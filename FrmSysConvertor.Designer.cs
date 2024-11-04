namespace DZ4
{
    partial class FrmSysConvertor
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
            label4 = new Label();
            tb10 = new TextBox();
            tb2 = new TextBox();
            tb8 = new TextBox();
            tb16 = new TextBox();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 20);
            label1.TabIndex = 0;
            label1.Text = "Число в десятичной системе:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 125);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 1;
            label2.Text = "Двоичная система:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(172, 20);
            label3.TabIndex = 2;
            label3.Text = "Восьмеричная система";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 187);
            label4.Name = "label4";
            label4.Size = new Size(214, 20);
            label4.TabIndex = 3;
            label4.Text = "Шестнадцатеричная система:";
            // 
            // tb10
            // 
            tb10.Location = new Point(254, 6);
            tb10.Name = "tb10";
            tb10.Size = new Size(125, 27);
            tb10.TabIndex = 4;
            // 
            // tb2
            // 
            tb2.Location = new Point(254, 118);
            tb2.Name = "tb2";
            tb2.ReadOnly = true;
            tb2.Size = new Size(125, 27);
            tb2.TabIndex = 5;
            // 
            // tb8
            // 
            tb8.Location = new Point(254, 151);
            tb8.Name = "tb8";
            tb8.ReadOnly = true;
            tb8.Size = new Size(125, 27);
            tb8.TabIndex = 6;
            // 
            // tb16
            // 
            tb16.Location = new Point(254, 184);
            tb16.Name = "tb16";
            tb16.ReadOnly = true;
            tb16.Size = new Size(125, 27);
            tb16.TabIndex = 7;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(254, 39);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(125, 29);
            btnConvert.TabIndex = 8;
            btnConvert.Text = "Перевести";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // FrmSysConvertor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 217);
            Controls.Add(btnConvert);
            Controls.Add(tb16);
            Controls.Add(tb8);
            Controls.Add(tb2);
            Controls.Add(tb10);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmSysConvertor";
            Text = "Перевод в счситему счисления";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tb10;
        private TextBox tb2;
        private TextBox tb8;
        private TextBox tb16;
        private Button btnConvert;
    }
}
