using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 155, 240, 67, 54, 22, 116, 82, 208, 133, 22, 237, 110, 17, 157, 87, 92, 56, 186, 161, 80, 89, 155, 102, 59, 173, 184, 1, 214, 215, 65, 199, 83, 134, 58, 12, 92, 208, 78, 126, 55, 236, 193, 186, 225, 40, 192, 57, 197, 160, 201, 32, 175, 110, 175, 167, 122, 253, 40, 151, 14, 30, 248, 180, 58 }, new byte[] { 177, 200, 215, 210, 204, 86, 108, 236, 82, 196, 35, 135, 172, 227, 147, 198, 109, 249, 171, 164, 145, 235, 252, 43, 59, 141, 130, 220, 247, 221, 193, 47, 246, 85, 235, 166, 231, 1, 240, 113, 1, 167, 220, 103, 199, 43, 122, 81, 248, 23, 157, 177, 175, 253, 230, 111, 213, 105, 76, 19, 204, 67, 197, 135, 5, 41, 76, 170, 1, 183, 212, 29, 140, 37, 130, 22, 133, 43, 236, 31, 231, 200, 255, 185, 246, 59, 160, 96, 222, 67, 237, 65, 70, 137, 58, 173, 43, 10, 174, 221, 250, 104, 84, 31, 13, 11, 226, 229, 159, 188, 163, 55, 189, 252, 42, 47, 113, 112, 163, 45, 122, 190, 51, 135, 0, 242, 187, 102 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 76, 242, 253, 165, 180, 12, 235, 39, 28, 121, 238, 187, 206, 148, 196, 117, 238, 162, 175, 196, 55, 82, 183, 175, 146, 238, 85, 10, 207, 42, 30, 28, 59, 95, 253, 236, 35, 168, 61, 71, 139, 46, 25, 178, 204, 238, 210, 129, 158, 41, 223, 101, 128, 127, 4, 221, 66, 53, 19, 225, 4, 104, 145, 197 }, new byte[] { 206, 118, 12, 14, 204, 83, 206, 213, 110, 194, 173, 245, 192, 143, 121, 63, 250, 172, 165, 192, 179, 66, 169, 250, 62, 127, 175, 255, 98, 201, 220, 2, 220, 224, 248, 139, 251, 19, 67, 177, 117, 194, 131, 133, 230, 92, 177, 242, 242, 209, 158, 17, 221, 51, 74, 23, 6, 163, 101, 66, 188, 128, 184, 38, 39, 39, 74, 12, 131, 26, 194, 75, 14, 102, 35, 157, 221, 15, 106, 186, 248, 184, 133, 123, 235, 227, 194, 136, 107, 124, 47, 65, 71, 129, 55, 79, 55, 37, 98, 115, 199, 135, 74, 207, 156, 146, 147, 167, 77, 98, 69, 243, 115, 193, 58, 153, 169, 104, 224, 6, 107, 239, 9, 220, 167, 250, 109, 60 } });
        }
    }
}
