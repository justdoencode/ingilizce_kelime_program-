namespace ingilizce_kelime_oyunu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_turkce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_kelime = new System.Windows.Forms.Label();
            this.lbl_turkce = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_süre = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_bilinenkelime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce Kelime :";
            // 
            // txt_turkce
            // 
            this.txt_turkce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_turkce.Location = new System.Drawing.Point(219, 119);
            this.txt_turkce.Name = "txt_turkce";
            this.txt_turkce.Size = new System.Drawing.Size(100, 23);
            this.txt_turkce.TabIndex = 3;
            this.txt_turkce.TextChanged += new System.EventHandler(this.txt_turkce_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(82, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe Karşılığı :";
            // 
            // lbl_kelime
            // 
            this.lbl_kelime.AutoSize = true;
            this.lbl_kelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kelime.Location = new System.Drawing.Point(219, 82);
            this.lbl_kelime.Name = "lbl_kelime";
            this.lbl_kelime.Size = new System.Drawing.Size(14, 17);
            this.lbl_kelime.TabIndex = 4;
            this.lbl_kelime.Text = "-";
            // 
            // lbl_turkce
            // 
            this.lbl_turkce.AutoSize = true;
            this.lbl_turkce.Location = new System.Drawing.Point(12, 228);
            this.lbl_turkce.Name = "lbl_turkce";
            this.lbl_turkce.Size = new System.Drawing.Size(35, 13);
            this.lbl_turkce.TabIndex = 5;
            this.lbl_turkce.Text = "label3";
            this.lbl_turkce.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(82, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kalan Süre :";
            // 
            // lbl_süre
            // 
            this.lbl_süre.AutoSize = true;
            this.lbl_süre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_süre.Location = new System.Drawing.Point(186, 37);
            this.lbl_süre.Name = "lbl_süre";
            this.lbl_süre.Size = new System.Drawing.Size(26, 17);
            this.lbl_süre.TabIndex = 7;
            this.lbl_süre.Text = "90";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_bilinenkelime
            // 
            this.lbl_bilinenkelime.AutoSize = true;
            this.lbl_bilinenkelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_bilinenkelime.Location = new System.Drawing.Point(218, 167);
            this.lbl_bilinenkelime.Name = "lbl_bilinenkelime";
            this.lbl_bilinenkelime.Size = new System.Drawing.Size(17, 17);
            this.lbl_bilinenkelime.TabIndex = 9;
            this.lbl_bilinenkelime.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(93, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bilinen Kelime :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 250);
            this.Controls.Add(this.lbl_bilinenkelime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_süre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_turkce);
            this.Controls.Add(this.lbl_kelime);
            this.Controls.Add(this.txt_turkce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_turkce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_kelime;
        private System.Windows.Forms.Label lbl_turkce;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_süre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_bilinenkelime;
        private System.Windows.Forms.Label label5;
    }
}

