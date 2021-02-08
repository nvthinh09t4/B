using Domain;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class StockReportBusinessRepository : BaseRepository<StockReportBusiness>, IStockReportBusinessRepository
    {
        private IConfiguration _configuration;
        private ApplicationDbContext _dbContext;
        private string _connectionString;

        public StockReportBusinessRepository(ApplicationDbContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<StockReportBusiness> GetByCodeOnTime(string code, string quarter, string year)
        {
            return await _dbContext.StockReportBusiness.FirstOrDefaultAsync(x => x.Code == code && x.Quarter == quarter && x.Year == year);
        }
    }
}
