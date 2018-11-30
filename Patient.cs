using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientApp
{
    class Patient
    {
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public DateTime birthDay { get; private set; }
        public BloodGroup bloodGroup { get; private set; }

        public Patient(string _firstName, string _lastName, DateTime _birthDay, BloodGroup _blooodGroup)
        {
            firstName = _firstName;
            lastName = _lastName;
            birthDay = _birthDay;
            bloodGroup = _blooodGroup;
        }
    }
}
