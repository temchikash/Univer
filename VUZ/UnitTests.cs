using Xunit;

namespace VUZ
{
    public class UnitTests
    {
        [Fact]
        public void LoadDB_Success()
        {
            var vuzer = new VUZER();

            vuzer.LoadDB();

            Assert.NotNull(VUZER.db);
            Assert.True(VUZER.db.VUZS.Local.Count > 0);
            Assert.True(VUZER.db.Cities.Local.Count > 0);
        }

        [Fact]
        public void LoadDB_Failure()
        {
            var vuzer = new VUZER();

            Assert.Throws<Exception>(() => vuzer.LoadDB());
        }
        [Fact]
        public void UniversTable_CellContentClick_NewFormShown()
        {
            var vuzer = new VUZER();

            vuzer.UniversTable_CellContentClick(null, new DataGridViewCellEventArgs(0, 0));

            Assert.True(vuzer.OwnedForms.Length > 0);
        }
    }
}
