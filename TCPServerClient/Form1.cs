using TCPServerClient.Classes;
using TCPServerClient;
using TCPServerClient.Forms;
using System.Net;

namespace TCPServerClient
{
    public partial class Form1 : Form
    {
        private UserData AppUser;
        private SCSocket ServerClient;


        public Form1()
        {
            InitializeComponent();
            AppUser= new User("Monkey");
            ServerClient = new ServerClientSocket(AppUser, this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(AppUser == null)
            {
                Application.Exit();
            }
            setUserData();
        }

        //SETTING DATA -----
        private void setUserData()
        {
            userName.Text = AppUser.Name;
            userPort.Text = AppUser.Port.ToString();
            userIpAddress.Text = AppUser.getIpAddress();
        }
        public void enableButtonsServer()
        {
            groupBoxClient.Enabled = false;
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
        }
        public void disableButtonsServer()
        {
            groupBoxClient.Enabled = true;
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
        }
        public void enableButtonsClient()
        {
            groupBoxServer.Enabled = false;
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
        }
        public void disableButtonsClient()
        {
            groupBoxServer.Enabled = true;
            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
        }
        public void writeNotification(string notification)
        {
            txtBoxMessages.Invoke(new MethodInvoker(delegate ()
            {
                txtBoxMessages.AppendText(notification + Environment.NewLine);
            }));
        }
        public void writeMessage(string message)
        {
            txtBoxMessages.Invoke(new MethodInvoker(delegate ()
            {
                txtBoxMessages.AppendText(message);
                txtBoxMessages.AppendText(Environment.NewLine);
            }));
        }

        public void automaticStopServer()
        {
            btnStopServer.Invoke(new MethodInvoker(delegate ()
            {
                btnStopServer.PerformClick();
            }));
        }
        public void automaticStopClient()
        {
            btnDisconnect.Invoke(new MethodInvoker(delegate ()
            {
                btnDisconnect.PerformClick();
            }));
        }

        //BUTTONS CLICK -----
        private void btnChangePresets_Click(object sender, EventArgs e)
        {
            ChangePresets newForm = new ChangePresets(AppUser);
            newForm.ShowDialog();
            setUserData();
            ServerClient.setUser(AppUser);
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            ServerClient.startServer();
            enableButtonsServer();
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            ServerClient.stopServer();
            disableButtonsServer();
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            ServerClient.sendMessage(txtBoxUserMessage.Text);
            txtBoxUserMessage.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(txtBoxIpAddressClient.Text.Length > 7 && txtBoxPortClient.Text.Length > 3)
            {
                enableButtonsClient();
                ServerClient.connectToServer(txtBoxIpAddressClient.Text, int.Parse(txtBoxPortClient.Text));
            }
            else
            {
                MessageBox.Show("Wrong IPAddress or port!");
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            ServerClient.stopServer();
            disableButtonsClient();
        }
    }
}