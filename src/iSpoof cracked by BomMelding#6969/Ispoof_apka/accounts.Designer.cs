namespace Ispoof_apka
{
	// Token: 0x02000003 RID: 3
	public partial class accounts : global::System.Windows.Forms.Form
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002121 File Offset: 0x00000321
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000029CC File Offset: 0x00000BCC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Ispoof_apka.accounts));
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button3 = new global::Guna.UI2.WinForms.Guna2Button();
			base.SuspendLayout();
			this.guna2Button2.Animated = true;
			this.guna2Button2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.guna2Button2.BorderRadius = 20;
			this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 21.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button2.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button2.ImageOffset = new global::System.Drawing.Point(5, 0);
			this.guna2Button2.ImageSize = new global::System.Drawing.Size(45, 45);
			this.guna2Button2.Location = new global::System.Drawing.Point(87, 59);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new global::System.Drawing.Size(506, 70);
			this.guna2Button2.TabIndex = 47;
			this.guna2Button2.Text = "Discord";
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button2_Click);
			this.guna2Button3.Animated = true;
			this.guna2Button3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.guna2Button3.BorderRadius = 20;
			this.guna2Button3.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button3.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button3.FillColor = global::System.Drawing.Color.FromArgb(248, 170, 23);
			this.guna2Button3.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 21.75f);
			this.guna2Button3.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button3.ImageAlign = global::System.Windows.Forms.HorizontalAlignment.Left;
			this.guna2Button3.ImageOffset = new global::System.Drawing.Point(5, 0);
			this.guna2Button3.ImageSize = new global::System.Drawing.Size(42, 42);
			this.guna2Button3.Location = new global::System.Drawing.Point(87, 208);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new global::System.Drawing.Size(506, 70);
			this.guna2Button3.TabIndex = 49;
			this.guna2Button3.Text = "Rockstar Accouts";
			this.guna2Button3.Click += new global::System.EventHandler(this.guna2Button3_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(676, 352);
			base.Controls.Add(this.guna2Button3);
			base.Controls.Add(this.guna2Button2);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "accounts";
			this.Text = "iSpoof";
			base.ResumeLayout(false);
		}

		// Token: 0x04000009 RID: 9
		private global::System.ComponentModel.IContainer icontainer_0 = null;

		// Token: 0x0400000A RID: 10
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x0400000B RID: 11
		private global::Guna.UI2.WinForms.Guna2Button guna2Button3;
	}
}
