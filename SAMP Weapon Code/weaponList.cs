using System.Collections.Generic;

namespace SAMP_Weapon_Code
{
    class WeaponList
    {
        public List<Weapon> weapList = new List<Weapon>();

        public WeaponList() { }

        public void AddWeapon(Weapon W)
        {
            weapList.Add(W);
        }
    }
}
