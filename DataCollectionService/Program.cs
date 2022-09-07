using System;
using System.Diagnostics;
using System.Data;
using System.Data.OleDb;
using Topshelf;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCollectionService
{
    public static class DataCollectionService 
    {
        public static void Main(string[] args)
        {
            TopshelfExitCode exit_code = HostFactory.Run(x =>
            {

                x.Service<PatientDataCollector>(patient_service => {
                    patient_service.ConstructUsing(data_collector => new PatientDataCollector());
                    patient_service.WhenStarted(data_collector => data_collector.Start());
                    patient_service.WhenStopped(data_collector => data_collector.Stop());
                });

                x.RunAsLocalSystem();
                x.SetServiceName("Data Collector");
                x.SetDisplayName("Data Collector");
            });

            int int_exit_code = (int)Convert.ChangeType(exit_code, exit_code.GetTypeCode());
            Environment.ExitCode = int_exit_code;
        }
    }
}
