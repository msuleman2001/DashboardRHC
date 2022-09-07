using System;
using System.Collections;
using System.Collections.Generic;

using Entities;
using Models;

namespace Controllers
{
	public class StaffRHCController
	{
		static StaffRHCModel objStaffRHCModel = new StaffRHCModel();
		public static List<StaffRHCEntity> StaffRHCSelectAll()
		{
			objStaffRHCModel = new StaffRHCModel();
			return objStaffRHCModel.StaffRHCSelectAll();
		}

		public static StaffRHCEntity StaffRHCSelectByID(Int32 staff_id)
		{
			objStaffRHCModel = new StaffRHCModel();
			return objStaffRHCModel.SelectStaffRHCByID(staff_id);
		}

		public static Int64 InsertUpdateStaffRHC(StaffRHCEntity objStaffRHC)
		{
			objStaffRHCModel = new StaffRHCModel();
			Int64 new_id = objStaffRHCModel.InsertUpdateStaffRHC(objStaffRHC);
			return new_id;
		}
	}
}

