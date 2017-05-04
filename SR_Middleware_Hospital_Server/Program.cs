using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ice.Instrumentation;
using Ice;
using Hospital;

namespace SR_Middleware_Hospital_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            int status = 0;
            Ice.Communicator communicator = null;

            try
            {
                // 1. Inicjalizacja ICE - utworzenie communicatora
                communicator = Ice.Util.initialize(ref args);


                //2. Konfiguracja adaptera
                // METODA 2 (niepolecana, dopuszczalna testowo): Konfiguracja adaptera Adapter1 jest w kodzie źródłowym
                Ice.ObjectAdapter adapter = communicator.createObjectAdapterWithEndpoints("Adapter1", "tcp -h localhost -p 10000:udp -h localhost -p 10000");


                // 3. Stworzenie serwanta/serwantów
                List<PatientRecord> records = makeTestsRecords();

                DoctorI doctor = new DoctorI(records);
                LabWorkerI labWorker = new LabWorkerI(records);
                PatientI patient = new PatientI(records);

                // 4. Dodanie wpisów do tablicy ASM
                adapter.add(patient, new Identity("patient", "hospital"));
                adapter.add(doctor, new Identity("doctor", "hospital"));
                adapter.add(labWorker, new Identity("labWorker", "hospital"));

                // 5. Aktywacja adaptera i przejście w pętlę przetwarzania żądań
                adapter.activate();

                Console.Write("Entering event processing loop...");

                communicator.waitForShutdown();

            }
            catch (System.Exception e)
            {
                Console.Write(e);
                status = 1;
            }
            if (communicator != null)
            {
                // Clean up
                //
                try
                {
                    communicator.destroy();
                }
                catch (System.Exception e)
                {
                    Console.Write(e);
                    status = 1;
                }
            }
            Environment.Exit(status);
        }
        private static List<PatientRecord> makeTestsRecords()
        {
            string[] firstNames =
            {
                "John","Daniel","Jacob","Peter","Edward","Angelina","Helena","Julia","James","David"
            };
            string[] lastNames =
            {
                "Bale","Pitt","Kowalsky","Norton","Hardy","May","Clarcskon","Hamiltion","Bukowsky","Obama"
            };
            string[] parametersNames =
            {
                "ALT","AST","Cholesterol","HDL","LDL","CRP","WBC","RBC","MCV", "MHCD"
            };
            double[] parametersValue =
            {
                4.60, 13, 19, 107, 85.2, 33.5, 12.2, 36.4, 85.2, 12
            };
            string[] groupsNames =
            {
                "Biochemic", "Immunochemics", "Analitics", "Hematology"
            };
            Random rnd = new Random();
            List<PatientRecord> records = new List<PatientRecord>();
            for (int i = 0; i < 100; i++)
            {
                List<Examination> examinations = new List<Examination>();
                string lastName = lastNames[rnd.Next(0, 9)];
                for (int j = 0; j < 3; j++)
                {
                    List<Group> groups = new List<Group>();
                    for (int k = 0; k < 4; k++)
                    {
                        List<Parameter> parameters = new List<Parameter>();
                        for (int l= 0; l < 10; l++)
                        {                           
                            parameters.Add(new Parameter(parametersNames[rnd.Next(0,9)], parametersValue[rnd.Next(0, 9)]));
                        }                        
                        
                        groups.Add(new Group(groupsNames[rnd.Next(0, 3)], parameters));
                    }                                        
                    examinations.Add(new Examination(lastName, "02.05.2017", lastNames[rnd.Next(0, 9)], groups));
                }                            
                records.Add(new PatientRecord(firstNames[rnd.Next(0,9)], lastName, examinations));
            }
                

            return records;
        }
    }
}

