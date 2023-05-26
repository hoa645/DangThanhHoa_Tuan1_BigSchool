namespace DangThanhHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse1 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Courses", name: "LectureID", newName: "LecturerId");
            RenameIndex(table: "dbo.Courses", name: "IX_LectureID", newName: "IX_LecturerId");
            AlterColumn("dbo.Courses", "CategoryId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "CategoryId", c => c.String(nullable: false));
            RenameIndex(table: "dbo.Courses", name: "IX_LecturerId", newName: "IX_LectureID");
            RenameColumn(table: "dbo.Courses", name: "LecturerId", newName: "LectureID");
        }
    }
}
