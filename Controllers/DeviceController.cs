using System;
using System.Collections;
using System.Collections.Generic;

using Entities;
using Models;

namespace Controllers
{
	public class DeviceController
	{
		static DeviceModel objDeviceModel = new DeviceModel();
		public static List<DeviceEntity> DeviceSelectAll()
		{
			objDeviceModel = new DeviceModel();
			return objDeviceModel.DeviceSelectAll();
		}

		public static DeviceEntity DeviceSelectByID(long device_id)
		{
			objDeviceModel = new DeviceModel();
			return objDeviceModel.SelectDeviceByID(device_id);
		}

		public static long InsertUpdateDevice(DeviceEntity objDevice)
		{
			objDeviceModel = new DeviceModel();
			long new_id = objDeviceModel.InsertUpdateDevice(objDevice);
			return new_id;
		}
	}
}

