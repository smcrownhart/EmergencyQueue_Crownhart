using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmergencyQueue_Crownhart
{
    internal class EmergencyPatients
    {
        private string _name;
        

        public EmergencyPatients(string name)
        {
            _name = name;

        }

        

        public override string ToString()
        {

            return _name;
        }

       
    }
}
