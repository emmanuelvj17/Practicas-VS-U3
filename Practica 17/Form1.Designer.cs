namespace Practica_17
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 22);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(237, 129);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 22);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(402, 129);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 22);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(77, 326);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 22);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(237, 326);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 22);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(402, 326);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(114, 22);
            textBox6.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(146, 63);
            label1.Name = "label1";
            label1.Size = new Size(300, 19);
            label1.TabIndex = 6;
            label1.Text = "Ordenar 3 numeros de mayor a menor.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(120, 173);
            label2.Name = "label2";
            label2.Size = new Size(20, 19);
            label2.TabIndex = 7;
            label2.Text = "A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(286, 173);
            label3.Name = "label3";
            label3.Size = new Size(21, 19);
            label3.TabIndex = 8;
            label3.Text = "B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(437, 173);
            label4.Name = "label4";
            label4.Size = new Size(21, 19);
            label4.TabIndex = 9;
            label4.Text = "C";
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(77, 233);
            button1.Name = "button1";
            button1.Size = new Size(114, 37);
            button1.TabIndex = 10;
            button1.Text = "Ordenar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(237, 233);
            button2.Name = "button2";
            button2.Size = new Size(114, 37);
            button2.TabIndex = 11;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(402, 233);
            button3.Name = "button3";
            button3.Size = new Size(114, 37);
            button3.TabIndex = 12;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(609, 447);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Ordenar de mayor a menor.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}