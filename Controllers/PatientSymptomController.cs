using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
using Models;


namespace Controllers
{
    public class PatientSymptomController
    {
        static PatientSymptomModel objPatientSymptomModel = new PatientSymptomModel();

        public static List<PatientSymptomEntity> PatientSymptomSelectAll()
        {
            objPatientSymptomModel = new PatientSymptomModel();

            return objPatientSymptomModel.PatientSymptomSelectAll();
        }

        public static PatientSymptomEntity PatientIllnessSelectByID(int patientsymptom_id)
        {
            List<PatientSymptomEntity> all_patientsymptom = PatientSymptomSelectAll();

            foreach (PatientSymptomEntity patientsymptom_purpose in all_patientsymptom)
            {
                if (patientsymptom_purpose.PatientSymptomID == patientsymptom_id)
                    return patientsymptom_purpose;
            }
            return null;


        }

        public static long PatientSymptomInsertUpdate(PatientSymptomEntity patient_symptom)
        {
            objPatientSymptomModel = new PatientSymptomModel();
            long new_id = objPatientSymptomModel.InsertUpdatePatientSymptom(patient_symptom);
            return new_id;
        }
    }

}









