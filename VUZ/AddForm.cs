using NLog;

namespace VUZ
{
    public partial class AddForm : Form
    {
        DBContext db = VUZER.db;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            Photo.Image = new Bitmap(filename);

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(NameTextBox.Text) && !String.IsNullOrEmpty(CityTextBox.Text) && Photo.Image != null)
            {
                bool CityFlag = true;
                City city1 = new City(db.Cities.Count() + 1, CityTextBox.Text);
                foreach (City city in db.Cities)
                {
                    if(city.Name == CityTextBox.Text)
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

                VUZ vuz = new VUZ(db.VUZS.Count() + 1, NameTextBox.Text, CityTextBox.Text, VUZ.PictureToByteArr(Photo.Image));
                db.VUZS.Add(vuz);
                db.SaveChanges();
                logger.Info("Добавлен ВУЗ");
                Hide();
            }
            else
            {
                MessageBox.Show("Вы не заполнили все поля.");
            }
        }
    }
}
