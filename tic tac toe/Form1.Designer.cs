
namespace tic_tac_toe
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
			this.label1 = new System.Windows.Forms.Label();
			this.buttonName = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(645, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "label1";
			// 
			// buttonName
			// 
			this.buttonName.Location = new System.Drawing.Point(645, 45);
			this.buttonName.Name = "buttonName";
			this.buttonName.Size = new System.Drawing.Size(94, 29);
			this.buttonName.TabIndex = 10;
			this.buttonName.Text = "Заново";
			this.buttonName.UseVisualStyleBackColor = true;
			this.buttonName.Click += new System.EventHandler(this.buttonName_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 870);
			this.Controls.Add(this.buttonName);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonName;
	}
}

