﻿using Dapper;
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
    public class StockTransactionHistoryRepository : BaseRepository<StockTransactionHistory>, IStockTransactionHistoryRepository
    {
        private IConfiguration _configuration;
        private ApplicationDbContext _dbContext;

        public StockTransactionHistoryRepository(ApplicationDbContext dbContext, IConfiguration configuration) : base(dbContext)
        {
            _configuration = configuration;
            _dbContext = dbContext;
        }

        public StockTransactionHistory GetByCodeAndDate(string code, string date)
        {
            return _dbContext.StockTransactionHistory.Where(x => x.Code == code).ToList().FirstOrDefault(x => date == x.TransactionDateString);
        }
    }
}
