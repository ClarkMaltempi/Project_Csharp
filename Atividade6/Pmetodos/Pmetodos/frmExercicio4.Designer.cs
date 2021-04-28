
namespace Pmetodos
{
    partial class frmExercicio4
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
            this.rchTextBox = new System.Windows.Forms.RichTextBox();
            this.btVarrerNum = new System.Windows.Forms.Button();
            this.btLocalizaEspaco = new System.Windows.Forms.Button();
            this.btContaCaracter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchTextBox
            // 
            this.rchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.rchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTextBox.Location = new System.Drawing.Point(81, 31);
            this.rchTextBox.Name = "rchTextBox";
            this.rchTextBox.Size = new System.Drawing.Size(423, 176);
            this.rchTextBox.TabIndex = 0;
            this.rchTextBox.Text = "";
            // 
            // btVarrerNum
            // 
            this.btVarrerNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVarrerNum.Location = new System.Drawing.Point(81, 237);
            this.btVarrerNum.Name = "btVarrerNum";
            this.btVarrerNum.Size = new System.Drawing.Size(86, 67);
            this.btVarrerNum.TabIndex = 1;
            this.btVarrerNum.Text = "Varrer Texto Encontrar Numero";
            this.btVarrerNum.UseVisualStyleBackColor = true;
            this.btVarrerNum.Click += new System.EventHandler(this.btVarrerNum_Click);
            // 
            // btLocalizaEspaco
            // 
            this.btLocalizaEspaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLocalizaEspaco.Location = new System.Drawing.Point(249, 236);
            this.btLocalizaEspaco.Name = "btLocalizaEspaco";
            this.btLocalizaEspaco.Size = new System.Drawing.Size(94, 68);
            this.btLocalizaEspaco.TabIndex = 2;
            this.btLocalizaEspaco.Text = "Localiza o 1º caracter branco";
            this.btLocalizaEspaco.UseVisualStyleBackColor = true;
            this.btLocalizaEspaco.Click += new System.EventHandler(this.btLocalizaEspaco_Click);
            // 
            // btContaCaracter
            // 
            this.btContaCaracter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btContaCaracter.Location = new System.Drawing.Point(429, 237);
            this.btContaCaracter.Name = "btContaCaracter";
            this.btContaCaracter.Size = new System.Drawing.Size(86, 68);
            this.btContaCaracter.TabIndex = 3;
            this.btContaCaracter.Text = "Contar Caracter Alfabético";
            this.btContaCaracter.UseVisualStyleBackColor = true;
            this.btContaCaracter.Click += new System.EventHandler(this.btContaCaracter_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 375);
            this.Controls.Add(this.btContaCaracter);
            this.Controls.Add(this.btLocalizaEspaco);
            this.Controls.Add(this.btVarrerNum);
            this.Controls.Add(this.rchTextBox);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchTextBox;
        private System.Windows.Forms.Button btVarrerNum;
        private System.Windows.Forms.Button btLocalizaEspaco;
        private System.Windows.Forms.Button btContaCaracter;
    }
}