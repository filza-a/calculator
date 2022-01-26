
namespace WindowsFormsApp1
{
    partial class Calculator
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
            this.one = new System.Windows.Forms.Button();
            this.allClear = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.equals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.Location = new System.Drawing.Point(23, 54);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(29, 24);
            this.one.TabIndex = 0;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // allClear
            // 
            this.allClear.Location = new System.Drawing.Point(23, 176);
            this.allClear.Name = "allClear";
            this.allClear.Size = new System.Drawing.Size(99, 24);
            this.allClear.TabIndex = 1;
            this.allClear.Text = "AC";
            this.allClear.UseVisualStyleBackColor = true;
            this.allClear.Click += new System.EventHandler(this.allClear_Click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(130, 146);
            this.divide.Name = "divide";
            this.divide.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.divide.Size = new System.Drawing.Size(29, 24);
            this.divide.TabIndex = 2;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(93, 146);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(29, 24);
            this.clear.TabIndex = 3;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // zero
            // 
            this.zero.Location = new System.Drawing.Point(58, 146);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(29, 24);
            this.zero.TabIndex = 4;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // dot
            // 
            this.dot.Location = new System.Drawing.Point(23, 146);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(29, 24);
            this.dot.TabIndex = 5;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(130, 114);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(29, 24);
            this.multiply.TabIndex = 6;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // nine
            // 
            this.nine.Location = new System.Drawing.Point(93, 114);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(29, 24);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.Location = new System.Drawing.Point(58, 114);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(29, 24);
            this.eight.TabIndex = 8;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.Location = new System.Drawing.Point(23, 114);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(29, 24);
            this.seven.TabIndex = 9;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(128, 84);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(29, 24);
            this.minus.TabIndex = 10;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // six
            // 
            this.six.Location = new System.Drawing.Point(93, 84);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(29, 24);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Location = new System.Drawing.Point(58, 84);
            this.five.Name = "five";
            this.five.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.five.Size = new System.Drawing.Size(29, 24);
            this.five.TabIndex = 12;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Location = new System.Drawing.Point(23, 84);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(29, 24);
            this.four.TabIndex = 13;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(130, 54);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(29, 24);
            this.plus.TabIndex = 14;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // three
            // 
            this.three.Location = new System.Drawing.Point(93, 54);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(29, 24);
            this.three.TabIndex = 15;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(58, 54);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(29, 24);
            this.two.TabIndex = 16;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(23, 21);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(136, 20);
            this.textBox.TabIndex = 17;
            // 
            // equals
            // 
            this.equals.Location = new System.Drawing.Point(127, 176);
            this.equals.Name = "equals";
            this.equals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.equals.Size = new System.Drawing.Size(29, 24);
            this.equals.TabIndex = 18;
            this.equals.Text = "=";
            this.equals.UseVisualStyleBackColor = true;
            this.equals.Click += new System.EventHandler(this.equals_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 218);
            this.Controls.Add(this.equals);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.two);
            this.Controls.Add(this.three);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.allClear);
            this.Controls.Add(this.one);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button allClear;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button equals;
    }
}