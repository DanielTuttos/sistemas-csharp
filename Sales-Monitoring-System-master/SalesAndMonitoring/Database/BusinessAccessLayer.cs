using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesAndMonitoring.Database
{
    public class BusinessAccessLayer
    {
        private static Database.SalesAndMonitoringEntities _entity;

        public static SalesAndMonitoringEntities GetEntity()
        {
            return _entity ?? (_entity = new SalesAndMonitoringEntities());
        }
    }
}
