using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital;
using Ice;

namespace SR_Middleware_Hospital_Server
{
    class PatientI : Hospital.PatientDisp_
    {
        private List<PatientRecord> records;
        public PatientI(List<PatientRecord> records)
        {
            this.records = records;
        }
        public override PatientRecord getRecord(string patientFirstName, string patientLastName, Current current__)
        {
            foreach(PatientRecord record in records)
            {
                if(record.firstName.Equals(patientFirstName) && record.lastName.Equals(patientLastName))
                {
                    return record;
                }
            }
            return null;
        }
    }
}
