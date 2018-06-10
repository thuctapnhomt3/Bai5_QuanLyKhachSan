using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyKhachSan.Layout
{
    public partial class QLPhong : UserControl
    {
        public QLPhong()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-QRUJQ92;Initial Catalog=QLKS;User ID=sa;Password=0975381329");
        SqlDataAdapter adapt;
        SqlCommand cmdDV;
        private void btthemdichvu_Click(object sender, EventArgs e)
        {
            SubLayout.FormThemDichVuPhong ftdvp =new  SubLayout.FormThemDichVuPhong();
            ftdvp.ShowDialog();
            DisplayData();
        }

        public void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from dbo.[phong]", con);
            adapt.Fill(dt);
            bunifuCustomDataGrid1.DataSource = dt;
            con.Close();
        }

        private void QLPhong_Load(object sender, EventArgs e)
        {
            DisplayData();
        }
    }
}
