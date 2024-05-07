using NLog;
using System.Data;

namespace VUZ
{
    public partial class DeleteForm : Form
    {
        DBContext db = VUZER.db;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if(NameBox == null)
            {
                MessageBox.Show("Выберите какой-либо ВУЗ");
            }
            else
            {
                db.VUZS.Remove(db.VUZS.Where(s => s.Name == NameBox.SelectedItem).First());
            }

            db.SaveChanges();
            logger.Info("Удален ВУЗ");
            Hide();
        }

        private void DeleteForm_Load(object sender, EventArgs e)
        {
            foreach (var i in db.VUZS.ToList())
            {
                NameBox.Items.Add(i.Name);
            }
        }
    }
}
