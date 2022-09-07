using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
using Models;

namespace Controllers
{
    public class MedicineContorller
    {
        static MedicineModel objMedicineModel = new MedicineModel();

        public static List<MedicineEntity> MedicineSelectAll()
        {
            objMedicineModel = new MedicineModel();
            return objMedicineModel.MedicineSelectAll();
        }

        public static List<MedicineEntity> MedicineSelectByMedicineID(int medicine_id)
        {
            List<MedicineEntity> all_medicine = MedicineSelectAll();
            List<MedicineEntity> selected_medicine = new List<MedicineEntity>();

            foreach (MedicineEntity medicine in all_medicine)
            {
                if (medicine.MedicineID == medicine_id)
                {
                    selected_medicine.Add(medicine);
                }
            }

            return selected_medicine;

        }
        public static MedicineEntity MedicineSelectByID(Int32 medicine_id)
        {
            objMedicineModel = new MedicineModel();
            return objMedicineModel.SelectMedicineByID(medicine_id);
        }

        public static long MedicineInsertUpdate(MedicineEntity objMedicineEntity)
        {
            objMedicineModel = new MedicineModel();
            long new_Id = objMedicineModel.InsertUpdateMedicine(objMedicineEntity);
            return new_Id;
        }
    }
}





