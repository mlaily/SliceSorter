using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SliceSorter
{

	class ColorSorter : IComparer<Color>
	{
		public int Compare(Color x, Color y)
		{
			var xHsb = HSBColor.FromRGBColor(x);
			var yHsb = HSBColor.FromRGBColor(y);
			return xHsb.H - yHsb.H;
		}
	}

	public struct HSBColor
	{
		/// <summary>
		/// 0-360°
		/// </summary>
		public int H { get; private set; }
		/// <summary>
		/// 0-1
		/// </summary>
		public double S { get; private set; }
		/// <summary>
		/// 0-1
		/// </summary>
		public double B { get; private set; }

		public HSBColor(int hue, double saturation, double brightness)
			: this()
		{
			if (hue < 0 || hue > 360)
			{
				throw new ArgumentException("0 <= h <= 360", "hue");
			}
			if (saturation < 0 || saturation > 1)
			{
				throw new ArgumentException("0 <= h <= 1", "saturation");
			}
			if (brightness < 0 || brightness > 1)
			{
				throw new ArgumentException("0 <= h <= 1", "brightness");
			}
			this.H = hue;
			this.S = saturation;
			this.B = brightness;
		}

		public override string ToString()
		{
			return string.Format("H:{0}, S:{1}, B:{2}", H, S, B);
		}

		private static void FromRGBColor(int r, int g, int b, out int h, out double s, out double v)
		{
			double rd = r / 255f, gd = g / 255f, bd = b / 255f;
			//http://en.wikipedia.org/wiki/HSL_and_HSV#General_approach
			double max = Math.Max(Math.Max(rd, gd), bd);
			double min = Math.Min(Math.Min(rd, gd), bd);
			double chroma = max - min;
			double hPrime = 0;
			if (chroma == 0)
			{
				h = 0;
				s = 0;
				v = 0;
			}
			else if (max == rd)
			{
				hPrime = (gd - bd) / chroma + (g < b ? 6 : 0); // mod 6
			}
			else if (max == gd)
			{
				hPrime = (bd - rd) / chroma + 2;
			}
			else if (max == bd)
			{
				hPrime = (rd - gd) / chroma + 4;
			}
			h = (int)(60f * hPrime);
			v = max;
			s = chroma / v;
		}

		public static HSBColor FromRGBColor(Color rgbColor)
		{
			int h;
			double s, v;
			FromRGBColor(rgbColor.R, rgbColor.G, rgbColor.B, out h, out s, out v);
			return new HSBColor() { H = h, B = v, S = s };
		}

		public Color ToRGBColor()
		{
			double chroma = this.B * this.S;
			double hPrime = this.H / 60f;
			double x = chroma * (1 - Math.Abs(hPrime % 2 - 1));
			double r1 = 0, g1 = 0, b1 = 0;
			if (hPrime < 1)
			{
				r1 = chroma;
				g1 = x;
			}
			else if (hPrime < 2)
			{
				r1 = x;
				g1 = chroma;
			}
			else if (hPrime < 3)
			{
				g1 = chroma;
				b1 = x;
			}
			else if (hPrime < 4)
			{
				g1 = x;
				b1 = chroma;
			}
			else if (hPrime < 5)
			{
				r1 = x;
				b1 = chroma;
			}
			else if (hPrime < 6)
			{
				r1 = chroma;
				b1 = x;
			}
			double m = this.B - chroma;
			return Color.FromArgb((int)((r1 + m) * 255f), (int)((g1 + m) * 255f), (int)((b1 + m) * 255f));
		}
	}
}
