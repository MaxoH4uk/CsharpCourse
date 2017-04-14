using System;
using System.Collections.Generic;

namespace HomeWork7
{
    public class Employee : Human
    {
        private bool IsBusy { get; set; }
        public uint PersonnelNumber { get; set; }
        public uint AccessLevel { get; set; }

        public Employee(string name, string surname, uint personnelNumber, uint accessLevel) 
            : base(name, surname)
        {
            this.PersonnelNumber = personnelNumber;
            this.AccessLevel = accessLevel;
        }
    }
}
