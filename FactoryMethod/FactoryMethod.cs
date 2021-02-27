using System;

namespace Factory
{
    class FactoryMethod
    {
        public static IUserType GetObject(string TypeClass)
        {
            IUserType ob = null;
            if (TypeClass == "S")
            {
                ob = new Student();
            }
            else if (TypeClass == "T")
            {
                ob = new Teacher();
            }
            else {
                ob = null;
            }
            return ob;
        }
    }
}
