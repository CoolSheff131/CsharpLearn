﻿using System;
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

		public int[,] tetr1 = new int[4, 4]
		{
			{ 0,0,1,0},
			{ 0,0,1,0},
			{ 0,0,1,0},
			{ 0,0,1,0},
		};
		public int[,] tetr2 = new int[3, 3]
		{
			{ 0,2,0},
			{ 0,2,2},
			{ 0,0,2},
			
		};
		public int[,] tetr3 = new int[3, 3]
		{
			{ 0,0,0},
			{ 3,3,3},
			{ 0,3,0},

		};
		public int[,] tetr4 = new int[3, 3]
		{
			{ 4,0,0},
			{ 4,0,0},
			{ 4,4,0},

		};
		public int[,] tetr5 = new int[3, 3]
		{
			{ 0,5,5},
			{ 0,5,5},
			{ 0,0,0},

		};
		public Shape(int _x,int _y)
		{
			x = _x;
			y = _y;
			GenerateMatrix();
		}
		public void GenerateMatrix()
		{
			Random r = new Random();
			sizeMatrix = 3;
			switch (r.Next(1, 6))
			{
				case 1:
					sizeMatrix = 4;
					matrix = tetr1;
					break;
				case 2:
					matrix = tetr2;
					break;
				case 3:
					matrix = tetr3;
					break;
				case 4:
					matrix = tetr4;
					break;
				case 5:
					matrix = tetr5;
					break;
			}
		}
		public void RotateShape()
		{
			for (int i = 0; i < sizeMatrix; i++)
			{
				for (int j = i; j < sizeMatrix; j++)
				{
					int temp = matrix[i, j];
					matrix[i, j] = matrix[j, i];
					matrix[j, i] = temp;
				}
			}
		}
		public void MoveDown()
		{
			y++;
		}
		public void MoveRight()
		{	
			x++;
		}
		public void MoveLeft()
		{
			x--;
		}

	}
}
