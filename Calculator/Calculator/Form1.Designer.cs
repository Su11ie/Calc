﻿namespace Calculator
{
    partial class Calc
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
            this.Calculator = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.TextBox();
            this.multiply = new System.Windows.Forms.Button();
            this.subract = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.Location = new System.Drawing.Point(137, 136);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(70, 59);
            this.Calculator.TabIndex = 0;
            this.Calculator.Text = "1";
            this.Calculator.UseVisualStyleBackColor = true;
            this.Calculator.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(213, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(289, 201);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(70, 59);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(213, 201);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 59);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(70, 59);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(289, 266);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(70, 59);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(213, 266);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(70, 59);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(137, 266);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 59);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(137, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 59);
            this.button1.TabIndex = 9;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(289, 331);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(70, 59);
            this.button10.TabIndex = 10;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button_click);
            // 
            // value
            // 
            this.value.AutoSize = true;
            this.value.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value.Location = new System.Drawing.Point(133, 64);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(0, 24);
            this.value.TabIndex = 11;
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.Location = new System.Drawing.Point(137, 101);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(381, 29);
            this.Result.TabIndex = 12;
            this.Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(365, 266);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(70, 59);
            this.multiply.TabIndex = 15;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.op_click);
            // 
            // subract
            // 
            this.subract.Location = new System.Drawing.Point(365, 201);
            this.subract.Name = "subract";
            this.subract.Size = new System.Drawing.Size(70, 59);
            this.subract.TabIndex = 14;
            this.subract.Text = "-";
            this.subract.UseVisualStyleBackColor = true;
            this.subract.Click += new System.EventHandler(this.op_click);
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(365, 136);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(70, 59);
            this.addition.TabIndex = 13;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = true;
            this.addition.Click += new System.EventHandler(this.op_click);
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(365, 331);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(70, 59);
            this.divide.TabIndex = 16;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.op_click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(441, 267);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(77, 123);
            this.clear.TabIndex = 17;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.reset);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 18;
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.subract);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.value);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Calculator);
            this.Name = "Calc";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calculator;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label value;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button subract;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
    }
}

