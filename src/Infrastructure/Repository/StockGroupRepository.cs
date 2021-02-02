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
    public class StockGroupRepository : BaseRepository<StockGroup>, IStockGroupRepository
    {
        private IConfiguration _configuration;
        private ApplicationDbContext _dbContext;

        public StockGroupRepository(ApplicationDbContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }

        public override async Task<bool> IsExist(StockGroup entity)
        {
            return GetDBSet().AsQueryable().FirstOrDefault(x => x.Code == entity.Code) != null;
        }
    }
}
