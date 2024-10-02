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

namespace HospitalSys.SurgeryProcedures
{
    public partial class ListOfAllSurgeryDoctorcs : Form
    {
        public ListOfAllSurgeryDoctorcs()
        {
            InitializeComponent();
        }

        public delegate void AfterChoosingDocotor(int DoctorID);
        public AfterChoosingDocotor AfterChoosingDocotorDataBack;

        private void _Load()
        {
            dataGridView1.DataSource = clsSurgery.GetAllSurgeryDoctorsInSys();
        }

        private void ListOfAllSurgeryDoctorcs_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DoctorID = (int)dataGridView1.CurrentRow.Cells[0].Value;
            AfterChoosingDocotorDataBack?.Invoke(DoctorID);
            this.Close();
        }
    }
}
