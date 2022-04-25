using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls.RJControls
{
	// Token: 0x02000002 RID: 2
	public class RJToggleButton : CheckBox
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000026AC File Offset: 0x000008AC
		public RJToggleButton()
		{
			this.MinimumSize = new Size(45, 22);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x0000271C File Offset: 0x0000091C
		// (set) Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Category("RJ Code Advance")]
		public Color OnBackColor
		{
			get
			{
				return this.color_0;
			}
			set
			{
				this.color_0 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00002734 File Offset: 0x00000934
		// (set) Token: 0x06000005 RID: 5 RVA: 0x0000205F File Offset: 0x0000025F
		[Category("RJ Code Advance")]
		public Color OnToggleColor
		{
			get
			{
				return this.color_1;
			}
			set
			{
				this.color_1 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000274C File Offset: 0x0000094C
		// (set) Token: 0x06000007 RID: 7 RVA: 0x0000206E File Offset: 0x0000026E
		[Category("RJ Code Advance")]
		public Color OffBackColor
		{
			get
			{
				return this.color_2;
			}
			set
			{
				this.color_2 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002764 File Offset: 0x00000964
		// (set) Token: 0x06000009 RID: 9 RVA: 0x0000207D File Offset: 0x0000027D
		[Category("RJ Code Advance")]
		public Color OffToggleColor
		{
			get
			{
				return this.color_3;
			}
			set
			{
				this.color_3 = value;
				base.Invalidate();
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x0000277C File Offset: 0x0000097C
		// (set) Token: 0x0600000B RID: 11 RVA: 0x0000208C File Offset: 0x0000028C
		[Browsable(false)]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000208E File Offset: 0x0000028E
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002096 File Offset: 0x00000296
		[Category("RJ Code Advance")]
		[DefaultValue(true)]
		public bool SolidStyle
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
				base.Invalidate();
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002794 File Offset: 0x00000994
		private GraphicsPath method_0()
		{
			int num = base.Height - 1;
			Rectangle rect = new Rectangle(0, 0, num, num);
			Rectangle rect2 = new Rectangle(base.Width - num - 2, 0, num, num);
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.StartFigure();
			graphicsPath.AddArc(rect, 90f, 180f);
			graphicsPath.AddArc(rect2, 270f, 180f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002804 File Offset: 0x00000A04
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Rectangle clientRectangle = base.ClientRectangle;
			Rectangle rectangle_ = Rectangle.Inflate(clientRectangle, -this.int_0, -this.int_0);
			int num = 2;
			if (this.int_0 > 0)
			{
				num = this.int_0;
			}
			if (this.int_1 > 2)
			{
				using (GraphicsPath graphicsPath = this.method_1(clientRectangle, this.int_1))
				{
					using (GraphicsPath graphicsPath2 = this.method_1(rectangle_, this.int_1 - this.int_0))
					{
						using (Pen pen = new Pen(base.Parent.BackColor, (float)num))
						{
							using (Pen pen2 = new Pen(this.color_4, (float)this.int_0))
							{
								pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
								base.Region = new Region(graphicsPath);
								pevent.Graphics.DrawPath(pen, graphicsPath);
								if (this.int_0 >= 1)
								{
									pevent.Graphics.DrawPath(pen2, graphicsPath2);
								}
							}
						}
					}
					return;
				}
			}
			pevent.Graphics.SmoothingMode = SmoothingMode.None;
			base.Region = new Region(clientRectangle);
			if (this.int_0 >= 1)
			{
				using (Pen pen3 = new Pen(this.color_4, (float)this.int_0))
				{
					pen3.Alignment = PenAlignment.Inset;
					pevent.Graphics.DrawRectangle(pen3, 0, 0, base.Width - 1, base.Height - 1);
				}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020A5 File Offset: 0x000002A5
		private GraphicsPath method_1(Rectangle rectangle_0, int int_2)
		{
			throw new NotImplementedException();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020AC File Offset: 0x000002AC
		protected override void OnHandleCreated(EventArgs e)
		{
			base.OnHandleCreated(e);
			base.Parent.BackColorChanged += this.method_2;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020CC File Offset: 0x000002CC
		private void method_2(object sender, EventArgs e)
		{
			base.Invalidate();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020D4 File Offset: 0x000002D4
		private void method_3(object sender, EventArgs e)
		{
			if (this.int_1 > base.Height)
			{
				this.int_1 = base.Height;
			}
		}

		// Token: 0x04000001 RID: 1
		private Color color_0 = Color.MediumSlateBlue;

		// Token: 0x04000002 RID: 2
		private Color color_1 = Color.WhiteSmoke;

		// Token: 0x04000003 RID: 3
		private Color color_2 = Color.Gray;

		// Token: 0x04000004 RID: 4
		private Color color_3 = Color.Gainsboro;

		// Token: 0x04000005 RID: 5
		private bool bool_0 = true;

		// Token: 0x04000006 RID: 6
		private int int_0 = 0;

		// Token: 0x04000007 RID: 7
		private int int_1 = 0;

		// Token: 0x04000008 RID: 8
		private Color color_4 = Color.PaleVioletRed;
	}
}
