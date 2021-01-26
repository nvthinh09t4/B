using Dapper;
using Domain;
using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class StockReportAccountingBalanceRepository : BaseRepository<StockReportAccountingBalance>, IStockReportAccountingBalanceRepository
    {
        private IConfiguration _configuration;
        private ApplicationDbContext _dbContext;
        private string _connectionString;

        public StockReportAccountingBalanceRepository(ApplicationDbContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
            _connectionString = _configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<StockReportAccountingBalance> GetByCodeOnTime(string code, string quarter, string year)
        {
            await using var connection = new SqlConnection(_connectionString);
            connection.Open();

            var result = await connection.QueryFirstOrDefaultAsync<StockReportAccountingBalance>(
                @"SELECT * FROM StockReportAccountingBalance s WHERE s.Code = @code and s.Quarter = @quarter and s.Year = @year",
                new { code, quarter, year }
                ); ;

            return result;
        }
    }
}
