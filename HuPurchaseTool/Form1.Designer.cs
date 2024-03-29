﻿namespace HuPurchaseTool
{
    partial class frmPurchase
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
            this.btnOpenURL = new System.Windows.Forms.Button();
            this.txtPurChaseCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbOptionUK = new System.Windows.Forms.RadioButton();
            this.rdbOptionUS = new System.Windows.Forms.RadioButton();
            this.grpOption = new System.Windows.Forms.GroupBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkChromeCMD = new System.Windows.Forms.CheckBox();
            this.chkCheckSize = new System.Windows.Forms.CheckBox();
            this.txtDelayTab = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnValidateSize = new System.Windows.Forms.Button();
            this.btnUserSetting = new System.Windows.Forms.Button();
            this.txtBatchSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkUseBatch = new System.Windows.Forms.CheckBox();
            this.btnCheckPrice = new System.Windows.Forms.Button();
            this.grpOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenURL
            // 
            this.btnOpenURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenURL.Location = new System.Drawing.Point(445, 350);
            this.btnOpenURL.Name = "btnOpenURL";
            this.btnOpenURL.Size = new System.Drawing.Size(151, 52);
            this.btnOpenURL.TabIndex = 0;
            this.btnOpenURL.Text = "OpenURL";
            this.btnOpenURL.UseVisualStyleBackColor = true;
            this.btnOpenURL.Click += new System.EventHandler(this.btnOpenURL_Click);
            // 
            // txtPurChaseCode
            // 
            this.txtPurChaseCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurChaseCode.Location = new System.Drawing.Point(15, 98);
            this.txtPurChaseCode.Multiline = true;
            this.txtPurChaseCode.Name = "txtPurChaseCode";
            this.txtPurChaseCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPurChaseCode.Size = new System.Drawing.Size(154, 535);
            this.txtPurChaseCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adias Purchase Location";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(444, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 52);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 636);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Develop by Leona";
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
            // grpOption
            // 
            this.grpOption.Controls.Add(this.rdbOptionUS);
            this.grpOption.Controls.Add(this.rdbOptionUK);
            this.grpOption.Location = new System.Drawing.Point(230, 12);
            this.grpOption.Name = "grpOption";
            this.grpOption.Size = new System.Drawing.Size(188, 50);
            this.grpOption.TabIndex = 6;
            this.grpOption.TabStop = false;
            // 
            // txtSize
            // 
            this.txtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.Location = new System.Drawing.Point(208, 98);
            this.txtSize.Multiline = true;
            this.txtSize.Name = "txtSize";
            this.txtSize.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSize.Size = new System.Drawing.Size(182, 535);
            this.txtSize.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adias Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adias Size";
            // 
            // chkChromeCMD
            // 
            this.chkChromeCMD.AutoSize = true;
            this.chkChromeCMD.Location = new System.Drawing.Point(452, 95);
            this.chkChromeCMD.Name = "chkChromeCMD";
            this.chkChromeCMD.Size = new System.Drawing.Size(144, 21);
            this.chkChromeCMD.TabIndex = 10;
            this.chkChromeCMD.Text = "Chrome command";
            this.chkChromeCMD.UseVisualStyleBackColor = true;
            // 
            // chkCheckSize
            // 
            this.chkCheckSize.AutoSize = true;
            this.chkCheckSize.Checked = true;
            this.chkCheckSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCheckSize.Location = new System.Drawing.Point(452, 119);
            this.chkCheckSize.Name = "chkCheckSize";
            this.chkCheckSize.Size = new System.Drawing.Size(112, 21);
            this.chkCheckSize.TabIndex = 11;
            this.chkCheckSize.Text = "Validate Size";
            this.chkCheckSize.UseVisualStyleBackColor = true;
            // 
            // txtDelayTab
            // 
            this.txtDelayTab.Location = new System.Drawing.Point(537, 23);
            this.txtDelayTab.Name = "txtDelayTab";
            this.txtDelayTab.Size = new System.Drawing.Size(73, 22);
            this.txtDelayTab.TabIndex = 12;
            this.txtDelayTab.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Delay Tab";
            // 
            // btnValidateSize
            // 
            this.btnValidateSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidateSize.Location = new System.Drawing.Point(444, 234);
            this.btnValidateSize.Name = "btnValidateSize";
            this.btnValidateSize.Size = new System.Drawing.Size(151, 52);
            this.btnValidateSize.TabIndex = 13;
            this.btnValidateSize.Text = "Validate Size";
            this.btnValidateSize.UseVisualStyleBackColor = true;
            this.btnValidateSize.Click += new System.EventHandler(this.btnValidateSize_Click);
            // 
            // btnUserSetting
            // 
            this.btnUserSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSetting.ForeColor = System.Drawing.Color.DarkRed;
            this.btnUserSetting.Location = new System.Drawing.Point(445, 581);
            this.btnUserSetting.Name = "btnUserSetting";
            this.btnUserSetting.Size = new System.Drawing.Size(151, 52);
            this.btnUserSetting.TabIndex = 0;
            this.btnUserSetting.Text = "User Setting";
            this.btnUserSetting.UseVisualStyleBackColor = true;
            this.btnUserSetting.Visible = false;
            this.btnUserSetting.Click += new System.EventHandler(this.btnUserSetting_Click);
            // 
            // txtBatchSize
            // 
            this.txtBatchSize.Location = new System.Drawing.Point(537, 51);
            this.txtBatchSize.Name = "txtBatchSize";
            this.txtBatchSize.Size = new System.Drawing.Size(73, 22);
            this.txtBatchSize.TabIndex = 15;
            this.txtBatchSize.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(451, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Batch Size";
            // 
            // chkUseBatch
            // 
            this.chkUseBatch.AutoSize = true;
            this.chkUseBatch.Location = new System.Drawing.Point(452, 146);
            this.chkUseBatch.Name = "chkUseBatch";
            this.chkUseBatch.Size = new System.Drawing.Size(95, 21);
            this.chkUseBatch.TabIndex = 16;
            this.chkUseBatch.Text = "Use Batch";
            this.chkUseBatch.UseVisualStyleBackColor = true;
            // 
            // btnCheckPrice
            // 
            this.btnCheckPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckPrice.Location = new System.Drawing.Point(445, 292);
            this.btnCheckPrice.Name = "btnCheckPrice";
            this.btnCheckPrice.Size = new System.Drawing.Size(151, 52);
            this.btnCheckPrice.TabIndex = 17;
            this.btnCheckPrice.Text = "Check Price";
            this.btnCheckPrice.UseVisualStyleBackColor = true;
            this.btnCheckPrice.Click += new System.EventHandler(this.btnCheckPrice_Click);
            // 
            // frmPurchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 662);
            this.Controls.Add(this.btnCheckPrice);
            this.Controls.Add(this.chkUseBatch);
            this.Controls.Add(this.txtBatchSize);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnValidateSize);
            this.Controls.Add(this.txtDelayTab);
            this.Controls.Add(this.chkCheckSize);
            this.Controls.Add(this.chkChromeCMD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.grpOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPurChaseCode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUserSetting);
            this.Controls.Add(this.btnOpenURL);
            this.Name = "frmPurchase";
            this.Text = "HuPurchaseTool";
            this.Load += new System.EventHandler(this.frmPurchase_Load);
            this.grpOption.ResumeLayout(false);
            this.grpOption.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenURL;
        private System.Windows.Forms.TextBox txtPurChaseCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbOptionUK;
        private System.Windows.Forms.RadioButton rdbOptionUS;
        private System.Windows.Forms.GroupBox grpOption;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkChromeCMD;
        private System.Windows.Forms.CheckBox chkCheckSize;
        private System.Windows.Forms.TextBox txtDelayTab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnValidateSize;
        private System.Windows.Forms.Button btnUserSetting;
        private System.Windows.Forms.TextBox txtBatchSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkUseBatch;
        private System.Windows.Forms.Button btnCheckPrice;
    }
}

