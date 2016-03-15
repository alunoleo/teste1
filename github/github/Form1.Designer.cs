namespace github
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imgCamUser_2 = new Emgu.CV.UI.ImageBox();
            this.buttonEscolher_foto = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgCamUser_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(98, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Rechonecimento facial";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Tirar Foto?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imgCamUser_2
            // 
            this.imgCamUser_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCamUser_2.Location = new System.Drawing.Point(548, 12);
            this.imgCamUser_2.Name = "imgCamUser_2";
            this.imgCamUser_2.Size = new System.Drawing.Size(349, 265);
            this.imgCamUser_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCamUser_2.TabIndex = 5;
            this.imgCamUser_2.TabStop = false;
            // 
            // buttonEscolher_foto
            // 
            this.buttonEscolher_foto.Location = new System.Drawing.Point(357, 282);
            this.buttonEscolher_foto.Name = "buttonEscolher_foto";
            this.buttonEscolher_foto.Size = new System.Drawing.Size(185, 23);
            this.buttonEscolher_foto.TabIndex = 7;
            this.buttonEscolher_foto.Text = "Selecionar foto para reconhecer";
            this.buttonEscolher_foto.UseVisualStyleBackColor = true;
            this.buttonEscolher_foto.Click += new System.EventHandler(this.buttonLer_fotos_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(339, 265);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 356);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.buttonEscolher_foto);
            this.Controls.Add(this.imgCamUser_2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCamUser_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.ImageBox imgCamUser_2;
        private System.Windows.Forms.Button buttonEscolher_foto;
        private Emgu.CV.UI.ImageBox imageBox1;
    }
}

