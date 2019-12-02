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
            this.btnCheckPrice = new System.Windows.Forms.Button();
            this.grpOption = new System.Windows.Forms.GroupBox();
            this.rdbOptionUS = new System.Windows.Forms.RadioButton();
            this.rdbOptionUK = new System.Windows.Forms.RadioButton();
            this.btnCheckSize = new System.Windows.Forms.Button();
            this.clCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFilePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clWebPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpOption.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(29, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(966, 578);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyUp);
            // 
            // btnCheckPrice
            // 
            this.btnCheckPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckPrice.Location = new System.Drawing.Point(1023, 162);
            this.btnCheckPrice.Name = "btnCheckPrice";
            this.btnCheckPrice.Size = new System.Drawing.Size(151, 52);
            this.btnCheckPrice.TabIndex = 18;
            this.btnCheckPrice.Text = "Check Price";
            this.btnCheckPrice.UseVisualStyleBackColor = true;
            this.btnCheckPrice.Click += new System.EventHandler(this.btnCheckPrice_Click);
            // 
            // grpOption
            // 
            this.grpOption.Controls.Add(this.rdbOptionUS);
            this.grpOption.Controls.Add(this.rdbOptionUK);
            this.grpOption.Location = new System.Drawing.Point(29, 38);
            this.grpOption.Name = "grpOption";
            this.grpOption.Size = new System.Drawing.Size(188, 50);
            this.grpOption.TabIndex = 19;
            this.grpOption.TabStop = false;
            this.grpOption.Text = "Adidas Location";
            // 
            // rdbOptionUS
            // 
            this.rdbOptionUS.AutoSize = true;
            this.rdbOptionUS.Location = new System.Drawing.Point(138, 21);
            this.rdbOptionUS.Name = "rdbOptionUS";
            this.rdbOptionUS.Size = new System.Drawing.Size(48, 21);
            this.rdbOptionUS.TabIndex = 5;
            this.rdbOptionUS.TabStop = true;
            this.rdbOptionUS.Text = "US";
            this.rdbOptionUS.UseVisualStyleBackColor = true;
            // 
            // rdbOptionUK
            // 
            this.rdbOptionUK.AutoSize = true;
            this.rdbOptionUK.Checked = true;
            this.rdbOptionUK.Location = new System.Drawing.Point(36, 21);
            this.rdbOptionUK.Name = "rdbOptionUK";
            this.rdbOptionUK.Size = new System.Drawing.Size(48, 21);
            this.rdbOptionUK.TabIndex = 4;
            this.rdbOptionUK.TabStop = true;
            this.rdbOptionUK.Text = "UK";
            this.rdbOptionUK.UseVisualStyleBackColor = true;
            // 
            // btnCheckSize
            // 
            this.btnCheckSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckSize.Location = new System.Drawing.Point(1023, 237);
            this.btnCheckSize.Name = "btnCheckSize";
            this.btnCheckSize.Size = new System.Drawing.Size(151, 52);
            this.btnCheckSize.TabIndex = 20;
            this.btnCheckSize.Text = "Check Size";
            this.btnCheckSize.UseVisualStyleBackColor = true;
            this.btnCheckSize.Click += new System.EventHandler(this.btnCheckSize_Click);
            // 
            // clCode
            // 
            this.clCode.HeaderText = "Adidas Code";
            this.clCode.Name = "clCode";
            // 
            // clFilePrice
            // 
            this.clFilePrice.HeaderText = "File Price / Size";
            this.clFilePrice.Name = "clFilePrice";
            // 
            // clWebPrice
            // 
            this.clWebPrice.HeaderText = "Web Price / Size";
            this.clWebPrice.Name = "clWebPrice";
            this.clWebPrice.Width = 200;
            // 
            // clStatus
            // 
            this.clStatus.HeaderText = "Price / Size Status";
            this.clStatus.Name = "clStatus";
            this.clStatus.Width = 150;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1023, 94);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 52);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmCheckPrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 684);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCheckSize);
            this.Controls.Add(this.grpOption);
            this.Controls.Add(this.btnCheckPrice);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmCheckPrice";
            this.Text = "frmCheckPrice";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpOption.ResumeLayout(false);
            this.grpOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCheckPrice;
        private System.Windows.Forms.GroupBox grpOption;
        private System.Windows.Forms.RadioButton rdbOptionUS;
        private System.Windows.Forms.RadioButton rdbOptionUK;
        private System.Windows.Forms.Button btnCheckSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFilePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clWebPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
        private System.Windows.Forms.Button btnClear;
    }
}