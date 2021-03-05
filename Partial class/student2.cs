using System;
using System.Collections.Generic;
using System.Text;

namespace lambda
{
    public partial class StudentPartial
    {
        private string fname;
        private string lname;

        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
    }
}
