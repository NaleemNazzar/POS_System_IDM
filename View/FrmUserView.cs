using POS_System.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.View
{
    public partial class FrmUserView : Form
    {
        private bool isCleared = false;

        public FrmUserView()
        {
            InitializeComponent();
        }

        public virtual void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            TxtSearch.ForeColor = Color.Black;
            LoadData();

            if (!isCleared)
            {
                TxtSearch.Clear();
                PictureBox1.Hide();
                isCleared = true;
            }
        }

        private void FrmUserView_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public virtual void BtnAdd_Click(object sender, EventArgs e)
        {
            MainClass.BlurBackground(new FrmUserAdd());
            LoadData();
        }

        private void LoadData()
        {
            ListBox lb = new ListBox();
            lb.Items.AddRange(new object[] { Dgvid, Dgvname, DgvuserName, Dgvpass, Dgvphone });

            try
            {
                string qry = TxtSearch.Text == "      Search Here" ?
                    "SELECT userID, uName, uUsername, uPass, uPhone FROM users" :
                    $"SELECT userID, uName, uUsername, uPass, uPhone FROM users WHERE uName LIKE '%{TxtSearch.Text}%' ORDER BY userID DESC";

                MainClass.LoadData(qry, DataGridView1, lb);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView1.CurrentCell.OwningColumn.Name == "DgvEdit")
            {
                EditUser();
            }
            else if (DataGridView1.CurrentCell.OwningColumn.Name == "DgvDel")
            {
                DeleteUser();
            }
        }

        private void EditUser()
        {
            FrmUserAdd frm = new FrmUserAdd();
            frm.id = Convert.ToInt32(DataGridView1.CurrentRow.Cells["Dgvid"].Value);
            frm.TxtName.Text = Convert.ToString(DataGridView1.CurrentRow.Cells["Dgvname"].Value);
            frm.TxtUser.Text = Convert.ToString(DataGridView1.CurrentRow.Cells["DgvuserName"].Value);
            frm.TxtPass.Text = Convert.ToString(DataGridView1.CurrentRow.Cells["Dgvpass"].Value);
            frm.TxtPhone.Text = Convert.ToString(DataGridView1.CurrentRow.Cells["Dgvphone"].Value);

            MainClass.BlurBackground(frm);
            LoadData();
        }

        private void DeleteUser()
        {
            int id = Convert.ToInt32(DataGridView1.CurrentRow.Cells["Dgvid"].Value);
            string qry = $"DELETE FROM users WHERE userID = {id}";
            Hashtable ht = new Hashtable();

            if (MainClass.SQL(qry, ht) > 0)
            {
                MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
        }

        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
