namespace Ispoof_apka
{
	// Token: 0x02000004 RID: 4
	public partial class form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00002175 File Offset: 0x00000375
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002E70 File Offset: 0x00001070
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Ispoof_apka.form1));
			this.backgroundWorker_0 = new global::System.ComponentModel.BackgroundWorker();
			this.Spoofer = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2DragControl_0 = new global::Guna.UI2.WinForms.Guna2DragControl(this.icontainer_0);
			this.Accounts = new global::Guna.UI2.WinForms.Guna2Button();
			this.Settings = new global::Guna.UI2.WinForms.Guna2Button();
			this.mainpanel = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2HtmlLabel1 = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.mainpanel.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.backgroundWorker_0.DoWork += new global::System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_0_DoWork);
			this.Spoofer.BackColor = global::System.Drawing.Color.Transparent;
			this.Spoofer.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.Spoofer.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 4);
			this.Spoofer.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Spoofer.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Spoofer.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Spoofer.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Spoofer.FillColor = global::System.Drawing.Color.Transparent;
			this.Spoofer.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 11.25f);
			this.Spoofer.ForeColor = global::System.Drawing.Color.Indigo;
			this.Spoofer.HoverState.BorderColor = global::System.Drawing.Color.Cyan;
			this.Spoofer.HoverState.CustomBorderColor = global::System.Drawing.Color.Indigo;
			this.Spoofer.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.Spoofer.Location = new global::System.Drawing.Point(158, 0);
			this.Spoofer.Name = "Spoofer";
			this.Spoofer.Size = new global::System.Drawing.Size(136, 45);
			this.Spoofer.TabIndex = 0;
			this.Spoofer.Text = "Spoofer";
			this.Spoofer.Click += new global::System.EventHandler(this.Spoofer_Click);
			this.guna2DragControl_0.DockIndicatorTransparencyValue = 1.0;
			this.guna2DragControl_0.DragStartTransparencyValue = 1.0;
			this.guna2DragControl_0.TargetControl = this;
			this.guna2DragControl_0.UseTransparentDrag = true;
			this.Accounts.BackColor = global::System.Drawing.Color.Transparent;
			this.Accounts.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.Accounts.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 4);
			this.Accounts.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Accounts.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Accounts.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Accounts.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Accounts.FillColor = global::System.Drawing.Color.Transparent;
			this.Accounts.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 11.25f);
			this.Accounts.ForeColor = global::System.Drawing.Color.Indigo;
			this.Accounts.HoverState.BorderColor = global::System.Drawing.Color.Cyan;
			this.Accounts.HoverState.CustomBorderColor = global::System.Drawing.Color.Indigo;
			this.Accounts.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.Accounts.Location = new global::System.Drawing.Point(298, 0);
			this.Accounts.Name = "Accounts";
			this.Accounts.Size = new global::System.Drawing.Size(151, 45);
			this.Accounts.TabIndex = 1;
			this.Accounts.Text = "Socials";
			this.Accounts.Click += new global::System.EventHandler(this.Accounts_Click);
			this.Settings.BackColor = global::System.Drawing.Color.Transparent;
			this.Settings.CustomBorderColor = global::System.Drawing.Color.Transparent;
			this.Settings.CustomBorderThickness = new global::System.Windows.Forms.Padding(0, 0, 0, 4);
			this.Settings.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.Settings.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.Settings.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.Settings.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.Settings.FillColor = global::System.Drawing.Color.Transparent;
			this.Settings.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 11.25f);
			this.Settings.ForeColor = global::System.Drawing.Color.Indigo;
			this.Settings.HoverState.BorderColor = global::System.Drawing.Color.Cyan;
			this.Settings.HoverState.CustomBorderColor = global::System.Drawing.Color.Indigo;
			this.Settings.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.Settings.Location = new global::System.Drawing.Point(455, 0);
			this.Settings.Name = "Settings";
			this.Settings.Size = new global::System.Drawing.Size(132, 45);
			this.Settings.TabIndex = 2;
			this.Settings.Text = "Misc";
			this.Settings.Click += new global::System.EventHandler(this.Settings_Click);
			this.mainpanel.Controls.Add(this.pictureBox1);
			this.mainpanel.Location = new global::System.Drawing.Point(-3, 43);
			this.mainpanel.Name = "mainpanel";
			this.mainpanel.Size = new global::System.Drawing.Size(686, 352);
			this.mainpanel.TabIndex = 4;
			this.mainpanel.Paint += new global::System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
			this.pictureBox1.Location = new global::System.Drawing.Point(0, -32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(683, 396);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			this.guna2Button1.AutoRoundedCorners = true;
			this.guna2Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.BorderRadius = 12;
			this.guna2Button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.HoverState.FillColor = global::System.Drawing.Color.FromArgb(255, 51, 51);
			this.guna2Button1.ImageSize = new global::System.Drawing.Size(10, 10);
			this.guna2Button1.Location = new global::System.Drawing.Point(625, 9);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(40, 26);
			this.guna2Button1.TabIndex = 5;
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.guna2HtmlLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 11.25f);
			this.guna2HtmlLabel1.ForeColor = global::System.Drawing.SystemColors.ControlDark;
			this.guna2HtmlLabel1.Location = new global::System.Drawing.Point(43, 13);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new global::System.Drawing.Size(51, 22);
			this.guna2HtmlLabel1.TabIndex = 1;
			this.guna2HtmlLabel1.Text = "iTrash";
			this.guna2HtmlLabel1.Click += new global::System.EventHandler(this.guna2HtmlLabel1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.White;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			base.ClientSize = new global::System.Drawing.Size(674, 394);
			base.Controls.Add(this.guna2HtmlLabel1);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.mainpanel);
			base.Controls.Add(this.Settings);
			base.Controls.Add(this.Accounts);
			base.Controls.Add(this.Spoofer);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "form1";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "iTrash";
			base.Load += new global::System.EventHandler(this.form1_Load);
			this.mainpanel.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400000E RID: 14
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400000F RID: 15
		private global::System.ComponentModel.BackgroundWorker backgroundWorker_0;

		// Token: 0x04000010 RID: 16
		private global::Guna.UI2.WinForms.Guna2Button Spoofer;

		// Token: 0x04000011 RID: 17
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl_0;

		// Token: 0x04000012 RID: 18
		private global::Guna.UI2.WinForms.Guna2Button Settings;

		// Token: 0x04000013 RID: 19
		private global::Guna.UI2.WinForms.Guna2Button Accounts;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Panel mainpanel;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000016 RID: 22
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x04000017 RID: 23
		private global::Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
	}
}
