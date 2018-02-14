namespace Vehicle_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmakes : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT [dbo].[VehicleModels] ON " +
                "INSERT [dbo].[VehicleModels] ([Id], [MakeId], [Name]) VALUES (1, 1, N'Make1-ModelA') " +
                "INSERT[dbo].[VehicleModels]([Id], [MakeId], [Name]) VALUES(2, 1, N'Make1-ModelB') " +
                "INSERT[dbo].[VehicleModels]([Id], [MakeId], [Name]) VALUES(3, 1, N'Make1-ModelC') " +
                "INSERT[dbo].[VehicleModels]([Id], [MakeId], [Name]) VALUES(4, 2, N'Make2-ModelA') " +
                "INSERT[dbo].[VehicleModels]([Id], [MakeId], [Name]) VALUES(5, 2, N'Make2-ModelB') " +
                "INSERT[dbo].[VehicleModels]([Id], [MakeId], [Name]) VALUES(6, 2, N'Make2-ModelC') " +
                "INSERT[dbo].[VehicleModels]([Id], [MakeId], [Name]) VALUES(7, 3, N'Make3-ModelA') " +
                "INSERT[dbo].[VehicleModels]([Id], [MakeId], [Name]) VALUES(8, 3, N'Make3-ModelB') " +
                "INSERT[dbo].[VehicleModels] ([Id], [MakeId], [Name]) VALUES(9, 3, N'Make3-ModelC') " +
                "SET IDENTITY_INSERT [dbo].[VehicleModels] OFF ");
        }
        
        public override void Down()
        {
        }
    }
}
