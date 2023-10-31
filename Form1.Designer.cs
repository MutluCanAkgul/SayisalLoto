namespace SayısalLoto
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
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(25, 49);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(119, 49);
            button2.Name = "button2";
            button2.Size = new Size(75, 75);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(215, 49);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(503, 49);
            button4.Name = "button4";
            button4.Size = new Size(75, 75);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(407, 49);
            button5.Name = "button5";
            button5.Size = new Size(75, 75);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(313, 49);
            button6.Name = "button6";
            button6.Size = new Size(75, 75);
            button6.TabIndex = 3;
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(25, 240);
            button7.Name = "button7";
            button7.Size = new Size(553, 75);
            button7.TabIndex = 6;
            button7.Text = "Şanşını Dene";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 363);
            Controls.Add(button7);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}