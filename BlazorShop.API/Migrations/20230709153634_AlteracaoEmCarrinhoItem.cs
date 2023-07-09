using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorShop.API.Migrations
{
    /// <inheritdoc />
    public partial class AlteracaoEmCarrinhoItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhosItens_Carrinhos_CarrinhoId",
                table: "CarrinhosItens");

            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhosItens_Produtos_ProdutoId",
                table: "CarrinhosItens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarrinhosItens",
                table: "CarrinhosItens");

            migrationBuilder.RenameTable(
                name: "CarrinhosItens",
                newName: "CarrinhoItens");

            migrationBuilder.RenameIndex(
                name: "IX_CarrinhosItens_ProdutoId",
                table: "CarrinhoItens",
                newName: "IX_CarrinhoItens_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_CarrinhosItens_CarrinhoId",
                table: "CarrinhoItens",
                newName: "IX_CarrinhoItens_CarrinhoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarrinhoItens",
                table: "CarrinhoItens",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoItens_Carrinhos_CarrinhoId",
                table: "CarrinhoItens",
                column: "CarrinhoId",
                principalTable: "Carrinhos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhoItens_Produtos_ProdutoId",
                table: "CarrinhoItens",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoItens_Carrinhos_CarrinhoId",
                table: "CarrinhoItens");

            migrationBuilder.DropForeignKey(
                name: "FK_CarrinhoItens_Produtos_ProdutoId",
                table: "CarrinhoItens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarrinhoItens",
                table: "CarrinhoItens");

            migrationBuilder.RenameTable(
                name: "CarrinhoItens",
                newName: "CarrinhosItens");

            migrationBuilder.RenameIndex(
                name: "IX_CarrinhoItens_ProdutoId",
                table: "CarrinhosItens",
                newName: "IX_CarrinhosItens_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_CarrinhoItens_CarrinhoId",
                table: "CarrinhosItens",
                newName: "IX_CarrinhosItens_CarrinhoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarrinhosItens",
                table: "CarrinhosItens",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhosItens_Carrinhos_CarrinhoId",
                table: "CarrinhosItens",
                column: "CarrinhoId",
                principalTable: "Carrinhos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarrinhosItens_Produtos_ProdutoId",
                table: "CarrinhosItens",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
