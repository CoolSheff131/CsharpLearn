using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tetris
{
	public partial class Form1 : Form
	{
		int size;
		int[,] map = new int[8, 16];
		public Form1()
		{
			InitializeComponent();
			Init();
		}
		public void Init()
		{
			size = 25;
			Invalidate();
		}
		public void DrawGrid(Graphics g)
		{
			for(int i = 0; i <= 16; i++)
			{
				g.DrawLine(Pens.Black, new Point(50, 50 + i * size), new Point(50 + 8 * size, 50 + i * size));
			}
			for (int i = 0; i <= 8; i++)
			{
				g.DrawLine(Pens.Black, new Point(50 + i * size, 50), new Point(50 + i * size, 50 + 16 * size));
			}
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			DrawGrid(e.Graphics);
		}
	}
}
