
using System.Collections.Generic;
using Igloo.Clinic.Domain;
using Igloo.Clinic.Services.Interfaces;

namespace Igloo.Clinic.Services.Impl
{
    public class PatientService : IPatientService
    {
        public IList<Patient> RetrievePatients(Doctor doctor)
        {
            IList<Patient> patients = new List<Patient>();

            if (doctor.Name == "no")
            {
                Patient patient = new Patient();
                patient.Name = "James Bond";
                patient.Address = "Jamaica";
                patients.Add(patient);

                patient = new Patient();
                patient.Name = "Felix Leiter";
                patient.Address = "New York";
                patients.Add(patient);

                patient = new Patient();
                patient.Name = "Miss Moneypenny";
                patient.Address = "London";
                patients.Add(patient);
            }

            return patients;
        }
    }
}
