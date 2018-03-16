namespace SetPrpxy
{
    partial class FormSetProxy
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetProxy));
            this.BtnEnable = new System.Windows.Forms.Button();
            this.BtnDisable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEnable
            // 
            this.BtnEnable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnEnable.Location = new System.Drawing.Point(27, 28);
            this.BtnEnable.Name = "BtnEnable";
            this.BtnEnable.Size = new System.Drawing.Size(119, 51);
            this.BtnEnable.TabIndex = 0;
            this.BtnEnable.Text = "有効";
            this.BtnEnable.UseVisualStyleBackColor = false;
            this.BtnEnable.Click += new System.EventHandler(this.BtnEnable_Click);
            // 
            // BtnDisable
            // 
            this.BtnDisable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnDisable.Location = new System.Drawing.Point(177, 28);
            this.BtnDisable.Name = "BtnDisable";
            this.BtnDisable.Size = new System.Drawing.Size(119, 51);
            this.BtnDisable.TabIndex = 0;
            this.BtnDisable.Text = "無効";
            this.BtnDisable.UseVisualStyleBackColor = false;
            this.BtnDisable.Click += new System.EventHandler(this.BtnDisable_Click);
            // 
            // FormSetProxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 105);
            this.Controls.Add(this.BtnDisable);
            this.Controls.Add(this.BtnEnable);
            this.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FormSetProxy";
            this.Text = "プロキシOn/Off切替";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnEnable;
        private System.Windows.Forms.Button BtnDisable;
    }
}

