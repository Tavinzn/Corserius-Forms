namespace Corserius_form
{
    partial class frmCadFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadFuncionario));
            this.lblNome = new System.Windows.Forms.Label();
            this.txbNamefun = new System.Windows.Forms.TextBox();
            this.txbEmailfun = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTituloFun = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.lblTelFun = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimparFun = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(89, 136);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(87, 27);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txbNamefun
            // 
            this.txbNamefun.BackColor = System.Drawing.Color.Silver;
            this.txbNamefun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNamefun.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNamefun.Location = new System.Drawing.Point(218, 130);
            this.txbNamefun.Name = "txbNamefun";
            this.txbNamefun.Size = new System.Drawing.Size(360, 33);
            this.txbNamefun.TabIndex = 1;
            // 
            // txbEmailfun
            // 
            this.txbEmailfun.BackColor = System.Drawing.Color.Silver;
            this.txbEmailfun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbEmailfun.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailfun.Location = new System.Drawing.Point(218, 183);
            this.txbEmailfun.Name = "txbEmailfun";
            this.txbEmailfun.Size = new System.Drawing.Size(360, 33);
            this.txbEmailfun.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(74, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(102, 27);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblTituloFun
            // 
            this.lblTituloFun.AutoSize = true;
            this.lblTituloFun.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloFun.Location = new System.Drawing.Point(121, 31);
            this.lblTituloFun.Name = "lblTituloFun";
            this.lblTituloFun.Size = new System.Drawing.Size(570, 48);
            this.lblTituloFun.TabIndex = 4;
            this.lblTituloFun.Text = "Cadastro - Funcionário";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.Silver;
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox2.Location = new System.Drawing.Point(218, 242);
            this.maskedTextBox2.Mask = "(00)00000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(212, 33);
            this.maskedTextBox2.TabIndex = 6;
            // 
            // lblTelFun
            // 
            this.lblTelFun.AutoSize = true;
            this.lblTelFun.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelFun.Location = new System.Drawing.Point(104, 248);
            this.lblTelFun.Name = "lblTelFun";
            this.lblTelFun.Size = new System.Drawing.Size(72, 27);
            this.lblTelFun.TabIndex = 7;
            this.lblTelFun.Text = "Tel:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.DimGray;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCadastrar.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(572, 313);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(107, 44);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimparFun
            // 
            this.btnLimparFun.BackColor = System.Drawing.Color.DimGray;
            this.btnLimparFun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimparFun.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparFun.ForeColor = System.Drawing.Color.White;
            this.btnLimparFun.Location = new System.Drawing.Point(434, 313);
            this.btnLimparFun.Name = "btnLimparFun";
            this.btnLimparFun.Size = new System.Drawing.Size(103, 44);
            this.btnLimparFun.TabIndex = 9;
            this.btnLimparFun.Text = "Limpar";
            this.btnLimparFun.UseVisualStyleBackColor = false;
            this.btnLimparFun.Click += new System.EventHandler(this.btnLimparFun_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(753, 385);
            this.Controls.Add(this.lblTituloFun);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnLimparFun);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblTelFun);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.txbEmailfun);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txbNamefun);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro - Funcionario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txbNamefun;
        private System.Windows.Forms.TextBox txbEmailfun;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTituloFun;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label lblTelFun;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimparFun;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}