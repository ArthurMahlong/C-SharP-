namespace _25._Intro_to_GUI
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
            textBox1 = new TextBox();
            btnSubmit = new Button();
            Surname = new Label();
            Age = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 42);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(248, 23);
            textBox1.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(230, 256);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 2;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnAge_Click;
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Location = new Point(49, 101);
            Surname.Name = "Surname";
            Surname.Size = new Size(54, 15);
            Surname.TabIndex = 3;
            Surname.Text = "Surname";
            // 
            // Age
            // 
            Age.AutoSize = true;
            Age.Location = new Point(49, 169);
            Age.Name = "Age";
            Age.Size = new Size(28, 15);
            Age.TabIndex = 4;
            Age.Text = "Age";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(248, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(183, 169);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(248, 23);
            textBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 240);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(Age);
            Controls.Add(Surname);
            Controls.Add(btnSubmit);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnSubmit;
        private Label Surname;
        private Label Age;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label2;
    }
}
