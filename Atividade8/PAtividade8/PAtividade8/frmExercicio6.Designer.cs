
namespace PAtividade8
{
    partial class frmExercicio6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.lblMediaAlunos = new System.Windows.Forms.Label();
            this.btnAlunos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNotas);
            this.groupBox1.Controls.Add(this.lblMediaAlunos);
            this.groupBox1.Location = new System.Drawing.Point(44, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 350);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Média Alunos";
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(58, 34);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(10, 13);
            this.lblNotas.TabIndex = 1;
            this.lblNotas.Text = "-";
            // 
            // lblMediaAlunos
            // 
            this.lblMediaAlunos.AutoSize = true;
            this.lblMediaAlunos.Location = new System.Drawing.Point(6, 34);
            this.lblMediaAlunos.Name = "lblMediaAlunos";
            this.lblMediaAlunos.Size = new System.Drawing.Size(10, 13);
            this.lblMediaAlunos.TabIndex = 0;
            this.lblMediaAlunos.Text = "-";
            // 
            // btnAlunos
            // 
            this.btnAlunos.Location = new System.Drawing.Point(400, 71);
            this.btnAlunos.Name = "btnAlunos";
            this.btnAlunos.Size = new System.Drawing.Size(75, 61);
            this.btnAlunos.TabIndex = 4;
            this.btnAlunos.Text = "Insira Alunos";
            this.btnAlunos.UseVisualStyleBackColor = true;
            this.btnAlunos.Click += new System.EventHandler(this.btnAlunos_Click);
            // 
            // frmExercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.Controls.Add(this.btnAlunos);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmExercicio6";
            this.Text = "frmExercicio6";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMediaAlunos;
        private System.Windows.Forms.Button btnAlunos;
        private System.Windows.Forms.Label lblNotas;
    }
}