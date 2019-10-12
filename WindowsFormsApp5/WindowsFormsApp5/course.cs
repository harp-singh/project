using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class course
    {
        //for course
        string studentid;
        string courseid;
        string sgpa;

        //3. constructor
        public course(string sid, string cid, string gpa)
        {

            this.studentid = sid;
            this.courseid = cid;
            this.sgpa = gpa;
        }
        //4 method
        public void fetchCourse()
        {
            Console.WriteLine("Name" + this.studentid +
                "program" + this.courseid + "type" + this.sgpa);
        }


        //getting course
        public string Studentid
        {
            get
            {
                return this.studentid;
            }
        }
        public string Courseid
        {
            get
            {
                return this.courseid;
            }
        }
        public string Gpa
        {
            get
            {
                return this.sgpa;
            }
        }
    }
}
