namespace Watermark.Forms
{
    partial class frmMark
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.lblHostname = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblEnterprise = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.lblAgent = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 4000;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTimeTick);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInfo.BackColor = System.Drawing.Color.White;
            this.pnlInfo.Controls.Add(this.lblHostname);
            this.pnlInfo.Controls.Add(this.lblIp);
            this.pnlInfo.Controls.Add(this.lblDate);
            this.pnlInfo.Controls.Add(this.lblEnterprise);
            this.pnlInfo.Controls.Add(this.lblDomain);
            this.pnlInfo.Controls.Add(this.lblAgent);
            this.pnlInfo.Controls.Add(this.lblLogin);
            this.pnlInfo.Location = new System.Drawing.Point(511, 247);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(222, 224);
            this.pnlInfo.TabIndex = 4;
            // 
            // lblHostname
            // 
            this.lblHostname.AutoSize = true;
            this.lblHostname.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblHostname.ForeColor = System.Drawing.Color.Black;
            this.lblHostname.Location = new System.Drawing.Point(14, 168);
            this.lblHostname.Name = "lblHostname";
            this.lblHostname.Size = new System.Drawing.Size(110, 20);
            this.lblHostname.TabIndex = 6;
            this.lblHostname.Text = "Nome do host:";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblIp.ForeColor = System.Drawing.Color.Black;
            this.lblIp.Location = new System.Drawing.Point(14, 142);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(30, 20);
            this.lblIp.TabIndex = 5;
            this.lblIp.Text = "IP: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(14, 116);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(132, 20);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Data Inicialização:";
            // 
            // lblEnterprise
            // 
            this.lblEnterprise.AutoSize = true;
            this.lblEnterprise.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblEnterprise.ForeColor = System.Drawing.Color.Black;
            this.lblEnterprise.Location = new System.Drawing.Point(14, 90);
            this.lblEnterprise.Name = "lblEnterprise";
            this.lblEnterprise.Size = new System.Drawing.Size(71, 20);
            this.lblEnterprise.TabIndex = 3;
            this.lblEnterprise.Text = "Empresa:";
            // 
            // lblDomain
            // 
            this.lblDomain.AutoSize = true;
            this.lblDomain.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblDomain.ForeColor = System.Drawing.Color.Black;
            this.lblDomain.Location = new System.Drawing.Point(14, 64);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(72, 20);
            this.lblDomain.TabIndex = 2;
            this.lblDomain.Text = "Dominio:";
            // 
            // lblAgent
            // 
            this.lblAgent.AutoSize = true;
            this.lblAgent.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblAgent.ForeColor = System.Drawing.Color.Black;
            this.lblAgent.Location = new System.Drawing.Point(14, 38);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(62, 20);
            this.lblAgent.TabIndex = 1;
            this.lblAgent.Text = "Agente:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.Black;
            this.lblLogin.Location = new System.Drawing.Point(14, 12);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(51, 20);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login:";
            // 
            // frmMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(745, 527);
            this.Controls.Add(this.pnlInfo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMark";
            this.Opacity = 0.15D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMark_FormClosing);
            this.Load += new System.EventHandler(this.frmMark_Load);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label lblHostname;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblEnterprise;
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblAgent;
        private System.Windows.Forms.Label lblLogin;
    }
}