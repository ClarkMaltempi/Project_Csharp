
namespace PAtividade7
{
    partial class frmExercicio2 
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
            this.txtNumeroN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerarNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumeroN
            // 
            this.txtNumeroN.Location = new System.Drawing.Point(185, 108);
            this.txtNumeroN.Name = "txtNumeroN";
            this.txtNumeroN.Size = new System.Drawing.Size(148, 20);
            this.txtNumeroN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserir Numero";
            // 
            // btnGerarNum
            // 
            this.btnGerarNum.Location = new System.Drawing.Point(339, 106);
            this.btnGerarNum.Name = "btnGerarNum";
            this.btnGerarNum.Size = new System.Drawing.Size(75, 23);
            this.btnGerarNum.TabIndex = 2;
            this.btnGerarNum.Text = "Gerar";
            this.btnGerarNum.UseVisualStyleBackColor = true;
            this.btnGerarNum.Click += new System.EventHandler(this.btnGerarNum_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerarNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumeroN);
            this.Name = "frmExercicio2";
            this.Text = "frmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerarNum;
    }
}