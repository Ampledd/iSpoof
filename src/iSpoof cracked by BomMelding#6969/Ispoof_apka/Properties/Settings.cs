using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Ispoof_apka.Properties
{
	// Token: 0x02000008 RID: 

	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600004B RID: 75 RVA: 0x0000479C File Offset: 0x0000299C
		public static Settings Settings_0
		{
			get
			{
				return Settings.settings_0;
			}
		}

		// Token: 0x0400002F RID: 47
		private static Settings settings_0 = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
