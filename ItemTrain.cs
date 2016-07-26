using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlSerilizer
{
    class ItemTrain:ItemBase
    {
        public UInt16 TrainSetID { get; set; }
        public UInt16 DeviceStatus { get; set; }
    }
}
