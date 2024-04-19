using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RabotaTukRabotaTam.Data.Migrations
{
    public partial class SeedCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0d004d5a-a38e-4b47-9278-b6f04fdbbbfd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("444c7d78-2769-498b-9835-d3e9058f3030"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80efeb7e-6772-405f-86b7-a90551101121"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("977a1ac8-9741-4b86-ace4-cb0a56f98c25"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3a90ddd-5129-4b5d-8776-a342f5063447"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c024a559-1470-431a-9feb-ae56ba55304d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dcc99c8c-92ec-4e4a-8366-666010475774"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgURL", "Name" },
                values: new object[,]
                {
                    { new Guid("314abf2f-630a-4fec-a34a-6bab109f4d59"), "https://gikn.eu/wp-content/uploads/2020/02/Shopping-Cart-money.png", "Trade and sales" },
                    { new Guid("4712e632-351d-4e34-a370-d0971dd78151"), "https://freedesignfile.com/upload/2017/03/City-building-construction-template-vectors-19.jpg", "Architecture and construction" },
                    { new Guid("49e1b6fb-262e-4a9d-9d14-8c96c1c6b11f"), "https://static.vecteezy.com/system/resources/previews/003/623/370/original/planning-schedule-or-time-management-with-calendar-business-meeting-activities-and-events-organizing-process-office-working-background-illustration-vector.jpg", "Office and business activities" },
                    { new Guid("51f325ae-b3c2-4e05-a21f-228ef3addf2c"), "https://st3.depositphotos.com/3272603/14306/v/450/depositphotos_143068019-stock-illustration-restaurant-cafe-cartoons-vector.jpg", "Bars and restaurants" },
                    { new Guid("a57545b7-60a1-4442-9ec2-3920277c551a"), "https://t3.ftcdn.net/jpg/02/62/29/32/360_F_262293274_BgGtnhf3gAZJkEt5vMj88oUK5Pwjguji.jpg", "Couriers and drivers" },
                    { new Guid("f9552326-6289-4d58-b847-17777aab0715"), "https://authorservices.taylorandfrancis.com/wp-content/uploads/2022/10/Icon_production-1170x1170.png", "Production" },
                    { new Guid("fe33f76f-0fed-4d85-b713-88784dc74a80"), "https://static.vecteezy.com/system/resources/previews/015/694/764/original/skyscraper-hotel-building-flat-cartoon-hand-drawn-illustration-template-with-view-on-city-space-of-street-panorama-design-vector.jpg", "Hotels" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("314abf2f-630a-4fec-a34a-6bab109f4d59"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4712e632-351d-4e34-a370-d0971dd78151"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49e1b6fb-262e-4a9d-9d14-8c96c1c6b11f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("51f325ae-b3c2-4e05-a21f-228ef3addf2c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a57545b7-60a1-4442-9ec2-3920277c551a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f9552326-6289-4d58-b847-17777aab0715"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fe33f76f-0fed-4d85-b713-88784dc74a80"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImgURL", "Name" },
                values: new object[,]
                {
                    { new Guid("0d004d5a-a38e-4b47-9278-b6f04fdbbbfd"), "https://gikn.eu/wp-content/uploads/2020/02/Shopping-Cart-money.png", "Trade and sales" },
                    { new Guid("444c7d78-2769-498b-9835-d3e9058f3030"), "https://static.vecteezy.com/system/resources/previews/015/694/764/original/skyscraper-hotel-building-flat-cartoon-hand-drawn-illustration-template-with-view-on-city-space-of-street-panorama-design-vector.jpg", "Hotels" },
                    { new Guid("80efeb7e-6772-405f-86b7-a90551101121"), "https://static.vecteezy.com/system/resources/previews/003/623/370/original/planning-schedule-or-time-management-with-calendar-business-meeting-activities-and-events-organizing-process-office-working-background-illustration-vector.jpg", "Office and business activities" },
                    { new Guid("977a1ac8-9741-4b86-ace4-cb0a56f98c25"), "https://p1.hiclipart.com/preview/719/864/3/reading-architect-architecture-female-cartoon-drawing-line-construction-worker-png-clipart.jpg", "Architecture and construction" },
                    { new Guid("b3a90ddd-5129-4b5d-8776-a342f5063447"), "https://authorservices.taylorandfrancis.com/wp-content/uploads/2022/10/Icon_production-1170x1170.png", "Production" },
                    { new Guid("c024a559-1470-431a-9feb-ae56ba55304d"), "https://st3.depositphotos.com/3272603/14306/v/450/depositphotos_143068019-stock-illustration-restaurant-cafe-cartoons-vector.jpg", "Bars and restaurants" },
                    { new Guid("dcc99c8c-92ec-4e4a-8366-666010475774"), "https://t3.ftcdn.net/jpg/02/62/29/32/360_F_262293274_BgGtnhf3gAZJkEt5vMj88oUK5Pwjguji.jpg", "Couriers and drivers" }
                });
        }
    }
}
