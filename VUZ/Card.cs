using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VUZ
{
    public partial class Card : Form
    {
        static public VUZ CurrentVuz = VUZER.CurrentVuz;
        static public DBContext db = VUZER.db;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Card()
        {
            InitializeComponent();
        }

        private void Card_Load(object sender, EventArgs e)
        {
            CurrentVuz = db.VUZS.Find(CurrentVuz.Id);
            NameTextBox.Text = CurrentVuz.Name;
            CityTextBox.Text = CurrentVuz.City;
            Photo.Image = VUZ.ByteArrToPicture(CurrentVuz.Photo);
        }

        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            Photo.Image = new Bitmap(filename);
        }


        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(NameTextBox.Text) && !String.IsNullOrEmpty(CityTextBox.Text) && Photo.Image != null)
            {
                bool CityFlag = true;
                City city1 = new City(db.Cities.Count() + 1, CityTextBox.Text);
                foreach (City city in db.Cities)
                {
                    if (city.Name == CityTextBox.Text)
                    {
                        CityFlag = true;
                    }
                    else
                    {
                        CityFlag = false;
                    }
                }
                if (!CityFlag)
                {
                    db.Cities.Add(city1);
                }
                CurrentVuz.Name = NameTextBox.Text;
                CurrentVuz.City = CityTextBox.Text;
                CurrentVuz.Photo = VUZ.PictureToByteArr(Photo.Image);
                db.SaveChanges();
                logger.Info("Изменена информация о ВУЗЕ");
                Hide();
            }
            else
            {
                MessageBox.Show("Вы не заполнили все поля.");
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
