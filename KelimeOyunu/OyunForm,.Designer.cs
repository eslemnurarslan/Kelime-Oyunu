namespace KelimeOyunu
{
    partial class OyunForm_
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
            this.soruLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kelimeLabel = new System.Windows.Forms.Label();
            this.tbTahmin = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.skorLabel = new System.Windows.Forms.Label();
            this.oyuncuLabel = new System.Windows.Forms.Label();
            this.sureLabel = new System.Windows.Forms.Label();
            this.oyunSayac = new System.Windows.Forms.Timer(this.components);
            this.cevapSayac = new System.Windows.Forms.Timer(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.tarihLabel = new System.Windows.Forms.Label();
            this.soruSayiLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(266, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Başla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(266, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "Cevap Ver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // soruLabel
            // 
            this.soruLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soruLabel.Location = new System.Drawing.Point(61, 16);
            this.soruLabel.Name = "soruLabel";
            this.soruLabel.Size = new System.Drawing.Size(533, 56);
            this.soruLabel.TabIndex = 1;
            this.soruLabel.Text = "------------------------------------";
            this.soruLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.kelimeLabel);
            this.groupBox1.Controls.Add(this.soruLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 111);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // kelimeLabel
            // 
            this.kelimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelimeLabel.Location = new System.Drawing.Point(235, 72);
            this.kelimeLabel.Name = "kelimeLabel";
            this.kelimeLabel.Size = new System.Drawing.Size(187, 23);
            this.kelimeLabel.TabIndex = 1;
            this.kelimeLabel.Text = "------------------";
            this.kelimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbTahmin
            // 
            this.tbTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTahmin.Location = new System.Drawing.Point(266, 154);
            this.tbTahmin.Name = "tbTahmin";
            this.tbTahmin.Size = new System.Drawing.Size(156, 26);
            this.tbTahmin.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(349, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "Harf Al";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(611, 287);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 44);
            this.button4.TabIndex = 0;
            this.button4.Text = "Çıkış";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tahmininiz";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Skor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Oyuncu:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kalan Süre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // skorLabel
            // 
            this.skorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skorLabel.Location = new System.Drawing.Point(12, 214);
            this.skorLabel.Name = "skorLabel";
            this.skorLabel.Size = new System.Drawing.Size(187, 23);
            this.skorLabel.TabIndex = 1;
            this.skorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyuncuLabel
            // 
            this.oyuncuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oyuncuLabel.Location = new System.Drawing.Point(12, 154);
            this.oyuncuLabel.Name = "oyuncuLabel";
            this.oyuncuLabel.Size = new System.Drawing.Size(187, 23);
            this.oyuncuLabel.TabIndex = 1;
            this.oyuncuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sureLabel
            // 
            this.sureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureLabel.Location = new System.Drawing.Point(12, 268);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(187, 23);
            this.sureLabel.TabIndex = 1;
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oyunSayac
            // 
            this.oyunSayac.Interval = 1000;
            this.oyunSayac.Tick += new System.EventHandler(this.oyunSayac_Tick);
            // 
            // cevapSayac
            // 
            this.cevapSayac.Interval = 1000;
            this.cevapSayac.Tick += new System.EventHandler(this.cevapSayac_Tick);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(269, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Tahmin Et";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tarihLabel
            // 
            this.tarihLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarihLabel.Location = new System.Drawing.Point(12, 312);
            this.tarihLabel.Name = "tarihLabel";
            this.tarihLabel.Size = new System.Drawing.Size(187, 23);
            this.tarihLabel.TabIndex = 1;
            this.tarihLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // soruSayiLbl
            // 
            this.soruSayiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soruSayiLbl.Location = new System.Drawing.Point(496, 131);
            this.soruSayiLbl.Name = "soruSayiLbl";
            this.soruSayiLbl.Size = new System.Drawing.Size(187, 23);
            this.soruSayiLbl.TabIndex = 1;
            this.soruSayiLbl.Text = "Soru:";
            this.soruSayiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OyunForm_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 344);
            this.ControlBox = false;
            this.Controls.Add(this.sureLabel);
            this.Controls.Add(this.tarihLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oyuncuLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.skorLabel);
            this.Controls.Add(this.soruSayiLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTahmin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "OyunForm_";
            this.Text = "Kelime Oyunu";
            this.Load += new System.EventHandler(this.OyunForm__Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label soruLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label kelimeLabel;
        private System.Windows.Forms.TextBox tbTahmin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label skorLabel;
        private System.Windows.Forms.Label oyuncuLabel;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Timer oyunSayac;
        private System.Windows.Forms.Timer cevapSayac;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label tarihLabel;
        private System.Windows.Forms.Label soruSayiLbl;
    }
}