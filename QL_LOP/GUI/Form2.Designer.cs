﻿namespace QL_LOP.GUI
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
            tbmasv = new TextBox();
            tbhoten = new TextBox();
            tbnoisinh = new TextBox();
            dtngaysinh = new DateTimePicker();
            cblophoc = new ComboBox();
            rdnam = new RadioButton();
            rdnu = new RadioButton();
            btthem = new Button();
            btghi = new Button();
            btxoa = new Button();
            btcapnhat = new Button();
            btthoat = new Button();
            dgdanhsachsinhvien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgdanhsachsinhvien).BeginInit();
            SuspendLayout();
            // 
            // tbmasv
            // 
            tbmasv.Location = new Point(147, 62);
            tbmasv.Name = "tbmasv";
            tbmasv.ReadOnly = true;
            tbmasv.Size = new Size(270, 27);
            tbmasv.TabIndex = 0;
            // 
            // tbhoten
            // 
            tbhoten.Location = new Point(147, 129);
            tbhoten.Name = "tbhoten";
            tbhoten.Size = new Size(270, 27);
            tbhoten.TabIndex = 0;
            // 
            // tbnoisinh
            // 
            tbnoisinh.Location = new Point(730, 129);
            tbnoisinh.Name = "tbnoisinh";
            tbnoisinh.Size = new Size(229, 27);
            tbnoisinh.TabIndex = 0;
            // 
            // dtngaysinh
            // 
            dtngaysinh.Location = new Point(730, 62);
            dtngaysinh.Name = "dtngaysinh";
            dtngaysinh.Size = new Size(229, 27);
            dtngaysinh.TabIndex = 1;
            // 
            // cblophoc
            // 
            cblophoc.FormattingEnabled = true;
            cblophoc.Location = new Point(730, 200);
            cblophoc.Name = "cblophoc";
            cblophoc.Size = new Size(229, 28);
            cblophoc.TabIndex = 2;
            // 
            // rdnam
            // 
            rdnam.AutoSize = true;
            rdnam.Location = new Point(147, 204);
            rdnam.Name = "rdnam";
            rdnam.Size = new Size(62, 24);
            rdnam.TabIndex = 3;
            rdnam.TabStop = true;
            rdnam.Text = "Nam";
            rdnam.UseVisualStyleBackColor = true;
            // 
            // rdnu
            // 
            rdnu.AutoSize = true;
            rdnu.Location = new Point(300, 204);
            rdnu.Name = "rdnu";
            rdnu.Size = new Size(50, 24);
            rdnu.TabIndex = 3;
            rdnu.TabStop = true;
            rdnu.Text = "Nữ";
            rdnu.UseVisualStyleBackColor = true;
            // 
            // btthem
            // 
            btthem.Location = new Point(147, 266);
            btthem.Name = "btthem";
            btthem.Size = new Size(108, 55);
            btthem.TabIndex = 4;
            btthem.Text = "THEM";
            btthem.UseVisualStyleBackColor = true;
            btthem.Click += btthem_Click;
            // 
            // btghi
            // 
            btghi.Location = new Point(322, 266);
            btghi.Name = "btghi";
            btghi.Size = new Size(108, 55);
            btghi.TabIndex = 4;
            btghi.Text = "GHI";
            btghi.UseVisualStyleBackColor = true;
            btghi.Click += btghi_Click;
            // 
            // btxoa
            // 
            btxoa.Location = new Point(500, 266);
            btxoa.Name = "btxoa";
            btxoa.Size = new Size(108, 55);
            btxoa.TabIndex = 4;
            btxoa.Text = "XOA";
            btxoa.UseVisualStyleBackColor = true;
            btxoa.Click += btxoa_Click;
            // 
            // btcapnhat
            // 
            btcapnhat.Location = new Point(690, 266);
            btcapnhat.Name = "btcapnhat";
            btcapnhat.Size = new Size(108, 55);
            btcapnhat.TabIndex = 4;
            btcapnhat.Text = "CAP NHAT";
            btcapnhat.UseVisualStyleBackColor = true;
            btcapnhat.Click += btcapnhat_Click;
            // 
            // btthoat
            // 
            btthoat.Location = new Point(869, 266);
            btthoat.Name = "btthoat";
            btthoat.Size = new Size(108, 55);
            btthoat.TabIndex = 4;
            btthoat.Text = "THOAT";
            btthoat.UseVisualStyleBackColor = true;
            btthoat.Click += btthoat_Click;
            // 
            // dgdanhsachsinhvien
            // 
            dgdanhsachsinhvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdanhsachsinhvien.Location = new Point(147, 361);
            dgdanhsachsinhvien.Name = "dgdanhsachsinhvien";
            dgdanhsachsinhvien.RowHeadersWidth = 51;
            dgdanhsachsinhvien.Size = new Size(812, 233);
            dgdanhsachsinhvien.TabIndex = 5;
            dgdanhsachsinhvien.CellContentClick += dgdanhsachsinhvien_CellContentClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 606);
            Controls.Add(dgdanhsachsinhvien);
            Controls.Add(btthoat);
            Controls.Add(btcapnhat);
            Controls.Add(btxoa);
            Controls.Add(btghi);
            Controls.Add(btthem);
            Controls.Add(rdnu);
            Controls.Add(rdnam);
            Controls.Add(cblophoc);
            Controls.Add(dtngaysinh);
            Controls.Add(tbnoisinh);
            Controls.Add(tbhoten);
            Controls.Add(tbmasv);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgdanhsachsinhvien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbmasv;
        private TextBox tbhoten;
        private TextBox tbnoisinh;
        private DateTimePicker dtngaysinh;
        private ComboBox cblophoc;
        private RadioButton rdnam;
        private RadioButton rdnu;
        private Button btthem;
        private Button btghi;
        private Button btxoa;
        private Button btcapnhat;
        private Button btthoat;
        private DataGridView dgdanhsachsinhvien;
    }
}