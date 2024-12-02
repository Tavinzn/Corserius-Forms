namespace Corserius_form
{
    partial class frmSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSobre));
            this.lblTituloSobreNós = new System.Windows.Forms.Label();
            this.lblSobreNós = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloSobreNós
            // 
            this.lblTituloSobreNós.AutoSize = true;
            this.lblTituloSobreNós.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSobreNós.Location = new System.Drawing.Point(219, 34);
            this.lblTituloSobreNós.Name = "lblTituloSobreNós";
            this.lblTituloSobreNós.Size = new System.Drawing.Size(324, 64);
            this.lblTituloSobreNós.TabIndex = 0;
            this.lblTituloSobreNós.Text = "Sobre Nós";
            // 
            // lblSobreNós
            // 
            this.lblSobreNós.AllowDrop = true;
            this.lblSobreNós.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobreNós.Location = new System.Drawing.Point(38, 139);
            this.lblSobreNós.Name = "lblSobreNós";
            this.lblSobreNós.Size = new System.Drawing.Size(776, 230);
            this.lblSobreNós.TabIndex = 1;
            this.lblSobreNós.Text = resources.GetString("lblSobreNós.Text");
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(-7, -4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(165, 140);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // frmSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblSobreNós);
            this.Controls.Add(this.lblTituloSobreNós);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre Nós";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloSobreNós;
        private System.Windows.Forms.Label lblSobreNós;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}