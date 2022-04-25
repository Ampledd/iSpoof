namespace Ispoof_apka
{
	// Token: 0x02000009 RID: 9
	public partial class Settings : global::System.Windows.Forms.Form
	{
		// Token: 0x06000054 RID: 84 RVA: 0x000022E2 File Offset: 0x000004E2
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000497C File Offset: 0x00002B7C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Ispoof_apka.Settings));
			this.guna2HtmlLabel1 = new global::Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.guna2GradientButton1 = new global::Guna.UI2.WinForms.Guna2GradientButton();
			base.SuspendLayout();
			this.guna2HtmlLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2HtmlLabel1.Font = new global::System.Drawing.Font("Microsoft YaHei", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.guna2HtmlLabel1.Location = new global::System.Drawing.Point(35, 37);
			this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
			this.guna2HtmlLabel1.Size = new global::System.Drawing.Size(86, 21);
			this.guna2HtmlLabel1.TabIndex = 2;
			this.guna2HtmlLabel1.Text = "HWID: invalid";
			this.guna2HtmlLabel1.Click += new global::System.EventHandler(this.guna2HtmlLabel1_Click);
			this.guna2Button1.Animated = true;
			this.guna2Button1.BorderRadius = 7;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.Location = new global::System.Drawing.Point(35, 64);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new global::System.Drawing.Size(58, 21);
			this.guna2Button1.TabIndex = 3;
			this.guna2Button1.Text = "copy";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.guna2Button2.Animated = true;
			this.guna2Button2.BorderRadius = 7;
			this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button2.Location = new global::System.Drawing.Point(105, 64);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new global::System.Drawing.Size(63, 21);
			this.guna2Button2.TabIndex = 4;
			this.guna2Button2.Text = "refresh";
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new global::System.Drawing.Point(571, 272);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(40, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Team :";
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new global::System.Drawing.Point(574, 287);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(89, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "mlody braili#0254";
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new global::System.Drawing.Point(574, 301);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(83, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "szefuncio#1939";
			this.label4.AutoSize = true;
			this.label4.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Location = new global::System.Drawing.Point(574, 316);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(79, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "sandauu#1312";
			this.guna2GradientButton1.Animated = true;
			this.guna2GradientButton1.AutoRoundedCorners = true;
			this.guna2GradientButton1.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.guna2GradientButton1.BorderRadius = 20;
			this.guna2GradientButton1.BorderThickness = 1;
			this.guna2GradientButton1.CustomImages.ImageOffset = new global::System.Drawing.Point(13, -1);
			this.guna2GradientButton1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2GradientButton1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton1.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2GradientButton1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2GradientButton1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2GradientButton1.ForeColor = global::System.Drawing.Color.White;
			this.guna2GradientButton1.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.guna2GradientButton1.Location = new global::System.Drawing.Point(27, 280);
			this.guna2GradientButton1.Name = "guna2GradientButton1";
			this.guna2GradientButton1.Size = new global::System.Drawing.Size(180, 43);
			this.guna2GradientButton1.TabIndex = 53;
			this.guna2GradientButton1.Text = "Disable BG Aps";
			this.guna2GradientButton1.Click += new global::System.EventHandler(this.guna2GradientButton1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 450);
			base.Controls.Add(this.guna2GradientButton1);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.guna2Button2);
			base.Controls.Add(this.guna2Button1);
			base.Controls.Add(this.guna2HtmlLabel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Settings";
			this.Text = "iSpoof";
			base.Load += new global::System.EventHandler(this.Settings_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000030 RID: 48
		private global::System.ComponentModel.IContainer icontainer_0 = null;

		// Token: 0x04000031 RID: 49
		private global::Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;

		// Token: 0x04000032 RID: 50
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;

		// Token: 0x04000033 RID: 51
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000038 RID: 56
		private global::Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
	}
}
