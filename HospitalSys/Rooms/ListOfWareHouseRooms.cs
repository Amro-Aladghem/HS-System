using clsBusineesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSys.Rooms
{
    public partial class ListOfWareHouseRooms : Form
    {
        public ListOfWareHouseRooms()
        {
            InitializeComponent();
        }

        private DataTable _LoadData()
        {
            DataTable dt = new DataTable();

            dt = clsHSInformation.GetWareHouseRooms();

            return dt;
        }


        private void ListOfWareHouseRooms_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                var data = _LoadData();

                this.Invoke((Action)(() =>
                {
                    dataGridView1.DataSource = data;
                    lbRecords.Text = dataGridView1.RowCount.ToString();
                }));

            });
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
