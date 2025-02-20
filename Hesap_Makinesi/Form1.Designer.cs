namespace Hesap_Makinesi
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
            groupBox1 = new GroupBox();
            ComboBox = new ComboBox();
            Number1MaskedTextBox = new MaskedTextBox();
            Number2MaskedTextBox = new MaskedTextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ComboBox);
            groupBox1.Location = new Point(12, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 59);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öperatör";
            // 
            // ComboBox
            // 
            ComboBox.FormattingEnabled = true;
            ComboBox.Items.AddRange(new object[] { "+", "-", "/", "*" });
            ComboBox.Location = new Point(6, 22);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(334, 23);
            ComboBox.TabIndex = 0;
            // 
            // Number1MaskedTextBox
            // 
            Number1MaskedTextBox.Location = new Point(18, 12);
            Number1MaskedTextBox.Mask = "00000000";
            Number1MaskedTextBox.Name = "Number1MaskedTextBox";
            Number1MaskedTextBox.Size = new Size(334, 23);
            Number1MaskedTextBox.TabIndex = 3;
            Number1MaskedTextBox.ValidatingType = typeof(int);
            // 
            // Number2MaskedTextBox
            // 
            Number2MaskedTextBox.Location = new Point(18, 41);
            Number2MaskedTextBox.Mask = "00000000";
            Number2MaskedTextBox.Name = "Number2MaskedTextBox";
            Number2MaskedTextBox.Size = new Size(334, 23);
            Number2MaskedTextBox.TabIndex = 3;
            Number2MaskedTextBox.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(104, 144);
            button1.Name = "button1";
            button1.Size = new Size(176, 31);
            button1.TabIndex = 4;
            button1.Text = "İşlem Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 181);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(346, 124);
            listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(370, 309);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(Number2MaskedTextBox);
            Controls.Add(Number1MaskedTextBox);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hesap Makinesi";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private GroupBox groupBox1;
        private ComboBox ComboBox;
        private MaskedTextBox Number1MaskedTextBox;
        private MaskedTextBox Number2MaskedTextBox;
        private Button button1;
        private ListBox listBox1;
    }
}
