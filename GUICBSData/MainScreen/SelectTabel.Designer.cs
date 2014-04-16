namespace GUICBSData.MainScreen
{
    partial class SelectTabel
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
            this.TabelsList = new System.Windows.Forms.CheckedListBox();
            this.ThemesList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // TabelsList
            // 
            this.TabelsList.FormattingEnabled = true;
            this.TabelsList.Location = new System.Drawing.Point(51, 40);
            this.TabelsList.Name = "TabelsList";
            this.TabelsList.Size = new System.Drawing.Size(178, 154);
            this.TabelsList.TabIndex = 0;
            // 
            // ThemesList
            // 
            this.ThemesList.FormattingEnabled = true;
            this.ThemesList.Location = new System.Drawing.Point(351, 40);
            this.ThemesList.Name = "ThemesList";
            this.ThemesList.Size = new System.Drawing.Size(180, 154);
            this.ThemesList.TabIndex = 1;
            // 
            // SelectTabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ThemesList);
            this.Controls.Add(this.TabelsList);
            this.Name = "SelectTabel";
            this.Size = new System.Drawing.Size(969, 473);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox TabelsList;
        private System.Windows.Forms.CheckedListBox ThemesList;
    }
}
