namespace adatbázis_UI
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
            panel1 = new Panel();
            button_UserControl2 = new Button();
            button_UserControl1 = new Button();
            button_UserControl3 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(155, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(646, 450);
            panel1.TabIndex = 0;
            // 
            // button_UserControl2
            // 
            button_UserControl2.BackColor = SystemColors.ControlLight;
            button_UserControl2.Location = new Point(8, 115);
            button_UserControl2.Name = "button_UserControl2";
            button_UserControl2.Size = new Size(141, 97);
            button_UserControl2.TabIndex = 2;
            button_UserControl2.Text = "UserControl2";
            button_UserControl2.UseVisualStyleBackColor = false;
            button_UserControl2.Click += button_UserControl2_Click;
            // 
            // button_UserControl1
            // 
            button_UserControl1.Location = new Point(8, 12);
            button_UserControl1.Name = "button_UserControl1";
            button_UserControl1.Size = new Size(141, 97);
            button_UserControl1.TabIndex = 1;
            button_UserControl1.Text = "UserControl1";
            button_UserControl1.UseVisualStyleBackColor = true;
            button_UserControl1.Click += button_UserControl1_Click;
            // 
            // button_UserControl3
            // 
            button_UserControl3.BackColor = SystemColors.ControlLight;
            button_UserControl3.Location = new Point(8, 218);
            button_UserControl3.Name = "button_UserControl3";
            button_UserControl3.Size = new Size(141, 97);
            button_UserControl3.TabIndex = 3;
            button_UserControl3.Text = "UserControl3";
            button_UserControl3.UseVisualStyleBackColor = false;
            button_UserControl3.Click += button_UserControl3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_UserControl3);
            Controls.Add(button_UserControl2);
            Controls.Add(panel1);
            Controls.Add(button_UserControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_UserControl2;
        private Button button_UserControl1;
        private Button button_UserControl3;
    }
}