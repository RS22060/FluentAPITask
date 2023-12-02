namespace FluentAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorBecameLecturer : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Authors", newName: "Lecturers");
            RenameColumn(table: "dbo.Courses", name: "Author_Id", newName: "Lecturer_Id");
            RenameIndex(table: "dbo.Courses", name: "IX_Author_Id", newName: "IX_Lecturer_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Courses", name: "IX_Lecturer_Id", newName: "IX_Author_Id");
            RenameColumn(table: "dbo.Courses", name: "Lecturer_Id", newName: "Author_Id");
            RenameTable(name: "dbo.Lecturers", newName: "Authors");
        }
    }
}
