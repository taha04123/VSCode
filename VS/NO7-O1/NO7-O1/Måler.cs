using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NO7_O1
{
    class Måler 
    {
        int sensorID;
        int posX;
        int posY;

        public int SensorID { get => sensorID; set => sensorID = value; }
        public int PosX { get => posX; set => posX = value; }
        public int PosY { get => posY; set => posY = value; }

        public Måler(int sensorID, int posX, int posY)
        {
            this.sensorID = sensorID;
            this.posX = posX;
            this.posY = posY;
        }

        public string Skrivut()
        {
            return string.Format ($"({sensorID} - ({posX},{posY}))");
        }

        public override string ToString()
        {
            return Skrivut();
        }
    }
}
