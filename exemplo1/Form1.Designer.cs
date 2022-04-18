namespace exemplo1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calendarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeFerramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.imgsair = new System.Windows.Forms.PictureBox();
            this.imgsobre = new System.Windows.Forms.PictureBox();
            this.imglimpar = new System.Windows.Forms.PictureBox();
            this.imgcalcular = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgfoto = new System.Windows.Forms.PictureBox();
            this.cbocargo = new System.Windows.Forms.ComboBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.txtbs = new System.Windows.Forms.TextBox();
            this.txtinss = new System.Windows.Forms.TextBox();
            this.txtsb = new System.Windows.Forms.TextBox();
            this.txtvh = new System.Windows.Forms.TextBox();
            this.txtht = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.calcularToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgsair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgsobre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imglimpar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcalcular)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgfoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.exibirToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularToolStripMenuItem,
            this.limparToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // calcularToolStripMenuItem
            // 
            this.calcularToolStripMenuItem.Name = "calcularToolStripMenuItem";
            this.calcularToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.calcularToolStripMenuItem.Text = "&Calcular";
            this.calcularToolStripMenuItem.Click += new System.EventHandler(this.calcularToolStripMenuItem_Click);
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.limparToolStripMenuItem.Text = "&Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.limparToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.sairToolStripMenuItem.Text = "Sai&r";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraToolStripMenuItem,
            this.calendarioToolStripMenuItem,
            this.barraDeFerramentasToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.exibirToolStripMenuItem.Text = "&Exibir";
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.calculadoraToolStripMenuItem.Text = "Calc&uladora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // calendarioToolStripMenuItem
            // 
            this.calendarioToolStripMenuItem.Name = "calendarioToolStripMenuItem";
            this.calendarioToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.calendarioToolStripMenuItem.Text = "Cale&ndario";
            this.calendarioToolStripMenuItem.Click += new System.EventHandler(this.calendarioToolStripMenuItem_Click);
            // 
            // barraDeFerramentasToolStripMenuItem
            // 
            this.barraDeFerramentasToolStripMenuItem.Name = "barraDeFerramentasToolStripMenuItem";
            this.barraDeFerramentasToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.barraDeFerramentasToolStripMenuItem.Text = "Barra de Ferramentas";
            this.barraDeFerramentasToolStripMenuItem.Click += new System.EventHandler(this.barraDeFerramentasToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sobreToolStripMenuItem.Text = "&Sobre ...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.imgsair);
            this.panel1.Controls.Add(this.imgsobre);
            this.panel1.Controls.Add(this.imglimpar);
            this.panel1.Controls.Add(this.imgcalcular);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 73);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(439, 21);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(575, 34);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Visible = false;
            // 
            // imgsair
            // 
            this.imgsair.Image = global::exemplo1.Properties.Resources.fechar;
            this.imgsair.Location = new System.Drawing.Point(280, 12);
            this.imgsair.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgsair.Name = "imgsair";
            this.imgsair.Size = new System.Drawing.Size(55, 47);
            this.imgsair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgsair.TabIndex = 3;
            this.imgsair.TabStop = false;
            this.imgsair.Click += new System.EventHandler(this.imgsair_Click);
            // 
            // imgsobre
            // 
            this.imgsobre.Image = global::exemplo1.Properties.Resources.informação;
            this.imgsobre.Location = new System.Drawing.Point(191, 12);
            this.imgsobre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgsobre.Name = "imgsobre";
            this.imgsobre.Size = new System.Drawing.Size(55, 47);
            this.imgsobre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgsobre.TabIndex = 2;
            this.imgsobre.TabStop = false;
            // 
            // imglimpar
            // 
            this.imglimpar.Image = global::exemplo1.Properties.Resources.limpar;
            this.imglimpar.Location = new System.Drawing.Point(103, 12);
            this.imglimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imglimpar.Name = "imglimpar";
            this.imglimpar.Size = new System.Drawing.Size(55, 47);
            this.imglimpar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imglimpar.TabIndex = 1;
            this.imglimpar.TabStop = false;
            this.imglimpar.Click += new System.EventHandler(this.imglimpar_Click);
            // 
            // imgcalcular
            // 
            this.imgcalcular.Image = global::exemplo1.Properties.Resources.calculadora;
            this.imgcalcular.Location = new System.Drawing.Point(27, 12);
            this.imgcalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgcalcular.Name = "imgcalcular";
            this.imgcalcular.Size = new System.Drawing.Size(55, 47);
            this.imgcalcular.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgcalcular.TabIndex = 0;
            this.imgcalcular.TabStop = false;
            this.imgcalcular.Click += new System.EventHandler(this.imgcalcular_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.imgfoto);
            this.groupBox1.Controls.Add(this.cbocargo);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 123);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1044, 241);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Funcionário";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // imgfoto
            // 
            this.imgfoto.Image = global::exemplo1.Properties.Resources.download;
            this.imgfoto.Location = new System.Drawing.Point(829, 89);
            this.imgfoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgfoto.Name = "imgfoto";
            this.imgfoto.Size = new System.Drawing.Size(157, 137);
            this.imgfoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgfoto.TabIndex = 7;
            this.imgfoto.TabStop = false;
            this.toolTip1.SetToolTip(this.imgfoto, "Clique para inserir a foto feia");
            this.imgfoto.Click += new System.EventHandler(this.imgfoto_Click);
            // 
            // cbocargo
            // 
            this.cbocargo.FormattingEnabled = true;
            this.cbocargo.Items.AddRange(new object[] {
            "Analista de Sistemas",
            "CEO",
            "Engenheiro de Requisitos",
            "Gerente de T.I"});
            this.cbocargo.Location = new System.Drawing.Point(491, 97);
            this.cbocargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbocargo.Name = "cbocargo";
            this.cbocargo.Size = new System.Drawing.Size(256, 38);
            this.cbocargo.Sorted = true;
            this.cbocargo.TabIndex = 6;
            this.cbocargo.Text = "selecione ...";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(200, 97);
            this.txtnome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnome.MaxLength = 30;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(263, 37);
            this.txtnome.TabIndex = 5;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            this.txtnome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnome_KeyPress);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(23, 100);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcodigo.MaxLength = 5;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(91, 37);
            this.txtcodigo.TabIndex = 4;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Foto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cargo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.txtsl);
            this.groupBox2.Controls.Add(this.txtbs);
            this.groupBox2.Controls.Add(this.txtinss);
            this.groupBox2.Controls.Add(this.txtsb);
            this.groupBox2.Controls.Add(this.txtvh);
            this.groupBox2.Controls.Add(this.txtht);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 372);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1039, 250);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Salariais";
            // 
            // txtsl
            // 
            this.txtsl.BackColor = System.Drawing.Color.Silver;
            this.txtsl.Cursor = System.Windows.Forms.Cursors.No;
            this.txtsl.Location = new System.Drawing.Point(793, 185);
            this.txtsl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsl.Name = "txtsl";
            this.txtsl.ReadOnly = true;
            this.txtsl.Size = new System.Drawing.Size(145, 37);
            this.txtsl.TabIndex = 13;
            // 
            // txtbs
            // 
            this.txtbs.BackColor = System.Drawing.Color.Silver;
            this.txtbs.Cursor = System.Windows.Forms.Cursors.No;
            this.txtbs.Location = new System.Drawing.Point(427, 185);
            this.txtbs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbs.Name = "txtbs";
            this.txtbs.ReadOnly = true;
            this.txtbs.Size = new System.Drawing.Size(145, 37);
            this.txtbs.TabIndex = 12;
            // 
            // txtinss
            // 
            this.txtinss.BackColor = System.Drawing.Color.Silver;
            this.txtinss.Cursor = System.Windows.Forms.Cursors.No;
            this.txtinss.Location = new System.Drawing.Point(65, 185);
            this.txtinss.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtinss.Name = "txtinss";
            this.txtinss.ReadOnly = true;
            this.txtinss.Size = new System.Drawing.Size(145, 37);
            this.txtinss.TabIndex = 11;
            // 
            // txtsb
            // 
            this.txtsb.BackColor = System.Drawing.Color.Silver;
            this.txtsb.Cursor = System.Windows.Forms.Cursors.No;
            this.txtsb.Location = new System.Drawing.Point(793, 85);
            this.txtsb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsb.Name = "txtsb";
            this.txtsb.ReadOnly = true;
            this.txtsb.Size = new System.Drawing.Size(145, 37);
            this.txtsb.TabIndex = 10;
            // 
            // txtvh
            // 
            this.txtvh.Location = new System.Drawing.Point(427, 85);
            this.txtvh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtvh.MaxLength = 6;
            this.txtvh.Name = "txtvh";
            this.txtvh.Size = new System.Drawing.Size(145, 37);
            this.txtvh.TabIndex = 9;
            this.txtvh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvh_KeyPress);
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(65, 85);
            this.txtht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtht.MaxLength = 3;
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(145, 37);
            this.txtht.TabIndex = 8;
            this.txtht.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtht_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(725, 150);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(234, 31);
            this.label10.TabIndex = 6;
            this.label10.Text = "Salário Líquido R$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(375, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(230, 31);
            this.label9.TabIndex = 5;
            this.label9.Text = "Bônus Salarial R$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 150);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(304, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "Desconto INSS 11% R$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(748, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 31);
            this.label7.TabIndex = 3;
            this.label7.Text = "Salário Bruto R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(403, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(186, 31);
            this.label6.TabIndex = 2;
            this.label6.Text = "Valor/Hora R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Horas Trabalhadas";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 656);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 43);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(336, 37);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(336, 37);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(336, 37);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Click += new System.EventHandler(this.toolStripStatusLabel3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcularToolStripMenuItem1,
            this.limparToolStripMenuItem1,
            this.sairToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(132, 76);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // calcularToolStripMenuItem1
            // 
            this.calcularToolStripMenuItem1.Name = "calcularToolStripMenuItem1";
            this.calcularToolStripMenuItem1.Size = new System.Drawing.Size(131, 24);
            this.calcularToolStripMenuItem1.Text = "Calcular";
            this.calcularToolStripMenuItem1.Click += new System.EventHandler(this.calcularToolStripMenuItem1_Click);
            // 
            // limparToolStripMenuItem1
            // 
            this.limparToolStripMenuItem1.Name = "limparToolStripMenuItem1";
            this.limparToolStripMenuItem1.Size = new System.Drawing.Size(131, 24);
            this.limparToolStripMenuItem1.Text = "Limpar";
            this.limparToolStripMenuItem1.Click += new System.EventHandler(this.limparToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(131, 24);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 699);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicativo Folha de Pagamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgsair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgsobre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imglimpar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgcalcular)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgfoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgcalcular;
        private System.Windows.Forms.PictureBox imglimpar;
        private System.Windows.Forms.PictureBox imgsobre;
        private System.Windows.Forms.PictureBox imgsair;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox imgfoto;
        private System.Windows.Forms.ComboBox cbocargo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.TextBox txtbs;
        private System.Windows.Forms.TextBox txtinss;
        private System.Windows.Forms.TextBox txtsb;
        private System.Windows.Forms.TextBox txtvh;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem barraDeFerramentasToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calcularToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
    }
}

