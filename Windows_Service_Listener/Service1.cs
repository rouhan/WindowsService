using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Toolkit;

namespace Windows_Service_Listener
{
    public partial class Service1 : ServiceBase
    {
        private TCPServer server = null;

        public void RunService()
        {
            string[] test = { "hello", "world" };
            OnStart(test);
        }
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                LogHelper.Log("Starting Service");
                // Create the Server Object ans Start it.
                server = new TCPServer();
                server.CommandReceived += Server_CommandReceived;
                server.StartServer();
            }
            catch (Exception ex)
            {
                LogHelper.Log(ex.ToString());
            }
        }

        private void Server_CommandReceived(object sender, ExecuteCommandEventArgs e)
        {
            LogHelper.Log("Server_CommandReceived::"+e.Command);

            
            // windows service runs in isolation and cannot normally execute batch scripts or executables in the session of logged in user.
            // so the below ApplicationLoader class will identify the current user using winlogon and then execute programs in that session.

            LogHelper.Log("Starting process from windows service...");
            ApplicationLoader.PROCESS_INFORMATION procInfo;
            ApplicationLoader.StartProcessAndBypassUAC(e.Command, out procInfo);
        }

        protected override void OnStop()
        {
            // Stop the Server. Release it.
            server.StopServer();
            server = null;
        }
    }
}
