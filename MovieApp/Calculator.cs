namespace MovieApp
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
            seven = new Button();
            textBox1 = new TextBox();
            eight = new Button();
            nine = new Button();
            four = new Button();
            five = new Button();
            six = new Button();
            one = new Button();
            two = new Button();
            three = new Button();
            button10 = new Button();
            zero = new Button();
            button12 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // seven
            // 
            seven.Location = new Point(342, 166);
            seven.Name = "seven";
            seven.Size = new Size(61, 50);
            seven.TabIndex = 0;
            seven.UseVisualStyleBackColor = true;
            seven.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(342, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(233, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // eight
            // 
            eight.Location = new Point(429, 166);
            eight.Name = "eight";
            eight.Size = new Size(61, 50);
            eight.TabIndex = 2;
            eight.UseVisualStyleBackColor = true;
            eight.Click += this.button2_Click;
            // 
            // nine
            // 
            nine.Location = new Point(514, 166);
            nine.Name = "nine";
            nine.Size = new Size(61, 50);
            nine.TabIndex = 3;
            nine.UseVisualStyleBackColor = true;
            nine.Click += this.button3_Click;
            // 
            // four
            // 
            four.Location = new Point(342, 234);
            four.Name = "four";
            four.RightToLeft = RightToLeft.Yes;
            four.Size = new Size(61, 50);
            four.TabIndex = 4;
            four.Text = "4";
            four.UseVisualStyleBackColor = true;
            four.Click += this.button4_Click;
            // 
            // five
            // 
            five.Location = new Point(429, 234);
            five.Name = "five";
            five.Size = new Size(61, 50);
            five.TabIndex = 5;
            five.UseVisualStyleBackColor = true;
            five.Click += button5_Click;
            // 
            // six
            // 
            six.Location = new Point(514, 234);
            six.Name = "six";
            six.Size = new Size(61, 50);
            six.TabIndex = 6;
            six.UseVisualStyleBackColor = true;
            six.Click += this.button6_Click;
            // 
            // one
            // 
            one.Location = new Point(342, 310);
            one.Name = "one";
            one.Size = new Size(61, 50);
            one.TabIndex = 7;
            one.Text = "1";
            one.UseVisualStyleBackColor = true;
            // 
            // two
            // 
            two.Location = new Point(429, 310);
            two.Name = "two";
            two.Size = new Size(61, 50);
            two.TabIndex = 8;
            two.Text = "2";
            two.UseVisualStyleBackColor = true;
            // 
            // three
            // 
            three.Location = new Point(514, 310);
            three.Name = "three";
            three.Size = new Size(61, 50);
            three.TabIndex = 9;
            three.Text = "3";
            three.UseVisualStyleBackColor = true;
            three.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(342, 383);
            button10.Name = "button10";
            button10.Size = new Size(61, 50);
            button10.TabIndex = 10;
            button10.UseVisualStyleBackColor = true;
            // 
            // zero
            // 
            zero.Location = new Point(429, 383);
            zero.Name = "zero";
            zero.Size = new Size(61, 50);
            zero.TabIndex = 11;
            zero.Text = "0";
            zero.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Location = new Point(514, 383);
            button12.Name = "button12";
            button12.Size = new Size(61, 50);
            button12.TabIndex = 12;
            button12.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(419, 73);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 13;
            label1.Text = "Calculator";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 556);
            Controls.Add(label1);
            Controls.Add(button12);
            Controls.Add(zero);
            Controls.Add(button10);
            Controls.Add(three);
            Controls.Add(two);
            Controls.Add(one);
            Controls.Add(six);
            Controls.Add(five);
            Controls.Add(four);
            Controls.Add(nine);
            Controls.Add(eight);
            Controls.Add(textBox1);
            Controls.Add(seven);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button seven;
        private TextBox textBox1;
        private Button eight;
        private Button nine;
        private Button four;
        private Button five;
        private Button six;
        private Button one;
        private Button two;
        private Button three;
        private Button button10;
        private Button zero;
        private Button button12;
        private Label label1;
    }
}
