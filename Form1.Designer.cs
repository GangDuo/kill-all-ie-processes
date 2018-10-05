namespace KillAllIeProcesses
{
    partial class Form1
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
            this.btnClose1 = new System.Windows.Forms.Button();
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.ListView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClose1
            // 
            this.btnClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose1.Location = new System.Drawing.Point(160, 172);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(112, 30);
            this.btnClose1.TabIndex = 4;
            this.btnClose1.Text = "プロセスの終了";
            this.btnClose1.Click += new System.EventHandler(this.btnClose1_Click);
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Process ID";
            this.ColumnHeader2.Width = 85;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Window Title";
            this.ColumnHeader1.Width = 160;
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloseAll.Location = new System.Drawing.Point(32, 172);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(112, 30);
            this.btnCloseAll.TabIndex = 3;
            this.btnCloseAll.Text = "すべて終了";
            this.btnCloseAll.Click += new System.EventHandler(this.btnCloseAll_Click);
            // 
            // ListView1
            // 
            this.ListView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.ListView1.FullRowSelect = true;
            this.ListView1.Location = new System.Drawing.Point(22, 36);
            this.ListView1.MultiSelect = false;
            this.ListView1.Name = "ListView1";
            this.ListView1.Size = new System.Drawing.Size(375, 126);
            this.ListView1.TabIndex = 7;
            this.ListView1.UseCompatibleStateImageBehavior = false;
            this.ListView1.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(278, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "再試行";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "Internet Explorerを閉じてください。";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.ClientSize = new System.Drawing.Size(425, 238);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCloseAll);
            this.Controls.Add(this.ListView1);
            this.Controls.Add(this.btnClose1);
            this.Name = "Form1";
            this.Text = "プロセス";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.closing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal System.Windows.Forms.Button btnCloseAll;
        internal System.Windows.Forms.ColumnHeader ColumnHeader2;
        internal System.Windows.Forms.ColumnHeader ColumnHeader1;
        internal System.Windows.Forms.ListView ListView1;
        internal System.Windows.Forms.Button btnClose1;
        internal System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}

