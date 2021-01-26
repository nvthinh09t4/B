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
                if (_stockShareholder == null)
                    _stockShareholder = new StockShareholderRepository(_dbContext, _configuration);

                return _stockShareholder;
            }
        }

        public IStockCompanyLeadershipRepository StockCompanyLeadership {
            get {
                if (_stockCompanyLeadership == null)
                    _stockCompanyLeadership = new StockCompanyLeadershipRepository(_dbContext, _configuration);

                return _stockCompanyLeadership;
            }
        }
        public IStockCompanyRepository StockCompany {
            get {
                if (_stockCompany == null)
                    _stockCompany = new StockCompanyRepository(_dbContext, _configuration);

                return _stockCompany;
            }
        }

        public IStockIndexRepository StockIndex {
            get {
                if (_stockIndex == null)
                    _stockIndex = new StockIndexRepository(_dbContext, _configuration);

                return _stockIndex;
            }
        }
        public IStockGroupRepository StockGroup {
            get {
                if (_stockGroup == null)
                    _stockGroup = new StockGroupRepository(_dbContext, _configuration);

                return _stockGroup;
            }
        }
        public IStockMainInformationRepository StockMainInformation {
            get {
                if (_stockMainInformation == null)
                    _stockMainInformation = new StockMainInformationRepository(_dbContext, _configuration);

                return _stockMainInformation;
            }
        }
        public IStockTransactionHistoryRepository StockTransactionHistory {
            get {
                if (_stockTransactionHistoryRepository == null)
                    _stockTransactionHistoryRepository = new StockTransactionHistoryRepository(_dbContext, _configuration);

                return _stockTransactionHistoryRepository;
            }
        }
        public IStockReportAccountingBalanceRepository StockReportAccountingBalance {
            get {
                if (_stockReportAccountingBalanceRepository == null)
                    _stockReportAccountingBalanceRepository = new StockReportAccountingBalanceRepository(_dbContext, _configuration);

                return _stockReportAccountingBalanceRepository;
            }
        }

        private IStockShareholderRepository _stockShareholder;
        private IStockCompanyLeadershipRepository _stockCompanyLeadership;
        private IStockCompanyRepository _stockCompany;
        private IStockIndexRepository _stockIndex;
        private IStockGroupRepository _stockGroup;
        private IStockMainInformationRepository _stockMainInformation;
        private IStockTransactionHistoryRepository _stockTransactionHistoryRepository;
        private IStockReportAccountingBalanceRepository _stockReportAccountingBalanceRepository;
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
