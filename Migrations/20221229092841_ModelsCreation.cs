using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FitnessApplication.Migrations
{
    /// <inheritdoc />
    public partial class ModelsCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    email = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(name: "First_Name", type: "text", nullable: false),
                    LastName = table.Column<string>(name: "Last_Name", type: "text", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    PhoneNumber = table.Column<string>(name: "Phone_Number", type: "text", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FoodProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProductName = table.Column<string>(name: "Product_Name", type: "text", nullable: false),
                    Calories = table.Column<int>(type: "integer", nullable: false),
                    TotalFat = table.Column<int>(name: "Total_Fat", type: "integer", nullable: false),
                    Saturated = table.Column<int>(type: "integer", nullable: false),
                    Trans = table.Column<int>(type: "integer", nullable: false),
                    Polyunsaturated = table.Column<int>(type: "integer", nullable: false),
                    Monounsaturated = table.Column<int>(type: "integer", nullable: false),
                    Cholesterol = table.Column<int>(type: "integer", nullable: false),
                    Sodium = table.Column<int>(type: "integer", nullable: false),
                    TotalCarbohydrates = table.Column<int>(name: "Total_Carbohydrates", type: "integer", nullable: false),
                    DietaryFiber = table.Column<int>(name: "Dietary_Fiber", type: "integer", nullable: false),
                    Sugar = table.Column<int>(type: "integer", nullable: false),
                    AddedSugar = table.Column<int>(name: "Added_Sugar", type: "integer", nullable: false),
                    SugarAlcohols = table.Column<int>(name: "Sugar_Alcohols", type: "integer", nullable: false),
                    Protein = table.Column<int>(type: "integer", nullable: false),
                    VitaminD = table.Column<int>(name: "Vitamin_D", type: "integer", nullable: false),
                    Calcium = table.Column<int>(type: "integer", nullable: false),
                    Iron = table.Column<int>(type: "integer", nullable: false),
                    VitaminA = table.Column<int>(name: "Vitamin_A", type: "integer", nullable: false),
                    VitaminC = table.Column<int>(name: "Vitamin_C", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodProducts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DailyDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    BurnedCalories = table.Column<float>(name: "Burned_Calories", type: "real", nullable: false),
                    ConsumedCalories = table.Column<float>(name: "Consumed_Calories", type: "real", nullable: false),
                    CurrentWeight = table.Column<float>(name: "Current_Weight", type: "real", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: true),
                    MealType = table.Column<int>(name: "Meal_Type", type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diaries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diaries_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Preferences",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Plan = table.Column<int>(type: "integer", nullable: false),
                    WeightGoal = table.Column<float>(name: "Weight_Goal", type: "real", nullable: false),
                    BaselineActivity = table.Column<int>(name: "Baseline_Activity", type: "integer", nullable: false),
                    WeeklyGoal = table.Column<float>(name: "Weekly_Goal", type: "real", nullable: false),
                    AccountId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preferences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Preferences_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DiaryFoodProduct",
                columns: table => new
                {
                    DiaryId = table.Column<int>(type: "integer", nullable: false),
                    FoodProductId = table.Column<int>(name: "Food_ProductId", type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaryFoodProduct", x => new { x.DiaryId, x.FoodProductId });
                    table.ForeignKey(
                        name: "FK_DiaryFoodProduct_Diaries_DiaryId",
                        column: x => x.DiaryId,
                        principalTable: "Diaries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiaryFoodProduct_FoodProducts_Food_ProductId",
                        column: x => x.FoodProductId,
                        principalTable: "FoodProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diaries_AccountId",
                table: "Diaries",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_DiaryFoodProduct_Food_ProductId",
                table: "DiaryFoodProduct",
                column: "Food_ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Preferences_AccountId",
                table: "Preferences",
                column: "AccountId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaryFoodProduct");

            migrationBuilder.DropTable(
                name: "Preferences");

            migrationBuilder.DropTable(
                name: "Diaries");

            migrationBuilder.DropTable(
                name: "FoodProducts");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
