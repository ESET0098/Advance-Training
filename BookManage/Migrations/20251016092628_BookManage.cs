using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManage.Migrations
{
    /// <inheritdoc />
    public partial class BookManage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_saleItems_Book_book_id",
                table: "saleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_saleItems_sales_sale_id",
                table: "saleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_sales_customers_customer_id",
                table: "sales");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sales",
                table: "sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_saleItems",
                table: "saleItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_customers",
                table: "customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.EnsureSchema(
                name: "Admin");

            migrationBuilder.RenameTable(
                name: "sales",
                newName: "Sales",
                newSchema: "Admin");

            migrationBuilder.RenameTable(
                name: "saleItems",
                newName: "SaleItems",
                newSchema: "Admin");

            migrationBuilder.RenameTable(
                name: "customers",
                newName: "Customers",
                newSchema: "Admin");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "User",
                newSchema: "Admin");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books",
                newSchema: "Admin");

            migrationBuilder.RenameIndex(
                name: "IX_sales_customer_id",
                schema: "Admin",
                table: "Sales",
                newName: "IX_Sales_customer_id");

            migrationBuilder.RenameIndex(
                name: "IX_saleItems_sale_id",
                schema: "Admin",
                table: "SaleItems",
                newName: "IX_SaleItems_sale_id");

            migrationBuilder.RenameIndex(
                name: "IX_saleItems_book_id",
                schema: "Admin",
                table: "SaleItems",
                newName: "IX_SaleItems_book_id");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                schema: "Admin",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                schema: "Admin",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(101)",
                oldMaxLength: 101);

            migrationBuilder.AlterColumn<string>(
                name: "title",
                schema: "Admin",
                table: "Books",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "author",
                schema: "Admin",
                table: "Books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sales",
                schema: "Admin",
                table: "Sales",
                column: "sale_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SaleItems",
                schema: "Admin",
                table: "SaleItems",
                column: "sale_item_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                schema: "Admin",
                table: "Customers",
                column: "customer_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                schema: "Admin",
                table: "User",
                column: "user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                schema: "Admin",
                table: "Books",
                column: "book_id");

            migrationBuilder.AddForeignKey(
                name: "FK_SaleItems_Books_book_id",
                schema: "Admin",
                table: "SaleItems",
                column: "book_id",
                principalSchema: "Admin",
                principalTable: "Books",
                principalColumn: "book_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SaleItems_Sales_sale_id",
                schema: "Admin",
                table: "SaleItems",
                column: "sale_id",
                principalSchema: "Admin",
                principalTable: "Sales",
                principalColumn: "sale_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Customers_customer_id",
                schema: "Admin",
                table: "Sales",
                column: "customer_id",
                principalSchema: "Admin",
                principalTable: "Customers",
                principalColumn: "customer_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SaleItems_Books_book_id",
                schema: "Admin",
                table: "SaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_SaleItems_Sales_sale_id",
                schema: "Admin",
                table: "SaleItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Customers_customer_id",
                schema: "Admin",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sales",
                schema: "Admin",
                table: "Sales");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SaleItems",
                schema: "Admin",
                table: "SaleItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                schema: "Admin",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                schema: "Admin",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                schema: "Admin",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Sales",
                schema: "Admin",
                newName: "sales");

            migrationBuilder.RenameTable(
                name: "SaleItems",
                schema: "Admin",
                newName: "saleItems");

            migrationBuilder.RenameTable(
                name: "Customers",
                schema: "Admin",
                newName: "customers");

            migrationBuilder.RenameTable(
                name: "User",
                schema: "Admin",
                newName: "users");

            migrationBuilder.RenameTable(
                name: "Books",
                schema: "Admin",
                newName: "Book");

            migrationBuilder.RenameIndex(
                name: "IX_Sales_customer_id",
                table: "sales",
                newName: "IX_sales_customer_id");

            migrationBuilder.RenameIndex(
                name: "IX_SaleItems_sale_id",
                table: "saleItems",
                newName: "IX_saleItems_sale_id");

            migrationBuilder.RenameIndex(
                name: "IX_SaleItems_book_id",
                table: "saleItems",
                newName: "IX_saleItems_book_id");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "users",
                type: "nvarchar(101)",
                maxLength: 101,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "title",
                table: "Book",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "author",
                table: "Book",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_sales",
                table: "sales",
                column: "sale_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_saleItems",
                table: "saleItems",
                column: "sale_item_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_customers",
                table: "customers",
                column: "customer_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "user_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "book_id");

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_saleItems_Book_book_id",
                table: "saleItems",
                column: "book_id",
                principalTable: "Book",
                principalColumn: "book_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_saleItems_sales_sale_id",
                table: "saleItems",
                column: "sale_id",
                principalTable: "sales",
                principalColumn: "sale_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_sales_customers_customer_id",
                table: "sales",
                column: "customer_id",
                principalTable: "customers",
                principalColumn: "customer_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
