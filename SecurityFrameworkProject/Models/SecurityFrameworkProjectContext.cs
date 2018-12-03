using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace SecurityFrameworkProject.Models
{
    public class SecurityFrameworkProjectContext : DbContext
    {

        //If we dont have a reference in one of the models used for the dbset, the table might not be created
        //SEE  https://stackoverflow.com/questions/25707924/entity-framework-code-first-migrations-doesnt-pickup-changes-to-the-model-class

        public DbSet<Project> Projects { get; set; }
            public DbSet<SecurityPractice> SecurityPractices { get; set; }
        public DbSet<MaturityLevelPersonnel> MaturityLevelPersonnels { get; set; }
        public DbSet<GdprArticle> GdprArticles { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //setting the relatedmaturitylevels
            modelBuilder.Entity<MaturityLevel>()
     .HasMany(e => e.RelatedMaturityLevels)
     .WithRequired()
     .HasForeignKey(e => e.MaturityLevelId);

            //Setting the related Gdpr articles to the current security practice
            modelBuilder.Entity<SecurityPractice>().HasMany(i => i.RelatedGpdrArticles).WithMany();
            modelBuilder.Entity<GdprArticle>().HasMany(i => i.RelatedSecurityPractices).WithMany();
        }
    }
    
}