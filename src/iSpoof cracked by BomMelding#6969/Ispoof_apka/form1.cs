using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Ispoof_apka
{
	// Token: 0x02000004 RID: 4
	public partial class form1 : Form
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00002DB4 File Offset: 0x00000FB4
		public form1()
		{
			this.icontainer_0 = null;
			this.InitializeComponent();
			base.Region = Region.FromHrgn(form1.CreateRoundRectRgn(0, 0, base.Width, base.Height, 25, 25));
		}

		// Token: 0x0600001B RID: 27
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5);

		// Token: 0x0600001C RID: 28 RVA: 0x00002E04 File Offset: 0x00001004
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

		// Token: 0x0600001D RID: 29 RVA: 0x0000208C File Offset: 0x0000028C
		private void form1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002146 File Offset: 0x00000346
		private void Spoofer_Click(object sender, EventArgs e)
		{
			this.loadform(new Spoofer());
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002153 File Offset: 0x00000353
		private void Accounts_Click(object sender, EventArgs e)
		{
			this.loadform(new accounts());
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002160 File Offset: 0x00000360
		private void method_0(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000208C File Offset: 0x0000028C
		private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002168 File Offset: 0x00000368
		private void Settings_Click(object sender, EventArgs e)
		{
			this.loadform(new Settings());
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000208C File Offset: 0x0000028C
		private void method_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000208C File Offset: 0x0000028C
		private void method_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000208C File Offset: 0x0000028C
		private void mainpanel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000208C File Offset: 0x0000028C
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002160 File Offset: 0x00000360
		private void method_3(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000208C File Offset: 0x0000028C
		private void method_4(object sender, EventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002160 File Offset: 0x00000360
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000208C File Offset: 0x0000028C
		private void guna2HtmlLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0400000C RID: 12
		private bool bool_0;

		// Token: 0x0400000D RID: 13
		private Point point_0;
	}
}
