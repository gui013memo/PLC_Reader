namespace EngineNum_match_validator
{
    partial class Main_form
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
            label1 = new Label();
            button4 = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.AppWorkspace;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Cross;
            button1.FlatAppearance.BorderColor = Color.LightCoral;
            button1.FlatAppearance.BorderSize = 3;
            button1.FlatAppearance.MouseDownBackColor = Color.Cyan;
            button1.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(15, 735);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(240, 129);
            button1.TabIndex = 0;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.AppWorkspace;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Cursor = Cursors.Cross;
            button2.FlatAppearance.BorderColor = Color.LightCoral;
            button2.FlatAppearance.BorderSize = 3;
            button2.FlatAppearance.MouseDownBackColor = Color.Cyan;
            button2.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(15, 170);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(240, 128);
            button2.TabIndex = 1;
            button2.Text = "Connect PLC";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.AppWorkspace;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Cross;
            button3.FlatAppearance.BorderColor = Color.LightCoral;
            button3.FlatAppearance.BorderSize = 3;
            button3.FlatAppearance.MouseDownBackColor = Color.Cyan;
            button3.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(15, 362);
            button3.Margin = new Padding(4, 5, 4, 5);
            button3.Name = "button3";
            button3.Size = new Size(240, 128);
            button3.TabIndex = 2;
            button3.Text = "Disconnect PLC";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(95, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 54);
            label1.TabIndex = 3;
            label1.Text = "CON";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Cursor = Cursors.Cross;
            button4.FlatAppearance.BorderColor = Color.LightCoral;
            button4.FlatAppearance.BorderSize = 3;
            button4.FlatAppearance.MouseDownBackColor = Color.Cyan;
            button4.FlatAppearance.MouseOverBackColor = Color.MediumSeaGreen;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ActiveCaptionText;
            button4.Location = new Point(60, 550);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(149, 120);
            button4.TabIndex = 4;
            button4.Text = "READ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(305, 95);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(674, 756);
            textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1005, 880);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Button button4;
        private TextBox textBox1;
    }
}