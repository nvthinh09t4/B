using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Newspaper",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    LogoBase64 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newspaper", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockCompany",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    GroupCode = table.Column<string>(nullable: true),
                    GroupName = table.Column<string>(nullable: true),
                    ListedAt = table.Column<string>(nullable: true),
                    BusinessArea = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockCompanyDocument",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockCompanyDocument", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockGroup",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    AvgEPS = table.Column<float>(nullable: false),
                    AvgPE = table.Column<float>(nullable: false),
                    AvgROA = table.Column<float>(nullable: false),
                    AvgROE = table.Column<float>(nullable: false),
                    AvgPrice = table.Column<float>(nullable: false),
                    ComparePrice = table.Column<float>(nullable: false),
                    AvgPB = table.Column<float>(nullable: false),
                    AvgBeta = table.Column<float>(nullable: false),
                    TongKL = table.Column<long>(nullable: false),
                    NNSoHuu = table.Column<long>(nullable: false),
                    VonTT = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockIndex",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    InforDate = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    KLGDTrongPhien = table.Column<long>(nullable: false),
                    GiaTran = table.Column<float>(nullable: false),
                    GiaSan = table.Column<float>(nullable: false),
                    GiaMoCua = table.Column<float>(nullable: false),
                    GiaCaoNhat = table.Column<float>(nullable: false),
                    GiaThapNhat = table.Column<float>(nullable: false),
                    VonHoaThiTruong = table.Column<float>(nullable: false),
                    KLGDTrungBinh10Phien = table.Column<long>(nullable: false),
                    CaoNhat52Tuan = table.Column<float>(nullable: false),
                    ThapNhat52Tuan = table.Column<float>(nullable: false),
                    SoCPLuuHanh = table.Column<string>(nullable: true),
                    FreeFloat = table.Column<float>(nullable: false),
                    Beta = table.Column<float>(nullable: false),
                    PE = table.Column<float>(nullable: false),
                    PB = table.Column<float>(nullable: false),
                    ROAE = table.Column<float>(nullable: false),
                    ROAA = table.Column<float>(nullable: false),
                    TySuatCoTuc = table.Column<string>(nullable: true),
                    EPS = table.Column<float>(nullable: false),
                    BVPS = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockIndex", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockMainInformation",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    InforDate = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    Group = table.Column<string>(nullable: true),
                    AvgEPS = table.Column<float>(nullable: false),
                    AvgPE = table.Column<float>(nullable: false),
                    AvgROA = table.Column<float>(nullable: false),
                    AvgROE = table.Column<float>(nullable: false),
                    AvgPrice = table.Column<float>(nullable: false),
                    ComparePrice = table.Column<float>(nullable: false),
                    AvgPB = table.Column<float>(nullable: false),
                    AvgBeta = table.Column<float>(nullable: false),
                    TongKL = table.Column<long>(nullable: false),
                    NNSoHuu = table.Column<long>(nullable: false),
                    VonTT = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockMainInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockNews",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockNews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockReportAccountingBalance",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Year = table.Column<string>(nullable: true),
                    Quarter = table.Column<string>(nullable: true),
                    Code = table.Column<string>(nullable: true),
                    TongCongTaiSan = table.Column<float>(nullable: false),
                    TongCongNguonVon = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockReportAccountingBalance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockReportBusiness",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockReportBusiness", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockReportCashFlow",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockReportCashFlow", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockTransactionHistory",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    ThayDoiDiem = table.Column<float>(nullable: false),
                    ThayDoiPhanTram = table.Column<float>(nullable: false),
                    GiaMoCua = table.Column<float>(nullable: false),
                    GiaThapNhat = table.Column<float>(nullable: false),
                    GiaCaoNhat = table.Column<float>(nullable: false),
                    GiaDongCua = table.Column<float>(nullable: false),
                    GiaBinhQuan = table.Column<float>(nullable: false),
                    GiaDongCuaDieuChinh = table.Column<float>(nullable: false),
                    KhoiLuongKhopLenh = table.Column<long>(nullable: false),
                    KhoiLuongThoaThuan = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTransactionHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitor",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    VisitorId = table.Column<string>(nullable: true),
                    IPAddress = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true),
                    Cookie = table.Column<string>(nullable: true),
                    QueryString = table.Column<string>(nullable: true),
                    Query = table.Column<string>(nullable: true),
                    RouteValue = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileStorage",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    OriginFullPath = table.Column<string>(nullable: true),
                    OriginFileName = table.Column<string>(nullable: true),
                    OriginFileExtension = table.Column<string>(nullable: true),
                    StorageFullPath = table.Column<string>(nullable: true),
                    StorageFileName = table.Column<string>(nullable: true),
                    StorageFileExtension = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    FileName = table.Column<string>(maxLength: 256, nullable: false),
                    IsDisable = table.Column<bool>(nullable: false),
                    UploadAt = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileStorage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileStorage_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    CategoryTypeId = table.Column<long>(nullable: false),
                    Display = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category_CategoryType_CategoryTypeId",
                        column: x => x.CategoryTypeId,
                        principalTable: "CategoryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewspaperUserSubcribes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    NewspaperId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewspaperUserSubcribes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewspaperUserSubcribes_Newspaper_NewspaperId",
                        column: x => x.NewspaperId,
                        principalTable: "Newspaper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewspaperUserSubcribes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockCompanyLeadership",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    CompanyId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockCompanyLeadership", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockCompanyLeadership_StockCompany_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "StockCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockForeignerHolderRate",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TakeDataAt = table.Column<DateTime>(nullable: false),
                    MaximumCanHold = table.Column<float>(nullable: false),
                    CurrentHold = table.Column<float>(nullable: false),
                    RoomLeft = table.Column<float>(nullable: false),
                    CompanyId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockForeignerHolderRate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockForeignerHolderRate_StockCompany_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "StockCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockShareholder",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    SharePercent = table.Column<float>(nullable: false),
                    CompanyId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockShareholder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockShareholder_StockCompany_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "StockCompany",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    StockReportAccountingBalanceId = table.Column<long>(nullable: false),
                    TongCong = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015_StockReportAccountingBalance_StockReportAccountingBalanceId",
                        column: x => x.StockReportAccountingBalanceId,
                        principalTable: "StockReportAccountingBalance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RPAB_NoPhaiTra",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    StockReportAccountingBalanceId = table.Column<long>(nullable: false),
                    TongCong = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPAB_NoPhaiTra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RPAB_NoPhaiTra_StockReportAccountingBalance_StockReportAccountingBalanceId",
                        column: x => x.StockReportAccountingBalanceId,
                        principalTable: "StockReportAccountingBalance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RPAB_TaiSanDaiHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    StockReportAccountingBalanceId = table.Column<long>(nullable: false),
                    TongCong = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPAB_TaiSanDaiHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RPAB_TaiSanDaiHan_StockReportAccountingBalance_StockReportAccountingBalanceId",
                        column: x => x.StockReportAccountingBalanceId,
                        principalTable: "StockReportAccountingBalance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RPAB_TaiSanNganHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    StockReportAccountingBalanceId = table.Column<long>(nullable: false),
                    TongCong = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPAB_TaiSanNganHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RPAB_TaiSanNganHan_StockReportAccountingBalance_StockReportAccountingBalanceId",
                        column: x => x.StockReportAccountingBalanceId,
                        principalTable: "StockReportAccountingBalance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RPAB_VonChuSoHuu",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    StockReportAccountingBalanceId = table.Column<long>(nullable: false),
                    TongCong = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RPAB_VonChuSoHuu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RPAB_VonChuSoHuu_StockReportAccountingBalance_StockReportAccountingBalanceId",
                        column: x => x.StockReportAccountingBalanceId,
                        principalTable: "StockReportAccountingBalance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileCategory",
                columns: table => new
                {
                    CategoryId = table.Column<long>(nullable: false),
                    FileStorageId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileCategory", x => new { x.CategoryId, x.FileStorageId });
                    table.ForeignKey(
                        name: "FK_FileCategory_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FileCategory_FileStorage_FileStorageId",
                        column: x => x.FileStorageId,
                        principalTable: "FileStorage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewspaperCategoryUserSubcribes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    CategoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewspaperCategoryUserSubcribes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewspaperCategoryUserSubcribes_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewspaperCategoryUserSubcribes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NewspaperSubCategories",
                columns: table => new
                {
                    NewspaperId = table.Column<long>(nullable: false),
                    CategoryId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewspaperSubCategories", x => new { x.CategoryId, x.NewspaperId });
                    table.ForeignKey(
                        name: "FK_NewspaperSubCategories_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewspaperSubCategories_Newspaper_NewspaperId",
                        column: x => x.NewspaperId,
                        principalTable: "Newspaper",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_NoDaiHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    PhaiTraDaiHanNguoiBan = table.Column<float>(nullable: false),
                    NguoiMuaTraTruocDaiHan = table.Column<float>(nullable: false),
                    ChiPhiPhaiTraDaiHan = table.Column<float>(nullable: false),
                    PhaiTraNoiBoVeVonKinhDoanh = table.Column<float>(nullable: false),
                    PhaiTraDaiHanNoiBo = table.Column<float>(nullable: false),
                    PhaiTraDaiHanKhac = table.Column<float>(nullable: false),
                    VayVaNoDaiHan = table.Column<float>(nullable: false),
                    TraiPhieuChuyenDoi = table.Column<float>(nullable: false),
                    CoPhieuUuDai = table.Column<float>(nullable: false),
                    ThueThuNhapHoanLaiPhaiTra = table.Column<float>(nullable: false),
                    DuPhongTroCapMatViecLam = table.Column<float>(nullable: false),
                    DoanhThuChuaThucHienDaiHan = table.Column<float>(nullable: false),
                    QuyPhatTrienKhoaHocVaCongNghe = table.Column<float>(nullable: false),
                    DuPhongPhaiTraDaiHan = table.Column<float>(nullable: false),
                    RPAB_NoPhaiTraId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_NoDaiHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_NoDaiHan_RPAB_NoPhaiTra_RPAB_NoPhaiTraId",
                        column: x => x.RPAB_NoPhaiTraId,
                        principalTable: "RPAB_NoPhaiTra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_NoNganHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    VayVaNoNganHan = table.Column<float>(nullable: false),
                    PhaiTraNguoiBan = table.Column<float>(nullable: false),
                    NguoiMuaTraTienTruoc = table.Column<float>(nullable: false),
                    ThueVaCacKhoanPhaiNopNhaNuoc = table.Column<float>(nullable: false),
                    PhaiTraNguoiLaoDong = table.Column<float>(nullable: false),
                    ChiPhiPhaiTra = table.Column<float>(nullable: false),
                    PhaiTraNoiBo = table.Column<float>(nullable: false),
                    PhaiTraTheoTienDoKeHoachHopDongXayDung = table.Column<float>(nullable: false),
                    CacKhoanPhaiTraPhaiNopNganHanKhac = table.Column<float>(nullable: false),
                    QuyKhenThuongPhucLoi = table.Column<float>(nullable: false),
                    DoanhThuChuaThucHienNganHan = table.Column<float>(nullable: false),
                    DuPhongPhaiTraNganHan = table.Column<float>(nullable: false),
                    QuyBinhOnGia = table.Column<float>(nullable: false),
                    GiaoDichMuaBanLaiTraiPhieuChinhPhu = table.Column<float>(nullable: false),
                    RPAB_NoPhaiTraId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_NoNganHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_NoNganHan_RPAB_NoPhaiTra_RPAB_NoPhaiTraId",
                        column: x => x.RPAB_NoPhaiTraId,
                        principalTable: "RPAB_NoPhaiTra",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_BatDongSanDauTu",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    NguyenGiaBatDongSanDauTu = table.Column<float>(nullable: false),
                    HaoMonBatDongSanDauTu = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_BatDongSanDauTu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_BatDongSanDauTu_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_CacKhoanDauTuTaiChinhDaiHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    DauTuVaoCongTyCon = table.Column<float>(nullable: false),
                    DauTuVaoCongTyLienKetLienDoanh = table.Column<float>(nullable: false),
                    DauTuDaiHanKhac = table.Column<float>(nullable: false),
                    DuPhongGiamGiaDauTuTaiChinhDaiHan = table.Column<float>(nullable: false),
                    DauTuDaiHanGiuDenNgayDaoHan = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_CacKhoanDauTuTaiChinhDaiHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_CacKhoanDauTuTaiChinhDaiHan_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_CacKhoanPhaiThuDaiHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    PhaiThuDaiHanCuaKhachHang = table.Column<float>(nullable: false),
                    TraTruocDaiHanNguoiBan = table.Column<float>(nullable: false),
                    VonKinhDoanhODonViTrucThuoc = table.Column<float>(nullable: false),
                    PhaiThuDaiHanNoiBo = table.Column<float>(nullable: false),
                    PhaiThuVeChoVayDaiHan = table.Column<float>(nullable: false),
                    PhaiThuDaiHanKhac = table.Column<float>(nullable: false),
                    DuPhongPhaiThuDaiHanKhoDoi = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_CacKhoanPhaiThuDaiHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_CacKhoanPhaiThuDaiHan_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_LoiTheThuongMaiTruoc2015",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_LoiTheThuongMaiTruoc2015", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_LoiTheThuongMaiTruoc2015_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_TaiSanCoDinh",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    TaiSanCoDinhHuuHinh = table.Column<float>(nullable: false),
                    TaiSanCoDinhThueTaiChinh = table.Column<float>(nullable: false),
                    TaiSanCoDinhVoHinh = table.Column<float>(nullable: false),
                    ChiPhiXayDungCoBanDoDang = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_TaiSanCoDinh", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_TaiSanCoDinh_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_TaiSanDaiHanKhac",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    ChiPhiTraTruocDaiHan = table.Column<float>(nullable: false),
                    TaiSanThueThuNhapHoanLai = table.Column<float>(nullable: false),
                    ThietBiVatTuPhuTungThayTheDaiHan = table.Column<float>(nullable: false),
                    TaiSanDaiHanKhac = table.Column<float>(nullable: false),
                    LoiTheThuongMai = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_TaiSanDaiHanKhac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_TaiSanDaiHanKhac_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_TaiSanDoDangDaiHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    ChiPhiSanXuatKinhDoanhDoDangDaiHan = table.Column<float>(nullable: false),
                    ChiPhiXayDungCoBanDoDang = table.Column<float>(nullable: false),
                    RPAB_TaiSanDaiHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_TaiSanDoDangDaiHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_TaiSanDoDangDaiHan_RPAB_TaiSanDaiHan_RPAB_TaiSanDaiHanId",
                        column: x => x.RPAB_TaiSanDaiHanId,
                        principalTable: "RPAB_TaiSanDaiHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_CacKhoanDauTuTaiChinhNganHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    DauTuNganHan = table.Column<float>(nullable: false),
                    DuPhongGiamGiaDauTuNganHan = table.Column<float>(nullable: false),
                    DauTuGiuDenNgayDaoHan = table.Column<float>(nullable: false),
                    RPAB_TaiSanNganHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_CacKhoanDauTuTaiChinhNganHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_CacKhoanDauTuTaiChinhNganHan_RPAB_TaiSanNganHan_RPAB_TaiSanNganHanId",
                        column: x => x.RPAB_TaiSanNganHanId,
                        principalTable: "RPAB_TaiSanNganHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_CacKhoanPhaiThuNganHan",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    PhaiThuKhachHang = table.Column<float>(nullable: false),
                    TraTruocChoNguoiBan = table.Column<float>(nullable: false),
                    PhaiThuNoiBoNganHan = table.Column<float>(nullable: false),
                    PhaiThuTheoTienDoKeHoachHopDongXayDung = table.Column<float>(nullable: false),
                    PhaiThuVeChoVayNganHan = table.Column<float>(nullable: false),
                    CacKhoanPhaiThuKhac = table.Column<float>(nullable: false),
                    DuPhongPhaiThuNganHanKhoDoi = table.Column<float>(nullable: false),
                    TaiSanThieuChoXuLy = table.Column<float>(nullable: false),
                    RPAB_TaiSanNganHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_CacKhoanPhaiThuNganHan", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_CacKhoanPhaiThuNganHan_RPAB_TaiSanNganHan_RPAB_TaiSanNganHanId",
                        column: x => x.RPAB_TaiSanNganHanId,
                        principalTable: "RPAB_TaiSanNganHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_HangTonKho",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    HangTonKho = table.Column<float>(nullable: false),
                    DuPhongGiamGiaHangTonKho = table.Column<float>(nullable: false),
                    RPAB_TaiSanNganHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_HangTonKho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_HangTonKho_RPAB_TaiSanNganHan_RPAB_TaiSanNganHanId",
                        column: x => x.RPAB_TaiSanNganHanId,
                        principalTable: "RPAB_TaiSanNganHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_TaiSanNganHanKhac",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    ChiPhiTraTruocNganHan = table.Column<float>(nullable: false),
                    ThueGTGTDuocKhauTru = table.Column<float>(nullable: false),
                    ThueVaCacKhoanKhacPhaiThuNhaNuoc = table.Column<float>(nullable: false),
                    GiaoDichMuaBanLaiTraiPhieuChinhPhu = table.Column<float>(nullable: false),
                    TaiSanNganHanKhac = table.Column<float>(nullable: false),
                    RPAB_TaiSanNganHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_TaiSanNganHanKhac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_TaiSanNganHanKhac_RPAB_TaiSanNganHan_RPAB_TaiSanNganHanId",
                        column: x => x.RPAB_TaiSanNganHanId,
                        principalTable: "RPAB_TaiSanNganHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_TienVaCacKhoanTuongDuongTien",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    Tien = table.Column<float>(nullable: false),
                    CacKhoanTuongDuongTien = table.Column<float>(nullable: false),
                    RPAB_TaiSanNganHanId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_TienVaCacKhoanTuongDuongTien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_TienVaCacKhoanTuongDuongTien_RPAB_TaiSanNganHan_RPAB_TaiSanNganHanId",
                        column: x => x.RPAB_TaiSanNganHanId,
                        principalTable: "RPAB_TaiSanNganHan",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_NguonKinhPhiVanQuyKhac",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    RPAB_VonChuSoHuuId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_NguonKinhPhiVanQuyKhac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_NguonKinhPhiVanQuyKhac_RPAB_VonChuSoHuu_RPAB_VonChuSoHuuId",
                        column: x => x.RPAB_VonChuSoHuuId,
                        principalTable: "RPAB_VonChuSoHuu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Criteria_VonVaCacQuy",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    TongCong = table.Column<float>(nullable: false),
                    VonGop = table.Column<float>(nullable: false),
                    ThangDuVonCoPhan = table.Column<float>(nullable: false),
                    QuyenChonChuyenDoiTraiPhieu = table.Column<float>(nullable: false),
                    VonKhacCuaChuSoHuu = table.Column<float>(nullable: false),
                    CoPhieuQuy = table.Column<float>(nullable: false),
                    ChenhLenhDanhGiaLaiTaiSan = table.Column<float>(nullable: false),
                    ChenhLechTyGiaHoiDoai = table.Column<float>(nullable: false),
                    QuyDauTuPhatTrien = table.Column<float>(nullable: false),
                    QuyDuPhongTaiChinh = table.Column<float>(nullable: false),
                    QuyKhacThuocVonChuSoHuu = table.Column<float>(nullable: false),
                    LoiNhuanSauThueChuaPhanPhoi = table.Column<float>(nullable: false),
                    LoiIchCoDongKhongKiemSoat = table.Column<float>(nullable: false),
                    QuyHoTroSapXepDoanhNghiep = table.Column<float>(nullable: false),
                    NguonVonDauTuXDCB = table.Column<float>(nullable: false),
                    RPAB_VonChuSoHuuId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Criteria_VonVaCacQuy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Criteria_VonVaCacQuy_RPAB_VonChuSoHuu_RPAB_VonChuSoHuuId",
                        column: x => x.RPAB_VonChuSoHuuId,
                        principalTable: "RPAB_VonChuSoHuu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewspaperSubCategoryUserSubcribes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    LastModifiedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    NewspaperSubCategoryCategoryId = table.Column<long>(nullable: true),
                    NewspaperSubCategoryNewspaperId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewspaperSubCategoryUserSubcribes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewspaperSubCategoryUserSubcribes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NewspaperSubCategoryUserSubcribes_NewspaperSubCategories_NewspaperSubCategoryCategoryId_NewspaperSubCategoryNewspaperId",
                        columns: x => new { x.NewspaperSubCategoryCategoryId, x.NewspaperSubCategoryNewspaperId },
                        principalTable: "NewspaperSubCategories",
                        principalColumns: new[] { "CategoryId", "NewspaperId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CategoryTypeId",
                table: "Category",
                column: "CategoryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_BatDongSanDauTu_RPAB_TaiSanDaiHanId",
                table: "Criteria_BatDongSanDauTu",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_CacKhoanDauTuTaiChinhDaiHan_RPAB_TaiSanDaiHanId",
                table: "Criteria_CacKhoanDauTuTaiChinhDaiHan",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_CacKhoanDauTuTaiChinhNganHan_RPAB_TaiSanNganHanId",
                table: "Criteria_CacKhoanDauTuTaiChinhNganHan",
                column: "RPAB_TaiSanNganHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_CacKhoanPhaiThuDaiHan_RPAB_TaiSanDaiHanId",
                table: "Criteria_CacKhoanPhaiThuDaiHan",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_CacKhoanPhaiThuNganHan_RPAB_TaiSanNganHanId",
                table: "Criteria_CacKhoanPhaiThuNganHan",
                column: "RPAB_TaiSanNganHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_HangTonKho_RPAB_TaiSanNganHanId",
                table: "Criteria_HangTonKho",
                column: "RPAB_TaiSanNganHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_LoiTheThuongMaiTruoc2015_RPAB_TaiSanDaiHanId",
                table: "Criteria_LoiTheThuongMaiTruoc2015",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_NguonKinhPhiVanQuyKhac_RPAB_VonChuSoHuuId",
                table: "Criteria_NguonKinhPhiVanQuyKhac",
                column: "RPAB_VonChuSoHuuId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_NoDaiHan_RPAB_NoPhaiTraId",
                table: "Criteria_NoDaiHan",
                column: "RPAB_NoPhaiTraId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_NoNganHan_RPAB_NoPhaiTraId",
                table: "Criteria_NoNganHan",
                column: "RPAB_NoPhaiTraId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_TaiSanCoDinh_RPAB_TaiSanDaiHanId",
                table: "Criteria_TaiSanCoDinh",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_TaiSanDaiHanKhac_RPAB_TaiSanDaiHanId",
                table: "Criteria_TaiSanDaiHanKhac",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_TaiSanDoDangDaiHan_RPAB_TaiSanDaiHanId",
                table: "Criteria_TaiSanDoDangDaiHan",
                column: "RPAB_TaiSanDaiHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_TaiSanNganHanKhac_RPAB_TaiSanNganHanId",
                table: "Criteria_TaiSanNganHanKhac",
                column: "RPAB_TaiSanNganHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_TienVaCacKhoanTuongDuongTien_RPAB_TaiSanNganHanId",
                table: "Criteria_TienVaCacKhoanTuongDuongTien",
                column: "RPAB_TaiSanNganHanId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Criteria_VonVaCacQuy_RPAB_VonChuSoHuuId",
                table: "Criteria_VonVaCacQuy",
                column: "RPAB_VonChuSoHuuId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileCategory_FileStorageId",
                table: "FileCategory",
                column: "FileStorageId");

            migrationBuilder.CreateIndex(
                name: "IX_FileStorage_UserId",
                table: "FileStorage",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperCategoryUserSubcribes_CategoryId",
                table: "NewspaperCategoryUserSubcribes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperCategoryUserSubcribes_UserId",
                table: "NewspaperCategoryUserSubcribes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperSubCategories_NewspaperId",
                table: "NewspaperSubCategories",
                column: "NewspaperId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperSubCategoryUserSubcribes_UserId",
                table: "NewspaperSubCategoryUserSubcribes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperSubCategoryUserSubcribes_NewspaperSubCategoryCategoryId_NewspaperSubCategoryNewspaperId",
                table: "NewspaperSubCategoryUserSubcribes",
                columns: new[] { "NewspaperSubCategoryCategoryId", "NewspaperSubCategoryNewspaperId" });

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperUserSubcribes_NewspaperId",
                table: "NewspaperUserSubcribes",
                column: "NewspaperId");

            migrationBuilder.CreateIndex(
                name: "IX_NewspaperUserSubcribes_UserId",
                table: "NewspaperUserSubcribes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015_StockReportAccountingBalanceId",
                table: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015",
                column: "StockReportAccountingBalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_NoPhaiTra_StockReportAccountingBalanceId",
                table: "RPAB_NoPhaiTra",
                column: "StockReportAccountingBalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_TaiSanDaiHan_StockReportAccountingBalanceId",
                table: "RPAB_TaiSanDaiHan",
                column: "StockReportAccountingBalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_TaiSanNganHan_StockReportAccountingBalanceId",
                table: "RPAB_TaiSanNganHan",
                column: "StockReportAccountingBalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RPAB_VonChuSoHuu_StockReportAccountingBalanceId",
                table: "RPAB_VonChuSoHuu",
                column: "StockReportAccountingBalanceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StockCompanyLeadership_CompanyId",
                table: "StockCompanyLeadership",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StockForeignerHolderRate_CompanyId",
                table: "StockForeignerHolderRate",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StockShareholder_CompanyId",
                table: "StockShareholder",
                column: "CompanyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Criteria_BatDongSanDauTu");

            migrationBuilder.DropTable(
                name: "Criteria_CacKhoanDauTuTaiChinhDaiHan");

            migrationBuilder.DropTable(
                name: "Criteria_CacKhoanDauTuTaiChinhNganHan");

            migrationBuilder.DropTable(
                name: "Criteria_CacKhoanPhaiThuDaiHan");

            migrationBuilder.DropTable(
                name: "Criteria_CacKhoanPhaiThuNganHan");

            migrationBuilder.DropTable(
                name: "Criteria_HangTonKho");

            migrationBuilder.DropTable(
                name: "Criteria_LoiTheThuongMaiTruoc2015");

            migrationBuilder.DropTable(
                name: "Criteria_NguonKinhPhiVanQuyKhac");

            migrationBuilder.DropTable(
                name: "Criteria_NoDaiHan");

            migrationBuilder.DropTable(
                name: "Criteria_NoNganHan");

            migrationBuilder.DropTable(
                name: "Criteria_TaiSanCoDinh");

            migrationBuilder.DropTable(
                name: "Criteria_TaiSanDaiHanKhac");

            migrationBuilder.DropTable(
                name: "Criteria_TaiSanDoDangDaiHan");

            migrationBuilder.DropTable(
                name: "Criteria_TaiSanNganHanKhac");

            migrationBuilder.DropTable(
                name: "Criteria_TienVaCacKhoanTuongDuongTien");

            migrationBuilder.DropTable(
                name: "Criteria_VonVaCacQuy");

            migrationBuilder.DropTable(
                name: "FileCategory");

            migrationBuilder.DropTable(
                name: "NewspaperCategoryUserSubcribes");

            migrationBuilder.DropTable(
                name: "NewspaperSubCategoryUserSubcribes");

            migrationBuilder.DropTable(
                name: "NewspaperUserSubcribes");

            migrationBuilder.DropTable(
                name: "RPAB_LoiIchCuaCoDongKhongKiemSoatTruoc2015");

            migrationBuilder.DropTable(
                name: "StockCompanyDocument");

            migrationBuilder.DropTable(
                name: "StockCompanyLeadership");

            migrationBuilder.DropTable(
                name: "StockForeignerHolderRate");

            migrationBuilder.DropTable(
                name: "StockGroup");

            migrationBuilder.DropTable(
                name: "StockIndex");

            migrationBuilder.DropTable(
                name: "StockMainInformation");

            migrationBuilder.DropTable(
                name: "StockNews");

            migrationBuilder.DropTable(
                name: "StockReportBusiness");

            migrationBuilder.DropTable(
                name: "StockReportCashFlow");

            migrationBuilder.DropTable(
                name: "StockShareholder");

            migrationBuilder.DropTable(
                name: "StockTransactionHistory");

            migrationBuilder.DropTable(
                name: "Visitor");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "RPAB_NoPhaiTra");

            migrationBuilder.DropTable(
                name: "RPAB_TaiSanDaiHan");

            migrationBuilder.DropTable(
                name: "RPAB_TaiSanNganHan");

            migrationBuilder.DropTable(
                name: "RPAB_VonChuSoHuu");

            migrationBuilder.DropTable(
                name: "FileStorage");

            migrationBuilder.DropTable(
                name: "NewspaperSubCategories");

            migrationBuilder.DropTable(
                name: "StockCompany");

            migrationBuilder.DropTable(
                name: "StockReportAccountingBalance");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Newspaper");

            migrationBuilder.DropTable(
                name: "CategoryType");
        }
    }
}
