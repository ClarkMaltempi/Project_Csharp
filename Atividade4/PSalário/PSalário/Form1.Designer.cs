
namespace PSalário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblnome = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblFilhos = new System.Windows.Forms.Label();
            this.txtBoxNomeFunc = new System.Windows.Forms.TextBox();
            this.mskSalarioBruto = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxFilhos = new System.Windows.Forms.ComboBox();
            this.ckBoxMasc = new System.Windows.Forms.CheckBox();
            this.ckBoxFem = new System.Windows.Forms.CheckBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.ckCasado = new System.Windows.Forms.CheckBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.txtBoxINSS = new System.Windows.Forms.TextBox();
            this.txtBoxIR = new System.Windows.Forms.TextBox();
            this.txtBoxSalFamilia = new System.Windows.Forms.TextBox();
            this.lblINSS = new System.Windows.Forms.Label();
            this.gpBoxSexo = new System.Windows.Forms.GroupBox();
            this.lblIR = new System.Windows.Forms.Label();
            this.lblSalarioFamilia = new System.Windows.Forms.Label();
            this.txtSalLiquido = new System.Windows.Forms.TextBox();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.txtDescontoINSS = new System.Windows.Forms.TextBox();
            this.lblDescontoINSS = new System.Windows.Forms.Label();
            this.lblDescontoIR = new System.Windows.Forms.Label();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckSolteiro = new System.Windows.Forms.CheckBox();
            this.gpBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            resources.ApplyResources(this.lblnome, "lblnome");
            this.lblnome.Name = "lblnome";
            // 
            // lblSalarioBruto
            // 
            resources.ApplyResources(this.lblSalarioBruto, "lblSalarioBruto");
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            // 
            // lblFilhos
            // 
            resources.ApplyResources(this.lblFilhos, "lblFilhos");
            this.lblFilhos.Name = "lblFilhos";
            // 
            // txtBoxNomeFunc
            // 
            resources.ApplyResources(this.txtBoxNomeFunc, "txtBoxNomeFunc");
            this.txtBoxNomeFunc.Name = "txtBoxNomeFunc";
            // 
            // mskSalarioBruto
            // 
            resources.ApplyResources(this.mskSalarioBruto, "mskSalarioBruto");
            this.mskSalarioBruto.Name = "mskSalarioBruto";
            // 
            // comboBoxFilhos
            // 
            resources.ApplyResources(this.comboBoxFilhos, "comboBoxFilhos");
            this.comboBoxFilhos.FormattingEnabled = true;
            this.comboBoxFilhos.Items.AddRange(new object[] {
            resources.GetString("comboBoxFilhos.Items"),
            resources.GetString("comboBoxFilhos.Items1"),
            resources.GetString("comboBoxFilhos.Items2"),
            resources.GetString("comboBoxFilhos.Items3"),
            resources.GetString("comboBoxFilhos.Items4"),
            resources.GetString("comboBoxFilhos.Items5"),
            resources.GetString("comboBoxFilhos.Items6"),
            resources.GetString("comboBoxFilhos.Items7"),
            resources.GetString("comboBoxFilhos.Items8")});
            this.comboBoxFilhos.Name = "comboBoxFilhos";
            // 
            // ckBoxMasc
            // 
            resources.ApplyResources(this.ckBoxMasc, "ckBoxMasc");
            this.ckBoxMasc.Name = "ckBoxMasc";
            this.ckBoxMasc.UseVisualStyleBackColor = true;
            this.ckBoxMasc.CheckedChanged += new System.EventHandler(this.ckBoxMasc_CheckedChanged);
            // 
            // ckBoxFem
            // 
            resources.ApplyResources(this.ckBoxFem, "ckBoxFem");
            this.ckBoxFem.Name = "ckBoxFem";
            this.ckBoxFem.UseVisualStyleBackColor = true;
            this.ckBoxFem.CheckedChanged += new System.EventHandler(this.ckBoxFem_CheckedChanged);
            // 
            // btnVerifica
            // 
            this.btnVerifica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnVerifica, "btnVerifica");
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.UseVisualStyleBackColor = false;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // ckCasado
            // 
            resources.ApplyResources(this.ckCasado, "ckCasado");
            this.ckCasado.Name = "ckCasado";
            this.ckCasado.UseVisualStyleBackColor = true;
            this.ckCasado.CheckedChanged += new System.EventHandler(this.ckCasado_CheckedChanged);
            // 
            // lblMensagem
            // 
            resources.ApplyResources(this.lblMensagem, "lblMensagem");
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Click += new System.EventHandler(this.lblMensagem_Click);
            // 
            // txtBoxINSS
            // 
            resources.ApplyResources(this.txtBoxINSS, "txtBoxINSS");
            this.txtBoxINSS.Name = "txtBoxINSS";
            // 
            // txtBoxIR
            // 
            resources.ApplyResources(this.txtBoxIR, "txtBoxIR");
            this.txtBoxIR.Name = "txtBoxIR";
            // 
            // txtBoxSalFamilia
            // 
            resources.ApplyResources(this.txtBoxSalFamilia, "txtBoxSalFamilia");
            this.txtBoxSalFamilia.Name = "txtBoxSalFamilia";
            // 
            // lblINSS
            // 
            resources.ApplyResources(this.lblINSS, "lblINSS");
            this.lblINSS.Name = "lblINSS";
            // 
            // gpBoxSexo
            // 
            this.gpBoxSexo.Controls.Add(this.ckBoxFem);
            this.gpBoxSexo.Controls.Add(this.ckBoxMasc);
            resources.ApplyResources(this.gpBoxSexo, "gpBoxSexo");
            this.gpBoxSexo.Name = "gpBoxSexo";
            this.gpBoxSexo.TabStop = false;
            this.gpBoxSexo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblIR
            // 
            resources.ApplyResources(this.lblIR, "lblIR");
            this.lblIR.Name = "lblIR";
            // 
            // lblSalarioFamilia
            // 
            resources.ApplyResources(this.lblSalarioFamilia, "lblSalarioFamilia");
            this.lblSalarioFamilia.Name = "lblSalarioFamilia";
            // 
            // txtSalLiquido
            // 
            resources.ApplyResources(this.txtSalLiquido, "txtSalLiquido");
            this.txtSalLiquido.Name = "txtSalLiquido";
            // 
            // lblSalLiquido
            // 
            resources.ApplyResources(this.lblSalLiquido, "lblSalLiquido");
            this.lblSalLiquido.Name = "lblSalLiquido";
            // 
            // txtDescontoINSS
            // 
            resources.ApplyResources(this.txtDescontoINSS, "txtDescontoINSS");
            this.txtDescontoINSS.Name = "txtDescontoINSS";
            // 
            // lblDescontoINSS
            // 
            resources.ApplyResources(this.lblDescontoINSS, "lblDescontoINSS");
            this.lblDescontoINSS.Name = "lblDescontoINSS";
            // 
            // lblDescontoIR
            // 
            resources.ApplyResources(this.lblDescontoIR, "lblDescontoIR");
            this.lblDescontoIR.Name = "lblDescontoIR";
            // 
            // txtIR
            // 
            resources.ApplyResources(this.txtIR, "txtIR");
            this.txtIR.Name = "txtIR";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_2);
            // 
            // ckSolteiro
            // 
            resources.ApplyResources(this.ckSolteiro, "ckSolteiro");
            this.ckSolteiro.Name = "ckSolteiro";
            this.ckSolteiro.UseVisualStyleBackColor = true;
            this.ckSolteiro.CheckedChanged += new System.EventHandler(this.ckSolteiro_CheckedChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.ckSolteiro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIR);
            this.Controls.Add(this.lblDescontoIR);
            this.Controls.Add(this.lblDescontoINSS);
            this.Controls.Add(this.txtDescontoINSS);
            this.Controls.Add(this.lblSalLiquido);
            this.Controls.Add(this.txtSalLiquido);
            this.Controls.Add(this.lblSalarioFamilia);
            this.Controls.Add(this.lblIR);
            this.Controls.Add(this.gpBoxSexo);
            this.Controls.Add(this.lblINSS);
            this.Controls.Add(this.txtBoxSalFamilia);
            this.Controls.Add(this.txtBoxIR);
            this.Controls.Add(this.txtBoxINSS);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.ckCasado);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.comboBoxFilhos);
            this.Controls.Add(this.mskSalarioBruto);
            this.Controls.Add(this.txtBoxNomeFunc);
            this.Controls.Add(this.lblFilhos);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpBoxSexo.ResumeLayout(false);
            this.gpBoxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblFilhos;
        private System.Windows.Forms.TextBox txtBoxNomeFunc;
        private System.Windows.Forms.MaskedTextBox mskSalarioBruto;
        private System.Windows.Forms.ComboBox comboBoxFilhos;
        private System.Windows.Forms.CheckBox ckBoxMasc;
        private System.Windows.Forms.CheckBox ckBoxFem;
        private System.Windows.Forms.Button btnVerifica;
        private System.Windows.Forms.CheckBox ckCasado;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.TextBox txtBoxINSS;
        private System.Windows.Forms.TextBox txtBoxIR;
        private System.Windows.Forms.TextBox txtBoxSalFamilia;
        private System.Windows.Forms.Label lblINSS;
        private System.Windows.Forms.GroupBox gpBoxSexo;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.Label lblSalarioFamilia;
        private System.Windows.Forms.TextBox txtSalLiquido;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.TextBox txtDescontoINSS;
        private System.Windows.Forms.Label lblDescontoINSS;
        private System.Windows.Forms.Label lblDescontoIR;
        private System.Windows.Forms.TextBox txtIR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckSolteiro;
    }
}

