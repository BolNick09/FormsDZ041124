namespace DZ4
{
    partial class FrmCrypro
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
            tbOrigText = new TextBox();
            label1 = new Label();
            tbCryptedText = new TextBox();
            label2 = new Label();
            btnCrypto = new Button();
            SuspendLayout();
            // 
            // tbOrigText
            // 
            tbOrigText.Location = new Point(12, 69);
            tbOrigText.Multiline = true;
            tbOrigText.Name = "tbOrigText";
            tbOrigText.Size = new Size(257, 245);
            tbOrigText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(169, 20);
            label1.TabIndex = 1;
            label1.Text = "Нешифрованный текст";
            // 
            // tbCryptedText
            // 
            tbCryptedText.Location = new Point(321, 69);
            tbCryptedText.Multiline = true;
            tbCryptedText.Name = "tbCryptedText";
            tbCryptedText.Size = new Size(257, 245);
            tbCryptedText.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 34);
            label2.Name = "label2";
            label2.Size = new Size(166, 20);
            label2.TabIndex = 3;
            label2.Text = "Зашифрованный текст";
            // 
            // btnCrypto
            // 
            btnCrypto.Location = new Point(152, 320);
            btnCrypto.Name = "btnCrypto";
            btnCrypto.Size = new Size(117, 29);
            btnCrypto.TabIndex = 4;
            btnCrypto.Text = "Зашифровать";
            btnCrypto.UseVisualStyleBackColor = true;
            btnCrypto.Click += btnCrypto_Click;
            // 
            // FrmCrypro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 361);
            Controls.Add(btnCrypto);
            Controls.Add(label2);
            Controls.Add(tbCryptedText);
            Controls.Add(label1);
            Controls.Add(tbOrigText);
            Name = "FrmCrypro";
            Text = "Шифровальщик";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbOrigText;
        private Label label1;
        private TextBox tbCryptedText;
        private Label label2;
        private Button btnCrypto;
    }
}