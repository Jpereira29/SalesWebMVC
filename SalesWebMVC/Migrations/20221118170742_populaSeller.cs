using Microsoft.EntityFrameworkCore.Migrations;
using SalesWebMVC.Models;

#nullable disable

namespace SalesWebMVC.Migrations
{
    public partial class populaSeller : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Seller(Name, Email, BirthDate, BaseSalary, DepartmentId)" +
                "Values('Jorge Pereira', 'jorge@gmail.com', '2001-07-03', 1000.0, 1)");

            mb.Sql("Insert into Seller(Name, Email, BirthDate, BaseSalary, DepartmentId)" +
                "Values('Maria Sthefane', 'maria@gmail.com', '2002-01-07', 3000.0, 1)");
            
            mb.Sql("Insert into Seller(Name, Email, BirthDate, BaseSalary, DepartmentId)" +
                "Values('George Pereira', 'george@gmail.com', '1998-06-09', 3300.0, 4)");

            mb.Sql("Insert into Seller(Name, Email, BirthDate, BaseSalary, DepartmentId)" +
                "Values('Juliane Pereira', 'juliane@gmail.com', '2005-09-14', 4200.0, 3)");

            mb.Sql("Insert into Seller(Name, Email, BirthDate, BaseSalary, DepartmentId)" +
                "Values('João Miguel', 'joao@gmail.com', '2016-07-03', 5700.0, 2)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Seller");
        }
    }
}
