using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Ispoof_apka.Properties
{
	// Token: 0x02000007 RID: 7
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	internal class Resources
	{
		// Token: 0x06000041 RID: 65 RVA: 0x0000225A File Offset: 0x0000045A
		internal Resources()
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000042 RID: 66 RVA: 0x00004698 File Offset: 0x00002898
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager_0
		{
			get
			{
				if (Resources.resourceManager_0 == null)
				{
					ResourceManager resourceManager = new ResourceManager("Ispoof_apka.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceManager_0 = resourceManager;
				}
				return Resources.resourceManager_0;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000046D8 File Offset: 0x000028D8
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002262 File Offset: 0x00000462
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo CultureInfo_0
		{
			get
			{
				return Resources.cultureInfo_0;
			}
			set
			{
				Resources.cultureInfo_0 = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000045 RID: 69 RVA: 0x000046EC File Offset: 0x000028EC
		internal static Bitmap Bitmap_0
		{
			get
			{
				object @object = Resources.ResourceManager_0.GetObject("g3", Resources.cultureInfo_0);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00004718 File Offset: 0x00002918


		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00004744 File Offset: 0x00002944


		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00004770 File Offset: 0x00002970


		// Token: 0x0400002D RID: 45
		private static ResourceManager resourceManager_0;

		// Token: 0x0400002E RID: 46
		private static CultureInfo cultureInfo_0;
	}
}
