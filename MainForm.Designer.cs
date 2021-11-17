/*
 * Created by SharpDevelop.
 * User: LAB-02
 * Date: 29/10/2021
 * Time: 20:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculadora
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_ce;
		private System.Windows.Forms.Button btn_dividir;
		private System.Windows.Forms.Button btn_7;
		private System.Windows.Forms.Button btn_8;
		private System.Windows.Forms.Button btn_9;
		private System.Windows.Forms.Button btn_mult;
		private System.Windows.Forms.Button btn_4;
		private System.Windows.Forms.Button btn_5;
		private System.Windows.Forms.Button btn_6;
		private System.Windows.Forms.Button btn_restar;
		private System.Windows.Forms.Button btn_1;
		private System.Windows.Forms.Button btn_2;
		private System.Windows.Forms.Button btn_3;
		private System.Windows.Forms.Button btn_sumar;
		private System.Windows.Forms.Button btn_0;
		private System.Windows.Forms.Button btn_resultado;
		private System.Windows.Forms.Button btn_borrar;
		private System.Windows.Forms.Button btn_c;
		private System.Windows.Forms.Button btn_coma;
		private System.Windows.Forms.Button btn_mas_menos;
		
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
			this.btn_ce = new System.Windows.Forms.Button();
			this.btn_dividir = new System.Windows.Forms.Button();
			this.btn_7 = new System.Windows.Forms.Button();
			this.btn_8 = new System.Windows.Forms.Button();
			this.btn_9 = new System.Windows.Forms.Button();
			this.btn_mult = new System.Windows.Forms.Button();
			this.btn_4 = new System.Windows.Forms.Button();
			this.btn_5 = new System.Windows.Forms.Button();
			this.btn_6 = new System.Windows.Forms.Button();
			this.btn_restar = new System.Windows.Forms.Button();
			this.btn_1 = new System.Windows.Forms.Button();
			this.btn_2 = new System.Windows.Forms.Button();
			this.btn_3 = new System.Windows.Forms.Button();
			this.btn_sumar = new System.Windows.Forms.Button();
			this.btn_0 = new System.Windows.Forms.Button();
			this.btn_resultado = new System.Windows.Forms.Button();
			this.btn_borrar = new System.Windows.Forms.Button();
			this.btn_c = new System.Windows.Forms.Button();
			this.btn_coma = new System.Windows.Forms.Button();
			this.btn_mas_menos = new System.Windows.Forms.Button();
			this.txt_resultados = new System.Windows.Forms.TextBox();
			this.txt_resultados2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_ce
			// 
			this.btn_ce.Location = new System.Drawing.Point(33, 94);
			this.btn_ce.Name = "btn_ce";
			this.btn_ce.Size = new System.Drawing.Size(42, 41);
			this.btn_ce.TabIndex = 0;
			this.btn_ce.Text = "CE";
			this.btn_ce.UseVisualStyleBackColor = true;
			this.btn_ce.Click += new System.EventHandler(this.Btn_ceClick);
			// 
			// btn_dividir
			// 
			this.btn_dividir.Location = new System.Drawing.Point(177, 94);
			this.btn_dividir.Name = "btn_dividir";
			this.btn_dividir.Size = new System.Drawing.Size(42, 41);
			this.btn_dividir.TabIndex = 3;
			this.btn_dividir.Text = "/";
			this.btn_dividir.UseVisualStyleBackColor = true;
			this.btn_dividir.Click += new System.EventHandler(this.Btn_sumarClick);
			// 
			// btn_7
			// 
			this.btn_7.Location = new System.Drawing.Point(33, 141);
			this.btn_7.Name = "btn_7";
			this.btn_7.Size = new System.Drawing.Size(42, 41);
			this.btn_7.TabIndex = 4;
			this.btn_7.Text = "7";
			this.btn_7.UseVisualStyleBackColor = true;
			this.btn_7.Click += new System.EventHandler(this.Btn_1Click);
			// 
			// btn_8
			// 
			this.btn_8.Location = new System.Drawing.Point(81, 141);
			this.btn_8.Name = "btn_8";
			this.btn_8.Size = new System.Drawing.Size(42, 41);
			this.btn_8.TabIndex = 5;
			this.btn_8.Text = "8";
			this.btn_8.UseVisualStyleBackColor = true;
			this.btn_8.Click += new System.EventHandler(this.Btn_1Click);
			// 
			// btn_9
			// 
			this.btn_9.Location = new System.Drawing.Point(129, 141);
			this.btn_9.Name = "btn_9";
			this.btn_9.Size = new System.Drawing.Size(42, 41);
			this.btn_9.TabIndex = 6;
			this.btn_9.Text = "9";
			this.btn_9.UseVisualStyleBackColor = true;
			this.btn_9.Click += new System.EventHandler(this.Btn_1Click);
			// 
			// btn_mult
			// 
			this.btn_mult.Location = new System.Drawing.Point(177, 141);
			this.btn_mult.Name = "btn_mult";
			this.btn_mult.Size = new System.Drawing.Size(42, 41);
			this.btn_mult.TabIndex = 7;
			this.btn_mult.Text = "X";
			this.btn_mult.UseVisualStyleBackColor = true;
			this.btn_mult.Click += new System.EventHandler(this.Btn_sumarClick);
			// 
			// btn_4
			// 
			this.btn_4.Location = new System.Drawing.Point(33, 188);
			this.btn_4.Name = "btn_4";
			this.btn_4.Size = new System.Drawing.Size(42, 41);
			this.btn_4.TabIndex = 8;
			this.btn_4.Text = "4";
			this.btn_4.UseVisualStyleBackColor = true;
			this.btn_4.Click += new System.EventHandler(this.Btn_1Click);
			// 
			// btn_5
			// 
			this.btn_5.Location = new System.Drawing.Point(81, 188);
			this.btn_5.Name = "btn_5";
			this.btn_5.Size = new System.Drawing.Size(42, 41);
			this.btn_5.TabIndex = 9;
			this.btn_5.Text = "5";
			this.btn_5.UseVisualStyleBackColor = true;
			this.btn_5.Click += new System.EventHandler(this.Btn_1Click);
			// 
			// btn_6
			// 
			this.btn_6.Location = new System.Drawing.Point(129, 188);
			this.btn_6.Name = "btn_6";
			this.btn_6.Size = new System.Drawing.Size(42, 41);
			this.btn_6.TabIndex = 10;
			this.btn_6.Text = "6";
			this.btn_6.UseVisualStyleBackColor = true;
			this.btn_6.Click += new System.EventHandler(this.Btn_1Click);
			// 
			// btn_restar
			// 
			this.btn_restar.Location = new System.Drawing.Point(177, 188);
			this.btn_restar.Name = "btn_restar";
			this.btn_restar.Size = new System.Drawing.Size(42, 41);
			this.btn_restar.TabIndex = 11;
			this.btn_restar.Text = "-";
			this.btn_restar.UseVisualStyleBackColor = true;
			this.btn_restar.Click += new System.EventHandler(this.Btn_sumarClick);
			// 
			// btn_1
			// 
			this.btn_1.Location = new System.Drawing.Point(33, 235);
			this.btn_1.Name = "btn_1";
			this.btn_1.Size = new System.Drawing.Size(42, 41);
			this.btn_1.TabIndex = 12;
			this.btn_1.Text = "1";
			this.btn_1.UseVisualStyleBackColor = true;
			this.btn_1.Click += new System.EventHandler(this.Btn_1Click);
			// 
			// btn_2
			// 
			this.btn_2.Location = new System.Drawing.Point(81, 235);
			this.btn_2.Name = "btn_2";
			this.btn_2.Size = new System.Drawing.Size(42, 41);
			this.btn_2.TabIndex = 13;
			this.btn_2.Text = "2";
			this.btn_2.UseVisualStyleBackColor = true;
			this.btn_2.Click += new System.EventHandler(this.Btn_1Click);
			// 
			// btn_3
			// 
			this.btn_3.Location = new System.Drawing.Point(129, 235);
			this.btn_3.Name = "btn_3";
			this.btn_3.Size = new System.Drawing.Size(42, 41);
			this.btn_3.TabIndex = 14;
			this.btn_3.Text = "3";
			this.btn_3.UseVisualStyleBackColor = true;
			this.btn_3.Click += new System.EventHandler(this.Btn_1Click);
			// 
			// btn_sumar
			// 
			this.btn_sumar.Location = new System.Drawing.Point(177, 235);
			this.btn_sumar.Name = "btn_sumar";
			this.btn_sumar.Size = new System.Drawing.Size(42, 41);
			this.btn_sumar.TabIndex = 15;
			this.btn_sumar.Text = "+";
			this.btn_sumar.UseVisualStyleBackColor = true;
			this.btn_sumar.Click += new System.EventHandler(this.Btn_sumarClick);
			// 
			// btn_0
			// 
			this.btn_0.Location = new System.Drawing.Point(81, 282);
			this.btn_0.Name = "btn_0";
			this.btn_0.Size = new System.Drawing.Size(42, 41);
			this.btn_0.TabIndex = 16;
			this.btn_0.Text = "0";
			this.btn_0.UseVisualStyleBackColor = true;
			this.btn_0.Click += new System.EventHandler(this.Btn_1Click);
			// 
			// btn_resultado
			// 
			this.btn_resultado.Location = new System.Drawing.Point(177, 282);
			this.btn_resultado.Name = "btn_resultado";
			this.btn_resultado.Size = new System.Drawing.Size(42, 41);
			this.btn_resultado.TabIndex = 18;
			this.btn_resultado.Text = "=";
			this.btn_resultado.UseVisualStyleBackColor = true;
			this.btn_resultado.Click += new System.EventHandler(this.Btn_resultadoClick);
			// 
			// btn_borrar
			// 
			this.btn_borrar.Location = new System.Drawing.Point(129, 94);
			this.btn_borrar.Name = "btn_borrar";
			this.btn_borrar.Size = new System.Drawing.Size(42, 41);
			this.btn_borrar.TabIndex = 1;
			this.btn_borrar.Text = "←";
			this.btn_borrar.UseVisualStyleBackColor = true;
			this.btn_borrar.Click += new System.EventHandler(this.Btn_borrarClick);
			// 
			// btn_c
			// 
			this.btn_c.Location = new System.Drawing.Point(81, 94);
			this.btn_c.Name = "btn_c";
			this.btn_c.Size = new System.Drawing.Size(42, 41);
			this.btn_c.TabIndex = 2;
			this.btn_c.Text = "C";
			this.btn_c.UseVisualStyleBackColor = true;
			this.btn_c.Click += new System.EventHandler(this.Btn_cClick);
			// 
			// btn_coma
			// 
			this.btn_coma.Location = new System.Drawing.Point(129, 282);
			this.btn_coma.Name = "btn_coma";
			this.btn_coma.Size = new System.Drawing.Size(42, 41);
			this.btn_coma.TabIndex = 19;
			this.btn_coma.Text = ",";
			this.btn_coma.UseVisualStyleBackColor = true;
			this.btn_coma.Click += new System.EventHandler(this.Btn_1Click);
			// 
			// btn_mas_menos
			// 
			this.btn_mas_menos.Location = new System.Drawing.Point(33, 282);
			this.btn_mas_menos.Name = "btn_mas_menos";
			this.btn_mas_menos.Size = new System.Drawing.Size(42, 41);
			this.btn_mas_menos.TabIndex = 20;
			this.btn_mas_menos.Text = "±";
			this.btn_mas_menos.UseVisualStyleBackColor = true;
			this.btn_mas_menos.Click += new System.EventHandler(this.Btn_mas_menosClick);
			// 
			// txt_resultados
			// 
			this.txt_resultados.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_resultados.Location = new System.Drawing.Point(33, 42);
			this.txt_resultados.MaxLength = 10;
			this.txt_resultados.Multiline = true;
			this.txt_resultados.Name = "txt_resultados";
			this.txt_resultados.ReadOnly = true;
			this.txt_resultados.Size = new System.Drawing.Size(186, 33);
			this.txt_resultados.TabIndex = 21;
			this.txt_resultados.Text = "0";
			this.txt_resultados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txt_resultados2
			// 
			this.txt_resultados2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_resultados2.Location = new System.Drawing.Point(144, 17);
			this.txt_resultados2.Name = "txt_resultados2";
			this.txt_resultados2.ReadOnly = true;
			this.txt_resultados2.Size = new System.Drawing.Size(74, 22);
			this.txt_resultados2.TabIndex = 22;
			this.txt_resultados2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(244, 360);
			this.Controls.Add(this.txt_resultados2);
			this.Controls.Add(this.txt_resultados);
			this.Controls.Add(this.btn_mas_menos);
			this.Controls.Add(this.btn_coma);
			this.Controls.Add(this.btn_resultado);
			this.Controls.Add(this.btn_0);
			this.Controls.Add(this.btn_sumar);
			this.Controls.Add(this.btn_3);
			this.Controls.Add(this.btn_2);
			this.Controls.Add(this.btn_1);
			this.Controls.Add(this.btn_restar);
			this.Controls.Add(this.btn_6);
			this.Controls.Add(this.btn_5);
			this.Controls.Add(this.btn_4);
			this.Controls.Add(this.btn_mult);
			this.Controls.Add(this.btn_9);
			this.Controls.Add(this.btn_8);
			this.Controls.Add(this.btn_7);
			this.Controls.Add(this.btn_dividir);
			this.Controls.Add(this.btn_c);
			this.Controls.Add(this.btn_borrar);
			this.Controls.Add(this.btn_ce);
			this.KeyPreview = true;
			this.Name = "MainForm";
			this.Text = "Calculadora";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txt_resultados2;
		private System.Windows.Forms.TextBox txt_resultados;
	}
}
