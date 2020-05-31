using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Service_Listener
{
    public class ExecuteCommandEventArgs : EventArgs
    {
        public string Command { get; set; }
    }
}
