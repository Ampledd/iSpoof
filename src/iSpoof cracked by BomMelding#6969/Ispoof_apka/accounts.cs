using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Ispoof_apka
{
	// Token: 0x02000003 RID: 3
	public partial class accounts : Form
	{
		// Token: 0x06000014 RID: 20 RVA: 0x000020F2 File Offset: 0x000002F2
		public accounts()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000208C File Offset: 0x0000028C
		private void method_0(object sender, EventArgs e)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002107 File Offset: 0x00000307
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/ispoof");
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002114 File Offset: 0x00000314
		private void guna2Button3_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.com/invite/fivemm");
		}
	}
}
