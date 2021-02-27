using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Teacher : IUserType
    {
        public string GetName()
        {
            return "Teacher";
        }
    }
}
