namespace SPORTHUBAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class all : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserLogin",
                c => new
                    {
                        UserId = c.Long(nullable: false, identity: true),
                        UserName = c.String(),
                        UserPassword = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.PlayerInfo",
                c => new
                    {
                        PlayerId = c.Long(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        PlayerName = c.String(),
                        PlayerPhoneNo = c.String(),
                        Sport = c.String(),
                        City = c.String(),
                        role = c.String(),
                        Monday = c.String(),
                        Tuesday = c.String(),
                        Wednesday = c.String(),
                        Thursday = c.String(),
                        Friday = c.String(),
                        Saturday = c.String(),
                        Sunday = c.String(),
                    })
                .PrimaryKey(t => t.PlayerId);
            
            CreateTable(
                "dbo.TeamRegister",
                c => new
                    {
                        UserId = c.Long(nullable: false, identity: true),
                        TeamName = c.String(),
                        TeamSport = c.String(),
                        CityName = c.String(),
                        TeamArea = c.String(),
                        PhoneNo = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TeamRegister");
            DropTable("dbo.PlayerInfo");
            DropTable("dbo.UserLogin");
        }
    }
}
