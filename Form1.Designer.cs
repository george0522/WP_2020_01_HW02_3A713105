﻿namespace WP_2020_01_HW02_3A713105
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pbCARD = new System.Windows.Forms.PictureBox();
            this.btnRUN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCARD)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCARD
            // 
            this.pbCARD.Location = new System.Drawing.Point(290, 179);
            this.pbCARD.Name = "pbCARD";
            this.pbCARD.Size = new System.Drawing.Size(110, 151);
            this.pbCARD.TabIndex = 0;
            this.pbCARD.TabStop = false;
            // 
            // btnRUN
            // 
            this.btnRUN.Location = new System.Drawing.Point(513, 105);
            this.btnRUN.Name = "btnRUN";
            this.btnRUN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRUN.Size = new System.Drawing.Size(98, 49);
            this.btnRUN.TabIndex = 1;
            this.btnRUN.Text = "抽";
            this.btnRUN.UseVisualStyleBackColor = true;
            this.btnRUN.Click += new System.EventHandler(this.btnRUN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 25F);
            this.label1.Location = new System.Drawing.Point(266, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "撲克牌抽卡";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRUN);
            this.Controls.Add(this.pbCARD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCARD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCARD;
        private System.Windows.Forms.Button btnRUN;
        private System.Windows.Forms.Label label1;
    }
}

