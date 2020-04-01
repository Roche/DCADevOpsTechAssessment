using RocheDevOpsAssessment.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading;
using System.Threading.Tasks;

namespace RocheDevOpsAssessment.Utils
{
    public class RaincheckQuery : IRaincheckQuery
    {
        private readonly IRocheDevOpsAssessmentContext context;

        public RaincheckQuery(IRocheDevOpsAssessmentContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Raincheck>> GetAllAsync()
        {
            var rainchecks = await context.RainChecks.ToListAsync();

            foreach (var raincheck in rainchecks)
            {
                await FillRaincheckValuesAsync(raincheck);
            }

            return rainchecks;
        }

        public async Task<Raincheck> FindAsync(int id)
        {
            var raincheck = await context.RainChecks.FirstOrDefaultAsync(r => r.RaincheckId == id);

            if (raincheck == null)
            {
                throw new ArgumentOutOfRangeException("id");
            }

            await FillRaincheckValuesAsync(raincheck);

            return raincheck;
        }

        public async Task<int> AddAsync(Raincheck raincheck)
        {
            var addedRaincheck = context.RainChecks.Add(raincheck);

            await context.SaveChangesAsync(CancellationToken.None);

            //return addedRaincheck.Entity.RaincheckId; 
            return addedRaincheck.RaincheckId;
        }

        /// <summary>
        /// Lazy loading is not currently available with EF 7.0, so this loads the Store/Product/Category information
        /// </summary>
        private async Task FillRaincheckValuesAsync(Raincheck raincheck)
        {
            raincheck.IssuerStore = await context.Stores.FirstAsync(s => s.StoreId == raincheck.StoreId);
            raincheck.Product = await context.Products.FirstAsync(p => p.ProductId == raincheck.ProductId);
            raincheck.Product.Category = await context.Categories.FirstAsync(c => c.CategoryId == raincheck.Product.CategoryId);
        }
    }
}
