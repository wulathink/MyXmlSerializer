using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerilizer
{
    public class SingleCar
    {
        public bool IsHead { get; set; }
        public UInt16 CarID { get; set; }
    }
    public class ItemTrainSet:ItemBase
    {
        public UInt16 TrainSetID { get; set; }
        private List<SingleCar> _cars = new List<SingleCar>();
        [XmlElement(ElementName = "Cars")]
        public List<SingleCar> Cars {
            get { return _cars; }
            set { _cars = value; }
        } 
    }
}
