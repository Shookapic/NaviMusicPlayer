namespace MyApp
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(283, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(329, 193);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.Transparent;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(203, 301);
            button1.Name = "button1";
            button1.Size = new Size(112, 116);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += PreviousButton;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(372, 301);
            button2.Name = "button2";
            button2.Size = new Size(113, 116);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += PauseButton;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(543, 301);
            button3.Name = "button3";
            button3.Size = new Size(105, 116);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += NextButton;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.White;
            checkBox1.Location = new Point(701, 393);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(65, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Loop";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += LoopButton;
            // 
            // button4
            // 
            button4.Location = new Point(36, 28);
            button4.Name = "button4";
            button4.Size = new Size(159, 212);
            button4.TabIndex = 5;
            button4.Text = "Choose your song !";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlaylistButton;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(858, 509);
            Controls.Add(button4);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Navi Music Player";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
        private Button button4;
    }
}