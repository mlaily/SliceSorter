﻿using System;
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

		private void Form1_Shown(object sender, EventArgs e)
		{
			var g = this.CreateGraphics();
			g.Clear(Color.Black);

			for (int i = 0; i < 360; i++)
			{
				for (int j = 0; j < 100; j++)
				{
					var hsb = new HSBColor(i, 1, j / 100f);
					var rgb = hsb.ToRGBColor();
					g.DrawLine(new Pen(rgb), i, j, i, j + 1);
				}
			}
			for (int i = 0; i < 360; i++)
			{
				for (int j = 0; j <= 100; j++)
				{
					var hsb = new HSBColor(i, j / 100f, 1);
					var rgb = hsb.ToRGBColor();
					g.DrawLine(new Pen(rgb), i, 200-j, i, 201-j);
				}
			}

			//r-y-g-c-b-m-r
			//List<Color> colors = new List<Color>();
			//var r = new Random(42);
			//for (int i = 0; i < 800; i++)
			//{
			//    colors.Add(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
			//    g.DrawLine(new Pen(colors[i]), i, 0, i, 200);
			//}

			//colors.Sort(new ColorSorter());

			//for (int i = 0; i < 800; i++)
			//{
			//    g.DrawLine(new Pen(colors[i]), i, 200, i, 400);
			//}

		}

	}

	class ColorSorter : IComparer<Color>
	{
		public int Compare(Color x, Color y)
		{
			return 0;
		}
	}
}
