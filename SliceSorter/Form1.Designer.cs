namespace SliceSorter
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtBarWidth = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtIterations = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBrowseIn = new System.Windows.Forms.Button();
			this.txtPathIn = new System.Windows.Forms.TextBox();
			this.btnSort = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBrowseOut = new System.Windows.Forms.Button();
			this.txtPathOut = new System.Windows.Forms.TextBox();
			this.ofd1 = new System.Windows.Forms.OpenFileDialog();
			this.sfd1 = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			// 
			// txtBarWidth
			// 
			this.txtBarWidth.Location = new System.Drawing.Point(81, 116);
			this.txtBarWidth.Name = "txtBarWidth";
			this.txtBarWidth.Size = new System.Drawing.Size(55, 20);
			this.txtBarWidth.TabIndex = 21;
			this.txtBarWidth.Text = "1";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(78, 100);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 20;
			this.label6.Text = "Bar width:";
			// 
			// txtIterations
			// 
			this.txtIterations.Location = new System.Drawing.Point(12, 116);
			this.txtIterations.Name = "txtIterations";
			this.txtIterations.Size = new System.Drawing.Size(55, 20);
			this.txtIterations.TabIndex = 19;
			this.txtIterations.Text = "1000";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(9, 100);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 13);
			this.label5.TabIndex = 18;
			this.label5.Text = "Iterations:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "Image path :";
			// 
			// btnBrowseIn
			// 
			this.btnBrowseIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseIn.Location = new System.Drawing.Point(345, 23);
			this.btnBrowseIn.Name = "btnBrowseIn";
			this.btnBrowseIn.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseIn.TabIndex = 23;
			this.btnBrowseIn.Text = "Browse...";
			this.btnBrowseIn.UseVisualStyleBackColor = true;
			this.btnBrowseIn.Click += new System.EventHandler(this.btnBrowseIn_Click);
			// 
			// txtPathIn
			// 
			this.txtPathIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPathIn.Location = new System.Drawing.Point(12, 25);
			this.txtPathIn.Name = "txtPathIn";
			this.txtPathIn.Size = new System.Drawing.Size(327, 20);
			this.txtPathIn.TabIndex = 22;
			// 
			// btnSort
			// 
			this.btnSort.Location = new System.Drawing.Point(345, 114);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(75, 23);
			this.btnSort.TabIndex = 25;
			this.btnSort.Text = "Sort!";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 13);
			this.label4.TabIndex = 28;
			this.label4.Text = "Output path :";
			// 
			// btnBrowseOut
			// 
			this.btnBrowseOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowseOut.Location = new System.Drawing.Point(345, 66);
			this.btnBrowseOut.Name = "btnBrowseOut";
			this.btnBrowseOut.Size = new System.Drawing.Size(75, 23);
			this.btnBrowseOut.TabIndex = 27;
			this.btnBrowseOut.Text = "Browse...";
			this.btnBrowseOut.UseVisualStyleBackColor = true;
			this.btnBrowseOut.Click += new System.EventHandler(this.btnBrowseOut_Click);
			// 
			// txtPathOut
			// 
			this.txtPathOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPathOut.Location = new System.Drawing.Point(12, 68);
			this.txtPathOut.Name = "txtPathOut";
			this.txtPathOut.Size = new System.Drawing.Size(327, 20);
			this.txtPathOut.TabIndex = 26;
			// 
			// ofd1
			// 
			this.ofd1.Filter = "Png|*.png|Bitmap|*.bmp|Jpeg|*.jpg|Gif|*.gif|All files|*.*";
			// 
			// sfd1
			// 
			this.sfd1.DefaultExt = "png";
			this.sfd1.Filter = "Png|*.png|Bitmap|*.bmp|Jpeg|*.jpg|Gif|*.gif|All files|*.*";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 153);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnBrowseOut);
			this.Controls.Add(this.txtPathOut);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnBrowseIn);
			this.Controls.Add(this.txtPathIn);
			this.Controls.Add(this.txtBarWidth);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtIterations);
			this.Controls.Add(this.label5);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Form1";
			this.Text = "SliceSorter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtBarWidth;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtIterations;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBrowseIn;
		private System.Windows.Forms.TextBox txtPathIn;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnBrowseOut;
		private System.Windows.Forms.TextBox txtPathOut;
		private System.Windows.Forms.OpenFileDialog ofd1;
		private System.Windows.Forms.SaveFileDialog sfd1;
	}
}

