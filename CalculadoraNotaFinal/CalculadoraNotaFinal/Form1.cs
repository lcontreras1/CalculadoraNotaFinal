using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraNotaFinal
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			/////////promedio de controles
			var c1 = Convert.ToInt32(textBox1.Text);
			var c2 = Convert.ToInt32(textBox2.Text);
			var c3 = Convert.ToInt32(textBox3.Text);
			var c4 = Convert.ToInt32(textBox4.Text);

			//var controlbajo = Math.Min(control1, control2, control3, control4);

			var menorControl = new int[] { c1, c2, c3, c4 }.Min();

			var promedioControles = (c1 + c2 + c3 + c4 - menorControl) / 3;


			label14.Text = "El promedio de controles es : " + promedioControles;

			////////promedio de laboratorio
			var l1 = Convert.ToInt32(textBox5.Text);
			var l2 = Convert.ToInt32(textBox6.Text);
			var l3 = Convert.ToInt32(textBox7.Text);
			var l4 = Convert.ToInt32(textBox8.Text);

			var promedioLaboratorio = (l1 + l2 + l3 + l4) / 4;

			label15.Text = "El promedio de laboratorio:" + promedioLaboratorio;

			///////promedio de evaluaciones

			var W = Convert.ToInt32(textBox9.Text);
			var promEva = (promedioControles + promedioLaboratorio + W) / 3;

			label16.Text = "El promedio de evaluaciones:" + promEva;

			///// promedio nota final

			var par = Convert.ToInt32(textBox10.Text);
			var fin = Convert.ToInt32(textBox10.Text);

			var promNotaFinal = (2 * promEva + par + fin) / 4;
			label17.Text = "Nota final:" + promNotaFinal;
		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void textBox9_TextChanged(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}
	}
}
