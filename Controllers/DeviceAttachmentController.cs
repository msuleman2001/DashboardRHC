using System;
using System.Collections;
using System.Collections.Generic;

using Entities;
using Models;

namespace Controllers
{
	public class DeviceAttachmentController
	{
		static DeviceAttachmentModel objDeviceAttachmentModel = new DeviceAttachmentModel();

		public static List<DeviceAttachmentEntity> DeviceAttachmentSelectAll()
		{
			objDeviceAttachmentModel = new DeviceAttachmentModel();
			return objDeviceAttachmentModel.DeviceAttachmentSelectAll();
		}

		public static DeviceAttachmentEntity DeviceAttachmentSelectByID(Int32 device_attachment_id)
		{
			objDeviceAttachmentModel = new DeviceAttachmentModel();
			return objDeviceAttachmentModel.SelectDeviceAttachmentByID(device_attachment_id);
		}

		public static long InsertUpdateDeviceAttachment(DeviceAttachmentEntity objDeviceAttachment)
		{
			objDeviceAttachmentModel = new DeviceAttachmentModel();
			Int64 new_id = objDeviceAttachmentModel.InsertUpdateDeviceAttachment(objDeviceAttachment);
			return new_id;
		}

		public static long GetAttachedDevice(long device_id)
		{
			try
			{
				List<DeviceAttachmentEntity> attached_devices = DeviceAttachmentSelectAll();
				DeviceAttachmentEntity attached_device = attached_devices.Find(d => d.DeviceID == device_id);
				if (attached_device == null)
					return 0;
				return attached_device.DeviceAttachmentID;
			}
			catch (NullReferenceException ex)
			{
				return 0;
			}

		}

		public static long DeleteDeviceAttachmentByID(long device_attachment_id)
		{
			objDeviceAttachmentModel = new DeviceAttachmentModel();
			return objDeviceAttachmentModel.DeleteDeviceAttachmentByID(device_attachment_id);
		}
	}
}

