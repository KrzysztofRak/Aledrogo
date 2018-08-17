using Microsoft.EntityFrameworkCore.Migrations;

namespace Aledrogo.Migrations
{
    public partial class DeliveryMethods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductOpinion_DeliveryMethod_DeliveryMethodId",
                table: "ProductOpinion");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductOpinion_Product_ProductId",
                table: "ProductOpinion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductOpinion",
                table: "ProductOpinion");

            migrationBuilder.RenameTable(
                name: "ProductOpinion",
                newName: "TransactionRating");

            migrationBuilder.RenameIndex(
                name: "IX_ProductOpinion_ProductId",
                table: "TransactionRating",
                newName: "IX_TransactionRating_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductOpinion_DeliveryMethodId",
                table: "TransactionRating",
                newName: "IX_TransactionRating_DeliveryMethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransactionRating",
                table: "TransactionRating",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionRating_DeliveryMethod_DeliveryMethodId",
                table: "TransactionRating");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionRating_Product_ProductId",
                table: "TransactionRating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransactionRating",
                table: "TransactionRating");

            migrationBuilder.RenameTable(
                name: "TransactionRating",
                newName: "ProductOpinion");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionRating_ProductId",
                table: "ProductOpinion",
                newName: "IX_ProductOpinion_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_TransactionRating_DeliveryMethodId",
                table: "ProductOpinion",
                newName: "IX_ProductOpinion_DeliveryMethodId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductOpinion",
                table: "ProductOpinion",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOpinion_DeliveryMethod_DeliveryMethodId",
                table: "ProductOpinion",
                column: "DeliveryMethodId",
                principalTable: "DeliveryMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductOpinion_Product_ProductId",
                table: "ProductOpinion",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
