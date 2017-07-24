using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMP_Weapon_Code
{
    class weaponList
    {
        public List<weapon> weapList = new List<weapon>();

        public weaponList() { }

        public void AddWeapon(weapon W)
        {
            weapList.Add(W);
        }
    }
}
