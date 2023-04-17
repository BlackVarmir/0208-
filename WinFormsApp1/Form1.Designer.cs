namespace WinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(51, 219);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 0;
            button1.Text = "Зашифрувати";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(171, 219);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 1;
            button2.Text = "Розшифрувати";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(384, 117);
            label1.Name = "label1";
            label1.Size = new Size(238, 15);
            label1.TabIndex = 2;
            label1.Text = "Тут буде зашифрований/розшифрований";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 117);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введіть суда слово";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 171);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Введіть розмір суву";
            textBox2.Size = new Size(224, 23);
            textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}