using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using kütüphaneOtomasyonu.DAL;
using kütüphaneOtomasyonu.Entites;

namespace kütüphaneOtomasyonu
{
    public partial class frmKatmanlıMimari : Form
    {
      

        public frmKatmanlıMimari()
        {
            InitializeComponent();
        }

       viewPersonelBirimiDAL vpbdal = new viewPersonelBirimiDAL();
       BirimDAL bdal = new BirimDAL();
       Personeller p = new Personeller();//veri kaynagı

        PersonelDAL pdal = new PersonelDAL();
        private ModelPersonelEntity db = new ModelPersonelEntity();

        void ClearDataBinding()
        {
            foreach ( Control item in this.Controls)
            {
                item.DataBindings.Clear();
            }
        }
        void Data_Binding(Personeller person)//person1
       {
           ClearDataBinding();
            this.p = person;

            txtPersonelID.DataBindings.Add("Text",p,"PersonelID");
            txtAdıSoyadı.DataBindings.Add("Text", p, "AdıSoyadı");
           mtxtTelefon.DataBindings.Add("Text", p, "Telefon");

            txtAdres.DataBindings.Add("Text", p, "Adress");

            txtEMail.DataBindings.Add("Text", p, "Email");

            cmbBirimi.DataBindings.Add("SelectedValue", p, "BirimID",true);

            dateTimePicker1.DataBindings.Add("Text", p, "Tarih", true);

            checkBox1.DataBindings.Add("CheckState", p, "IsActive",true);



        }

        public void yenile()
        {
           dataGridView1.DataSource = vpbdal.GetList();
           // dataGridView1.DataSource = pdal.PersonelleriGetir(db,x => x.AdıSoyadı.Contains(txtAra.Text) || x.Telefon.Contains(txtAra.Text) || x.Email.Contains(txtAra.Text) || x.Adress.Contains(txtAra.Text));


            cmbBirimi.DataSource = bdal.GetList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            yenile();
            Data_Binding(new Personeller());
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = vpbdal.GetList(x => x.AdıSoyadı.Contains(txtAra.Text) || x.Telefon.Contains(txtAra.Text) || x.Email.Contains(txtAra.Text) || x.Adress.Contains(txtAra.Text));

            dataGridView1.DataSource = pdal.PersonelleriGetir(db,x => x.AdıSoyadı.Contains(txtAra.Text) || x.Telefon.Contains(txtAra.Text) || x.Email.Contains(txtAra.Text) || x.Adress.Contains(txtAra.Text));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int personelid = int.Parse(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString());
            Data_Binding(pdal.GetByFilter(x => x.PersonelID == personelid));
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            Data_Binding(new Personeller());
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            pdal.@AddorUpdate(p); //ekleme ve güncelleme işlemi
            pdal.Save();
            yenile();
            Data_Binding(new Personeller());
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int personelid = int.Parse(dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString());
            pdal.Delete(p=>p.PersonelID==personelid);
            pdal.Save();
            yenile();
            Data_Binding(new Personeller());
        }
    }
}
