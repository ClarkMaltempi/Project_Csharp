
namespace PAtividade8
{
    partial class frmExercicio7
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
            this.btnExecutar = new System.Windows.Forms.Button();
            this.ListaNomes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(80, 140);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(75, 54);
            this.btnExecutar.TabIndex = 1;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // ListaNomes
            // 
            this.ListaNomes.FormattingEnabled = true;
            this.ListaNomes.Location = new System.Drawing.Point(242, 12);
            this.ListaNomes.Name = "ListaNomes";
            this.ListaNomes.Size = new System.Drawing.Size(372, 342);
            this.ListaNomes.TabIndex = 2;
            // 
            // frmExercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListaNomes);
            this.Controls.Add(this.btnExecutar);
            this.Name = "frmExercicio7";
            this.Text = "frmExercicio7";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.ListBox ListaNomes;
    }
}