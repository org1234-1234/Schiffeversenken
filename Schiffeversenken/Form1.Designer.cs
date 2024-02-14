namespace Schiffeversenken
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pic_Spielfeld = new System.Windows.Forms.PictureBox();
            this.lbl_Ueberschrift = new System.Windows.Forms.Label();
            this.btn_SchiffePlatzieren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Spielfeld)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Spielfeld
            // 
            this.pic_Spielfeld.Image = ((System.Drawing.Image)(resources.GetObject("pic_Spielfeld.Image")));
            this.pic_Spielfeld.Location = new System.Drawing.Point(13, 200);
            this.pic_Spielfeld.Name = "pic_Spielfeld";
            this.pic_Spielfeld.Size = new System.Drawing.Size(988, 662);
            this.pic_Spielfeld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Spielfeld.TabIndex = 1;
            this.pic_Spielfeld.TabStop = false;
            // 
            // lbl_Ueberschrift
            // 
            this.lbl_Ueberschrift.AutoSize = true;
            this.lbl_Ueberschrift.Font = new System.Drawing.Font("Stencil", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Ueberschrift.Location = new System.Drawing.Point(84, 19);
            this.lbl_Ueberschrift.Name = "lbl_Ueberschrift";
            this.lbl_Ueberschrift.Size = new System.Drawing.Size(838, 95);
            this.lbl_Ueberschrift.TabIndex = 2;
            this.lbl_Ueberschrift.Text = "Schiffe versenken";
            // 
            // btn_SchiffePlatzieren
            // 
            this.btn_SchiffePlatzieren.Location = new System.Drawing.Point(97, 127);
            this.btn_SchiffePlatzieren.Name = "btn_SchiffePlatzieren";
            this.btn_SchiffePlatzieren.Size = new System.Drawing.Size(204, 29);
            this.btn_SchiffePlatzieren.TabIndex = 3;
            this.btn_SchiffePlatzieren.Text = "Schiffe platzieren";
            this.btn_SchiffePlatzieren.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 874);
            this.Controls.Add(this.btn_SchiffePlatzieren);
            this.Controls.Add(this.lbl_Ueberschrift);
            this.Controls.Add(this.pic_Spielfeld);
            this.Name = "Form1";
            this.Text = "Schiffeversenken";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Spielfeld)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic_Spielfeld;
        private System.Windows.Forms.Label lbl_Ueberschrift;
        private System.Windows.Forms.Button btn_SchiffePlatzieren;
    }
}

