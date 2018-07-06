namespace WiimoteWhiteboard
{
	partial class WiimoteMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WiimoteMainForm));
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMainControls = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pbBattery = new System.Windows.Forms.ProgressBar();
            this.lblBattery = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPoint4 = new System.Windows.Forms.Label();
            this.lblPoint3 = new System.Windows.Forms.Label();
            this.lblPoint2 = new System.Windows.Forms.Label();
            this.lblPoint1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSmoothingLevel = new System.Windows.Forms.TrackBar();
            this.cbCursorControl = new System.Windows.Forms.CheckBox();
            this.cbAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.btnCalibrate = new System.Windows.Forms.Button();
            this.pbTrackingLayout = new System.Windows.Forms.PictureBox();
            this.ConnectionControl = new WiimoteWhiteboard.ConnectionController();
            this.flowLayoutPanel2.SuspendLayout();
            this.pnlMainControls.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmoothingLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrackingLayout)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.ConnectionControl);
            this.flowLayoutPanel2.Controls.Add(this.pnlMainControls);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(137, 283);
            this.flowLayoutPanel2.TabIndex = 37;
            // 
            // pnlMainControls
            // 
            this.pnlMainControls.Controls.Add(this.groupBox2);
            this.pnlMainControls.Controls.Add(this.groupBox1);
            this.pnlMainControls.Controls.Add(this.cbCursorControl);
            this.pnlMainControls.Controls.Add(this.cbAlwaysOnTop);
            this.pnlMainControls.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlMainControls.Location = new System.Drawing.Point(0, 125);
            this.pnlMainControls.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMainControls.Name = "pnlMainControls";
            this.pnlMainControls.Size = new System.Drawing.Size(134, 378);
            this.pnlMainControls.TabIndex = 41;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbBattery);
            this.groupBox4.Controls.Add(this.lblBattery);
            this.groupBox4.Location = new System.Drawing.Point(153, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(124, 46);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bateria";
            // 
            // pbBattery
            // 
            this.pbBattery.Location = new System.Drawing.Point(8, 20);
            this.pbBattery.Name = "pbBattery";
            this.pbBattery.Size = new System.Drawing.Size(71, 14);
            this.pbBattery.Step = 1;
            this.pbBattery.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbBattery.TabIndex = 6;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Location = new System.Drawing.Point(86, 20);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(33, 13);
            this.lblBattery.TabIndex = 9;
            this.lblBattery.Text = "100%";
            this.lblBattery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPoint4);
            this.groupBox2.Controls.Add(this.lblPoint3);
            this.groupBox2.Controls.Add(this.lblPoint2);
            this.groupBox2.Controls.Add(this.lblPoint1);
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(124, 38);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IR Visibles";
            // 
            // lblPoint4
            // 
            this.lblPoint4.AutoSize = true;
            this.lblPoint4.Font = new System.Drawing.Font("Wingdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPoint4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPoint4.Location = new System.Drawing.Point(78, 15);
            this.lblPoint4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoint4.Name = "lblPoint4";
            this.lblPoint4.Size = new System.Drawing.Size(17, 15);
            this.lblPoint4.TabIndex = 32;
            this.lblPoint4.Text = "l";
            this.lblPoint4.Visible = false;
            // 
            // lblPoint3
            // 
            this.lblPoint3.AutoSize = true;
            this.lblPoint3.Font = new System.Drawing.Font("Wingdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPoint3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPoint3.Location = new System.Drawing.Point(57, 15);
            this.lblPoint3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoint3.Name = "lblPoint3";
            this.lblPoint3.Size = new System.Drawing.Size(17, 15);
            this.lblPoint3.TabIndex = 31;
            this.lblPoint3.Text = "l";
            this.lblPoint3.Visible = false;
            // 
            // lblPoint2
            // 
            this.lblPoint2.AutoSize = true;
            this.lblPoint2.Font = new System.Drawing.Font("Wingdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPoint2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPoint2.Location = new System.Drawing.Point(36, 15);
            this.lblPoint2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoint2.Name = "lblPoint2";
            this.lblPoint2.Size = new System.Drawing.Size(17, 15);
            this.lblPoint2.TabIndex = 30;
            this.lblPoint2.Text = "l";
            this.lblPoint2.Visible = false;
            // 
            // lblPoint1
            // 
            this.lblPoint1.AutoSize = true;
            this.lblPoint1.Font = new System.Drawing.Font("Wingdings", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblPoint1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblPoint1.Location = new System.Drawing.Point(15, 15);
            this.lblPoint1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPoint1.Name = "lblPoint1";
            this.lblPoint1.Size = new System.Drawing.Size(17, 15);
            this.lblPoint1.TabIndex = 29;
            this.lblPoint1.Text = "l";
            this.lblPoint1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSmoothingLevel);
            this.groupBox1.Location = new System.Drawing.Point(2, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(124, 64);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Suavidad";
            // 
            // tbSmoothingLevel
            // 
            this.tbSmoothingLevel.Location = new System.Drawing.Point(8, 16);
            this.tbSmoothingLevel.Margin = new System.Windows.Forms.Padding(2);
            this.tbSmoothingLevel.Maximum = 50;
            this.tbSmoothingLevel.Name = "tbSmoothingLevel";
            this.tbSmoothingLevel.Size = new System.Drawing.Size(105, 45);
            this.tbSmoothingLevel.TabIndex = 32;
            this.tbSmoothingLevel.TickFrequency = 5;
            this.tbSmoothingLevel.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.tbSmoothingLevel.Value = 8;
            // 
            // cbCursorControl
            // 
            this.cbCursorControl.AutoSize = true;
            this.cbCursorControl.Location = new System.Drawing.Point(2, 112);
            this.cbCursorControl.Margin = new System.Windows.Forms.Padding(2);
            this.cbCursorControl.Name = "cbCursorControl";
            this.cbCursorControl.Size = new System.Drawing.Size(111, 17);
            this.cbCursorControl.TabIndex = 42;
            this.cbCursorControl.Text = "Control Del Cursor";
            this.cbCursorControl.UseVisualStyleBackColor = true;
            // 
            // cbAlwaysOnTop
            // 
            this.cbAlwaysOnTop.AutoSize = true;
            this.cbAlwaysOnTop.Checked = true;
            this.cbAlwaysOnTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlwaysOnTop.Location = new System.Drawing.Point(2, 133);
            this.cbAlwaysOnTop.Margin = new System.Windows.Forms.Padding(2);
            this.cbAlwaysOnTop.Name = "cbAlwaysOnTop";
            this.cbAlwaysOnTop.Size = new System.Drawing.Size(97, 17);
            this.cbAlwaysOnTop.TabIndex = 43;
            this.cbAlwaysOnTop.Text = "Siempre Visible";
            this.cbAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // btnCalibrate
            // 
            this.btnCalibrate.Location = new System.Drawing.Point(153, 220);
            this.btnCalibrate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalibrate.Name = "btnCalibrate";
            this.btnCalibrate.Size = new System.Drawing.Size(124, 52);
            this.btnCalibrate.TabIndex = 44;
            this.btnCalibrate.Text = "Area de Calibración (Precionar A en el Wiimote A)";
            this.btnCalibrate.Click += new System.EventHandler(this.btnCalibrate_Click_1);
            // 
            // pbTrackingLayout
            // 
            this.pbTrackingLayout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbTrackingLayout.Location = new System.Drawing.Point(136, 53);
            this.pbTrackingLayout.Margin = new System.Windows.Forms.Padding(2);
            this.pbTrackingLayout.Name = "pbTrackingLayout";
            this.pbTrackingLayout.Size = new System.Drawing.Size(181, 152);
            this.pbTrackingLayout.TabIndex = 45;
            this.pbTrackingLayout.TabStop = false;
            // 
            // ConnectionControl
            // 
            this.ConnectionControl.Location = new System.Drawing.Point(2, 2);
            this.ConnectionControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConnectionControl.Name = "ConnectionControl";
            this.ConnectionControl.Size = new System.Drawing.Size(124, 121);
            this.ConnectionControl.TabIndex = 42;
            this.ConnectionControl.Load += new System.EventHandler(this.ConnectionControl_Load);
            // 
            // WiimoteMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(336, 287);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.pbTrackingLayout);
            this.Controls.Add(this.btnCalibrate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WiimoteMainForm";
            this.Text = "Proyecto Pizarra Tactil Arquitectura";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.pnlMainControls.ResumeLayout(false);
            this.pnlMainControls.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbSmoothingLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTrackingLayout)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel pnlMainControls;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar pbBattery;
        private System.Windows.Forms.Label lblBattery;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPoint4;
        private System.Windows.Forms.Label lblPoint3;
        private System.Windows.Forms.Label lblPoint2;
        private System.Windows.Forms.Label lblPoint1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar tbSmoothingLevel;
        private System.Windows.Forms.CheckBox cbCursorControl;
        private System.Windows.Forms.CheckBox cbAlwaysOnTop;
        private System.Windows.Forms.Button btnCalibrate;
        private System.Windows.Forms.PictureBox pbTrackingLayout;
        private ConnectionController ConnectionControl;


    }
}

