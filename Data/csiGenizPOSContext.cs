using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace csiWSGeniuzPOS.Model
{
    public partial class csiGenizPOSContext : DbContext
    {
        //private readonly string _connectionString;

        //public csiGenizPOSContext(String connectionString)
        //{
        //    _connectionString = connectionString;
        //}

        //public csiGenizPOSContext(DbContextOptions<csiGenizPOSContext> options)
        //    : base(options)
        //{
        //}

        public csiGenizPOSContext()
        {
        }

        public csiGenizPOSContext(DbContextOptions<csiGenizPOSContext> options)
            : base(options)
        {
        }

    public virtual DbSet<CsArticle> CsArticles { get; set; }
        public virtual DbSet<CsArticleGroup> CsArticleGroups { get; set; }
        public virtual DbSet<CsArticleGroupCode> CsArticleGroupCodes { get; set; }
        public virtual DbSet<CsArticleGroupType> CsArticleGroupTypes { get; set; }
        public virtual DbSet<CsColor> CsColors { get; set; }
        public virtual DbSet<CsDocGroup> CsDocGroups { get; set; }
        public virtual DbSet<CsDocType> CsDocTypes { get; set; }
        public virtual DbSet<CsMatType> CsMatTypes { get; set; }
        public virtual DbSet<CsPara> CsParas { get; set; }
        public virtual DbSet<CsPlu> CsPlus { get; set; }
        public virtual DbSet<CsSize> CsSizes { get; set; }
        public virtual DbSet<CsSku> CsSkus { get; set; }
        public virtual DbSet<CsStyle> CsStyles { get; set; }
        public virtual DbSet<CsSupplier> CsSuppliers { get; set; }
        public virtual DbSet<CsTaste> CsTastes { get; set; }
        public virtual DbSet<CsUnit> CsUnits { get; set; }
        public virtual DbSet<CsVatCode> CsVatCodes { get; set; }
        public virtual DbSet<CsVatType> CsVatTypes { get; set; }
        public virtual DbSet<DataAuditLog> DataAuditLogs { get; set; }
        public virtual DbSet<Exception> Exceptions { get; set; }
        public virtual DbSet<IcWh> IcWhs { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<PsCashCouponType> PsCashCouponTypes { get; set; }
        public virtual DbSet<PsCashier> PsCashiers { get; set; }
        public virtual DbSet<PsCreditCard> PsCreditCards { get; set; }
        public virtual DbSet<PsCurrency> PsCurrencies { get; set; }
        public virtual DbSet<PsDebitCard> PsDebitCards { get; set; }
        public virtual DbSet<PsDiscCouponType> PsDiscCouponTypes { get; set; }
        public virtual DbSet<PsExchangeRate> PsExchangeRates { get; set; }
        public virtual DbSet<PsHoldDt> PsHoldDts { get; set; }
        public virtual DbSet<PsHoldHd> PsHoldHds { get; set; }
        public virtual DbSet<PsMbDiscGroup> PsMbDiscGroups { get; set; }
        public virtual DbSet<PsMember> PsMembers { get; set; }
        public virtual DbSet<PsMemberType> PsMemberTypes { get; set; }
        public virtual DbSet<PsOtherPayment> PsOtherPayments { get; set; }
        public virtual DbSet<PsPanelGroupButton> PsPanelGroupButtons { get; set; }
        public virtual DbSet<PsPanelItemButton> PsPanelItemButtons { get; set; }
        public virtual DbSet<PsPara> PsParas { get; set; }
        public virtual DbSet<PsPaymentType> PsPaymentTypes { get; set; }
        public virtual DbSet<PsPosFunc> PsPosFuncs { get; set; }
        public virtual DbSet<PsPosPrinter> PsPosPrinters { get; set; }
        public virtual DbSet<PsPosShiftControl> PsPosShiftControls { get; set; }
        public virtual DbSet<PsPosStation> PsPosStations { get; set; }
        public virtual DbSet<PsPosTouchPanelType> PsPosTouchPanelTypes { get; set; }
        public virtual DbSet<PsPosTranDisc> PsPosTranDiscs { get; set; }
        public virtual DbSet<PsPosTranDt> PsPosTranDts { get; set; }
        public virtual DbSet<PsPosTranHd> PsPosTranHds { get; set; }
        public virtual DbSet<PsPosTranRecv> PsPosTranRecvs { get; set; }
        public virtual DbSet<PsPriceChange> PsPriceChanges { get; set; }
        public virtual DbSet<PsPromoDt> PsPromoDts { get; set; }
        public virtual DbSet<PsPromoHd> PsPromoHds { get; set; }
        public virtual DbSet<PsPromoMb> PsPromoMbs { get; set; }
        public virtual DbSet<PsSalesman> PsSalesmen { get; set; }
        public virtual DbSet<PsSalesmanGroup> PsSalesmanGroups { get; set; }
        public virtual DbSet<PsSetItemDt> PsSetItemDts { get; set; }
        public virtual DbSet<PsSetItemHd> PsSetItemHds { get; set; }
        public virtual DbSet<PsShop> PsShops { get; set; }
        public virtual DbSet<PsShopGroup> PsShopGroups { get; set; }
        public virtual DbSet<PsShopType> PsShopTypes { get; set; }
        public virtual DbSet<PsTaxInvoiceAddress> PsTaxInvoiceAddresses { get; set; }
        public virtual DbSet<PsTaxInvoiceDt> PsTaxInvoiceDts { get; set; }
        public virtual DbSet<PsTaxInvoiceHd> PsTaxInvoiceHds { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolePermission> RolePermissions { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserPermission> UserPermissions { get; set; }
        public virtual DbSet<UserPreference> UserPreferences { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<VersionInfo> VersionInfos { get; set; }
        public virtual DbSet<Vexchange> Vexchanges { get; set; }

        public virtual DbSet<Vposparam> Vposparams { get; set; }
        public virtual DbSet<VpsPlu> VpsPlus { get; set; }
        public virtual DbSet<VgetSalesItem> VgetSalesItems { get; set; }
        public virtual DbSet<vatSalesItem> vatSalesItems { get; set; }
        public virtual DbSet<getPosTranHd> getPosTranHds { get; set; }
        public virtual DbSet<getPosTranDt> getPosTranDts { get; set; }
        public virtual DbSet<getPosTranDisc> getPosTranDiscs { get; set; }
        public virtual DbSet<getPosTranReceipt> getPosTranReceipts { get; set; }
        public virtual DbSet<getActivePosStation> getActivePosStations { get; set; }
        public virtual DbSet<VgetPosSignin> VgetPosSignins { get; set; }

        public virtual DbSet<VpsMember> VpsMembers { get; set; }

        public virtual DbSet<PmUnitPrice> PmUnitPrices { get; set; }
        public virtual DbSet<PluPrice> PluPrices  { get; set; }
        public virtual DbSet<PaymentInfo> PaymentInfos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=ATU;Database=CSIGENIUS_DB;User=sa;Password=morepos5599;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Thai_CS_AI");

            modelBuilder.Entity<CsArticle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csArticle");

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ArticleDesc).HasMaxLength(150);

                entity.Property(e => e.ArticleDesc2)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ArticleName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.ArticleStyle).HasMaxLength(20);

                entity.Property(e => e.BaseUnit)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.ConsignGp).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MarketDate).HasColumnType("date");

                entity.Property(e => e.ProdImageLink)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SupplCode).HasMaxLength(15);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VatRateCode)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.VatType)
                    .IsRequired()
                    .HasMaxLength(2);
            });

            modelBuilder.Entity<CsArticleGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csArticleGroup");

                entity.Property(e => e.ArticleCode).HasMaxLength(20);

                entity.Property(e => e.AtcGroupCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.AtcGroupTypeCode)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<CsArticleGroupCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csArticleGroupCode");

                entity.Property(e => e.AtcGroupCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.AtcGroupName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.AtcGroupTypeCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CsArticleGroupType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csArticleGroupType");

                entity.Property(e => e.AtcGroupTypeCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AtcGroupTypeDesc)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CsColor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csColor");

                entity.Property(e => e.ColorId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ColorName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CsDocGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csDocGroup");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DocFormTitleE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocFormTitleT)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocGroup)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.DocGroupDesc)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.DocType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PrintFormName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateBy).HasMaxLength(100);
            });

            modelBuilder.Entity<CsDocType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csDocType");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DocName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.DocPrefix).HasMaxLength(2);

                entity.Property(e => e.DocType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy).HasMaxLength(100);
            });

            modelBuilder.Entity<CsMatType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csMatType");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MatTypeId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.MatTypeName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CsPara>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csPara");

                entity.Property(e => e.BizAddressLine1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BizAddressLine2)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BizAddressLine3)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BizName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.BizType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.FaxId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.RegId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TaxId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TaxInvAddrLine1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TaxInvAddrLine2)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TaxInvAddrLine3)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TaxInvName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TelId)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CsPlu>(entity =>
            {
               // entity.HasNoKey();
                entity.HasKey(e => e.PluCode);
                entity.Property(e => e.PluCode)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PluCode");

                entity.ToTable("csPlu");

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ColorId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DeliverCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MatTypeId)
                    .IsRequired()
                    .HasMaxLength(20);

              //  entity.Property(e => e.PluCode)
              //      .IsRequired()
              //      .HasMaxLength(20);

                entity.Property(e => e.PluDesc)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.PluIntCode).HasMaxLength(20);

                entity.Property(e => e.PluShortDesc)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.SellUnit)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SellUnitPrice1).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SellUnitPrice2).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SellUnitPrice3).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SellUnitPrice4).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SellUnitPrice5).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SellUnitPrice6).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SellUnitRatio).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.SizeId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SkuCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StyleId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TasteId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CsSize>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csSize");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.SizeId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.SizeName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CsSku>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csSku");

                entity.Property(e => e.ArticleCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ColorId).HasMaxLength(20);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastPurPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MatTypeId).HasMaxLength(20);

                entity.Property(e => e.MaxStockQty).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.MinStockQty).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.PurLeadTime).HasColumnType("decimal(3, 0)");

                entity.Property(e => e.PurUnit)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.PurUnitPrice).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.PurUnitRatio).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.QtyOnhand).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.SizeId).HasMaxLength(20);

                entity.Property(e => e.SkuCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SkuDesc)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.StkUnit)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.StockCostValue).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StyleId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TasteId).HasMaxLength(20);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CsStyle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csStyle");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.StyleId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StyleName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CsSupplier>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csSupplier");

                entity.Property(e => e.ConsignGp).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.SupplAddress)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.SupplId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SupplName).HasMaxLength(80);

                entity.Property(e => e.SupplRegAddress)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.SupplRegName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.SupplTaxId).HasMaxLength(15);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CsTaste>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csTaste");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.TasteId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.TasteName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CsUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csUnit");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.UnitId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CsVatCode>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csVatCode");

                entity.Property(e => e.VatRate).HasColumnType("decimal(19, 5)");

                entity.Property(e => e.VatRateCode)
                    .IsRequired()
                    .HasMaxLength(4);
            });

            modelBuilder.Entity<CsVatType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("csVatType");

                entity.Property(e => e.VatType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.VatTypeDesc)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DataAuditLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DataAuditLog");

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.RecordId)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Exception>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DeletionDate).HasColumnType("datetime");

                entity.Property(e => e.Guid).HasColumnName("GUID");

                entity.Property(e => e.Host).HasMaxLength(100);

                entity.Property(e => e.Httpmethod)
                    .HasMaxLength(10)
                    .HasColumnName("HTTPMethod");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(40)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Message).HasMaxLength(1000);

                entity.Property(e => e.Source).HasMaxLength(100);

                entity.Property(e => e.Sql).HasColumnName("SQL");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Url).HasMaxLength(500);
            });

            modelBuilder.Entity<IcWh>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("icWhs");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ShopId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.WhsId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.WhsName)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.LanguageId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PsCashCouponType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psCashCouponType");

                entity.Property(e => e.CashCouponName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CashCouponType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CashCouponValue).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PartnerCompensateAmt).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.PartnerCompensatePc).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsCashier>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psCashier");

                entity.Property(e => e.CashierId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CashierName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CashierPassword)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsCreditCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psCreditCard");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CreditCardName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CreditCardType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsCurrency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psCurrency");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsDebitCard>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psDebitCard");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DebitCardName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DebitCardType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsDiscCouponType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psDiscCouponType");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DiscCouponName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DiscCouponType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DiscCouponValue).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PartnerCompensateAmt).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.PartnerCompensatePc).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsExchangeRate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psExchangeRate");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(8, 5)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsHoldDt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psHoldDt");

                entity.Property(e => e.ChrgAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ChrgPc).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.CouponNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DiscAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.DiscPc).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ExPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.HoldNo)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.LineItemType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.PluCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PromoId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Qty).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.SerialNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsHoldHd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psHoldHd");

                entity.Property(e => e.CashierId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.HoldDate).HasColumnType("date");

                entity.Property(e => e.HoldNo)
                    .IsRequired()
                    .HasMaxLength(16);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PosId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsMbDiscGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psMbDiscGroup");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.GroupCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.GroupTypeCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MbDiscPs).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.MemberType)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psMember");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MbAccumPoint).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.MbAddress)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.MbAmphur)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.MbApplyDate).HasColumnType("date");

                entity.Property(e => e.MbBirthDay).HasColumnType("date");

                entity.Property(e => e.MbCardType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MbEmail)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.MbExpireDate).HasColumnType("date");

                entity.Property(e => e.MbExpirePointDate).HasColumnType("date");

                entity.Property(e => e.MbGender)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.MbId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.MbLineAddr1)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.MbLineAddr2)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.MbLineAddr3)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.MbNameE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MbNameT)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MbNation)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MbNearlyExpirePoint).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.MbOccupation)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MbPhoto)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MbProvince)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.MbRace)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MbTelNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MbTumbol)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.MbType)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.MbZipCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.MbPid)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsMemberType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psMemberType");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MbDiscPs).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.MemberType)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.MemberTypeDesc)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsOtherPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psOtherPayment");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.OtherPaymentName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.OtherPaymentType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsPanelGroupButton>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id");

                entity.ToTable("psPanelGroupButton");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.GroupButtonId)
            .IsRequired();

                entity.Property(e => e.GroupButtonImage)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GroupButtonLabel)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.TxtColor)
                  .IsRequired()
                  .HasMaxLength(8);
                entity.Property(e => e.BgColor)
                  .IsRequired()
                  .HasMaxLength(8);
                entity.Property(e => e.TxtFontSize)
                  .IsRequired();

                entity.Property(e => e.TouchPanelType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsPanelItemButton>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id");

                entity.ToTable("psPanelItemButton");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.GroupButtonId)
              .IsRequired();

                entity.Property(e => e.ItemButtonId)
               .IsRequired();
            

                entity.Property(e => e.ItemButtonLabel)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ItemButtonImage)
                 .IsRequired()
                 .HasMaxLength(100);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.LinkCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LinkCodeFg)
                     .IsRequired();

                entity.Property(e => e.TxtColor)
                  .IsRequired()
                  .HasMaxLength(8);
                entity.Property(e => e.BgColor)
                  .IsRequired()
                  .HasMaxLength(8);
                entity.Property(e => e.TxtFontSize)
                  .IsRequired();

                entity.Property(e => e.TouchPanelType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsPara>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psPara");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.ChargeVatRate).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.NoOfRecptCopy).HasColumnType("decimal(1, 0)");

                entity.Property(e => e.PointRedeemOneBaht).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.PosProcessMode)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PosScreenType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.RecptFootMesg1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg2)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg3)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg4)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg5)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg6)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg10)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg2)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg3)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg4)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg5)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg6)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg7)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg8)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg9)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.SalesVatType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ShopAddress)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ShopLogoOnFrontScreen)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShopLogoOnReceipt)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ShopRegAddressLine1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShopRegAddressLine2)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShopRegAddressLine3)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShopRegId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ShopRegName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.ShopTaxId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.WeightBarcodePrefix)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<PsPaymentType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psPaymentType");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PaymentName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateBy).HasMaxLength(100);
            });

            modelBuilder.Entity<PsPosFunc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psPosFunc");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FuncDesc)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.FuncId)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.KbMapKeyCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.KbMapShiftCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsPosPrinter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psPosPrinter");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PrinterId)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.PrinterName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsPosShiftControl>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id");

                entity.ToTable("psPosShiftControl");

                entity.Property(e => e.BegCash).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CashBalance).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CashIn).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CashOut).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CashSales).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CashierId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Charge).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Deiscount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.EndReceiptNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.EndRefundNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.GrossAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.NetSales).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PosId)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("PosID");

                entity.Property(e => e.RecvByCash).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RecvByCashCd).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RecvByCoupon).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RecvByCreditCd).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RecvByDebitCd).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RecvByOthers).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RecvByPoint).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RoundReceive).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ShiftStatus)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SingInDate).HasColumnType("date");

                entity.Property(e => e.SingInTime).HasColumnType("datetime");

                entity.Property(e => e.SingOutDate).HasColumnType("date");

                entity.Property(e => e.SingOutTime).HasColumnType("datetime");

                entity.Property(e => e.StartReceiptNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.StartRefundNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TotalCashInAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TotalCashOutamt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TotalRefundAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TotalVoidAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsPosStation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psPosStation");

                entity.Property(e => e.AutoChargeRate).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.ConnectEdcfg).HasColumnName("ConnectEDCFg");

                entity.Property(e => e.ConnectRfidreaderFg).HasColumnName("ConnectRFIDReaderFg");

                entity.Property(e => e.ConnectVfdfg).HasColumnName("ConnectVFDFg");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastReceiptRunNo).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.LastRefundRunNo).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MaxCashInDrawer).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PosId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.PosPermitNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PosScreenType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.PosTouchPanelId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.PsParaDefault1).HasColumnName("psParaDefault1");

                entity.Property(e => e.PsParaDefault2).HasColumnName("psParaDefault2");

                entity.Property(e => e.RecptFootMesg1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg10)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg2)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg3)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg4)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg5)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg6)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg7)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg8)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg9)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg1)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg2)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg3)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg4)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg5)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptHeadMesg6)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.SalesVatType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ShopId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.ShopLogoOnFrontScreen)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShopLogoOnReceipt)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.WhsId)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<PsPosTouchPanelType>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id");

                entity.ToTable("psPosTouchPanelType");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.TouchPanelDesc)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.TouchPanelType)
                    .IsRequired()
                    .HasMaxLength(10);
                entity.Property(e => e.POSScreenType)
                  .IsRequired()
                  .HasMaxLength(2);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsPosTranDisc>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id");

                entity.ToTable("psPosTranDisc");

                entity.Property(e => e.ChargeAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ChargePc).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DiscCouponNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DiscCouponType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.LineItemType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.PromoId)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsPosTranDt>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id");

                entity.ToTable("psPosTranDt");

                entity.Property(e => e.AllocatedBillDiscount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ChargeAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ChargePc).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DiscCouponNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DiscCouponType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DiscPc).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.Discamt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ExPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ItemCharge).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ItemDiscount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ItemNetExprice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ItemNetSales).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ItemPromoId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ItemVat).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.ItemVatRate).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.ItemVatType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.LineItemType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.PluCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PromoId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Qty).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.SerialNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsPosTranHd>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id");

                entity.ToTable("psPosTranHd");

                entity.Property(e => e.AllItemCharge).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.AllItemDiscount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.BillCharge).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.BillDiscount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CashierId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DocAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.DocDate).HasColumnType("date");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DocTime).HasColumnType("datetime");

                entity.Property(e => e.GrossSales).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MbId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.NetSales).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.NetSalesExVat).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.NetSalesNonVat).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.NetSalesNormal).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.NetSalesPromo).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PosId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.ReceiveCash).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ReceiveCashCd).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ReceiveCoupon).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ReceiveCreditCd).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ReceiveDebitCd).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ReceiveOthers).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ReceivePoint).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RefDocNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RoundAdjust).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.SalesVatType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.SlaesmanId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Vat).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.VatOfCharge).HasColumnType("decimal(8, 4)");

                entity.Property(e => e.VatOfNetSales).HasColumnType("decimal(8, 4)");
            });

            modelBuilder.Entity<PsPosTranRecv>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Id");

                entity.ToTable("psPosTranRecv");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CurrencyAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ExchangeRate).HasColumnType("decimal(8, 5)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ReceivetAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.RefType)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsPriceChange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psPriceChange");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PluCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SellUnitPrice1).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SellUnitPrice2).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SellUnitPrice3).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SellUnitPrice4).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SellUnitPrice5).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.SellUnitPrice6).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsPromoDt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psPromoDt");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.GpNormal).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.GpPromo).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PromoDiscPc).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.PromoId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PromoPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsPromoHd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psPromoHd");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.EndPromoDate).HasColumnType("date");

                entity.Property(e => e.EndPromoTime).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PromoDay)
                    .IsRequired()
                    .HasMaxLength(7);

                entity.Property(e => e.PromoDesc)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.PromoId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PromoName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.StartPromoDate).HasColumnType("date");

                entity.Property(e => e.StartPromoTime).HasColumnType("datetime");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsPromoMb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psPromoMb");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.MbType)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.PromoId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsSalesman>(entity =>
            {
                entity.HasKey(e => e.SalesmanId);
                entity.Property(e => e.SalesmanId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SalesmanId");

                entity.ToTable("psSalesman");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.SalesmanGroup)
                    .IsRequired()
                    .HasMaxLength(5);

                //entity.Property(e => e.SalesmanId)
                //    .IsRequired()
                //    .HasMaxLength(5);

                entity.Property(e => e.SalesmanName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsSalesmanGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psSalesmanGroup");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.SalesmanGroup)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.SalesmanGroupDesc)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsSetItemDt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psSetItemDt");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.NormalUnitPrice).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.PluCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Qty).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.SetItemCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SetUnitPrice).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsSetItemHd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psSetItemHd");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.FinishDate).HasColumnType("date");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.SetItemCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SetItemName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SetItemShortName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.SetItemUnit)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SetPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsShop>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psShop");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ShopAddress)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.ShopGroupId)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.ShopId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.ShopRegAddressLine1)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.ShopRegAddressLine2)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.ShopRegAddressLine3)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.ShopRegId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ShopRegName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.ShopTaxId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ShopTypeId)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsShopGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psShopGroup");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ShopGroupId)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.ShopGroupName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsShopType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psShopType");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.ShopTypeId)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.ShopTypeName)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsTaxInvoiceAddress>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psTaxInvoiceAddress");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.TaxId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TaxInvAddressLine1)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.TaxInvAddressLine2)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.TaxInvAddressLine3)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.TaxInvName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsTaxInvoiceDt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psTaxInvoiceDt");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ExPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ItemCharge).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ItemDescription)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemDiscount).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ItemNetExprice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.ItemVatType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.PluCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Qty).HasColumnType("decimal(7, 2)");

                entity.Property(e => e.SerialNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UnitPrice).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PsTaxInvoiceHd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("psTaxInvoiceHd");

                entity.Property(e => e.ChargeAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.CreateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.DocDate).HasColumnType("date");

                entity.Property(e => e.DocNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.DocType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.GrossAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.LastUpdate).HasColumnType("datetime");

                entity.Property(e => e.NetAmt).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.RefDocNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.SalesVatType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TaxId)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TaxInvAddressLine1)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.TaxInvAddressLine2)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.TaxInvAddressLine3)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.TaxInvName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.UpdateBy)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.VatAmt).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RoleKey).HasMaxLength(100);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PermissionKey)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.InsertDate).HasColumnType("datetime");

                entity.Property(e => e.LastDirectoryUpdate).HasColumnType("datetime");

                entity.Property(e => e.MobilePhoneNumber).HasMaxLength(20);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(86);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(4);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserImage).HasMaxLength(100);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserPermission>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PermissionKey)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserPreference>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PreferenceType)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<VersionInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("VersionInfo");

                entity.Property(e => e.AppliedOn).HasColumnType("datetime");


                entity.Property(e => e.Description).HasMaxLength(1024);
            });

            //modelBuilder.Entity<VpsPlu>(entity =>
            //{
            //    entity.HasKey(e => e.PluCode);
            //    entity.Property(e => e.PluCode)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("PluCode");

            //    entity.ToView("VpsPLU");

            //    entity.Property(e => e.ArticleCode)
            //        .IsRequired()
            //        .HasMaxLength(20);

            //    entity.Property(e => e.ArticleStyle).HasMaxLength(20);

            //    entity.Property(e => e.ColorId)
            //        .IsRequired()
            //        .HasMaxLength(20);

            //    entity.Property(e => e.DeliverCost).HasColumnType("decimal(10, 2)");

            //    entity.Property(e => e.MatTypeId)
            //        .IsRequired()
            //        .HasMaxLength(20);

            //    // entity.Property(e => e.PluCode)
            //    //     .IsRequired()
            //    //     .HasMaxLength(20);

            //    entity.Property(e => e.PluDesc)
            //        .IsRequired()
            //        .HasMaxLength(80);

            //    entity.Property(e => e.PluIntCode).HasMaxLength(20);

            //    entity.Property(e => e.PluShortDesc)
            //        .IsRequired()
            //        .HasMaxLength(30);

            //    entity.Property(e => e.SellUnit)
            //        .IsRequired()
            //        .HasMaxLength(15);

            //    entity.Property(e => e.SellUnitPrice1).HasColumnType("decimal(10, 2)");

            //    entity.Property(e => e.SellUnitPrice2).HasColumnType("decimal(10, 2)");

            //    entity.Property(e => e.SellUnitPrice3).HasColumnType("decimal(10, 2)");

            //    entity.Property(e => e.SellUnitPrice4).HasColumnType("decimal(10, 2)");

            //    entity.Property(e => e.SellUnitPrice5).HasColumnType("decimal(10, 2)");

            //    entity.Property(e => e.SellUnitPrice6).HasColumnType("decimal(10, 2)");

            //    entity.Property(e => e.SellUnitRatio).HasColumnType("decimal(5, 2)");

            //    entity.Property(e => e.SizeId)
            //        .IsRequired()
            //        .HasMaxLength(20);

            //    entity.Property(e => e.SkuCode)
            //        .IsRequired()
            //        .HasMaxLength(20);

            //    entity.Property(e => e.StyleId)
            //        .IsRequired()
            //        .HasMaxLength(20);

            //    entity.Property(e => e.SupplCode).HasMaxLength(15);

            //    entity.Property(e => e.TasteId)
            //        .IsRequired()
            //        .HasMaxLength(20);

            //    entity.Property(e => e.VatRateCode).HasMaxLength(4);

            //    entity.Property(e => e.VatType).HasMaxLength(2);

            //    entity.Property(e => e.QtyOnHand).HasColumnType("decimal(10, 2)");

            //    entity.Property(e => e.StockFg)
            //      .IsRequired();

            //    entity.Property(e => e.ProdImageLink).HasMaxLength(100);
            //});

            //modelBuilder.Entity<Vexchange>(entity =>
            //{

            //    entity.HasKey(e => e.Id);
            //    entity.Property(e => e.Id)
            //        .ValueGeneratedOnAdd()
            //        .HasColumnName("Id");

             

            //    entity.ToView("Vexchange");


            //    entity.Property(e => e.CurrencyCode)
            //       .IsRequired()
            //       .HasMaxLength(20);

            //    entity.Property(e => e.CurrencyName)
            //       .IsRequired()
            //       .HasMaxLength(100);

             

            //   // entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

            //    entity.Property(e => e.ExchangeRate).HasColumnType("decimal(10, 6)");


            //});

            modelBuilder.Entity<Vposparam>(entity =>
            {
                entity.HasKey(e => e.PosId);
                entity.Property(e => e.PosId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("PosId");
                //entity.Property(e => e.PosId)
                //.IsRequired()
                //.HasMaxLength(5);

               // entity.HasNoKey();

                entity.ToView("VPOSparam");

                entity.Property(e => e.AutoChargeRate).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.BizAddressLine1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BizAddressLine2)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BizAddressLine3)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BizName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.BizType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.BranchName).HasMaxLength(80);

                entity.Property(e => e.ChargeVatRate).HasColumnType("decimal(2, 2)");

                entity.Property(e => e.ConnectEdcfg).HasColumnName("ConnectEDCFg");

                entity.Property(e => e.ConnectRfidreaderFg).HasColumnName("ConnectRFIDReaderFg");

                entity.Property(e => e.ConnectVfdfg).HasColumnName("ConnectVFDFg");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.FaxId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.LastReceiptRunNo).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.LastRefundRunNo).HasColumnType("decimal(6, 0)");

                entity.Property(e => e.MaxCashInDrawer).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.PointRedeemOneBaht).HasColumnType("decimal(5, 2)");

            

                entity.Property(e => e.PosPermitNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PosProcessMode)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.PosScreenType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.PosTouchPanelId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.PsParaDefault1).HasColumnName("psParaDefault1");

                entity.Property(e => e.PsParaDefault2).HasColumnName("psParaDefault2");

                entity.Property(e => e.RecptFootMesg1)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RecptFootMesg10)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RecptFootMesg2)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RecptFootMesg3)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RecptFootMesg4)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RecptFootMesg5)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RecptFootMesg6)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RecptFootMesg7)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.RecptFootMesg8)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RecptFootMesg9)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RecptHeadMesg1)
                    .IsRequired()
                    .HasMaxLength(40);

             

                entity.Property(e => e.RecptHeadMesg2)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RecptHeadMesg3)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RecptHeadMesg4)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RecptHeadMesg5)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.RecptHeadMesg6)
                    .IsRequired()
                    .HasMaxLength(80);

            

                entity.Property(e => e.RegId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SalesVatType)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ShopAddress).HasMaxLength(150);

                entity.Property(e => e.ShopGroupId).HasMaxLength(4);

                entity.Property(e => e.ShopId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.ShopLogoOnFrontScreen)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShopLogoOnReceipt)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ShopName).HasMaxLength(40);

                entity.Property(e => e.ShopRegAddressLine1).HasMaxLength(100);

                entity.Property(e => e.ShopRegAddressLine2).HasMaxLength(100);

                entity.Property(e => e.ShopRegAddressLine3).HasMaxLength(100);

                entity.Property(e => e.ShopRegId).HasMaxLength(20);

                entity.Property(e => e.ShopRegName).HasMaxLength(80);

                entity.Property(e => e.ShopTaxId).HasMaxLength(20);

                entity.Property(e => e.ShopTypeId).HasMaxLength(4);

                entity.Property(e => e.TaxId)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.TaxInvAddrLine1)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TaxInvAddrLine2)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TaxInvAddrLine3)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.TaxInvName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.TelId)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.WeightBarcodePrefix)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.WhsId)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.AllowSaleOverStock)
                 .IsRequired();

                entity.Property(e => e.PromptPayLink)
                  .IsRequired()
                  .HasMaxLength(100);

                entity.Property(e => e.QRCodeAccount)
                  .IsRequired()
                  .HasMaxLength(100);
            });

            modelBuilder.Entity<VpsMember>(entity =>
            {
                entity.HasKey(e => e.MbId);
                entity.Property(e => e.MbId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("MbId");

                entity.ToView("VpsMember");

                entity.Property(e => e.MemberTypeDesc)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MbDiscPs).HasColumnType("decimal(3, 2)");

                entity.Property(e => e.MbAccumPoint).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.MbAddress)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.MbAmphur)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.MbApplyDate).HasColumnType("date");

                entity.Property(e => e.MbBirthDay).HasColumnType("date");

                entity.Property(e => e.MbCardType)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MbEmail)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.MbExpireDate).HasColumnType("date");

                entity.Property(e => e.MbExpirePointDate).HasColumnType("date");

                entity.Property(e => e.MbGender)
                    .IsRequired()
                    .HasMaxLength(1);

              

                entity.Property(e => e.MbLineAddr1)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.MbLineAddr2)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.MbLineAddr3)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.MbNameE)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MbNameT)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MbNation)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MbNearlyExpirePoint).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.MbOccupation)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MbPhoto)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.MbProvince)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.MbRace)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MbTelNo)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.MbTumbol)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.MbType)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.MbZipCode)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.MbPid)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.SellUnitPriceNo)
                     .IsRequired();

                entity.Property(e => e.MbPriceFg)
                    .IsRequired();
                
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    
    }
}
