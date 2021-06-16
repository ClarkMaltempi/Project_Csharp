using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PVacina0030482023028
{
    public partial class frmVacina : Form
    {
        private BindingSource bsVacina = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsVacina = new DataSet();
        private DataSet dsCidade = new DataSet();
        private DataSet dsEnfermeiro = new DataSet();


        public frmVacina()
        {
            InitializeComponent();
        }

        private void frmVacina_Load(object sender, EventArgs e)
        {
            
            try
            {
                Vacina Vac = new Vacina(); // Criar objeto
                dsVacina.Tables.Add(Vac.Listar());
                bsVacina.DataSource = dsVacina.Tables["Vacina"];
                bnVacina.BindingSource = bsVacina;
                dgVacina.DataSource = bsVacina;


                txtIDVacina.DataBindings.Add("Text", bsVacina, "id_vacina");
                txtNomeVacina.DataBindings.Add("Text", bsVacina, "nome_vacina");
                txtDataNascVacina.DataBindings.Add("Text", bsVacina, "datanasc_vacina");
                txtEndVacina.DataBindings.Add("Text", bsVacina, "end_vacina");
                cbxCidade.DataBindings.Add("Text", bsVacina, "cidade_id_cidade");
                //txtCidadeIDCidade.DataBindings.Add("Text", bsVacina, "cidade_id_cidade");
                mskbxCpfVacina.DataBindings.Add("Text", bsVacina, "cpf_vacina");
                mskbxRgVacina.DataBindings.Add("Text", bsVacina, "rg_vacina");
                txtDataVacina.DataBindings.Add("Text", bsVacina, "data_vacina");
                cbxTipoVacina.DataBindings.Add("SelectedItem", bsVacina, "tipo_vacina");
                cbxComorbiVacina.DataBindings.Add("SelectedItem", bsVacina, "comorbidade_vacina");
                cbxPrioriVacina.DataBindings.Add("SelectedItem", bsVacina, "grupopriori_vacina");
                //txtEnfermeiroVacina.DataBindings.Add("Text", bsVacina, "enfermeiro_id_enfermeiro");
                cbxEnfermeiro.DataBindings.Add("Text", bsVacina, "enfermeiro_id_enfermeiro");

                Cidade RegCid = new Cidade(); //criar objeto
                dsCidade.Tables.Add(RegCid.Listar());
                cbxCidade.DataSource = dsCidade.Tables["Cidade"];
                cbxCidade.DisplayMember = "nome_cidade";
                cbxCidade.ValueMember = "id_cidade";
                cbxCidade.DataBindings.Add("SelectedValue", bsVacina, "cidade_id_cidade");

                /*bnCidade.DataSource = dsCidade.Tables["TBCidade"];
                dgvCidade.DataSource = bnCidade;
                bnvCidade.BindingSource = bnCidade;
                txtId.DataBindings.Add("TEXT", bnCidade, "id_cidade");
                txtNomeCidade.DataBindings.Add("TEXT", bnCidade, "nome_cidade");
                cbxEstado.DataBindings.Add("SelectedItem", bnCidade, "uf_cidade");
                // AJUSTAR DROPDOWNSTYLE PARA DropDownList PARA NAO DEIXAR INCLUIR
            }*/
                Enfermeiro RegEnfermeiro = new Enfermeiro(); //criar objeto
                dsEnfermeiro.Tables.Add(RegEnfermeiro.Listar());
                cbxEnfermeiro.DataSource = dsEnfermeiro.Tables["Enfermeiro"];
                cbxEnfermeiro.DisplayMember = "nome_enfermeiro";
                cbxEnfermeiro.ValueMember = "id_enfermeiro";
                cbxEnfermeiro.DataBindings.Add("SelectedValue", bsVacina, "enfermeiro_id_enfermeiro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            {
                if (tbVacina.SelectedIndex == 0)
                {
                    tbVacina.SelectTab(1);
                }
                bsVacina.AddNew();



                txtNomeVacina.Enabled = true;
                txtDataNascVacina.Enabled = true;
                txtEndVacina.Enabled = true;
                cbxCidade.Enabled = true;
                //txtCidadeIDCidade.Enabled = true;
                mskbxCpfVacina.Enabled = true;
                mskbxRgVacina.Enabled = true;
                txtDataVacina.Enabled = true;
                cbxTipoVacina.Enabled = true;
                cbxComorbiVacina.Enabled = true;
                cbxPrioriVacina.Enabled = true;
                //txtEnfermeiroVacina.Enabled = true;
                cbxEnfermeiro.Enabled = true;
                cbxTipoVacina.SelectedIndex = 0;
                cbxComorbiVacina.SelectedIndex = 0;
                cbxPrioriVacina.SelectedIndex = 0;



                btnNovoRegistro.Enabled = false;
                btnSalvar.Enabled = true;
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
                btnCancelar.Enabled = true;
                bInclusao = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime data;


            // validar os dados
            if (txtNomeVacina.Text == "")
                MessageBox.Show("Nome inválido!");
            else
            if (!DateTime.TryParse(txtDataNascVacina.Value.ToString(), out data))
                MessageBox.Show("Data inválida!");
            else
            if (mskbxCpfVacina.Text == "")
                MessageBox.Show("CPF inválido!");
            else
            if (mskbxRgVacina.Text == "")
                MessageBox.Show("RG inválido!");
            else
            if (!DateTime.TryParse(txtDataVacina.Value.ToString(), out data))
                MessageBox.Show("Data inválida!");
            else
            {
                Vacina RegVac = new Vacina();



                RegVac.NomeVacina = txtNomeVacina.Text;
                RegVac.EndVacina = txtEndVacina.Text;
                RegVac.DataNascVacina = txtDataNascVacina.Value;
                RegVac.CidadeIdVacina = Convert.ToInt32(cbxCidade.SelectedValue.ToString());
                RegVac.CpfVacina = mskbxCpfVacina.Text;
                RegVac.RgVacina = mskbxRgVacina.Text;
                RegVac.DataVacina = txtDataVacina.Value;
                RegVac.TipoVacina = Convert.ToChar(cbxTipoVacina.SelectedItem.ToString());
                RegVac.GrupoPrioriVacina = Convert.ToChar(cbxPrioriVacina.SelectedItem.ToString());
                RegVac.ComorbidadeVacina = Convert.ToChar(cbxComorbiVacina.SelectedItem.ToString());
                RegVac.EnfermeiroIdEnfermeiroVacina = Convert.ToInt32(cbxEnfermeiro.SelectedValue.ToString());



                if (bInclusao)
                {
                    if (RegVac.Salvar() > 0)
                    {
                        MessageBox.Show("Vacina adicionada com sucesso!");



                        txtNomeVacina.Enabled = false;
                        txtDataNascVacina.Enabled = false;
                        txtEndVacina.Enabled = false;
                        //cbxCidadeIDCidade.Enabled = false;
                        cbxCidade.Enabled = false;
                        mskbxCpfVacina.Enabled = false;
                        mskbxRgVacina.Enabled = false;
                        txtDataVacina.Enabled = false;
                        cbxTipoVacina.Enabled = false;
                        cbxComorbiVacina.Enabled = false;
                        cbxPrioriVacina.Enabled = false;
                        //txtEnfermeiroVacina.Enabled = false;
                        cbxEnfermeiro.Enabled = false;



                        btnNovoRegistro.Enabled = true;
                        btnSalvar.Enabled = false;
                        btnAlterar.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;



                        // recarrega o grid
                        dsVacina.Tables.Clear();
                        dsVacina.Tables.Add(RegVac.Listar());
                        bsVacina.DataSource = dsVacina.Tables["Vacina"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade!");
                    }
                }
                else
                {
                    // validar os dados
                    if (txtNomeVacina.Text == "")
                        MessageBox.Show("Nome inválido!");
                    else
                    if (!DateTime.TryParse(txtDataNascVacina.Value.ToString(), out data))
                        MessageBox.Show("Data inválida!");
                    else
                    if (mskbxCpfVacina.Text == "")
                        MessageBox.Show("CPF inválido!");
                    else
                    if (mskbxRgVacina.Text == "")
                        MessageBox.Show("RG inválido!");
                    else
                    if (!DateTime.TryParse(txtDataVacina.Value.ToString(), out data))
                        MessageBox.Show("Data inválida!");
                    else
                    {
                        Vacina RegVac1 = new Vacina();



                        RegVac1.NomeVacina = txtNomeVacina.Text;
                        RegVac1.EndVacina = txtEndVacina.Text;
                        RegVac1.DataNascVacina = txtDataNascVacina.Value;
                        RegVac1.CidadeIdVacina = Convert.ToInt32(cbxCidade.SelectedValue.ToString());
                        RegVac1.CpfVacina = mskbxCpfVacina.Text;
                        RegVac1.RgVacina = mskbxRgVacina.Text;
                        RegVac1.DataVacina = txtDataVacina.Value;
                        RegVac1.TipoVacina = Convert.ToChar(cbxTipoVacina.SelectedItem.ToString());
                        RegVac1.GrupoPrioriVacina = Convert.ToChar(cbxComorbiVacina.SelectedItem.ToString());
                        RegVac1.ComorbidadeVacina = Convert.ToChar(cbxComorbiVacina.SelectedItem.ToString());
                        RegVac1.EnfermeiroIdEnfermeiroVacina = Convert.ToInt32(cbxEnfermeiro.Enabled = false);



                        if (bInclusao)
                        {
                            if (RegVac.Salvar() > 0)
                            {
                                MessageBox.Show("Vacina adicionada com sucesso!");



                                txtNomeVacina.Enabled = false;
                                txtDataNascVacina.Enabled = false;
                                txtEndVacina.Enabled = false;
                                cbxCidade.Enabled = false;
                                mskbxCpfVacina.Enabled = false;
                                mskbxRgVacina.Enabled = false;
                                txtDataVacina.Enabled = false;
                                cbxTipoVacina.Enabled = false;
                                cbxComorbiVacina.Enabled = false;
                                cbxPrioriVacina.Enabled = false;
                                cbxEnfermeiro.Enabled = false;



                                btnNovoRegistro.Enabled = true;
                                btnSalvar.Enabled = false;
                                btnAlterar.Enabled = true;
                                btnExcluir.Enabled = true;
                                btnCancelar.Enabled = false;

                                bInclusao = false;



                                // recarrega o grid
                                dsVacina.Tables.Clear();
                                dsVacina.Tables.Add(RegVac.Listar());
                                bsVacina.DataSource = dsVacina.Tables["Vacina"];
                            }
                            else
                            {
                                MessageBox.Show("Erro ao gravar vacina!");
                            }
                        }
                        else
                        {
                            RegVac.IdVacina = Convert.ToInt32(txtIDVacina.Text);



                            if (RegVac.Alterar() > 0)
                            {
                                MessageBox.Show("Vacina alterada com sucesso!");



                                txtNomeVacina.Enabled = false;
                                txtDataNascVacina.Enabled = false;
                                txtEndVacina.Enabled = false;
                                cbxCidade.Enabled = false;
                                mskbxCpfVacina.Enabled = false;
                                mskbxRgVacina.Enabled = false;
                                txtDataVacina.Enabled = false;
                                cbxTipoVacina.Enabled = false;
                                cbxComorbiVacina.Enabled = false;
                                cbxPrioriVacina.Enabled = false;
                                cbxEnfermeiro.Enabled = false;




                                btnNovoRegistro.Enabled = true;
                                btnSalvar.Enabled = false;
                                btnAlterar.Enabled = true;
                                btnExcluir.Enabled = true;
                                btnCancelar.Enabled = false;




                                // recarrega o grid
                                dsVacina.Tables.Clear();
                                dsVacina.Tables.Add(RegVac.Listar());
                                bsVacina.DataSource = dsVacina.Tables["Vacina"];



                            }
                            else
                            {
                                MessageBox.Show("Erro ao alterar vacina!");
                            }



                        }
                    }
                    /*
                    if (RegCid.Alterar() > 0)
                    {
                    MessageBox.Show("Cidade alterada com sucesso!");



                    dsCidade.Tables.Clear();
                    dsCidade.Tables.Add(RegCid.Listar());
                    txtId.Enabled = false;
                    txtNomeCidade.Enabled = false;
                    cbxEstado.Enabled = false;
                    btnSalvar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnNovoRegistro.Enabled = true;
                    btnExcluir.Enabled = true;
                    btnCancelar.Enabled = false;
                    }
                    else
                    {
                    MessageBox.Show("Erro ao gravar cidade!");
                    } */



                }
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }

            txtNomeVacina.Enabled = true;
            txtDataNascVacina.Enabled = true;
            txtEndVacina.Enabled = true;
            cbxCidade.Enabled = true;
            mskbxCpfVacina.Enabled = true;
            mskbxRgVacina.Enabled = true;
            txtDataVacina.Enabled = true;
            cbxTipoVacina.Enabled = true;
            cbxComorbiVacina.Enabled = true;
            cbxPrioriVacina.Enabled = true;
            cbxEnfermeiro.Enabled = true;

            btnNovoRegistro.Enabled = false;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }



            if (MessageBox.Show("Confirma exclusão?", "Sim or Não", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Vacina RegVac = new Vacina();
                RegVac.IdVacina = Convert.ToInt32(txtIDVacina.Text);

                if (RegVac.Excluir() > 0)
                {
                    MessageBox.Show("Vacina excluída com sucesso!");



                    // recarrega o grid
                    dsVacina.Tables.Clear();
                    dsVacina.Tables.Add(RegVac.Listar());
                    bsVacina.DataSource = dsVacina.Tables["Vacina"];
                }
                else
                    MessageBox.Show("Erro ao excluir vacina!");

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bsVacina.CancelEdit();



            txtNomeVacina.Enabled = false;
            txtDataNascVacina.Enabled = false;
            txtEndVacina.Enabled = false;
            cbxCidade.Enabled = false;
            mskbxCpfVacina.Enabled = false;
            mskbxRgVacina.Enabled = false;
            txtDataVacina.Enabled = false;
            cbxTipoVacina.Enabled = false;
            cbxComorbiVacina.Enabled = false;
            cbxPrioriVacina.Enabled = false;
            cbxEnfermeiro.Enabled = false;



            btnNovoRegistro.Enabled = true;
            btnSalvar.Enabled = false;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCancelar.Enabled = false;



            bInclusao = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}