
namespace ConversorPolegadas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_Polegadas = new System.Windows.Forms.Label();
            this.lb_Centimetros = new System.Windows.Forms.Label();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_converter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Polegadas
            // 
            this.lb_Polegadas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Polegadas.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Polegadas.Location = new System.Drawing.Point(12, 274);
            this.lb_Polegadas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Polegadas.Name = "lb_Polegadas";
            this.lb_Polegadas.Size = new System.Drawing.Size(384, 119);
            this.lb_Polegadas.TabIndex = 0;
            this.lb_Polegadas.Text = "Valor em Centimetros";
            this.lb_Polegadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Centimetros
            // 
            this.lb_Centimetros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_Centimetros.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Centimetros.Location = new System.Drawing.Point(12, 155);
            this.lb_Centimetros.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Centimetros.Name = "lb_Centimetros";
            this.lb_Centimetros.Size = new System.Drawing.Size(384, 119);
            this.lb_Centimetros.TabIndex = 1;
            this.lb_Centimetros.Text = "Valor em Polegadas";
            this.lb_Centimetros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_Valor
            // 
            this.txt_Valor.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Valor.Location = new System.Drawing.Point(53, 72);
            this.txt_Valor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(303, 63);
            this.txt_Valor.TabIndex = 3;
            this.txt_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Digite o valor em Polegadas";
            // 
            // btn_converter
            // 
            this.btn_converter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_converter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_converter.Location = new System.Drawing.Point(12, 397);
            this.btn_converter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_converter.Name = "btn_converter";
            this.btn_converter.Size = new System.Drawing.Size(384, 112);
            this.btn_converter.TabIndex = 5;
            this.btn_converter.Text = "Converter";
            this.btn_converter.UseVisualStyleBackColor = true;
            this.btn_converter.Click += new System.EventHandler(this.btn_converter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 540);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desenvolvido por Miller M. Vasco";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(409, 566);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_converter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.lb_Centimetros);
            this.Controls.Add(this.lb_Polegadas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor Polegadas/Centimetros";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Polegadas;
        private System.Windows.Forms.Label lb_Centimetros;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_converter;
        private System.Windows.Forms.Label label1;
    }
}

