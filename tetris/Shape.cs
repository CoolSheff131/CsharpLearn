using System;
using System.Collections.Generic;
using System.Text;

namespace tetris
{
	class Shape
	{
		public int x;
		public int y;
		public int[,] matrix;
		public int sizeMatrix;
		public Shape(int _x,int _y)
		{
			x = _x;
			y = _y;
			matrix = new int[3, 3]
			{
				{0,1,0},
				{0,1,1},
				{0,0,1},
			};
			sizeMatrix = 3;
		}
		public void MoveDown()
		{
			y++;
		}
		public void MoveRight()
		{
			if(x < 8- sizeMatrix)
			x++;
		}
		public void MoveLeft()
		{
			if(x>=0)
			x--;
		}

	}
}
