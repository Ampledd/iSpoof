namespace Ispoof_apka
{
	// Token: 0x02000005 RID: 5
	public partial class Form2 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00002201 File Offset: 0x00000401
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000039A8 File Offset: 0x00001BA8
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Ispoof_apka.Form2));
			this.guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.mainpanel = new global::System.Windows.Forms.Panel();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.password = new global::System.Windows.Forms.TextBox();
			this.username = new global::System.Windows.Forms.TextBox();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.panel4 = new global::System.Windows.Forms.Panel();
			this.guna2DragControl_0 = new global::Guna.UI2.WinForms.Guna2DragControl(this.icontainer_0);
			this.guna2Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.mainpanel.SuspendLayout();
			base.SuspendLayout();
			this.guna2Panel1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Panel1.BackgroundImage");
			this.guna2Panel1.Controls.Add(this.guna2Button1);
			this.guna2Panel1.Controls.Add(this.pictureBox1);
			this.guna2Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new global::System.Drawing.Size(276, 173);
			this.guna2Panel1.TabIndex = 0;
			this.guna2Panel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
			this.guna2Button1.AutoRoundedCorners = true;
			this.guna2Button1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.BorderRadius = 9;
			this.guna2Button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.Transparent;
			this.guna2Button1.HoverState.FillColor = global::System.Drawing.Color.FromArgb(255, 51, 51);
			this.guna2Button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("guna2Button1.Image");
			this.guna2Button1.ImageSize = new global::System.Drawing.Size(10, 10);
			this.guna2Button1.Location = new global::System.Drawing.Point(245, 8);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(25, 20);
			this.guna2Button1.TabIndex = 4;
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.pictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(22, 39);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(233, 95);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.mainpanel.Controls.Add(this.guna2Button2);
			this.mainpanel.Controls.Add(this.label2);
			this.mainpanel.Controls.Add(this.label1);
			this.mainpanel.Controls.Add(this.password);
			this.mainpanel.Controls.Add(this.username);
			this.mainpanel.Controls.Add(this.panel3);
			this.mainpanel.Controls.Add(this.panel4);
			this.mainpanel.Location = new global::System.Drawing.Point(0, 172);
			this.mainpanel.Name = "mainpanel";
			this.mainpanel.Size = new global::System.Drawing.Size(276, 255);
			this.mainpanel.TabIndex = 1;
			this.mainpanel.Paint += new global::System.Windows.Forms.PaintEventHandler(this.mainpanel_Paint);
			this.guna2Button2.Animated = true;
			this.guna2Button2.AutoRoundedCorners = true;
			this.guna2Button2.BorderRadius = 21;
			this.guna2Button2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.FillColor = global::System.Drawing.Color.FromArgb(73, 192, 255);
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button2.Location = new global::System.Drawing.Point(48, 178);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new global::System.Drawing.Size(180, 45);
			this.guna2Button2.TabIndex = 30;
			this.guna2Button2.Text = "Login";
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label2.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new global::System.Drawing.Point(29, 99);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(61, 15);
			this.label2.TabIndex = 29;
			this.label2.Text = "Password";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new global::System.Drawing.Point(29, 29);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(62, 15);
			this.label1.TabIndex = 28;
			this.label1.Text = "Username";
			this.password.BackColor = global::System.Drawing.SystemColors.Control;
			this.password.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.password.Font = new global::System.Drawing.Font("Calibri", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.password.Location = new global::System.Drawing.Point(32, 117);
			this.password.Name = "password";
			this.password.Size = new global::System.Drawing.Size(215, 19);
			this.password.TabIndex = 27;
			this.password.UseSystemPasswordChar = true;
			this.username.BackColor = global::System.Drawing.SystemColors.Control;
			this.username.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.username.Font = new global::System.Drawing.Font("Calibri", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.username.Location = new global::System.Drawing.Point(32, 47);
			this.username.Name = "username";
			this.username.Size = new global::System.Drawing.Size(215, 19);
			this.username.TabIndex = 26;
			this.panel3.BackColor = global::System.Drawing.SystemColors.AppWorkspace;
			this.panel3.Location = new global::System.Drawing.Point(32, 136);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(215, 1);
			this.panel3.TabIndex = 25;
			this.panel4.BackColor = global::System.Drawing.SystemColors.AppWorkspace;
			this.panel4.Location = new global::System.Drawing.Point(32, 66);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(215, 1);
			this.panel4.TabIndex = 24;
			this.guna2DragControl_0.DockIndicatorTransparencyValue = 1.0;
			this.guna2DragControl_0.DragStartTransparencyValue = 1.0;
			this.guna2DragControl_0.TargetControl = this.guna2Panel1;
			this.guna2DragControl_0.UseTransparentDrag = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(276, 439);
			base.Controls.Add(this.mainpanel);
			base.Controls.Add(this.guna2Panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form2";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "iSpoof";
			base.Load += new global::System.EventHandler(this.Form2_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.mainpanel.ResumeLayout(false);
			this.mainpanel.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400001B RID: 27
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400001C RID: 28
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;

		// Token: 0x0400001D RID: 29
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.Panel mainpanel;

		// Token: 0x04000020 RID: 32
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.TextBox password;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.TextBox username;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x04000027 RID: 39
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl_0;
	}
}
