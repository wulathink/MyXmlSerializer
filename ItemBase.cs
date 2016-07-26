using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerilizer
{
    public class ItemBase
    {

        public int ItemID { get; set; }
        public float PosX { get; set; }
        public virtual byte[] GetBytes()
        {
            return null;
        }

        public virtual void Say()
        {
        }
    }
}
