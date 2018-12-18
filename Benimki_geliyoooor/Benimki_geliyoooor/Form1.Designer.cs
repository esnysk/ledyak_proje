namespace Benimki_geliyoooor
{
    partial class esnakod
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
            this.kaynak = new System.Windows.Forms.PictureBox();
            this.islem = new System.Windows.Forms.PictureBox();
            this.Basla = new System.Windows.Forms.Button();
            this.kamerasec = new System.Windows.Forms.ComboBox();
            this.gonder = new System.Windows.Forms.Button();
            this.ScrollBark = new System.Windows.Forms.HScrollBar();
            this.ScrollBary = new System.Windows.Forms.HScrollBar();
            this.ScrollBarm = new System.Windows.Forms.HScrollBar();
            this.Takipet = new System.Windows.Forms.Button();
            this.KırmızıButton = new System.Windows.Forms.RadioButton();
            this.YesilButton = new System.Windows.Forms.RadioButton();
            this.MaviButton = new System.Windows.Forms.RadioButton();
            this.labelk = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.labelm = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kaynak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islem)).BeginInit();
            this.SuspendLayout();
            // 
            // kaynak
            // 
            this.kaynak.BackColor = System.Drawing.Color.RosyBrown;
            this.kaynak.Location = new System.Drawing.Point(34, 62);
            this.kaynak.Name = "kaynak";
            this.kaynak.Size = new System.Drawing.Size(600, 450);
            this.kaynak.TabIndex = 0;
            this.kaynak.TabStop = false;
            // 
            // islem
            // 
            this.islem.BackColor = System.Drawing.Color.RosyBrown;
            this.islem.Location = new System.Drawing.Point(672, 62);
            this.islem.Name = "islem";
            this.islem.Size = new System.Drawing.Size(600, 450);
            this.islem.TabIndex = 1;
            this.islem.TabStop = false;
            // 
            // Basla
            // 
            this.Basla.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Basla.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Basla.Location = new System.Drawing.Point(575, 11);
            this.Basla.Name = "Basla";
            this.Basla.Size = new System.Drawing.Size(150, 35);
            this.Basla.TabIndex = 2;
            this.Basla.Text = "Basla";
            this.Basla.UseVisualStyleBackColor = false;
            this.Basla.Click += new System.EventHandler(this.Basla_Click);
            // 
            // kamerasec
            // 
            this.kamerasec.FormattingEnabled = true;
            this.kamerasec.Location = new System.Drawing.Point(162, 22);
            this.kamerasec.Name = "kamerasec";
            this.kamerasec.Size = new System.Drawing.Size(121, 24);
            this.kamerasec.TabIndex = 3;
            // 
            // gonder
            // 
            this.gonder.BackColor = System.Drawing.Color.PeachPuff;
            this.gonder.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonder.Location = new System.Drawing.Point(195, 530);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(249, 39);
            this.gonder.TabIndex = 4;
            this.gonder.Text = "Arduıno\'ya gönder";
            this.gonder.UseVisualStyleBackColor = false;
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // ScrollBark
            // 
            this.ScrollBark.Location = new System.Drawing.Point(137, 586);
            this.ScrollBark.Maximum = 255;
            this.ScrollBark.Name = "ScrollBark";
            this.ScrollBark.Size = new System.Drawing.Size(271, 24);
            this.ScrollBark.TabIndex = 6;
            this.ScrollBark.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBark_Scroll);
            // 
            // ScrollBary
            // 
            this.ScrollBary.Location = new System.Drawing.Point(879, 590);
            this.ScrollBary.Maximum = 255;
            this.ScrollBary.Name = "ScrollBary";
            this.ScrollBary.Size = new System.Drawing.Size(271, 24);
            this.ScrollBary.TabIndex = 7;
            this.ScrollBary.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBary_Scroll);
            // 
            // ScrollBarm
            // 
            this.ScrollBarm.Location = new System.Drawing.Point(512, 590);
            this.ScrollBarm.Maximum = 255;
            this.ScrollBarm.Name = "ScrollBarm";
            this.ScrollBarm.Size = new System.Drawing.Size(271, 24);
            this.ScrollBarm.TabIndex = 8;
            this.ScrollBarm.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ScrollBarm_Scroll);
            // 
            // Takipet
            // 
            this.Takipet.BackColor = System.Drawing.Color.PeachPuff;
            this.Takipet.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Takipet.Location = new System.Drawing.Point(879, 530);
            this.Takipet.Name = "Takipet";
            this.Takipet.Size = new System.Drawing.Size(232, 39);
            this.Takipet.TabIndex = 9;
            this.Takipet.Text = "Nesneyi Takip Et";
            this.Takipet.UseVisualStyleBackColor = false;
            this.Takipet.Click += new System.EventHandler(this.Takipet_Click);
            // 
            // KırmızıButton
            // 
            this.KırmızıButton.AutoSize = true;
            this.KırmızıButton.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KırmızıButton.ForeColor = System.Drawing.Color.Red;
            this.KırmızıButton.Location = new System.Drawing.Point(222, 633);
            this.KırmızıButton.Name = "KırmızıButton";
            this.KırmızıButton.Size = new System.Drawing.Size(110, 32);
            this.KırmızıButton.TabIndex = 10;
            this.KırmızıButton.TabStop = true;
            this.KırmızıButton.Text = "Kırmızı";
            this.KırmızıButton.UseVisualStyleBackColor = true;
            this.KırmızıButton.CheckedChanged += new System.EventHandler(this.KırmızıButton_CheckedChanged);
            // 
            // YesilButton
            // 
            this.YesilButton.AutoSize = true;
            this.YesilButton.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YesilButton.ForeColor = System.Drawing.Color.Green;
            this.YesilButton.Location = new System.Drawing.Point(601, 633);
            this.YesilButton.Name = "YesilButton";
            this.YesilButton.Size = new System.Drawing.Size(73, 32);
            this.YesilButton.TabIndex = 11;
            this.YesilButton.TabStop = true;
            this.YesilButton.Text = "Yeşil";
            this.YesilButton.UseVisualStyleBackColor = true;
            this.YesilButton.CheckedChanged += new System.EventHandler(this.YesilButton_CheckedChanged);
            // 
            // MaviButton
            // 
            this.MaviButton.AutoSize = true;
            this.MaviButton.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaviButton.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.MaviButton.Location = new System.Drawing.Point(970, 633);
            this.MaviButton.Name = "MaviButton";
            this.MaviButton.Size = new System.Drawing.Size(78, 32);
            this.MaviButton.TabIndex = 12;
            this.MaviButton.TabStop = true;
            this.MaviButton.Text = "Mavi";
            this.MaviButton.UseVisualStyleBackColor = true;
            this.MaviButton.CheckedChanged += new System.EventHandler(this.MaviButton_CheckedChanged);
            // 
            // labelk
            // 
            this.labelk.AutoSize = true;
            this.labelk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelk.Location = new System.Drawing.Point(428, 590);
            this.labelk.Name = "labelk";
            this.labelk.Size = new System.Drawing.Size(19, 20);
            this.labelk.TabIndex = 13;
            this.labelk.Text = "0";
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labely.Location = new System.Drawing.Point(1162, 594);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(19, 20);
            this.labely.TabIndex = 14;
            this.labely.Text = "0";
            // 
            // labelm
            // 
            this.labelm.AutoSize = true;
            this.labelm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelm.Location = new System.Drawing.Point(798, 594);
            this.labelm.Name = "labelm";
            this.labelm.Size = new System.Drawing.Size(19, 20);
            this.labelm.TabIndex = 15;
            this.labelm.Text = "0";
            // 
            // serialPort
            // 
            this.serialPort.PortName = "COM4";
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kamera Sec";
            // 
            // esnakod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1309, 684);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelm);
            this.Controls.Add(this.labely);
            this.Controls.Add(this.labelk);
            this.Controls.Add(this.MaviButton);
            this.Controls.Add(this.YesilButton);
            this.Controls.Add(this.KırmızıButton);
            this.Controls.Add(this.Takipet);
            this.Controls.Add(this.ScrollBarm);
            this.Controls.Add(this.ScrollBary);
            this.Controls.Add(this.ScrollBark);
            this.Controls.Add(this.gonder);
            this.Controls.Add(this.kamerasec);
            this.Controls.Add(this.Basla);
            this.Controls.Add(this.islem);
            this.Controls.Add(this.kaynak);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "esnakod";
            this.Text = "Nesne ve Renk Takibi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.esnakod_FormClosing);
            this.Load += new System.EventHandler(this.esnakod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kaynak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kaynak;
        private System.Windows.Forms.PictureBox islem;
        private System.Windows.Forms.Button Basla;
        private System.Windows.Forms.ComboBox kamerasec;
        private System.Windows.Forms.Button gonder;
        private System.Windows.Forms.HScrollBar ScrollBark;
        private System.Windows.Forms.HScrollBar ScrollBary;
        private System.Windows.Forms.HScrollBar ScrollBarm;
        private System.Windows.Forms.Button Takipet;
        private System.Windows.Forms.RadioButton KırmızıButton;
        private System.Windows.Forms.RadioButton YesilButton;
        private System.Windows.Forms.RadioButton MaviButton;
        private System.Windows.Forms.Label labelk;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Label labelm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label1;
    }
}

