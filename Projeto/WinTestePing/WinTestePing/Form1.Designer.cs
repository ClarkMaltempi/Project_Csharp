
namespace WinTestePing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblOuteirosLadoMar = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblCostaLeiteSaida = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ckBoxBalRodo = new System.Windows.Forms.CheckBox();
            this.ckBox2Ferrovia = new System.Windows.Forms.CheckBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblCostaLeiteEntrada = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblXXIII = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lblMoegaEnt = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblMoegaSaida = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lblM1Ent = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOuteirosLadoTerra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 18);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(149, 15);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Balança Outeiros Lado Mar";
            // 
            // lblOuteirosLadoMar
            // 
            this.lblOuteirosLadoMar.AutoSize = true;
            this.lblOuteirosLadoMar.BackColor = System.Drawing.Color.PaleGreen;
            this.lblOuteirosLadoMar.Location = new System.Drawing.Point(161, 18);
            this.lblOuteirosLadoMar.Name = "lblOuteirosLadoMar";
            this.lblOuteirosLadoMar.Size = new System.Drawing.Size(25, 15);
            this.lblOuteirosLadoMar.TabIndex = 2;
            this.lblOuteirosLadoMar.Text = "ON";
            this.lblOuteirosLadoMar.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(321, 55);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(148, 15);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Balança Costa Leite - Saída";
            // 
            // lblCostaLeiteSaida
            // 
            this.lblCostaLeiteSaida.AutoSize = true;
            this.lblCostaLeiteSaida.BackColor = System.Drawing.Color.PaleGreen;
            this.lblCostaLeiteSaida.Location = new System.Drawing.Point(475, 55);
            this.lblCostaLeiteSaida.Name = "lblCostaLeiteSaida";
            this.lblCostaLeiteSaida.Size = new System.Drawing.Size(25, 15);
            this.lblCostaLeiteSaida.TabIndex = 4;
            this.lblCostaLeiteSaida.Text = "ON";
            this.lblCostaLeiteSaida.Click += new System.EventHandler(this.lblCostaLeiteSaida_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(28, 257);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(34, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Atualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckBoxBalRodo
            // 
            this.ckBoxBalRodo.AutoSize = true;
            this.ckBoxBalRodo.Location = new System.Drawing.Point(85, 12);
            this.ckBoxBalRodo.Name = "ckBoxBalRodo";
            this.ckBoxBalRodo.Size = new System.Drawing.Size(111, 19);
            this.ckBoxBalRodo.TabIndex = 7;
            this.ckBoxBalRodo.Text = "Balanca SPRodo";
            this.ckBoxBalRodo.UseVisualStyleBackColor = true;
            this.ckBoxBalRodo.CheckedChanged += new System.EventHandler(this.ckBoxBalRodo_CheckedChanged);
            // 
            // ckBox2Ferrovia
            // 
            this.ckBox2Ferrovia.AutoSize = true;
            this.ckBox2Ferrovia.Location = new System.Drawing.Point(357, 12);
            this.ckBox2Ferrovia.Name = "ckBox2Ferrovia";
            this.ckBox2Ferrovia.Size = new System.Drawing.Size(112, 19);
            this.ckBox2Ferrovia.TabIndex = 8;
            this.ckBox2Ferrovia.Text = "Balanca Ferrovia";
            this.ckBox2Ferrovia.UseVisualStyleBackColor = true;
            this.ckBox2Ferrovia.CheckedChanged += new System.EventHandler(this.ckBox2Ferrovia_CheckedChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(321, 80);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(137, 15);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "Balança Costa Leite - Ent";
            // 
            // lblCostaLeiteEntrada
            // 
            this.lblCostaLeiteEntrada.AutoSize = true;
            this.lblCostaLeiteEntrada.BackColor = System.Drawing.Color.PaleGreen;
            this.lblCostaLeiteEntrada.Location = new System.Drawing.Point(475, 80);
            this.lblCostaLeiteEntrada.Name = "lblCostaLeiteEntrada";
            this.lblCostaLeiteEntrada.Size = new System.Drawing.Size(25, 15);
            this.lblCostaLeiteEntrada.TabIndex = 10;
            this.lblCostaLeiteEntrada.Text = "ON";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(321, 106);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(30, 15);
            this.lbl4.TabIndex = 11;
            this.lbl4.Text = "XXIII";
            // 
            // lblXXIII
            // 
            this.lblXXIII.AutoSize = true;
            this.lblXXIII.BackColor = System.Drawing.Color.PaleGreen;
            this.lblXXIII.Location = new System.Drawing.Point(475, 106);
            this.lblXXIII.Name = "lblXXIII";
            this.lblXXIII.Size = new System.Drawing.Size(25, 15);
            this.lblXXIII.TabIndex = 12;
            this.lblXXIII.Text = "ON";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(321, 132);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(94, 15);
            this.lbl5.TabIndex = 13;
            this.lbl5.Text = "Moegão Entrada";
            // 
            // lblMoegaEnt
            // 
            this.lblMoegaEnt.AutoSize = true;
            this.lblMoegaEnt.BackColor = System.Drawing.Color.PaleGreen;
            this.lblMoegaEnt.Location = new System.Drawing.Point(475, 132);
            this.lblMoegaEnt.Name = "lblMoegaEnt";
            this.lblMoegaEnt.Size = new System.Drawing.Size(25, 15);
            this.lblMoegaEnt.TabIndex = 14;
            this.lblMoegaEnt.Text = "ON";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(321, 159);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(82, 15);
            this.lbl6.TabIndex = 15;
            this.lbl6.Text = "Moegão Saída";
            // 
            // lblMoegaSaida
            // 
            this.lblMoegaSaida.AutoSize = true;
            this.lblMoegaSaida.BackColor = System.Drawing.Color.PaleGreen;
            this.lblMoegaSaida.Location = new System.Drawing.Point(475, 159);
            this.lblMoegaSaida.Name = "lblMoegaSaida";
            this.lblMoegaSaida.Size = new System.Drawing.Size(25, 15);
            this.lblMoegaSaida.TabIndex = 16;
            this.lblMoegaSaida.Text = "ON";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(321, 185);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(91, 15);
            this.lbl7.TabIndex = 17;
            this.lbl7.Text = "M1 Entrada (b2)";
            // 
            // lblM1Ent
            // 
            this.lblM1Ent.AutoSize = true;
            this.lblM1Ent.BackColor = System.Drawing.Color.PaleGreen;
            this.lblM1Ent.Location = new System.Drawing.Point(475, 185);
            this.lblM1Ent.Name = "lblM1Ent";
            this.lblM1Ent.Size = new System.Drawing.Size(25, 15);
            this.lblM1Ent.TabIndex = 18;
            this.lblM1Ent.Text = "ON";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(306, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 184);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOuteirosLadoTerra);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Controls.Add(this.lblOuteirosLadoMar);
            this.groupBox2.Location = new System.Drawing.Point(47, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 184);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // lblOuteirosLadoTerra
            // 
            this.lblOuteirosLadoTerra.AutoSize = true;
            this.lblOuteirosLadoTerra.BackColor = System.Drawing.Color.PaleGreen;
            this.lblOuteirosLadoTerra.Location = new System.Drawing.Point(161, 43);
            this.lblOuteirosLadoTerra.Name = "lblOuteirosLadoTerra";
            this.lblOuteirosLadoTerra.Size = new System.Drawing.Size(25, 15);
            this.lblOuteirosLadoTerra.TabIndex = 4;
            this.lblOuteirosLadoTerra.Text = "ON";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Balança Outeiros Lado Terra";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 301);
            this.Controls.Add(this.lblM1Ent);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lblMoegaSaida);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lblMoegaEnt);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lblXXIII);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblCostaLeiteEntrada);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.ckBox2Ferrovia);
            this.Controls.Add(this.ckBoxBalRodo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblCostaLeiteSaida);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblOuteirosLadoMar;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblCostaLeiteSaida;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckBoxBalRodo;
        private System.Windows.Forms.CheckBox ckBox2Ferrovia;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblCostaLeiteEntrada;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblXXIII;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblMoegaEnt;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lblMoegaSaida;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lblM1Ent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOuteirosLadoTerra;
        private System.Windows.Forms.Label label1;
    }
}

