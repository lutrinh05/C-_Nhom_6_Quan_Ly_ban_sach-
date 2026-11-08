namespace BAI_3
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
            this.lblSonguyen = new System.Windows.Forms.Label();
            this.txtSonguyen = new System.Windows.Forms.TextBox();
            this.lstKetqua = new System.Windows.Forms.ListBox();
            this.btCapnhat = new System.Windows.Forms.Button();
            this.btTang2 = new System.Windows.Forms.Button();
            this.btChonchandau = new System.Windows.Forms.Button();
            this.btLecuoi = new System.Windows.Forms.Button();
            this.btXoaptdangchon = new System.Windows.Forms.Button();
            this.btXoaptdau = new System.Windows.Forms.Button();
            this.btXoaptcuoi = new System.Windows.Forms.Button();
            this.btKetthuc = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSonguyen
            // 
            this.lblSonguyen.AutoSize = true;
            this.lblSonguyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonguyen.Location = new System.Drawing.Point(28, 39);
            this.lblSonguyen.Name = "lblSonguyen";
            this.lblSonguyen.Size = new System.Drawing.Size(134, 20);
            this.lblSonguyen.TabIndex = 0;
            this.lblSonguyen.Text = "Nhập số nguyên:";
            // 
            // txtSonguyen
            // 
            this.txtSonguyen.Location = new System.Drawing.Point(183, 26);
            this.txtSonguyen.Multiline = true;
            this.txtSonguyen.Name = "txtSonguyen";
            this.txtSonguyen.Size = new System.Drawing.Size(251, 48);
            this.txtSonguyen.TabIndex = 1;
            this.txtSonguyen.TextChanged += new System.EventHandler(this.txtSonguyen_TextChanged);
            // 
            // lstKetqua
            // 
            this.lstKetqua.FormattingEnabled = true;
            this.lstKetqua.ItemHeight = 16;
            this.lstKetqua.Location = new System.Drawing.Point(32, 114);
            this.lstKetqua.Name = "lstKetqua";
            this.lstKetqua.Size = new System.Drawing.Size(275, 308);
            this.lstKetqua.TabIndex = 2;
            this.lstKetqua.SelectedIndexChanged += new System.EventHandler(this.lstKetqua_SelectedIndexChanged);
            // 
            // btCapnhat
            // 
            this.btCapnhat.BackColor = System.Drawing.SystemColors.Info;
            this.btCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapnhat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCapnhat.Location = new System.Drawing.Point(470, 26);
            this.btCapnhat.Name = "btCapnhat";
            this.btCapnhat.Size = new System.Drawing.Size(148, 48);
            this.btCapnhat.TabIndex = 3;
            this.btCapnhat.Text = "Cập nhật";
            this.btCapnhat.UseVisualStyleBackColor = false;
            this.btCapnhat.Click += new System.EventHandler(this.btCapnhat_Click);
            // 
            // btTang2
            // 
            this.btTang2.BackColor = System.Drawing.SystemColors.Info;
            this.btTang2.Location = new System.Drawing.Point(20, 44);
            this.btTang2.Name = "btTang2";
            this.btTang2.Size = new System.Drawing.Size(267, 37);
            this.btTang2.TabIndex = 4;
            this.btTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btTang2.UseVisualStyleBackColor = false;
            this.btTang2.Click += new System.EventHandler(this.btTang2_Click);
            // 
            // btChonchandau
            // 
            this.btChonchandau.BackColor = System.Drawing.SystemColors.Info;
            this.btChonchandau.Location = new System.Drawing.Point(20, 87);
            this.btChonchandau.Name = "btChonchandau";
            this.btChonchandau.Size = new System.Drawing.Size(267, 37);
            this.btChonchandau.TabIndex = 5;
            this.btChonchandau.Text = "Chọn số chẵn đầu";
            this.btChonchandau.UseVisualStyleBackColor = false;
            this.btChonchandau.Click += new System.EventHandler(this.btChonchandau_Click);
            // 
            // btLecuoi
            // 
            this.btLecuoi.BackColor = System.Drawing.SystemColors.Info;
            this.btLecuoi.Location = new System.Drawing.Point(20, 130);
            this.btLecuoi.Name = "btLecuoi";
            this.btLecuoi.Size = new System.Drawing.Size(267, 37);
            this.btLecuoi.TabIndex = 6;
            this.btLecuoi.Text = "Chọn số lẻ cuối";
            this.btLecuoi.UseVisualStyleBackColor = false;
            this.btLecuoi.Click += new System.EventHandler(this.btLecuoi_Click);
            // 
            // btXoaptdangchon
            // 
            this.btXoaptdangchon.BackColor = System.Drawing.SystemColors.Info;
            this.btXoaptdangchon.Location = new System.Drawing.Point(20, 173);
            this.btXoaptdangchon.Name = "btXoaptdangchon";
            this.btXoaptdangchon.Size = new System.Drawing.Size(267, 37);
            this.btXoaptdangchon.TabIndex = 7;
            this.btXoaptdangchon.Text = "Xoá phần tử đang chọn";
            this.btXoaptdangchon.UseVisualStyleBackColor = false;
            this.btXoaptdangchon.Click += new System.EventHandler(this.btXoaptdangchon_Click);
            // 
            // btXoaptdau
            // 
            this.btXoaptdau.BackColor = System.Drawing.SystemColors.Info;
            this.btXoaptdau.Location = new System.Drawing.Point(20, 216);
            this.btXoaptdau.Name = "btXoaptdau";
            this.btXoaptdau.Size = new System.Drawing.Size(267, 37);
            this.btXoaptdau.TabIndex = 8;
            this.btXoaptdau.Text = "Xoá phần tử đầu";
            this.btXoaptdau.UseVisualStyleBackColor = false;
            this.btXoaptdau.Click += new System.EventHandler(this.btXoaptdau_Click);
            // 
            // btXoaptcuoi
            // 
            this.btXoaptcuoi.BackColor = System.Drawing.SystemColors.Info;
            this.btXoaptcuoi.Location = new System.Drawing.Point(20, 259);
            this.btXoaptcuoi.Name = "btXoaptcuoi";
            this.btXoaptcuoi.Size = new System.Drawing.Size(267, 37);
            this.btXoaptcuoi.TabIndex = 9;
            this.btXoaptcuoi.Text = "Xoá phần tử cuối";
            this.btXoaptcuoi.UseVisualStyleBackColor = false;
            this.btXoaptcuoi.Click += new System.EventHandler(this.btXoaptcuoi_Click);
            // 
            // btKetthuc
            // 
            this.btKetthuc.BackColor = System.Drawing.SystemColors.Info;
            this.btKetthuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btKetthuc.Location = new System.Drawing.Point(32, 439);
            this.btKetthuc.Name = "btKetthuc";
            this.btKetthuc.Size = new System.Drawing.Size(607, 29);
            this.btKetthuc.TabIndex = 10;
            this.btKetthuc.Text = "Kết thúc";
            this.btKetthuc.UseVisualStyleBackColor = false;
            this.btKetthuc.Click += new System.EventHandler(this.btKetthuc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btLecuoi);
            this.groupBox1.Controls.Add(this.btXoaptdangchon);
            this.groupBox1.Controls.Add(this.btChonchandau);
            this.groupBox1.Controls.Add(this.btXoaptcuoi);
            this.groupBox1.Controls.Add(this.btTang2);
            this.groupBox1.Controls.Add(this.btXoaptdau);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(331, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 319);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(674, 480);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btKetthuc);
            this.Controls.Add(this.btCapnhat);
            this.Controls.Add(this.lstKetqua);
            this.Controls.Add(this.txtSonguyen);
            this.Controls.Add(this.lblSonguyen);
            this.Name = "Form1";
            this.Text = "Thao tác số";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonguyen;
        private System.Windows.Forms.TextBox txtSonguyen;
        private System.Windows.Forms.ListBox lstKetqua;
        private System.Windows.Forms.Button btCapnhat;
        private System.Windows.Forms.Button btTang2;
        private System.Windows.Forms.Button btChonchandau;
        private System.Windows.Forms.Button btLecuoi;
        private System.Windows.Forms.Button btXoaptdangchon;
        private System.Windows.Forms.Button btXoaptdau;
        private System.Windows.Forms.Button btXoaptcuoi;
        private System.Windows.Forms.Button btKetthuc;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

