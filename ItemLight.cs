using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlSerilizer
{
    public enum EnumLightColor { red =0,green,}
    public class ItemLight:ItemBase
    {
        public EnumLightColor lightColor { get; set; }
        public UInt16 DeviceID { get; set; }
        public override void Say()
        {
            Console.WriteLine("light say ");
        }
    }
}
