using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

using Entities;
using Models;

namespace Controllers
{
	public class CenterAdminController
	{
		static CenterAdminModel objCenterAdminModel = new CenterAdminModel();

		public static long CenterAdminLogin(string admin_name, string admin_password)
		{
			string encrypted_password = EncryptPassword(admin_password);
			List<CenterAdminEntity> all_admins = CenterAdminSelectAll();
			if (all_admins.Count > 0)
			{
				foreach (CenterAdminEntity admin in all_admins)
					if (admin.AdminName == admin_name)
					{
						if (admin.AdminPassword == encrypted_password)
							return admin.AdminID;
						return -3; // User exist but password error.
					}
				return -2;   // Required user does not exist. 
			}
			return -1;  // No user exist table empty.
		}

		public static long ChangeAdminPassword(long admin_id, string old_password, string new_password)
		{
			CenterAdminEntity admin = CenterAdminSelectByID(admin_id);
			string old_encrypted_password = EncryptPassword(old_password);
			//string new_encrypted_password = EncryptPassword(new_password);	

			if (admin != null)
			{
				if (old_encrypted_password == admin.AdminPassword)
				{
					admin.AdminPassword = new_password;
					InsertUpdateCenterAdmin(admin);
					return admin_id;
				}
				else
					return -1; //old password is not matching
			}
			else
				return -2; //amdin not founded
		}

		public static string EncryptPassword(string plain_password)
		{
			MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
			byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(plain_password));
			string encrypted_password = Convert.ToBase64String(data);
			return encrypted_password;
		}

		public static List<CenterAdminEntity> CenterAdminSelectAll()
		{
			objCenterAdminModel = new CenterAdminModel();
			return objCenterAdminModel.CenterAdminSelectAll();
		}

		public static CenterAdminEntity CenterAdminSelectByID(long admin_id)
		{
			objCenterAdminModel = new CenterAdminModel();
			return objCenterAdminModel.SelectCenterAdminByID(admin_id);
		}

		public static long InsertUpdateCenterAdmin(CenterAdminEntity objCenterAdmin)
		{
			objCenterAdmin.AdminPassword = EncryptPassword(objCenterAdmin.AdminPassword);
			objCenterAdminModel = new CenterAdminModel();
			Int64 new_admin_id = objCenterAdminModel.InsertUpdateCenterAdmin(objCenterAdmin);
			return new_admin_id;
		}
	}
}
