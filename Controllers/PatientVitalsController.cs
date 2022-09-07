using System;
using System.Collections;
using System.Collections.Generic;

using Entities;
using Models;

namespace Controllers
{
    public class PatientVitalsController
    {
        static PatientVitalsModel patient_vitals_model = new PatientVitalsModel();

        public static List<PatientVitalsEntity> PatientVitalsSelectAll()
        {
            return patient_vitals_model.PatientVitalsSelectAll();
        }

        public static PatientVitalsEntity SelectPatientVitalsByID(long patient_vital_i_d)
        {
            return patient_vitals_model.SelectPatientVitalsByID(patient_vital_i_d);
        }

        public static long InsertUpdatePatientVitals(PatientVitalsEntity patient_vitals)
        {
            return patient_vitals_model.InsertUpdatePatientVitals(patient_vitals);
        }

        public static long DeletePatientVitalsByID(long patient_vital_i_d)
        {
            return patient_vitals_model.DeletePatientVitalsByID(patient_vital_i_d);
        }

        public static List<PatientVitalsEntity> GetPatientVitals(long patient_id)
        {
            List<PatientVitalsEntity> all_patient_vitals = PatientVitalsSelectAll();
            List<PatientVitalsEntity> visit_patient_vitals = all_patient_vitals.FindAll(p => p.PatientID == patient_id);
            if (visit_patient_vitals.Count > 0)
                return visit_patient_vitals;
            else
                return null;
        }
    }
}

