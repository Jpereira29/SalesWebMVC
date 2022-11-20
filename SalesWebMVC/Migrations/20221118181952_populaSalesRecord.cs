using Microsoft.EntityFrameworkCore.Migrations;
using SalesWebMVC.Models.Enums;
using SalesWebMVC.Models;

#nullable disable

namespace SalesWebMVC.Migrations
{
    public partial class populaSalesRecord : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into SalesRecord(Date, Amount, Status, SellerId)" +
                "Values('2022-07-01', 1300.0, 1, 1)");

            mb.Sql("Insert into SalesRecord(Date, Amount, Status, SellerId)" +
                "Values('2022-07-01', 300.0, 1, 3)");

            mb.Sql("Insert into SalesRecord(Date, Amount, Status, SellerId)" +
                "Values('2022-07-03', 3300.0, 1, 2)");

            mb.Sql("Insert into SalesRecord(Date, Amount, Status, SellerId)" +
                "Values('2022-07-02', 400.0, 1, 2)");

            mb.Sql("Insert into SalesRecord(Date, Amount, Status, SellerId)" +
                "Values('2022-07-02', 300.0, 1, 1)");

            mb.Sql("Insert into SalesRecord(Date, Amount, Status, SellerId)" +
                "Values('2022-07-02', 350.0, 1, 4)");

            mb.Sql("Insert into SalesRecord(Date, Amount, Status, SellerId)" +
                "Values('2022-07-01', 300.0, 1, 5)");

            mb.Sql("Insert into SalesRecord(Date, Amount, Status, SellerId)" +
                "Values('2022-07-03', 490.0, 1, 3)");

            mb.Sql("Insert into SalesRecord(Date, Amount, Status, SellerId)" +
                "Values('2022-07-04', 150.0, 1, 2)");

            mb.Sql("Insert into SalesRecord(Date, Amount, Status, SellerId)" +
                "Values('2022-07-03', 700.0, 1, 5)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from SalesRecord");
        }
    }
}
