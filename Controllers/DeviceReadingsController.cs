using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
using Models;

namespace Controllers
{
	public class DeviceReadingsController
	{
		static DeviceReadingsModel objDeviceReadingModel = new DeviceReadingsModel();
		public static List<DeviceReadingsEntity> DeviceReadingSelectAll()
		{
			objDeviceReadingModel = new DeviceReadingsModel();
			return objDeviceReadingModel.DeviceReadingsSelectAll();
		}

		public static DeviceReadingsEntity DeviceReadingSelectByID(long device_reading)
		{
			objDeviceReadingModel = new DeviceReadingsModel();
			return objDeviceReadingModel.SelectDeviceReadingsByID(device_reading);
		}

		public static long DeviceReadingInsertUpdate(DeviceReadingsEntity objDeviceReadings)
		{
			objDeviceReadingModel = new DeviceReadingsModel();
			long new_id = objDeviceReadingModel.InsertUpdateDeviceReadings(objDeviceReadings);
			return new_id;
		}

		public static DeviceReadingsEntity GetLatestPatientReading(long patient_id)
		{
			List<DeviceReadingsEntity> all_readings = DeviceReadingSelectAll();
			List<DeviceReadingsEntity> patient_readings = all_readings.FindAll(reading => reading.PatientID == patient_id);
			List<DeviceReadingsEntity> sorted = patient_readings.OrderByDescending(r => r.CreatedDateTime).ToList();
			if (sorted.Count > 0)
				return sorted[0];
			else
				return null;

		}
	}
}



