using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System
{
    public partial class SampleView : Form
    {
        private bool isCleared = false;

        public SampleView()
        {
            InitializeComponent();
        }

        public virtual void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!isCleared)
            {
                TxtSearch.Clear();
                PictureBox1.Hide();
                isCleared = true;
            }
        }

        public virtual void BtnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
