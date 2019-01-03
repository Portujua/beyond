using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using BeyondCore.Server;

namespace Jodie.Server
{
  public class JodieServer : BeyondServer
  {
    public void Setup(Func<string, int> sendFunction)
    {
      this.__Setup(this.ProcessFn, sendFunction);
    }

    private int ProcessFn(StreamReader reader, StreamWriter writer)
    {
      return 0;
    }
  }
}
