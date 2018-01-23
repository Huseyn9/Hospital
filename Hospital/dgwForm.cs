using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class dgwForm : Form
    {
        HospitalEntities1 db = new HospitalEntities1();
        public dgwForm()
        {
            InitializeComponent();
        }

        private void dgwForm_Load(object sender, EventArgs e)
        {
            fillData();
        }
        private void fillData()
        {
            dataGridView1.Rows.Clear();
            int i=0;
            List<Patient> PatientList = db.Patients.ToList();
            foreach (Patient item in PatientList)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = item.account_number;
                dataGridView1.Rows[i].Cells[1].Value = item.old_file_number;
                dataGridView1.Rows[i].Cells[2].Value = item.Title.title_name;
                dataGridView1.Rows[i].Cells[3].Value = item.first_name;
                dataGridView1.Rows[i].Cells[4].Value = item.middle_name;
                dataGridView1.Rows[i].Cells[5].Value = item.surname;
                dataGridView1.Rows[i].Cells[6].Value = item.date_of_birth;
                dataGridView1.Rows[i].Cells[7].Value = item.Material_Status;
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteForm del = new DeleteForm();
            del.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateForm upd = new UpdateForm();
            upd.ShowDialog();
        }
    }
}
