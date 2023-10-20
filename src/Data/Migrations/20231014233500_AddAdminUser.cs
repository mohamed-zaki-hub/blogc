using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace src.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] ([Id], [FristName], [LastName]) VALUES (N'937b5376-3afd-4098-bdb5-65a67c5d5023', N'mohamed', N'zaki')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [dbo][Users] WHERE Id ='937b5376-3afd-4098-bdb5-65a67c5d5023'");

        }
    }
}
