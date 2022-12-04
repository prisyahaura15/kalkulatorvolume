namespace kalkulatorvolume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPanjang = new System.Windows.Forms.TextBox();
            this.tbTinggi = new System.Windows.Forms.TextBox();
            this.tbLebar = new System.Windows.Forms.TextBox();
            this.tbDiameter = new System.Windows.Forms.TextBox();
            this.tbAlas = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbKerucut = new System.Windows.Forms.RadioButton();
            this.rbLimas4 = new System.Windows.Forms.RadioButton();
            this.rbLimas3 = new System.Windows.Forms.RadioButton();
            this.rbTabung = new System.Windows.Forms.RadioButton();
            this.rbBola = new System.Windows.Forms.RadioButton();
            this.rbPrisma = new System.Windows.Forms.RadioButton();
            this.rbBalok = new System.Windows.Forms.RadioButton();
            this.rbKubus = new System.Windows.Forms.RadioButton();
            this.bHitung = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCorrect = new System.Windows.Forms.ErrorProvider(this.components);
            this.epInfo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kalkulator Volume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Panjang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tinggi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lebar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Diameter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alas";
            // 
            // tbPanjang
            // 
            this.tbPanjang.Location = new System.Drawing.Point(110, 117);
            this.tbPanjang.Name = "tbPanjang";
            this.tbPanjang.Size = new System.Drawing.Size(100, 20);
            this.tbPanjang.TabIndex = 7;
            this.tbPanjang.Leave += new System.EventHandler(this.tbPanjang_Leave);
            // 
            // tbTinggi
            // 
            this.tbTinggi.Location = new System.Drawing.Point(110, 150);
            this.tbTinggi.Name = "tbTinggi";
            this.tbTinggi.Size = new System.Drawing.Size(100, 20);
            this.tbTinggi.TabIndex = 8;
            this.tbTinggi.Leave += new System.EventHandler(this.tbTinggi_Leave);
            // 
            // tbLebar
            // 
            this.tbLebar.Location = new System.Drawing.Point(110, 186);
            this.tbLebar.Name = "tbLebar";
            this.tbLebar.Size = new System.Drawing.Size(100, 20);
            this.tbLebar.TabIndex = 9;
            this.tbLebar.Leave += new System.EventHandler(this.tbLebar_Leave);
            // 
            // tbDiameter
            // 
            this.tbDiameter.Location = new System.Drawing.Point(110, 217);
            this.tbDiameter.Name = "tbDiameter";
            this.tbDiameter.Size = new System.Drawing.Size(100, 20);
            this.tbDiameter.TabIndex = 10;
            this.tbDiameter.Leave += new System.EventHandler(this.tbDiameter_Leave);
            // 
            // tbAlas
            // 
            this.tbAlas.Location = new System.Drawing.Point(110, 254);
            this.tbAlas.Name = "tbAlas";
            this.tbAlas.Size = new System.Drawing.Size(100, 20);
            this.tbAlas.TabIndex = 11;
            this.tbAlas.Leave += new System.EventHandler(this.tbAlas_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbKerucut);
            this.groupBox1.Controls.Add(this.rbLimas4);
            this.groupBox1.Controls.Add(this.rbLimas3);
            this.groupBox1.Controls.Add(this.rbTabung);
            this.groupBox1.Controls.Add(this.rbBola);
            this.groupBox1.Controls.Add(this.rbPrisma);
            this.groupBox1.Controls.Add(this.rbBalok);
            this.groupBox1.Controls.Add(this.rbKubus);
            this.groupBox1.Location = new System.Drawing.Point(383, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 167);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bentuk Bangun Ruang";
            // 
            // rbKerucut
            // 
            this.rbKerucut.AutoSize = true;
            this.rbKerucut.Location = new System.Drawing.Point(135, 101);
            this.rbKerucut.Name = "rbKerucut";
            this.rbKerucut.Size = new System.Drawing.Size(62, 17);
            this.rbKerucut.TabIndex = 7;
            this.rbKerucut.TabStop = true;
            this.rbKerucut.Text = "Kerucut";
            this.rbKerucut.UseVisualStyleBackColor = true;
            this.rbKerucut.CheckedChanged += new System.EventHandler(this.rbKerucut_CheckedChanged);
            // 
            // rbLimas4
            // 
            this.rbLimas4.AutoSize = true;
            this.rbLimas4.Location = new System.Drawing.Point(135, 69);
            this.rbLimas4.Name = "rbLimas4";
            this.rbLimas4.Size = new System.Drawing.Size(109, 17);
            this.rbLimas4.TabIndex = 6;
            this.rbLimas4.TabStop = true;
            this.rbLimas4.Text = "Limas Segi Empat";
            this.rbLimas4.UseVisualStyleBackColor = true;
            this.rbLimas4.CheckedChanged += new System.EventHandler(this.rbLimas4_CheckedChanged);
            // 
            // rbLimas3
            // 
            this.rbLimas3.AutoSize = true;
            this.rbLimas3.Location = new System.Drawing.Point(135, 36);
            this.rbLimas3.Name = "rbLimas3";
            this.rbLimas3.Size = new System.Drawing.Size(93, 17);
            this.rbLimas3.TabIndex = 5;
            this.rbLimas3.TabStop = true;
            this.rbLimas3.Text = "Limas Segitiga";
            this.rbLimas3.UseVisualStyleBackColor = true;
            this.rbLimas3.CheckedChanged += new System.EventHandler(this.rbLimas3_CheckedChanged);
            // 
            // rbTabung
            // 
            this.rbTabung.AutoSize = true;
            this.rbTabung.Location = new System.Drawing.Point(135, 133);
            this.rbTabung.Name = "rbTabung";
            this.rbTabung.Size = new System.Drawing.Size(62, 17);
            this.rbTabung.TabIndex = 4;
            this.rbTabung.TabStop = true;
            this.rbTabung.Text = "Tabung";
            this.rbTabung.UseVisualStyleBackColor = true;
            this.rbTabung.CheckedChanged += new System.EventHandler(this.rbTabung_CheckedChanged);
            // 
            // rbBola
            // 
            this.rbBola.AutoSize = true;
            this.rbBola.Location = new System.Drawing.Point(19, 133);
            this.rbBola.Name = "rbBola";
            this.rbBola.Size = new System.Drawing.Size(46, 17);
            this.rbBola.TabIndex = 3;
            this.rbBola.TabStop = true;
            this.rbBola.Text = "Bola";
            this.rbBola.UseVisualStyleBackColor = true;
            this.rbBola.CheckedChanged += new System.EventHandler(this.rbBola_CheckedChanged);
            // 
            // rbPrisma
            // 
            this.rbPrisma.AutoSize = true;
            this.rbPrisma.Location = new System.Drawing.Point(19, 99);
            this.rbPrisma.Name = "rbPrisma";
            this.rbPrisma.Size = new System.Drawing.Size(56, 17);
            this.rbPrisma.TabIndex = 2;
            this.rbPrisma.TabStop = true;
            this.rbPrisma.Text = "Prisma";
            this.rbPrisma.UseVisualStyleBackColor = true;
            this.rbPrisma.CheckedChanged += new System.EventHandler(this.rbPrisma_CheckedChanged);
            // 
            // rbBalok
            // 
            this.rbBalok.AutoSize = true;
            this.rbBalok.Location = new System.Drawing.Point(19, 67);
            this.rbBalok.Name = "rbBalok";
            this.rbBalok.Size = new System.Drawing.Size(52, 17);
            this.rbBalok.TabIndex = 1;
            this.rbBalok.TabStop = true;
            this.rbBalok.Text = "Balok";
            this.rbBalok.UseVisualStyleBackColor = true;
            this.rbBalok.CheckedChanged += new System.EventHandler(this.rbBalok_CheckedChanged);
            // 
            // rbKubus
            // 
            this.rbKubus.AutoSize = true;
            this.rbKubus.Location = new System.Drawing.Point(19, 34);
            this.rbKubus.Name = "rbKubus";
            this.rbKubus.Size = new System.Drawing.Size(55, 17);
            this.rbKubus.TabIndex = 0;
            this.rbKubus.TabStop = true;
            this.rbKubus.Text = "Kubus";
            this.rbKubus.UseVisualStyleBackColor = true;
            this.rbKubus.CheckedChanged += new System.EventHandler(this.rbKubus_CheckedChanged);
            // 
            // bHitung
            // 
            this.bHitung.Location = new System.Drawing.Point(223, 373);
            this.bHitung.Name = "bHitung";
            this.bHitung.Size = new System.Drawing.Size(75, 23);
            this.bHitung.TabIndex = 14;
            this.bHitung.Text = "Hitung";
            this.bHitung.UseVisualStyleBackColor = true;
            this.bHitung.Click += new System.EventHandler(this.bHitung_Click);
            // 
            // bClear
            // 
            this.bClear.Location = new System.Drawing.Point(393, 373);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 15;
            this.bClear.Text = "Clear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(273, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mohon diisi dengan angka dan dalam satuan yang sama";
            // 
            // epWrong
            // 
            this.epWrong.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // epCorrect
            // 
            this.epCorrect.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epCorrect.ContainerControl = this;
            this.epCorrect.Icon = ((System.Drawing.Icon)(resources.GetObject("epCorrect.Icon")));
            // 
            // epInfo
            // 
            this.epInfo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epInfo.ContainerControl = this;
            this.epInfo.Icon = ((System.Drawing.Icon)(resources.GetObject("epInfo.Icon")));
            // 
            // epWarning
            // 
            this.epWarning.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bHitung);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbAlas);
            this.Controls.Add(this.tbDiameter);
            this.Controls.Add(this.tbLebar);
            this.Controls.Add(this.tbTinggi);
            this.Controls.Add(this.tbPanjang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kalkulator Volume";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPanjang;
        private System.Windows.Forms.TextBox tbTinggi;
        private System.Windows.Forms.TextBox tbLebar;
        private System.Windows.Forms.TextBox tbDiameter;
        private System.Windows.Forms.TextBox tbAlas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbKerucut;
        private System.Windows.Forms.RadioButton rbLimas4;
        private System.Windows.Forms.RadioButton rbLimas3;
        private System.Windows.Forms.RadioButton rbTabung;
        private System.Windows.Forms.RadioButton rbBola;
        private System.Windows.Forms.RadioButton rbPrisma;
        private System.Windows.Forms.RadioButton rbBalok;
        private System.Windows.Forms.RadioButton rbKubus;
        private System.Windows.Forms.Button bHitung;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider epWrong;
        private System.Windows.Forms.ErrorProvider epCorrect;
        private System.Windows.Forms.ErrorProvider epInfo;
        private System.Windows.Forms.ErrorProvider epWarning;
    }
}

