using System;
using System.Collections;
using System.Collections.Generic;

using Entities;
using Models;

namespace Controllers
{
	public class StaffObservationController
	{
		static StaffObservationModel objStaffObservationModel = new StaffObservationModel();
		public static List<StaffObservationEntity> StaffObservationSelectAll()
		{
			objStaffObservationModel = new StaffObservationModel();
			return objStaffObservationModel.StaffObservationSelectAll();
		}

		public static StaffObservationEntity StaffObservationSelectByID(Int32 staff_observation_id)
		{
			objStaffObservationModel = new StaffObservationModel();
			return objStaffObservationModel.SelectStaffObservationByID(staff_observation_id);
		}

		public static Int64 InsertUpdateStaffObservation(StaffObservationEntity objStaffObservation)
		{
			objStaffObservationModel = new StaffObservationModel();
			Int64 new_id = objStaffObservationModel.InsertUpdateStaffObservation(objStaffObservation);
			return new_id;
		}

		public static List<StaffObservationEntity> GetPatientObservationHistory(long patient_id)
		{
			List<StaffObservationEntity> all_observation = StaffObservationSelectAll();
			List<StaffObservationEntity> patient_history = all_observation.FindAll(po => po.PatientID == patient_id);
			return patient_history;
		}
	}
}

