namespace Prument
{
    partial class SearthItem
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet1 = new Prument.dataDataSet1();
            this.imagesTableAdapter = new Prument.dataDataSet1TableAdapters.ImagesTableAdapter();
            this.productsTableAdapter = new Prument.dataDataSet1TableAdapters.ProductsTableAdapter();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).BeginInit();
            this.panButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pID,
            this.pName,
            this.pDescription});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(611, 358);
            this.dataGridView1.TabIndex = 0;
            // 
            // pID
            // 
            this.pID.DataPropertyName = "ID";
            this.pID.HeaderText = "ID";
            this.pID.Name = "pID";
            this.pID.ReadOnly = true;
            // 
            // pName
            // 
            this.pName.DataPropertyName = "Name";
            this.pName.HeaderText = "ÐÍºÅ";
            this.pName.Name = "pName";
            this.pName.ReadOnly = true;
            // 
            // pDescription
            // 
            this.pDescription.DataPropertyName = "Description";
            this.pDescription.HeaderText = "ÃèÊö";
            this.pDescription.Name = "pDescription";
            this.pDescription.ReadOnly = true;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dataDataSet1;
            this.bindingSource1.Position = 0;
            // 
            // dataDataSet1
            // 
            this.dataDataSet1.DataSetName = "dataDataSet1";
            this.dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imagesTableAdapter
            // 
            this.imagesTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(84, 0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "É¾³ý¼ÇÂ¼";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(3, 0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "²é¿´¼ÇÂ¼";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(166, 0);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Ë¢    ÐÂ";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // panButtons
            // 
            this.panButtons.Controls.Add(this.btnRefresh);
            this.panButtons.Controls.Add(this.btnDel);
            this.panButtons.Controls.Add(this.btnView);
            this.panButtons.Location = new System.Drawing.Point(3, 376);
            this.panButtons.Name = "panButtons";
            this.panButtons.Size = new System.Drawing.Size(252, 33);
            this.panButtons.TabIndex = 4;
            // 
            // SearthItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 410);
            this.Controls.Add(this.panButtons);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearthItem";
            this.Text = "ËÑË÷";
            this.SizeChanged += new System.EventHandler(this.SearthItem_SizeChanged);
            this.Load += new System.EventHandler(this.SearthItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet1)).EndInit();
            this.panButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private dataDataSet1 dataDataSet1;
        private Prument.dataDataSet1TableAdapters.ImagesTableAdapter imagesTableAdapter;
        private Prument.dataDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDescription;
        private System.Windows.Forms.Panel panButtons;
    }
}