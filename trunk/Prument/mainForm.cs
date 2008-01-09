using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Prument
{
    public enum EditStatus
    {
        New,
        Saved,
        Changed,
        NewChanged
    }
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            this.MdiChildActivate += new EventHandler(mainForm_MdiChildActivate);
        }

        private void mainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (Form.ActiveForm.ActiveMdiChild != null && Form.ActiveForm.ActiveMdiChild.Name=="ItemDetail")
                ((ItemDetail)Form.ActiveForm.ActiveMdiChild).changeSaveStatus();
        }
       
        
        private void mainForm_Load(object sender, EventArgs e)
        {

            this.IsMdiContainer = true;
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {

        }

        private void iteNew_Click(object sender, EventArgs e)
        {
            ItemDetail _iteDetail = new ItemDetail();
            _iteDetail.MdiParent = this;
            _iteDetail.Show();
        }

        private void iteSave_Click(object sender, EventArgs e)
        {
            ((ItemDetail)Form.ActiveForm.ActiveMdiChild).btnSave_Click(sender, e);
        }

        private void menMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iteFind_Click(object sender, EventArgs e)
        {
            SearthItem _seaItem = new SearthItem();
            _seaItem.MdiParent = this;
            _seaItem.Show();
        }

        private void iteAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright 2006 By Homyu.Shinn\nhttp://eroman.org");
        }

        private void iteExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}