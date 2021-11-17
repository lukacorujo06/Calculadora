using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{

	class calculadora{
		public double sumar (double num1, double num2){	
			
			return (num1 + num2);
		}
		
		public double restar (double num1, double num2){	
			
			return (num1 - num2);
		}
		
		public double div (double num1, double num2){	
			
			return (num1 / num2);
		}
		
		public double mult (double num1, double num2){	
			
			return (num1 * num2);
		}
	}
	
	public partial class MainForm : Form
	{
		double num1, num2;
		
		string operador;
		
		bool auxiliar = false, auxiliar2 = false, auxiliar3 = false;
		
		calculadora objCalculadora = new calculadora();
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void Btn_1Click(object sender, EventArgs e)
		{
			Button boton = (Button) sender;
			
			if (txt_resultados.Text == "0" || auxiliar2 == true){
				
				txt_resultados.Text = " ";
			}
			
			txt_resultados.Text = txt_resultados.Text + boton.Text;
		
			auxiliar3 = true;
			
			auxiliar2 = false;
			
			btn_resultado.Focus();
		}
		
		void Btn_sumarClick(object sender, EventArgs e)
		{
			Button boton = (Button) sender;
			
			if (auxiliar3 == true){
				
				if(auxiliar == true){
					
					switch(operador){
							
						case "+":
							txt_resultados.Text = Convert.ToString(objCalculadora.sumar (num1, Convert.ToDouble(txt_resultados.Text)));
							break;
						case "-":
							txt_resultados.Text = Convert.ToString(objCalculadora.restar (num1, Convert.ToDouble(txt_resultados.Text)));
							break;
						case "X":
							txt_resultados.Text = Convert.ToString(objCalculadora.mult (num1, Convert.ToDouble(txt_resultados.Text)));
							break;
						case "/":
							txt_resultados.Text = Convert.ToString(objCalculadora.div (num1, Convert.ToDouble(txt_resultados.Text)));
							break;
					}
				}
			
				num1 = Convert.ToDouble(txt_resultados.Text);
			
				txt_resultados.Text = "0";
			}
			
			operador = boton.Text;
			
			txt_resultados2.Text = Convert.ToString(num1)+" "+ operador;
			
			auxiliar = true;
			
			auxiliar3 = false;
			
			btn_resultado.Focus();
		}
		
		void Btn_resultadoClick(object sender, EventArgs e)
		{
			num2 = Convert.ToDouble(txt_resultados.Text);
			
			switch(operador){
				case "+":
					txt_resultados.Text = Convert.ToString(objCalculadora.sumar (num1, num2));
					break;
				case "-":
					txt_resultados.Text = Convert.ToString(objCalculadora.restar (num1, num2));
					break;
				case "X":
					txt_resultados.Text = Convert.ToString(objCalculadora.mult (num1, num2));
					break;
				case "/":
					txt_resultados.Text = Convert.ToString(objCalculadora.div (num1, num2));
					break;
			}
			
			txt_resultados2.Text = " ";
			num1 = 0;
			num2 = 0;
			auxiliar = false;
			auxiliar2 = true;
			
			btn_resultado.Focus();
		}
		
		void Btn_cClick(object sender, EventArgs e)
		{
			num1 = 0;
			num2 = 0;
			txt_resultados.Text = "0";
			txt_resultados2.Text = " ";
			auxiliar = false;
			
			btn_resultado.Focus();
		}
		
		void Btn_borrarClick(object sender, EventArgs e)
		{
			if (txt_resultados.Text.Length > 2){
				txt_resultados.Text = txt_resultados.Text.Substring(0,txt_resultados.Text.Length-1);
			}else{
				txt_resultados.Text = "0";
			}
			
			btn_resultado.Focus();
		}
		
		void Btn_ceClick(object sender, EventArgs e)
		{
			txt_resultados.Text = "0";
			btn_resultado.Focus();
		}
		
		void Btn_mas_menosClick(object sender, EventArgs e)
		{
			double signo;
			
			signo = Convert.ToDouble(txt_resultados.Text);
			
			signo *= -1;
			
			txt_resultados.Text = Convert.ToString(signo);
			
			btn_resultado.Focus();
		}
		
		
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0){
				btn_0.PerformClick();
			}
			
			if(e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1){
				btn_1.PerformClick();
			}
			
			if(e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2){
				btn_2.PerformClick();
			}
			
			if(e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3){
				btn_3.PerformClick();
			}
			
			if(e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4){
				btn_4.PerformClick();
			}
			
			if(e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5){
				btn_5.PerformClick();
			}
			
			if(e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6){
				btn_6.PerformClick();
			}
			
			if(e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7){
				btn_7.PerformClick();
			}
			
			if(e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8){
				btn_8.PerformClick();
			}
			
			if(e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9){
				btn_9.PerformClick();
			}
			
			if(e.KeyCode == Keys.Decimal){
				btn_coma.PerformClick();
			}
			
			if(e.KeyCode == Keys.Back){
				btn_borrar.PerformClick();
			}
			
			if(e.KeyCode == Keys.Add){
				btn_sumar.PerformClick();
			}
			
			if(e.KeyCode == Keys.Multiply){
				btn_mult.PerformClick();
			}
			
			if(e.KeyCode == Keys.Divide){
				btn_dividir.PerformClick();
			}
			
			if(e.KeyCode == Keys.Subtract){
				btn_restar.PerformClick();
			}
			
			if(e.KeyCode == Keys.Enter){
				btn_resultado.PerformClick();
			}
		}
	}
}
