using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Prument
{
    public partial class ItemDetail : Form
    {
        public ItemDetail()
        {
            InitializeComponent();
        }
        public Prument.ORM.Products _p;
        private string[] ImagePaths=new string[255];
        private int ImageCursor;
        private int ImageMax=0;
        private EditStatus _status;
        public EditStatus Status {
            get {
                return _status;
            }
            set {
                _status = value;
            }
        }
        private void ItemDetail_Load(object sender, EventArgs e)
        {
            _p = new Prument.ORM.Products();
            ((mainForm)this.MdiParent).tsslMain.Text = "Ready";
            this.Status = EditStatus.New;
        }

        private void ItemDetail_Click(object sender, EventArgs e)
        {
            changeSaveStatus();
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            int i=0;
            string _mess = "储存成功！";
            Prument.ORM.BindOperator _bo;
            try
            {
                _p.Name = this.txbName.Text;
                _p.Description = this.txbDescription.Text;
                _p.Images.clear();
                while(i < ImageMax){
                    _p.Images.add(ImagePaths[i]);
                    i++;
                }
                if (this.Status == EditStatus.Changed)
                    _bo = Prument.ORM.BindOperator.Update;
                else
                    _bo = Prument.ORM.BindOperator.Insert;
                FileInfo _file;
                i = 0;
                while (_p.Images.Path[i] != "" && _p.Images.Path[i] != null)
                {
                    _file = new FileInfo(_p.Images.Path[i]);
                    string target = Application.StartupPath + "\\Pictures\\" + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Year.ToString() + "_" + DateTime.Now.Hour.ToString().ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString() + (new System.Random()).Next(0, 100).ToString() + _p.Images.Path[i].Substring(_p.Images.Path[i].LastIndexOf("\\") + 1, _p.Images.Path[i].Length - _p.Images.Path[i].LastIndexOf("\\") - 1);
                    _file.CopyTo(target,true);
                    _p.Images.Path[i] = target;
                    ((mainForm)this.MdiParent).tspbMain.Value = (int)Math.Floor((decimal)i * (decimal)100 / (decimal)_p.Images.Count);
                    i++;
                }
                _p.DataBind(_bo);
                ((mainForm)this.MdiParent).tspbMain.Value = 0;
                
            }
            catch (Exception ex) {
                _mess = "存储失败" + ex.Message;
            }

            MessageBox.Show(_mess);
            this.Status = EditStatus.Saved;
            changeSaveStatus();
        }

        private void txbName_Leave(object sender, EventArgs e)
        {
            if (txbName.Text.Trim() == "")
            {
                erpMain.SetError(txbName, "型号必须填写");
                changeSaveStatus();
            }
            else
            {
                erpMain.Clear();
                changeSaveStatus();
            }
        }
        public void changeSaveStatus() {
            if (this.Status == EditStatus.Saved || this.Status == EditStatus.New  || this.txbName.Text == "")
            {
                this.btnSave.Enabled=false;
                ((mainForm)this.MdiParent).iteSave.Enabled=false;
            }
            else{
                this.btnSave.Enabled=true;
                ((mainForm)this.MdiParent).iteSave.Enabled = true;
            }
            if (this.Status == EditStatus.Changed)
            {
                ((mainForm)this.MdiParent).tsslMain.Text = "Changed";
                setTitle(" * :" + this._p.ID );
            }
            if (this.Status == EditStatus.Saved)
            {
                ((mainForm)this.MdiParent).tsslMain.Text = "Saved";
                setTitle(":" + this._p.ID);
            }
            if (this.Status == EditStatus.NewChanged)
            {
                ((mainForm)this.MdiParent).tsslMain.Text = "New Item";
                setTitle(" * :" + this._p.ID);
            }
        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {
            if (this.Status != EditStatus.New && this.Status != EditStatus.NewChanged)
                this.Status = EditStatus.Changed;
            else
                this.Status = EditStatus.NewChanged;
            changeSaveStatus();
        }

        private void btnInsertImg_Click(object sender, EventArgs e)
        {
            ofdMain.ShowDialog();
            
        }

        private void ofdMain_FileOk(object sender, CancelEventArgs e)
        {
            ImagePaths[ImageMax] = ofdMain.FileName.ToString();
            ImageCursor = ImageMax;
            ImageMax++;
            if (this.Status != EditStatus.New && this.Status !=  EditStatus.NewChanged)
                this.Status = EditStatus.Changed;
            else
                this.Status = EditStatus.NewChanged;
            showPicture();
            changeSaveStatus();

        }

        private void btnOpenPic_Click(object sender, EventArgs e)
        {

            if (picProduct.IsAccessible && picProduct.ImageLocation.Trim() != "") {
                System.Diagnostics.ProcessStartInfo _psi = new System.Diagnostics.ProcessStartInfo();
                _psi.FileName="rundll32.exe";
                _psi.Arguments="C:\\WINDOWS\\System32\\shimgvw.dll,,ImageView_Fullscreen " + picProduct.ImageLocation;
                _psi.WorkingDirectory = "C:\\WINDOWS\\System32\\";
                System.Diagnostics.Process _process;
                try
                {
                    _process = System.Diagnostics.Process.Start(_psi);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
            }

        }

        private void btnNextPic_Click(object sender, EventArgs e)
        {
            if (ImagePaths != null && ImagePaths[ImageCursor] != "" && ImageCursor + 1 < ImageMax)
            {
                ImageCursor++;
                showPicture();
            }
        }
        private void showPicture() {
            picProduct.ImageLocation = ImagePaths[ImageCursor];
            lblPicStatus.Text = (ImageCursor+1).ToString() + "\\" + ImageMax.ToString();
        }

        private void btnPrevPic_Click(object sender, EventArgs e)
        {
            if (ImagePaths != null && ImagePaths[ImageCursor] != "" && ImageCursor - 1 > -1)
            {
                ImageCursor--;
                showPicture();
            }
        }

        private void txbDescription_TextChanged(object sender, EventArgs e)
        {
            if (this.Status != EditStatus.New && this.Status != EditStatus.NewChanged)
                this.Status = EditStatus.Changed;
            else
                this.Status = EditStatus.NewChanged;
            changeSaveStatus();
        }
        public void DataBind() { 
            Prument.ORM.BindOperator bo = Prument.ORM.BindOperator.Select;
            this._p.DataBind(bo);
            this.txbName.Text = _p.Name;
            this.txbDescription.Text = _p.Description;
            if (this._p.Images.Path[0] != "") {
                this.ImageCursor = 0;
                int i = 0;
                while (this._p.Images.Path[i] != "" && this._p.Images.Path[i] != null)
                {

                    i++;
                }
                this.ImageMax = i;
                this.ImagePaths = this._p.Images.Path;
                showPicture();
            }
        }
        private void setTitle(string input) { 
            this.Text="产品信息" + input;
        }

        private void ItemDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((mainForm)this.MdiParent).iteSave.Enabled = false;
        }

        private void btnDeleteImg_Click(object sender, EventArgs e)
        {
            int i;
            for (i = ImageCursor; i <= ImageMax;i++ )
            {
                ImagePaths[i] = ImagePaths[i + 1] != null && ImagePaths[i + 1] != ""?ImagePaths[i + 1]:null;
            }
            ImageMax--;
            ImageCursor = ImageCursor + 1> ImageMax ? ImageMax - 1 : ImageCursor;
            if (this.Status != EditStatus.New && this.Status != EditStatus.NewChanged)
                this.Status = EditStatus.Changed;
            else
                this.Status = EditStatus.NewChanged;
            showPicture();
            changeSaveStatus();
        }

    }
}