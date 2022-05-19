using System;

namespace day05
{
    class employees : IComparable
    {
        int id;
        int securityLevel;
        int salary;
        HiringDate hiredate;
        GENDER gender;

        public int ID
        {
            set { id = value; }
            get { return id; }
        }

        public int SecurityLevel
        {
            set { securityLevel = value; }
            get { return securityLevel; }
        }

        public int Salary
        {
            set { salary = value; }
            get { return salary; }
        }


        public GENDER Gender
        {
            set { gender = value; }
            get { return gender; }
        }

        public HiringDate HireDate
        {
            set { hiredate = value; }
            get { return hiredate; }
        }
         
        public int CompareTo(object obj)
        {
            employees rhs = (employees)obj;
            if (hiredate.Year > rhs.hiredate.Year)
            {
                return 1;
            }
            else if (hiredate.Year < rhs.hiredate.Year)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return $"( {ID} , {securityLevel} , {salary:C} , {hiredate.ToString()} , {Gender})";
        }

        
        

    }
}
