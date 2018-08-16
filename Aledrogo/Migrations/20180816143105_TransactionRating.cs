using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aledrogo.Migrations
{
    public partial class TransactionRating : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_DeliveryMethod_SelectedDeliveryMethodId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_UserId1",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductDeliveryMethod_ProductDeliveryMethod_ProductDeliveryMethodId",
                table: "ProductDeliveryMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionRating_DeliveryMethod_DeliveryMethodId",
                table: "TransactionRating");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionRating_Product_ProductId",
                table: "TransactionRating");

            migrationBuilder.DropIndex(
                name: "IX_TransactionRating_DeliveryMethodId",
                table: "TransactionRating");

            migrationBuilder.DropIndex(
                name: "IX_TransactionRating_ProductId",
                table: "TransactionRating");

            migrationBuilder.DropIndex(
                name: "IX_ProductDeliveryMethod_ProductDeliveryMethodId",
                table: "ProductDeliveryMethod");

            migrationBuilder.DropIndex(
                name: "IX_Order_SelectedDeliveryMethodId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DeliveryMethodId",
                table: "TransactionRating");

            migrationBuilder.DropColumn(
                name: "ProductDeliveryMethodId",
                table: "ProductDeliveryMethod");

            migrationBuilder.DropColumn(
                name: "ItemInStock",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "SelectedDeliveryMethodId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ParentCatrgoryId",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "TransactionRating",
                newName: "SellerId");

            migrationBuilder.RenameColumn(
                name: "UserId1",
                table: "Product",
                newName: "SellerId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Product",
                newName: "ItemsInStock");

            migrationBuilder.RenameIndex(
                name: "IX_Product_UserId1",
                table: "Product",
                newName: "IX_Product_SellerId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Order",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserId",
                table: "Order",
                newName: "IX_Order_CustomerId");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "TransactionRating",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SellerId1",
                table: "TransactionRating",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Completed",
                table: "Order",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DeliveryMethodId",
                table: "Order",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Order",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ParentCategoryId",
                table: "Category",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TransactionRatingResponses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: true),
                    TransactionRatingId = table.Column<int>(nullable: false),
                    Response = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionRatingResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TransactionRatingResponses_TransactionRating_TransactionRatingId",
                        column: x => x.TransactionRatingId,
                        principalTable: "TransactionRating",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionRatingResponses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRating_OrderId",
                table: "TransactionRating",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRating_SellerId1",
                table: "TransactionRating",
                column: "SellerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_DeliveryMethodId",
                table: "Order",
                column: "DeliveryMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentCategoryId",
                table: "Category",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRatingResponses_TransactionRatingId",
                table: "TransactionRatingResponses",
                column: "TransactionRatingId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRatingResponses_UserId",
                table: "TransactionRatingResponses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Category_ParentCategoryId",
                table: "Category",
                column: "ParentCategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_CustomerId",
                table: "Order",
                column: "CustomerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_DeliveryMethod_DeliveryMethodId",
                table: "Order",
                column: "DeliveryMethodId",
                principalTable: "DeliveryMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_SellerId",
                table: "Product",
                column: "SellerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionRating_Order_OrderId",
                table: "TransactionRating",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionRating_AspNetUsers_SellerId1",
                table: "TransactionRating",
                column: "SellerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Category_ParentCategoryId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_AspNetUsers_CustomerId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_DeliveryMethod_DeliveryMethodId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_AspNetUsers_SellerId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionRating_Order_OrderId",
                table: "TransactionRating");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionRating_AspNetUsers_SellerId1",
                table: "TransactionRating");

            migrationBuilder.DropTable(
                name: "TransactionRatingResponses");

            migrationBuilder.DropIndex(
                name: "IX_TransactionRating_OrderId",
                table: "TransactionRating");

            migrationBuilder.DropIndex(
                name: "IX_TransactionRating_SellerId1",
                table: "TransactionRating");

            migrationBuilder.DropIndex(
                name: "IX_Order_DeliveryMethodId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Category_ParentCategoryId",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "TransactionRating");

            migrationBuilder.DropColumn(
                name: "SellerId1",
                table: "TransactionRating");

            migrationBuilder.DropColumn(
                name: "Completed",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DeliveryMethodId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ParentCategoryId",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "TransactionRating",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "Product",
                newName: "UserId1");

            migrationBuilder.RenameColumn(
                name: "ItemsInStock",
                table: "Product",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_SellerId",
                table: "Product",
                newName: "IX_Product_UserId1");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Order",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                newName: "IX_Order_UserId");

            migrationBuilder.AddColumn<int>(
                name: "DeliveryMethodId",
                table: "TransactionRating",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductDeliveryMethodId",
                table: "ProductDeliveryMethod",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ItemInStock",
                table: "Product",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SelectedDeliveryMethodId",
                table: "Order",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ParentCatrgoryId",
                table: "Category",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRating_DeliveryMethodId",
                table: "TransactionRating",
                column: "DeliveryMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionRating_ProductId",
                table: "TransactionRating",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDeliveryMethod_ProductDeliveryMethodId",
                table: "ProductDeliveryMethod",
                column: "ProductDeliveryMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_SelectedDeliveryMethodId",
                table: "Order",
                column: "SelectedDeliveryMethodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_DeliveryMethod_SelectedDeliveryMethodId",
                table: "Order",
                column: "SelectedDeliveryMethodId",
                principalTable: "DeliveryMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_AspNetUsers_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_AspNetUsers_UserId1",
                table: "Product",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductDeliveryMethod_ProductDeliveryMethod_ProductDeliveryMethodId",
                table: "ProductDeliveryMethod",
                column: "ProductDeliveryMethodId",
                principalTable: "ProductDeliveryMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionRating_DeliveryMethod_DeliveryMethodId",
                table: "TransactionRating",
                column: "DeliveryMethodId",
                principalTable: "DeliveryMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionRating_Product_ProductId",
                table: "TransactionRating",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
