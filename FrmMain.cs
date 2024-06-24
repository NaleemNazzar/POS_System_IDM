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
    public partial class FrmMain : Form
    {
        static FrmMain _obj;
        public static FrmMain Instance
        {
            get { if (_obj == null) { _obj = new FrmMain(); } return _obj; }
        }
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            _obj = this;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
