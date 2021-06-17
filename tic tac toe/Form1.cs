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
		private int player;
		public Form1()
		{
			InitializeComponent();
			this.Height = 700;
			this.Width = 900;
			player = 1;
			label1.Text = "Текущий ход: игрок 1";
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
			if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text != "")
			{
				MessageBox.Show("Вы победили");
			}
			if (button4.Text == button5.Text && button5.Text == button6.Text && button6.Text != "")
			{
				MessageBox.Show("Вы победили");
			}
			if (button7.Text == button8.Text && button8.Text == button9.Text && button9.Text != "")
			{
				MessageBox.Show("Вы победили");
			}

			if (button1.Text == button4.Text && button4.Text == button7.Text && button7.Text != "")
			{
				MessageBox.Show("Вы победили");
			}
			if (button2.Text == button5.Text && button5.Text == button8.Text && button8.Text != "")
			{
				MessageBox.Show("Вы победили");
			}
			if (button3.Text == button6.Text && button6.Text == button9.Text && button9.Text != "")
			{
				MessageBox.Show("Вы победили");
			}

			if (button1.Text == button5.Text && button5.Text == button9.Text && button9.Text != "")
			{
				MessageBox.Show("Вы победили");
			}
			if (button7.Text == button5.Text && button5.Text == button3.Text && button3.Text != "")
			{
				MessageBox.Show("Вы победили");
			}
			
		}
	}
}
