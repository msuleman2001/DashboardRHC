using System;
using System.Collections;
using System.Collections.Generic;

using Entities;
using Models;

namespace Controllers
{
	public class AdminLogController
	{
		static AdminLogModel objAdminLogModel = new AdminLogModel();
		public static List<AdminLogEntity> AdminLogSelectAll()
		{
			objAdminLogModel = new AdminLogModel();
			return objAdminLogModel.AdminLogSelectAll();
		}

		public static List<AdminLogEntity> SelectAdminLogByAdminID(int admin_id)
		{
			List<AdminLogEntity> all_admin_logs = AdminLogSelectAll();
			List<AdminLogEntity> selected_admin_log = new List<AdminLogEntity>();

			foreach (AdminLogEntity admin_log in all_admin_logs)
			{
				if (admin_log.AdminID == admin_id)
					selected_admin_log.Add(admin_log);
			}

			return selected_admin_log;

		}


		public static AdminLogEntity AdminLogSelectByID(long admin_log_id)
		{
			objAdminLogModel = new AdminLogModel();

			return objAdminLogModel.SelectAdminLogByID(admin_log_id);
		}

		public static long InsertUpdateAdminLog(AdminLogEntity objAdminLog)
		{
			objAdminLogModel = new AdminLogModel();
			long new_id = objAdminLogModel.InsertUpdateAdminLog(objAdminLog);
			return new_id;
		}
	}
}
