using NLog;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace VUZ
{
    public partial class VUZER : Form
    {
        static public DBContext db = new DBContext();
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static public VUZ CurrentVuz = new VUZ();
        public VUZER()
        {
            InitializeComponent();
            LoadDB();
            //InitializeDB();
        }
        private void CityBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadDB()
        {
            try
            {
                db.Database.EnsureCreated();
                db.VUZS.Load();
                db.Cities.Load();
                logger.Debug("База данных загрузилась");
            }
            catch (Exception e)
            {
                logger.Fatal("База данных не загрузилась");
            }
        }
        private void InitializeDB()
        {
            byte[] arr = new byte[1];
            SQLitePCL.Batteries.Init();
            City Kazan = new City(1, "Казань");
            db.Cities.Add(Kazan);
            City Moskow = new City(2, "Москва");
            db.Cities.Add(Moskow);
            var univer1 = new VUZ(1, "КФУ", Kazan.Name, arr);
            db.VUZS.Add(univer1);
            db.SaveChanges();
        }

        private void VUZER_Load(object sender, EventArgs e)
        {
            foreach (var i in db.Cities.ToList())
            {
                CityBox.Items.Add(i.Name);
            }
            foreach (var i in db.VUZS.ToList())
            {
                UniversTable.DataSource = db.VUZS.Local.ToBindingList();
            }
            logger.Info("Приложение загружено");
        }

        public void UniversTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var SelectedRow = UniversTable.Rows[e.RowIndex];
                CurrentVuz.Id = (int)SelectedRow.Cells["IdGrid"].Value;

                Card card = new Card();
                card.Show();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddForm add = new AddForm();
            add.Show();
        }

        private void CityBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string SelectedCity = CityBox.SelectedItem.ToString();
            using (var db = new DBContext())
            {
                var FilteredData = db.VUZS.Where(v => v.City == SelectedCity).ToList();

                UniversTable.DataSource = FilteredData;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteForm delete = new DeleteForm();
            delete.Show();
        }
    }
}