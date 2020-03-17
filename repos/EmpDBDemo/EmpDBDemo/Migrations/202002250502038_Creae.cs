namespace EmpDBDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Creae : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Did = c.Int(nullable: false),
                        Dname = c.String(nullable: false),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.Did);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Eid = c.Int(nullable: false),
                        Ename = c.String(nullable: false),
                        Designation = c.String(),
                        Did = c.Int(nullable: false),
                        Salary = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Eid)
                .ForeignKey("dbo.Departments", t => t.Did, cascadeDelete: true)
                .Index(t => t.Did);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Did", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "Did" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
