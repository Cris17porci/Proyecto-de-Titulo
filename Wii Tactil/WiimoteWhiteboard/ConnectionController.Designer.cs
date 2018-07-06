namespace WiimoteWhiteboard
{
    partial class ConnectionController
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
            this.gbConnectivity = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cbAutoConnect = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.pbConnecting = new System.Windows.Forms.ProgressBar();
            this.gbConnectivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnectivity
            // 
            this.gbConnectivity.Controls.Add(this.lblStatus);
            this.gbConnectivity.Controls.Add(this.cbAutoConnect);
            this.gbConnectivity.Controls.Add(this.btnConnect);
            this.gbConnectivity.Controls.Add(this.pbConnecting);
            this.gbConnectivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConnectivity.Location = new System.Drawing.Point(0, 0);
            this.gbConnectivity.Margin = new System.Windows.Forms.Padding(0);
            this.gbConnectivity.Name = "gbConnectivity";
            this.gbConnectivity.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbConnectivity.Size = new System.Drawing.Size(176, 182);
            this.gbConnectivity.TabIndex = 41;
            this.gbConnectivity.TabStop = false;
            this.gbConnectivity.Text = "Connectivity";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.DarkOrange;
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(4, 74);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(115, 30);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Control de Wii No Detectado";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbAutoConnect
            // 
            this.cbAutoConnect.AutoSize = true;
            this.cbAutoConnect.Checked = true;
            this.cbAutoConnect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoConnect.Location = new System.Drawing.Point(26, 54);
            this.cbAutoConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbAutoConnect.Name = "cbAutoConnect";
            this.cbAutoConnect.Size = new System.Drawing.Size(90, 17);
            this.cbAutoConnect.TabIndex = 6;
            this.cbAutoConnect.Text = "Autoconectar";
            this.cbAutoConnect.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(7, 22);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 28);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pbConnecting
            // 
            this.pbConnecting.Location = new System.Drawing.Point(7, 106);
            this.pbConnecting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbConnecting.Name = "pbConnecting";
            this.pbConnecting.Size = new System.Drawing.Size(112, 19);
            this.pbConnecting.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbConnecting.TabIndex = 4;
            // 
            // ConnectionController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbConnectivity);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ConnectionController";
            this.Size = new System.Drawing.Size(176, 182);
            this.gbConnectivity.ResumeLayout(false);
            this.gbConnectivity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnectivity;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox cbAutoConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ProgressBar pbConnecting;
    }
}
