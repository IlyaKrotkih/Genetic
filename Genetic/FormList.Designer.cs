namespace Genetic
{
    partial class FormList
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.clGood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clExisting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clD1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cD2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clGood,
            this.clCount,
            this.clExisting,
            this.clPrice,
            this.clD1,
            this.cD2,
            this.cF});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.ShowEditingIcon = false;
            this.dgvList.Size = new System.Drawing.Size(468, 292);
            this.dgvList.TabIndex = 4;
            // 
            // clGood
            // 
            this.clGood.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clGood.HeaderText = "X";
            this.clGood.MinimumWidth = 50;
            this.clGood.Name = "clGood";
            this.clGood.ReadOnly = true;
            this.clGood.Width = 50;
            // 
            // clCount
            // 
            this.clCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clCount.HeaderText = "Y";
            this.clCount.MinimumWidth = 50;
            this.clCount.Name = "clCount";
            this.clCount.ReadOnly = true;
            this.clCount.Width = 50;
            // 
            // clExisting
            // 
            this.clExisting.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clExisting.HeaderText = "val X";
            this.clExisting.Name = "clExisting";
            this.clExisting.ReadOnly = true;
            this.clExisting.Width = 55;
            // 
            // clPrice
            // 
            this.clPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clPrice.HeaderText = "ValY";
            this.clPrice.Name = "clPrice";
            this.clPrice.ReadOnly = true;
            this.clPrice.Width = 53;
            // 
            // clD1
            // 
            this.clD1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clD1.HeaderText = "D1";
            this.clD1.Name = "clD1";
            this.clD1.ReadOnly = true;
            this.clD1.Width = 45;
            // 
            // cD2
            // 
            this.cD2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cD2.HeaderText = "D2";
            this.cD2.Name = "cD2";
            this.cD2.ReadOnly = true;
            this.cD2.Width = 45;
            // 
            // cF
            // 
            this.cF.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cF.HeaderText = "F";
            this.cF.Name = "cF";
            this.cF.ReadOnly = true;
            this.cF.Width = 37;
            // 
            // FormList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 292);
            this.Controls.Add(this.dgvList);
            this.Name = "FormList";
            this.Text = "Список";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGood;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clExisting;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clD1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cD2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cF;
    }
}