using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prument
{
    public partial class SearthItem : Form
    {
        public SearthItem()
        {
            InitializeComponent();
        }

        private void SearthItem_Load(object sender, EventArgs e)
        {
            DataGridRefresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridRefresh();
        }
        private void DataGridRefresh() {
            // TODO: This line of code loads data into the 'dataDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dataDataSet1.Products);
            // TODO: This line of code loads data into the 'dataDataSet1.Images' table. You can move, or remove it, as needed.
            this.imagesTableAdapter.Fill(this.dataDataSet1.Images);
        }
        private void SearthItem_SizeChanged(object sender, EventArgs e)
        {
            this.dataGridView1.Width = this.Width - 13;
            this.dataGridView1.Height = this.Height - 79;
            this.panButtons.Top  = this.dataGridView1.Top + this.dataGridView1.Height +6;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            int i = 0;
            ItemDetail[] _iteDetail = new ItemDetail[255];
            while (i < dataGridView1.SelectedRows.Count && i < 256)
            {
                _iteDetail[i] = new ItemDetail();
                _iteDetail[i].MdiParent = this.MdiParent;
                _iteDetail[i].Show();
                _iteDetail[i]._p = new Prument.ORM.Products();
                _iteDetail[i]._p.ID = Int32.Parse(dataGridView1.SelectedRows[i].Cells["pID"].Value.ToString());
                _iteDetail[i].DataBind();
                _iteDetail[i].Status = EditStatus.Saved;
                i++;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("请问确认要删除这些记录吗？一旦删除数据将不可恢复！", "提示", MessageBoxButtons.YesNo) ==DialogResult.Yes)
            {
                int i;
                Prument.ORM.Products _p = new Prument.ORM.Products();
                for (i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    _p.ID = Int32.Parse(dataGridView1.SelectedRows[i].Cells["pID"].Value.ToString());
                    _p.DataBind(Prument.ORM.BindOperator.Delete);
                }
                DataGridRefresh();
            }
        }
    }
}