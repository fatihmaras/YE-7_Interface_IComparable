using System;

namespace OOP_7_Interface_IComparable
{
    public class Employee : IComparable
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(object obj)   //Implemented edildi 
        {
            var other = (Employee)obj;    // CompareTo  methodundaki obejcti Employee olarak cast işlemi uyguladık.

            if (this.Salary < other.Salary)
            {
                return -1;
            }
            else if (this.Salary.Equals(other.Salary))
            {
                return 0;
            }
            else
            {
                return 1;

            }
        }
        public override string ToString()
        {
            return $"{Id,-5}{FullName,-25}{Salary,-7}";

        }
    }
}
