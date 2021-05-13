
namespace PAtividade7
{
    partial class frmExercicio1 
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTxtTexto = new System.Windows.Forms.RichTextBox();
            this.btnEspaçoBranco = new System.Windows.Forms.Button();
            this.btnAparecerR = new System.Windows.Forms.Button();
            this.btnParLetras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxtTexto
            // 
            this.richTxtTexto.Location = new System.Drawing.Point(99, 39);
            this.richTxtTexto.Name = "richTxtTexto";
            this.richTxtTexto.Size = new System.Drawing.Size(449, 155);
            this.richTxtTexto.TabIndex = 0;
            this.richTxtTexto.Text = "";
            // 
            // btnEspaçoBranco
            // 
            this.btnEspaçoBranco.Location = new System.Drawing.Point(140, 219);
            this.btnEspaçoBranco.Name = "btnEspaçoBranco";
            this.btnEspaçoBranco.Size = new System.Drawing.Size(75, 54);
            this.btnEspaçoBranco.TabIndex = 1;
            this.btnEspaçoBranco.Text = "Espaço Branco";
            this.btnEspaçoBranco.UseVisualStyleBackColor = true;
            this.btnEspaçoBranco.Click += new System.EventHandler(this.btnEspaçoBranco_Click);
            // 
            // btnAparecerR
            // 
            this.btnAparecerR.Location = new System.Drawing.Point(271, 219);
            this.btnAparecerR.Name = "btnAparecerR";
            this.btnAparecerR.Size = new System.Drawing.Size(75, 54);
            this.btnAparecerR.TabIndex = 2;
            this.btnAparecerR.Text = "Qtd Letra R";
            this.btnAparecerR.UseVisualStyleBackColor = true;
            this.btnAparecerR.Click += new System.EventHandler(this.btnAparecerR_Click);
            // 
            // btnParLetras
            // 
            this.btnParLetras.Location = new System.Drawing.Point(406, 219);
            this.btnParLetras.Name = "btnParLetras";
            this.btnParLetras.Size = new System.Drawing.Size(75, 54);
            this.btnParLetras.TabIndex = 3;
            this.btnParLetras.Text = "Par Letras";
            this.btnParLetras.UseVisualStyleBackColor = true;
            this.btnParLetras.Click += new System.EventHandler(this.btnParLetras_Click);
            // 
            // frmExercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParLetras);
            this.Controls.Add(this.btnAparecerR);
            this.Controls.Add(this.btnEspaçoBranco);
            this.Controls.Add(this.richTxtTexto);
            this.Name = "frmExercicio1";
            this.Text = "frmExercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtTexto;
        private System.Windows.Forms.Button btnEspaçoBranco;
        private System.Windows.Forms.Button btnAparecerR;
        private System.Windows.Forms.Button btnParLetras;
    }
}