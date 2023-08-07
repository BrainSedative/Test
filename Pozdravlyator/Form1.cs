using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pozdra
{
    public partial class Form1 : Form
    {
        BdayPeople bdayperson = new BdayPeople();

        public Form1()
        {
            InitializeComponent();
            PopulateDataGridView();

        }

        private void PopulateDataGridView()
        {
            BdayDatabaseEntities db = new BdayDatabaseEntities();
            gridBirthdays.DataSource = db.BdayPeoples.ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BdayDatabaseEntities db = new BdayDatabaseEntities();
            bdayperson.FullName = txtName.Text;
            bdayperson.Position = txtPosition.Text;
            bdayperson.DateOfBirth = dateTimePicker1.Value;
            bdayperson.DaysUntilBirthday = dateTimePicker1.Value.DayOfYear - DateTime.Now.DayOfYear;
            if (bdayperson.DaysUntilBirthday + dateTimePicker1.Value.DayOfYear < DateTime.Now.DayOfYear)
                bdayperson.DaysUntilBirthday = dateTimePicker1.Value.DayOfYear + 365 - DateTime.Now.DayOfYear;
            db.BdayPeoples.Add(bdayperson);
            db.SaveChanges();
            MessageBox.Show("Сохранение успешно");
            PopulateDataGridView();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            BdayDatabaseEntities db = new BdayDatabaseEntities();
            var entry = db.Entry(bdayperson);
            if (entry.State == System.Data.Entity.EntityState.Detached)
                db.BdayPeoples.Attach(bdayperson);
            db.BdayPeoples.Remove(bdayperson);
            db.SaveChanges();
            PopulateDataGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BdayDatabaseEntities db = new BdayDatabaseEntities();
            bdayperson.FullName = txtName.Text;
            bdayperson.Position = txtPosition.Text;
            bdayperson.DateOfBirth = dateTimePicker1.Value;
            bdayperson.DaysUntilBirthday = dateTimePicker1.Value.DayOfYear - DateTime.Now.DayOfYear;
            if (bdayperson.DaysUntilBirthday + dateTimePicker1.Value.DayOfYear < DateTime.Now.DayOfYear)
                bdayperson.DaysUntilBirthday = dateTimePicker1.Value.DayOfYear + 365 - DateTime.Now.DayOfYear;
            db.BdayPeoples.Add(bdayperson);
            db.Entry(bdayperson).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            PopulateDataGridView();
        }

        private void gridBirthdays_DoubleClick(object sender, EventArgs e)
        {

        }

        private void gridBirthdays_Click(object sender, EventArgs e)
        {
            if (gridBirthdays.CurrentRow.Index != -1)
            {
                BdayDatabaseEntities db = new BdayDatabaseEntities();
                bdayperson.Id = (int)gridBirthdays.CurrentRow.Cells["Id"].Value;
                bdayperson = db.BdayPeoples.Where(x => x.Id == bdayperson.Id).FirstOrDefault();
                txtName.Text = bdayperson.FullName;
                txtPosition.Text = bdayperson.Position;
            }
        }




    }
}
