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
            CatchmeButton.Location = new Point(271, 143);
            CatchmeButton.Name = "CatchmeButton";
            CatchmeButton.Size = new Size(234, 155);
            CatchmeButton.TabIndex = 0;
            CatchmeButton.Text = "나를 잡아봐";
            CatchmeButton.UseVisualStyleBackColor = true;
            CatchmeButton.Click += CatchmeButton_Click;
            CatchmeButton.MouseEnter += CatchmeButton_MouseEnter;
           
            // 
            // RestartButton
            // 
            RestartButton.Font = new Font("맑은 고딕", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 129);
            RestartButton.Location = new Point(600, 0);
            RestartButton.Name = "RestartButton";
            RestartButton.Size = new Size(130, 33);
            RestartButton.TabIndex = 2;
            RestartButton.Text = "다시시작";
            RestartButton.UseVisualStyleBackColor = true;
            RestartButton.Enabled = false;
            RestartButton.Click += RestartButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RestartButton);
            Controls.Add(CatchmeButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CatchmeButton;
        private Button RestartButton;
    }
}
