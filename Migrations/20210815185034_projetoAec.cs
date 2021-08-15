using Microsoft.EntityFrameworkCore.Migrations;

namespace aec_gama_api.Migrations
{
    public partial class projetoAec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "candidatos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    nascimento = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: true),
                    cep = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    logradouro = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    numero = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: false),
                    bairro = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    cidade = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    uf = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    telefone = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    email = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_candidatos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "profissoes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_profissoes", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "candidatos");

            migrationBuilder.DropTable(
                name: "profissoes");
        }
    }
}
