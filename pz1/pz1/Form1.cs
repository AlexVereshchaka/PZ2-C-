using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pz1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Bitmap b;

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			// Устанавливаем свойства для OpenFileDialog
			openFileDialog1.InitialDirectory = "C:\\";
			openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 2;
			openFileDialog1.RestoreDirectory = true;

			// Отображаем диалоговое окно выбора файла
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				// Получаем выбранный путь к файлу
				string filePath = openFileDialog1.FileName;

				// Выводим путь к файлу в текстовое поле на форме
				textBox1.Text = filePath;
				b = new Bitmap(Image.FromFile(textBox1.Text));
				pictureBox1.Image = b;
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Color c, newC;
			int newR, newG, newB;
			double k = Convert.ToDouble(textBox2.Text);
			for (int x = 50; x < b.Width - 50; x++)
			{
				for (int y = 0; y < b.Height - 50; y++)
				{
					c = b.GetPixel(x, y);
					newR = (int)(k * c.R);
					newG = (int)(k * c.G);
					newB = (int)(k * c.B);

					if (newR > 255) newR = 255;
					if (newR < 0) newR = 0;

					if (newG > 255) newG = 255;
					if (newG < 0) newG = 0;

					if (newB > 255) newG = 255;
					if (newB < 0) newG = 0;

					newC = Color.FromArgb(255, newR, newG, newB);


					b.SetPixel(x, y, newC);
				}

			}
			pictureBox1.Image = b;
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{
			Color c, newC;
			int newR, newG, newB;
			double L = 255;

			for (int x = 200; x < b.Width - 0; x++)
			{
				for (int y = 0; y < b.Height - 50; y++)
				{
					c = b.GetPixel(x, y);
					newR = (int)(L - c.R);
					newG = (int)(L - c.G);
					newB = (int)(L - c.B);

					if (newR > 255) newR = 255;
					if (newR < 0) newR = 0;

					if (newG > 255) newG = 255;
					if (newG < 0) newG = 0;

					if (newB > 255) newG = 255;
					if (newB < 0) newG = 0;

					newC = Color.FromArgb(255, newR, newG, newB);
					b.SetPixel(x, y, newC);

				}

			}
			pictureBox1.Image = b;

		}

		private void button3_Click(object sender, EventArgs e)
		{
			Color c, newC;
			double I;
			for (int x = 200; x < b.Width - 0; x++)
			{
				for (int y = 0; y < b.Height - 50; y++)
				{
					c = b.GetPixel(x, y);

					I = (c.R + c.G + c.B) / 3;
					if (I > 255) I = 255;
					if (I < 0) I = 0;
					newC = Color.FromArgb(255, (int)I, (int)I, (int)I);
					b.SetPixel(x, y, newC);

				}
			}
			pictureBox1.Image = b;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Color c, newC;
			int newR, newG, newB;

			for (int x = 200; x < b.Width - 0; x++)
			{
				for (int y = 0; y < b.Height - 50; y++)
				{
					c = b.GetPixel(x, y);
					newR = (int)(c.R * 0.393 + c.G * 0.769 + c.B * 0.189);
					newG = (int)(c.R * 0.349 + c.G * 0.686 + c.B * 0.168);
					newB = (int)(c.R * 0.272 + c.G * 0.534 + c.B * 0.131);

					if (newR > 255) newR = 255;
					if (newR < 0) newR = 0;

					if (newG > 255) newG = 255;
					if (newG < 0) newG = 0;

					if (newB > 255) newG = 255;
					if (newB < 0) newG = 0;

					newC = Color.FromArgb(255, newR, newG, newB);
					b.SetPixel(x, y, newC);
				}
			}
			pictureBox1.Image = b;

		}
	}
}