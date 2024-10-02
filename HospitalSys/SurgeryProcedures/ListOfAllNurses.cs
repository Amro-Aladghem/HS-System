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
    public partial class ListOfAllNurses : Form
    {
        public delegate void AfterChoosingNurse(int NurseID);
        public AfterChoosingNurse AfterChoosingDataBack;

        private void _Load()
        {
            dataGridView1.DataSource = clsSurgery.GetAllSurgerNurseInSys();
        }

        public ListOfAllNurses()
        {
            InitializeComponent();
        }

        private void ListOfAllNurses_Load(object sender, EventArgs e)
        {
            _Load();
        }

        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int NurseID =(int)dataGridView1.CurrentRow.Cells[0].Value;
            AfterChoosingDataBack?.Invoke(NurseID);
            this.Close();
            
        }
    }
}
