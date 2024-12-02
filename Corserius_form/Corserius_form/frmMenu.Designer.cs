namespace Corserius_form
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.MenuOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bemVindoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolmenuUsu = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl1Info = new System.Windows.Forms.Label();
            this.lbl2Info = new System.Windows.Forms.Label();
            this.lbl3Info = new System.Windows.Forms.Label();
            this.lbl4Ifno = new System.Windows.Forms.Label();
            this.lbl5Info = new System.Windows.Forms.Label();
            this.lbl6Info = new System.Windows.Forms.Label();
            this.exe2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exe3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exe4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exe5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exe6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exe7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exe8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exe9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exe10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuOptions
            // 
            this.MenuOptions.Name = "MenuOptions";
            this.MenuOptions.Size = new System.Drawing.Size(61, 4);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.DimGray;
            this.MenuStrip.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.bemVindoToolStripMenuItem,
            this.toolmenuUsu,
            this.funçõesToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1485, 30);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.consultarToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem.Image")));
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produtosToolStripMenuItem.Image")));
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.produtosToolStripMenuItem.Text = "Funcionarios";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem1,
            this.funcionarioToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(93, 26);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // clientesToolStripMenuItem1
            // 
            this.clientesToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("clientesToolStripMenuItem1.Image")));
            this.clientesToolStripMenuItem1.Name = "clientesToolStripMenuItem1";
            this.clientesToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.clientesToolStripMenuItem1.Size = new System.Drawing.Size(206, 26);
            this.clientesToolStripMenuItem1.Text = "Clientes";
            this.clientesToolStripMenuItem1.Click += new System.EventHandler(this.clientesToolStripMenuItem1_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionarioToolStripMenuItem.Image")));
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.funcionarioToolStripMenuItem.Text = "Funcionarios";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // bemVindoToolStripMenuItem
            // 
            this.bemVindoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.bemVindoToolStripMenuItem.Name = "bemVindoToolStripMenuItem";
            this.bemVindoToolStripMenuItem.Size = new System.Drawing.Size(102, 26);
            this.bemVindoToolStripMenuItem.Text = "Bem vindo";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // toolmenuUsu
            // 
            this.toolmenuUsu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolmenuUsu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trocarDeUsuarioToolStripMenuItem});
            this.toolmenuUsu.Name = "toolmenuUsu";
            this.toolmenuUsu.Size = new System.Drawing.Size(81, 26);
            this.toolmenuUsu.Text = "Usuario";
            // 
            // trocarDeUsuarioToolStripMenuItem
            // 
            this.trocarDeUsuarioToolStripMenuItem.Name = "trocarDeUsuarioToolStripMenuItem";
            this.trocarDeUsuarioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.trocarDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.trocarDeUsuarioToolStripMenuItem.Text = "Trocar de Usuario";
            this.trocarDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.trocarDeUsuarioToolStripMenuItem_Click);
            // 
            // funçõesToolStripMenuItem
            // 
            this.funçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.exe2ToolStripMenuItem,
            this.exe3ToolStripMenuItem,
            this.exe4ToolStripMenuItem,
            this.exe5ToolStripMenuItem,
            this.exe6ToolStripMenuItem,
            this.exe7ToolStripMenuItem,
            this.exe8ToolStripMenuItem,
            this.exe9ToolStripMenuItem,
            this.exe10ToolStripMenuItem});
            this.funçõesToolStripMenuItem.Name = "funçõesToolStripMenuItem";
            this.funçõesToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.funçõesToolStripMenuItem.Text = "Funções";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 26);
            this.toolStripMenuItem2.Text = "Exe1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // lbl1Info
            // 
            this.lbl1Info.AutoSize = true;
            this.lbl1Info.BackColor = System.Drawing.Color.Transparent;
            this.lbl1Info.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Info.ForeColor = System.Drawing.Color.Gray;
            this.lbl1Info.Location = new System.Drawing.Point(44, 171);
            this.lbl1Info.Name = "lbl1Info";
            this.lbl1Info.Size = new System.Drawing.Size(250, 21);
            this.lbl1Info.TabIndex = 3;
            this.lbl1Info.Text = "F1 Cadastrar cliente";
            // 
            // lbl2Info
            // 
            this.lbl2Info.AutoSize = true;
            this.lbl2Info.BackColor = System.Drawing.Color.Transparent;
            this.lbl2Info.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Info.ForeColor = System.Drawing.Color.Gray;
            this.lbl2Info.Location = new System.Drawing.Point(44, 192);
            this.lbl2Info.Name = "lbl2Info";
            this.lbl2Info.Size = new System.Drawing.Size(298, 21);
            this.lbl2Info.TabIndex = 4;
            this.lbl2Info.Text = "F2 Cadastrar Funcionario";
            // 
            // lbl3Info
            // 
            this.lbl3Info.AutoSize = true;
            this.lbl3Info.BackColor = System.Drawing.Color.Transparent;
            this.lbl3Info.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Info.ForeColor = System.Drawing.Color.Gray;
            this.lbl3Info.Location = new System.Drawing.Point(44, 213);
            this.lbl3Info.Name = "lbl3Info";
            this.lbl3Info.Size = new System.Drawing.Size(250, 21);
            this.lbl3Info.TabIndex = 5;
            this.lbl3Info.Text = "F3 Consultar Cliente";
            // 
            // lbl4Ifno
            // 
            this.lbl4Ifno.AutoSize = true;
            this.lbl4Ifno.BackColor = System.Drawing.Color.Transparent;
            this.lbl4Ifno.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Ifno.ForeColor = System.Drawing.Color.Gray;
            this.lbl4Ifno.Location = new System.Drawing.Point(44, 234);
            this.lbl4Ifno.Name = "lbl4Ifno";
            this.lbl4Ifno.Size = new System.Drawing.Size(298, 21);
            this.lbl4Ifno.TabIndex = 6;
            this.lbl4Ifno.Text = "F4 Consultar Funcionario";
            // 
            // lbl5Info
            // 
            this.lbl5Info.AutoSize = true;
            this.lbl5Info.BackColor = System.Drawing.Color.Transparent;
            this.lbl5Info.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5Info.ForeColor = System.Drawing.Color.Gray;
            this.lbl5Info.Location = new System.Drawing.Point(44, 255);
            this.lbl5Info.Name = "lbl5Info";
            this.lbl5Info.Size = new System.Drawing.Size(154, 21);
            this.lbl5Info.TabIndex = 7;
            this.lbl5Info.Text = "F5 Sobre Nós";
            // 
            // lbl6Info
            // 
            this.lbl6Info.AutoSize = true;
            this.lbl6Info.BackColor = System.Drawing.Color.Transparent;
            this.lbl6Info.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6Info.ForeColor = System.Drawing.Color.Gray;
            this.lbl6Info.Location = new System.Drawing.Point(44, 276);
            this.lbl6Info.Name = "lbl6Info";
            this.lbl6Info.Size = new System.Drawing.Size(250, 21);
            this.lbl6Info.TabIndex = 8;
            this.lbl6Info.Text = "F6 Trocar De Usuário";
            // 
            // exe2ToolStripMenuItem
            // 
            this.exe2ToolStripMenuItem.Name = "exe2ToolStripMenuItem";
            this.exe2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.exe2ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exe2ToolStripMenuItem.Text = "Exe2";
            this.exe2ToolStripMenuItem.Click += new System.EventHandler(this.exe2ToolStripMenuItem_Click);
            // 
            // exe3ToolStripMenuItem
            // 
            this.exe3ToolStripMenuItem.Name = "exe3ToolStripMenuItem";
            this.exe3ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.exe3ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exe3ToolStripMenuItem.Text = "Exe3";
            this.exe3ToolStripMenuItem.Click += new System.EventHandler(this.exe3ToolStripMenuItem_Click);
            // 
            // exe4ToolStripMenuItem
            // 
            this.exe4ToolStripMenuItem.Name = "exe4ToolStripMenuItem";
            this.exe4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.exe4ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exe4ToolStripMenuItem.Text = "Exe4";
            this.exe4ToolStripMenuItem.Click += new System.EventHandler(this.exe4ToolStripMenuItem_Click);
            // 
            // exe5ToolStripMenuItem
            // 
            this.exe5ToolStripMenuItem.Name = "exe5ToolStripMenuItem";
            this.exe5ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F15)));
            this.exe5ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exe5ToolStripMenuItem.Text = "Exe5";
            this.exe5ToolStripMenuItem.Click += new System.EventHandler(this.exe5ToolStripMenuItem_Click);
            // 
            // exe6ToolStripMenuItem
            // 
            this.exe6ToolStripMenuItem.Name = "exe6ToolStripMenuItem";
            this.exe6ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F6)));
            this.exe6ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exe6ToolStripMenuItem.Text = "Exe6";
            this.exe6ToolStripMenuItem.Click += new System.EventHandler(this.exe6ToolStripMenuItem_Click);
            // 
            // exe7ToolStripMenuItem
            // 
            this.exe7ToolStripMenuItem.Name = "exe7ToolStripMenuItem";
            this.exe7ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F7)));
            this.exe7ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exe7ToolStripMenuItem.Text = "Exe7";
            this.exe7ToolStripMenuItem.Click += new System.EventHandler(this.exe7ToolStripMenuItem_Click);
            // 
            // exe8ToolStripMenuItem
            // 
            this.exe8ToolStripMenuItem.Name = "exe8ToolStripMenuItem";
            this.exe8ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F8)));
            this.exe8ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exe8ToolStripMenuItem.Text = "Exe8";
            this.exe8ToolStripMenuItem.Click += new System.EventHandler(this.exe8ToolStripMenuItem_Click);
            // 
            // exe9ToolStripMenuItem
            // 
            this.exe9ToolStripMenuItem.Name = "exe9ToolStripMenuItem";
            this.exe9ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F9)));
            this.exe9ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exe9ToolStripMenuItem.Text = "Exe9";
            this.exe9ToolStripMenuItem.Click += new System.EventHandler(this.exe9ToolStripMenuItem_Click);
            // 
            // exe10ToolStripMenuItem
            // 
            this.exe10ToolStripMenuItem.Name = "exe10ToolStripMenuItem";
            this.exe10ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F10)));
            this.exe10ToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.exe10ToolStripMenuItem.Text = "Exe10";
            this.exe10ToolStripMenuItem.Click += new System.EventHandler(this.exe10ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(44, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Crtl + F1 Função 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(44, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Crtl + F2 Função 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(44, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Crtl + F3 Função 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(44, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Crtl + F4 Função 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(44, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Crtl + F5 Função 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(44, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Crtl + F6 Função 6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(44, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(226, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Crtl + F7 Função 7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(44, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Crtl + F8 Função 8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gray;
            this.label9.Location = new System.Drawing.Point(44, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(226, 21);
            this.label9.TabIndex = 18;
            this.label9.Text = "Crtl + F9 Função 9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Gray;
            this.label10.Location = new System.Drawing.Point(44, 487);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 21);
            this.label10.TabIndex = 19;
            this.label10.Text = "Crtl + F10 Função 10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(44, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 21);
            this.label11.TabIndex = 20;
            this.label11.Text = "Atalhos:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1249, 815);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 62);
            this.button1.TabIndex = 21;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1485, 903);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl6Info);
            this.Controls.Add(this.lbl5Info);
            this.Controls.Add(this.lbl4Ifno);
            this.Controls.Add(this.lbl3Info);
            this.Controls.Add(this.lbl2Info);
            this.Controls.Add(this.lbl1Info);
            this.Controls.Add(this.MenuStrip);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "frmMenu";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu - Corserius";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip MenuOptions;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bemVindoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolmenuUsu;
        private System.Windows.Forms.ToolStripMenuItem trocarDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.Label lbl1Info;
        private System.Windows.Forms.Label lbl2Info;
        private System.Windows.Forms.Label lbl3Info;
        private System.Windows.Forms.Label lbl4Ifno;
        private System.Windows.Forms.Label lbl5Info;
        private System.Windows.Forms.Label lbl6Info;
        private System.Windows.Forms.ToolStripMenuItem funçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exe2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exe3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exe4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exe5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exe6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exe7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exe8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exe9ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exe10ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}