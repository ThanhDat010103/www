namespace BaiToankt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt1 = new TextBox();
            txt2 = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(219, 19);
            label1.Name = "label1";
            label1.Size = new Size(168, 20);
            label1.TabIndex = 0;
            label1.Text = "THỰC HIỆN PHÉP TOÁN";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 64);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 0;
            label2.Text = "Số thứ 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(81, 144);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 0;
            label3.Text = "Số thứ 2:";
            // 
            // txt1
            // 
            txt1.Location = new Point(197, 64);
            txt1.Name = "txt1";
            txt1.Size = new Size(182, 27);
            txt1.TabIndex = 1;
            // 
            // txt2
            // 
            txt2.Location = new Point(197, 144);
            txt2.Name = "txt2";
            txt2.Size = new Size(182, 27);
            txt2.TabIndex = 1;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(81, 222);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(103, 57);
            btnCong.TabIndex = 2;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(276, 222);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(103, 57);
            btnTru.TabIndex = 2;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(81, 310);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(103, 57);
            btnNhan.TabIndex = 2;
            btnNhan.Text = "x";
            btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(276, 310);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(103, 57);
            btnChia.TabIndex = 2;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(602, 450);
            Controls.Add(btnChia);
            Controls.Add(btnNhan);
            Controls.Add(btnTru);
            Controls.Add(btnCong);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt1;
        private TextBox txt2;
        private Button btnCong;
        private Button btnTru;
        private Button btnNhan;
        private Button btnChia;
    }
}