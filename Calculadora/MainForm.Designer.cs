/*
 * Created by SharpDevelop.
 * User: IPPESSI
 * Date: 6/5/2019
 * Time: 20:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CALCULADORA
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox calcular;
		private System.Windows.Forms.TextBox auxiliar;
		private System.Windows.Forms.Button btn_ce;
		private System.Windows.Forms.Button btn_c;
		private System.Windows.Forms.Button btn_borrar;
		private System.Windows.Forms.Button btn_division;
		private System.Windows.Forms.Button btn_7;
		private System.Windows.Forms.Button btn_8;
		private System.Windows.Forms.Button btn_9;
		private System.Windows.Forms.Button btn_multi;
		private System.Windows.Forms.Button btn_4;
		private System.Windows.Forms.Button btn_5;
		private System.Windows.Forms.Button btn_6;
		private System.Windows.Forms.Button btn_resta;
		private System.Windows.Forms.Button btn_1;
		private System.Windows.Forms.Button btn_2;
		private System.Windows.Forms.Button btn_3;
		private System.Windows.Forms.Button btn_suma;
		private System.Windows.Forms.Button btn_credits;
		private System.Windows.Forms.Button btn_0;
		private System.Windows.Forms.Button btn_coma;
		private System.Windows.Forms.Button btn_resultado;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.calcular = new System.Windows.Forms.TextBox();
			this.auxiliar = new System.Windows.Forms.TextBox();
			this.btn_ce = new System.Windows.Forms.Button();
			this.btn_c = new System.Windows.Forms.Button();
			this.btn_borrar = new System.Windows.Forms.Button();
			this.btn_division = new System.Windows.Forms.Button();
			this.btn_7 = new System.Windows.Forms.Button();
			this.btn_8 = new System.Windows.Forms.Button();
			this.btn_9 = new System.Windows.Forms.Button();
			this.btn_multi = new System.Windows.Forms.Button();
			this.btn_4 = new System.Windows.Forms.Button();
			this.btn_5 = new System.Windows.Forms.Button();
			this.btn_6 = new System.Windows.Forms.Button();
			this.btn_resta = new System.Windows.Forms.Button();
			this.btn_1 = new System.Windows.Forms.Button();
			this.btn_2 = new System.Windows.Forms.Button();
			this.btn_3 = new System.Windows.Forms.Button();
			this.btn_suma = new System.Windows.Forms.Button();
			this.btn_credits = new System.Windows.Forms.Button();
			this.btn_0 = new System.Windows.Forms.Button();
			this.btn_coma = new System.Windows.Forms.Button();
			this.btn_resultado = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// calcular
			// 
			this.calcular.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.calcular.Location = new System.Drawing.Point(35, 53);
			this.calcular.Multiline = true;
			this.calcular.Name = "calcular";
			this.calcular.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.calcular.Size = new System.Drawing.Size(286, 88);
			this.calcular.TabIndex = 0;
			this.calcular.Text = "0";
			this.calcular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.calcular.TextChanged += new System.EventHandler(this.CalcularTextChanged);
			// 
			// auxiliar
			// 
			this.auxiliar.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.auxiliar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.auxiliar.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.auxiliar.Location = new System.Drawing.Point(35, 27);
			this.auxiliar.Name = "auxiliar";
			this.auxiliar.Size = new System.Drawing.Size(286, 17);
			this.auxiliar.TabIndex = 1;
			this.auxiliar.Text = "0";
			this.auxiliar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btn_ce
			// 
			this.btn_ce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_ce.Location = new System.Drawing.Point(35, 182);
			this.btn_ce.Name = "btn_ce";
			this.btn_ce.Size = new System.Drawing.Size(53, 34);
			this.btn_ce.TabIndex = 2;
			this.btn_ce.Text = "CE";
			this.btn_ce.UseVisualStyleBackColor = true;
			// 
			// btn_c
			// 
			this.btn_c.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_c.Location = new System.Drawing.Point(113, 182);
			this.btn_c.Name = "btn_c";
			this.btn_c.Size = new System.Drawing.Size(53, 34);
			this.btn_c.TabIndex = 3;
			this.btn_c.Text = "C";
			this.btn_c.UseVisualStyleBackColor = true;
			// 
			// btn_borrar
			// 
			this.btn_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_borrar.Location = new System.Drawing.Point(191, 182);
			this.btn_borrar.Name = "btn_borrar";
			this.btn_borrar.Size = new System.Drawing.Size(53, 34);
			this.btn_borrar.TabIndex = 4;
			this.btn_borrar.Text = "<=x";
			this.btn_borrar.UseVisualStyleBackColor = true;
			// 
			// btn_division
			// 
			this.btn_division.BackColor = System.Drawing.SystemColors.Control;
			this.btn_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_division.Location = new System.Drawing.Point(268, 182);
			this.btn_division.Name = "btn_division";
			this.btn_division.Size = new System.Drawing.Size(53, 34);
			this.btn_division.TabIndex = 5;
			this.btn_division.Text = "/";
			this.btn_division.UseVisualStyleBackColor = false;
			// 
			// btn_7
			// 
			this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_7.Location = new System.Drawing.Point(35, 248);
			this.btn_7.Name = "btn_7";
			this.btn_7.Size = new System.Drawing.Size(53, 34);
			this.btn_7.TabIndex = 6;
			this.btn_7.Text = "7";
			this.btn_7.UseVisualStyleBackColor = true;
			this.btn_7.Click += new System.EventHandler(this.Capturo_Numeros);
			// 
			// btn_8
			// 
			this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_8.Location = new System.Drawing.Point(113, 248);
			this.btn_8.Name = "btn_8";
			this.btn_8.Size = new System.Drawing.Size(53, 34);
			this.btn_8.TabIndex = 7;
			this.btn_8.Text = "8";
			this.btn_8.UseVisualStyleBackColor = true;
			this.btn_8.Click += new System.EventHandler(this.Capturo_Numeros);
			// 
			// btn_9
			// 
			this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_9.Location = new System.Drawing.Point(191, 248);
			this.btn_9.Name = "btn_9";
			this.btn_9.Size = new System.Drawing.Size(53, 34);
			this.btn_9.TabIndex = 8;
			this.btn_9.Text = "9";
			this.btn_9.UseVisualStyleBackColor = true;
			this.btn_9.Click += new System.EventHandler(this.Capturo_Numeros);
			// 
			// btn_multi
			// 
			this.btn_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_multi.Location = new System.Drawing.Point(268, 248);
			this.btn_multi.Name = "btn_multi";
			this.btn_multi.Size = new System.Drawing.Size(53, 34);
			this.btn_multi.TabIndex = 9;
			this.btn_multi.Text = "X";
			this.btn_multi.UseVisualStyleBackColor = true;
			// 
			// btn_4
			// 
			this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_4.Location = new System.Drawing.Point(35, 318);
			this.btn_4.Name = "btn_4";
			this.btn_4.Size = new System.Drawing.Size(53, 34);
			this.btn_4.TabIndex = 10;
			this.btn_4.Text = "4";
			this.btn_4.UseVisualStyleBackColor = true;
			this.btn_4.Click += new System.EventHandler(this.Capturo_Numeros);
			// 
			// btn_5
			// 
			this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_5.Location = new System.Drawing.Point(113, 318);
			this.btn_5.Name = "btn_5";
			this.btn_5.Size = new System.Drawing.Size(53, 34);
			this.btn_5.TabIndex = 11;
			this.btn_5.Text = "5";
			this.btn_5.UseVisualStyleBackColor = true;
			this.btn_5.Click += new System.EventHandler(this.Capturo_Numeros);
			// 
			// btn_6
			// 
			this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_6.Location = new System.Drawing.Point(191, 318);
			this.btn_6.Name = "btn_6";
			this.btn_6.Size = new System.Drawing.Size(53, 34);
			this.btn_6.TabIndex = 12;
			this.btn_6.Text = "6";
			this.btn_6.UseVisualStyleBackColor = true;
			this.btn_6.Click += new System.EventHandler(this.Capturo_Numeros);
			// 
			// btn_resta
			// 
			this.btn_resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_resta.Location = new System.Drawing.Point(268, 318);
			this.btn_resta.Name = "btn_resta";
			this.btn_resta.Size = new System.Drawing.Size(53, 34);
			this.btn_resta.TabIndex = 13;
			this.btn_resta.Text = "-";
			this.btn_resta.UseVisualStyleBackColor = true;
			// 
			// btn_1
			// 
			this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_1.Location = new System.Drawing.Point(36, 379);
			this.btn_1.Name = "btn_1";
			this.btn_1.Size = new System.Drawing.Size(53, 34);
			this.btn_1.TabIndex = 14;
			this.btn_1.Text = "1";
			this.btn_1.UseVisualStyleBackColor = true;
			this.btn_1.Click += new System.EventHandler(this.Capturo_Numeros);
			// 
			// btn_2
			// 
			this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_2.Location = new System.Drawing.Point(113, 379);
			this.btn_2.Name = "btn_2";
			this.btn_2.Size = new System.Drawing.Size(53, 34);
			this.btn_2.TabIndex = 15;
			this.btn_2.Text = "2";
			this.btn_2.UseVisualStyleBackColor = true;
			this.btn_2.Click += new System.EventHandler(this.Capturo_Numeros);
			// 
			// btn_3
			// 
			this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_3.Location = new System.Drawing.Point(191, 379);
			this.btn_3.Name = "btn_3";
			this.btn_3.Size = new System.Drawing.Size(53, 34);
			this.btn_3.TabIndex = 16;
			this.btn_3.Text = "3";
			this.btn_3.UseVisualStyleBackColor = true;
			this.btn_3.Click += new System.EventHandler(this.Capturo_Numeros);
			// 
			// btn_suma
			// 
			this.btn_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suma.Location = new System.Drawing.Point(268, 379);
			this.btn_suma.Name = "btn_suma";
			this.btn_suma.Size = new System.Drawing.Size(53, 34);
			this.btn_suma.TabIndex = 17;
			this.btn_suma.Text = "+";
			this.btn_suma.UseVisualStyleBackColor = true;
			// 
			// btn_credits
			// 
			this.btn_credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_credits.Location = new System.Drawing.Point(35, 439);
			this.btn_credits.Name = "btn_credits";
			this.btn_credits.Size = new System.Drawing.Size(53, 34);
			this.btn_credits.TabIndex = 18;
			this.btn_credits.Text = "M & G";
			this.btn_credits.UseVisualStyleBackColor = true;
			// 
			// btn_0
			// 
			this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_0.Location = new System.Drawing.Point(113, 439);
			this.btn_0.Name = "btn_0";
			this.btn_0.Size = new System.Drawing.Size(53, 34);
			this.btn_0.TabIndex = 19;
			this.btn_0.Text = "0";
			this.btn_0.UseVisualStyleBackColor = true;
			this.btn_0.Click += new System.EventHandler(this.Capturo_Numeros);
			// 
			// btn_coma
			// 
			this.btn_coma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_coma.Location = new System.Drawing.Point(191, 439);
			this.btn_coma.Name = "btn_coma";
			this.btn_coma.Size = new System.Drawing.Size(53, 34);
			this.btn_coma.TabIndex = 20;
			this.btn_coma.Text = ",";
			this.btn_coma.UseVisualStyleBackColor = true;
			// 
			// btn_resultado
			// 
			this.btn_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_resultado.Location = new System.Drawing.Point(268, 439);
			this.btn_resultado.Name = "btn_resultado";
			this.btn_resultado.Size = new System.Drawing.Size(53, 34);
			this.btn_resultado.TabIndex = 21;
			this.btn_resultado.Text = "=";
			this.btn_resultado.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 514);
			this.Controls.Add(this.btn_resultado);
			this.Controls.Add(this.btn_coma);
			this.Controls.Add(this.btn_0);
			this.Controls.Add(this.btn_credits);
			this.Controls.Add(this.btn_suma);
			this.Controls.Add(this.btn_3);
			this.Controls.Add(this.btn_2);
			this.Controls.Add(this.btn_1);
			this.Controls.Add(this.btn_resta);
			this.Controls.Add(this.btn_6);
			this.Controls.Add(this.btn_5);
			this.Controls.Add(this.btn_4);
			this.Controls.Add(this.btn_multi);
			this.Controls.Add(this.btn_9);
			this.Controls.Add(this.btn_8);
			this.Controls.Add(this.btn_7);
			this.Controls.Add(this.btn_division);
			this.Controls.Add(this.btn_borrar);
			this.Controls.Add(this.btn_c);
			this.Controls.Add(this.btn_ce);
			this.Controls.Add(this.auxiliar);
			this.Controls.Add(this.calcular);
			this.Name = "MainForm";
			this.Text = "CALCULADORA";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}