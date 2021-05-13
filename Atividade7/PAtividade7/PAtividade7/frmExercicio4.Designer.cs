
namespace PAtividade7
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
            this.masktxtSalario = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.masktxtGratificacao = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.masktxtProducao = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.masktxtInscricao = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculaSalario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // masktxtSalario
            // 
            this.masktxtSalario.Location = new System.Drawing.Point(130, 78);
            this.masktxtSalario.Name = "masktxtSalario";
            this.masktxtSalario.Size = new System.Drawing.Size(166, 20);
            this.masktxtSalario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // masktxtGratificacao
            // 
            this.masktxtGratificacao.Location = new System.Drawing.Point(130, 104);
            this.masktxtGratificacao.Name = "masktxtGratificacao";
            this.masktxtGratificacao.Size = new System.Drawing.Size(166, 20);
            this.masktxtGratificacao.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gratificação";
            // 
            // masktxtProducao
            // 
            this.masktxtProducao.Location = new System.Drawing.Point(130, 130);
            this.masktxtProducao.Name = "masktxtProducao";
            this.masktxtProducao.Size = new System.Drawing.Size(166, 20);
            this.masktxtProducao.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Produção";
            // 
            // masktxtInscricao
            // 
            this.masktxtInscricao.Location = new System.Drawing.Point(130, 156);
            this.masktxtInscricao.Name = "masktxtInscricao";
            this.masktxtInscricao.Size = new System.Drawing.Size(166, 20);
            this.masktxtInscricao.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inscrição";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(130, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(304, 20);
            this.txtNome.TabIndex = 8;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(130, 38);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(304, 20);
            this.txtCargo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nome";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cargo";
            // 
            // btnCalculaSalario
            // 
            this.btnCalculaSalario.Location = new System.Drawing.Point(130, 201);
            this.btnCalculaSalario.Name = "btnCalculaSalario";
            this.btnCalculaSalario.Size = new System.Drawing.Size(75, 23);
            this.btnCalculaSalario.TabIndex = 12;
            this.btnCalculaSalario.Text = "Calcular";
            this.btnCalculaSalario.UseVisualStyleBackColor = true;
            this.btnCalculaSalario.Click += new System.EventHandler(this.btnCalculaSalario_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculaSalario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.masktxtInscricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.masktxtProducao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.masktxtGratificacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.masktxtSalario);
            this.Name = "frmExercicio4";
            this.Text = "frmExercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox masktxtSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox masktxtGratificacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox masktxtProducao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox masktxtInscricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculaSalario;
    }
}