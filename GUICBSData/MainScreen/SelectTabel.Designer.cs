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
            this.Info = new System.Windows.Forms.Panel();
            this.Summary = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.SearchTabel = new System.Windows.Forms.TextBox();
            this.SearchTheme = new System.Windows.Forms.TextBox();
            this.LocationTable = new System.Windows.Forms.LinkLabel();
            this.GetData = new System.Windows.Forms.Button();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabelsList
            // 
            this.TabelsList.CheckOnClick = true;
            this.TabelsList.FormattingEnabled = true;
            this.TabelsList.Location = new System.Drawing.Point(51, 77);
            this.TabelsList.Name = "TabelsList";
            this.TabelsList.Size = new System.Drawing.Size(252, 244);
            this.TabelsList.TabIndex = 0;
            this.TabelsList.SelectedIndexChanged += new System.EventHandler(this.TabelsList_SelectedIndexChanged);
            // 
            // ThemesList
            // 
            this.ThemesList.CheckOnClick = true;
            this.ThemesList.FormattingEnabled = true;
            this.ThemesList.Location = new System.Drawing.Point(448, 77);
            this.ThemesList.Name = "ThemesList";
            this.ThemesList.Size = new System.Drawing.Size(188, 244);
            this.ThemesList.TabIndex = 1;
            // 
            // Info
            // 
            this.Info.Controls.Add(this.Summary);
            this.Info.Controls.Add(this.Title);
            this.Info.Location = new System.Drawing.Point(496, 355);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(427, 186);
            this.Info.TabIndex = 2;
            // 
            // Summary
            // 
            this.Summary.AutoSize = true;
            this.Summary.Location = new System.Drawing.Point(21, 57);
            this.Summary.MaximumSize = new System.Drawing.Size(400, 0);
            this.Summary.MinimumSize = new System.Drawing.Size(400, 0);
            this.Summary.Name = "Summary";
            this.Summary.Size = new System.Drawing.Size(400, 13);
            this.Summary.TabIndex = 1;
            this.Summary.Text = "Summary";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(17, 17);
            this.Title.MaximumSize = new System.Drawing.Size(400, 0);
            this.Title.MinimumSize = new System.Drawing.Size(400, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(400, 24);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title";
            // 
            // SearchTabel
            // 
            this.SearchTabel.Location = new System.Drawing.Point(51, 32);
            this.SearchTabel.Name = "SearchTabel";
            this.SearchTabel.Size = new System.Drawing.Size(252, 20);
            this.SearchTabel.TabIndex = 3;
            this.SearchTabel.TextChanged += new System.EventHandler(this.SearchTabel_TextChanged);
            // 
            // SearchTheme
            // 
            this.SearchTheme.Location = new System.Drawing.Point(448, 32);
            this.SearchTheme.Name = "SearchTheme";
            this.SearchTheme.Size = new System.Drawing.Size(188, 20);
            this.SearchTheme.TabIndex = 4;
            this.SearchTheme.TextChanged += new System.EventHandler(this.SearchTabel_TextChanged);
            // 
            // LocationTable
            // 
            this.LocationTable.AutoSize = true;
            this.LocationTable.Location = new System.Drawing.Point(496, 548);
            this.LocationTable.Name = "LocationTable";
            this.LocationTable.Size = new System.Drawing.Size(48, 13);
            this.LocationTable.TabIndex = 5;
            this.LocationTable.TabStop = true;
            this.LocationTable.Text = "Location";
            this.LocationTable.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LocationTable_LinkClicked);
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(739, 32);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(184, 23);
            this.GetData.TabIndex = 6;
            this.GetData.Text = "Get Data";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // SelectTabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.LocationTable);
            this.Controls.Add(this.SearchTheme);
            this.Controls.Add(this.SearchTabel);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.ThemesList);
            this.Controls.Add(this.TabelsList);
            this.Name = "SelectTabel";
            this.Size = new System.Drawing.Size(997, 578);
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox TabelsList;
        private System.Windows.Forms.CheckedListBox ThemesList;
        private System.Windows.Forms.Panel Info;
        private System.Windows.Forms.Label Summary;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox SearchTabel;
        private System.Windows.Forms.TextBox SearchTheme;
        private System.Windows.Forms.LinkLabel LocationTable;
        private System.Windows.Forms.Button GetData;
    }
}
