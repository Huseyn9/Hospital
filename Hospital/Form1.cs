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
    public partial class hospital : Form
    {
        HospitalEntities1 db = new HospitalEntities1();
        public hospital()
        {
            InitializeComponent();
        }

        private void hospital_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Titles)
            {
                this.p_title.Items.Add(item.title_name);
            }
            foreach (var item in db.Religions)
            {
                this.p_religion.Items.Add(item.religion_name);
            }
            foreach (var item in db.Occupations)
            {
                this.p_occupation.Items.Add(item.occupation_name);
            }
            foreach (var item in db.Existing_Account)
            {
                this.a_existing_account.Items.Add(item.existing_account_name);

            }
            foreach (var item in db.Card_Type)
            {
                this.a_card_type.Items.Add(item.card_type_name);
            }
            foreach (var item in db.State_of_Origin)
            {
                this.n_state.Items.Add(item.state_of_origin_name);
            }
            foreach (var item in db.State_of_Origin)
            {
                this.p_state.Items.Add(item.state_of_origin_name);
            }
            foreach (var item in db.Patient_Category)
            {
                this.a_pattient_category.Items.Add(item.patient_category_name);
            }
            foreach (var item in db.Material_Status)
            {
                this.p_material.Items.Add(item.materil_name);
            }
        }

        private void btn_Add_pattient_Click(object sender, EventArgs e)
        {     
            Patient patient = new Patient();
            int Title_id = db.Titles.FirstOrDefault(t => t.title_name == p_title.Text).id;
            int Card_Type_id = db.Card_Type.FirstOrDefault(t => t.card_type_name == a_card_type.Text).id;
            int patinet_category_id = db.Patient_Category.FirstOrDefault(t => t.patient_category_name == a_pattient_category.Text).id;
            int Existing_Account_id = db.Existing_Account.FirstOrDefault(t => t.existing_account_name == a_existing_account.Text).id;
            int Religion_id = db.Religions.FirstOrDefault(t => t.religion_name == p_religion.Text).id;
            int Occupation_id = db.Occupations.FirstOrDefault(t => t.occupation_name == p_occupation.Text).id;
            int State_of_Origin = db.State_of_Origin.FirstOrDefault(t => t.state_of_origin_name == p_state.Text).id;
            int Material_id = db.Material_Status.FirstOrDefault(t => t.materil_name == p_material.Text).id;
            patient.title_id = Title_id;
            patient.card_type_id = Card_Type_id;
            patient.patient_category_id = patinet_category_id;
            patient.existing_account_id = Existing_Account_id;
            patient.religion_id = Religion_id;
            patient.occupation_id = Occupation_id;
            patient.state_of_origin_id = State_of_Origin;
            patient.material_id = Material_id;
            patient.first_name = this.p_firstname.Text;
            patient.middle_name = this.p_middlename.Text;
            patient.surname = this.p_surname.Text;
            patient.gender_type = radioButton1.Checked;
            patient.gender_type = radioButton2.Checked;
            patient.date_of_birth = p_date.Value;
            patient.tribe = this.p_tribe.Text;
            patient.permanent_adress = this.c_permanent.Text;
            patient.home_adress = this.c_home_address.Text;
            patient.photo = "TestPhoto";
            patient.family_id = 1;
            patient.old_file_number = Convert.ToInt32(a_old_file.Text);
            patient.account_number = Convert.ToInt32(textBox11.Text);

            db.Patients.Add(patient);
            db.SaveChanges();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgwForm dgw = new dgwForm();
            dgw.ShowDialog();
            this.Hide();
        }
    }
}
