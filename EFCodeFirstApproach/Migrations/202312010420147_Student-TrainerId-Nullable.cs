namespace EFCodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentTrainerIdNullable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tblStudent", "TrainerId", "dbo.Trainers");
            DropIndex("dbo.tblStudent", new[] { "TrainerId" });
            AlterColumn("dbo.tblStudent", "TrainerId", c => c.Int());
            CreateIndex("dbo.tblStudent", "TrainerId");
            AddForeignKey("dbo.tblStudent", "TrainerId", "dbo.Trainers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblStudent", "TrainerId", "dbo.Trainers");
            DropIndex("dbo.tblStudent", new[] { "TrainerId" });
            AlterColumn("dbo.tblStudent", "TrainerId", c => c.Int(nullable: false));
            CreateIndex("dbo.tblStudent", "TrainerId");
            AddForeignKey("dbo.tblStudent", "TrainerId", "dbo.Trainers", "Id", cascadeDelete: true);
        }
    }
}
