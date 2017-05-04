using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital;
using Ice;

namespace SR_Middleware_Hospital_Server
{
    class DoctorI : Hospital.DoctorDisp_
    {
        private List<PatientRecord> records;
        public DoctorI(List<PatientRecord> records)
        {
            this.records = records;
        }

        public override PatientRecord getRecord(string patientFirstName, string patientLastName, Current current__)
        {
            foreach (PatientRecord record in records)
            {
                if (record.firstName.Equals(patientFirstName) && record.lastName.Equals(patientLastName))
                {
                    return record;
                }
            }
            return null;
        }

        public override List<PatientRecord> getRecords(Current current__)
        {
            return records;
        }

        public override List<PatientRecord> MVCMoreThanFifty(Current current__)
        {
            Console.WriteLine("MVC more than fifty");
            List<PatientRecord> result = new List<PatientRecord>();
            foreach(PatientRecord record in records)
            {
                foreach(Examination ex in record.listOfExaminations)
                {
                    foreach(Group gr in ex.listOfGroups)
                    {
                        foreach(Parameter p in gr.listOfParams)
                        {
                            if(p.name.Equals("MCV") && p.value > 50)
                            {
                                result.Add(record);
                                Console.WriteLine("ADDED");                              
                            }
                        }
                    }
                }
            }
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("END");
            return result;
        }
    }
}
