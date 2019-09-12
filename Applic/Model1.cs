namespace Applic
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Контекст настроен для использования строки подключения "Model1" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "Applic.Model1" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "Model1" 
        // в файле конфигурации приложения.
        public Model1()
            : base("name=Model1")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Furnitura> Furnituras { get; set; }
        public DbSet<FurnituraIzd> FurnituraIzds { get; set; }
        public DbSet<Izdelie> Izdelies { get; set; }
        public DbSet<ScladFurn> ScladFurns { get; set; }
        public DbSet<ScladTkan> ScladTkans { get; set; }
        public DbSet<Tkan> Tkans { get; set; }
        public DbSet<TkanIzd> TkanIzds { get; set; }
        public DbSet<Zakaz> Zakazs { get; set; }
        public DbSet<ZakazIzd> ZakazIzds { get; set; }


        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}