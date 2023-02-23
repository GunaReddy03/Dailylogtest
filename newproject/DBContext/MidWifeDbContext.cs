using Microsoft.EntityFrameworkCore;
using newproject.Models;
using newproject.ViewModel;
using PromiseApp.Models.MidWifeModels;

namespace newproject.DBContext
{
    public class MidWifeDbContext : DbContext
    {
        public MidWifeDbContext(DbContextOptions<MidWifeDbContext> opt) : base(opt)
        {

        }
        public DbSet<DailyLog> DailyLogs { get; set; }
        public DbSet<AncOpd> AncOpds { get; set; }
        public DbSet<Dailylog_Triage> dailylog_Triages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dailylog_Triage>().OwnsOne(
            reflectionmodel => reflectionmodel.DemographicDetailsTriage, ownedNavigationBuilder =>
            {
                ownedNavigationBuilder.ToJson();

            });
            modelBuilder.Entity<Dailylog_Triage>().OwnsOne(
              reflectionmodel => reflectionmodel.Vitals_Triage, ownedNavigationBuilder =>
              {
                  ownedNavigationBuilder.ToJson();

              });
            modelBuilder.Entity<Dailylog_Triage>().OwnsOne(
              reflectionmodel => reflectionmodel.Traige_Category, ownedNavigationBuilder =>
              {
                  ownedNavigationBuilder.ToJson();

              });
            modelBuilder.Entity<Dailylog_Triage>().OwnsOne(
              reflectionmodel => reflectionmodel.Status_Of_Mother, ownedNavigationBuilder =>
              {
                  ownedNavigationBuilder.ToJson();

              });
        }
    }
}
