using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenShop.Data.Infrastructure
{
    public class DbFactory : Disposeable, IDbFactory
    {
        private SenShopDbContext dbContext;

        public SenShopDbContext Init()
        {
            return dbContext ?? (dbContext = new SenShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
