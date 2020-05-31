1. Compile the code on VS 2015
2. Install the windows service using installutil

"C:\Windows\Microsoft.NET\Framework\v4.0.30319\installutil.exe" "C:\Users\gr8_a\Documents\Visual Studio 2015\Projects\Windows_Service_Listener\Windows_Service_Listener\bin\Debug\Windows_Service_Listener.exe"

3. go to start and type services.msc and find "TCP" and start it.
4. It will create some logs in bin/debug/logs  
5. Open telnet and connect it to 127.0.0.1 31002 or connect a tcp channel.
6. Use commands like
	"D:\hello.bat"
	"cmd.exe"
	"mspaint.exe"

7. The programs will be opened.