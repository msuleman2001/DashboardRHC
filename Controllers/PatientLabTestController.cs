using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
using Models;

namespace Controllers
{
    public class PatientLabTestController
    {
        static PatientLabTestModel objPatientLabTestModel = new PatientLabTestModel();
        public static List<PatientLabTestEntity> PatientLabTestSelectAll()
        {
            objPatientLabTestModel = new PatientLabTestModel();
            return objPatientLabTestModel.PatientLabTestSelectAll();
        }

        public static List<PatientLabTestEntity> PatientLabTestSelectByLabTestID(int lab_TestID)
        {
            List<PatientLabTestEntity> all_labtest = PatientLabTestSelectAll();
            List<PatientLabTestEntity> selected_labtest = new List<PatientLabTestEntity>();

            foreach (PatientLabTestEntity lab_test in all_labtest)
            {
                if (lab_test.PatientLabTestID == lab_TestID)
                    selected_labtest.Add(lab_test);



            }
            return selected_labtest;
        }

        public static PatientLabTestEntity PatientLabTestSelectByID(Int32 lab_test_id)
        {
            objPatientLabTestModel = new PatientLabTestModel();
            return objPatientLabTestModel.SelectPatientLabTestByID(lab_test_id);
        }
        public static long PatientLabTestInsertUpdate(PatientLabTestEntity objPatientLabTest)
        {
            objPatientLabTestModel = new PatientLabTestModel();
            long new_id = objPatientLabTestModel.InsertUpdatePatientLabTest(objPatientLabTest);
            return new_id;
        }

        public static List<PatientLabTestEntity> PatientLabTestByPatientID(long patient_id)
        {
            List<PatientLabTestEntity> all_patient_labtest = PatientLabTestSelectAll();
            List<PatientLabTestEntity> patient_labtest = all_patient_labtest.FindAll(pl => pl.PatientID == patient_id);
            return patient_labtest;
        }
    }
}





