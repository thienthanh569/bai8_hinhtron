using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai8_hinhtron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btTinh_Click(object sender, EventArgs e)
        {
            double dai= Int32.Parse(txtChieuDai.Text);
            double rong = Int32.Parse(txtChieuRong.Text);
            double dientich,chuvi = 0;

            chuvi = dai * 3.14 ;
            dientich = Math.Pow(dai, 2) * 3.14;

            txtChuVi.Text=chuvi.ToString();
            txtDienTich.Text=dientich.ToString();


        }

        private void txtDienTich_TextChanged(object sender, EventArgs e)
        {

        }
    }  
}
