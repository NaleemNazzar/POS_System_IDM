using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_System.Model
{
    public partial class UcProuct : UserControl
    {
        public string Barcode { get; set; }

        public event EventHandler onSelect = null;
        public UcProuct()
        {
            InitializeComponent();
        }

        private void TxtPic_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }
        public int id { get; set; }
        public string PCost { get; set; }

        public string PName
        {
            get { return LblPName.Text; }
            set { LblPName.Text = value; }
        }

        public string Price
        {
            get { return LblPrice.Text; }
            set { LblPrice.Text = value; }
        }

        public Image PImage
        {
            get { return TxtPic.Image; }
            set { TxtPic.Image = value; }
        }
    }
}
