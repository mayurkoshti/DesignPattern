using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Student : IUserType
    {
        public string GetName()
        {
            return "Strudent";
        }
    }
}
