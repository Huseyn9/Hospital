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
    public partial class DeleteForm : Form
    {
        HospitalEntities1 db = new HospitalEntities1();
        private Patient SelectdPatient;
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            fillData();
        }
        private void fillData()
        {
            dataGridView1.Rows.Clear();
            int i = 0;
            List<Patient> PatientList = db.Patients.ToList();
            foreach (Patient item in PatientList)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = item.id;
                dataGridView1.Rows[i].Cells[1].Value = item.account_number;
                dataGridView1.Rows[i].Cells[2].Value = item.old_file_number;
                dataGridView1.Rows[i].Cells[3].Value = item.Title.title_name;
                dataGridView1.Rows[i].Cells[4].Value = item.first_name;
                dataGridView1.Rows[i].Cells[5].Value = item.middle_name;
                dataGridView1.Rows[i].Cells[6].Value = item.surname;
                dataGridView1.Rows[i].Cells[7].Value = item.date_of_birth;
                dataGridView1.Rows[i].Cells[8].Value = item.Material_Status;
                i++;
            }
        }

        private void Delete(object sender, DataGridViewCellMouseEventArgs e)
        {
            int no = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            SelectdPatient = db.Patients.Find(no);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.Patients.Remove(SelectdPatient);
            db.SaveChanges();
            fillData();
        }
    }
}
