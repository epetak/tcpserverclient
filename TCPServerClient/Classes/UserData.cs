using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TCPServerClient.Classes
{
    public interface UserData
    {
        string Name { get; set; }
        IPAddress IpAddress { get; set; }
        int Port { get; set; }

        public IPEndPoint getIPEndPoint();
        public string getIpAddress();
    }

    public class User : UserData
    {
        public string Name { get; set; }
        public IPAddress IpAddress { get; set; }
        public int Port { get; set; }

        public User(string name)
        {
            Name = name;
            IpAddress = Dns.GetHostAddresses(Dns.GetHostName())[1];
            Port = 4949;
        }

        public IPEndPoint getIPEndPoint()
        {
            return new IPEndPoint(IpAddress, Port);
        }

        public string getIpAddress()
        {
            return IpAddress.ToString();
        }

    }
}
