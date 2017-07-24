using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAMP_Weapon_Code
{
    public partial class Form1 : Form
    {
        weaponList WL = new weaponList();
        int _index = 0;
   
        public Form1()
        {
            InitializeComponent();
            
            //Status Strip
            statusStrip1.Items.Add("SA-MP Loaded");

            weapon W0 = new weapon(0, "Fist", 0, 0, Properties.Resources.fist);
            weapon W1 = new weapon(1, "Brass Knuckles", 331, 0, Properties.Resources.BRASSKNUCKLEicon);
            weapon W2 = new weapon(2, "Golf Club", 333, 1, Properties.Resources.golfclubicon);
            weapon W3 = new weapon(3, "Kightstick", 334, 1,Properties.Resources.nitestickicon);
            weapon W4 = new weapon(4, "Knife", 335, 1, Properties.Resources.knifecuricon);
            weapon W5 = new weapon(5, "Baseball Bat", 336, 1, Properties.Resources.baticon);
            weapon W6 = new weapon(6, "Shovel", 337, 1, Properties.Resources.shovelicon);
            weapon W7 = new weapon(7, "Pool Cue", 338, 1, Properties.Resources.poolcueicon);
            weapon W8 = new weapon(8, "Katana", 339, 1, Properties.Resources.katanaicon);
            weapon W9 = new weapon(9, "Chainsaw", 341, 1, Properties.Resources.chnsawicon);
            weapon W10 = new weapon(10, "Purple Dildo", 321, 10, Properties.Resources.gun_dildo1icon);
            weapon W11 = new weapon(11, "Dildo", 322, 10, Properties.Resources.gun_dildo2icon);
            weapon W12 = new weapon(12, "Vibrator", 323, 10, Properties.Resources.gun_vibe1icon);
            weapon W13 = new weapon(13, "Silver Vibrator", 324, 10, Properties.Resources.gun_vibe2icon);
            weapon W14 = new weapon(14, "Flowers", 325, 10, Properties.Resources.floweraicon);
            weapon W15 = new weapon(15, "Cane", 326, 10, Properties.Resources.gun_caneicon);
            weapon W16 = new weapon(16, "Grenade", 342, 8, Properties.Resources.grenadeicon);
            weapon W17 = new weapon(17, "Tear Gas", 343, 8, Properties.Resources.TearGasicon);
            weapon W18 = new weapon(18, "Motolov Cocktail", 344, 8, Properties.Resources.molotovicon);
            weapon W19 = new weapon(22, "9mm", 346, 2, Properties.Resources.colt45icon);
            weapon W20 = new weapon(23, "Silenced 9mm", 347, 2, Properties.Resources.silencedicon);
            weapon W21 = new weapon(24, "Desert Eagle", 348, 2, Properties.Resources.desert_eagleicon);
            weapon W22 = new weapon(25, "Shotgun", 349, 3, Properties.Resources.chromegunicon);
            weapon W23 = new weapon(26, "Swan-off Shotgun", 350, 3, Properties.Resources.sawnofficon);
            weapon W24 = new weapon(27, "Combat Shotgun", 351, 3, Properties.Resources.shotgspaicon);
            weapon W25 = new weapon(28, "Micro-UZI", 352, 4, Properties.Resources.micro_uziicon);
            weapon W26 = new weapon(29, "MP5", 353, 4, Properties.Resources.mp5lngicon);
            weapon W27 = new weapon(30, "AK-47", 355, 5, Properties.Resources.ak47icon);
            weapon W28 = new weapon(31, "M4", 356, 5, Properties.Resources.M4icon);
            weapon W29 = new weapon(32, "Tec-9", 372, 4, Properties.Resources.tec9icon);
            weapon W30 = new weapon(33, "Country Rifle", 357, 6, Properties.Resources.cuntgunicon);
            weapon W31 = new weapon(34, "Sniper Rifle", 358, 6, Properties.Resources.SNIPERicon);
            weapon W32 = new weapon(35, "RPG", 359, 7, Properties.Resources.rocketlaicon);
            weapon W33 = new weapon(36, "HS Rocket", 360, 7, Properties.Resources.heatseekicon);
            weapon W34 = new weapon(37, "Flame Thrower", 361, 7, Properties.Resources.flameicon);
            weapon W35 = new weapon(38, "Minigun", 362, 7, Properties.Resources.minigunicon);
            weapon W36 = new weapon(39, "Satchel Charge", 363, 8, Properties.Resources.satchelicon);
            weapon W37 = new weapon(40, "Detonator", 364, 12, Properties.Resources.bombicon);
            weapon W38 = new weapon(41, "Spray Can", 365, 9, Properties.Resources.SPRAYCANicon);
            weapon W39 = new weapon(42, "Fire Extinguisher", 366, 9, Properties.Resources.fire_exicon);
            weapon W40 = new weapon(43, "Camera", 367, 9, Properties.Resources.Cameraicon);
            weapon W41 = new weapon(44, "Night Vis Goggles", 368, 11, Properties.Resources.nvgogglesicon);
            weapon W42 = new weapon(45, "Thermal Goggles", 369, 11, Properties.Resources.irgogglesicon);
            weapon W43 = new weapon(46, "Parachut", 357, 6, Properties.Resources.gun_paraicon);

            WL.AddWeapon(W0);
            WL.AddWeapon(W1);
            WL.AddWeapon(W2);
            WL.AddWeapon(W3);
            WL.AddWeapon(W4);
            WL.AddWeapon(W5);
            WL.AddWeapon(W6);
            WL.AddWeapon(W7);
            WL.AddWeapon(W8);
            WL.AddWeapon(W9);
            WL.AddWeapon(W10);
            WL.AddWeapon(W11);
            WL.AddWeapon(W12);
            WL.AddWeapon(W13);
            WL.AddWeapon(W14);
            WL.AddWeapon(W15);
            WL.AddWeapon(W16);
            WL.AddWeapon(W17);
            WL.AddWeapon(W18);
            WL.AddWeapon(W19);
            WL.AddWeapon(W20);
            WL.AddWeapon(W21);
            WL.AddWeapon(W22);
            WL.AddWeapon(W23);
            WL.AddWeapon(W24);
            WL.AddWeapon(W25);
            WL.AddWeapon(W26);
            WL.AddWeapon(W27);
            WL.AddWeapon(W28);
            WL.AddWeapon(W29);
            WL.AddWeapon(W30);
            WL.AddWeapon(W31);
            WL.AddWeapon(W32);
            WL.AddWeapon(W33);
            WL.AddWeapon(W34);
            WL.AddWeapon(W35);
            WL.AddWeapon(W36);
            WL.AddWeapon(W37);
            WL.AddWeapon(W38);
            WL.AddWeapon(W39);
            WL.AddWeapon(W40);
            WL.AddWeapon(W41);
            WL.AddWeapon(W42);
            WL.AddWeapon(W43);

            UpdateUI();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (_index > 0)
            {
                string _content;
                _index--;

                _content = "Selected Entity: " + _index;

                statusStrip1.Items.Clear();
                statusStrip1.Items.Add(_content);
                statusStrip1.ForeColor = Color.Black;
                UpdateUI();
            }
            else
            {
                statusStrip1.Items.Clear();
                statusStrip1.Items.Add("You have reached the smallest weapon ID!");
                statusStrip1.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (_index < 43)
            {
                string _content;

                _index++;

                _content = "Selected Entity: " + _index;

                statusStrip1.Items.Clear();
                statusStrip1.Items.Add(_content);
                statusStrip1.ForeColor = Color.Black;
                UpdateUI();
            }
            else
            {
                statusStrip1.Items.Clear();
                statusStrip1.Items.Add("You have reached the biggest weapon ID!");
                statusStrip1.ForeColor = Color.Red;
            }
        }

        public void UpdateUI()
        {
            label1.Text = WL.weapList[_index].WeapName;
            label6.Text = WL.weapList[_index].WeapID.ToString();
            label7.Text = WL.weapList[_index].WeapModel.ToString();
            label8.Text = WL.weapList[_index].WeapSlot.ToString();
            pictureBox1.Image = WL.weapList[_index].WeapPicture;
        }
    }
}
