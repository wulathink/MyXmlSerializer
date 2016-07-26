using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlSerilizer
{
    public class ItemDaocha:ItemBase
    {
        public UInt16 DeviceID { get; set; }
        public UInt16 DeviceStatus { get; set; }
        public override void Say()
        {
            Console.WriteLine("Daocha say ");
        }
    }
}
