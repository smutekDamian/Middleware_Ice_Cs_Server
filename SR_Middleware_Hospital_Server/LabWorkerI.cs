using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital;
using Ice;

namespace SR_Middleware_Hospital_Server
{
    class LabWorkerI : Hospital.LabWorkerDisp_
    {
        private List<PatientRecord> records;

        public LabWorkerI(List<PatientRecord> records)
        {
            this.records = records;
        }
        public override void addExamination(Examination examination, string patientFirstName, string patientLastName, Current current__)
        {
            foreach (PatientRecord record in records)
            {
                if (record.firstName.Equals(patientFirstName) && record.lastName.Equals(patientLastName))
                {
                    record.listOfExaminations.Add(examination);
                    return;
                }
            }
            List<Examination> listOfExams = new List<Examination>();
            listOfExams.Add(examination);
            PatientRecord addingRecord = new PatientRecord(patientFirstName, patientLastName, listOfExams);
            records.Add(addingRecord);
        }
    }
}
