using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "ISBN", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "Åsa Jakobsson", "978-91-9845-302-7", "Klickerförlaget", "Vardagsträning med klicker" },
                    { 2, "Kyra Sundance & Chalcy", "978-91-7783-674-2", "Tucan förlag", "101 Hundtrick" },
                    { 3, "Sophie Collins", "978-91-7861-610-7", "Lindco", "Hjärngympa för hundar" },
                    { 4, "Per Jensen", "978-91-27-15187-1", "Natur & Kultur", "Den missförstådda hunden" },
                    { 5, "Per Jensen", "978-91-27-13108-8", "Natur & Kultur", "Hundens språk och tankar" },
                    { 6, "Kenth Svartberg", "978-91-978158-2-6", "Svartbergs Hundkunskap", "Bra relation" },
                    { 7, "Kerstin Malm och Malin Avenius", "978-9163989919", "AH Books", "Lär känna din hund - och dig själv" },
                    { 8, "Eva Bodfäldt", "978-91-973578-7-6", "Eva Bodfäldt Education AB", "Kontakt kontraktet" },
                    { 9, "Anders Hallgren", "978-91-6393-834-4", "AH Books", "Nyckeln till lycka - att motverka social stress hos hundar" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerEmail", "CustomerName", "CustomerPhone" },
                values: new object[,]
                {
                    { 1, "leon@mail.se", "Léon Nahum", "070-6233728" },
                    { 2, "andreas@mail.se", "Andreas Fors", "072-4421186" },
                    { 3, "nadine@mail.se", "Nadine Marklund", "076-6231458" },
                    { 4, "axel@mail.se", "Axel Wennström", "072-3664014" },
                    { 5, "miriam@mail.se", "Miriam Nahum", "073-8018685" }
                });

            migrationBuilder.InsertData(
                table: "BorrowHistories",
                columns: new[] { "BorrowHistoryId", "ActualReturnDate", "BorrowDate", "FkBookId", "FkCustomerId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 2 },
                    { 3, new DateTime(2024, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 4, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 4 },
                    { 5, new DateTime(2024, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 5 },
                    { 6, new DateTime(2024, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 1 },
                    { 7, null, new DateTime(2024, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 2 },
                    { 8, null, new DateTime(2024, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 3 },
                    { 9, null, new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BorrowHistories",
                keyColumn: "BorrowHistoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BorrowHistories",
                keyColumn: "BorrowHistoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BorrowHistories",
                keyColumn: "BorrowHistoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BorrowHistories",
                keyColumn: "BorrowHistoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BorrowHistories",
                keyColumn: "BorrowHistoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BorrowHistories",
                keyColumn: "BorrowHistoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BorrowHistories",
                keyColumn: "BorrowHistoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BorrowHistories",
                keyColumn: "BorrowHistoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BorrowHistories",
                keyColumn: "BorrowHistoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);
        }
    }
}
