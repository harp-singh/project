using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    //name
    class student
    {   //2. variable

        string name;
        string program;
        string type;

        //3. constructor
        public student(string n, string p, string t)
        {

            this.name = n;
            this.program = p;
            this.type = t;
        }
        //4 method
        public void lookUp()
        {
            Console.WriteLine("Name" + this.name +
                "program" + this.program + "type" + this.type);
        }
        //getter setter method

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        public string programs
        {
            get
            {
                return this.program;
            }
        }
        public string types
        {
            get
            {
                return this.type;
            }
        }

    }
}
