namespace Ispoof_apka
{
	// Token: 0x02000006 RID: 6
	public partial class KeyForm : global::System.Windows.Forms.Form
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00002235 File Offset: 0x00000435
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000043C0 File Offset: 0x000025C0
		private void InitializeComponent()
		{
			this.mainpanel1 = new global::System.Windows.Forms.Panel();
			this.label3 = new global::System.Windows.Forms.Label();
			this.textBox3 = new global::System.Windows.Forms.TextBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.mainpanel1.SuspendLayout();
			base.SuspendLayout();
			this.mainpanel1.Controls.Add(this.label3);
			this.mainpanel1.Controls.Add(this.textBox3);
			this.mainpanel1.Controls.Add(this.panel1);
			this.mainpanel1.Location = new global::System.Drawing.Point(2, -68);
			this.mainpanel1.Name = "mainpanel1";
			this.mainpanel1.Size = new global::System.Drawing.Size(259, 203);
			this.mainpanel1.TabIndex = 1;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Calibri", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.label3.ForeColor = global::System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new global::System.Drawing.Point(27, 151);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(69, 15);
			this.label3.TabIndex = 36;
			this.label3.Text = "License Key";
			this.textBox3.BackColor = global::System.Drawing.SystemColors.Control;
			this.textBox3.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new global::System.Drawing.Font("Calibri", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 238);
			this.textBox3.Location = new global::System.Drawing.Point(30, 169);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new global::System.Drawing.Size(215, 19);
			this.textBox3.TabIndex = 35;
			this.textBox3.UseSystemPasswordChar = true;
			this.panel1.BackColor = global::System.Drawing.SystemColors.AppWorkspace;
			this.panel1.Location = new global::System.Drawing.Point(30, 188);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(215, 1);
			this.panel1.TabIndex = 34;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(257, 250);
			base.Controls.Add(this.mainpanel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "KeyForm";
			this.Text = "KeyForm";
			this.mainpanel1.ResumeLayout(false);
			this.mainpanel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000028 RID: 40
		private global::System.ComponentModel.IContainer icontainer_0 = null;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.Panel mainpanel1;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.TextBox textBox3;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.Panel panel1;
	}
}
