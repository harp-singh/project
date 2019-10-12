using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        List<student> students = new List<student>();

        List<course> courses = new List<course>();
        // adding student
        string sname;
        string sprogram;
        string stype;

        // adding course
        string sid;
        string scourse;
        string sgpa;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sname = textBox1.Text;
            sprogram = textBox2.Text;
            stype = textBox3.Text;


            student stud = new student(sname, sprogram, stype);

            students.Add(stud);
            int a = students.Count;
            label5.Text = ("total student" + a);

            stud.lookUp();

            MessageBox.Show("student added");
            Console.WriteLine("id " + sname);
            Console.WriteLine("name " + sprogram);
            Console.WriteLine("program " + stype);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sid = textBox4.Text;
            scourse = textBox5.Text;
            sgpa = textBox6.Text;


            course studcourse = new course(sid, scourse, sgpa);

            courses.Add(studcourse);

            studcourse.fetchCourse();

            MessageBox.Show("course added");
            Console.WriteLine("id " + sid);
            Console.WriteLine("course " + scourse);
            Console.WriteLine("GPA " + sgpa);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // int k = Convert.ToInt32(textBox7.Text);
            int s = 0;
            string k = textBox7.Text;
            double gpaOf = double.Parse(k);
            for (int i = 0; i < courses.Count; i++)
            {
                if (k != courses[i].Courseid)
                {
                    double cgpa = gpaOf/s;
                    if (cgpa > s)
                    {
                        MessageBox.Show("name "+ sname + "\r\n" + "gpa " + sgpa +" : pass" );
                        break;
                    }
                }
                else
                {
                    MessageBox.Show("name " + sname + "\r\n" + "gpa " + sgpa + " :fail");
                    break;
                }
            }
        }
    }
}