using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aledrogo.Migrations
{
    public partial class changeSpecificiFieldValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PredefinedValueForCategoryField");

            migrationBuilder.DropTable(
                name: "SelectedValueForCategoryField");

            migrationBuilder.DropTable(
                name: "CategorySpecificField");

            migrationBuilder.CreateTable(
                name: "SpecificFieldValue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificFieldValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product_SpecificFieldValues",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    SpecificFieldValueId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_SpecificFieldValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_SpecificFieldValues_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_SpecificFieldValues_SpecificFieldValue_SpecificFieldValueId",
                        column: x => x.SpecificFieldValueId,
                        principalTable: "SpecificFieldValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecificField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    SpecificFieldValueId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsRequired = table.Column<bool>(nullable: false),
                    CanBeUnknown = table.Column<bool>(nullable: false),
                    CustomNumericValueAllowed = table.Column<bool>(nullable: false),
                    MinNumber = table.Column<int>(nullable: true),
                    MaxNumber = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpecificField_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SpecificField_SpecificFieldValue_SpecificFieldValueId",
                        column: x => x.SpecificFieldValueId,
                        principalTable: "SpecificFieldValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_SpecificFieldValues_ProductId",
                table: "Product_SpecificFieldValues",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_SpecificFieldValues_SpecificFieldValueId",
                table: "Product_SpecificFieldValues",
                column: "SpecificFieldValueId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificField_CategoryId",
                table: "SpecificField",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SpecificField_SpecificFieldValueId",
                table: "SpecificField",
                column: "SpecificFieldValueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product_SpecificFieldValues");

            migrationBuilder.DropTable(
                name: "SpecificField");

            migrationBuilder.DropTable(
                name: "SpecificFieldValue");

            migrationBuilder.CreateTable(
                name: "CategorySpecificField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CanBeUnknown = table.Column<bool>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    CustomNumericValueAllowed = table.Column<bool>(nullable: false),
                    IsRequired = table.Column<bool>(nullable: false),
                    MaxNumber = table.Column<int>(nullable: true),
                    MinNumber = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategorySpecificField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategorySpecificField_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PredefinedValueForCategoryField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryFieldId = table.Column<int>(nullable: false),
                    Value = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PredefinedValueForCategoryField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PredefinedValueForCategoryField_CategorySpecificField_CategoryFieldId",
                        column: x => x.CategoryFieldId,
                        principalTable: "CategorySpecificField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SelectedValueForCategoryField",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryFieldId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedValueForCategoryField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SelectedValueForCategoryField_CategorySpecificField_CategoryFieldId",
                        column: x => x.CategoryFieldId,
                        principalTable: "CategorySpecificField",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SelectedValueForCategoryField_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategorySpecificField_CategoryId",
                table: "CategorySpecificField",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PredefinedValueForCategoryField_CategoryFieldId",
                table: "PredefinedValueForCategoryField",
                column: "CategoryFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedValueForCategoryField_CategoryFieldId",
                table: "SelectedValueForCategoryField",
                column: "CategoryFieldId");

            migrationBuilder.CreateIndex(
                name: "IX_SelectedValueForCategoryField_ProductId",
                table: "SelectedValueForCategoryField",
                column: "ProductId");
        }
    }
}
