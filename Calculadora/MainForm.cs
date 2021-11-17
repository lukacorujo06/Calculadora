using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CALCULADORA
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
		}

		void CalcularTextChanged(object sender, EventArgs e)
		{
			
		}
		void Capturo_Numeros(object sender, EventArgs e)
		{
			if(calcular.Text == "0"){
				calcular.Text = ((Button)sender).Text;			
			}else if(((calcular.Text == "*") || (calcular.Text == "/") || (calcular.Text == "-") || (calcular.Text == "+") || (calcular.Text == ".")) && ((calcular.Text[-1] == "*") || (calcular.Text[-1] == "/") || (calcular.Text[-1] == "-") || (calcular.Text[-1] == "+") || (calcular.Text[-1] == "."))){
				calcular.Text = ((Button)sender).Text;
			}
			else{
				calcular.Text += ((Button)sender).Text;
			}
				
		}
	}
}
