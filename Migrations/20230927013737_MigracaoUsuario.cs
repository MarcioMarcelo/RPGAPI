using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                column: "UsuarioId",
                value: null);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 76, 242, 253, 165, 180, 12, 235, 39, 28, 121, 238, 187, 206, 148, 196, 117, 238, 162, 175, 196, 55, 82, 183, 175, 146, 238, 85, 10, 207, 42, 30, 28, 59, 95, 253, 236, 35, 168, 61, 71, 139, 46, 25, 178, 204, 238, 210, 129, 158, 41, 223, 101, 128, 127, 4, 221, 66, 53, 19, 225, 4, 104, 145, 197 }, new byte[] { 206, 118, 12, 14, 204, 83, 206, 213, 110, 194, 173, 245, 192, 143, 121, 63, 250, 172, 165, 192, 179, 66, 169, 250, 62, 127, 175, 255, 98, 201, 220, 2, 220, 224, 248, 139, 251, 19, 67, 177, 117, 194, 131, 133, 230, 92, 177, 242, 242, 209, 158, 17, 221, 51, 74, 23, 6, 163, 101, 66, 188, 128, 184, 38, 39, 39, 74, 12, 131, 26, 194, 75, 14, 102, 35, 157, 221, 15, 106, 186, 248, 184, 133, 123, 235, 227, 194, 136, 107, 124, 47, 65, 71, 129, 55, 79, 55, 37, 98, 115, 199, 135, 74, 207, 156, 146, 147, 167, 77, 98, 69, 243, 115, 193, 58, 153, 169, 104, 224, 6, 107, 239, 9, 220, 167, 250, 109, 60 } });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioId",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                column: "UsuarioId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                column: "UsuarioId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                column: "UsuarioId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                column: "UsuarioId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                column: "UsuarioId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                column: "UsuarioId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                column: "UsuarioId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 122, 95, 175, 216, 108, 143, 137, 224, 157, 109, 93, 181, 231, 86, 75, 54, 73, 239, 187, 108, 255, 176, 160, 157, 69, 92, 140, 145, 107, 141, 14, 49, 25, 123, 218, 159, 1, 81, 167, 94, 239, 51, 66, 9, 63, 81, 64, 71, 156, 185, 31, 44, 84, 60, 229, 48, 11, 58, 220, 98, 77, 188, 86, 163 }, new byte[] { 164, 243, 155, 177, 181, 152, 19, 56, 163, 82, 229, 27, 248, 153, 239, 217, 79, 80, 215, 77, 108, 161, 65, 234, 108, 149, 82, 178, 51, 101, 21, 189, 175, 71, 167, 168, 70, 60, 176, 69, 178, 47, 201, 203, 108, 10, 190, 142, 182, 193, 206, 209, 58, 102, 218, 29, 194, 66, 145, 28, 198, 170, 145, 177, 34, 3, 0, 188, 214, 50, 109, 9, 249, 232, 135, 64, 26, 19, 30, 149, 12, 54, 246, 28, 233, 155, 213, 195, 97, 162, 129, 194, 177, 56, 8, 166, 114, 243, 8, 32, 83, 125, 107, 12, 90, 34, 137, 229, 77, 26, 142, 94, 175, 245, 171, 22, 5, 76, 80, 155, 115, 21, 245, 224, 198, 63, 4, 159 } });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
