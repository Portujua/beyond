using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeyondCore.Server;

namespace Aiden.Server
{
  public class AidenServer : BeyondServer
  {
    public void Setup()
    {
      this.__Setup(this.ProcessFn, this.SendFn);
    }

    private int ProcessFn(StreamReader reader, StreamWriter writer)
    {
      string received = (string)reader.ReadLine();

      Console.WriteLine("Received: {0}", received);

      if (!received.Contains("Hello Jodie, I am")) {
        try {
          AidenCommand c = new AidenCommand(received);
          writer.WriteLine(c.execute());
        }
        catch (Exception ex) {
          writer.WriteLine(String.Format("Error executing the command: {0}{1}{2}", ex.Message, Environment.NewLine, ex.StackTrace));
        }
      }

      return 0;
    }

    private int SendFn(string received)
    {
      return 0;
    }
  }
}
