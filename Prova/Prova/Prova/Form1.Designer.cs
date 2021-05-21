
namespace Prova
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.ListaBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.BackColor = System.Drawing.Color.DarkOrange;
            this.btnExecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecutar.ForeColor = System.Drawing.Color.Maroon;
            this.btnExecutar.Location = new System.Drawing.Point(91, 144);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(93, 68);
            this.btnExecutar.TabIndex = 0;
            this.btnExecutar.Text = "Cadastro Vendas";
            this.btnExecutar.UseVisualStyleBackColor = false;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // ListaBox
            // 
            this.ListaBox.FormattingEnabled = true;
            this.ListaBox.Location = new System.Drawing.Point(245, 36);
            this.ListaBox.Name = "ListaBox";
            this.ListaBox.Size = new System.Drawing.Size(387, 277);
            this.ListaBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(667, 354);
            this.Controls.Add(this.ListaBox);
            this.Controls.Add(this.btnExecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ListBox ListaBox;
    }
}

