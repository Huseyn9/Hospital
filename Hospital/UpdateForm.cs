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
    public partial class UpdateForm : Form
    {
        HospitalEntities1 db = new HospitalEntities1();
        private Patient SelectdPatient;
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
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

        private void Update(object sender, DataGridViewCellMouseEventArgs e)
        {
            int no = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            SelectdPatient = db.Patients.Find(no);
            p_title.Text = SelectdPatient.Title.title_name;
            textBox11.Text = SelectdPatient.account_number.ToString();
            a_old_file.Text = SelectdPatient.old_file_number.ToString();
            p_firstname.Text = SelectdPatient.first_name;
            p_middlename.Text = SelectdPatient.first_name;
            p_surname.Text = SelectdPatient.surname;
            p_date.Text = SelectdPatient.date_of_birth.ToString();
            p_material.Text = SelectdPatient.Material_Status.materil_name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectdPatient.account_number = Convert.ToInt32(textBox11.Text);
            SelectdPatient.old_file_number = Convert.ToInt32(a_old_file.Text);
            int Title_id = db.Titles.FirstOrDefault(t => t.title_name == p_title.Text).id;
            SelectdPatient.title_id = Title_id;
            SelectdPatient.first_name = this.p_firstname.Text;
            SelectdPatient.middle_name = this.p_middlename.Text;
            SelectdPatient.surname = this.p_surname.Text;
            SelectdPatient.date_of_birth = p_date.Value;
            int Material_id = db.Material_Status.FirstOrDefault(t => t.materil_name == p_material.Text).id;
            SelectdPatient.material_id = Material_id;
            db.SaveChanges();
            fillData();  
        }
    }
}
