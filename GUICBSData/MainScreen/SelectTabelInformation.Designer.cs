namespace GUICBSData.MainScreen
{
    partial class SelectTabelInformation
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
            this.CatogoriesList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CatogoriesList
            // 
            this.CatogoriesList.CheckOnClick = true;
            this.CatogoriesList.FormattingEnabled = true;
            this.CatogoriesList.Location = new System.Drawing.Point(76, 81);
            this.CatogoriesList.Name = "CatogoriesList";
            this.CatogoriesList.Size = new System.Drawing.Size(180, 154);
            this.CatogoriesList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catogorie";
            // 
            // SelectTabelInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CatogoriesList);
            this.Name = "SelectTabelInformation";
            this.Size = new System.Drawing.Size(772, 447);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CatogoriesList;
        private System.Windows.Forms.Label label1;
    }
}
