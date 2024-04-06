using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CNNET
{
    public partial class frmCategory : Form
    {
        //khai báo xâu kế nối
        private string conStr = @"Data Source=NEYAQUAN\HONGQUAN;Initial Catalog=BOOKRENTALS;Integrated Security=True";
        //khai báo đối tượng kết nối
        SqlConnection mysqlcon;
        //khai báo đối tượng sqlcommmand truy vấn, cậpn nhật, sửa , xoá
        SqlCommand mysqlcmd;
        //khai báo biến kiểm tra xem có chọn nút thêm mới hay là sửa
        private bool addnew;
        //khai báo biến kiểm tra xem có sửa categryname hay không
        private string Oldcategoryname;
        public frmCategory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void display()
        {
            //định nghĩa xâu SQL
            string Ssql = "select * from Categories";
            //tạo đốt tượn truy vấn
            mysqlcmd = new SqlCommand(Ssql, mysqlcon);
            //truy vấn dữ liệu
            SqlDataReader drcategory = mysqlcmd.ExecuteReader();
            //để hiển thị dữ liệu lên lưới thì ta cần hiển thị dữ liệu lên datatable
            DataTable dt = new DataTable();
            dt.Load(drcategory);

            //hiên thị lên lưới
            dgvCategory.DataSource = dt;
            drcategory.Close();
            
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            //kết nối tới database

            mysqlcon = new SqlConnection(conStr);
            mysqlcon.Open();

            display();
            //thiết lập trạng  thái
            setenable(false);


        }
        private void setenable(bool check)
        {
            txtCategoryName.Enabled = check;
            txtDescription.Enabled = check;
            btnAddNew.Enabled = !check;
            BtnSua.Enabled = !check;
            btnDelete.Enabled = !check;
            btnGhi.Enabled = check;
            btnCancel.Enabled = check;
        }

        private void dgvCategory_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //lấy dòng đang chọn
            int r = e.RowIndex;
            //chuyển dữ liệu từ của dòng đan chọn sang textbox
            txtCategoryName.Text = dgvCategory.Rows[r].Cells[1].Value.ToString();
            txtDescription.Text = dgvCategory.Rows[r].Cells[2].Value.ToString();

            //lưu lại categoryname trước khi sửa
            Oldcategoryname = txtCategoryName.Text;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            addnew = false;
            // thiêt lập trạng thái
            setenable(true);
            //chuyên con trỏ về lại txtcategory
            txtCategoryName.Focus();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //thiết lập trạng thái 
            setenable(false);
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            //kiểm tra dữ liệu nhập 
            if(txtCategoryName.Text.Trim().Length == 0)
            {
                MessageBox.Show("tên loại sách không được để trống!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategoryName.Focus();
                return;
            }
            if(txtCategoryName.Text.Trim().Length >50)
            {
                MessageBox.Show("tên sách quá dài (<=50 kí tự)", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategoryName.Focus();
                return;
            }
            if(txtDescription.Text.Trim().Length > 250)
            {
                MessageBox.Show("chú thích không được quá dài (<=250 kí tự)!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescription.Focus();
                return;
            }

            //kiểm tra nhấp mới hoặc sửa trùng tên sách đó
            
            if((addnew == true) || (addnew == false) && txtDescription.Text != Oldcategoryname)
            {
                //truy vấn kiểm tra dữl liệu trùng
                string Ssql = "select * from Categories where CategoryName = N'" + txtCategoryName.Text + "' ";
                mysqlcmd = new SqlCommand(Ssql, mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader drsearch = mysqlcmd.ExecuteReader();

                if(drsearch.HasRows)
                {
                    MessageBox.Show("Tên loại sách bị trùng!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCategoryName.Focus();
                    drsearch.Close();
                    return;
                }
                drsearch.Close();
            }
            if(addnew == true)
            {
              
                //thêm mới
                //định nghĩa câu sql
                string Ssql = "insert into Categories values(N'" + txtCategoryName.Text + "', N'" + txtDescription.Text + "')";
                mysqlcmd = new SqlCommand(Ssql, mysqlcon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                //thưc hiện lênh
                
                mysqlcmd.ExecuteNonQuery();
                mysqlcon.Close();
               
            }
            else
            {
                //sửa dữ liệu
                //lấy dòng hiện tại
                int r = dgvCategory.CurrentRow.Index;
                //lấy mã CategoryID
                string CategoryID = dgvCategory.Rows[r].Cells[0].Value.ToString();
                //định nghĩa câu lệnh sql
                string Ssql = "Update Categories set CategoryName = N'"+ txtCategoryName.Text + ", Description = N'" + txtDescription.Text + "' where CategoryID= " + CategoryID;
                //tạo đối tượng sqlcomman
                mysqlcmd = new SqlCommand(Ssql, mysqlcon);
                //thực hiện lệnh
                mysqlcmd.ExecuteNonQuery();
            }
            //hiện thị lại dữ liệu lên lưới
            display();
            //thiết lập lại trạng thái
            setenable(false);
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            addnew = true;
            //thiết lập trạng thái
            setenable(true);
            txtCategoryName.Text = "";
            txtDescription.Text = "";

            //chuyển con trỏ về txtcategorynam
            txtCategoryName.Focus();    
        }

        private void btnExits_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
