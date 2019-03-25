using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCV
{
    public partial class Form1 : Form
    {
        private CongViecEntities cv = new CongViecEntities();
        Congviec congViec = new Congviec();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            clear();
            data();
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            string NgayTao = dateNgaytao.Value.ToString("yyyy-MM-dd");
            string NgayHT = dateNgayht.Value.ToString("yyyy-MM-dd");
            if (txtMaCV.Text != "") congViec.MaCV = int.Parse(txtMaCV.Text);
            if (txtTenCV.Text!= "") congViec.TenCV = txtTenCV.Text.Trim() ;
            if (txtNguoitao.Text !="") congViec.Nguoitao = txtNguoitao.Text.Trim();
            if (txtNguoith.Text!="") congViec.Nguoithuchien = txtNguoith.Text.Trim();
            congViec.Ngaytao = DateTime.Parse(NgayTao);
            congViec.Ngayhoanthanh = DateTime.Parse(NgayHT);
            cv.Congviecs.AddOrUpdate(congViec);//add
            cv.SaveChanges();

            MessageBox.Show("Saved sucessfully");
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                //get key
                int rowId = Convert.ToInt32(row.Cells[0].Value);

                //avoid updating the last empty row in datagrid
                if (rowId > 0)
                {
                    //delete 
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
            }
            data();

        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm?","",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                var entry = cv.Entry(congViec);
                if (entry.State == EntityState.Detached)
                    cv.Congviecs.Attach(congViec);
                cv.Congviecs.Remove(congViec);
                cv.SaveChanges();
                data();
                clear();
                MessageBox.Show("Deleted");
            }
            
        }
        private void data()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = cv.Congviecs.ToList<Congviec>();

        }
        void clear()
        {
            if (txtMaCV != null)
            {
                txtMaCV.Clear();
            }
            txtTenCV.Clear();
            txtNguoitao.Clear();
            txtNguoith.Clear();
            data();
            bttnSave.Text = "Save";
            congViec.MaCV = 0;
            bttnDelete.Enabled = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                congViec.MaCV = Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaCV"].Value);
                congViec = cv.Congviecs.Where(x => x.MaCV == congViec.MaCV).FirstOrDefault();
                string NgayTao = dateNgaytao.Value.ToString("yyyy-MM-dd");
                string NgayHT = dateNgayht.Value.ToString("yyyy-MM-dd");
                if (txtMaCV.Text != "") congViec.MaCV = int.Parse(txtMaCV.Text);
                if (txtTenCV.Text != "") congViec.TenCV = txtTenCV.Text.Trim();
                if (txtNguoitao.Text != "") congViec.Nguoitao = txtNguoitao.Text.Trim();
                if (txtNguoith.Text != "") congViec.Nguoithuchien = txtNguoith.Text.Trim();
                congViec.Ngaytao = DateTime.Parse(NgayTao);
                congViec.Ngayhoanthanh = DateTime.Parse(NgayHT);
            }
            bttnSave.Text = "Update";
            bttnDelete.Enabled = true;
        }
        private void bttnSearch_Click(object sender, EventArgs e)
        {
            bool flag = cv.Congviecs.Where(x => x.TenCV == txtSearch.Text).Any();

            if (flag)
            {
                List<Congviec> tbl = cv.Congviecs.Where(x => x.TenCV == txtSearch.Text).ToList();
                dataGridView1.DataSource = tbl;
            }
            else
            {
                MessageBox.Show("This record does not exist in the database.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}