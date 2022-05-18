using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace SquaresOfFigures
{
	public partial class Form1 : MaterialForm
	{
		readonly MaterialSkin.MaterialSkinManager materialSkinManager;
		public Form1()
		{
			InitializeComponent();
			materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
			materialSkinManager.EnforceBackcolorOnAllComponents = true;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
		}

		private void SquareTriangle1_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBoxSquareTriangle1a.Text);
				double h = double.Parse(textBoxSquareTriangle1h.Text);
				labelSquareTriangle1.Text = "= " + Function.SquareTriangle(a, h).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareTriangle2_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBoxSquareTriangle2a.Text);
				double b = double.Parse(textBoxSquareTriangle2b.Text);
				int alpha = int.Parse(textBoxSquareTriangle2alpha.Text);
				labelSquareTriangle2.Text = "= " + Function.SquareTriangle(a, b, alpha).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareTriangle3_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBoxSquareTriangle3a.Text);
				double b = double.Parse(textBoxSquareTriangle3b.Text);
				double c = double.Parse(textBoxSquareTriangle3c.Text);
				labelSquareTriangle3.Text = "= " + Function.SquareTriangle(a, b, c).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareTriangle4_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBoxSquareTriangle4a.Text);
				double b = double.Parse(textBoxSquareTriangle4b.Text);
				double c = double.Parse(textBoxSquareTriangle4c.Text);
				double R = double.Parse(textBoxSquareTriangle4R.Text);
				labelSquareTriangle4.Text = "= " + Function.SquareTrianglePR(a, b, c, R).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareTriangle5_Click(object sender, EventArgs e)
		{
			try
			{
				double r = double.Parse(textBoxSquareTriangle5r.Text);
				labelSquareTriangle5.Text = "= " + Function.SquareTrianglePR(r).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareTriangleClear_Click(object sender, EventArgs e)
		{
			textBoxSquareTriangle1a.Text = "";
			textBoxSquareTriangle1h.Text = "";
			textBoxSquareTriangle2a.Text = "";
			textBoxSquareTriangle2b.Text = "";
			textBoxSquareTriangle3a.Text = "";
			textBoxSquareTriangle3b.Text = "";
			textBoxSquareTriangle3c.Text = "";
			textBoxSquareTriangle4a.Text = "";
			textBoxSquareTriangle4b.Text = "";
			textBoxSquareTriangle4c.Text = "";
			textBoxSquareTriangle4R.Text = "";
			textBoxSquareTriangle5r.Text = "";
		}



		private void SquareBox1_Click(object sender, EventArgs e)
		{
			try
			{
				int a = int.Parse(textBoxSquareBox1a.Text);
				labelSquareBox1.Text = "= " + Function.SquareBox(a).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareBox2_Click(object sender, EventArgs e)
		{
			try
			{
				double d = double.Parse(textBoxSquareBox1a.Text);
				labelSquareBox2.Text = "= " + Function.SquareBox(d).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareBoxClear_Click(object sender, EventArgs e)
		{
			textBoxSquareBox1a.Text = "";
			textBoxSquareBox2d.Text = "";
		}



		private void SquareRectangle1_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBoxSquareRectangle1a.Text);
				double b = double.Parse(textBoxSquareRectangle1b.Text);
				labelSquareRectangle1.Text = "= " + Function.SquareRectangle(a, b).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareRectangle2_Click(object sender, EventArgs e)
		{
			try
			{
				double d = double.Parse(textBoxSquareRectangle2d.Text);
				int alpha = int.Parse(textBoxSquareRectangle2alpha.Text);
				labelSquareRectangle2.Text = "= " + Function.SquareRectangle(d, alpha).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareRectangleClear_Click(object sender, EventArgs e)
		{
			textBoxSquareRectangle1a.Text = "";
			textBoxSquareRectangle1b.Text = "";
			textBoxSquareRectangle2d.Text = "";
			textBoxSquareRectangle2alpha.Text = "";
		}



		private void SquareParallelogram1_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBoxSquareParallelogram1a.Text);
				double h = double.Parse(textBoxSquareParallelogram1h.Text);
				labelSquareParallelogram1.Text = "= " + Function.SquareParallelogram(a, h).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareParallelogram2_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBoxSquareParallelogram2a.Text);
				double b = double.Parse(textBoxSquareParallelogram2b.Text);
				int alpha = int.Parse(textBoxSquareParallelogram2alpha.Text);
				labelSquareParallelogram2.Text = "= " + Function.SquareParallelogram(a, b, alpha, false).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareParallelogram3_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBoxSquareParallelogram3d1.Text);
				double b = double.Parse(textBoxSquareParallelogram3d2.Text);
				int alpha = int.Parse(textBoxSquareParallelogram3alpha.Text);
				labelSquareParallelogram3.Text = "= " + Function.SquareParallelogram(a, b, alpha, true).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareParallelogramClean_Click(object sender, EventArgs e)
		{
			textBoxSquareParallelogram1a.Text = "";
			textBoxSquareParallelogram1h.Text = "";
			textBoxSquareParallelogram2a.Text = "";
			textBoxSquareParallelogram2b.Text = "";
			textBoxSquareParallelogram2alpha.Text = "";
			textBoxSquareParallelogram3d1.Text = "";
			textBoxSquareParallelogram3d2.Text = "";
			textBoxSquareParallelogram3alpha.Text = "";
		}



		private void SquareRhombus1_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBoxSquareRhombus1a.Text);
				double h = double.Parse(textBoxSquareRhombus1h.Text);
				labelSquareRhombus1.Text = "= " + Function.SquareRhombus(a, h, true).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareRhombus2_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBoxSquareRhombus2a.Text);
				int alpha = int.Parse(textBoxSquareRhombus2alpha.Text);
				labelSquareRhombus2.Text = "= " + Function.SquareRhombus(a, alpha).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareRhombus3_Click(object sender, EventArgs e)
		{
			try
			{
				double d1 = double.Parse(textBoxSquareRhombus3d1.Text);
				double d2 = double.Parse(textBoxSquareRhombus3d2.Text);
				labelSquareRhombus3.Text = "= " + Function.SquareRhombus(d1, d2, false).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareRhombus4_Click(object sender, EventArgs e)
		{
			try
			{
				double r = double.Parse(textBoxSquareRhombus4r.Text);
				labelSquareRhombus4.Text = "= " + Function.SquareRhombus(r).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareRhombusClean_Click(object sender, EventArgs e)
		{
			textBoxSquareRhombus1a.Text = "";
			textBoxSquareRhombus1h.Text = "";
			textBoxSquareRhombus2a.Text = "";
			textBoxSquareRhombus2alpha.Text = "";
			textBoxSquareRhombus3d1.Text = "";
			textBoxSquareRhombus3d2.Text = "";
			textBoxSquareRhombus4r.Text = "";
		}



		private void SquareTrapezoid1_Click(object sender, EventArgs e)
		{
			try
			{
				double a = double.Parse(textBoxSquareTrapezoid1a.Text);
				double b = double.Parse(textBoxSquareTrapezoid1b.Text);
				double h = double.Parse(textBoxSquareTrapezoid1h.Text);
				labelSquareTrapezoid1.Text = "= " + Function.SquareTrapezoid(a, b, h).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void SquareTrapezoid2_Click(object sender, EventArgs e)
		{
			try
			{
				double r = double.Parse(textBoxSquareTrapezoid2r.Text);
				labelSquareTrapezoid2.Text = "= " + Function.SquareTrapezoid(r).ToString();
			}
			catch (Exception ex) { MessageBox.Show("Ошибка!"); }
		}

		private void materialButton3_Click(object sender, EventArgs e)
		{
			textBoxSquareTrapezoid1a.Text = "";
			textBoxSquareTrapezoid1b.Text = "";
			textBoxSquareTrapezoid1h.Text = "";
			textBoxSquareTrapezoid2r.Text = "";
		}
	}
}
