namespace Prument
{
    partial class ItemDetail
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
            this.components = new System.ComponentModel.Container();
            this.btnInsertImg = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenPic = new System.Windows.Forms.Button();
            this.btnNextPic = new System.Windows.Forms.Button();
            this.btnPrevPic = new System.Windows.Forms.Button();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.erpMain = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofdMain = new System.Windows.Forms.OpenFileDialog();
            this.btnDeleteImg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPicStatus = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsertImg
            // 
            this.btnInsertImg.Location = new System.Drawing.Point(129, 286);
            this.btnInsertImg.Name = "btnInsertImg";
            this.btnInsertImg.Size = new System.Drawing.Size(69, 23);
            this.btnInsertImg.TabIndex = 30;
            this.btnInsertImg.Text = "添加照片";
            this.btnInsertImg.UseVisualStyleBackColor = true;
            this.btnInsertImg.Click += new System.EventHandler(this.btnInsertImg_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(465, 324);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 23);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "保存/更新";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenPic
            // 
            this.btnOpenPic.Location = new System.Drawing.Point(47, 286);
            this.btnOpenPic.Name = "btnOpenPic";
            this.btnOpenPic.Size = new System.Drawing.Size(66, 23);
            this.btnOpenPic.TabIndex = 28;
            this.btnOpenPic.Text = "打开照片";
            this.btnOpenPic.UseVisualStyleBackColor = true;
            this.btnOpenPic.Click += new System.EventHandler(this.btnOpenPic_Click);
            // 
            // btnNextPic
            // 
            this.btnNextPic.Location = new System.Drawing.Point(289, 286);
            this.btnNextPic.Name = "btnNextPic";
            this.btnNextPic.Size = new System.Drawing.Size(25, 23);
            this.btnNextPic.TabIndex = 27;
            this.btnNextPic.Text = ">";
            this.btnNextPic.UseVisualStyleBackColor = true;
            this.btnNextPic.Click += new System.EventHandler(this.btnNextPic_Click);
            // 
            // btnPrevPic
            // 
            this.btnPrevPic.Location = new System.Drawing.Point(12, 286);
            this.btnPrevPic.Name = "btnPrevPic";
            this.btnPrevPic.Size = new System.Drawing.Size(25, 23);
            this.btnPrevPic.TabIndex = 26;
            this.btnPrevPic.Text = "<";
            this.btnPrevPic.UseVisualStyleBackColor = true;
            this.btnPrevPic.Click += new System.EventHandler(this.btnPrevPic_Click);
            // 
            // picProduct
            // 
            this.picProduct.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Location = new System.Drawing.Point(12, 12);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(302, 267);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 21;
            this.picProduct.TabStop = false;
            // 
            // erpMain
            // 
            this.erpMain.ContainerControl = this;
            // 
            // ofdMain
            // 
            this.ofdMain.Filter = "All Picture format|*.*|BitMap|*.bmp|JPEG|*.jpg";
            this.ofdMain.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdMain_FileOk);
            // 
            // btnDeleteImg
            // 
            this.btnDeleteImg.Location = new System.Drawing.Point(213, 286);
            this.btnDeleteImg.Name = "btnDeleteImg";
            this.btnDeleteImg.Size = new System.Drawing.Size(65, 23);
            this.btnDeleteImg.TabIndex = 31;
            this.btnDeleteImg.Text = "删除照片";
            this.btnDeleteImg.UseVisualStyleBackColor = true;
            this.btnDeleteImg.Click += new System.EventHandler(this.btnDeleteImg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "照片位置：";
            // 
            // lblPicStatus
            // 
            this.lblPicStatus.AutoSize = true;
            this.lblPicStatus.Location = new System.Drawing.Point(77, 324);
            this.lblPicStatus.Name = "lblPicStatus";
            this.lblPicStatus.Size = new System.Drawing.Size(0, 13);
            this.lblPicStatus.TabIndex = 33;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(394, 12);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(175, 20);
            this.txbName.TabIndex = 22;
            this.txbName.Leave += new System.EventHandler(this.txbName_Leave);
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(333, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 13);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "产品型号:";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(336, 56);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(233, 253);
            this.txbDescription.TabIndex = 24;
            this.txbDescription.TextChanged += new System.EventHandler(this.txbDescription_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "相关描述:";
            // 
            // ItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 359);
            this.Controls.Add(this.lblPicStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteImg);
            this.Controls.Add(this.btnInsertImg);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpenPic);
            this.Controls.Add(this.btnNextPic);
            this.Controls.Add(this.btnPrevPic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.picProduct);
            this.Name = "ItemDetail";
            this.Text = "产品信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemDetail_FormClosed);
            this.Click += new System.EventHandler(this.ItemDetail_Click);
            this.Load += new System.EventHandler(this.ItemDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInsertImg;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenPic;
        private System.Windows.Forms.Button btnNextPic;
        private System.Windows.Forms.Button btnPrevPic;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.ErrorProvider erpMain;
        private System.Windows.Forms.OpenFileDialog ofdMain;
        private System.Windows.Forms.Button btnDeleteImg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPicStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
    }
}