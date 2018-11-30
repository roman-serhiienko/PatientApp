using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientApp
{
    class Program
    {

        static void Main(string[] args)
        {
            BloodGroup bgOm = new BloodGroup(Group.O, Rhesus.minus);
            BloodGroup bgOp = new BloodGroup(Group.O, Rhesus.plus);
            BloodGroup bgAm = new BloodGroup(Group.A, Rhesus.minus);
            BloodGroup bgAp = new BloodGroup(Group.A, Rhesus.plus);
            BloodGroup bgBm = new BloodGroup(Group.B, Rhesus.minus);
            BloodGroup bgBp = new BloodGroup(Group.B, Rhesus.plus);
            BloodGroup bgABm = new BloodGroup(Group.AB, Rhesus.minus);
            BloodGroup bgABp = new BloodGroup(Group.AB, Rhesus.plus);

            Dictionary<BloodGroup, List<BloodGroup>> AcceptableBloodGroupTypes = new Dictionary<BloodGroup, List<BloodGroup>>();
            AcceptableBloodGroupTypes.Add(bgOm, (new List<BloodGroup> { bgOm }));
            AcceptableBloodGroupTypes.Add(bgOp, (new List<BloodGroup> { bgOm, bgOp }));
            AcceptableBloodGroupTypes.Add(bgAm, (new List<BloodGroup> { bgOm, bgAm }));
            AcceptableBloodGroupTypes.Add(bgAp, (new List<BloodGroup> { bgOm, bgOp, bgAm, bgAp }));
            AcceptableBloodGroupTypes.Add(bgBm, (new List<BloodGroup> { bgOm, bgBm }));
            AcceptableBloodGroupTypes.Add(bgBp, (new List<BloodGroup> { bgOm, bgOp, bgBm, bgBp }));
            AcceptableBloodGroupTypes.Add(bgABm, (new List<BloodGroup> { bgOm, bgBm, bgAm, bgABm }));
            AcceptableBloodGroupTypes.Add(bgABp, (new List<BloodGroup> { bgOm, bgBm, bgAm, bgABm, bgOp, bgBp, bgAp, bgABp }));

            string  AcceptableBloodTypes(BloodGroup bg)
            {
                List<BloodGroup> bloodList = AcceptableBloodGroupTypes[bg];
                string stringList = "";
                foreach (BloodGroup item in bloodList)
                {
                    string rSign = (item.Rhesus == Rhesus.minus) ? "-" : "+";
                    stringList += (item.Group.ToString() + rSign + ", ");
                }
                stringList = stringList.Remove(stringList.Length - 2);
                return stringList;
            }

            List<Patient> patientList = new List<Patient>();
            patientList.Add(new Patient("John", "Smith", Convert.ToDateTime("01/10/1991"), bgAm));
            patientList.Add(new Patient("Joe", "Scott", Convert.ToDateTime("02/10/1992"), bgABm));
            patientList.Add(new Patient("Jonah", "Weakh", Convert.ToDateTime("03/10/1993"), bgBp));
            patientList.Add(new Patient("Jack", "Pig", Convert.ToDateTime("04/10/1994"), bgAp));
            patientList.Add(new Patient("Jim", "Pigly", Convert.ToDateTime("05/10/1995"), bgABm));

            foreach(Patient patient in patientList)
            {
                Console.WriteLine("Patient {0} {1}, born on {2 : MM/dd/yyyy}, acceptable blood groups: {3}", 
                    patient.firstName, 
                    patient.lastName, 
                    patient.birthDay,
                   AcceptableBloodTypes(patient.bloodGroup)  );
            }
            Console.ReadLine();


        }
    }
}
