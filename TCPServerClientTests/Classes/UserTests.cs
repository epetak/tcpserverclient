using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCPServerClient.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using TCPServerClient.Forms;

namespace TCPServerClient.Classes.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void getIpAddressAndPortTest()
        {
            User user = new User("Monkey");
            IPAddress ipAddr = Dns.GetHostAddresses(Dns.GetHostName())[1];
           
            Assert.IsTrue(ipAddr.ToString() == user.IpAddress.ToString() && 4949 == user.Port && user.Name == "Monkey");
        }

        [TestMethod()]
        public void changeUserPresets()
        {
            UserData User = new User("Monkey");
            ChangePresets Form = new ChangePresets(User);
            Form.ShowDialog();

            Assert.IsTrue(User.Name == "Monkey2");
        }

    }
}