namespace Sten_Sax_Påse
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(75, 119);
            button1.Name = "button1";
            button1.Size = new Size(132, 34);
            button1.TabIndex = 0;
            button1.Text = "ROCK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(351, 119);
            button2.Name = "button2";
            button2.Size = new Size(132, 34);
            button2.TabIndex = 1;
            button2.Text = "SCISSORS";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.Crimson;
            button3.Location = new Point(213, 119);
            button3.Name = "button3";
            button3.Size = new Size(132, 34);
            button3.TabIndex = 2;
            button3.Text = "PAPER";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.Window;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Popup;
            button4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(213, 262);
            button4.Name = "button4";
            button4.Size = new Size(132, 74);
            button4.TabIndex = 3;
            button4.Text = "PLAY";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 233);
            label1.Name = "label1";
            label1.Size = new Size(0, 28);
            label1.TabIndex = 4;
            label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 258);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 5;
            label2.UseCompatibleTextRendering = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 283);
            label3.Name = "label3";
            label3.Size = new Size(0, 28);
            label3.TabIndex = 6;
            label3.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 308);
            label4.Name = "label4";
            label4.Size = new Size(0, 28);
            label4.TabIndex = 7;
            label4.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.the_drock;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(561, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Stone Maybe Paper Never Scissors";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
