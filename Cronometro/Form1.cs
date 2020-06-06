using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cronometro
{
    public partial class Form1 : Form
    {

        byte Horas;
        byte Minutos;
        byte Segundos;

        public Form1()
        {
            InitializeComponent();
            byte hora = (byte)DateTime.Now.Hour;
            this.Text = hora > 5 && hora < 12 ? "Bom dia" : hora > 11 && hora < 18 ? "Boa tarde" : "Boa noite";
        }
        
        private void rdoCronometro_CheckedChanged(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                btnIniciar.Text = "Iniciar";
            }

            //se Regressiva estiver selecionado todos textbox recebe é habilitado caso contrario, desabilitados
            foreach (Control p in this.panelTempo.Controls)
                if (p is TextBox)
                    p.Enabled = !rdoMeuTempo.Checked;

            progressBar1.Visible = !rdoMeuTempo.Checked;
            lblTempo.Visible = !rdoMeuTempo.Checked;

            if (rdoMeuTempo.Checked)
            {
                progressBar1.Value = 0;
                btnIniciar.Enabled = true;

                Horas = 0;
                Minutos = 0;
                Segundos = 0;

                txtHoras.Text = "00";
                txtMinutos.Text = "00";
                txtSegundos.Text = "00";
            }
            else if (rdoRegressiva.Checked)
            {
                //se conter valores nos text habilita o botao iniciar
                btnIniciar.Enabled = (Segundos > 0 || Minutos > 0 || Horas > 0);
                lblTempo.Text = "Tempo: 00:00:00";
            }
        }

        private void txtHoraMinutoSegundos_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "" || (sender as TextBox).Text == "0")
            {
                (sender as TextBox).Text = "00";
            }
        }

        private void txtHoraMinutoSegundo_TextChanged(object sender, EventArgs e)
        {
            if (rdoMeuTempo.Checked)
                return;
            //textBox valido para todos
            TextBox esseTxt = (sender as TextBox);
            int valor;

            //se nao conseguir converter para numero
            if (!int.TryParse(esseTxt.Text, out valor))
            {
                esseTxt.Text = "";
                //se tiver algum numero direfente de 0 e nao vazio ele habilita
                btnIniciar.Enabled = ((txtMinutos.Text != "" && Convert.ToByte(txtMinutos.Text) != 0) || (txtHoras.Text != "" && Convert.ToByte(txtHoras.Text) != 0) || (txtSegundos.Text != "" && Convert.ToByte(txtSegundos.Text) != 0));
                return;
            }
            //verifico qual é o textbox atual que esta sendo modificado
            switch ((string)esseTxt.Tag)
            {
                case "hora":
                    if (byte.Parse(esseTxt.Text) > 24)
                        esseTxt.Text = "24";
                    break;
                //caso nao for hora é (min ou seg)
                default:
                    if (byte.Parse(esseTxt.Text) > 60)
                        esseTxt.Text = "60";
                    break;
            }
            //se tiver algum numero direfente de 0 e nao vazio ele habilita
            btnIniciar.Enabled = ((txtMinutos.Text != "" && Convert.ToByte(txtMinutos.Text) != 0) || (txtHoras.Text != "" && Convert.ToByte(txtHoras.Text) != 0) || (txtSegundos.Text != "" && Convert.ToByte(txtSegundos.Text) != 0));
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Parar")
            {
                timer1.Stop();
                btnIniciar.Text = "Iniciar";
                return;
            }
            else if (btnIniciar.Text == "Iniciar")
            {
                if (rdoRegressiva.Checked)
                {
                    //Inicializacao da contagem
                    Horas = byte.Parse(txtHoras.Text);
                    Minutos = byte.Parse(txtMinutos.Text);
                    Segundos = byte.Parse(txtSegundos.Text);

                    progressBar1.Value = 0;
                    progressBar1.Step = 1;
                    //convertendo as horas e minutos em segundos
                    progressBar1.Maximum = (Horas * 60 * 60) + (Minutos * 60) + Segundos;
                    progressBar1.Minimum = 0;

                    txtHoras.Enabled = false;
                    txtMinutos.Enabled = false;
                    txtSegundos.Enabled = false;

                    btnIniciar.Text = "Parar";

                    lblTempo.Text = "Tempo: " + Horas.ToString("00") + ":" + Minutos.ToString("00") + ":" + Segundos.ToString("00");
                    lblTempo.Enabled = true;
                }
                else if (rdoMeuTempo.Checked)
                {
                    Segundos = 0;
                    Minutos = 0;
                    Horas = 0;
                }
                //data = Convert.ToDateTime(txtHoras.Text +":"+ txtMinutos.Text +":"+ txtSegundos.Text);
                //Horas = (byte)data.Hour;
            }
            timer1.Start();
        }

        private void btnZerar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btnIniciar.Text = "Iniciar";
            lblTempo.Text = "Tempo: 00:00:00";
            Segundos = 0;
            Minutos = 0;
            Horas = 0;
            progressBar1.Value = 0;

            //seto todos textos
            foreach (Control txt in panelTempo.Controls)
            {
                if (txt is TextBox)
                {
                    (txt as TextBox).Text = "00";
                    //habilito os campos para nova contagem
                    if (rdoRegressiva.Checked)
                        (txt as TextBox).Enabled = true;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rdoRegressiva.Checked)
            {
                ContagemRegressiva();
            }
            else
            {
                MeuTempo();
            }
        }

        private void ContagemRegressiva()
        {
            //se acabar os segundos mas ainda tiver minutos
            if (Segundos == 0 && Minutos > 0)
            {
                Minutos--;
                Segundos = 60;
            }
            //se acabar os segundos e os minutos mas ainda haver Horas
            else if (Segundos == 0 && Minutos == 0 && Horas > 0)
            {
                Horas--;
                Minutos = 59;
                Segundos = 60;
            }

            Segundos--;

            txtHoras.Text = Horas.ToString("00");
            txtMinutos.Text = Minutos.ToString("00");
            txtSegundos.Text = Segundos.ToString("00");
            progressBar1.Increment(progressBar1.Step);

            //se o tempo acabar
            if (Horas == 0 && Segundos == 0 && Minutos == 0)
            {
                timer1.Stop();
                MessageBox.Show("O Tempo Acabou !", "Tempo Esgotado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btnIniciar.Text = "Iniciar";
            }            
        }

        private void MeuTempo()
        {
            Segundos += 1;
            if (Segundos == 60)
            {
                Segundos = 0;
                Minutos += 1;
            }
            if (Minutos == 60)
            {
                Minutos = 0;
                Horas += 1;
            }

            txtSegundos.Text = Segundos.ToString("00");
            txtMinutos.Text = Minutos.ToString("00");
            txtHoras.Text = Horas.ToString("00");
        }
        
        //----------------------DESPERTADOR-----------------
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
            if (chkDesAtivo.Checked)
            {
                DateTime atual = DateTime.Now;
                DateTime despertar = dateTimePicker1.Value;

                //lblTempoRestante.Text = atual > despertar ? "Passou: " : "Diferença: ";
                //lblTempoRestante.Text += atual.Subtract(despertar).ToString("hh':'mm':'ss");

                lblTempoRestante.Text = atual > despertar ? "Passou: " : "Tempo Restante: ";
                TimeSpan dif = atual.Subtract(despertar);
                lblTempoRestante.Text += string.Format("{0}:{1:mm}:{1:ss}", (Math.Abs((int)dif.TotalHours)).ToString("d2"), dif);

                if (atual.Hour == despertar.Hour) {
                    if (atual.Minute == despertar.Minute) {
                        if(atual.Second == despertar.Second){
                            alert_alarm();
                            chkDesAtivo.Checked = false;
                        }
                    }
                }                    
            }
        }

        private void btnCarregarSom_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "WAVE File (*.WAV)| *.wav";
            openFileDialog1.ShowDialog();
            lblPathMusic.Text = openFileDialog1.FileName; 
        }

        private void alert_alarm()
        {
            System.Media.SoundPlayer SND_Play = null;
            if (File.Exists(lblPathMusic.Text))
            {
                SND_Play = new System.Media.SoundPlayer(lblPathMusic.Text);
                SND_Play.PlayLooping();                
            }

            MessageBox.Show("Alarm Clock !!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(SND_Play != null)
                SND_Play.Stop();            

        }        
    }
}
