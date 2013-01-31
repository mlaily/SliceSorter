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

	}

}
