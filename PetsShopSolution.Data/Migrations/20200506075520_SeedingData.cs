using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetsShopSolution.Data.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppConfigs",
                columns: new[] { "Key", "Value" },
                values: new object[,]
                {
                    { "HomeTitle", "This is home page of eShopSolution" },
                    { "HomeKeyword", "This is keyword of eShopSolution" },
                    { "HomeDescription", "This is description of eShopSolution" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "IsShownOnHome", "Name", "ParentID", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder", "Status" },
                values: new object[,]
                {
                    { 1, true, "Chó", null, "cho", "Hãy lựa chọn những chú cún bạn yêu thích", "Những chú cún con đáng yêu nhất đang chờ bạn đón về nhà", 1, 1 },
                    { 2, true, "Mèo", null, "Meo", "Hãy lựa chọn những chú mèo bạn yêu thích", "Quàng thượng đang chờ sen rinh về :P", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "DateCreated", "Description", "Details", "Name", "OriginalPrice", "Price", "SeoAlias", "SeoDescription", "SeoTitle", "SortOrder" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 6, 14, 55, 19, 168, DateTimeKind.Local).AddTicks(5186), "Chó Husky lông đen 3 tháng tuổi", "Chó Husky lông đen 3 tháng tuổi", "Chó Husky lông đen 3 tháng tuổi", 3200000m, 6000000m, "Cho-Husky-long-den-3-thang-tuoi", "Chó Husky lông đen 3 tháng tuổi", "Chó Husky lông đen 3 tháng tuổi", 0 },
                    { 2, new DateTime(2020, 5, 6, 14, 55, 19, 171, DateTimeKind.Local).AddTicks(5448), "Mèo Ai Cập lông trắng mắt xanh", "Mèo Ai Cập lông trắng mắt xanh", "Mèo Ai Cập lông trắng mắt xanh", 1500000m, 2300000m, "meo-ai-cap-long-trang-mat-xanh", "Mèo Ai Cập lông trắng mắt xanh", "Mèo Ai Cập lông trắng mắt xanh", 0 }
                });

            migrationBuilder.InsertData(
                table: "ProductInCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "ProductInCategory",
                columns: new[] { "CategoryId", "ProductId" },
                values: new object[] { 2, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeDescription");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword");

            migrationBuilder.DeleteData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeTitle");

            migrationBuilder.DeleteData(
                table: "ProductInCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductInCategory",
                keyColumns: new[] { "CategoryId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
