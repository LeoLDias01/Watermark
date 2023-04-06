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
    public partial class frmMark : Form
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
        #endregion

        #region ..:: Constructor ::..

        public frmMark()
        {
            InitializeComponent();
            SetttingValuesToVariables();
        }

        #endregion

        #region ..:: Params ::..

        /// <summary>
        /// When Screen has been activated, mouse cannot block 
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= CONST_PASS_THROUGH_MOUSE;
                return cp;
            }
        }

        #endregion

        #region ..:: Events ::..

        private void frmMark_FormClosing(object sender, FormClosingEventArgs e)
        {
            CancelAppFinalization(ref e);
        }

        private void frmMark_Load(object sender, EventArgs e)
        {
            DefineWatermarkValues();
            tmrTime.Start();
        }
        private void tmrTimeTick(object sender, EventArgs e)
        {
            DefineWatermarkValues();
        }

        #endregion

        #region ..:: General Methods ::..
        private void SetttingValuesToVariables()
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
        private void DefineWatermarkValues()
        {
            lblLogin.Text = userName;
            lblAgent.Text = userFullName;
            lblDomain.Text = netWorkDomainName;
            lblEnterprise.Text = userDomainName;
            lblDate.Text = actualDate;
            lblIp.Text = localIp;
            lblHostname.Text = hostName;
        }
        private void CancelAppFinalization(ref FormClosingEventArgs e)
        {
            e.Cancel = true;
        }
        #endregion
    }
}
