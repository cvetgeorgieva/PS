using System;

public class DatabaseContext : DbContext
{
	public DatabaseContext()
	{
		protected override void OnConfiguring(DbContexOptionsBuilder optionsBuilder) 
		{
			string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string databaseFile = "Welcome.db";
			string databasePath = databasePath.Combine(solutionFolder, databaseFile);
			optionsBuilder.UseSqlite($"Data Sourse={databasePath}");	
		}

	protected override void OnModelCreating(ModelBuilder modelBuilder) 
	{
		modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();

		//Create a user
		var user = new DatabaseUser()
		{
			Id = 1,
			Name = "John Doe",
			Password = "1234",
			Role = UserRolesEnum.Administrator,
			Expires = DateTime.Now.AddYears(10)
		};

		modelBuilder.Entity<DatabaseUser>()
			.HasData(user);

        var user1 = new DatabaseUser()
        {
            Id = 2,
            Name = "Nik Doe",
            Password = "1235",
            Role = UserRolesEnum.ADMIN,
            Expires = DateTime.Now.AddYears(20)
        };

        modelBuilder.Entity<DatabaseUser>()
            .HasData(user1);

        var user2 = new DatabaseUser()
        {
            Id = 3,
            Name = "Gog Doe",
            Password = "1935",
            Role = UserRolesEnum.PROFESSOR,
            Expires = DateTime.Now.AddYears(30)
        };

        modelBuilder.Entity<DatabaseUser>()
            .HasData(user2);
    }

	public DbSet<DatabaseUser> Users { get; set; }

	}
