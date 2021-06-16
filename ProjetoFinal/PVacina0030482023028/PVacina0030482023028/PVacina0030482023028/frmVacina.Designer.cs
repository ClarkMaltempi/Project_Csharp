
namespace PVacina0030482023028
{
    partial class frmVacina
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacina));
            this.bnVacina = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovoRegistro = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAlterar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tbVacina = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgVacina = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbxPrioriVacina = new System.Windows.Forms.ComboBox();
            this.cbxComorbiVacina = new System.Windows.Forms.ComboBox();
            this.cbxTipoVacina = new System.Windows.Forms.ComboBox();
            this.mskbxRgVacina = new System.Windows.Forms.MaskedTextBox();
            this.mskbxCpfVacina = new System.Windows.Forms.MaskedTextBox();
            this.txtEndVacina = new System.Windows.Forms.TextBox();
            this.txtDataVacina = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataNascVacina = new System.Windows.Forms.DateTimePicker();
            this.txtNomeVacina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIDVacina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxEnfermeiro = new System.Windows.Forms.ComboBox();
            this.cbxCidade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.bnVacina)).BeginInit();
            this.bnVacina.SuspendLayout();
            this.tbVacina.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVacina)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnVacina
            // 
            this.bnVacina.AddNewItem = null;
            this.bnVacina.CountItem = this.bindingNavigatorCountItem;
            this.bnVacina.DeleteItem = null;
            this.bnVacina.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnNovoRegistro,
            this.btnSalvar,
            this.btnAlterar,
            this.btnExcluir,
            this.btnCancelar,
            this.btnSair});
            this.bnVacina.Location = new System.Drawing.Point(0, 0);
            this.bnVacina.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnVacina.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnVacina.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnVacina.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnVacina.Name = "bnVacina";
            this.bnVacina.PositionItem = this.bindingNavigatorPositionItem;
            this.bnVacina.Size = new System.Drawing.Size(615, 25);
            this.bnVacina.TabIndex = 0;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnNovoRegistro
            // 
            this.btnNovoRegistro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNovoRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnNovoRegistro.Image")));
            this.btnNovoRegistro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovoRegistro.Name = "btnNovoRegistro";
            this.btnNovoRegistro.Size = new System.Drawing.Size(23, 22);
            this.btnNovoRegistro.Text = "Novo Registro";
            this.btnNovoRegistro.Click += new System.EventHandler(this.btnNovoRegistro_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(23, 22);
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(23, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // tbVacina
            // 
            this.tbVacina.Controls.Add(this.tabPage1);
            this.tbVacina.Controls.Add(this.tabPage2);
            this.tbVacina.Location = new System.Drawing.Point(0, 28);
            this.tbVacina.Name = "tbVacina";
            this.tbVacina.SelectedIndex = 0;
            this.tbVacina.Size = new System.Drawing.Size(634, 510);
            this.tbVacina.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgVacina);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 484);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgVacina
            // 
            this.dgVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVacina.Location = new System.Drawing.Point(3, 3);
            this.dgVacina.Name = "dgVacina";
            this.dgVacina.Size = new System.Drawing.Size(680, 464);
            this.dgVacina.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.cbxCidade);
            this.tabPage2.Controls.Add(this.cbxEnfermeiro);
            this.tabPage2.Controls.Add(this.cbxPrioriVacina);
            this.tabPage2.Controls.Add(this.cbxComorbiVacina);
            this.tabPage2.Controls.Add(this.cbxTipoVacina);
            this.tabPage2.Controls.Add(this.mskbxRgVacina);
            this.tabPage2.Controls.Add(this.mskbxCpfVacina);
            this.tabPage2.Controls.Add(this.txtEndVacina);
            this.tabPage2.Controls.Add(this.txtDataVacina);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtDataNascVacina);
            this.tabPage2.Controls.Add(this.txtNomeVacina);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtIDVacina);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalhes";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // cbxPrioriVacina
            // 
            this.cbxPrioriVacina.AutoCompleteCustomSource.AddRange(new string[] {
            "S",
            "N"});
            this.cbxPrioriVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPrioriVacina.Enabled = false;
            this.cbxPrioriVacina.FormattingEnabled = true;
            this.cbxPrioriVacina.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxPrioriVacina.Location = new System.Drawing.Point(150, 386);
            this.cbxPrioriVacina.Name = "cbxPrioriVacina";
            this.cbxPrioriVacina.Size = new System.Drawing.Size(346, 23);
            this.cbxPrioriVacina.TabIndex = 28;
            // 
            // cbxComorbiVacina
            // 
            this.cbxComorbiVacina.AutoCompleteCustomSource.AddRange(new string[] {
            "S",
            "N"});
            this.cbxComorbiVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxComorbiVacina.Enabled = false;
            this.cbxComorbiVacina.FormattingEnabled = true;
            this.cbxComorbiVacina.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxComorbiVacina.Location = new System.Drawing.Point(150, 347);
            this.cbxComorbiVacina.Name = "cbxComorbiVacina";
            this.cbxComorbiVacina.Size = new System.Drawing.Size(346, 23);
            this.cbxComorbiVacina.TabIndex = 27;
            // 
            // cbxTipoVacina
            // 
            this.cbxTipoVacina.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3"});
            this.cbxTipoVacina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoVacina.Enabled = false;
            this.cbxTipoVacina.FormattingEnabled = true;
            this.cbxTipoVacina.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxTipoVacina.Location = new System.Drawing.Point(320, 318);
            this.cbxTipoVacina.Name = "cbxTipoVacina";
            this.cbxTipoVacina.Size = new System.Drawing.Size(176, 23);
            this.cbxTipoVacina.TabIndex = 26;
            // 
            // mskbxRgVacina
            // 
            this.mskbxRgVacina.Enabled = false;
            this.mskbxRgVacina.Location = new System.Drawing.Point(150, 251);
            this.mskbxRgVacina.Mask = "999999999";
            this.mskbxRgVacina.Name = "mskbxRgVacina";
            this.mskbxRgVacina.Size = new System.Drawing.Size(100, 21);
            this.mskbxRgVacina.TabIndex = 25;
            // 
            // mskbxCpfVacina
            // 
            this.mskbxCpfVacina.Enabled = false;
            this.mskbxCpfVacina.Location = new System.Drawing.Point(150, 224);
            this.mskbxCpfVacina.Mask = "99999999999";
            this.mskbxCpfVacina.Name = "mskbxCpfVacina";
            this.mskbxCpfVacina.Size = new System.Drawing.Size(100, 21);
            this.mskbxCpfVacina.TabIndex = 24;
            // 
            // txtEndVacina
            // 
            this.txtEndVacina.Enabled = false;
            this.txtEndVacina.Location = new System.Drawing.Point(150, 150);
            this.txtEndVacina.MaxLength = 50;
            this.txtEndVacina.Name = "txtEndVacina";
            this.txtEndVacina.Size = new System.Drawing.Size(346, 21);
            this.txtEndVacina.TabIndex = 16;
            // 
            // txtDataVacina
            // 
            this.txtDataVacina.CustomFormat = "dd/MM/yyyy";
            this.txtDataVacina.Enabled = false;
            this.txtDataVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataVacina.Location = new System.Drawing.Point(150, 280);
            this.txtDataVacina.Name = "txtDataVacina";
            this.txtDataVacina.Size = new System.Drawing.Size(200, 21);
            this.txtDataVacina.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 436);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 15);
            this.label12.TabIndex = 14;
            this.label12.Text = "Enfermeiro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "Grupo prioritário";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 356);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Comorbidade";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 322);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 15);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tipo Vacina (1 - Coronavac; 2- Astrazeneca; 3- Pfizer";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 285);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Data Vacinação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "RG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Endereço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data de nascimento";
            // 
            // txtDataNascVacina
            // 
            this.txtDataNascVacina.CustomFormat = "dd/MM/yyyy";
            this.txtDataNascVacina.Enabled = false;
            this.txtDataNascVacina.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDataNascVacina.Location = new System.Drawing.Point(150, 108);
            this.txtDataNascVacina.Name = "txtDataNascVacina";
            this.txtDataNascVacina.Size = new System.Drawing.Size(200, 21);
            this.txtDataNascVacina.TabIndex = 4;
            // 
            // txtNomeVacina
            // 
            this.txtNomeVacina.Enabled = false;
            this.txtNomeVacina.Location = new System.Drawing.Point(150, 64);
            this.txtNomeVacina.MaxLength = 50;
            this.txtNomeVacina.Name = "txtNomeVacina";
            this.txtNomeVacina.Size = new System.Drawing.Size(346, 21);
            this.txtNomeVacina.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome do paciente";
            // 
            // txtIDVacina
            // 
            this.txtIDVacina.Enabled = false;
            this.txtIDVacina.Location = new System.Drawing.Point(150, 21);
            this.txtIDVacina.MaxLength = 50;
            this.txtIDVacina.Name = "txtIDVacina";
            this.txtIDVacina.Size = new System.Drawing.Size(69, 21);
            this.txtIDVacina.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // cbxEnfermeiro
            // 
            this.cbxEnfermeiro.AutoCompleteCustomSource.AddRange(new string[] {
            "S",
            "N"});
            this.cbxEnfermeiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEnfermeiro.FormattingEnabled = true;
            this.cbxEnfermeiro.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxEnfermeiro.Location = new System.Drawing.Point(150, 428);
            this.cbxEnfermeiro.Name = "cbxEnfermeiro";
            this.cbxEnfermeiro.Size = new System.Drawing.Size(346, 23);
            this.cbxEnfermeiro.TabIndex = 29;
            // 
            // cbxCidade
            // 
            this.cbxCidade.AutoCompleteCustomSource.AddRange(new string[] {
            "S",
            "N"});
            this.cbxCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCidade.FormattingEnabled = true;
            this.cbxCidade.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cbxCidade.Location = new System.Drawing.Point(150, 183);
            this.cbxCidade.Name = "cbxCidade";
            this.cbxCidade.Size = new System.Drawing.Size(346, 23);
            this.cbxCidade.TabIndex = 30;
            // 
            // frmVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(615, 550);
            this.Controls.Add(this.tbVacina);
            this.Controls.Add(this.bnVacina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmVacina";
            this.Text = "frmVacina";
            this.Load += new System.EventHandler(this.frmVacina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnVacina)).EndInit();
            this.bnVacina.ResumeLayout(false);
            this.bnVacina.PerformLayout();
            this.tbVacina.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgVacina)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnVacina;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TabControl tbVacina;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgVacina;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripButton btnNovoRegistro;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnAlterar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.TextBox txtEndVacina;
        private System.Windows.Forms.DateTimePicker txtDataVacina;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDataNascVacina;
        private System.Windows.Forms.TextBox txtNomeVacina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIDVacina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPrioriVacina;
        private System.Windows.Forms.ComboBox cbxComorbiVacina;
        private System.Windows.Forms.ComboBox cbxTipoVacina;
        private System.Windows.Forms.MaskedTextBox mskbxRgVacina;
        private System.Windows.Forms.MaskedTextBox mskbxCpfVacina;
        private System.Windows.Forms.ComboBox cbxCidade;
        private System.Windows.Forms.ComboBox cbxEnfermeiro;
    }
}