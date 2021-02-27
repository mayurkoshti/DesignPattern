using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Teacher : IUserType
    {
        public string GetName()
        {
            return "Teacher";
        }
    }
}
