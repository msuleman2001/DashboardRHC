using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
using Models;

namespace Controllers
{
    public class LabTestController
    {
        static LabTestModel objLabTestModel = new LabTestModel();
        public static List<LabTestEntity> LabTestSelectAll()
        {
            objLabTestModel = new LabTestModel();
            return objLabTestModel.LabTestSelectAll();
        }

        public static List<LabTestEntity> LabTestSelectByLabTestID(int lab_TestID)
        {
            List<LabTestEntity> all_labtest = LabTestSelectAll();
            List<LabTestEntity> selected_labtest = new List<LabTestEntity>();

            foreach (LabTestEntity lab_test in all_labtest)
            {
                if (lab_test.LabTestID == lab_TestID)
                    selected_labtest.Add(lab_test);



            }
            return selected_labtest;
        }

        public static LabTestEntity LabTestSelectByID(Int32 lab_test_id)
        {
            objLabTestModel = new LabTestModel();
            return objLabTestModel.SelectLabTestByID(lab_test_id);
        }
        public static long LabTestInsertUpdate(LabTestEntity objLabTest)
        {
            objLabTestModel = new LabTestModel();
            long new_id = objLabTestModel.InsertUpdateLabTest(objLabTest);
            return new_id;

        }
    }
}



