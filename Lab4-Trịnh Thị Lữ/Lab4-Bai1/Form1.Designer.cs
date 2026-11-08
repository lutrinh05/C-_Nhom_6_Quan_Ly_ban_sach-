namespace Lab4_Bai1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.chkClean = new System.Windows.Forms.CheckBox();
            this.chkWhitening = new System.Windows.Forms.CheckBox();
            this.chkXRay = new System.Windows.Forms.CheckBox();
            this.lblCleanCost = new System.Windows.Forms.Label();
            this.lblWhiteningCost = new System.Windows.Forms.Label();
            this.lblXRayCost = new System.Windows.Forms.Label();
            this.lblFilling = new System.Windows.Forms.Label();
            this.numFilling = new System.Windows.Forms.NumericUpDown();
            this.lblFillCost = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lBox1 = new System.Windows.Forms.ListBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnTuychon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Blue;
            this.lblTitle.Location = new System.Drawing.Point(163, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 35);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DENTAL PAYMENT FORM";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(63, 81);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(127, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên khách hàng";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Red;
            this.txtName.Location = new System.Drawing.Point(221, 71);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(327, 30);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // chkClean
            // 
            this.chkClean.AutoSize = true;
            this.chkClean.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkClean.Location = new System.Drawing.Point(67, 145);
            this.chkClean.Name = "chkClean";
            this.chkClean.Size = new System.Drawing.Size(87, 24);
            this.chkClean.TabIndex = 3;
            this.chkClean.Text = "Cạo vôi";
            this.chkClean.UseVisualStyleBackColor = true;
            // 
            // chkWhitening
            // 
            this.chkWhitening.AutoSize = true;
            this.chkWhitening.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWhitening.Location = new System.Drawing.Point(67, 190);
            this.chkWhitening.Name = "chkWhitening";
            this.chkWhitening.Size = new System.Drawing.Size(101, 24);
            this.chkWhitening.TabIndex = 4;
            this.chkWhitening.Text = "Tẩy trắng";
            this.chkWhitening.UseVisualStyleBackColor = true;
            // 
            // chkXRay
            // 
            this.chkXRay.AutoSize = true;
            this.chkXRay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkXRay.Location = new System.Drawing.Point(67, 240);
            this.chkXRay.Name = "chkXRay";
            this.chkXRay.Size = new System.Drawing.Size(144, 24);
            this.chkXRay.TabIndex = 5;
            this.chkXRay.Text = "Chụp hình răng";
            this.chkXRay.UseVisualStyleBackColor = true;
            // 
            // lblCleanCost
            // 
            this.lblCleanCost.AutoSize = true;
            this.lblCleanCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCleanCost.Location = new System.Drawing.Point(420, 146);
            this.lblCleanCost.Name = "lblCleanCost";
            this.lblCleanCost.Size = new System.Drawing.Size(76, 20);
            this.lblCleanCost.TabIndex = 6;
            this.lblCleanCost.Text = "$100.000";
            // 
            // lblWhiteningCost
            // 
            this.lblWhiteningCost.AutoSize = true;
            this.lblWhiteningCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhiteningCost.Location = new System.Drawing.Point(420, 194);
            this.lblWhiteningCost.Name = "lblWhiteningCost";
            this.lblWhiteningCost.Size = new System.Drawing.Size(89, 20);
            this.lblWhiteningCost.TabIndex = 7;
            this.lblWhiteningCost.Text = "$1.200.000";
            // 
            // lblXRayCost
            // 
            this.lblXRayCost.AutoSize = true;
            this.lblXRayCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXRayCost.Location = new System.Drawing.Point(420, 244);
            this.lblXRayCost.Name = "lblXRayCost";
            this.lblXRayCost.Size = new System.Drawing.Size(76, 20);
            this.lblXRayCost.TabIndex = 8;
            this.lblXRayCost.Text = "$200.000";
            // 
            // lblFilling
            // 
            this.lblFilling.AutoSize = true;
            this.lblFilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilling.Location = new System.Drawing.Point(63, 295);
            this.lblFilling.Name = "lblFilling";
            this.lblFilling.Size = new System.Drawing.Size(86, 20);
            this.lblFilling.TabIndex = 9;
            this.lblFilling.Text = "Trám răng";
            // 
            // numFilling
            // 
            this.numFilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numFilling.Location = new System.Drawing.Point(221, 295);
            this.numFilling.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numFilling.Name = "numFilling";
            this.numFilling.Size = new System.Drawing.Size(92, 27);
            this.numFilling.TabIndex = 10;
            // 
            // lblFillCost
            // 
            this.lblFillCost.AutoSize = true;
            this.lblFillCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFillCost.Location = new System.Drawing.Point(420, 295);
            this.lblFillCost.Name = "lblFillCost";
            this.lblFillCost.Size = new System.Drawing.Size(94, 20);
            this.lblFillCost.TabIndex = 11;
            this.lblFillCost.Text = "$80.000/cái";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(198, 363);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(46, 20);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Red;
            this.txtTotal.Location = new System.Drawing.Point(307, 353);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ShortcutsEnabled = false;
            this.txtTotal.Size = new System.Drawing.Size(207, 30);
            this.txtTotal.TabIndex = 13;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(23, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(89, 39);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(483, 417);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(98, 39);
            this.btnCalc.TabIndex = 15;
            this.btnCalc.Text = "Tính tiền";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lBox1
            // 
            this.lBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBox1.FormattingEnabled = true;
            this.lBox1.ItemHeight = 20;
            this.lBox1.Location = new System.Drawing.Point(23, 478);
            this.lBox1.MultiColumn = true;
            this.lBox1.Name = "lBox1";
            this.lBox1.Size = new System.Drawing.Size(558, 164);
            this.lBox1.TabIndex = 16;
            this.lBox1.SelectedIndexChanged += new System.EventHandler(this.lBox1_SelectedIndexChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(133, 417);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 39);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnDoc
            // 
            this.btnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoc.Location = new System.Drawing.Point(244, 417);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(89, 39);
            this.btnDoc.TabIndex = 18;
            this.btnDoc.Text = "Đọc file";
            this.btnDoc.UseVisualStyleBackColor = true;
            // 
            // btnTuychon
            // 
            this.btnTuychon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuychon.Location = new System.Drawing.Point(356, 417);
            this.btnTuychon.Name = "btnTuychon";
            this.btnTuychon.Size = new System.Drawing.Size(101, 39);
            this.btnTuychon.TabIndex = 19;
            this.btnTuychon.Text = "Tuỳ chọn";
            this.btnTuychon.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 664);
            this.Controls.Add(this.btnTuychon);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lBox1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFillCost);
            this.Controls.Add(this.numFilling);
            this.Controls.Add(this.lblFilling);
            this.Controls.Add(this.lblXRayCost);
            this.Controls.Add(this.lblWhiteningCost);
            this.Controls.Add(this.lblCleanCost);
            this.Controls.Add(this.chkXRay);
            this.Controls.Add(this.chkWhitening);
            this.Controls.Add(this.chkClean);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Dental Payment Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFilling)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox chkClean;
        private System.Windows.Forms.CheckBox chkWhitening;
        private System.Windows.Forms.CheckBox chkXRay;
        private System.Windows.Forms.Label lblCleanCost;
        private System.Windows.Forms.Label lblWhiteningCost;
        private System.Windows.Forms.Label lblXRayCost;
        private System.Windows.Forms.Label lblFilling;
        private System.Windows.Forms.NumericUpDown numFilling;
        private System.Windows.Forms.Label lblFillCost;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.ListBox lBox1;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnTuychon;
    }
}

