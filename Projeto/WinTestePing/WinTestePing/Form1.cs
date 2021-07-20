using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.IO;
using System.Globalization;
using System.Threading;



namespace WinTestePing
{
    public partial class Form1 : Form
    {
        
        DateTime data = DateTime.Now;
        public Form1()
        {
            InitializeComponent();
            

        }

        
        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void lblCostaLeiteSaida_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ckBox2Ferrovia.Checked == true || ckBoxBalRodo.Checked == true )
            {
                ckBoxBalRodo.Enabled = true;
                lbl1.Enabled = true;
                ckBox2Ferrovia.Enabled = true;
                lbl2.Enabled = true;
                ckBox2Ferrovia.Checked = false;
                ckBoxBalRodo.Checked = false;
            }
            

        }

        private void ckBoxBalRodo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBoxBalRodo.Checked == true)
            {
                ckBox2Ferrovia.Enabled = false;
                lbl2.Enabled = false;

                
                    Ping ping = new Ping();
                    PingReply reply_BalOuteirosLdMar = ping.Send("10.201.70.171", 1000);

                   if (reply_BalOuteirosLdMar.Status.ToString() == "Sucess")
                   {
                        lblOuteirosLadoMar.Text = "ON";
                        lblOuteirosLadoTerra.Text = "ON";

                }
                    else if(reply_BalOuteirosLdMar.Status.ToString() == "TimedOut")
                   {
                        lblOuteirosLadoMar.Text = "OFF";
                        lblOuteirosLadoMar.BackColor = Color.Red;
                        lblOuteirosLadoTerra.Text = "OFF";
                        lblOuteirosLadoTerra.BackColor = Color.Red;

                }


                
            }

            
            




        }

        private void ckBox2Ferrovia_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBox2Ferrovia.Checked == true)
            {
                ckBoxBalRodo.Enabled = false;
                lbl1.Enabled = false;

                Ping ping = new Ping();
                PingReply reply_lblCostaLeiteSaida = ping.Send("10.201.70.158", 1000);
                //MessageBox.Show(reply_lblCostaLeiteSaida.Status.ToString());

                if (reply_lblCostaLeiteSaida.Status.ToString() == "Sucess")
                {
                    lblCostaLeiteSaida.Text = "ON";

                }
                if (reply_lblCostaLeiteSaida.Status.ToString() == "TimedOut")
                {
                    lblCostaLeiteSaida.Text = "OFF";
                    lblCostaLeiteSaida.BackColor = Color.Red;
                    StreamWriter valor = File.CreateText(@"C:\data\BalOffLine_log.txt");
                    valor.WriteLine(data + " Balança Costa Leite Saida." + "\n");
                    valor.Close();
                    
                }


                Ping ping2 = new Ping();
                PingReply reply_lblCostaLeiteEntrada = ping2.Send("10.201.70.157", 1000);

                //MessageBox.Show(reply_lblCostaLeiteEntrada.Status.ToString());
                if (reply_lblCostaLeiteEntrada.Status.ToString() == "Sucess")
                {
                    lblCostaLeiteEntrada.Text = "ON";

                }
                if (reply_lblCostaLeiteEntrada.Status.ToString() == "TimedOut")
                {
                    lblCostaLeiteEntrada.Text = "OFF";
                    lblCostaLeiteEntrada.BackColor = Color.Red;
                    StreamWriter valor = File.CreateText(@"C:\data\BalOffLine_log.txt");
                    valor.WriteLine(data + " Balança Costa Leite Saida." + "\n");
                    valor.Close();

                }

                Ping ping3 = new Ping();
                PingReply reply_lblXXIII = ping3.Send("10.201.70.159", 1000);

                //MessageBox.Show(reply_lblXXIII.Status.ToString());
                if (reply_lblXXIII.Status.ToString() == "Sucess")
                {
                    lblXXIII.Text = "ON";

                }
                if (reply_lblXXIII.Status.ToString() == "TimedOut")
                {
                    lblXXIII.Text = "OFF";
                    lblXXIII.BackColor = Color.Red;
                    StreamWriter valor = File.CreateText(@"C:\data\BalOffLine_log.txt");
                    valor.WriteLine(data + " Balança Costa Leite Saida." + "\n");
                    valor.Close();
                }

                Ping ping4 = new Ping();
                PingReply reply_lblMoegaEnt = ping4.Send("10.201.70.176", 1000);

                //MessageBox.Show(reply_lblMoegaEnt.Status.ToString());
                if (reply_lblMoegaEnt.Status.ToString() == "Sucess")
                {
                    lblMoegaEnt.Text = "ON";

                }
                if (reply_lblMoegaEnt.Status.ToString() == "TimedOut")
                {
                    lblMoegaEnt.Text = "OFF";
                    lblMoegaEnt.BackColor = Color.Red;
                    StreamWriter valor = File.CreateText(@"C:\data\BalOffLine_log.txt");
                    valor.WriteLine(data + " Balança Costa Leite Saida." + "\n");
                    valor.Close();
                }

                Ping ping5 = new Ping();
                PingReply reply_lblMoegaSaida = ping5.Send("10.201.70.177", 1000);

                //MessageBox.Show(reply_lblMoegaSaida.Status.ToString());
                if (reply_lblMoegaSaida.Status.ToString() == "Sucess")
                {
                    lblMoegaSaida.Text = "ON";

                }
                if (reply_lblMoegaEnt.Status.ToString() == "TimedOut")
                {
                    lblMoegaSaida.Text = "OFF";
                    lblMoegaSaida.BackColor = Color.Red;
                    StreamWriter valor = File.CreateText(@"C:\data\BalOffLine_log.txt");
                    valor.WriteLine(data + " Balança Costa Leite Saida." + "\n");
                    valor.Close();
                }

                Ping ping6 = new Ping();
                PingReply reply_lblM1Ent = ping6.Send("10.201.70.132", 1000);

                //MessageBox.Show(reply_lblM1Ent.Status.ToString());
                if (reply_lblM1Ent.Status.ToString() == "Sucess")
                {
                    lblM1Ent.Text = "ON";

                }
                if (reply_lblMoegaEnt.Status.ToString() == "TimedOut")
                {
                    lblM1Ent.Text = "OFF";
                    lblM1Ent.BackColor = Color.Red;
                    StreamWriter valor = File.CreateText(@"C:\data\BalOffLine_log.txt");
                    valor.WriteLine(data + " Balança Costa Leite Saida." + "\n");
                    valor.Close();
                }

            }


            
            }

       // private void button2_Click(object sender, EventArgs e)
        //{
            //string text = System.IO.File.ReadAllText(@"C:\data\BalOffLine_log.txt");
            //MessageBox.Show(text.ToString());
        //}
    }
}

