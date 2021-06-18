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
		Shape currentShape;
		int size;
		int[,] map = new int[200, 200];
		public Form1()
		{
			InitializeComponent();

			Init();
		}

		private void update(object sender, EventArgs e)
		{
			
			ResetArea();
			if (!Collide())
			{
				currentShape.MoveDown();
			}
			else
			{
				Merge();
				currentShape = new Shape(3, 0);
			}
			Merge();
			Invalidate();

		}

		public void Merge()
		{
			for(int i = currentShape.y; i < currentShape.y + currentShape.sizeMatrix; i++)
			{
				for (int j = currentShape.x; j < currentShape.x + currentShape.sizeMatrix; j++)
				{
					if(currentShape.matrix[i - currentShape.y,j - currentShape.x] != 0)
					map[i, j] = currentShape.matrix[i - currentShape.y, j - currentShape.x];
				}
			}
		}
		public bool Collide()
		{
			for(int i = currentShape.y + currentShape.sizeMatrix - 1; i > currentShape.y; i--)
			{
				for(int j = currentShape.x;j<currentShape.x + currentShape.sizeMatrix; j++)
				{
					if(currentShape.matrix[i - currentShape.y,j - currentShape.x] != 0)
					{

						if (i + 1 == 16)
							return true;
						if(map[i+1,j] != 0)
						{
							return true;
						}
					}
				}
			}
			return false;
		}
		public bool CollideHor(int dir)
		{
			for (int i = currentShape.y; i < currentShape.y + currentShape.sizeMatrix; i++)
			{
				for (int j = currentShape.x; j < currentShape.x + currentShape.sizeMatrix; j++)
				{
					if (currentShape.matrix[i - currentShape.y, j - currentShape.x] != 0)
					{
						if (j + 1 * dir > 7 || j + 1 * dir < 0)
							return true;

						if (map[i, j + 1 * dir] != 0)
						{
							if (j - currentShape.x + 1 * dir >= currentShape.sizeMatrix || j - currentShape.x + 1 * dir < 0)
							{
								return true;
							}
							if (currentShape.matrix[i - currentShape.y, j - currentShape.x + 1 * dir] == 0)
								return true;
						}
					}
				}
			}
			return false;
		}
		public void ResetArea()
		{
			for (int i = currentShape.y; i < currentShape.y + currentShape.sizeMatrix; i++)
			{
				for (int j = currentShape.x; j < currentShape.x + currentShape.sizeMatrix; j++)
				{
					if (i >= 0 && j >= 0 && i < 16 && j < 8)
					{
						if (currentShape.matrix[i - currentShape.y, j - currentShape.x] != 0)
						{
							map[i, j] = 0;
						}
					}


				}
			}
		}
		public void DrawMap(Graphics e)
		{
			for(int i = 0; i< 16; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					if (map[i, j] == 1)
					{
						e.FillRectangle(Brushes.Red, new Rectangle(50 + j * size + 1, 50 + i * size + 1, size - 1, size - 1));
					}
				}
			}

		}
		public void Init()
		{
			size = 25;

			currentShape = new Shape(3, 0);

			this.KeyUp += new KeyEventHandler(keyFunc);

			timer1.Interval = 1000;
			timer1.Tick += new EventHandler(update);
			timer1.Start();

			Invalidate();
		}

		private void keyFunc(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Space:
					break;
				case Keys.Right:
					if (!CollideHor(1))
					{
						ResetArea();
						currentShape.MoveRight();
						Merge();
						Invalidate();
					}
					break;
				case Keys.Left:
					if (!CollideHor(-1))
					{
						ResetArea();
						currentShape.MoveLeft();
						Merge();
						Invalidate();
					}
					break;

			}
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
			DrawMap(e.Graphics);
		}
	}
}
