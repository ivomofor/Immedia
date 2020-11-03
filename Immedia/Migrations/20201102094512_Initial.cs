using Microsoft.EntityFrameworkCore.Migrations;

namespace Immedia.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Geocodes",
                columns: table => new
                {
                    GeocodeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Where = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geocodes", x => x.GeocodeId);
                });

            migrationBuilder.CreateTable(
                name: "Icons",
                columns: table => new
                {
                    IconId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prefix = table.Column<string>(nullable: true),
                    Suffix = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icons", x => x.IconId);
                });

            migrationBuilder.CreateTable(
                name: "JsonDatas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Json = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JsonDatas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RootImages",
                columns: table => new
                {
                    RootImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(nullable: true),
                    ImageIdentity = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RootImages", x => x.RootImageId);
                });

            migrationBuilder.CreateTable(
                name: "Roots",
                columns: table => new
                {
                    RootId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roots", x => x.RootId);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    FeatureId = table.Column<int>(nullable: false),
                    CC = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DisplayName = table.Column<string>(nullable: true),
                    MatchedName = table.Column<string>(nullable: true),
                    HighlightedName = table.Column<string>(nullable: true),
                    WoeType = table.Column<int>(nullable: false),
                    Slug = table.Column<string>(nullable: true),
                    longId = table.Column<string>(nullable: true),
                    GeocodeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Features_Geocodes_GeocodeId",
                        column: x => x.GeocodeId,
                        principalTable: "Geocodes",
                        principalColumn: "GeocodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Hits",
                columns: table => new
                {
                    HitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id = table.Column<int>(nullable: false),
                    type = table.Column<string>(nullable: true),
                    tags = table.Column<string>(nullable: true),
                    webformatURL = table.Column<string>(nullable: true),
                    webformatWidth = table.Column<int>(nullable: false),
                    webformatHeight = table.Column<int>(nullable: false),
                    largeImageURL = table.Column<string>(nullable: true),
                    imageWidth = table.Column<int>(nullable: false),
                    imageHeight = table.Column<int>(nullable: false),
                    imageSize = table.Column<int>(nullable: false),
                    views = table.Column<int>(nullable: false),
                    downloads = table.Column<int>(nullable: false),
                    favorites = table.Column<int>(nullable: false),
                    likes = table.Column<int>(nullable: false),
                    comments = table.Column<int>(nullable: false),
                    user = table.Column<string>(nullable: true),
                    RootImageId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hits", x => x.HitId);
                    table.ForeignKey(
                        name: "FK_Hits_RootImages_RootImageId",
                        column: x => x.RootImageId,
                        principalTable: "RootImages",
                        principalColumn: "RootImageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    ResponseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeocodeId = table.Column<int>(nullable: true),
                    RootId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.ResponseId);
                    table.ForeignKey(
                        name: "FK_Responses_Geocodes_GeocodeId",
                        column: x => x.GeocodeId,
                        principalTable: "Geocodes",
                        principalColumn: "GeocodeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Responses_Roots_RootId",
                        column: x => x.RootId,
                        principalTable: "Roots",
                        principalColumn: "RootId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    VenueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ResponseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venues", x => x.VenueId);
                    table.ForeignKey(
                        name: "FK_Venues_Responses_ResponseId",
                        column: x => x.ResponseId,
                        principalTable: "Responses",
                        principalColumn: "ResponseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PluralName = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    IconId = table.Column<int>(nullable: true),
                    VenueId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                    table.ForeignKey(
                        name: "FK_Categories_Icons_IconId",
                        column: x => x.IconId,
                        principalTable: "Icons",
                        principalColumn: "IconId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Categories_Venues_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venues",
                        principalColumn: "VenueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    CrossStreet = table.Column<string>(nullable: true),
                    lat = table.Column<double>(nullable: false),
                    lng = table.Column<double>(nullable: false),
                    PostalCode = table.Column<string>(nullable: true),
                    CC = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    VenueId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Locations_Venues_VenueId",
                        column: x => x.VenueId,
                        principalTable: "Venues",
                        principalColumn: "VenueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_IconId",
                table: "Categories",
                column: "IconId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_VenueId",
                table: "Categories",
                column: "VenueId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_GeocodeId",
                table: "Features",
                column: "GeocodeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hits_RootImageId",
                table: "Hits",
                column: "RootImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_VenueId",
                table: "Locations",
                column: "VenueId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Responses_GeocodeId",
                table: "Responses",
                column: "GeocodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Responses_RootId",
                table: "Responses",
                column: "RootId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Venues_ResponseId",
                table: "Venues",
                column: "ResponseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apis");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "Hits");

            migrationBuilder.DropTable(
                name: "JsonDatas");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Icons");

            migrationBuilder.DropTable(
                name: "RootImages");

            migrationBuilder.DropTable(
                name: "Venues");

            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Geocodes");

            migrationBuilder.DropTable(
                name: "Roots");
        }
    }
}
