using adatbázis_UI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adatbázis_UI
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
            listBox1.DisplayMember = "Name";
        }
        StudiesContext context = new StudiesContext();
        private void heha()
        {
            listBox1.DataSource = (from i in context.Courses
                                   where i.Name.Contains(textBox1.Text)
                                   select i).ToList();
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {
            var ilist = from i in context.Courses
                        select i;
            listBox1.DataSource = ilist.ToList();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            heha();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Course selectedCourse = (Course)listBox1.SelectedItem;

            var kurzus = from l in context.Lessons
                          where l.InstructorFk == selectedCourse.CourseSk
                          select new
                          {
                              Nap = l.DayFkNavigation.Name,
                              Sáv = l.TimeFkNavigation.Name,
                              Oktató = l.InstructorFkNavigation.Name
                          };
            dataGridView1.DataSource = kurzus.ToList();
        }
    }
}
