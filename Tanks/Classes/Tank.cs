using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

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
        public static bool operator*(Tank obj)
        {

            return true;
        }
    }
}
