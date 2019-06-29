namespace StockProc
{
    partial class ProgressBar
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
            this.progressBar_MeanLine = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progressBar_MeanLine
            // 
            this.progressBar_MeanLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar_MeanLine.Location = new System.Drawing.Point(0, 0);
            this.progressBar_MeanLine.Name = "progressBar_MeanLine";
            this.progressBar_MeanLine.Size = new System.Drawing.Size(284, 24);
            this.progressBar_MeanLine.TabIndex = 0;
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 24);
            this.Controls.Add(this.progressBar_MeanLine);
            this.Name = "ProgressBar";
            this.Text = "正在计算平均线";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ProgressBar progressBar_MeanLine;
    }
}