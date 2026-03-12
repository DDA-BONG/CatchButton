namespace CatchButton
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
            CatchmeButton = new Button();
            RestartButton = new Button();
            SuspendLayout();
            // 
            // CatchmeButton
            // 
            CatchmeButton.Font = new Font("맑은 고딕", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 129);
            CatchmeButton.ForeColor = Color.Gold;
            CatchmeButton.Location = new Point(211, 107);
            CatchmeButton.Margin = new Padding(2, 2, 2, 2);
            CatchmeButton.Name = "CatchmeButton";
            CatchmeButton.Size = new Size(182, 116);
            CatchmeButton.TabIndex = 0;
            CatchmeButton.Text = "나를 잡아봐";
            CatchmeButton.UseVisualStyleBackColor = true;
            CatchmeButton.Click += CatchmeButton_Click;
            CatchmeButton.MouseEnter += CatchmeButton_MouseEnter;
            // 
            // RestartButton
            // 
            RestartButton.Enabled = false;
            RestartButton.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            RestartButton.Location = new Point(519, 2);
            RestartButton.Margin = new Padding(2, 2, 2, 2);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(101, 25);
            RestartButton.TabIndex = 2;
            RestartButton.Text = "다시시작";
            RestartButton.UseVisualStyleBackColor = true;
            RestartButton.Click += RestartButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 338);
            Controls.Add(RestartButton);
            Controls.Add(CatchmeButton);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CatchmeButton;
        private Button RestartButton;
    }
}
