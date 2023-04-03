namespace FridayThe13thWarner
{
    partial class mainForm
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
            resultLabel = new Label();
            label1 = new Label();
            dragBar = new Panel();
            closeBTN = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dragBar.SuspendLayout();
            SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Chiller", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            resultLabel.ForeColor = Color.FromArgb(179, 27, 27);
            resultLabel.Location = new Point(245, 198);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(188, 56);
            resultLabel.TabIndex = 0;
            resultLabel.Text = "00.00.00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Goudy Old Style", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(209, 159);
            label1.Name = "label1";
            label1.Size = new Size(251, 43);
            label1.TabIndex = 1;
            label1.Text = "Friday the 13th";
            // 
            // dragBar
            // 
            dragBar.BackColor = Color.FromArgb(255, 102, 0);
            dragBar.Controls.Add(closeBTN);
            dragBar.Dock = DockStyle.Top;
            dragBar.Location = new Point(0, 0);
            dragBar.Name = "dragBar";
            dragBar.Size = new Size(781, 28);
            dragBar.TabIndex = 2;
            dragBar.MouseDown += dragBar_MouseDown;
            dragBar.MouseMove += dragBar_MouseMove;
            dragBar.MouseUp += dragBar_MouseUp;
            // 
            // closeBTN
            // 
            closeBTN.FlatAppearance.BorderSize = 0;
            closeBTN.FlatStyle = FlatStyle.Flat;
            closeBTN.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point);
            closeBTN.ForeColor = Color.White;
            closeBTN.Location = new Point(753, 0);
            closeBTN.Name = "closeBTN";
            closeBTN.Size = new Size(28, 28);
            closeBTN.TabIndex = 0;
            closeBTN.Text = "X";
            closeBTN.UseVisualStyleBackColor = true;
            closeBTN.Click += closeBTN_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(23, 23, 23);
            ClientSize = new Size(781, 362);
            Controls.Add(dragBar);
            Controls.Add(label1);
            Controls.Add(resultLabel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainForm";
            ShowIcon = false;
            dragBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label resultLabel;
        private Label label1;
        private Panel dragBar;
        private Button closeBTN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}