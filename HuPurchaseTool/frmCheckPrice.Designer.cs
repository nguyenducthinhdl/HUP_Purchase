namespace HuPurchaseTool
{
    partial class frmCheckPrice
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFilePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWebPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCode,
            this.clFilePrice,
            this.clWebPrice,
            this.clStatus});
            this.dataGridView1.Location = new System.Drawing.Point(40, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 464);
            this.dataGridView1.TabIndex = 0;
            // 
            // clCode
            // 
            this.clCode.HeaderText = "Adidas Code";
            this.clCode.Name = "clCode";
            // 
            // clFilePrice
            // 
            this.clFilePrice.HeaderText = "File Price";
            this.clFilePrice.Name = "clFilePrice";
            // 
            // clWebPrice
            // 
            this.clWebPrice.HeaderText = "Web Price";
            this.clWebPrice.Name = "clWebPrice";
            // 
            // clStatus
            // 
            this.clStatus.HeaderText = "Price Status";
            this.clStatus.Name = "clStatus";
            // 
            // frmCheckPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 564);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCheckPrice";
            this.Text = "frmCheckPrice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFilePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWebPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
    }
}