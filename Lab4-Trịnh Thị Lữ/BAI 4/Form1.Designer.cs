namespace BAI_4
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
            this.lbds = new System.Windows.Forms.Label();
            this.lbHoten = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.btCapnhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstBandau = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.btTraisangphai = new System.Windows.Forms.Button();
            this.btPhaisangtrai = new System.Windows.Forms.Button();
            this.btTatcatraisangphai = new System.Windows.Forms.Button();
            this.btTatcaphaisangtrai = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btKetthuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbds
            // 
            this.lbds.AutoSize = true;
            this.lbds.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbds.Location = new System.Drawing.Point(207, 9);
            this.lbds.Name = "lbds";
            this.lbds.Size = new System.Drawing.Size(330, 40);
            this.lbds.TabIndex = 0;
            this.lbds.Text = "DANH SÁCH SINH VIÊN";
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoten.Location = new System.Drawing.Point(61, 83);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(86, 20);
            this.lbHoten.TabIndex = 1;
            this.lbHoten.Text = "Họ và tên:";
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(183, 63);
            this.txtHoten.Multiline = true;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(331, 40);
            this.txtHoten.TabIndex = 2;
            this.txtHoten.TextChanged += new System.EventHandler(this.txtHoten_TextChanged);
            // 
            // btCapnhat
            // 
            this.btCapnhat.BackColor = System.Drawing.Color.PapayaWhip;
            this.btCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapnhat.Location = new System.Drawing.Point(579, 63);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(100, 40);
            this.btCapnhat.TabIndex = 3;
            this.btCapnhat.Text = "Cập nhật";
            this.btCapnhat.UseVisualStyleBackColor = false;
            this.btCapnhat.Click += new System.EventHandler(this.btCapnhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstBandau);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 305);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A:";
            // 
            // lstBandau
            // 
            this.lstBandau.FormattingEnabled = true;
            this.lstBandau.ItemHeight = 20;
            this.lstBandau.Location = new System.Drawing.Point(17, 24);
            this.lstBandau.Name = "lstBandau";
            this.lstBandau.Size = new System.Drawing.Size(248, 264);
            this.lstBandau.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstKetqua);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(439, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 305);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B:";
            // 
            // lstKetqua
            // 
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.ItemHeight = 20;
            this.lstKetqua.Location = new System.Drawing.Point(18, 26);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(250, 264);
            this.lstKetqua.TabIndex = 0;
            // 
            // btTraisangphai
            // 
            this.btTraisangphai.BackColor = System.Drawing.Color.PapayaWhip;
            this.btTraisangphai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraisangphai.Location = new System.Drawing.Point(325, 174);
            this.btTraisangphai.Name = "btTraisangphai";
            this.btTraisangphai.Size = new System.Drawing.Size(46, 34);
            this.btTraisangphai.TabIndex = 6;
            this.btTraisangphai.Text = ">";
            this.btTraisangphai.UseVisualStyleBackColor = false;
            this.btTraisangphai.Click += new System.EventHandler(this.btTraisangphai_Click);
            // 
            // btPhaisangtrai
            // 
            this.btPhaisangtrai.BackColor = System.Drawing.Color.PapayaWhip;
            this.btPhaisangtrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPhaisangtrai.Location = new System.Drawing.Point(387, 174);
            this.btPhaisangtrai.Name = "btPhaisangtrai";
            this.btPhaisangtrai.Size = new System.Drawing.Size(46, 34);
            this.btPhaisangtrai.TabIndex = 7;
            this.btPhaisangtrai.Text = "<";
            this.btPhaisangtrai.UseVisualStyleBackColor = false;
            this.btPhaisangtrai.Click += new System.EventHandler(this.btPhaisangtrai_Click);
            // 
            // btTatcatraisangphai
            // 
            this.btTatcatraisangphai.BackColor = System.Drawing.Color.PapayaWhip;
            this.btTatcatraisangphai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTatcatraisangphai.Location = new System.Drawing.Point(325, 244);
            this.btTatcatraisangphai.Name = "btTatcatraisangphai";
            this.btTatcatraisangphai.Size = new System.Drawing.Size(47, 34);
            this.btTatcatraisangphai.TabIndex = 1;
            this.btTatcatraisangphai.Text = ">>";
            this.btTatcatraisangphai.UseVisualStyleBackColor = false;
            this.btTatcatraisangphai.Click += new System.EventHandler(this.btTatcatraisangphai_Click);
            // 
            // btTatcaphaisangtrai
            // 
            this.btTatcaphaisangtrai.BackColor = System.Drawing.Color.PapayaWhip;
            this.btTatcaphaisangtrai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTatcaphaisangtrai.Location = new System.Drawing.Point(387, 244);
            this.btTatcaphaisangtrai.Name = "btTatcaphaisangtrai";
            this.btTatcaphaisangtrai.Size = new System.Drawing.Size(46, 34);
            this.btTatcaphaisangtrai.TabIndex = 8;
            this.btTatcaphaisangtrai.Text = "<<";
            this.btTatcaphaisangtrai.UseVisualStyleBackColor = false;
            this.btTatcaphaisangtrai.Click += new System.EventHandler(this.btTatcaphaisangtrai_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.PapayaWhip;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Location = new System.Drawing.Point(123, 458);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(104, 33);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btKetthuc
            // 
            this.btKetthuc.BackColor = System.Drawing.Color.PapayaWhip;
            this.btKetthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKetthuc.Location = new System.Drawing.Point(539, 458);
            this.btKetthuc.Name = "btKetthuc";
            this.btKetthuc.Size = new System.Drawing.Size(104, 33);
            this.btKetthuc.TabIndex = 10;
            this.btKetthuc.Text = "Kết thúc";
            this.btKetthuc.UseVisualStyleBackColor = false;
            this.btKetthuc.Click += new System.EventHandler(this.btKetthuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(756, 510);
            this.Controls.Add(this.btKetthuc);
            this.Controls.Add(this.btTatcaphaisangtrai);
            this.Controls.Add(this.btPhaisangtrai);
            this.Controls.Add(this.btTatcatraisangphai);
            this.Controls.Add(this.btTraisangphai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCapnhat);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.lbHoten);
            this.Controls.Add(this.lbds);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbds;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btCapnhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstBandau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.Button btTraisangphai;
        private System.Windows.Forms.Button btPhaisangtrai;
        private System.Windows.Forms.Button btTatcatraisangphai;
        private System.Windows.Forms.Button btTatcaphaisangtrai;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btKetthuc;
    }
}

