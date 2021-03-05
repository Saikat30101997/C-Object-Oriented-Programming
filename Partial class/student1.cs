using System;
using System.Collections.Generic;
using System.Text;

namespace lambda
{
     public partial class StudentPartial
    {
       public StudentPartial(string f,string l)
        {
            fname = f;
            lname = l;
        }
        public void fullname()
        {
            Console.WriteLine(fname+" "+lname);
        }
    }
}
