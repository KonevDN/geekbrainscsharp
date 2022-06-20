using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Project1
{

    [Serializable]
    public class Building
    {
        public int Floors { get; set; }
        public int Entrances { get; set; }
        public bool IsHeatable { get; set; }
        public string Address { get; set; }

        public Building()
        {
            Floors = 1;
            Entrances = 1;
        }

        public Building(int floors, int entrances)
        {
            Floors = floors;
            Entrances = entrances;
        }

        public void OpenDoor() 
        {
            Console.WriteLine("Дверь открыта");
            //Console.ReadKey();
        }



    }
}
