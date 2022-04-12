using API_MySIRH.Entities;
using Microsoft.EntityFrameworkCore;

namespace API_MySIRH.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ToDoItem> ToDoItems { get; set; }

        public DbSet<ToDoList> ToDoLists { get; set; }

        public DbSet<Memo> Memos { get; set; }

        //public DbSet<Collaborater> Collaborators { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            
            this.ChangeTracker.DetectChanges();
            var added = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Added)
                        .Select(t => t.Entity)
                        .ToArray();

            foreach (var entity in added)
            {
                if (entity is EntityBase)
                {
                    var track = entity as EntityBase;
                    track.CreationDate = DateTime.Now;
                    track.ModificationDate= DateTime.Now;
                }
            }

            var modified = this.ChangeTracker.Entries()
                        .Where(t => t.State == EntityState.Modified)
                        .Select(t => t.Entity)
                        .ToArray();

            foreach (var entity in modified)
            {
                if (entity is EntityBase)
                {
                    var track = entity as EntityBase;
                    track.ModificationDate = DateTime.Now;
                }
            }

            // return await base.SaveChangesAsync().ConfigureAwait(false);

            return base.SaveChangesAsync();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Collaborater>().HasData(
                new Collaborater() {
                    Agency = "OUJDA",
                    Civility = true,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    DateOf1stExperience = DateTime.Now,
                    DateOfBirth = DateTime.Now,
                    Diplomas = "2022:Ingenieur",
                    Email = "Knaimi@sqli.com",
                    EntryDate = DateTime.Now,
                    FullName = "khalil Naimi",
                    InternshipStartDate = DateTime.Now,
                    Level = "Junior",
                    Login = "Knaimi",
                    RegistrationNumber = 32062,
                    Post = "Ingénieur Concepteur développeur",
                    SkillsCenter = "Skill Microsoft",

                },
                new Collaborater() {
                    Agency = "OUJDA",
                    Civility = true,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    DateOf1stExperience = DateTime.Now,
                    DateOfBirth = DateTime.Now,
                    Diplomas = "2022:Ingenieur",
                    Email = "Knaimi@sqli.com",
                    EntryDate = DateTime.Now,
                    FullName = "khalil Naimi",
                    InternshipStartDate = DateTime.Now,
                    Level = "Junior",
                    Login = "Knaimi",
                    RegistrationNumber = 32062,
                    Post = "Ingénieur Concepteur développeur",
                    SkillsCenter = "Skill Microsoft",

                },
                new Collaborater() {
                    Agency = "OUJDA",
                    Civility = true,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    DateOf1stExperience = DateTime.Now,
                    DateOfBirth = DateTime.Now,
                    Diplomas = "2022:Ingenieur",
                    Email = "Knaimi@sqli.com",
                    EntryDate = DateTime.Now,
                    FullName = "khalil Naimi",
                    InternshipStartDate = DateTime.Now,
                    Level = "Junior",
                    Login = "Knaimi",
                    RegistrationNumber = 32062,
                    Post = "Ingénieur Concepteur développeur",
                    SkillsCenter = "Skill Microsoft",

                },
                new Collaborater() {
                    Agency = "OUJDA",
                    Civility = true,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    DateOf1stExperience = DateTime.Now,
                    DateOfBirth = DateTime.Now,
                    Diplomas = "2022:Ingenieur",
                    Email = "Knaimi@sqli.com",
                    EntryDate = DateTime.Now,
                    FullName = "khalil Naimi",
                    InternshipStartDate = DateTime.Now,
                    Level = "Junior",
                    Login = "Knaimi",
                    RegistrationNumber = 32062,
                    Post = "Ingénieur Concepteur développeur",
                    SkillsCenter = "Skill Microsoft",

                },
                new Collaborater() {
                    Agency = "OUJDA",
                    Civility = true,
                    CreationDate = DateTime.Now,
                    ModificationDate = DateTime.Now,
                    DateOf1stExperience = DateTime.Now,
                    DateOfBirth = DateTime.Now,
                    Diplomas = "2022:Ingenieur",
                    Email = "Knaimi@sqli.com",
                    EntryDate = DateTime.Now,
                    FullName = "khalil Naimi",
                    InternshipStartDate = DateTime.Now,
                    Level = "Junior",
                    Login = "Knaimi",
                    RegistrationNumber = 32062,
                    Post = "Ingénieur Concepteur développeur",
                    SkillsCenter = "Skill Microsoft",

                });
            modelBuilder.Entity<ToDoList>().HasData(
                new ToDoList() { CreationDate = DateTime.Now, Description = "dasfsdf", ModificationDate = DateTime.Now, Ordre = 5, Titre = "dasdasda", ToDoItemList = { new ToDoItem() { Titre = "fsdfsdf" } } },
                new ToDoList() { CreationDate = DateTime.Now, Description = "dasfsdf", ModificationDate = DateTime.Now, Ordre = 5, Titre = "dasdasda", ToDoItemList = { new ToDoItem() { Titre = "fsdfsdf" } } },
                new ToDoList() { CreationDate = DateTime.Now, Description = "dasfsdf", ModificationDate = DateTime.Now, Ordre = 5, Titre = "dasdasda", ToDoItemList = { new ToDoItem() { Titre = "fsdfsdf" } } }
                );
        }
    }

}



