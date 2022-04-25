using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using KeyAuth;

namespace Ispoof_apka
{
	// Token: 0x02000005 RID: 5
	public partial class Form2 : Form
	{
		// Token: 0x0600002D RID: 45 RVA: 0x0000219A File Offset: 0x0000039A
		public Form2()
		{
			this.InitializeComponent();
			base.Region = Region.FromHrgn(Form2.CreateRoundRectRgn(0, 0, base.Width, base.Height, 25, 25));
		}

		// Token: 0x0600002F RID: 47
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5);

		// Token: 0x06000030 RID: 48 RVA: 0x00003880 File Offset: 0x00001A80
		public void loadform(object Form)
		{
			if (this.mainpanel.Controls.Count > 0)
			{
				this.mainpanel.Controls.RemoveAt(0);
			}
			Form form = Form as Form;
			form.TopLevel = false;
			form.Dock = DockStyle.Fill;
			this.mainpanel.Controls.Add(form);
			this.mainpanel.Tag = form;
			form.Show();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000021EA File Offset: 0x000003EA
		private void Form2_Load(object sender, EventArgs e)
		{
			MessageBox.Show("Cracked by BomMelding#6969");
			new form1().Show();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000038EC File Offset: 0x00001AEC
		private static string smethod_0()
		{
			string text = null;
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
			}
			return text;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002160 File Offset: 0x00000360
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000208C File Offset: 0x0000028C
		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00003948 File Offset: 0x00001B48
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Form2.KeyAuthApp.login(this.username.Text, this.password.Text);
			if (Form2.KeyAuthApp.response.success)
			{
				Control control = new form1();
				base.Hide();
				control.Show();
				return;
			}
			MessageBox.Show("Login or Password is invalid", "iSpoof-Security");
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000208C File Offset: 0x0000028C
		private void mainpanel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x04000018 RID: 24
		private bool bool_0;

		// Token: 0x04000019 RID: 25
		private Point point_0;

		// Token: 0x0400001A RID: 26
		public static api KeyAuthApp = new api("iSpoof", "nSQBUcM4qQ", "a98899af75ca225706cbb52ad7d0e81c08197ea5a4b7f1e240605cce0bd72660", "1.0");
	}
}
