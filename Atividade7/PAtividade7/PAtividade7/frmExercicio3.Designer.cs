
namespace PAtividade7
{
    partial class frmExercicio3
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
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnTestarPalindromo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(78, 90);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(370, 20);
            this.txtMensagem.TabIndex = 0;
            // 
            // btnTestarPalindromo
            // 
            this.btnTestarPalindromo.Location = new System.Drawing.Point(454, 87);
            this.btnTestarPalindromo.Name = "btnTestarPalindromo";
            this.btnTestarPalindromo.Size = new System.Drawing.Size(146, 23);
            this.btnTestarPalindromo.TabIndex = 1;
            this.btnTestarPalindromo.Text = "Testar Palíndromo";
            this.btnTestarPalindromo.UseVisualStyleBackColor = true;
            this.btnTestarPalindromo.Click += new System.EventHandler(this.btnTestarPalindromo_Click);
            // 
            // frmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTestarPalindromo);
            this.Controls.Add(this.txtMensagem);
            this.Name = "frmExercicio3";
            this.Text = "frmExercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnTestarPalindromo;
    }
}