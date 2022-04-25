using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Ispoof_apka.Properties;
using Microsoft.Win32;

namespace Ispoof_apka
{
	// Token: 0x02000009 RID: 9
	public partial class Settings : Form
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00002288 File Offset: 0x00000488
		public Settings()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000208C File Offset: 0x0000028C
		private void method_0(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000208C File Offset: 0x0000028C
		private void guna2HtmlLabel1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000047B0 File Offset: 0x000029B0
		private static string smethod_0()
		{
			string text = "SOFTWARE\\Microsoft\\Cryptography";
			string text2 = "MachineGuid";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key not found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index not found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000229D File Offset: 0x0000049D
		private void Settings_Load(object sender, EventArgs e)
		{
			this.guna2HtmlLabel1.Text = "HWID: " + Settings.smethod_0();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000229D File Offset: 0x0000049D
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			this.guna2HtmlLabel1.Text = "HWID: " + Settings.smethod_0();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000022B9 File Offset: 0x000004B9
		private void guna2Button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(Settings.smethod_0() + "\n             [Copied to Clipboard]", "iSpoof", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			Clipboard.SetText(Settings.smethod_0());
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004858 File Offset: 0x00002A58
		private void guna2GradientButton1_Click(object sender, EventArgs e)
		{
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("set tmp3 = C:\\Windows\\Temp\\ispoof2helper.bat");
				streamWriter.WriteLine("echo @echo off > % tmp3 % ");
				streamWriter.WriteLine("echo title Zyorby Cleaner V2 \\ Startup Apps Help >> % tmp3 %");
				streamWriter.WriteLine("echo color 03 >> % tmp3 % ");
				streamWriter.WriteLine("echo mode con:cols = 100 lines = 20 >> % tmp3 %");
				streamWriter.WriteLine("echo echo Hello if you dont know what to do in the startup apps setting then read this: >> % tmp3 % ");
				streamWriter.WriteLine("echo echo. >> % tmp3 %");
				streamWriter.WriteLine("echo echo What most do here is switch all uneccesary apps off on startup >> % tmp3 % ");
				streamWriter.WriteLine("echo echo Like i turn off discord, steam, and all my peripheral apps >> % tmp3 %");
				streamWriter.WriteLine(" echo echo. >> % tmp3 % ");
				streamWriter.WriteLine("echo echo. >> % tmp3 %");
				streamWriter.WriteLine("echo echo. >> % tmp3 %");
				streamWriter.WriteLine("echo echo. >> % tmp3 %");
				streamWriter.WriteLine("echo echo Please Close This Window Once You Are Done >> % tmp3 % ");
				streamWriter.WriteLine("echo set / p read = \" >> % tmp3 %");
				streamWriter.WriteLine("start C:\\Windows\\Temp\\ispoof2helper.bat");
				streamWriter.WriteLine("start ms - settings:startupapps");
			}
			Process.Start(text).WaitForExit();
			File.Delete(text);
			MessageBox.Show("iSpoof: Bg Apps has been disabled");
		}
	}
}
