namespace FaceDetection
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHaar = new System.Windows.Forms.Button();
            this.picCamer = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCNN = new System.Windows.Forms.Button();
            this.btnLbp = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.ConfigPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picCamer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ConfigPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHaar
            // 
            this.btnHaar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHaar.Location = new System.Drawing.Point(6, 194);
            this.btnHaar.Margin = new System.Windows.Forms.Padding(6);
            this.btnHaar.Name = "btnHaar";
            this.btnHaar.Size = new System.Drawing.Size(194, 44);
            this.btnHaar.TabIndex = 1;
            this.btnHaar.Text = "Haar人脸识别";
            this.btnHaar.UseVisualStyleBackColor = true;
            this.btnHaar.Click += new System.EventHandler(this.OnHaarFaceDetection);
            // 
            // picCamer
            // 
            this.picCamer.Location = new System.Drawing.Point(12, 38);
            this.picCamer.Margin = new System.Windows.Forms.Padding(6);
            this.picCamer.Name = "picCamer";
            this.picCamer.Size = new System.Drawing.Size(560, 479);
            this.picCamer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCamer.TabIndex = 1;
            this.picCamer.TabStop = false;
            this.picCamer.Click += new System.EventHandler(this.picCamer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.picCamer);
            this.groupBox1.Location = new System.Drawing.Point(372, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(589, 538);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Area";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCNN
            // 
            this.btnCNN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCNN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCNN.Location = new System.Drawing.Point(6, 138);
            this.btnCNN.Margin = new System.Windows.Forms.Padding(6);
            this.btnCNN.Name = "btnCNN";
            this.btnCNN.Size = new System.Drawing.Size(194, 44);
            this.btnCNN.TabIndex = 0;
            this.btnCNN.Text = "CNN人脸识别";
            this.btnCNN.UseVisualStyleBackColor = true;
            this.btnCNN.Click += new System.EventHandler(this.OnCNNFaceDetection);
            // 
            // btnLbp
            // 
            this.btnLbp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLbp.Location = new System.Drawing.Point(6, 250);
            this.btnLbp.Margin = new System.Windows.Forms.Padding(6);
            this.btnLbp.Name = "btnLbp";
            this.btnLbp.Size = new System.Drawing.Size(194, 44);
            this.btnLbp.TabIndex = 2;
            this.btnLbp.Text = "Lbp人脸识别";
            this.btnLbp.UseVisualStyleBackColor = true;
            this.btnLbp.Click += new System.EventHandler(this.OnLbpFaceDetection);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Title.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(30, 10);
            this.Title.Margin = new System.Windows.Forms.Padding(30, 10, 3, 70);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(246, 52);
            this.Title.TabIndex = 3;
            this.Title.Text = "Face Detection";
            this.Title.Click += new System.EventHandler(this.title_Click);
            // 
            // ConfigPanel
            // 
            this.ConfigPanel.Controls.Add(this.Title);
            this.ConfigPanel.Controls.Add(this.btnCNN);
            this.ConfigPanel.Controls.Add(this.btnHaar);
            this.ConfigPanel.Controls.Add(this.btnLbp);
            this.ConfigPanel.ForeColor = System.Drawing.Color.Black;
            this.ConfigPanel.Location = new System.Drawing.Point(12, 31);
            this.ConfigPanel.Name = "ConfigPanel";
            this.ConfigPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ConfigPanel.Size = new System.Drawing.Size(338, 300);
            this.ConfigPanel.TabIndex = 4;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(976, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConfigPanel);
            this.Font = new System.Drawing.Font("楷体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "人脸识别";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCamer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ConfigPanel.ResumeLayout(false);
            this.ConfigPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHaar;
        private System.Windows.Forms.PictureBox picCamer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCNN;
        private System.Windows.Forms.Button btnLbp;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.FlowLayoutPanel ConfigPanel;
    }
}

