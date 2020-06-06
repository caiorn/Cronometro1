namespace Cronometro
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
            this.components = new System.ComponentModel.Container();
            this.panelTempo = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTempo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoMeuTempo = new System.Windows.Forms.RadioButton();
            this.rdoRegressiva = new System.Windows.Forms.RadioButton();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.btnZerar = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chkDesAtivo = new System.Windows.Forms.CheckBox();
            this.lblPathMusic = new System.Windows.Forms.Label();
            this.btnCarregarSom = new System.Windows.Forms.Button();
            this.lblTempoRestante = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.panelTempo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTempo
            // 
            this.panelTempo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTempo.Controls.Add(this.progressBar1);
            this.panelTempo.Controls.Add(this.lblTempo);
            this.panelTempo.Controls.Add(this.groupBox1);
            this.panelTempo.Controls.Add(this.txtSegundos);
            this.panelTempo.Controls.Add(this.txtMinutos);
            this.panelTempo.Controls.Add(this.txtHoras);
            this.panelTempo.Controls.Add(this.btnZerar);
            this.panelTempo.Controls.Add(this.btnIniciar);
            this.panelTempo.Controls.Add(this.label1);
            this.panelTempo.Controls.Add(this.label2);
            this.panelTempo.Controls.Add(this.label5);
            this.panelTempo.Controls.Add(this.label4);
            this.panelTempo.Controls.Add(this.label3);
            this.panelTempo.Location = new System.Drawing.Point(12, 12);
            this.panelTempo.Name = "panelTempo";
            this.panelTempo.Size = new System.Drawing.Size(609, 66);
            this.panelTempo.TabIndex = 23;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(395, 39);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(211, 23);
            this.progressBar1.TabIndex = 31;
            // 
            // lblTempo
            // 
            this.lblTempo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTempo.BackColor = System.Drawing.SystemColors.Control;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(389, 9);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(218, 31);
            this.lblTempo.TabIndex = 29;
            this.lblTempo.Text = "Tempo: 00:00:00";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoMeuTempo);
            this.groupBox1.Controls.Add(this.rdoRegressiva);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 59);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contagem";
            // 
            // rdoMeuTempo
            // 
            this.rdoMeuTempo.AutoSize = true;
            this.rdoMeuTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMeuTempo.Location = new System.Drawing.Point(5, 36);
            this.rdoMeuTempo.Name = "rdoMeuTempo";
            this.rdoMeuTempo.Size = new System.Drawing.Size(92, 19);
            this.rdoMeuTempo.TabIndex = 27;
            this.rdoMeuTempo.Text = "Meu Tempo";
            this.rdoMeuTempo.UseVisualStyleBackColor = true;
            this.rdoMeuTempo.CheckedChanged += new System.EventHandler(this.rdoCronometro_CheckedChanged);
            // 
            // rdoRegressiva
            // 
            this.rdoRegressiva.AutoSize = true;
            this.rdoRegressiva.Checked = true;
            this.rdoRegressiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoRegressiva.Location = new System.Drawing.Point(5, 18);
            this.rdoRegressiva.Name = "rdoRegressiva";
            this.rdoRegressiva.Size = new System.Drawing.Size(86, 19);
            this.rdoRegressiva.TabIndex = 26;
            this.rdoRegressiva.TabStop = true;
            this.rdoRegressiva.Text = "Regressivo";
            this.rdoRegressiva.UseVisualStyleBackColor = true;
            this.rdoRegressiva.CheckedChanged += new System.EventHandler(this.rdoCronometro_CheckedChanged);
            // 
            // txtSegundos
            // 
            this.txtSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundos.ForeColor = System.Drawing.Color.Maroon;
            this.txtSegundos.Location = new System.Drawing.Point(275, 4);
            this.txtSegundos.MaxLength = 2;
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(47, 47);
            this.txtSegundos.TabIndex = 23;
            this.txtSegundos.Tag = "seg";
            this.txtSegundos.Text = "00";
            this.txtSegundos.TextChanged += new System.EventHandler(this.txtHoraMinutoSegundo_TextChanged);
            this.txtSegundos.Leave += new System.EventHandler(this.txtHoraMinutoSegundos_Leave);
            // 
            // txtMinutos
            // 
            this.txtMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutos.ForeColor = System.Drawing.Color.Maroon;
            this.txtMinutos.Location = new System.Drawing.Point(209, 5);
            this.txtMinutos.MaxLength = 2;
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(46, 47);
            this.txtMinutos.TabIndex = 1;
            this.txtMinutos.Tag = "min";
            this.txtMinutos.Text = "00";
            this.txtMinutos.TextChanged += new System.EventHandler(this.txtHoraMinutoSegundo_TextChanged);
            this.txtMinutos.Leave += new System.EventHandler(this.txtHoraMinutoSegundos_Leave);
            // 
            // txtHoras
            // 
            this.txtHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoras.ForeColor = System.Drawing.Color.Maroon;
            this.txtHoras.Location = new System.Drawing.Point(145, 5);
            this.txtHoras.MaxLength = 2;
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(46, 47);
            this.txtHoras.TabIndex = 1;
            this.txtHoras.Tag = "hora";
            this.txtHoras.Text = "00";
            this.txtHoras.TextChanged += new System.EventHandler(this.txtHoraMinutoSegundo_TextChanged);
            this.txtHoras.Leave += new System.EventHandler(this.txtHoraMinutoSegundos_Leave);
            // 
            // btnZerar
            // 
            this.btnZerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZerar.Location = new System.Drawing.Point(330, 36);
            this.btnZerar.Name = "btnZerar";
            this.btnZerar.Size = new System.Drawing.Size(57, 29);
            this.btnZerar.TabIndex = 23;
            this.btnZerar.Text = "Zerar";
            this.btnZerar.UseVisualStyleBackColor = true;
            this.btnZerar.Click += new System.EventHandler(this.btnZerar_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Enabled = false;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(330, 3);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(57, 30);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 39);
            this.label1.TabIndex = 21;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 39);
            this.label2.TabIndex = 23;
            this.label2.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Segundo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Minuto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Hora";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.chkDesAtivo);
            this.panel1.Controls.Add(this.lblPathMusic);
            this.panel1.Controls.Add(this.btnCarregarSom);
            this.panel1.Controls.Add(this.lblTempoRestante);
            this.panel1.Controls.Add(this.lblHora);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 64);
            this.panel1.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(72, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // chkDesAtivo
            // 
            this.chkDesAtivo.AutoSize = true;
            this.chkDesAtivo.Location = new System.Drawing.Point(200, 14);
            this.chkDesAtivo.Name = "chkDesAtivo";
            this.chkDesAtivo.Size = new System.Drawing.Size(50, 17);
            this.chkDesAtivo.TabIndex = 7;
            this.chkDesAtivo.Text = "Ativo";
            this.chkDesAtivo.UseVisualStyleBackColor = true;
            // 
            // lblPathMusic
            // 
            this.lblPathMusic.AutoSize = true;
            this.lblPathMusic.Location = new System.Drawing.Point(60, 38);
            this.lblPathMusic.Name = "lblPathMusic";
            this.lblPathMusic.Size = new System.Drawing.Size(16, 13);
            this.lblPathMusic.TabIndex = 5;
            this.lblPathMusic.Text = "...";
            // 
            // btnCarregarSom
            // 
            this.btnCarregarSom.Location = new System.Drawing.Point(7, 33);
            this.btnCarregarSom.Name = "btnCarregarSom";
            this.btnCarregarSom.Size = new System.Drawing.Size(47, 23);
            this.btnCarregarSom.TabIndex = 4;
            this.btnCarregarSom.Text = "Som";
            this.btnCarregarSom.UseVisualStyleBackColor = true;
            this.btnCarregarSom.Click += new System.EventHandler(this.btnCarregarSom_Click);
            // 
            // lblTempoRestante
            // 
            this.lblTempoRestante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTempoRestante.Location = new System.Drawing.Point(398, 13);
            this.lblTempoRestante.Name = "lblTempoRestante";
            this.lblTempoRestante.Size = new System.Drawing.Size(208, 20);
            this.lblTempoRestante.TabIndex = 3;
            this.lblTempoRestante.Text = "Tempo Restante:";
            this.lblTempoRestante.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.Location = new System.Drawing.Point(397, 36);
            this.lblHora.Name = "lblHora";
            this.lblHora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHora.Size = new System.Drawing.Size(209, 20);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora: ";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Despertador:";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(11, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(608, 10);
            this.label7.TabIndex = 25;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 182);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTempo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTempo.ResumeLayout(false);
            this.panelTempo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTempo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoMeuTempo;
        private System.Windows.Forms.RadioButton rdoRegressiva;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Button btnZerar;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTempoRestante;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblPathMusic;
        private System.Windows.Forms.Button btnCarregarSom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox chkDesAtivo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
    }
}

