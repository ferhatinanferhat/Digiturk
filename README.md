# Digiturk


VERİTABANI BAĞLANTISI

Digiturk/DAL/Concrete/EntityFrameworkCore/Context/

protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-RDA326M; Database=DigiturkArticle; Integrated Security=true;");
		}
