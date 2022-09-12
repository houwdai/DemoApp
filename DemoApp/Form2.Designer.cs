namespace DemoApp
{
    partial class Form2
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
            this.namaPegawai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NIP = new System.Windows.Forms.TextBox();
            this.Jabatan = new System.Windows.Forms.TextBox();
            this.Golongan = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Inputid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // namaPegawai
            // 
            this.namaPegawai.Location = new System.Drawing.Point(192, 95);
            this.namaPegawai.Name = "namaPegawai";
            this.namaPegawai.Size = new System.Drawing.Size(100, 23);
            this.namaPegawai.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nama Pegawai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "NIP Pegawai";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jabatan";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Golongan Pegawai";
            // 
            // NIP
            // 
            this.NIP.Location = new System.Drawing.Point(192, 128);
            this.NIP.Name = "NIP";
            this.NIP.Size = new System.Drawing.Size(100, 23);
            this.NIP.TabIndex = 5;
            // 
            // Jabatan
            // 
            this.Jabatan.Location = new System.Drawing.Point(192, 157);
            this.Jabatan.Name = "Jabatan";
            this.Jabatan.Size = new System.Drawing.Size(100, 23);
            this.Jabatan.TabIndex = 6;
            // 
            // Golongan
            // 
            this.Golongan.Location = new System.Drawing.Point(192, 183);
            this.Golongan.Name = "Golongan";
            this.Golongan.Size = new System.Drawing.Size(100, 23);
            this.Golongan.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID";
            // 
            // Inputid
            // 
            this.Inputid.Location = new System.Drawing.Point(192, 68);
            this.Inputid.Name = "Inputid";
            this.Inputid.Size = new System.Drawing.Size(100, 23);
            this.Inputid.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 328);
            this.Controls.Add(this.Inputid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Golongan);
            this.Controls.Add(this.Jabatan);
            this.Controls.Add(this.NIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namaPegawai);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox namaPegawai;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NIP;
        private TextBox Jabatan;
        private TextBox Golongan;
        private Button button1;
        private Label label5;
        private TextBox Inputid;
    }
}