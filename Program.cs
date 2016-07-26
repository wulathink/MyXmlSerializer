using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlSerilizer
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/
            Frame frame = new Frame();
            frame.FrameId = 1;

            ItemDaocha item1 = new ItemDaocha();
            item1.ItemID = 100;
            item1.PosX = 0.5f;
            item1.DeviceID = 1000;
            item1.DeviceStatus = 0x100;
            frame.ItemList.Add(item1);

            ItemLight item2 = new ItemLight();
            item2.ItemID = 101;
            item2.PosX = 2.5f;
            item2.DeviceID = 1002;
            item2.lightColor = EnumLightColor.green;
            frame.ItemList.Add(item2);

            ItemTrainSet item3 = new ItemTrainSet();
            item3.ItemID = 102;
            item3.PosX = 3.5f;
            item3.TrainSetID = 1003;
            SingleCar s1 =new SingleCar();
            s1.CarID = 0x9501;
            s1.IsHead = true;
            SingleCar s2 = new SingleCar();
            s2.CarID = 0x9502;
            s2.IsHead = false;
            SingleCar s3 = new SingleCar();
            s3.CarID = 0x9503;
            s3.IsHead = false;
            item3.Cars.Add(s1);
            item3.Cars.Add(s2);
            item3.Cars.Add(s3);
            frame.ItemList.Add(item3);
            //写入
            XmlSerializer writer = new XmlSerializer(typeof(Frame));
            FileStream file = System.IO.File.Create(@"D:\333.xml");
            writer.Serialize(file, frame);
            file.Close();
            //读取
            FileStream fileRead = new FileStream(@"D:\333.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xmlSearializer = new XmlSerializer(typeof(Frame));
            Frame f = (Frame)xmlSearializer.Deserialize(fileRead);
            fileRead.Close();
        }
    }
}
