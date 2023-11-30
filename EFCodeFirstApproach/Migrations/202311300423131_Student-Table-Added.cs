namespace EFCodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentTableAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblStudent",
                c => new
                    {
                        RollNumber = c.Int(nullable: false, identity: true),
                        StudentName = c.String(nullable: false, maxLength: 50, unicode: false),
                        Gender = c.String(maxLength: 20, unicode: false),
                        TrainerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RollNumber)
                .ForeignKey("dbo.Trainers", t => t.TrainerId, cascadeDelete: true)
                .Index(t => t.TrainerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblStudent", "TrainerId", "dbo.Trainers");
            DropIndex("dbo.tblStudent", new[] { "TrainerId" });
            DropTable("dbo.tblStudent");
        }
    }
}
