using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BeyondCore.Server
{
  public class BeyondServer
  {
    // Server address
    public static string JODIE = "127.0.0.1";
    public static int JODIE_PORT = 19500;

    Thread t;
    TcpListener listener;
    TcpClient client;
    string localIP;
    string ipAddress = BeyondServer.JODIE;
    int port = BeyondServer.JODIE_PORT;

    Func<StreamReader, StreamWriter, int> processFunction;
    Func<string, int> sendFunction;

    public BeyondServer()
    {
    }

    public void Greet()
    {
      // Get my IP
      using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0)) {
        socket.Connect("8.8.8.8", 65530);
        IPEndPoint endpoint = socket.LocalEndPoint as IPEndPoint;
        localIP = endpoint.Address.ToString();
      }

      // Greet Jodie
      this.Send(String.Format("Hello Jodie, I am {0}", localIP));
    }

    public void __Setup(Func<StreamReader, StreamWriter, int> processFunction = null, Func<string, int> sendFunction = null)
    {
      this.processFunction = processFunction;
      this.sendFunction = sendFunction;
      t = new Thread(__Start);
      t.IsBackground = true;
    }

    public void Start(string ipAddress = null, int port = -1)
    {
      if (ipAddress != null) {
        this.ipAddress = ipAddress;
      }

      if (port != -1) {
        this.port = port;
      }

      t.Start();
    }

    public void __Start()
    {
      listener = null;

      try {
        listener = new TcpListener(IPAddress.Parse(this.ipAddress), this.port);
        listener.Start();

        while (true) {
          TcpClient client = listener.AcceptTcpClient();
          Thread t = new Thread(ProcessRequests);
          t.Start(client);
        }
      }
      catch (Exception ex) {
        Console.WriteLine(ex.Message);
      }
    }

    public void ProcessRequests(object argument)
    {
      TcpClient client = (TcpClient)argument;

      try {
        StreamReader reader = new StreamReader(client.GetStream());
        StreamWriter writer = new StreamWriter(client.GetStream());

        this.processFunction(reader, writer);

        writer.Close();
        reader.Close();
      }
      catch (Exception) {

      }
      finally {
        client.Close();
      }
    }

    public void Send(object command)
    {
      client = new TcpClient(this.ipAddress, this.port);

      StreamReader reader = new StreamReader(client.GetStream());
      StreamWriter writer = new StreamWriter(client.GetStream());

      writer.WriteLine(command);
      writer.Flush();

      this.sendFunction(reader.ReadToEnd());

      /*string answer = reader.ReadToEnd();

      if (!String.IsNullOrEmpty(answer) && !String.IsNullOrWhiteSpace(answer)) {
        Console.WriteLine("Aiden said: {0}{1}", Environment.NewLine, answer);
      }*/

      writer.Close();
      reader.Close();
      client.Close();
    }
  }
}
