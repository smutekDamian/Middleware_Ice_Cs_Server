
#ifndef HOSPITAL_ICE
#define HOSPITAL_ICE

module Hospital
{
    class Parameter {
        string name;
        double value;
    };


    ["clr:generic:List"] sequence<Parameter> ListOfParameters;
    class Group {
    	string name;
        ListOfParameters listOfParams;
    };
    ["clr:generic:List"] sequence<Group> ListOfGroups;
    class Examination {
        string patientName;
        string date;
        string doctorName;
        ListOfGroups listOfGroups;
    };
    ["clr:generic:List"] sequence<Examination> ListOfExaminations;
    class PatientRecord {
        string firstName;
        string lastName;
        ListOfExaminations listOfExaminations;
    };
    ["clr:generic:List"] sequence<PatientRecord> records;
  interface LabWorker
  {
    void addExamination(Examination examination, string patientFirstName, string patientLastName);
  };
  interface Patient{
    PatientRecord getRecord( string patientFirstName, string patientLastName);
  };
  interface Doctor{
    records getRecords();
    PatientRecord getRecord( string patientFirstName, string patientLastName);
    records MVCMoreThanFifty();
  };

};

#endif
