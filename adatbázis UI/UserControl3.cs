using adatbázis_UI.Models;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adatbázis_UI
{
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
            listBox1.DisplayMember = "Name";
        }
        StudiesContext context = new StudiesContext();
        string adat;
        private void UserControl3_Load(object sender, EventArgs e)
        {
            var ilist = from i in context.Instructors
                        select i;
            listBox1.DataSource = ilist.ToList();

            adat = ilist.ToString();
        }
        private void heha()
        {
            listBox1.DataSource = (from i in context.Instructors
                                   where i.Name.Contains(textBox1.Text)
                                   select i).ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            heha();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Instructor selectedInstructor = (Instructor)listBox1.SelectedItem;

            var lessons = from l in context.Lessons
                          where l.InstructorFk == selectedInstructor.InstructorSk
                          select new
                          {
                              Kurzus = l.CourseFkNavigation.Name,
                              Nap = l.DayFkNavigation.Name,
                              Sáv = l.TimeFkNavigation.Name
                          };
            dataGridView1.DataSource = lessons.ToList();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("tanarok.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                // Write records to the CSV file
                csv.WriteRecords(adat);
            };
        }
    }
}
