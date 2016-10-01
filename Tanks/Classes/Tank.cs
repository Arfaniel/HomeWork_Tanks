using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading;

namespace Tanks.Classes
{
    class Tank
    {
        private string _name;
        private int armor;
        private int ammo;
        private int manuvr;
        public Tank(string name)
        {
            _name = name;
            Random r = new Random();
            armor = r.Next(1, 100);
            ammo = r.Next(1, 100);
            manuvr = r.Next(1, 100);
            Thread.Sleep(29);
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Armor
        {
            get
            {
                return armor;
            }
        }
        public int Ammo
        {
            get
            {
                return ammo;
            }
        }
        public int Manuvr
        {
            get
            {
                return manuvr;
            }
        }
        public static bool operator*(Tank obj1, Tank obj2)
        {
            if(obj1.Ammo > obj2.Ammo && obj1.Armor > obj2.Armor)
                return true;
            if(obj1.Ammo > obj2.Ammo && obj1.Manuvr > obj2.Manuvr)
                return true;
            if (obj1.Armor > obj2.Armor && obj1.Manuvr > obj2.Manuvr)
                return true;
            return false;
        }
        public override string ToString()
        {
            return $"{_name}  ammo:{ammo},  armor:{armor},  manuvr:{manuvr}";

        }

    }
}
