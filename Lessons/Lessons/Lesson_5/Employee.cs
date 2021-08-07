using System;
using System.Collections.Generic;
using System.Text;

namespace Lessons.Lesson_5
{
    [Serializable]
    class Employee
    {
        public string FIO { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public decimal Salary  { get; set; }
        public DateTime BirthDate { get; set; }

        public Employee(string fio, string role, string email, string tel, decimal salary, DateTime birthDate)
        {
            FIO = fio;
            Role = role;
            Email = email;
            Tel = tel;
            Salary = salary;
            BirthDate = birthDate;
        }

        public void GetDetails()
        {
            Console.WriteLine($"FIO: {FIO}, Role: {Role}, Email: {Email}, Tel: {Tel}, Salary: {Salary}, Age {CalcualteAge(BirthDate)}");
        }

        public int CalcualteAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age)) 
                age--;

            return age;
        }

     

    }
}
