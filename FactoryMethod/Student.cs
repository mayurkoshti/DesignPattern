using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Student : IUserType
    {
        public string GetName()
        {
            return "Strudent";
        }
    }
}
