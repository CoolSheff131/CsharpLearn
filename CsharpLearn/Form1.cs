using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpLearn
{
	
	public partial class Form1 : Form
	{
		private int _width = 900;
		private int _height = 800;
		private int _sizeOfSides = 40;
		public Form1()
		{
			InitializeComponent();
			this.Width = _width;
			this.Height = _height;
			_generatorMap();
			this.KeyDown += new KeyEventHandler(OKP);
		}
		private void _generatorMap()
		{
			for(int i = 0; i<_width / _sizeOfSides; i++)
			{
				PictureBox pic = new PictureBox();
				pic.BackColor = Color.Black;
				pic.Location = new Point(0, _sizeOfSides * i);
				pic.Size = new Size(_width - 100, 1);
				this.Controls.Add(pic);
			}
			for (int i = 0; i <= _height / _sizeOfSides; i++)
			{
				PictureBox pic = new PictureBox();
				pic.BackColor = Color.Black;
				pic.Location = new Point(_sizeOfSides * i, 0);
				pic.Size = new Size(1,_width);
				this.Controls.Add(pic);

			}
		}
		private void OKP(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode.ToString())
			{
				case "Right":
					cube.Location = new Point(cube.Location.X + _sizeOfSides, cube.Location.Y);
					break;
				case "Left":
					cube.Location = new Point(cube.Location.X - _sizeOfSides, cube.Location.Y);
					break;
				case "Up":
					cube.Location = new Point(cube.Location.X, cube.Location.Y - _sizeOfSides);
					break;
				case "Down":
					cube.Location = new Point(cube.Location.X, cube.Location.Y + _sizeOfSides);
					break;
			}
		}
	}
}
