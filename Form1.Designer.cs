namespace лаба_10_з1
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
            Посчитать = new Button();
            a = new Label();
            b = new Label();
            x = new Label();
            r = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // Посчитать
            // 
            Посчитать.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Посчитать.Location = new Point(659, 400);
            Посчитать.Name = "Посчитать";
            Посчитать.Size = new Size(129, 38);
            Посчитать.TabIndex = 0;
            Посчитать.Text = "Посчитать";
            Посчитать.UseVisualStyleBackColor = true;
            Посчитать.Click += button1_Click;
            // 
            // a
            // 
            a.AutoSize = true;
            a.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            a.Location = new Point(223, 58);
            a.Name = "a";
            a.Size = new Size(97, 25);
            a.TabIndex = 1;
            a.Text = "Введите a";
            // 
            // b
            // 
            b.AutoSize = true;
            b.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            b.Location = new Point(222, 110);
            b.Name = "b";
            b.Size = new Size(98, 25);
            b.TabIndex = 2;
            b.Text = "Введите b";
            // 
            // x
            // 
            x.AutoSize = true;
            x.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            x.Location = new Point(88, 163);
            x.Name = "x";
            x.Size = new Size(232, 25);
            x.TabIndex = 3;
            x.Text = "Введите угол между a и b";
            // 
            // r
            // 
            r.AutoSize = true;
            r.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            r.Location = new Point(170, 290);
            r.Name = "r";
            r.Size = new Size(150, 25);
            r.TabIndex = 4;
            r.Text = "Площадь равна";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(358, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 33);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(358, 102);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 33);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(358, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 33);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(358, 282);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 33);
            textBox4.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(r);
            Controls.Add(x);
            Controls.Add(b);
            Controls.Add(a);
            Controls.Add(Посчитать);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Посчитать;
        private Label a;
        private Label b;
        private Label x;
        private Label r;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
    }
}
