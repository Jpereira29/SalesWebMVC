using Microsoft.EntityFrameworkCore.Migrations;
using SalesWebMVC.Models;

#nullable disable

namespace SalesWebMVC.Migrations
{
    public partial class populaDepartment : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Department(Name)Values('Computers')");
            mb.Sql("Insert into Department(Name)Values('Eletronics')");
            mb.Sql("Insert into Department(Name)Values('Fashion')");
            mb.Sql("Insert into Department(Name)Values('Books')");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Department");
        }
    }
}
