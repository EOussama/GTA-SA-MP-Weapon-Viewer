using System.Drawing;

namespace SAMP_Weapon_Code
{
    class Weapon
    {
        private int     _weapID;
        private string  _weapName;
        private int     _weapModel;
        private int     _weapSlot;
        private Image   _weapPicture;

        public int WeapID
        {

            get
            {
                return _weapID;
            }

            set
            {
                if (value < 0 || value > 46)
                    _weapID = 0;
                else
                    _weapID = value;
            }
        }

        public string WeapName
        {

            get
            {
                return _weapName;
            }

            set
            {
                _weapName = value;
            }
        }

        public int WeapModel
        {

            get
            {
                return _weapModel;
            }

            set
            {
                _weapModel = value;
            }
        }

        public int WeapSlot
        {

            get
            {
                return _weapSlot;
            }

            set
            {
                _weapSlot = value;
            }
        }

        public Image WeapPicture
        {
            get
            {
                return _weapPicture;
            }

            set
            {
                _weapPicture = value;
            }
        }

        public Weapon(int WeapID, string WeapName, int WeapModel, int WeapSlot, Image WeapPicture)
        {
            this.WeapID = WeapID;
            this.WeapName = WeapName;
            this.WeapModel = WeapModel;
            this.WeapSlot = WeapSlot;
            this.WeapPicture = WeapPicture;
        }
    }
}
