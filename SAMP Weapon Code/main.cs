using System;
using System.Drawing;
using System.Windows.Forms;

namespace SAMP_Weapon_Code
{
    public partial class main : Form
    {
        WeaponList WL = new WeaponList();
        int _index = 0;
   
        public main()
        {
            InitializeComponent();
            
            ssInfo.Items.Add("SA-MP Loaded");

            WL.AddWeapon(new Weapon(0, "Fist", 0, 0, Properties.Resources.fist));
            WL.AddWeapon(new Weapon(1, "Brass Knuckles", 331, 0, Properties.Resources.BRASSKNUCKLEicon));
            WL.AddWeapon(new Weapon(2, "Golf Club", 333, 1, Properties.Resources.golfclubicon));
            WL.AddWeapon(new Weapon(3, "Kightstick", 334, 1, Properties.Resources.nitestickicon));
            WL.AddWeapon(new Weapon(4, "Knife", 335, 1, Properties.Resources.knifecuricon));
            WL.AddWeapon(new Weapon(5, "Baseball Bat", 336, 1, Properties.Resources.baticon));
            WL.AddWeapon(new Weapon(6, "Shovel", 337, 1, Properties.Resources.shovelicon));
            WL.AddWeapon(new Weapon(7, "Pool Cue", 338, 1, Properties.Resources.poolcueicon));
            WL.AddWeapon(new Weapon(8, "Katana", 339, 1, Properties.Resources.katanaicon));
            WL.AddWeapon(new Weapon(9, "Chainsaw", 341, 1, Properties.Resources.chnsawicon));
            WL.AddWeapon(new Weapon(10, "Purple Dildo", 321, 10, Properties.Resources.gun_dildo1icon));
            WL.AddWeapon(new Weapon(11, "Dildo", 322, 10, Properties.Resources.gun_dildo2icon));
            WL.AddWeapon(new Weapon(12, "Vibrator", 323, 10, Properties.Resources.gun_vibe1icon));
            WL.AddWeapon(new Weapon(13, "Silver Vibrator", 324, 10, Properties.Resources.gun_vibe2icon));
            WL.AddWeapon(new Weapon(14, "Flowers", 325, 10, Properties.Resources.floweraicon));
            WL.AddWeapon(new Weapon(15, "Cane", 326, 10, Properties.Resources.gun_caneicon));
            WL.AddWeapon(new Weapon(16, "Grenade", 342, 8, Properties.Resources.grenadeicon));
            WL.AddWeapon(new Weapon(17, "Tear Gas", 343, 8, Properties.Resources.TearGasicon));
            WL.AddWeapon(new Weapon(18, "Motolov Cocktail", 344, 8, Properties.Resources.molotovicon));
            WL.AddWeapon(new Weapon(22, "9mm", 346, 2, Properties.Resources.colt45icon));
            WL.AddWeapon(new Weapon(23, "Silenced 9mm", 347, 2, Properties.Resources.silencedicon));
            WL.AddWeapon(new Weapon(24, "Desert Eagle", 348, 2, Properties.Resources.desert_eagleicon));
            WL.AddWeapon(new Weapon(25, "Shotgun", 349, 3, Properties.Resources.chromegunicon));
            WL.AddWeapon(new Weapon(26, "Swan-off Shotgun", 350, 3, Properties.Resources.sawnofficon));
            WL.AddWeapon(new Weapon(27, "Combat Shotgun", 351, 3, Properties.Resources.shotgspaicon));
            WL.AddWeapon(new Weapon(28, "Micro-UZI", 352, 4, Properties.Resources.micro_uziicon));
            WL.AddWeapon(new Weapon(29, "MP5", 353, 4, Properties.Resources.mp5lngicon));
            WL.AddWeapon(new Weapon(30, "AK-47", 355, 5, Properties.Resources.ak47icon));
            WL.AddWeapon(new Weapon(31, "M4", 356, 5, Properties.Resources.M4icon));
            WL.AddWeapon(new Weapon(32, "Tec-9", 372, 4, Properties.Resources.tec9icon));
            WL.AddWeapon(new Weapon(33, "Country Rifle", 357, 6, Properties.Resources.cuntgunicon));
            WL.AddWeapon(new Weapon(34, "Sniper Rifle", 358, 6, Properties.Resources.SNIPERicon));
            WL.AddWeapon(new Weapon(35, "RPG", 359, 7, Properties.Resources.rocketlaicon));
            WL.AddWeapon(new Weapon(36, "HS Rocket", 360, 7, Properties.Resources.heatseekicon));
            WL.AddWeapon(new Weapon(37, "Flame Thrower", 361, 7, Properties.Resources.flameicon));
            WL.AddWeapon(new Weapon(38, "Minigun", 362, 7, Properties.Resources.minigunicon));
            WL.AddWeapon(new Weapon(39, "Satchel Charge", 363, 8, Properties.Resources.satchelicon));
            WL.AddWeapon(new Weapon(40, "Detonator", 364, 12, Properties.Resources.bombicon));
            WL.AddWeapon(new Weapon(41, "Spray Can", 365, 9, Properties.Resources.SPRAYCANicon));
            WL.AddWeapon(new Weapon(42, "Fire Extinguisher", 366, 9, Properties.Resources.fire_exicon));
            WL.AddWeapon(new Weapon(43, "Camera", 367, 9, Properties.Resources.Cameraicon));
            WL.AddWeapon(new Weapon(44, "Night Vis Goggles", 368, 11, Properties.Resources.nvgogglesicon));
            WL.AddWeapon(new Weapon(45, "Thermal Goggles", 369, 11, Properties.Resources.irgogglesicon));
            WL.AddWeapon(new Weapon(46, "Parachut", 357, 6, Properties.Resources.gun_paraicon));

            UpdateUI();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_index > 0)
            {
                string _content;
                _index--;

                _content = "Selected Entity: " + _index;

                ssInfo.Items.Clear();
                ssInfo.Items.Add(_content);
                ssInfo.ForeColor = Color.Black;
                UpdateUI();
            }
            else
            {
                ssInfo.Items.Clear();
                ssInfo.Items.Add("You have reached the smallest weapon ID!");
                ssInfo.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (_index < 43)
            {
                string _content;

                _index++;

                _content = "Selected Entity: " + _index;

                ssInfo.Items.Clear();
                ssInfo.Items.Add(_content);
                ssInfo.ForeColor = Color.Black;
                UpdateUI();
            }
            else
            {
                ssInfo.Items.Clear();
                ssInfo.Items.Add("You have reached the biggest weapon ID!");
                ssInfo.ForeColor = Color.Red;
            }
        }

        private void bFirst_Click(object sender, EventArgs e)
        {
            string _content;
            _index = 0;

            _content = "Selected Entity: " + _index;

            ssInfo.Items.Clear();
            ssInfo.Items.Add(_content);
            ssInfo.ForeColor = Color.Black;
            UpdateUI();
        }

        private void bLast_Click(object sender, EventArgs e)
        {
            string _content;
            _index = WL.weapList.Count - 1;

            _content = "Selected Entity: " + _index;

            ssInfo.Items.Clear();
            ssInfo.Items.Add(_content);
            ssInfo.ForeColor = Color.Black;
            UpdateUI();
        }

        private void nupEntity_ValueChanged(object sender, EventArgs e)
        {
            if((int)nupEntity.Value >= 0 && (int)nupEntity.Value <= WL.weapList.Count)
            {
                string _content;
                _index = (int)nupEntity.Value;

                _content = "Selected Entity: " + _index;

                ssInfo.Items.Clear();
                ssInfo.Items.Add(_content);
                ssInfo.ForeColor = Color.Black;
                UpdateUI();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a simple lightweight program that helps retrieve useful information concerning weapons in GTA SA, it personally helped me save a lot of time, and I thought of releasing it, probably, it could come in useful for you someday... or every day.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateUI()
        {
            lWeaponName.Text = WL.weapList[_index].WeapName;
            lWeaponIDPH.Text = WL.weapList[_index].WeapID.ToString();
            lWeaponModelPH.Text = WL.weapList[_index].WeapModel.ToString();
            lWeaponSlotPH.Text = WL.weapList[_index].WeapSlot.ToString();
            pbWeaponPicture.Image = WL.weapList[_index].WeapPicture;
            nupEntity.Value = _index;
        }
    }
}
