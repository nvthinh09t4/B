using Domain.Interfaces;
using Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        public IStockShareholderRepository StockShareholder {
            get {
                return _stockShareholder ?? new StockShareholderRepository(_dbContext, _configuration);
            }
        }

        public IStockCompanyLeadershipRepository StockCompanyLeadership {
            get {
                return _stockCompanyLeadership ?? new StockCompanyLeadershipRepository(_dbContext, _configuration);
            }
        }
        public IStockCompanyRepository StockCompany {
            get {
                return _stockCompany ?? new StockCompanyRepository(_dbContext, _configuration);
            }
        }

        public IStockIndexRepository StockIndex {
            get {
                return _stockIndex ?? new StockIndexRepository(_dbContext, _configuration);
            }
        }
        public IStockGroupRepository StockGroup {
            get {
                return _stockGroup ?? new StockGroupRepository(_dbContext, _configuration);
            }
        }
        public IStockMainInformationRepository StockMainInformation {
            get {
                return _stockMainInformation ?? new StockMainInformationRepository(_dbContext, _configuration);
            }
        }
        public IStockTransactionHistoryRepository StockTransactionHistory {
            get {
                return IStockTransactionHistoryRepository ?? new StockTransactionHistoryRepository(_dbContext, _configuration);
            }
        }


        private IStockShareholderRepository _stockShareholder;
        private IStockCompanyLeadershipRepository _stockCompanyLeadership;
        private IStockCompanyRepository _stockCompany;
        private IStockIndexRepository _stockIndex;
        private IStockGroupRepository _stockGroup;
        private IStockMainInformationRepository _stockMainInformation;
        private IStockTransactionHistoryRepository IStockTransactionHistoryRepository;
        private ApplicationDbContext _dbContext;

        private IConfiguration _configuration;

        public RepositoryWrapper(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }

        public void SaveChange()
        {
            _dbContext.SaveChanges();
        }

        public async Task SaveChangeAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
