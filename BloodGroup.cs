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
        public Group group;
        public Rhesus rhesus;
        
        public BloodGroup(Group _group, Rhesus _rhesus)
        {
            group = _group;
            rhesus = _rhesus;
        }


        public override int GetHashCode()
        {
            int g = (int)group;
            int r = (int)rhesus;
            
            return r * 4 + g;
        }

    }

   
}

/*
 
 */
