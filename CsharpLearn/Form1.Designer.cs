
namespace CsharpLearn
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cube = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.cube)).BeginInit();
			this.SuspendLayout();
			// 
			// cube
			// 
			this.cube.BackColor = System.Drawing.SystemColors.HotTrack;
			this.cube.Location = new System.Drawing.Point(229, 50);
			this.cube.Name = "cube";
			this.cube.Size = new System.Drawing.Size(40, 40);
			this.cube.TabIndex = 0;
			this.cube.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cube);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.cube)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox cube;
	}
}

