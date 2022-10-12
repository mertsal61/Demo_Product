using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class mig_addjob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.JobId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_customers_JobId",
                table: "customers",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_customers_jobs_JobId",
                table: "customers",
                column: "JobId",
                principalTable: "jobs",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_customers_jobs_JobId",
                table: "customers");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropIndex(
                name: "IX_customers_JobId",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "customers");
        }
    }
}
