using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SliceSorter
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnBrowseOut_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(ofd1.FileName))
			{
				sfd1.FileName = System.IO.Path.GetFileNameWithoutExtension(ofd1.FileName) + ".png";
			}
			if (sfd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				txtPathOut.Text = sfd1.FileName;
			}
		}

		private void btnBrowseIn_Click(object sender, EventArgs e)
		{
			if (ofd1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				txtPathIn.Text = ofd1.FileName;
			}
		}

		private void btnSort_Click(object sender, EventArgs e)
		{
			var b = (Bitmap)Bitmap.FromFile(txtPathIn.Text);
			int width = b.Width;
			int height = b.Height;
			int iterations;
			int barWidth;
			if (!int.TryParse(txtIterations.Text, out iterations))
			{
				MessageBox.Show("Unexpected value for 'iterations'");
				return;
			}
			if (!int.TryParse(txtBarWidth.Text, out barWidth))
			{
				MessageBox.Show("Unexpected value for 'bar width'");
				return;
			}
			if (barWidth * iterations != width)
			{
				MessageBox.Show("Warning: the specified parameters do not seem to match the provided image! (barWidth * iterations != width)");
			}
			List<Tuple<Rectangle, Color>> slicesColors = new List<Tuple<Rectangle, Color>>();
			for (int i = 0; i < iterations; i += barWidth)
			{
				var rectangle = new Rectangle(i, 0, barWidth, height);
				slicesColors.Add(new Tuple<Rectangle, Color>(rectangle, FindAverageColor(rectangle, b)));
			}
			slicesColors.Sort(new TupleColorSorter());
			var newB = new Bitmap(b.Width, b.Height);
			newB.SetResolution(b.HorizontalResolution, b.VerticalResolution);
			var g = Graphics.FromImage(newB);
			int k = 0;
			foreach (var item in slicesColors)
			{
				g.DrawImage(b, k, 0, item.Item1, GraphicsUnit.Pixel);
				k++;
			}
			newB.Save(txtPathOut.Text);

		}

		private Color FindAverageColor(Rectangle region, Bitmap bitmap)
		{
			int r = 0, g = 0, b = 0;
			//var datas = bitmap.LockBits(region, System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.DontCare);
			int width = region.Right;
			int height = region.Bottom;
			for (int i = region.X; i < width; i++)
			{
				for (int j = region.Y; j < height; j++)
				{
					var pixel = bitmap.GetPixel(i, j);
					r += pixel.R;
					g += pixel.G;
					b += pixel.B;
				}
			}
			var pixels = region.Width * region.Height;
			return Color.FromArgb(r / pixels, g / pixels, b / pixels);
		}

	}

}
