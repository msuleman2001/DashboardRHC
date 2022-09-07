using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
using Models;

namespace Controllers
{
    public class PatientMedicineController
    {
        static PatientMedicineModel objPatientMedicineModel = new PatientMedicineModel();
        public static List<PatientMedicineEntity> PatientMedicineSelectAll()
        {
            objPatientMedicineModel = new PatientMedicineModel();
            return objPatientMedicineModel.PatientMedicineSelectAll();
        }

        public static PatientMedicineEntity PatientMedicineSelectByID(int patient_medicine_id)
        {
            List<PatientMedicineEntity> all_patient_Medicine = PatientMedicineSelectAll();

            foreach (PatientMedicineEntity patient_medicine in all_patient_Medicine)
                return patient_medicine;

            return null;
        }

        public static long PatientMedicineInsertUpdate(PatientMedicineEntity patient_medicine)
        {
            objPatientMedicineModel = new PatientMedicineModel();
            long new_Id = objPatientMedicineModel.InsertUpdatePatientMedicine(patient_medicine);
            return new_Id;
        }

        public static List<PatientMedicineEntity> GetPatientMedcineByPatientID(long patient_id)
        {
            List<PatientMedicineEntity> all_patient_medicine = PatientMedicineSelectAll();
            List<PatientMedicineEntity> patient_medicine = all_patient_medicine.FindAll(p => p.PatientID == patient_id);
            return patient_medicine;
        }
    }
}





