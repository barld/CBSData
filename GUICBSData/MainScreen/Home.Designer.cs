namespace GUICBSData.MainScreen
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SynchronsizeButton = new System.Windows.Forms.Button();
            this.SelectTabelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.MaximumSize = new System.Drawing.Size(200, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welkom bij dit programma voor het makkelijk selecteeren van data bij het CBS klik" +
    " hiernaast wat u wilt doen";
            // 
            // SynchronsizeButton
            // 
            this.SynchronsizeButton.Location = new System.Drawing.Point(429, 46);
            this.SynchronsizeButton.Name = "SynchronsizeButton";
            this.SynchronsizeButton.Size = new System.Drawing.Size(144, 23);
            this.SynchronsizeButton.TabIndex = 1;
            this.SynchronsizeButton.Text = "Synchroniseer cataloges";
            this.SynchronsizeButton.UseVisualStyleBackColor = true;
            this.SynchronsizeButton.Click += new System.EventHandler(this.SynchronsizeButton_Click);
            // 
            // SelectTabelButton
            // 
            this.SelectTabelButton.Location = new System.Drawing.Point(429, 96);
            this.SelectTabelButton.Name = "SelectTabelButton";
            this.SelectTabelButton.Size = new System.Drawing.Size(144, 23);
            this.SelectTabelButton.TabIndex = 2;
            this.SelectTabelButton.Text = "selecteer tabel";
            this.SelectTabelButton.UseVisualStyleBackColor = true;
            this.SelectTabelButton.Click += new System.EventHandler(this.SelectTabelButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SelectTabelButton);
            this.Controls.Add(this.SynchronsizeButton);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(602, 364);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SynchronsizeButton;
        private System.Windows.Forms.Button SelectTabelButton;
    }
}
