using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watermark.Forms
{
    public partial class frmMenu : Form
    {
        #region ..:: Variables ::..
        public string userName;
        public string userFullName;
        public string netWorkDomainName;
        public string userDomainName;
        public string actualDate;
        public string localIp;
        public string hostName;
        #endregion

        #region ..:: Constraints ::..
        public const int CONST_PASS_THROUGH_MOUSE = 0x20;
        public const int CONST_DIVISION_SIZE = 23;
        public const int CONST_WINDOW_WIDTH = 700;
        public const int CONST_WINDOW_HEIGHT = 20;
        public const int CONST_WINDOW_X_POSITION = 100;
        public const int CONST_WINDOW_Y_POSITION = 80;
        #endregion

        public frmMenu()
        {
            InitializeComponent();
            SetttingValues();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            DefinirValoresMarcaDagua();
            tmrHorario.Start();
        }
        private void SetttingValues()
        {
            userName = Environment.UserName; ;
            userFullName = GetUserFullName();
            netWorkDomainName = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            userDomainName = Environment.UserDomainName; ;
            actualDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            localIp = GetLocalIp();
            hostName = Dns.GetHostName(); ;

    }
        public static string GetUserFullName()
        {
            string domainUser = WindowsIdentity.GetCurrent().Name.Replace(@"\", "/");
            DirectoryEntry adEntry = new DirectoryEntry("WinNT://" + domainUser);
            string fullName = adEntry.Properties["FullName"].Value.ToString();
            return fullName;
        }
        public static string GetLocalIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "0.0.0.0";
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= CONST_PASS_THROUGH_MOUSE;
                return cp;
            }
        }
        private void DefinirValoresMarcaDagua()
        {
            if (flpTexto.Controls.Count > 0) flpTexto.Controls.Clear();

            actualDate = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            for (int i = 0; i < this.Width / CONST_DIVISION_SIZE; i++)
            {
                Label label = new Label
                {
                    Text = userName
                + " \n " + userFullName
                + " \n " + netWorkDomainName
                + " \n " + userDomainName
                + " \n " + actualDate
                + " \n " + localIp
                + " \n " + hostName,

                    Size = new Size(CONST_WINDOW_WIDTH, CONST_WINDOW_HEIGHT),
                    AutoSize = true,
                    Location = new Point(CONST_WINDOW_X_POSITION, i * CONST_WINDOW_Y_POSITION)
                };

                for (int counter = 0; counter < 1; counter++)
                {
                    flpTexto.Controls.Add(label);
                }
            }
        }
        private void CancelarFinalizacaoAplicacao(ref FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            CancelarFinalizacaoAplicacao(ref e);
        }

        private void tmrHorario_Tick(object sender, EventArgs e)
        {
            DefinirValoresMarcaDagua();
        }
    }
}
