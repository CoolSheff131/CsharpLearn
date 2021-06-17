using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
	public partial class Form1 : Form
	{
		private Button[,] buttons = new Button[3,3];
		private int player;
		public Form1()
		{
			InitializeComponent();
			this.Height = 700;
			this.Width = 900;
			player = 1;
			label1.Text = "Текущий ход: игрок 1";
			for (int i = 0; i < buttons.Length/3; i++)
			{
				for (int j = 0; j < buttons.Length/3; j++)
				{
					buttons[i, j] = new Button();
					buttons[i, j].Size = new Size(200, 200);
				}
					
			}
				
			setButtons();
		}
		private void setButtons()
		{
			Font font = new Font(new FontFamily("Microsoft sans serif"), 138);
			for (int i = 0; i < buttons.Length/3; i++)
			{
				for (int j = 0; j < buttons.Length/3; j++)
				{
					buttons[i, j].Location = new Point(12 + 206 * i, 12 + 206 * j);
					buttons[i, j].Click += button1_Click;
					buttons[i, j].Font = font;
					this.Controls.Add(buttons[i, j]);
				}
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			switch (player)
			{
				case 1:
					sender.GetType().GetProperty("Text").SetValue(sender, "x");
					label1.Text = "Текущий ход: игрок 2";
					player = 0;
					break;
				case 0:
					sender.GetType().GetProperty("Text").SetValue(sender, "o");
					label1.Text = "Текущий ход: игрок 1";
					player = 1;
					break;
			}
			sender.GetType().GetProperty("Enabled").SetValue(sender, false);
			checkWin();
			//MessageBox.Show(sender.GetType().GetProperty("Name").GetValue(sender).ToString());
		}
		private void checkWin()
		{
			if (buttons[0,0].Text == buttons[0,1].Text && buttons[0, 1].Text == buttons[0, 2].Text && buttons[0, 2].Text != "")
			{
				MessageBox.Show("Вы победили");
			}
			if (buttons[1,0].Text == buttons[1,1].Text && buttons[1,1].Text == buttons[1,2].Text && buttons[1,2].Text != "")
			{
				MessageBox.Show("Вы победили");
			}
			if (buttons[2,0].Text == buttons[2,1].Text && buttons[2,1].Text == buttons[2,2].Text && buttons[2,2].Text != "")
			{
				MessageBox.Show("Вы победили");
			}

			if (buttons[0,0].Text == buttons[1,0].Text && buttons[1,0].Text == buttons[2,0].Text && buttons[2,0].Text != "")
			{
				MessageBox.Show("Вы победили");
			}
			if (buttons[0,1].Text == buttons[1,1].Text && buttons[1, 1].Text == buttons[2, 1].Text && buttons[2, 1].Text != "")
			{
				MessageBox.Show("Вы победили");
			}
			if (buttons[0,2].Text == buttons[1,2].Text && buttons[1,2].Text == buttons[2,2].Text && buttons[2,2].Text != "")
			{
				MessageBox.Show("Вы победили");
			}

			if (buttons[0,0].Text == buttons[1,1].Text && buttons[1,1].Text == buttons[2,2].Text && buttons[2,2].Text != "")
			{
				MessageBox.Show("Вы победили");
			}
			if (buttons[2,0].Text == buttons[1,1].Text && buttons[1,1].Text == buttons[0,2].Text && buttons[0,2].Text != "")
			{
				MessageBox.Show("Вы победили");
			}
			
		}

		private void buttonName_Click(object sender, EventArgs e)
		{
			for(int i = 0; i<buttons.Length/3; i++)
			{
				for(int j = 0; j < buttons.Length / 3; j++)
				{
					buttons[i, j].Text = "";
					buttons[i, j].Enabled = true;
				}
			}
		}
	}
}
