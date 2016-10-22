using HomelessHelper.Core.EntityFramework;
using NUnit.Framework;

namespace HomelessHelper.Test
{
    [TestFixture]
    public class DatabaseSchemaExport
    {
        [Test]
        public void Export()
        {
            var manager = new DatabaseManager(new HomelessHelperDbContext());
            manager.DropAndCreate();
        }
    }
}
