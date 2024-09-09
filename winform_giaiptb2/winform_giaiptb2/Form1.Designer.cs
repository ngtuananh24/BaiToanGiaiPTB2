namespace winform_giaiptb2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nhapb = new System.Windows.Forms.TextBox();
            this.tb_nhapc = new System.Windows.Forms.TextBox();
            this.tb_nhapa = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kq = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH GIẢI PHƯƠNG TRÌNH BẬC 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = " ax2+bx+c=0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập hệ số a:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhập hệ số b:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(355, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập hệ số c:";
            // 
            // tb_nhapb
            // 
            this.tb_nhapb.Location = new System.Drawing.Point(450, 178);
            this.tb_nhapb.Name = "tb_nhapb";
            this.tb_nhapb.Size = new System.Drawing.Size(124, 22);
            this.tb_nhapb.TabIndex = 6;
            // 
            // tb_nhapc
            // 
            this.tb_nhapc.Location = new System.Drawing.Point(450, 220);
            this.tb_nhapc.Name = "tb_nhapc";
            this.tb_nhapc.Size = new System.Drawing.Size(124, 22);
            this.tb_nhapc.TabIndex = 7;
            // 
            // tb_nhapa
            // 
            this.tb_nhapa.Location = new System.Drawing.Point(450, 133);
            this.tb_nhapa.Name = "tb_nhapa";
            this.tb_nhapa.Size = new System.Drawing.Size(124, 22);
            this.tb_nhapa.TabIndex = 8;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(602, 226);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(57, 28);
            this.btn_tim.TabIndex = 10;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kq);
            this.groupBox1.Location = new System.Drawing.Point(290, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 132);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nghiệm PT";
            // 
            // kq
            // 
            this.kq.AutoSize = true;
            this.kq.Location = new System.Drawing.Point(19, 35);
            this.kq.Name = "kq";
            this.kq.Size = new System.Drawing.Size(0, 16);
            this.kq.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::winform_giaiptb2.Properties.Resources.pngtree_cute_hand_drawn_style_mathematics_education_pink_plaid_background_picture_image_1176976;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.tb_nhapa);
            this.Controls.Add(this.tb_nhapc);
            this.Controls.Add(this.tb_nhapb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nhapb;
        private System.Windows.Forms.TextBox tb_nhapc;
        private System.Windows.Forms.TextBox tb_nhapa;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label kq;
    }
}

