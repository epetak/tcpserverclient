using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPServerClient.Classes
{
    public interface SCSocket
    {
        public void setUser(UserData user);
        public void startServer();
        public void stopServer();
        public void sendMessage(string message);
        public void connectToServer(string ipAddress, int port);
        
    }
    public class ServerClientSocket : SCSocket
    {
        public Socket Server;
        public Socket Client;
        private UserData User;
        private Form1 MainForm;

        public ServerClientSocket(UserData user, Form1 mainForm)
        {
            Server = Client = new Socket(user.IpAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            User = user;
            MainForm = mainForm;
        }

        public void setUser(UserData user)
        {
            User = user;
        }
        //SERVER -----
        public void stopServer()
        {
            MainForm.writeNotification("Server closed!");
            serverClientDispose();
        }
        public void startServer()
        {
            Server.Bind(User.getIPEndPoint());
            Server.Listen();
            MainForm.writeNotification("Starting Server");
            Thread ListeningThread = new Thread(acceptClient);
            ListeningThread.Start();
        }
        private void acceptClient()
        {
            try
            {
                MainForm.writeNotification("Waiting for connection...");
                Client = Server.Accept();
                MainForm.writeNotification("Connected!");
                listening();
            }catch(Exception ex)
            {
                if(ex is SocketException)
                {
                    serverClientDispose();
                }
                else
                {
                    MainForm.writeNotification(ex.ToString());
                    serverClientDispose();
                }
            }
        }

        // CLIENT
        public void connectToServer(string ipAddress, int port)
        {
            var thread = new Thread(() =>
            {
                try
                {
                    Server.Connect(ipAddress, port);
                    Client = Server;
                    MainForm.writeNotification("Connected!");
                    listening();
                }
                catch (Exception ex)
                {
                    MainForm.writeNotification(ex.ToString());
                    MainForm.automaticStopClient();
                }
            });
            thread.Start();
        }

        private void listening()
        {
            try
            {
                while (true)
                {
                    byte[] buffer = new byte[1024];
                    Client.Receive(buffer);
                    string recivedMessage = Encoding.UTF8.GetString(buffer);
                    MainForm.writeMessage(recivedMessage);
                }
            }
            catch(Exception ex)
            {
                if(ex is SocketException)
                {
                    serverClientDispose();
                }
                else
                {
                    MainForm.writeNotification(ex.ToString());
                    serverClientDispose();
                }
            }
        }

        private void serverClientDispose()
        {
            Server.Close();
            Client.Close();
            Server.Dispose();
            Client.Dispose();
            Server = Client = new Socket(User.IpAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        }

        public void sendMessage(string msg)
        {
            string message = User.Name + ": " + msg;
            try
            {
                byte[] buffer = new byte[1024];
                buffer = Encoding.UTF8.GetBytes(message);
                Client.Send(buffer);
                MainForm.writeMessage("You: "+msg);
            }
            catch
            {
                MainForm.writeNotification("No connection!");
                MainForm.automaticStopServer();
                MainForm.automaticStopClient();
            }
        }


    }
}
