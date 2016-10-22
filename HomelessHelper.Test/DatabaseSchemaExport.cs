using HomelessHelper.Core.EntityFramework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HomelessHelper.Test
{
    [TestClass]
    public class DatabaseSchemaExport
    {
        [TestMethod]
        public void Export()
        {
            var manager = new DatabaseManager(new HomelessHelperDbContext());
            manager.DropAndCreate();
        }
    }
}
