using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientApp
{
    enum Group : int { O, A, B, AB };
    enum Rhesus { plus, minus };

    struct BloodGroup
    {
        public Group Group { get; private set; }
        public Rhesus Rhesus { get; private set; }

        public BloodGroup(Group _group, Rhesus _rhesus)
        {
            Group = _group;
            Rhesus = _rhesus;
        }


        public override int GetHashCode()
        {
            int g = (int)Group;
            int r = (int)Rhesus;
            
            return r * 4 + g;
        }

    }

   
}

/*
 
 */
