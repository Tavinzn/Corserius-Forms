namespace Corserius_form
{
    partial class frmExe6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExe6));
            this.btn1 = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txb1 = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Location = new System.Drawing.Point(357, 180);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(101, 41);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "Calcular";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.BackColor = System.Drawing.Color.Transparent;
            this.Result.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(195, 260);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 24);
            this.Result.TabIndex = 8;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(42, 258);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(147, 27);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Fatorial:";
            // 
            // txb1
            // 
            this.txb1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb1.Location = new System.Drawing.Point(633, 127);
            this.txb1.Name = "txb1";
            this.txb1.Size = new System.Drawing.Size(100, 29);
            this.txb1.TabIndex = 6;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(65, 128);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(562, 21);
            this.lbltitulo.TabIndex = 5;
            this.lbltitulo.Text = "Escreva um numero inteiro (diferente de zero):";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmExe6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txb1);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmExe6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExe6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txb1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}