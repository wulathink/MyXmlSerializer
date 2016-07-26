using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerilizer
{
    [XmlInclude(typeof(ItemDaocha)), 
    XmlInclude(typeof(ItemLight)),
    XmlInclude(typeof(ItemTrainSet)),]
    public class Frame
    {
        private List<ItemBase> _itemList = new List<ItemBase>();
        public int FrameId { get; set; }

        [XmlElement(ElementName = "ItemList")]
        public List<ItemBase> ItemList
        {
            get { return _itemList; }
            set { _itemList = value; }
        }
    }
}
