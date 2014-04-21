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
            this.GetData = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.limitFrom = new System.Windows.Forms.Label();
            this.LimitTo = new System.Windows.Forms.Label();
            this.limit = new System.Windows.Forms.Label();
            this.DataTransfer = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // CatogoriesList
            // 
            this.CatogoriesList.CheckOnClick = true;
            this.CatogoriesList.FormattingEnabled = true;
            this.CatogoriesList.Location = new System.Drawing.Point(76, 81);
            this.CatogoriesList.Name = "CatogoriesList";
            this.CatogoriesList.Size = new System.Drawing.Size(220, 169);
            this.CatogoriesList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "selecteer de juiste Column";
            // 
            // GetData
            // 
            this.GetData.Location = new System.Drawing.Point(519, 41);
            this.GetData.Name = "GetData";
            this.GetData.Size = new System.Drawing.Size(184, 23);
            this.GetData.TabIndex = 9;
            this.GetData.Text = "Get Data in Excel";
            this.GetData.UseVisualStyleBackColor = true;
            this.GetData.Click += new System.EventHandler(this.GetData_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(76, 361);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(220, 45);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // limitFrom
            // 
            this.limitFrom.AutoSize = true;
            this.limitFrom.Location = new System.Drawing.Point(35, 361);
            this.limitFrom.Name = "limitFrom";
            this.limitFrom.Size = new System.Drawing.Size(13, 13);
            this.limitFrom.TabIndex = 11;
            this.limitFrom.Text = "1";
            // 
            // LimitTo
            // 
            this.LimitTo.AutoSize = true;
            this.LimitTo.Location = new System.Drawing.Point(303, 361);
            this.LimitTo.Name = "LimitTo";
            this.LimitTo.Size = new System.Drawing.Size(41, 13);
            this.LimitTo.TabIndex = 12;
            this.LimitTo.Text = "LimitTo";
            // 
            // limit
            // 
            this.limit.AutoSize = true;
            this.limit.Location = new System.Drawing.Point(175, 330);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(13, 13);
            this.limit.TabIndex = 13;
            this.limit.Text = "1";
            // 
            // DataTransfer
            // 
            this.DataTransfer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DataTransfer_DoWork);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Aantal rijen";
            // 
            // SelectTabelInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.LimitTo);
            this.Controls.Add(this.limitFrom);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.GetData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CatogoriesList);
            this.Name = "SelectTabelInformation";
            this.Size = new System.Drawing.Size(772, 447);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CatogoriesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GetData;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label limitFrom;
        private System.Windows.Forms.Label LimitTo;
        private System.Windows.Forms.Label limit;
        private System.ComponentModel.BackgroundWorker DataTransfer;
        private System.Windows.Forms.Label label2;
    }
}
