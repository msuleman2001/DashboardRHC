using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Models;

namespace Controllers
{
    public class SymptomController
    {

        static SymptomModel objSymptomModel = new SymptomModel();

        public static List<SymptomEntity> SymptomSelectAll()
        {
            objSymptomModel = new SymptomModel();
            return objSymptomModel.SymptomSelectAll();
        }

        public static SymptomEntity SymptomSelectByID(long symptom_id)
        {
            List<SymptomEntity> all_symptom = SymptomSelectAll();

            foreach (SymptomEntity symptom in all_symptom)
            {
                if (symptom.SymptomID == symptom_id)
                {
                    return symptom;
                }

            }

            return null;
        }

        public static long SymptomInsertUpdate(SymptomEntity symptom)
        {
            objSymptomModel = new SymptomModel();
            long new_id = objSymptomModel.InsertUpdateSymptom(symptom);
            return new_id;
        }
    }
}





