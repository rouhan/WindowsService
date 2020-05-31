namespace Windows_Service_Listener
{
    partial class Installer1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TCPServiceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.TCPServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // TCPServiceProcessInstaller
            // 
            this.TCPServiceProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.TCPServiceProcessInstaller.Password = null;
            this.TCPServiceProcessInstaller.Username = null;
            this.TCPServiceProcessInstaller.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.TCPServiceProcessInstaller_AfterInstall);
            // 
            // TCPServiceInstaller
            // 
            this.TCPServiceInstaller.DisplayName = "TCP";
            this.TCPServiceInstaller.ServiceName = "TCPService";
            // 
            // Installer1
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.TCPServiceProcessInstaller,
            this.TCPServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller TCPServiceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller TCPServiceInstaller;
    }
}