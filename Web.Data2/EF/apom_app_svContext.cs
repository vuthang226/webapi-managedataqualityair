using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Web.Data2.Entities;


#nullable disable

namespace Web.Data2.EF
{
    public partial class apom_app_svContext : DbContext
    {
        public apom_app_svContext()
        {
        }

        public apom_app_svContext(DbContextOptions<apom_app_svContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AComponent> AComponents { get; set; }
        public virtual DbSet<AComponentGeotiffDaily> AComponentGeotiffDailies { get; set; }
        public virtual DbSet<AComponentGeotiffIndexMemPm252021> AComponentGeotiffIndexMemPm252021s { get; set; }
        public virtual DbSet<AComponentGeotiffIndexMemPm252022> AComponentGeotiffIndexMemPm252022s { get; set; }
        public virtual DbSet<AComponentGeotiffIndexMemPm25nrt2022> AComponentGeotiffIndexMemPm25nrt2022s { get; set; }
        public virtual DbSet<AComponentGeotiffIndexWrfPm252021> AComponentGeotiffIndexWrfPm252021s { get; set; }
        public virtual DbSet<AComponentGeotiffIndexWrfPm252022> AComponentGeotiffIndexWrfPm252022s { get; set; }
        public virtual DbSet<AComponentGeotiffService> AComponentGeotiffServices { get; set; }
        public virtual DbSet<AComponentGeotiffValMemPm252021> AComponentGeotiffValMemPm252021s { get; set; }
        public virtual DbSet<AComponentGeotiffValMemPm252022> AComponentGeotiffValMemPm252022s { get; set; }
        public virtual DbSet<AComponentGeotiffValMemPm25nrt2022> AComponentGeotiffValMemPm25nrt2022s { get; set; }
        public virtual DbSet<AComponentGeotiffValWrfPm252021> AComponentGeotiffValWrfPm252021s { get; set; }
        public virtual DbSet<AComponentGeotiffValWrfPm252022> AComponentGeotiffValWrfPm252022s { get; set; }
        public virtual DbSet<AComponentStationDaily> AComponentStationDailies { get; set; }
        public virtual DbSet<ADlfileentry> ADlfileentries { get; set; }
        public virtual DbSet<ADlfileversion> ADlfileversions { get; set; }
        public virtual DbSet<ADlfolder> ADlfolders { get; set; }
        public virtual DbSet<AGroup> AGroups { get; set; }
        public virtual DbSet<AGroupComponent> AGroupComponents { get; set; }
        public virtual DbSet<Addr> Addrs { get; set; }
        public virtual DbSet<Addrfeat> Addrfeats { get; set; }
        public virtual DbSet<Bg> Bgs { get; set; }
        public virtual DbSet<CMapScale> CMapScales { get; set; }
        public virtual DbSet<CVnaqiIndex> CVnaqiIndices { get; set; }
        public virtual DbSet<CfPinnedLocation> CfPinnedLocations { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<CountyLookup> CountyLookups { get; set; }
        public virtual DbSet<CountysubLookup> CountysubLookups { get; set; }
        public virtual DbSet<Cousub> Cousubs { get; set; }
        public virtual DbSet<DirectionLookup> DirectionLookups { get; set; }
        public virtual DbSet<Edge> Edges { get; set; }
        public virtual DbSet<Face> Faces { get; set; }
        public virtual DbSet<Featname> Featnames { get; set; }
        public virtual DbSet<GeocodeSetting> GeocodeSettings { get; set; }
        public virtual DbSet<GeocodeSettingsDefault> GeocodeSettingsDefaults { get; set; }
        public virtual DbSet<GisAStation> GisAStations { get; set; }
        public virtual DbSet<GisAStationAqiPm25> GisAStationAqiPm25s { get; set; }
        public virtual DbSet<GisAdministrativeCommunne> GisAdministrativeCommunnes { get; set; }
        public virtual DbSet<GisAdministrativeDistrict> GisAdministrativeDistricts { get; set; }
        public virtual DbSet<GisAdministrativeProvince> GisAdministrativeProvinces { get; set; }
        public virtual DbSet<Layer> Layers { get; set; }
        public virtual DbSet<LoaderLookuptable> LoaderLookuptables { get; set; }
        public virtual DbSet<LoaderPlatform> LoaderPlatforms { get; set; }
        public virtual DbSet<LoaderVariable> LoaderVariables { get; set; }
        public virtual DbSet<MosaicSnowApom> MosaicSnowApoms { get; set; }
        public virtual DbSet<PagcGaz> PagcGazs { get; set; }
        public virtual DbSet<PagcLex> PagcLices { get; set; }
        public virtual DbSet<PagcRule> PagcRules { get; set; }
        public virtual DbSet<Place> Places { get; set; }
        public virtual DbSet<PlaceLookup> PlaceLookups { get; set; }
        public virtual DbSet<Pm25> Pm25s { get; set; }
        public virtual DbSet<Pm25Mem> Pm25Mems { get; set; }
        public virtual DbSet<Pm25Wrf> Pm25Wrves { get; set; }
        public virtual DbSet<Pm25Wrfchem> Pm25Wrfchems { get; set; }
        public virtual DbSet<RAdministrativeAvg> RAdministrativeAvgs { get; set; }
        public virtual DbSet<RAirPolution> RAirPolutions { get; set; }
        public virtual DbSet<RComponentStationDailyAvg> RComponentStationDailyAvgs { get; set; }
        public virtual DbSet<SecondaryUnitLookup> SecondaryUnitLookups { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<StateLookup> StateLookups { get; set; }
        public virtual DbSet<StreetTypeLookup> StreetTypeLookups { get; set; }
        public virtual DbSet<Tabblock> Tabblocks { get; set; }
        public virtual DbSet<Tabblock20> Tabblock20s { get; set; }
        public virtual DbSet<Topology> Topologies { get; set; }
        public virtual DbSet<Tract> Tracts { get; set; }
        public virtual DbSet<UGeneralSetting> UGeneralSettings { get; set; }
        public virtual DbSet<URole> URoles { get; set; }
        public virtual DbSet<UUser> UUsers { get; set; }
        public virtual DbSet<UUserRole> UUserRoles { get; set; }
        public virtual DbSet<VAComponentStationDaily7Day> VAComponentStationDaily7Days { get; set; }
        public virtual DbSet<VAComponentStationDailyGropuidLatest7Day> VAComponentStationDailyGropuidLatest7Days { get; set; }
        public virtual DbSet<VAdministrativeCommune> VAdministrativeCommunes { get; set; }
        public virtual DbSet<VAdministrativeDistrict> VAdministrativeDistricts { get; set; }
        public virtual DbSet<VAdministrativeProvince> VAdministrativeProvinces { get; set; }
        public virtual DbSet<VAdministrativeProvinceAvg> VAdministrativeProvinceAvgs { get; set; }
        public virtual DbSet<Zcta5> Zcta5s { get; set; }
        public virtual DbSet<ZipLookup> ZipLookups { get; set; }
        public virtual DbSet<ZipLookupAll> ZipLookupAlls { get; set; }
        public virtual DbSet<ZipLookupBase> ZipLookupBases { get; set; }
        public virtual DbSet<ZipState> ZipStates { get; set; }
        public virtual DbSet<ZipStateLoc> ZipStateLocs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=112.137.129.244;Port=5432;Database=apom_app_sv;User Id=sv;Password=sinhvien", x => x.UseNetTopologySuite());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("address_standardizer")
                .HasPostgresExtension("fuzzystrmatch")
                .HasPostgresExtension("postgis")
                .HasPostgresExtension("postgis_raster")
                .HasPostgresExtension("postgis_sfcgal")
                .HasPostgresExtension("postgis_tiger_geocoder")
                .HasPostgresExtension("postgis_topology")
                .HasAnnotation("Relational:Collation", "en_US.UTF-8");

            modelBuilder.Entity<AComponent>(entity =>
            {
                entity.ToTable("a_component");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("id");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Des)
                    .HasMaxLength(500)
                    .HasColumnName("des");

                entity.Property(e => e.DesEn)
                    .HasMaxLength(500)
                    .HasColumnName("des_en");

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .HasColumnName("icon");

                entity.Property(e => e.LegendDes)
                    .HasMaxLength(500)
                    .HasColumnName("legend_des");

                entity.Property(e => e.LegendDesEn)
                    .HasMaxLength(500)
                    .HasColumnName("legend_des_en");

                entity.Property(e => e.LegendImg)
                    .HasMaxLength(50)
                    .HasColumnName("legend_img");

                entity.Property(e => e.Modifydate).HasColumnName("modifydate");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(255)
                    .HasColumnName("name_en");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<AComponentGeotiffDaily>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("a_component_geotiff_daily_pkey1");

                entity.ToTable("a_component_geotiff_daily");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("category_id");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.DateShooting).HasColumnName("date_shooting");

                entity.Property(e => e.Filename)
                    .HasMaxLength(100)
                    .HasColumnName("filename");

                entity.Property(e => e.GroupcomponentId)
                    .HasMaxLength(50)
                    .HasColumnName("groupcomponent_id");

                entity.Property(e => e.MaxX).HasColumnName("max_x");

                entity.Property(e => e.MaxY).HasColumnName("max_y");

                entity.Property(e => e.MinX).HasColumnName("min_x");

                entity.Property(e => e.MinY).HasColumnName("min_y");

                entity.Property(e => e.Modifydate).HasColumnName("modifydate");

                entity.Property(e => e.Projectioncode)
                    .HasMaxLength(50)
                    .HasColumnName("projectioncode");

                entity.Property(e => e.ResolutionX).HasColumnName("resolution_x");

                entity.Property(e => e.ResolutionY).HasColumnName("resolution_y");

                entity.Property(e => e.Tableindex)
                    .HasMaxLength(100)
                    .HasColumnName("tableindex");

                entity.Property(e => e.Tablename)
                    .HasMaxLength(100)
                    .HasColumnName("tablename");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("user_id");

                entity.HasOne(d => d.Groupcomponent)
                    .WithMany(p => p.AComponentGeotiffDailies)
                    .HasForeignKey(d => d.GroupcomponentId)
                    .HasConstraintName("a_component_geotiff_daily_groupcomponent_id_fkey1");
            });

            modelBuilder.Entity<AComponentGeotiffIndexMemPm252021>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_component_geotiff_index_pm25_2021_pkey");

                entity.ToTable("a_component_geotiff_index_mem_pm25_2021");

                entity.Property(e => e.Oid)
                    .HasColumnName("oid")
                    .HasDefaultValueSql("nextval('a_component_geotiff_index_pm25_2021_oid_seq'::regclass)");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("category_id");

                entity.Property(e => e.FromCell).HasColumnName("from_cell");

                entity.Property(e => e.RowIndex).HasColumnName("row_index");

                entity.Property(e => e.ToCell).HasColumnName("to_cell");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AComponentGeotiffIndexMemPm252021s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("a_component_geotiff_index_mem_pm25_2021_category_id_fkey");
            });

            modelBuilder.Entity<AComponentGeotiffIndexMemPm252022>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_component_geotiff_index_pm25_2022_pkey");

                entity.ToTable("a_component_geotiff_index_mem_pm25_2022");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("category_id");

                entity.Property(e => e.FromCell).HasColumnName("from_cell");

                entity.Property(e => e.RowIndex).HasColumnName("row_index");

                entity.Property(e => e.ToCell).HasColumnName("to_cell");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AComponentGeotiffIndexMemPm252022s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("a_component_geotiff_index_mem_pm25_2022_category_id_fkey");
            });

            modelBuilder.Entity<AComponentGeotiffIndexMemPm25nrt2022>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_component_geotiff_index_pm25nrt_2022_pkey");

                entity.ToTable("a_component_geotiff_index_mem_pm25nrt_2022");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("category_id");

                entity.Property(e => e.FromCell).HasColumnName("from_cell");

                entity.Property(e => e.RowIndex).HasColumnName("row_index");

                entity.Property(e => e.ToCell).HasColumnName("to_cell");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AComponentGeotiffIndexMemPm25nrt2022s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("a_component_geotiff_index_mem_pm25nrt_2022_category_id_fkey");
            });

            modelBuilder.Entity<AComponentGeotiffIndexWrfPm252021>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_component_geotiff_index_wrf_pm25_2021_pkey");

                entity.ToTable("a_component_geotiff_index_wrf_pm25_2021");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("category_id");

                entity.Property(e => e.FromCell).HasColumnName("from_cell");

                entity.Property(e => e.RowIndex).HasColumnName("row_index");

                entity.Property(e => e.ToCell).HasColumnName("to_cell");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AComponentGeotiffIndexWrfPm252021s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("a_component_geotiff_index_wrf_pm25_2021_category_id_fkey");
            });

            modelBuilder.Entity<AComponentGeotiffIndexWrfPm252022>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_component_geotiff_index_wrf_pm25_2022_pkey");

                entity.ToTable("a_component_geotiff_index_wrf_pm25_2022");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("category_id");

                entity.Property(e => e.FromCell).HasColumnName("from_cell");

                entity.Property(e => e.RowIndex).HasColumnName("row_index");

                entity.Property(e => e.ToCell).HasColumnName("to_cell");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AComponentGeotiffIndexWrfPm252022s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("a_component_geotiff_index_wrf_pm25_2022_category_id_fkey");
            });

            modelBuilder.Entity<AComponentGeotiffService>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_component_geotiff_service_pkey");

                entity.ToTable("a_component_geotiff_service");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Featurebase)
                    .HasMaxLength(100)
                    .HasColumnName("featurebase");

                entity.Property(e => e.Featuretype)
                    .HasMaxLength(100)
                    .HasColumnName("featuretype");

                entity.Property(e => e.GroupcomponentId)
                    .HasMaxLength(50)
                    .HasColumnName("groupcomponent_id");

                entity.Property(e => e.Modifydate).HasColumnName("modifydate");

                entity.Property(e => e.Orderservice).HasColumnName("orderservice");

                entity.Property(e => e.Timeslider)
                    .HasColumnName("timeslider")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .HasColumnName("type");

                entity.Property(e => e.Typeslider)
                    .HasMaxLength(10)
                    .HasColumnName("typeslider");

                entity.Property(e => e.Urlservice)
                    .HasMaxLength(255)
                    .HasColumnName("urlservice");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("user_id");

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasDefaultValueSql("true");

                entity.HasOne(d => d.Groupcomponent)
                    .WithMany(p => p.AComponentGeotiffServices)
                    .HasForeignKey(d => d.GroupcomponentId)
                    .HasConstraintName("a_component_geotiff_daily_groupcomponent_id_fkey");
            });

            modelBuilder.Entity<AComponentGeotiffValMemPm252021>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_component_geotiff_val_pm25_2021_pkey");

                entity.ToTable("a_component_geotiff_val_mem_pm25_2021");

                entity.Property(e => e.Oid)
                    .HasColumnName("oid")
                    .HasDefaultValueSql("nextval('a_component_geotiff_val_pm25_2021_oid_seq'::regclass)");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("category_id");

                entity.Property(e => e.Maxx).HasColumnName("maxx");

                entity.Property(e => e.Maxy).HasColumnName("maxy");

                entity.Property(e => e.Minx).HasColumnName("minx");

                entity.Property(e => e.Miny).HasColumnName("miny");

                entity.Property(e => e.RowIndex).HasColumnName("row_index");

                entity.Property(e => e.RowVal).HasColumnName("row_val");

                entity.Property(e => e.RowValAqi).HasColumnName("row_val_aqi");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AComponentGeotiffValMemPm252021s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("a_component_geotiff_val_mem_pm25_2021_category_id_fkey");
            });

            modelBuilder.Entity<AComponentGeotiffValMemPm252022>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_component_geotiff_val_pm25_2022_pkey");

                entity.ToTable("a_component_geotiff_val_mem_pm25_2022");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("category_id");

                entity.Property(e => e.Maxx).HasColumnName("maxx");

                entity.Property(e => e.Maxy).HasColumnName("maxy");

                entity.Property(e => e.Minx).HasColumnName("minx");

                entity.Property(e => e.Miny).HasColumnName("miny");

                entity.Property(e => e.RowIndex).HasColumnName("row_index");

                entity.Property(e => e.RowVal).HasColumnName("row_val");

                entity.Property(e => e.RowValAqi).HasColumnName("row_val_aqi");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AComponentGeotiffValMemPm252022s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("a_component_geotiff_val_mem_pm25_2022_category_id_fkey");
            });

            modelBuilder.Entity<AComponentGeotiffValMemPm25nrt2022>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_component_geotiff_val_pm25nrt_2022_pkey");

                entity.ToTable("a_component_geotiff_val_mem_pm25nrt_2022");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("category_id");

                entity.Property(e => e.Maxx).HasColumnName("maxx");

                entity.Property(e => e.Maxy).HasColumnName("maxy");

                entity.Property(e => e.Minx).HasColumnName("minx");

                entity.Property(e => e.Miny).HasColumnName("miny");

                entity.Property(e => e.RowIndex).HasColumnName("row_index");

                entity.Property(e => e.RowVal).HasColumnName("row_val");

                entity.Property(e => e.RowValAqi).HasColumnName("row_val_aqi");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AComponentGeotiffValMemPm25nrt2022s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("a_component_geotiff_val_mem_pm25nrt_2022_category_id_fkey");
            });

            modelBuilder.Entity<AComponentGeotiffValWrfPm252021>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_component_geotiff_val_wrf_pm25_2021_pkey");

                entity.ToTable("a_component_geotiff_val_wrf_pm25_2021");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("category_id");

                entity.Property(e => e.Maxx).HasColumnName("maxx");

                entity.Property(e => e.Maxy).HasColumnName("maxy");

                entity.Property(e => e.Minx).HasColumnName("minx");

                entity.Property(e => e.Miny).HasColumnName("miny");

                entity.Property(e => e.RowIndex).HasColumnName("row_index");

                entity.Property(e => e.RowVal).HasColumnName("row_val");

                entity.Property(e => e.RowValAqi).HasColumnName("row_val_aqi");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AComponentGeotiffValWrfPm252021s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("a_component_geotiff_val_wrf_pm25_2021_category_id_fkey");
            });

            modelBuilder.Entity<AComponentGeotiffValWrfPm252022>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_component_geotiff_val_wrf_pm25_2022_pkey");

                entity.ToTable("a_component_geotiff_val_wrf_pm25_2022");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("category_id");

                entity.Property(e => e.Maxx).HasColumnName("maxx");

                entity.Property(e => e.Maxy).HasColumnName("maxy");

                entity.Property(e => e.Minx).HasColumnName("minx");

                entity.Property(e => e.Miny).HasColumnName("miny");

                entity.Property(e => e.RowIndex).HasColumnName("row_index");

                entity.Property(e => e.RowVal).HasColumnName("row_val");

                entity.Property(e => e.RowValAqi).HasColumnName("row_val_aqi");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AComponentGeotiffValWrfPm252022s)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("a_component_geotiff_val_wrf_pm25_2022_category_id_fkey");
            });

            modelBuilder.Entity<AComponentStationDaily>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_component_station_daily_pkey");

                entity.ToTable("a_component_station_daily");

                entity.HasIndex(e => e.SearchTsv, "a_component_station_daily_idx")
                    .HasMethod("gin");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Altm).HasColumnName("altm");

                entity.Property(e => e.Aqi).HasColumnName("aqi");

                entity.Property(e => e.AqiCo).HasColumnName("aqi_co");

                entity.Property(e => e.AqiNo2).HasColumnName("aqi_no2");

                entity.Property(e => e.AqiO3).HasColumnName("aqi_o3");

                entity.Property(e => e.AqiPm10).HasColumnName("aqi_pm10");

                entity.Property(e => e.AqiPm25).HasColumnName("aqi_pm25");

                entity.Property(e => e.AqiSo2).HasColumnName("aqi_so2");

                entity.Property(e => e.Co).HasColumnName("co");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.DataShooting)
                    .HasColumnType("jsonb")
                    .HasColumnName("data_shooting");

                entity.Property(e => e.DatetimeShooting).HasColumnName("datetime_shooting");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .HasColumnName("group_id");

                entity.Property(e => e.Hud).HasColumnName("hud");

                entity.Property(e => e.Modifydate).HasColumnName("modifydate");

                entity.Property(e => e.No2).HasColumnName("no2");

                entity.Property(e => e.O3).HasColumnName("o3");

                entity.Property(e => e.Pm10).HasColumnName("pm10");

                entity.Property(e => e.Pm25).HasColumnName("pm25");

                entity.Property(e => e.SearchTsv).HasColumnName("search_tsv");

                entity.Property(e => e.So2).HasColumnName("so2");

                entity.Property(e => e.Temp).HasColumnName("temp");

                entity.Property(e => e.UserId)
                    .HasColumnType("character varying")
                    .HasColumnName("user_id");

                entity.Property(e => e.Vis).HasColumnName("vis");

                entity.Property(e => e.Wdir).HasColumnName("wdir");

                entity.Property(e => e.Wspd).HasColumnName("wspd");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AComponentStationDailies)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("gis_a_station_group_id_pkey");
            });

            modelBuilder.Entity<ADlfileentry>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_dlfileentry_pkey");

                entity.ToTable("a_dlfileentry");

                entity.HasIndex(e => e.Fileentryid, "a_dlfileentry_fileentryid_key")
                    .IsUnique();

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Classname)
                    .HasMaxLength(255)
                    .HasColumnName("classname");

                entity.Property(e => e.Classpk)
                    .HasMaxLength(50)
                    .HasColumnName("classpk");

                entity.Property(e => e.Createdate)
                    .HasColumnType("date")
                    .HasColumnName("createdate");

                entity.Property(e => e.Extension)
                    .HasMaxLength(10)
                    .HasColumnName("extension");

                entity.Property(e => e.Fileentryid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("fileentryid")
                    .HasComment("ma tai lieu");

                entity.Property(e => e.Folderid)
                    .HasMaxLength(50)
                    .HasColumnName("folderid")
                    .HasComment("thu muc chua tai lieu");

                entity.Property(e => e.Host)
                    .HasMaxLength(255)
                    .HasColumnName("host");

                entity.Property(e => e.Mimetype)
                    .HasMaxLength(100)
                    .HasColumnName("mimetype");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("date")
                    .HasColumnName("modifydate");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Repositoryid)
                    .HasMaxLength(50)
                    .HasColumnName("repositoryid")
                    .HasComment("kho tai lieu - co the la organizationid");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.Treepath)
                    .HasMaxLength(255)
                    .HasColumnName("treepath");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .HasColumnName("userid");

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .HasColumnName("version");

                entity.HasOne(d => d.Folder)
                    .WithMany(p => p.ADlfileentries)
                    .HasPrincipalKey(p => p.Folderid)
                    .HasForeignKey(d => d.Folderid)
                    .HasConstraintName("a_dlfileentry_folderid_fkey");
            });

            modelBuilder.Entity<ADlfileversion>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_dlfileversion_pkey");

                entity.ToTable("a_dlfileversion");

                entity.HasIndex(e => e.Fileversionid, "a_dlfileversion_fileversionid_key")
                    .IsUnique();

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Classname)
                    .HasMaxLength(255)
                    .HasColumnName("classname");

                entity.Property(e => e.Classpk)
                    .HasMaxLength(50)
                    .HasColumnName("classpk");

                entity.Property(e => e.Createdate)
                    .HasColumnType("date")
                    .HasColumnName("createdate");

                entity.Property(e => e.Extension)
                    .HasMaxLength(10)
                    .HasColumnName("extension");

                entity.Property(e => e.Fileentryid)
                    .HasMaxLength(50)
                    .HasColumnName("fileentryid");

                entity.Property(e => e.Fileversionid)
                    .HasMaxLength(50)
                    .HasColumnName("fileversionid");

                entity.Property(e => e.Folderid)
                    .HasMaxLength(50)
                    .HasColumnName("folderid");

                entity.Property(e => e.Host)
                    .HasMaxLength(255)
                    .HasColumnName("host");

                entity.Property(e => e.Mimetype)
                    .HasMaxLength(100)
                    .HasColumnName("mimetype");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("date")
                    .HasColumnName("modifydate");

                entity.Property(e => e.Repositoryid)
                    .HasMaxLength(50)
                    .HasColumnName("repositoryid");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.Treepath)
                    .HasMaxLength(255)
                    .HasColumnName("treepath");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .HasColumnName("userid");

                entity.Property(e => e.Version)
                    .HasMaxLength(10)
                    .HasColumnName("version");

                entity.HasOne(d => d.Fileentry)
                    .WithMany(p => p.ADlfileversions)
                    .HasPrincipalKey(p => p.Fileentryid)
                    .HasForeignKey(d => d.Fileentryid)
                    .HasConstraintName("a_dlfileversion_fileentryid_fkey");

                entity.HasOne(d => d.Folder)
                    .WithMany(p => p.ADlfileversions)
                    .HasPrincipalKey(p => p.Folderid)
                    .HasForeignKey(d => d.Folderid)
                    .HasConstraintName("a_dlfileversion_folderid_fkey");
            });

            modelBuilder.Entity<ADlfolder>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("a_dlfolder_pkey");

                entity.ToTable("a_dlfolder");

                entity.HasIndex(e => e.Folderid, "a_dlfolder_folderid_key")
                    .IsUnique();

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Createdate)
                    .HasColumnType("date")
                    .HasColumnName("createdate");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.Folderid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("folderid");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("date")
                    .HasColumnName("modifydate");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Parentfolderid)
                    .HasMaxLength(50)
                    .HasColumnName("parentfolderid");

                entity.Property(e => e.Repositoryid)
                    .HasMaxLength(50)
                    .HasColumnName("repositoryid");

                entity.Property(e => e.Treepath)
                    .HasMaxLength(255)
                    .HasColumnName("treepath");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<AGroup>(entity =>
            {
                entity.ToTable("a_group");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("id");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Des)
                    .HasMaxLength(500)
                    .HasColumnName("des");

                entity.Property(e => e.DesEn)
                    .HasMaxLength(500)
                    .HasColumnName("des_en");

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .HasColumnName("icon");

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Isaqi).HasColumnName("isaqi");

                entity.Property(e => e.Isgroup)
                    .HasColumnName("isgroup")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.IslayerModel)
                    .HasColumnName("islayer_model")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Isstation).HasColumnName("isstation");

                entity.Property(e => e.IsstationWeather)
                    .HasColumnName("isstation_weather")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Modifydate).HasColumnName("modifydate");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(255)
                    .HasColumnName("name_en");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(50)
                    .HasColumnName("parent_id");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<AGroupComponent>(entity =>
            {
                entity.ToTable("a_group_component");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("id");

                entity.Property(e => e.ComponentId)
                    .HasMaxLength(50)
                    .HasColumnName("component_id");

                entity.Property(e => e.Createdate)
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .HasColumnName("group_id");

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Isshow)
                    .HasColumnName("isshow")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Modifydate).HasColumnName("modifydate");

                entity.Property(e => e.Ordercomponent).HasColumnName("ordercomponent");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("user_id");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.AGroupComponents)
                    .HasForeignKey(d => d.ComponentId)
                    .HasConstraintName("a_group_component_component_id_fkey");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AGroupComponents)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("a_group_component_group_id_fkey");
            });

            modelBuilder.Entity<Addr>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("addr_pkey");

                entity.ToTable("addr", "tiger");

                entity.HasIndex(e => new { e.Tlid, e.Statefp }, "idx_tiger_addr_tlid_statefp");

                entity.HasIndex(e => e.Zip, "idx_tiger_addr_zip");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Arid)
                    .HasMaxLength(22)
                    .HasColumnName("arid");

                entity.Property(e => e.Fromarmid).HasColumnName("fromarmid");

                entity.Property(e => e.Fromhn)
                    .HasMaxLength(12)
                    .HasColumnName("fromhn");

                entity.Property(e => e.Fromtyp)
                    .HasMaxLength(1)
                    .HasColumnName("fromtyp");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Plus4)
                    .HasMaxLength(4)
                    .HasColumnName("plus4");

                entity.Property(e => e.Side)
                    .HasMaxLength(1)
                    .HasColumnName("side");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Tlid).HasColumnName("tlid");

                entity.Property(e => e.Toarmid).HasColumnName("toarmid");

                entity.Property(e => e.Tohn)
                    .HasMaxLength(12)
                    .HasColumnName("tohn");

                entity.Property(e => e.Totyp)
                    .HasMaxLength(1)
                    .HasColumnName("totyp");

                entity.Property(e => e.Zip)
                    .HasMaxLength(5)
                    .HasColumnName("zip");
            });

            modelBuilder.Entity<Addrfeat>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("addrfeat_pkey");

                entity.ToTable("addrfeat", "tiger");

                entity.HasIndex(e => e.TheGeom, "idx_addrfeat_geom_gist")
                    .HasMethod("gist");

                entity.HasIndex(e => e.Tlid, "idx_addrfeat_tlid");

                entity.HasIndex(e => e.Zipl, "idx_addrfeat_zipl");

                entity.HasIndex(e => e.Zipr, "idx_addrfeat_zipr");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Aridl)
                    .HasMaxLength(22)
                    .HasColumnName("aridl");

                entity.Property(e => e.Aridr)
                    .HasMaxLength(22)
                    .HasColumnName("aridr");

                entity.Property(e => e.EdgeMtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("edge_mtfcc");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("fullname");

                entity.Property(e => e.Lfromhn)
                    .HasMaxLength(12)
                    .HasColumnName("lfromhn");

                entity.Property(e => e.Lfromtyp)
                    .HasMaxLength(1)
                    .HasColumnName("lfromtyp");

                entity.Property(e => e.Linearid)
                    .HasMaxLength(22)
                    .HasColumnName("linearid");

                entity.Property(e => e.Ltohn)
                    .HasMaxLength(12)
                    .HasColumnName("ltohn");

                entity.Property(e => e.Ltotyp)
                    .HasMaxLength(1)
                    .HasColumnName("ltotyp");

                entity.Property(e => e.Offsetl)
                    .HasMaxLength(1)
                    .HasColumnName("offsetl");

                entity.Property(e => e.Offsetr)
                    .HasMaxLength(1)
                    .HasColumnName("offsetr");

                entity.Property(e => e.Parityl)
                    .HasMaxLength(1)
                    .HasColumnName("parityl");

                entity.Property(e => e.Parityr)
                    .HasMaxLength(1)
                    .HasColumnName("parityr");

                entity.Property(e => e.Plus4l)
                    .HasMaxLength(4)
                    .HasColumnName("plus4l");

                entity.Property(e => e.Plus4r)
                    .HasMaxLength(4)
                    .HasColumnName("plus4r");

                entity.Property(e => e.Rfromhn)
                    .HasMaxLength(12)
                    .HasColumnName("rfromhn");

                entity.Property(e => e.Rfromtyp)
                    .HasMaxLength(1)
                    .HasColumnName("rfromtyp");

                entity.Property(e => e.Rtohn)
                    .HasMaxLength(12)
                    .HasColumnName("rtohn");

                entity.Property(e => e.Rtotyp)
                    .HasMaxLength(1)
                    .HasColumnName("rtotyp");

                entity.Property(e => e.Statefp)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.TheGeom).HasColumnName("the_geom");

                entity.Property(e => e.Tlid).HasColumnName("tlid");

                entity.Property(e => e.Zipl)
                    .HasMaxLength(5)
                    .HasColumnName("zipl");

                entity.Property(e => e.Zipr)
                    .HasMaxLength(5)
                    .HasColumnName("zipr");
            });

            modelBuilder.Entity<Bg>(entity =>
            {
                entity.ToTable("bg", "tiger");

                entity.HasComment("block groups");

                entity.Property(e => e.BgId)
                    .HasMaxLength(12)
                    .HasColumnName("bg_id");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Blkgrpce)
                    .HasMaxLength(1)
                    .HasColumnName("blkgrpce");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Namelsad)
                    .HasMaxLength(13)
                    .HasColumnName("namelsad");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.TheGeom).HasColumnName("the_geom");

                entity.Property(e => e.Tractce)
                    .HasMaxLength(6)
                    .HasColumnName("tractce");
            });

            modelBuilder.Entity<CMapScale>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("c_map_scale_pkey");

                entity.ToTable("c_map_scale");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.ScaleAlias)
                    .HasMaxLength(50)
                    .HasColumnName("scale_alias");

                entity.Property(e => e.ScaleVal).HasColumnName("scale_val");
            });

            modelBuilder.Entity<CVnaqiIndex>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("c_vnaqi_index_pkey");

                entity.ToTable("c_vnaqi_index");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.AqiDes)
                    .HasMaxLength(500)
                    .HasColumnName("aqi_des");

                entity.Property(e => e.AqiDesEn)
                    .HasMaxLength(500)
                    .HasColumnName("aqi_des_en");

                entity.Property(e => e.AqiFrom).HasColumnName("aqi_from");

                entity.Property(e => e.AqiPm25From).HasColumnName("aqi_pm25_from");

                entity.Property(e => e.AqiPm25To).HasColumnName("aqi_pm25_to");

                entity.Property(e => e.AqiStatusname)
                    .HasMaxLength(50)
                    .HasColumnName("aqi_statusname");

                entity.Property(e => e.AqiStatusnameEn)
                    .HasMaxLength(50)
                    .HasColumnName("aqi_statusname_en");

                entity.Property(e => e.AqiTo).HasColumnName("aqi_to");

                entity.Property(e => e.BgColor)
                    .HasMaxLength(50)
                    .HasColumnName("bg_color");

                entity.Property(e => e.FontColor)
                    .HasMaxLength(20)
                    .HasColumnName("font_color");
            });

            modelBuilder.Entity<CfPinnedLocation>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("cf_pinned_location_pkey");

                entity.ToTable("cf_pinned_location");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(50)
                    .HasColumnName("province_id");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("user_id");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.CfPinnedLocations)
                    .HasPrincipalKey(p => p.ProvinceId)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("cf_pinned_location_province_id_fkey");
            });

            modelBuilder.Entity<County>(entity =>
            {
                entity.HasKey(e => e.Cntyidfp)
                    .HasName("pk_tiger_county");

                entity.ToTable("county", "tiger");

                entity.HasIndex(e => e.Countyfp, "idx_tiger_county");

                entity.HasIndex(e => e.Gid, "uidx_county_gid")
                    .IsUnique();

                entity.Property(e => e.Cntyidfp)
                    .HasMaxLength(5)
                    .HasColumnName("cntyidfp");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Cbsafp)
                    .HasMaxLength(5)
                    .HasColumnName("cbsafp");

                entity.Property(e => e.Classfp)
                    .HasMaxLength(2)
                    .HasColumnName("classfp");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Countyns)
                    .HasMaxLength(8)
                    .HasColumnName("countyns");

                entity.Property(e => e.Csafp)
                    .HasMaxLength(3)
                    .HasColumnName("csafp");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Lsad)
                    .HasMaxLength(2)
                    .HasColumnName("lsad");

                entity.Property(e => e.Metdivfp)
                    .HasMaxLength(5)
                    .HasColumnName("metdivfp");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Namelsad)
                    .HasMaxLength(100)
                    .HasColumnName("namelsad");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.TheGeom).HasColumnName("the_geom");
            });

            modelBuilder.Entity<CountyLookup>(entity =>
            {
                entity.HasKey(e => new { e.StCode, e.CoCode })
                    .HasName("county_lookup_pkey");

                entity.ToTable("county_lookup", "tiger");

                entity.HasIndex(e => e.State, "county_lookup_state_idx");

                entity.Property(e => e.StCode).HasColumnName("st_code");

                entity.Property(e => e.CoCode).HasColumnName("co_code");

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .HasColumnName("name");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<CountysubLookup>(entity =>
            {
                entity.HasKey(e => new { e.StCode, e.CoCode, e.CsCode })
                    .HasName("countysub_lookup_pkey");

                entity.ToTable("countysub_lookup", "tiger");

                entity.HasIndex(e => e.State, "countysub_lookup_state_idx");

                entity.Property(e => e.StCode).HasColumnName("st_code");

                entity.Property(e => e.CoCode).HasColumnName("co_code");

                entity.Property(e => e.CsCode).HasColumnName("cs_code");

                entity.Property(e => e.County)
                    .HasMaxLength(90)
                    .HasColumnName("county");

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .HasColumnName("name");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<Cousub>(entity =>
            {
                entity.HasKey(e => e.Cosbidfp)
                    .HasName("cousub_pkey");

                entity.ToTable("cousub", "tiger");

                entity.HasIndex(e => e.TheGeom, "tige_cousub_the_geom_gist")
                    .HasMethod("gist");

                entity.HasIndex(e => e.Gid, "uidx_cousub_gid")
                    .IsUnique();

                entity.Property(e => e.Cosbidfp)
                    .HasMaxLength(10)
                    .HasColumnName("cosbidfp");

                entity.Property(e => e.Aland)
                    .HasPrecision(14)
                    .HasColumnName("aland");

                entity.Property(e => e.Awater)
                    .HasPrecision(14)
                    .HasColumnName("awater");

                entity.Property(e => e.Classfp)
                    .HasMaxLength(2)
                    .HasColumnName("classfp");

                entity.Property(e => e.Cnectafp)
                    .HasMaxLength(3)
                    .HasColumnName("cnectafp");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Cousubfp)
                    .HasMaxLength(5)
                    .HasColumnName("cousubfp");

                entity.Property(e => e.Cousubns)
                    .HasMaxLength(8)
                    .HasColumnName("cousubns");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Lsad)
                    .HasMaxLength(2)
                    .HasColumnName("lsad");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Namelsad)
                    .HasMaxLength(100)
                    .HasColumnName("namelsad");

                entity.Property(e => e.Nctadvfp)
                    .HasMaxLength(5)
                    .HasColumnName("nctadvfp");

                entity.Property(e => e.Nectafp)
                    .HasMaxLength(5)
                    .HasColumnName("nectafp");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.TheGeom).HasColumnName("the_geom");
            });

            modelBuilder.Entity<DirectionLookup>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("direction_lookup_pkey");

                entity.ToTable("direction_lookup", "tiger");

                entity.HasIndex(e => e.Abbrev, "direction_lookup_abbrev_idx");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(3)
                    .HasColumnName("abbrev");
            });

            modelBuilder.Entity<Edge>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("edges_pkey");

                entity.ToTable("edges", "tiger");

                entity.HasIndex(e => e.Tlid, "idx_edges_tlid");

                entity.HasIndex(e => e.Countyfp, "idx_tiger_edges_countyfp");

                entity.HasIndex(e => e.TheGeom, "idx_tiger_edges_the_geom_gist")
                    .HasMethod("gist");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Artpath)
                    .HasMaxLength(1)
                    .HasColumnName("artpath");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Deckedroad)
                    .HasMaxLength(1)
                    .HasColumnName("deckedroad");

                entity.Property(e => e.Divroad)
                    .HasMaxLength(1)
                    .HasColumnName("divroad");

                entity.Property(e => e.Exttyp)
                    .HasMaxLength(1)
                    .HasColumnName("exttyp");

                entity.Property(e => e.Featcat)
                    .HasMaxLength(1)
                    .HasColumnName("featcat");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("fullname");

                entity.Property(e => e.Gcseflg)
                    .HasMaxLength(1)
                    .HasColumnName("gcseflg");

                entity.Property(e => e.Hydroflg)
                    .HasMaxLength(1)
                    .HasColumnName("hydroflg");

                entity.Property(e => e.Lfromadd)
                    .HasMaxLength(12)
                    .HasColumnName("lfromadd");

                entity.Property(e => e.Ltoadd)
                    .HasMaxLength(12)
                    .HasColumnName("ltoadd");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Offsetl)
                    .HasMaxLength(1)
                    .HasColumnName("offsetl");

                entity.Property(e => e.Offsetr)
                    .HasMaxLength(1)
                    .HasColumnName("offsetr");

                entity.Property(e => e.Olfflg)
                    .HasMaxLength(1)
                    .HasColumnName("olfflg");

                entity.Property(e => e.Passflg)
                    .HasMaxLength(1)
                    .HasColumnName("passflg");

                entity.Property(e => e.Persist)
                    .HasMaxLength(1)
                    .HasColumnName("persist");

                entity.Property(e => e.Railflg)
                    .HasMaxLength(1)
                    .HasColumnName("railflg");

                entity.Property(e => e.Rfromadd)
                    .HasMaxLength(12)
                    .HasColumnName("rfromadd");

                entity.Property(e => e.Roadflg)
                    .HasMaxLength(1)
                    .HasColumnName("roadflg");

                entity.Property(e => e.Rtoadd)
                    .HasMaxLength(12)
                    .HasColumnName("rtoadd");

                entity.Property(e => e.Smid)
                    .HasMaxLength(22)
                    .HasColumnName("smid");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Tfidl)
                    .HasPrecision(10)
                    .HasColumnName("tfidl");

                entity.Property(e => e.Tfidr)
                    .HasPrecision(10)
                    .HasColumnName("tfidr");

                entity.Property(e => e.TheGeom).HasColumnName("the_geom");

                entity.Property(e => e.Tlid).HasColumnName("tlid");

                entity.Property(e => e.Tnidf)
                    .HasPrecision(10)
                    .HasColumnName("tnidf");

                entity.Property(e => e.Tnidt)
                    .HasPrecision(10)
                    .HasColumnName("tnidt");

                entity.Property(e => e.Ttyp)
                    .HasMaxLength(1)
                    .HasColumnName("ttyp");

                entity.Property(e => e.Zipl)
                    .HasMaxLength(5)
                    .HasColumnName("zipl");

                entity.Property(e => e.Zipr)
                    .HasMaxLength(5)
                    .HasColumnName("zipr");
            });

            modelBuilder.Entity<Face>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("faces_pkey");

                entity.ToTable("faces", "tiger");

                entity.HasIndex(e => e.Countyfp, "idx_tiger_faces_countyfp");

                entity.HasIndex(e => e.Tfid, "idx_tiger_faces_tfid");

                entity.HasIndex(e => e.TheGeom, "tiger_faces_the_geom_gist")
                    .HasMethod("gist");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Aiannhce)
                    .HasMaxLength(4)
                    .HasColumnName("aiannhce");

                entity.Property(e => e.Aiannhce00)
                    .HasMaxLength(4)
                    .HasColumnName("aiannhce00");

                entity.Property(e => e.Aiannhfp)
                    .HasMaxLength(5)
                    .HasColumnName("aiannhfp");

                entity.Property(e => e.Aiannhfp00)
                    .HasMaxLength(5)
                    .HasColumnName("aiannhfp00");

                entity.Property(e => e.Anrcfp)
                    .HasMaxLength(5)
                    .HasColumnName("anrcfp");

                entity.Property(e => e.Anrcfp00)
                    .HasMaxLength(5)
                    .HasColumnName("anrcfp00");

                entity.Property(e => e.Atotal).HasColumnName("atotal");

                entity.Property(e => e.Blkgrpce)
                    .HasMaxLength(1)
                    .HasColumnName("blkgrpce");

                entity.Property(e => e.Blkgrpce00)
                    .HasMaxLength(1)
                    .HasColumnName("blkgrpce00");

                entity.Property(e => e.Blockce)
                    .HasMaxLength(4)
                    .HasColumnName("blockce");

                entity.Property(e => e.Blockce00)
                    .HasMaxLength(4)
                    .HasColumnName("blockce00");

                entity.Property(e => e.Cbsafp)
                    .HasMaxLength(5)
                    .HasColumnName("cbsafp");

                entity.Property(e => e.Cd108fp)
                    .HasMaxLength(2)
                    .HasColumnName("cd108fp");

                entity.Property(e => e.Cd111fp)
                    .HasMaxLength(2)
                    .HasColumnName("cd111fp");

                entity.Property(e => e.Cnectafp)
                    .HasMaxLength(3)
                    .HasColumnName("cnectafp");

                entity.Property(e => e.Comptyp)
                    .HasMaxLength(1)
                    .HasColumnName("comptyp");

                entity.Property(e => e.Comptyp00)
                    .HasMaxLength(1)
                    .HasColumnName("comptyp00");

                entity.Property(e => e.Conctyfp)
                    .HasMaxLength(5)
                    .HasColumnName("conctyfp");

                entity.Property(e => e.Conctyfp00)
                    .HasMaxLength(5)
                    .HasColumnName("conctyfp00");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Countyfp00)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp00");

                entity.Property(e => e.Cousubfp)
                    .HasMaxLength(5)
                    .HasColumnName("cousubfp");

                entity.Property(e => e.Cousubfp00)
                    .HasMaxLength(5)
                    .HasColumnName("cousubfp00");

                entity.Property(e => e.Csafp)
                    .HasMaxLength(3)
                    .HasColumnName("csafp");

                entity.Property(e => e.Elsdlea)
                    .HasMaxLength(5)
                    .HasColumnName("elsdlea");

                entity.Property(e => e.Elsdlea00)
                    .HasMaxLength(5)
                    .HasColumnName("elsdlea00");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Lwflag)
                    .HasMaxLength(1)
                    .HasColumnName("lwflag");

                entity.Property(e => e.Metdivfp)
                    .HasMaxLength(5)
                    .HasColumnName("metdivfp");

                entity.Property(e => e.Nctadvfp)
                    .HasMaxLength(5)
                    .HasColumnName("nctadvfp");

                entity.Property(e => e.Nectafp)
                    .HasMaxLength(5)
                    .HasColumnName("nectafp");

                entity.Property(e => e.Offset)
                    .HasMaxLength(1)
                    .HasColumnName("offset");

                entity.Property(e => e.Placefp)
                    .HasMaxLength(5)
                    .HasColumnName("placefp");

                entity.Property(e => e.Placefp00)
                    .HasMaxLength(5)
                    .HasColumnName("placefp00");

                entity.Property(e => e.Puma5ce)
                    .HasMaxLength(5)
                    .HasColumnName("puma5ce");

                entity.Property(e => e.Puma5ce00)
                    .HasMaxLength(5)
                    .HasColumnName("puma5ce00");

                entity.Property(e => e.Scsdlea)
                    .HasMaxLength(5)
                    .HasColumnName("scsdlea");

                entity.Property(e => e.Scsdlea00)
                    .HasMaxLength(5)
                    .HasColumnName("scsdlea00");

                entity.Property(e => e.Sldlst)
                    .HasMaxLength(3)
                    .HasColumnName("sldlst");

                entity.Property(e => e.Sldlst00)
                    .HasMaxLength(3)
                    .HasColumnName("sldlst00");

                entity.Property(e => e.Sldust)
                    .HasMaxLength(3)
                    .HasColumnName("sldust");

                entity.Property(e => e.Sldust00)
                    .HasMaxLength(3)
                    .HasColumnName("sldust00");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Statefp00)
                    .HasMaxLength(2)
                    .HasColumnName("statefp00");

                entity.Property(e => e.Submcdfp)
                    .HasMaxLength(5)
                    .HasColumnName("submcdfp");

                entity.Property(e => e.Submcdfp00)
                    .HasMaxLength(5)
                    .HasColumnName("submcdfp00");

                entity.Property(e => e.Tazce)
                    .HasMaxLength(6)
                    .HasColumnName("tazce");

                entity.Property(e => e.Tazce00)
                    .HasMaxLength(6)
                    .HasColumnName("tazce00");

                entity.Property(e => e.Tblkgpce)
                    .HasMaxLength(1)
                    .HasColumnName("tblkgpce");

                entity.Property(e => e.Tfid)
                    .HasPrecision(10)
                    .HasColumnName("tfid");

                entity.Property(e => e.TheGeom).HasColumnName("the_geom");

                entity.Property(e => e.Tractce)
                    .HasMaxLength(6)
                    .HasColumnName("tractce");

                entity.Property(e => e.Tractce00)
                    .HasMaxLength(6)
                    .HasColumnName("tractce00");

                entity.Property(e => e.Trsubce)
                    .HasMaxLength(3)
                    .HasColumnName("trsubce");

                entity.Property(e => e.Trsubce00)
                    .HasMaxLength(3)
                    .HasColumnName("trsubce00");

                entity.Property(e => e.Trsubfp)
                    .HasMaxLength(5)
                    .HasColumnName("trsubfp");

                entity.Property(e => e.Trsubfp00)
                    .HasMaxLength(5)
                    .HasColumnName("trsubfp00");

                entity.Property(e => e.Ttractce)
                    .HasMaxLength(6)
                    .HasColumnName("ttractce");

                entity.Property(e => e.Uace)
                    .HasMaxLength(5)
                    .HasColumnName("uace");

                entity.Property(e => e.Uace00)
                    .HasMaxLength(5)
                    .HasColumnName("uace00");

                entity.Property(e => e.Ugace)
                    .HasMaxLength(5)
                    .HasColumnName("ugace");

                entity.Property(e => e.Ugace00)
                    .HasMaxLength(5)
                    .HasColumnName("ugace00");

                entity.Property(e => e.Unsdlea)
                    .HasMaxLength(5)
                    .HasColumnName("unsdlea");

                entity.Property(e => e.Unsdlea00)
                    .HasMaxLength(5)
                    .HasColumnName("unsdlea00");

                entity.Property(e => e.Vtdst)
                    .HasMaxLength(6)
                    .HasColumnName("vtdst");

                entity.Property(e => e.Vtdst00)
                    .HasMaxLength(6)
                    .HasColumnName("vtdst00");

                entity.Property(e => e.Zcta5ce)
                    .HasMaxLength(5)
                    .HasColumnName("zcta5ce");

                entity.Property(e => e.Zcta5ce00)
                    .HasMaxLength(5)
                    .HasColumnName("zcta5ce00");
            });

            modelBuilder.Entity<Featname>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("featnames_pkey");

                entity.ToTable("featnames", "tiger");

                entity.HasIndex(e => new { e.Tlid, e.Statefp }, "idx_tiger_featnames_tlid_statefp");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Fullname)
                    .HasMaxLength(100)
                    .HasColumnName("fullname");

                entity.Property(e => e.Linearid)
                    .HasMaxLength(22)
                    .HasColumnName("linearid");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Paflag)
                    .HasMaxLength(1)
                    .HasColumnName("paflag");

                entity.Property(e => e.Predir)
                    .HasMaxLength(2)
                    .HasColumnName("predir");

                entity.Property(e => e.Predirabrv)
                    .HasMaxLength(15)
                    .HasColumnName("predirabrv");

                entity.Property(e => e.Prequal)
                    .HasMaxLength(2)
                    .HasColumnName("prequal");

                entity.Property(e => e.Prequalabr)
                    .HasMaxLength(15)
                    .HasColumnName("prequalabr");

                entity.Property(e => e.Pretyp)
                    .HasMaxLength(3)
                    .HasColumnName("pretyp");

                entity.Property(e => e.Pretypabrv)
                    .HasMaxLength(50)
                    .HasColumnName("pretypabrv");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Sufdir)
                    .HasMaxLength(2)
                    .HasColumnName("sufdir");

                entity.Property(e => e.Sufdirabrv)
                    .HasMaxLength(15)
                    .HasColumnName("sufdirabrv");

                entity.Property(e => e.Sufqual)
                    .HasMaxLength(2)
                    .HasColumnName("sufqual");

                entity.Property(e => e.Sufqualabr)
                    .HasMaxLength(15)
                    .HasColumnName("sufqualabr");

                entity.Property(e => e.Suftyp)
                    .HasMaxLength(3)
                    .HasColumnName("suftyp");

                entity.Property(e => e.Suftypabrv)
                    .HasMaxLength(50)
                    .HasColumnName("suftypabrv");

                entity.Property(e => e.Tlid).HasColumnName("tlid");
            });

            modelBuilder.Entity<GeocodeSetting>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("geocode_settings_pkey");

                entity.ToTable("geocode_settings", "tiger");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Setting).HasColumnName("setting");

                entity.Property(e => e.ShortDesc).HasColumnName("short_desc");

                entity.Property(e => e.Unit).HasColumnName("unit");
            });

            modelBuilder.Entity<GeocodeSettingsDefault>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("geocode_settings_default_pkey");

                entity.ToTable("geocode_settings_default", "tiger");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Setting).HasColumnName("setting");

                entity.Property(e => e.ShortDesc).HasColumnName("short_desc");

                entity.Property(e => e.Unit).HasColumnName("unit");
            });

            modelBuilder.Entity<GisAStation>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("gis_a_station_pkey");

                entity.ToTable("gis_a_station");

                entity.HasIndex(e => e.Geom, "gis_a_station_geom_idx")
                    .HasMethod("gist");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.CoorX).HasColumnName("coor_x");

                entity.Property(e => e.CoorY).HasColumnName("coor_y");

                entity.Property(e => e.Geom)
                    .HasColumnType("geometry(Point,4326)")
                    .HasColumnName("geom");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .HasColumnName("group_id");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GisAStations)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("a_component_station_daily_group_id_pkey");
            });

            modelBuilder.Entity<GisAStationAqiPm25>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("gis_a_station_aqi_pm25");

                entity.Property(e => e.AqiPm25).HasColumnName("aqi_pm25");

                entity.Property(e => e.CoorX).HasColumnName("coor_x");

                entity.Property(e => e.CoorY).HasColumnName("coor_y");

                entity.Property(e => e.Geom)
                    .HasColumnType("geometry(Point,4326)")
                    .HasColumnName("geom");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .HasColumnName("group_id");

                entity.Property(e => e.ParentId)
                    .HasMaxLength(50)
                    .HasColumnName("parent_id");
            });

            modelBuilder.Entity<GisAdministrativeCommunne>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("gis_administrative_communne_pkey");

                entity.ToTable("gis_administrative_communne");

                entity.HasIndex(e => e.CommuneId, "gis_administrative_communne_commune_id_key")
                    .IsUnique();

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.CommuneId)
                    .HasMaxLength(50)
                    .HasColumnName("commune_id");

                entity.Property(e => e.DistrictId)
                    .HasMaxLength(50)
                    .HasColumnName("district_id");

                entity.Property(e => e.ExtentMaxx).HasColumnName("extent_maxx");

                entity.Property(e => e.ExtentMaxy).HasColumnName("extent_maxy");

                entity.Property(e => e.ExtentMinx).HasColumnName("extent_minx");

                entity.Property(e => e.ExtentMiny).HasColumnName("extent_miny");

                entity.Property(e => e.Geom)
                    .HasColumnType("geometry(MultiPolygon,4326)")
                    .HasColumnName("geom");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(150)
                    .HasColumnName("name_en");

                entity.Property(e => e.NameVi)
                    .HasMaxLength(150)
                    .HasColumnName("name_vi");

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(50)
                    .HasColumnName("province_id");

                entity.Property(e => e.TypeEn)
                    .HasColumnType("character varying")
                    .HasColumnName("type_en");

                entity.Property(e => e.TypeVi)
                    .HasColumnType("character varying")
                    .HasColumnName("type_vi");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.GisAdministrativeCommunnes)
                    .HasPrincipalKey(p => p.DistrictId)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("gis_administrative_communne_district_id_fkey");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.GisAdministrativeCommunnes)
                    .HasPrincipalKey(p => p.ProvinceId)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("gis_administrative_communne_province_id_fkey");
            });

            modelBuilder.Entity<GisAdministrativeDistrict>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("gis_administrative_district_pkey");

                entity.ToTable("gis_administrative_district");

                entity.HasIndex(e => e.DistrictId, "gis_administrative_district_district_id_key")
                    .IsUnique();

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.DistrictId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("district_id");

                entity.Property(e => e.ExtentMaxx).HasColumnName("extent_maxx");

                entity.Property(e => e.ExtentMaxy).HasColumnName("extent_maxy");

                entity.Property(e => e.ExtentMinx).HasColumnName("extent_minx");

                entity.Property(e => e.ExtentMiny).HasColumnName("extent_miny");

                entity.Property(e => e.Geom)
                    .HasColumnType("geometry(MultiPolygon,4326)")
                    .HasColumnName("geom");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(150)
                    .HasColumnName("name_en");

                entity.Property(e => e.NameVi)
                    .HasMaxLength(150)
                    .HasColumnName("name_vi");

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(50)
                    .HasColumnName("province_id");

                entity.Property(e => e.TypeEn)
                    .HasMaxLength(50)
                    .HasColumnName("type_en");

                entity.Property(e => e.TypeVi)
                    .HasMaxLength(50)
                    .HasColumnName("type_vi");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.GisAdministrativeDistricts)
                    .HasPrincipalKey(p => p.ProvinceId)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("gis_administrative_district_province_id_fkey");
            });

            modelBuilder.Entity<GisAdministrativeProvince>(entity =>
            {
                entity.HasKey(e => e.Gid)
                    .HasName("gis_administrative_province_pkey");

                entity.ToTable("gis_administrative_province");

                entity.HasIndex(e => e.ProvinceId, "gis_administrative_province_province_id_key")
                    .IsUnique();

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.ExtentMaxx).HasColumnName("extent_maxx");

                entity.Property(e => e.ExtentMaxy).HasColumnName("extent_maxy");

                entity.Property(e => e.ExtentMinx).HasColumnName("extent_minx");

                entity.Property(e => e.ExtentMiny).HasColumnName("extent_miny");

                entity.Property(e => e.Geom)
                    .HasColumnType("geometry(MultiPolygon,4326)")
                    .HasColumnName("geom");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(150)
                    .HasColumnName("name_en");

                entity.Property(e => e.NameVi)
                    .HasMaxLength(150)
                    .HasColumnName("name_vi");

                entity.Property(e => e.ProvinceId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("province_id");

                entity.Property(e => e.TypeEn)
                    .HasMaxLength(50)
                    .HasColumnName("type_en");

                entity.Property(e => e.TypeVi)
                    .HasMaxLength(50)
                    .HasColumnName("type_vi");
            });

            modelBuilder.Entity<Layer>(entity =>
            {
                entity.HasKey(e => new { e.TopologyId, e.LayerId })
                    .HasName("layer_pkey");

                entity.ToTable("layer", "topology");

                entity.HasIndex(e => new { e.SchemaName, e.TableName, e.FeatureColumn }, "layer_schema_name_table_name_feature_column_key")
                    .IsUnique();

                entity.Property(e => e.TopologyId).HasColumnName("topology_id");

                entity.Property(e => e.LayerId).HasColumnName("layer_id");

                entity.Property(e => e.ChildId).HasColumnName("child_id");

                entity.Property(e => e.FeatureColumn)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("feature_column");

                entity.Property(e => e.FeatureType).HasColumnName("feature_type");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.SchemaName)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("schema_name");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("table_name");

                entity.HasOne(d => d.Topology)
                    .WithMany(p => p.Layers)
                    .HasForeignKey(d => d.TopologyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("layer_topology_id_fkey");
            });

            modelBuilder.Entity<LoaderLookuptable>(entity =>
            {
                entity.HasKey(e => e.LookupName)
                    .HasName("loader_lookuptables_pkey");

                entity.ToTable("loader_lookuptables", "tiger");

                entity.Property(e => e.LookupName)
                    .HasColumnName("lookup_name")
                    .HasComment("This is the table name to inherit from and suffix of resulting output table -- how the table will be named --  edges here would mean -- ma_edges , pa_edges etc. except in the case of national tables. national level tables have no prefix");

                entity.Property(e => e.ColumnsExclude)
                    .HasColumnName("columns_exclude")
                    .HasComment("List of columns to exclude as an array. This is excluded from both input table and output table and rest of columns remaining are assumed to be in same order in both tables. gid, geoid,cpi,suffix1ce are excluded if no columns are specified.");

                entity.Property(e => e.InsertMode)
                    .HasMaxLength(1)
                    .HasColumnName("insert_mode")
                    .HasDefaultValueSql("'c'::bpchar");

                entity.Property(e => e.LevelCounty).HasColumnName("level_county");

                entity.Property(e => e.LevelNation)
                    .HasColumnName("level_nation")
                    .HasComment("These are tables that contain all data for the whole US so there is just a single file");

                entity.Property(e => e.LevelState).HasColumnName("level_state");

                entity.Property(e => e.Load)
                    .IsRequired()
                    .HasColumnName("load")
                    .HasDefaultValueSql("true")
                    .HasComment("Whether or not to load the table.  For states and zcta5 (you may just want to download states10, zcta510 nationwide file manually) load your own into a single table that inherits from tiger.states, tiger.zcta5.  You'll get improved performance for some geocoding cases.");

                entity.Property(e => e.PostLoadProcess).HasColumnName("post_load_process");

                entity.Property(e => e.PreLoadProcess).HasColumnName("pre_load_process");

                entity.Property(e => e.ProcessOrder)
                    .HasColumnName("process_order")
                    .HasDefaultValueSql("1000");

                entity.Property(e => e.SingleGeomMode)
                    .HasColumnName("single_geom_mode")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.SingleMode)
                    .IsRequired()
                    .HasColumnName("single_mode")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.TableName)
                    .HasColumnName("table_name")
                    .HasComment("suffix of the tables to load e.g.  edges would load all tables like *edges.dbf(shp)  -- so tl_2010_42129_edges.dbf .  ");

                entity.Property(e => e.WebsiteRootOverride)
                    .HasColumnName("website_root_override")
                    .HasComment("Path to use for wget instead of that specified in year table.  Needed currently for zcta where they release that only for 2000 and 2010");
            });

            modelBuilder.Entity<LoaderPlatform>(entity =>
            {
                entity.HasKey(e => e.Os)
                    .HasName("loader_platform_pkey");

                entity.ToTable("loader_platform", "tiger");

                entity.Property(e => e.Os)
                    .HasMaxLength(50)
                    .HasColumnName("os");

                entity.Property(e => e.CountyProcessCommand).HasColumnName("county_process_command");

                entity.Property(e => e.DeclareSect).HasColumnName("declare_sect");

                entity.Property(e => e.EnvironSetCommand).HasColumnName("environ_set_command");

                entity.Property(e => e.Loader).HasColumnName("loader");

                entity.Property(e => e.PathSep).HasColumnName("path_sep");

                entity.Property(e => e.Pgbin).HasColumnName("pgbin");

                entity.Property(e => e.Psql).HasColumnName("psql");

                entity.Property(e => e.UnzipCommand).HasColumnName("unzip_command");

                entity.Property(e => e.Wget).HasColumnName("wget");
            });

            modelBuilder.Entity<LoaderVariable>(entity =>
            {
                entity.HasKey(e => e.TigerYear)
                    .HasName("loader_variables_pkey");

                entity.ToTable("loader_variables", "tiger");

                entity.Property(e => e.TigerYear)
                    .HasMaxLength(4)
                    .HasColumnName("tiger_year");

                entity.Property(e => e.DataSchema).HasColumnName("data_schema");

                entity.Property(e => e.StagingFold).HasColumnName("staging_fold");

                entity.Property(e => e.StagingSchema).HasColumnName("staging_schema");

                entity.Property(e => e.WebsiteRoot).HasColumnName("website_root");
            });

            modelBuilder.Entity<MosaicSnowApom>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("mosaic_snow_apom_pkey");

                entity.ToTable("mosaic_snow_apom");

                entity.HasIndex(e => e.Geom, "spatial_mosaic_snow_apom_geom")
                    .HasMethod("gist");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.Elevation).HasColumnName("elevation");

                entity.Property(e => e.Geom)
                    .HasColumnType("geometry(Polygon,32632)")
                    .HasColumnName("geom");

                entity.Property(e => e.Ingestion).HasColumnName("ingestion");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .HasColumnName("location");
            });

            modelBuilder.Entity<PagcGaz>(entity =>
            {
                entity.ToTable("pagc_gaz", "tiger");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsCustom)
                    .IsRequired()
                    .HasColumnName("is_custom")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Stdword).HasColumnName("stdword");

                entity.Property(e => e.Token).HasColumnName("token");

                entity.Property(e => e.Word).HasColumnName("word");
            });

            modelBuilder.Entity<PagcLex>(entity =>
            {
                entity.ToTable("pagc_lex", "tiger");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsCustom)
                    .IsRequired()
                    .HasColumnName("is_custom")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Seq).HasColumnName("seq");

                entity.Property(e => e.Stdword).HasColumnName("stdword");

                entity.Property(e => e.Token).HasColumnName("token");

                entity.Property(e => e.Word).HasColumnName("word");
            });

            modelBuilder.Entity<PagcRule>(entity =>
            {
                entity.ToTable("pagc_rules", "tiger");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsCustom)
                    .HasColumnName("is_custom")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Rule).HasColumnName("rule");
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.HasKey(e => e.Plcidfp)
                    .HasName("place_pkey");

                entity.ToTable("place", "tiger");

                entity.HasIndex(e => e.TheGeom, "tiger_place_the_geom_gist")
                    .HasMethod("gist");

                entity.HasIndex(e => e.Gid, "uidx_tiger_place_gid")
                    .IsUnique();

                entity.Property(e => e.Plcidfp)
                    .HasMaxLength(7)
                    .HasColumnName("plcidfp");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Classfp)
                    .HasMaxLength(2)
                    .HasColumnName("classfp");

                entity.Property(e => e.Cpi)
                    .HasMaxLength(1)
                    .HasColumnName("cpi");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Lsad)
                    .HasMaxLength(2)
                    .HasColumnName("lsad");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Namelsad)
                    .HasMaxLength(100)
                    .HasColumnName("namelsad");

                entity.Property(e => e.Pcicbsa)
                    .HasMaxLength(1)
                    .HasColumnName("pcicbsa");

                entity.Property(e => e.Pcinecta)
                    .HasMaxLength(1)
                    .HasColumnName("pcinecta");

                entity.Property(e => e.Placefp)
                    .HasMaxLength(5)
                    .HasColumnName("placefp");

                entity.Property(e => e.Placens)
                    .HasMaxLength(8)
                    .HasColumnName("placens");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.TheGeom).HasColumnName("the_geom");
            });

            modelBuilder.Entity<PlaceLookup>(entity =>
            {
                entity.HasKey(e => new { e.StCode, e.PlCode })
                    .HasName("place_lookup_pkey");

                entity.ToTable("place_lookup", "tiger");

                entity.HasIndex(e => e.State, "place_lookup_state_idx");

                entity.Property(e => e.StCode).HasColumnName("st_code");

                entity.Property(e => e.PlCode).HasColumnName("pl_code");

                entity.Property(e => e.Name)
                    .HasMaxLength(90)
                    .HasColumnName("name");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<Pm25>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("pm25_pkey");

                entity.ToTable("pm25");

                entity.HasIndex(e => e.Geom, "spatial_pm25_geom")
                    .HasMethod("gist");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.Elevation).HasColumnName("elevation");

                entity.Property(e => e.Geom)
                    .HasColumnType("geometry(Polygon,4326)")
                    .HasColumnName("geom");

                entity.Property(e => e.Ingestion).HasColumnName("ingestion");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .HasColumnName("location");
            });

            modelBuilder.Entity<Pm25Mem>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("pm25_MEM_pkey");

                entity.ToTable("pm25_mem");

                entity.HasIndex(e => e.TheGeom, "spatial_pm25_MEM_the_geom")
                    .HasMethod("gist");

                entity.Property(e => e.Fid)
                    .HasColumnName("fid")
                    .HasDefaultValueSql("nextval('\"pm25_MEM_fid_seq\"'::regclass)");

                entity.Property(e => e.Ingestion).HasColumnName("ingestion");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .HasColumnName("location");

                entity.Property(e => e.TheGeom)
                    .HasColumnType("geometry(Polygon,4326)")
                    .HasColumnName("the_geom");
            });

            modelBuilder.Entity<Pm25Wrf>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("pm25_wrf_pkey");

                entity.ToTable("pm25_wrf");

                entity.HasIndex(e => e.Geom, "spatial_pm25_wrf_geom")
                    .HasMethod("gist");

                entity.Property(e => e.Fid).HasColumnName("fid");

                entity.Property(e => e.Elevation).HasColumnName("elevation");

                entity.Property(e => e.Geom)
                    .HasColumnType("geometry(Polygon,4326)")
                    .HasColumnName("geom");

                entity.Property(e => e.Ingestion).HasColumnName("ingestion");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .HasColumnName("location");
            });

            modelBuilder.Entity<Pm25Wrfchem>(entity =>
            {
                entity.HasKey(e => e.Fid)
                    .HasName("pm25_WRFChem_pkey");

                entity.ToTable("pm25_wrfchem");

                entity.HasIndex(e => e.TheGeom, "spatial_pm25_WRFChem_the_geom")
                    .HasMethod("gist");

                entity.Property(e => e.Fid)
                    .HasColumnName("fid")
                    .HasDefaultValueSql("nextval('\"pm25_WRFChem_fid_seq\"'::regclass)");

                entity.Property(e => e.Ingestion).HasColumnName("ingestion");

                entity.Property(e => e.Location)
                    .HasMaxLength(255)
                    .HasColumnName("location");

                entity.Property(e => e.TheGeom)
                    .HasColumnType("geometry(Polygon,4326)")
                    .HasColumnName("the_geom");
            });

            modelBuilder.Entity<RAdministrativeAvg>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("r_administrative_avg_pkey");

                entity.ToTable("r_administrative_avg");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("category_id");

                entity.Property(e => e.DistrictId)
                    .HasMaxLength(50)
                    .HasColumnName("district_id");

                entity.Property(e => e.Num).HasColumnName("num");

                entity.Property(e => e.ValAvg).HasColumnName("val_avg");

                entity.Property(e => e.ValAvgAqi).HasColumnName("val_avg_aqi");

                entity.Property(e => e.ValSum).HasColumnName("val_sum");

                entity.Property(e => e.ValSumAqi).HasColumnName("val_sum_aqi");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.RAdministrativeAvgs)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("r_administrative_avg_category_id_fkey");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.RAdministrativeAvgs)
                    .HasPrincipalKey(p => p.DistrictId)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("r_administrative_avg_district_id_fkey");
            });

            modelBuilder.Entity<RAirPolution>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("r_air_polution_pkey");

                entity.ToTable("r_air_polution");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.FileentryId)
                    .HasMaxLength(50)
                    .HasColumnName("fileentry_id");

                entity.Property(e => e.FileentryThumbnailId)
                    .HasMaxLength(50)
                    .HasColumnName("fileentry_thumbnail_id");

                entity.Property(e => e.Modifydate).HasColumnName("modifydate");

                entity.Property(e => e.Reportdate)
                    .HasMaxLength(50)
                    .HasColumnName("reportdate");

                entity.Property(e => e.Reportname)
                    .HasMaxLength(255)
                    .HasColumnName("reportname");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("user_id");
            });

            modelBuilder.Entity<RComponentStationDailyAvg>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("r_component_station_daily_pkey");

                entity.ToTable("r_component_station_daily_avg");

                entity.Property(e => e.Oid)
                    .HasColumnName("oid")
                    .HasDefaultValueSql("nextval('r_component_station_daily_oid_seq'::regclass)");

                entity.Property(e => e.Altm).HasColumnName("altm");

                entity.Property(e => e.Aqi).HasColumnName("aqi");

                entity.Property(e => e.AqiCo).HasColumnName("aqi_co");

                entity.Property(e => e.AqiNo2).HasColumnName("aqi_no2");

                entity.Property(e => e.AqiO3).HasColumnName("aqi_o3");

                entity.Property(e => e.AqiPm10).HasColumnName("aqi_pm10");

                entity.Property(e => e.AqiPm25).HasColumnName("aqi_pm25");

                entity.Property(e => e.AqiSo2).HasColumnName("aqi_so2");

                entity.Property(e => e.Co).HasColumnName("co");

                entity.Property(e => e.DateShooting)
                    .HasColumnType("date")
                    .HasColumnName("date_shooting");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .HasColumnName("group_id");

                entity.Property(e => e.Hud).HasColumnName("hud");

                entity.Property(e => e.No2).HasColumnName("no2");

                entity.Property(e => e.O3).HasColumnName("o3");

                entity.Property(e => e.Pm10).HasColumnName("pm10");

                entity.Property(e => e.Pm25).HasColumnName("pm25");

                entity.Property(e => e.So2).HasColumnName("so2");

                entity.Property(e => e.Temp).HasColumnName("temp");

                entity.Property(e => e.Vis).HasColumnName("vis");

                entity.Property(e => e.Wdir).HasColumnName("wdir");

                entity.Property(e => e.Wspd).HasColumnName("wspd");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.RComponentStationDailyAvgs)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("r_component_station_daily_group_id_fkey");
            });

            modelBuilder.Entity<SecondaryUnitLookup>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("secondary_unit_lookup_pkey");

                entity.ToTable("secondary_unit_lookup", "tiger");

                entity.HasIndex(e => e.Abbrev, "secondary_unit_lookup_abbrev_idx");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(5)
                    .HasColumnName("abbrev");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.Statefp)
                    .HasName("pk_tiger_state");

                entity.ToTable("state", "tiger");

                entity.HasIndex(e => e.TheGeom, "idx_tiger_state_the_geom_gist")
                    .HasMethod("gist");

                entity.HasIndex(e => e.Gid, "uidx_tiger_state_gid")
                    .IsUnique();

                entity.HasIndex(e => e.Stusps, "uidx_tiger_state_stusps")
                    .IsUnique();

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Division)
                    .HasMaxLength(2)
                    .HasColumnName("division");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Lsad)
                    .HasMaxLength(2)
                    .HasColumnName("lsad");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Region)
                    .HasMaxLength(2)
                    .HasColumnName("region");

                entity.Property(e => e.Statens)
                    .HasMaxLength(8)
                    .HasColumnName("statens");

                entity.Property(e => e.Stusps)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("stusps");

                entity.Property(e => e.TheGeom).HasColumnName("the_geom");
            });

            modelBuilder.Entity<StateLookup>(entity =>
            {
                entity.HasKey(e => e.StCode)
                    .HasName("state_lookup_pkey");

                entity.ToTable("state_lookup", "tiger");

                entity.HasIndex(e => e.Abbrev, "state_lookup_abbrev_key")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "state_lookup_name_key")
                    .IsUnique();

                entity.HasIndex(e => e.Statefp, "state_lookup_statefp_key")
                    .IsUnique();

                entity.Property(e => e.StCode)
                    .ValueGeneratedNever()
                    .HasColumnName("st_code");

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(3)
                    .HasColumnName("abbrev");

                entity.Property(e => e.Name)
                    .HasMaxLength(40)
                    .HasColumnName("name");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<StreetTypeLookup>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("street_type_lookup_pkey");

                entity.ToTable("street_type_lookup", "tiger");

                entity.HasIndex(e => e.Abbrev, "street_type_lookup_abbrev_idx");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Abbrev)
                    .HasMaxLength(50)
                    .HasColumnName("abbrev");

                entity.Property(e => e.IsHw).HasColumnName("is_hw");
            });

            modelBuilder.Entity<Tabblock>(entity =>
            {
                entity.ToTable("tabblock", "tiger");

                entity.Property(e => e.TabblockId)
                    .HasMaxLength(16)
                    .HasColumnName("tabblock_id");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Blockce)
                    .HasMaxLength(4)
                    .HasColumnName("blockce");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.TheGeom).HasColumnName("the_geom");

                entity.Property(e => e.Tractce)
                    .HasMaxLength(6)
                    .HasColumnName("tractce");

                entity.Property(e => e.Uace)
                    .HasMaxLength(5)
                    .HasColumnName("uace");

                entity.Property(e => e.Ur)
                    .HasMaxLength(1)
                    .HasColumnName("ur");
            });

            modelBuilder.Entity<Tabblock20>(entity =>
            {
                entity.HasKey(e => e.Geoid)
                    .HasName("pk_tabblock20");

                entity.ToTable("tabblock20", "tiger");

                entity.Property(e => e.Geoid)
                    .HasMaxLength(15)
                    .HasColumnName("geoid");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Blockce)
                    .HasMaxLength(4)
                    .HasColumnName("blockce");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.TheGeom)
                    .HasColumnType("geometry(MultiPolygon,4269)")
                    .HasColumnName("the_geom");

                entity.Property(e => e.Tractce)
                    .HasMaxLength(6)
                    .HasColumnName("tractce");

                entity.Property(e => e.Uace)
                    .HasMaxLength(5)
                    .HasColumnName("uace");

                entity.Property(e => e.Uatype)
                    .HasMaxLength(1)
                    .HasColumnName("uatype");

                entity.Property(e => e.Ur)
                    .HasMaxLength(1)
                    .HasColumnName("ur");
            });

            modelBuilder.Entity<Topology>(entity =>
            {
                entity.ToTable("topology", "topology");

                entity.HasIndex(e => e.Name, "topology_name_key")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Hasz).HasColumnName("hasz");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("character varying")
                    .HasColumnName("name");

                entity.Property(e => e.Precision).HasColumnName("precision");

                entity.Property(e => e.Srid).HasColumnName("srid");
            });

            modelBuilder.Entity<Tract>(entity =>
            {
                entity.ToTable("tract", "tiger");

                entity.Property(e => e.TractId)
                    .HasMaxLength(11)
                    .HasColumnName("tract_id");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Countyfp)
                    .HasMaxLength(3)
                    .HasColumnName("countyfp");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Name)
                    .HasMaxLength(7)
                    .HasColumnName("name");

                entity.Property(e => e.Namelsad)
                    .HasMaxLength(20)
                    .HasColumnName("namelsad");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.TheGeom).HasColumnName("the_geom");

                entity.Property(e => e.Tractce)
                    .HasMaxLength(6)
                    .HasColumnName("tractce");
            });

            modelBuilder.Entity<UGeneralSetting>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("u_general_setting_pkey");

                entity.ToTable("u_general_setting");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.DomainLdap).HasColumnName("domain_ldap");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(255)
                    .HasColumnName("email_address");

                entity.Property(e => e.EmailGate).HasColumnName("email_gate");

                entity.Property(e => e.EmailPassword)
                    .HasMaxLength(255)
                    .HasColumnName("email_password");

                entity.Property(e => e.EmailPasswordencrypted)
                    .HasColumnName("email_passwordencrypted")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.EmailServerPop)
                    .HasMaxLength(255)
                    .HasColumnName("email_server_pop");

                entity.Property(e => e.ExtentMapX1).HasColumnName("extent_map_x1");

                entity.Property(e => e.ExtentMapX2).HasColumnName("extent_map_x2");

                entity.Property(e => e.ExtentMapY1).HasColumnName("extent_map_y1");

                entity.Property(e => e.ExtentMapY2).HasColumnName("extent_map_y2");

                entity.Property(e => e.Formatdate)
                    .HasMaxLength(10)
                    .HasColumnName("formatdate");

                entity.Property(e => e.Formattime)
                    .HasMaxLength(10)
                    .HasColumnName("formattime");

                entity.Property(e => e.Languagedefaultid)
                    .HasMaxLength(30)
                    .HasColumnName("languagedefaultid");

                entity.Property(e => e.MaxSizeFile).HasColumnName("max_size_file");

                entity.Property(e => e.NumberDigitdecimal).HasColumnName("number_digitdecimal");

                entity.Property(e => e.NumbercurrencyDigitdecimal).HasColumnName("numbercurrency_digitdecimal");

                entity.Property(e => e.Projection)
                    .HasMaxLength(20)
                    .HasColumnName("projection");

                entity.Property(e => e.Ssl).HasColumnName("ssl");

                entity.Property(e => e.Symbolcurrency)
                    .HasMaxLength(10)
                    .HasColumnName("symbolcurrency");

                entity.Property(e => e.SymbolcurrencyDigitdecimal)
                    .HasMaxLength(10)
                    .HasColumnName("symbolcurrency_digitdecimal");

                entity.Property(e => e.SymbolcurrencyDigitgroup)
                    .HasMaxLength(10)
                    .HasColumnName("symbolcurrency_digitgroup");

                entity.Property(e => e.SymbolnumberDigitdecimal)
                    .HasMaxLength(10)
                    .HasColumnName("symbolnumber_digitdecimal");

                entity.Property(e => e.SymbolnumberDigitgroup)
                    .HasMaxLength(10)
                    .HasColumnName("symbolnumber_digitgroup");

                entity.Property(e => e.Themeid)
                    .HasMaxLength(30)
                    .HasColumnName("themeid");

                entity.Property(e => e.UnitScale)
                    .HasMaxLength(10)
                    .HasColumnName("unit_scale");

                entity.Property(e => e.UseLdap).HasColumnName("use_ldap");
            });

            modelBuilder.Entity<URole>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("u_role_pkey");

                entity.ToTable("u_role");

                entity.HasIndex(e => e.Roleid, "u_role_roleid_key")
                    .IsUnique();

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Active)
                    .HasColumnName("active")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Createdate)
                    .HasColumnType("date")
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("date")
                    .HasColumnName("modifydate");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Roleid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("roleid");

                entity.Property(e => e.Rolesystem)
                    .HasColumnName("rolesystem")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .HasColumnName("userid");
            });

            modelBuilder.Entity<UUser>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("u_user_pkey");

                entity.ToTable("u_user");

                entity.HasIndex(e => e.Userid, "u_user_userid_key")
                    .IsUnique();

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Birthday)
                    .HasColumnType("date")
                    .HasColumnName("birthday");

                entity.Property(e => e.Companyname)
                    .HasMaxLength(500)
                    .HasColumnName("companyname");

                entity.Property(e => e.Createdate)
                    .HasColumnType("date")
                    .HasColumnName("createdate")
                    .HasDefaultValueSql("now()");

                entity.Property(e => e.Displayname)
                    .HasMaxLength(50)
                    .HasColumnName("displayname");

                entity.Property(e => e.Emailaddress)
                    .HasMaxLength(50)
                    .HasColumnName("emailaddress");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(50)
                    .HasColumnName("firstname");

                entity.Property(e => e.Image)
                    .HasMaxLength(200)
                    .HasColumnName("image");

                entity.Property(e => e.IsDelete)
                    .HasColumnName("is_delete")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Isactive)
                    .HasColumnName("isactive")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(50)
                    .HasColumnName("lastname");

                entity.Property(e => e.LasttimeAccess).HasColumnName("lasttime_access");

                entity.Property(e => e.Lockaccount).HasColumnName("lockaccount");

                entity.Property(e => e.Middlename)
                    .HasMaxLength(50)
                    .HasColumnName("middlename");

                entity.Property(e => e.Modifydate)
                    .HasColumnType("date")
                    .HasColumnName("modifydate");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");

                entity.Property(e => e.PasswordReset)
                    .HasColumnName("password_reset")
                    .HasDefaultValueSql("false");

                entity.Property(e => e.Passwordencrypted)
                    .HasColumnName("passwordencrypted")
                    .HasDefaultValueSql("true");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(30)
                    .HasColumnName("phonenumber");

                entity.Property(e => e.Sex)
                    .HasMaxLength(10)
                    .HasColumnName("sex");

                entity.Property(e => e.TimeRegister).HasColumnName("time_register");

                entity.Property(e => e.TimeResetPwd).HasColumnName("time_reset_pwd");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");

                entity.Property(e => e.Website)
                    .HasMaxLength(500)
                    .HasColumnName("website");
            });

            modelBuilder.Entity<UUserRole>(entity =>
            {
                entity.HasKey(e => e.Oid)
                    .HasName("u_role_user_pkey");

                entity.ToTable("u_user_role");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Dateupdate)
                    .HasColumnType("date")
                    .HasColumnName("dateupdate");

                entity.Property(e => e.Isroot).HasColumnName("isroot");

                entity.Property(e => e.Roleid)
                    .HasMaxLength(50)
                    .HasColumnName("roleid");

                entity.Property(e => e.Userid)
                    .HasMaxLength(50)
                    .HasColumnName("userid");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UUserRoles)
                    .HasPrincipalKey(p => p.Roleid)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("u_role_user_roleid_fkey");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UUserRoles)
                    .HasPrincipalKey(p => p.Userid)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("u_role_user_userid_fkey");
            });

            modelBuilder.Entity<VAComponentStationDaily7Day>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("v_a_component_station_daily_7_days");

                entity.Property(e => e.Altm).HasColumnName("altm");

                entity.Property(e => e.Aqi).HasColumnName("aqi");

                entity.Property(e => e.AqiCo).HasColumnName("aqi_co");

                entity.Property(e => e.AqiNo2).HasColumnName("aqi_no2");

                entity.Property(e => e.AqiO3).HasColumnName("aqi_o3");

                entity.Property(e => e.AqiPm10).HasColumnName("aqi_pm10");

                entity.Property(e => e.AqiPm25).HasColumnName("aqi_pm25");

                entity.Property(e => e.AqiSo2).HasColumnName("aqi_so2");

                entity.Property(e => e.Co).HasColumnName("co");

                entity.Property(e => e.Createdate).HasColumnName("createdate");

                entity.Property(e => e.DataShooting)
                    .HasColumnType("jsonb")
                    .HasColumnName("data_shooting");

                entity.Property(e => e.DatetimeShooting).HasColumnName("datetime_shooting");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .HasColumnName("group_id");

                entity.Property(e => e.Hud).HasColumnName("hud");

                entity.Property(e => e.Modifydate).HasColumnName("modifydate");

                entity.Property(e => e.No2).HasColumnName("no2");

                entity.Property(e => e.O3).HasColumnName("o3");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Pm10).HasColumnName("pm10");

                entity.Property(e => e.Pm25).HasColumnName("pm25");

                entity.Property(e => e.SearchTsv).HasColumnName("search_tsv");

                entity.Property(e => e.So2).HasColumnName("so2");

                entity.Property(e => e.Temp).HasColumnName("temp");

                entity.Property(e => e.UserId)
                    .HasColumnType("character varying")
                    .HasColumnName("user_id");

                entity.Property(e => e.Vis).HasColumnName("vis");

                entity.Property(e => e.Wdir).HasColumnName("wdir");

                entity.Property(e => e.Wspd).HasColumnName("wspd");
            });

            modelBuilder.Entity<VAComponentStationDailyGropuidLatest7Day>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("v_a_component_station_daily_gropuid_latest_7_days");

                entity.Property(e => e.AqiPm25).HasColumnName("aqi_pm25");

                entity.Property(e => e.DatetimeShooting).HasColumnName("datetime_shooting");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .HasColumnName("group_id");
            });

            modelBuilder.Entity<VAdministrativeCommune>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("v_administrative_commune");

                entity.Property(e => e.CommuneId)
                    .HasMaxLength(50)
                    .HasColumnName("commune_id");

                entity.Property(e => e.DistrictId)
                    .HasMaxLength(50)
                    .HasColumnName("district_id");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(150)
                    .HasColumnName("name_en");

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(50)
                    .HasColumnName("province_id");

                entity.Property(e => e.Type)
                    .HasColumnType("character varying")
                    .HasColumnName("type");

                entity.Property(e => e.TypeEn)
                    .HasColumnType("character varying")
                    .HasColumnName("type_en");
            });

            modelBuilder.Entity<VAdministrativeDistrict>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("v_administrative_district");

                entity.Property(e => e.DistrictId)
                    .HasMaxLength(50)
                    .HasColumnName("district_id");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(150)
                    .HasColumnName("name_en");

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(50)
                    .HasColumnName("province_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.Property(e => e.TypeEn)
                    .HasMaxLength(50)
                    .HasColumnName("type_en");
            });

            modelBuilder.Entity<VAdministrativeProvince>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("v_administrative_province");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Name)
                    .HasMaxLength(150)
                    .HasColumnName("name");

                entity.Property(e => e.NameEn)
                    .HasMaxLength(150)
                    .HasColumnName("name_en");

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(50)
                    .HasColumnName("province_id");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .HasColumnName("type");

                entity.Property(e => e.TypeEn)
                    .HasMaxLength(50)
                    .HasColumnName("type_en");
            });

            modelBuilder.Entity<VAdministrativeProvinceAvg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("v_administrative_province_avg");

                entity.Property(e => e.Avg).HasColumnName("avg");

                entity.Property(e => e.AvgAqi).HasColumnName("avg_aqi");

                entity.Property(e => e.CategoryId)
                    .HasMaxLength(50)
                    .HasColumnName("category_id");

                entity.Property(e => e.DateShooting).HasColumnName("date_shooting");

                entity.Property(e => e.ProvinceId)
                    .HasMaxLength(50)
                    .HasColumnName("province_id");

                entity.Property(e => e.ProvinceName)
                    .HasMaxLength(150)
                    .HasColumnName("province_name");

                entity.Property(e => e.ProvinceNameEn)
                    .HasMaxLength(150)
                    .HasColumnName("province_name_en");
            });

            modelBuilder.Entity<Zcta5>(entity =>
            {
                entity.HasKey(e => new { e.Zcta5ce, e.Statefp })
                    .HasName("pk_tiger_zcta5_zcta5ce");

                entity.ToTable("zcta5", "tiger");

                entity.HasIndex(e => e.Gid, "uidx_tiger_zcta5_gid")
                    .IsUnique();

                entity.Property(e => e.Zcta5ce)
                    .HasMaxLength(5)
                    .HasColumnName("zcta5ce");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");

                entity.Property(e => e.Aland).HasColumnName("aland");

                entity.Property(e => e.Awater).HasColumnName("awater");

                entity.Property(e => e.Classfp)
                    .HasMaxLength(2)
                    .HasColumnName("classfp");

                entity.Property(e => e.Funcstat)
                    .HasMaxLength(1)
                    .HasColumnName("funcstat");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Intptlat)
                    .HasMaxLength(11)
                    .HasColumnName("intptlat");

                entity.Property(e => e.Intptlon)
                    .HasMaxLength(12)
                    .HasColumnName("intptlon");

                entity.Property(e => e.Mtfcc)
                    .HasMaxLength(5)
                    .HasColumnName("mtfcc");

                entity.Property(e => e.Partflg)
                    .HasMaxLength(1)
                    .HasColumnName("partflg");

                entity.Property(e => e.TheGeom).HasColumnName("the_geom");
            });

            modelBuilder.Entity<ZipLookup>(entity =>
            {
                entity.HasKey(e => e.Zip)
                    .HasName("zip_lookup_pkey");

                entity.ToTable("zip_lookup", "tiger");

                entity.Property(e => e.Zip)
                    .ValueGeneratedNever()
                    .HasColumnName("zip");

                entity.Property(e => e.Cnt).HasColumnName("cnt");

                entity.Property(e => e.CoCode).HasColumnName("co_code");

                entity.Property(e => e.County)
                    .HasMaxLength(90)
                    .HasColumnName("county");

                entity.Property(e => e.Cousub)
                    .HasMaxLength(90)
                    .HasColumnName("cousub");

                entity.Property(e => e.CsCode).HasColumnName("cs_code");

                entity.Property(e => e.PlCode).HasColumnName("pl_code");

                entity.Property(e => e.Place)
                    .HasMaxLength(90)
                    .HasColumnName("place");

                entity.Property(e => e.StCode).HasColumnName("st_code");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<ZipLookupAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zip_lookup_all", "tiger");

                entity.Property(e => e.Cnt).HasColumnName("cnt");

                entity.Property(e => e.CoCode).HasColumnName("co_code");

                entity.Property(e => e.County)
                    .HasMaxLength(90)
                    .HasColumnName("county");

                entity.Property(e => e.Cousub)
                    .HasMaxLength(90)
                    .HasColumnName("cousub");

                entity.Property(e => e.CsCode).HasColumnName("cs_code");

                entity.Property(e => e.PlCode).HasColumnName("pl_code");

                entity.Property(e => e.Place)
                    .HasMaxLength(90)
                    .HasColumnName("place");

                entity.Property(e => e.StCode).HasColumnName("st_code");

                entity.Property(e => e.State)
                    .HasMaxLength(2)
                    .HasColumnName("state");

                entity.Property(e => e.Zip).HasColumnName("zip");
            });

            modelBuilder.Entity<ZipLookupBase>(entity =>
            {
                entity.HasKey(e => e.Zip)
                    .HasName("zip_lookup_base_pkey");

                entity.ToTable("zip_lookup_base", "tiger");

                entity.Property(e => e.Zip)
                    .HasMaxLength(5)
                    .HasColumnName("zip");

                entity.Property(e => e.City)
                    .HasMaxLength(90)
                    .HasColumnName("city");

                entity.Property(e => e.County)
                    .HasMaxLength(90)
                    .HasColumnName("county");

                entity.Property(e => e.State)
                    .HasMaxLength(40)
                    .HasColumnName("state");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");
            });

            modelBuilder.Entity<ZipState>(entity =>
            {
                entity.HasKey(e => new { e.Zip, e.Stusps })
                    .HasName("zip_state_pkey");

                entity.ToTable("zip_state", "tiger");

                entity.Property(e => e.Zip)
                    .HasMaxLength(5)
                    .HasColumnName("zip");

                entity.Property(e => e.Stusps)
                    .HasMaxLength(2)
                    .HasColumnName("stusps");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");
            });

            modelBuilder.Entity<ZipStateLoc>(entity =>
            {
                entity.HasKey(e => new { e.Zip, e.Stusps, e.Place })
                    .HasName("zip_state_loc_pkey");

                entity.ToTable("zip_state_loc", "tiger");

                entity.Property(e => e.Zip)
                    .HasMaxLength(5)
                    .HasColumnName("zip");

                entity.Property(e => e.Stusps)
                    .HasMaxLength(2)
                    .HasColumnName("stusps");

                entity.Property(e => e.Place)
                    .HasMaxLength(100)
                    .HasColumnName("place");

                entity.Property(e => e.Statefp)
                    .HasMaxLength(2)
                    .HasColumnName("statefp");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
