using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=LAPTOP-QM7MFAI0;Initial Catalog=QLNS;Integrated Security=True;");
            con.Open();
            Hienthi();
        }

        //Hàm hiển thị
        public void Hienthi()
        {
            string sqlSelect = "SELECT *FROM NhanSu ";
            SqlCommand command = new SqlCommand(sqlSelect, con);
            SqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgvNhanSu.DataSource = dt;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
             con.Close();
        }

        //Hien thi du lieu len Datagridview
        private void dgvNhanSu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //txtID.ReadOnly = true;
            int i;
            i = dgvNhanSu.CurrentRow.Index;
            txtID.Text = dgvNhanSu.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dgvNhanSu.Rows[i].Cells[1].Value.ToString();
            cbGioiTinh.Text = dgvNhanSu.Rows[i].Cells[2].Value.ToString();
            dtpNS.Text = dgvNhanSu.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dgvNhanSu.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = dgvNhanSu.Rows[i].Cells[5].Value.ToString();
            txtPhone.Text = dgvNhanSu.Rows[i].Cells[6].Value.ToString();
        }

        //Chuc nang them
        private void btAdd_Click(object sender, EventArgs e)
        {
            string sqlAdd = "INSERT INTO NhanSu VALUES (@ID,@HoTen,@GioiTinh,@NgaySinh,@Email,@DiaChi,@DienThoai)";
            SqlCommand command = new SqlCommand(sqlAdd, con);
            command.CommandText = sqlAdd;
            command.Parameters.AddWithValue("ID", txtID.Text);
            command.Parameters.AddWithValue("HoTen", txtTen.Text);
            command.Parameters.AddWithValue("GioiTinh", cbGioiTinh.Text);
            command.Parameters.AddWithValue("NgaySinh",dtpNS.Text);
            command.Parameters.AddWithValue("Email", txtEmail.Text);
            command.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            command.Parameters.AddWithValue("DienThoai", txtPhone.Text);
            MessageBox.Show("Thêm mới nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            command.ExecuteNonQuery();
            Hienthi();
        }

        //Chuc nang xoa
        private void btDel_Click(object sender, EventArgs e)
        {
            string sqlDel = "DELETE NhanSu WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sqlDel, con);
            command.CommandText = sqlDel;
            command.Parameters.AddWithValue("ID", txtID.Text);
            command.Parameters.AddWithValue("HoTen", txtTen.Text);
            command.Parameters.AddWithValue("GioiTinh", cbGioiTinh.Text);
            command.Parameters.AddWithValue("NgaySinh", dtpNS.Text);
            command.Parameters.AddWithValue("Email", txtEmail.Text);
            command.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            command.Parameters.AddWithValue("DienThoai", txtPhone.Text);
            MessageBox.Show("Xóa nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            command.ExecuteNonQuery();
            Hienthi();
        }

        //Chuc nang sua
        private void btUp_Click(object sender, EventArgs e)
        {
            string sqlUp = "UPDATE NhanSu SET HoTen = @HoTen, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, Email = @Email, DiaChi = @DiaChi, DienThoai = @DienThoai WHERE ID = @ID";
            SqlCommand command = new SqlCommand(sqlUp, con);
            command.CommandText = sqlUp;
            command.Parameters.AddWithValue("ID", txtID.Text);
            command.Parameters.AddWithValue("HoTen", txtTen.Text);
            command.Parameters.AddWithValue("GioiTinh", cbGioiTinh.Text);
            command.Parameters.AddWithValue("NgaySinh", dtpNS.Text);
            command.Parameters.AddWithValue("Email", txtEmail.Text);
            command.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
            command.Parameters.AddWithValue("DienThoai", txtPhone.Text);
            MessageBox.Show("Cập nhật nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            command.ExecuteNonQuery();
            Hienthi();
        }

        //Chuc nang thoat
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Chuc nang sap xep theo ID và Ho ten
        private void cbSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSapXep.SelectedIndex == 0)
            {
                this.dgvNhanSu.Sort(this.dgvNhanSu.Columns["ID"], ListSortDirection.Ascending);
            }
            else
            {
                this.dgvNhanSu.Sort(this.dgvNhanSu.Columns["HoTen"], ListSortDirection.Ascending);
            }
        }
        
        //Chuc nang tim kiem theo chu cai 
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string rowFilter = string.Format("{0} like '{1}'", "HoTen", "*" + txtSearch.Text + "*");
            (dgvNhanSu.DataSource as DataTable).DefaultView.RowFilter = rowFilter;
        }

    }
}
