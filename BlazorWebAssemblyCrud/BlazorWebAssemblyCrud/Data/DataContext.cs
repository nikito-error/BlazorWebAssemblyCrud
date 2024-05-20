using BlazorWebAssemblyCrud.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAssemblyCrud.Data
{
	public class DataContext :DbContext
	{
		public DataContext(DbContextOptions<DataContext>options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Artikul>().HasData(
				new Artikul 
				{ 
				ArtikulID = 1,
				ArtikulName = "Televizor",
				ArtikulPrice = 5.33,
				ArtikulDate = new DateTime(2024, 02, 02)
				},
				new Artikul
				{
					ArtikulID = 2,
					ArtikulName = "Kasetofon",
					ArtikulPrice = 6.60,
					ArtikulDate = new DateTime(2024, 05, 20)
				}
				);
		}

		public DbSet<Artikul> artikuls { get; set; }
	
	}
}
