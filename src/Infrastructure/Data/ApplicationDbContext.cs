using Domain;
using Domain.Interfaces;
using Domain.ReportEntity.ReportAccountingBalance;
using Infrastructure.EntityConfiguration;
using Infrastructure.EntityConfiguration.ReportConfiguration.ReportAccountingBalance;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IUnitOfWork
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            await base.SaveChangesAsync(cancellationToken);
            return true;
        }
        public DbSet<Book> Book { get; set; }

        public DbSet<FileStorage> FileStorage { get; set; }
        public DbSet<CategoryType> CategoryType { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Visitor> Visitor { get; set; }
        public DbSet<Newspaper> Newspaper { get; set; }
        public DbSet<NewspaperSubCategory> NewspaperSubCategories { get; set; }
        public DbSet<NewspaperUserSubcribe> NewspaperUserSubcribes { get; set; }
        public DbSet<NewspaperCategoryUserSubcribe> NewspaperCategoryUserSubcribes { get; set; }
        public DbSet<NewspaperSubCategoryUserSubcribe> NewspaperSubCategoryUserSubcribes { get; set; }
        public DbSet<StockIndex> StockIndex { get; set; }
        public DbSet<StockGroup> StockGroup { get; set; }
        public DbSet<StockMainInformation> StockMainInformation { get; set; }
        //public DbSet<ViewConfiguration> ViewConfiguration { get; set; }

        public DbSet<StockCompanyLeadership> StockCompanyLeadership { get; set; }
        public DbSet<StockCompany> StockCompany { get; set; }
        public DbSet<StockCompanyDocument> StockCompanyDocument { get; set; }
        public DbSet<StockForeignerHolderRate> StockForeignerHolderRate { get; set; }
        public DbSet<StockNews> StockNews { get; set; }
        public DbSet<StockReportAccountingBalance> StockReportAccountingBalance { get; set; }
        public DbSet<StockReportBusiness> StockReportBusiness { get; set; }
        public DbSet<StockReportCashFlow> StockReportCashFlow { get; set; }
        public DbSet<StockShareholder> StockShareholder { get; set; }
        public DbSet<StockTransactionHistory> StockTransactionHistory { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new FileStorageConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new FileCategoryConfiguration());
            builder.ApplyConfiguration(new NewspaperSubCategoryConfiguration());
            builder.ApplyConfiguration(new NewspaperUserSubcribeConfiguration());
            builder.ApplyConfiguration(new StockCompanyConfiguration());

            builder.ApplyConfiguration(new StockReportAccountingBalanceConfiguration());
            builder.ApplyConfiguration(new RPAB_TaiSanNganHanConfiguration());
            builder.ApplyConfiguration(new RPAB_TaiSanDaiHanConfiguration());
            builder.ApplyConfiguration(new RPAB_NoPhaiTraConfiguration());
            builder.ApplyConfiguration(new RPAB_VonChuSoHuuConfiguration());

            builder.Entity<Criteria_BatDongSanDauTu>().HasKey(x => x.Id);
            builder.Entity<Criteria_CacKhoanDauTuTaiChinhDaiHan>().HasKey(x => x.Id);
            builder.Entity<Criteria_CacKhoanDauTuTaiChinhNganHan>().HasKey(x => x.Id);
            builder.Entity<Criteria_CacKhoanPhaiThuDaiHan>().HasKey(x => x.Id);
            builder.Entity<Criteria_CacKhoanPhaiThuNganHan>().HasKey(x => x.Id);
            builder.Entity<Criteria_HangTonKho>().HasKey(x => x.Id);
            builder.Entity<Criteria_LoiTheThuongMaiTruoc2015>().HasKey(x => x.Id);
            builder.Entity<Criteria_NguonKinhPhiVanQuyKhac>().HasKey(x => x.Id);
            builder.Entity<Criteria_NoDaiHan>().HasKey(x => x.Id);
            builder.Entity<Criteria_NoNganHan>().HasKey(x => x.Id);
            builder.Entity<Criteria_TaiSanCoDinh>().HasKey(x => x.Id);
            builder.Entity<Criteria_TaiSanDaiHanKhac>().HasKey(x => x.Id);
            builder.Entity<Criteria_TaiSanDoDangDaiHan>().HasKey(x => x.Id);
            builder.Entity<Criteria_TaiSanNganHanKhac>().HasKey(x => x.Id);
            builder.Entity<Criteria_TienVaCacKhoanTuongDuongTien>().HasKey(x => x.Id);
            builder.Entity<Criteria_VonVaCacQuy>().HasKey(x => x.Id);
        }
    }
}
