namespace QL_LOP.GUI
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
            txttenlop = new TextBox();
            txtmalop = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dgdanhsachlop = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgdanhsachlop).BeginInit();
            SuspendLayout();
            // 
            // txttenlop
            // 
            txttenlop.Location = new Point(293, 98);
            txttenlop.Name = "txttenlop";
            txttenlop.Size = new Size(299, 27);
            txttenlop.TabIndex = 0;
            // 
            // txtmalop
            // 
            txtmalop.Location = new Point(293, 37);
            txtmalop.Name = "txtmalop";
            txtmalop.Size = new Size(299, 27);
            txtmalop.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(178, 180);
            button1.Name = "button1";
            button1.Size = new Size(102, 69);
            button1.TabIndex = 1;
            button1.Text = "THEM";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(307, 180);
            button2.Name = "button2";
            button2.Size = new Size(102, 69);
            button2.TabIndex = 1;
            button2.Text = "XOA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(459, 180);
            button3.Name = "button3";
            button3.Size = new Size(102, 69);
            button3.TabIndex = 1;
            button3.Text = "CAP NHAT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(605, 180);
            button4.Name = "button4";
            button4.Size = new Size(102, 69);
            button4.TabIndex = 1;
            button4.Text = "THOAT";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dgdanhsachlop
            // 
            dgdanhsachlop.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgdanhsachlop.Location = new Point(178, 331);
            dgdanhsachlop.Name = "dgdanhsachlop";
            dgdanhsachlop.RowHeadersWidth = 51;
            dgdanhsachlop.Size = new Size(414, 188);
            dgdanhsachlop.TabIndex = 2;
            dgdanhsachlop.CellContentClick += dgdanhsachlop_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 664);
            Controls.Add(dgdanhsachlop);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtmalop);
            Controls.Add(txttenlop);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgdanhsachlop).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txttenlop;
        private TextBox txtmalop;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dgdanhsachlop;
    }
}