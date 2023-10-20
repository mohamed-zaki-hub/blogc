using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace src.Data.Migrations
{
    /// <inheritdoc />
    public partial class AssignAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [UsersRoles] (UserId , RoleId) SELECT '937b5376-3afd-4098-bdb5-65a67c5d5023',Id FROM [Roles]");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [UsersRoles] WHERE UserId ='937b5376-3afd-4098-bdb5-65a67c5d5023'");
        }
    }
}
