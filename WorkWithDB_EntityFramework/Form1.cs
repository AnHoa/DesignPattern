using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkWithDB_EntityFramework
{
    public partial class Form1 : Form
    {
        private ModelVLXD1 entities = new ModelVLXD1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.NHANVIENs.Select(nv => new
            {
                nv.TEN,
                nv.MANHANVIEN,
                nv.EMAIL
            }).ToList();

            SqlParameter mnv = new SqlParameter("MANHANVIEN", "NV00000002");
            SqlParameter pass = new SqlParameter("PASS", "123");
            bool res = entities.Database.SqlQuery<bool>("select dbo.CHECK_NHANVIEN(@MANHANVIEN, @PASS)", new object[]{
                mnv,
                pass
            }).SingleOrDefault();
            
            MessageBox.Show(res.ToString());
            //NHANVIEN nv1 = entities.NHANVIENs.Where(nv => nv.MANHANVIEN.Equals("NV00000001")).FirstOrDefault();
            //MessageBox.Show(nv1.HOADONBANHANGs.Where(ha => ha.MANHANVIEN.Equals("NV00000001")).FirstOrDefault().SOHOADON.ToString());
        }
    }
}
