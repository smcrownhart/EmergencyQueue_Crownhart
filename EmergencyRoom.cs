using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmergencyQueue_Crownhart
{
    internal class EmergencyRoom
    {
        private PriorityQueue<EmergencyPatients, int> patientqueue;
        

        public int Priority { get; set; }

        

        public EmergencyRoom()
        {
            patientqueue = new PriorityQueue<EmergencyPatients, int>();
        }

        public void Enqueue(EmergencyPatients pname, int Priority)
        {
            patientqueue.Enqueue(pname, Priority);
        }

        

        
        public void ECount()
        {
            Console.WriteLine("There are " + patientqueue.Count + " in the queue.");
        }

        public EmergencyPatients Dequeue()
        {
            return patientqueue.Dequeue();
        }

       

        public EmergencyPatients[] patientsNames()
        {
            

            EmergencyPatients[] names = new EmergencyPatients[patientqueue.Count];
            for(int i = 0; i < names.Length; i++)
            {

                names [i] = patientqueue.Dequeue();
            }

            foreach (EmergencyPatients pname in names)
            {
                patientqueue.Enqueue(pname, Priority);
            }

            foreach (EmergencyPatients pnames in names)
            {
                Console.WriteLine(pnames);
            }
            return names;
            
        }


        public EmergencyPatients[] removeNames()
        {
            
            

            List<EmergencyPatients> p = new List<EmergencyPatients>();
            
            EmergencyPatients[] updated = new EmergencyPatients[patientqueue.Count];
            if (patientqueue.Count == 0)
            {
                Console.WriteLine("The Queue is Empty");
                return updated;
            }

            string delete = patientqueue.Dequeue().ToString();
            

            
                for (int i = 0; i < updated.Length; i++)
                {
                    for (int j = 0; j < p.Count; j++)
                    {

                        updated[i] = patientqueue.Dequeue();
                        if (delete != null)
                        {
                            updated[i].ToString().Equals(delete);
                            p.RemoveAt(i);

                        }
                    }
                }
            
                updated = p.ToArray();
                foreach (EmergencyPatients pname in updated)
                {
                    patientqueue.Enqueue(pname, Priority);

                }

            return updated;
        }
    }
}
