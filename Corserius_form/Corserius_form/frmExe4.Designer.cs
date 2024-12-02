namespace Corserius_form
{
    partial class frmExe4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExe4));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxNascimento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAno = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(353, 347);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(34, 35);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ano de Nascimento:";
            // 
            // tbxNascimento
            // 
            this.tbxNascimento.BackColor = System.Drawing.Color.Gainsboro;
            this.tbxNascimento.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNascimento.Location = new System.Drawing.Point(383, 116);
            this.tbxNascimento.Name = "tbxNascimento";
            this.tbxNascimento.Size = new System.Drawing.Size(100, 36);
            this.tbxNascimento.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ano atual:";
            // 
            // tbxAno
            // 
            this.tbxAno.BackColor = System.Drawing.Color.Gainsboro;
            this.tbxAno.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAno.Location = new System.Drawing.Point(383, 168);
            this.tbxAno.Name = "tbxAno";
            this.tbxAno.Size = new System.Drawing.Size(100, 36);
            this.tbxAno.TabIndex = 10;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(370, 227);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(122, 45);
            this.btn1.TabIndex = 12;
            this.btn1.Text = "Consultar";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 27);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sua idade Atual:";
            // 
            // frmExe4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.tbxAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNascimento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExe4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExe4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNascimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAno;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label3;
    }
}