using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jodie.Server;
using System.IO;
using System.Text.RegularExpressions;
using BeyondCore.Server;

namespace Jodie
{
  public partial class Form1 : Form
  {
    JodieServer server = new JodieServer();

    public Form1()
    {
      InitializeComponent();
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
      btnConnect.Text = "Conectado";
      btnConnect.Enabled = false;
      aidenAddress.Enabled = false;
      btnRefreshProcessList.Enabled = true;
      btnScreenshot.Enabled = true;

      server.Setup((string received) => {
        string[] processes = received.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);


        foreach (string p in processes) {
          //GroupCollection groups = Regex.Match(p, @"(.+)\s\(hWnd\:\s([0-9]+)\)", RegexOptions.IgnoreCase).Groups;
          //ListViewItem lvi = new ListViewItem(p);
          processList.Items.Add(new ListViewItem(p));
        }

        return 0;
      });
    }

    private void btnRefreshProcessList_Click(object sender, EventArgs e)
    {
      processList.Clear();
      server.Send((int)BeyondCore.Server.CommandType.ListProcesses);
    }

    private void btnScreenshot_Click(object sender, EventArgs e)
    {
      string param = "";

      if (processList.CheckedItems.Count > 0) {
        foreach (ListViewItem lvi in processList.CheckedItems) {
          GroupCollection groups = Regex.Match(lvi.Text, @"(.+)\s\(hWnd\:\s([0-9]+)\)", RegexOptions.IgnoreCase).Groups;

          server.Send(String.Format("{0} {1}", (int)BeyondCore.Server.CommandType.WindowScreenshot, groups[2]));
        }
      }
      else {
        server.Send((int)BeyondCore.Server.CommandType.WindowScreenshot);
      }
    }
  }
}
