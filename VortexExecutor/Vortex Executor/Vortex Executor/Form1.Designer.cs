namespace Vortex_Executor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Indigo;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(12, 408);
            button2.Name = "button2";
            button2.Size = new Size(37, 37);
            button2.TabIndex = 0;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(21, 21, 21);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 390);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "loadstring(game:HttpGet(\"https://pastebin.com/raw/4nf3G0AP\"))()";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Indigo;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(55, 408);
            button1.Name = "button1";
            button1.Size = new Size(37, 37);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Indigo;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(751, 408);
            button3.Name = "button3";
            button3.Size = new Size(37, 37);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 24);
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Vortex - Early Access";
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button3;
    }
}
