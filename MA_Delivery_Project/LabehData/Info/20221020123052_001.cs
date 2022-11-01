using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MA_Delivery_Project.LabehData.Info
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "LabehDB");

            migrationBuilder.CreateTable(
                name: "ContractCategoryTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConractCategory = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractCategoryTab", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerCategoryTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoyName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCategoryTab", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerCode = table.Column<int>(type: "int", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LatitudeDefault = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LongtitudeDefault = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTab", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DriversCompaniesCatTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    CompaniesType = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriversCompaniesCatTab", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EvaluateAnswerTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluateAnswerTab", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EvaluateDriverTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Questions = table.Column<string>(type: "nvarchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvaluateDriverTab", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrganizeCode = table.Column<int>(type: "int", nullable: false),
                    OrganizeName = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationTab", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    PaymentWay = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTab", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StaffTypeTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    TypeName = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffTypeTab", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    VehicleName = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTab", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerCusCatTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    CustomerCatID = table.Column<int>(type: "int", nullable: false),
                    CurrentDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerCusCatTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CustomerCusCatTab_CustomerCategoryTab_CustomerCatID",
                        column: x => x.CustomerCatID,
                        principalSchema: "LabehDB",
                        principalTable: "CustomerCategoryTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CustomerCusCatTab_CustomerTab_CustomerID",
                        column: x => x.CustomerID,
                        principalSchema: "LabehDB",
                        principalTable: "CustomerTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DriverCompanyTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DriverCompCatID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverCompanyTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DriverCompanyTab_DriversCompaniesCatTab_DriverCompCatID",
                        column: x => x.DriverCompCatID,
                        principalSchema: "LabehDB",
                        principalTable: "DriversCompaniesCatTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "AnswerTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerTitle = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    QuestionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AnswerTab_EvaluateAnswerTab_QuestionID",
                        column: x => x.QuestionID,
                        principalSchema: "LabehDB",
                        principalTable: "EvaluateAnswerTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OrgsSubTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgsSubCode = table.Column<int>(type: "int", nullable: false),
                    OrgsSubName = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Latitiude = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Logtitude = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    OrganizationRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgsSubTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrgsSubTab_OrganizationTab_OrganizationRef",
                        column: x => x.OrganizationRef,
                        principalSchema: "LabehDB",
                        principalTable: "OrganizationTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SubCategoryTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: true),
                    SubCatName = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    OrganizationRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoryTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SubCategoryTab_OrganizationTab_OrganizationRef",
                        column: x => x.OrganizationRef,
                        principalSchema: "LabehDB",
                        principalTable: "OrganizationTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "StaffTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    StaffTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StaffTab_StaffTypeTab_StaffTypeID",
                        column: x => x.StaffTypeID,
                        principalSchema: "LabehDB",
                        principalTable: "StaffTypeTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DriverCompContractTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    OrganizationAddress = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    DateFrom = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    DateTo = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Phone1 = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Phone2 = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    DriverCompID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverCompContractTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DriverCompContractTab_DriverCompanyTab_DriverCompID",
                        column: x => x.DriverCompID,
                        principalSchema: "LabehDB",
                        principalTable: "DriverCompanyTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DriverTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverCode = table.Column<int>(type: "int", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    DriverPhone = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    LatitudeDefault = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    LongtitudeDefault = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    DriverEmail = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    DriverTypeId = table.Column<int>(type: "int", nullable: false),
                    DriverCompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DriverTab_DriverCompanyTab_DriverCompanyId",
                        column: x => x.DriverCompanyId,
                        principalSchema: "LabehDB",
                        principalTable: "DriverCompanyTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DriverTab_DriversCompaniesCatTab_DriverTypeId",
                        column: x => x.DriverTypeId,
                        principalSchema: "LabehDB",
                        principalTable: "DriversCompaniesCatTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BranchTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BranchName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    longtitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrgsSubID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BranchTab_OrgsSubTab_OrgsSubID",
                        column: x => x.OrgsSubID,
                        principalSchema: "LabehDB",
                        principalTable: "OrgsSubTab",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "ContractTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    OwnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganizationAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    OrgsSubIdRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContractTab_OrgsSubTab_OrgsSubIdRef",
                        column: x => x.OrgsSubIdRef,
                        principalSchema: "LabehDB",
                        principalTable: "OrgsSubTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "SubCategoryOrgsSubTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgSubIDRef = table.Column<int>(type: "int", nullable: false),
                    SubCategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoryOrgsSubTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SubCategoryOrgsSubTab_OrgsSubTab_OrgSubIDRef",
                        column: x => x.OrgSubIDRef,
                        principalSchema: "LabehDB",
                        principalTable: "OrgsSubTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_SubCategoryOrgsSubTab_SubCategoryTab_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalSchema: "LabehDB",
                        principalTable: "SubCategoryTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DriversContractTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    ContractDetaill = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    DateFrom = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    DateTo = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    DriverId = table.Column<int>(type: "int", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriversContractTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DriversContractTab_DriverTab_DriverId",
                        column: x => x.DriverId,
                        principalSchema: "LabehDB",
                        principalTable: "DriverTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DriverTrackingTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverCode = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    Longtitude = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    CurentDTime = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    CurrentHour = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    DriverID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverTrackingTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DriverTrackingTab_DriverTab_DriverID",
                        column: x => x.DriverID,
                        principalSchema: "LabehDB",
                        principalTable: "DriverTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DriverVehicleTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    DriverID = table.Column<int>(type: "int", nullable: false),
                    VehicleID = table.Column<int>(type: "int", nullable: false),
                    UsingDate = table.Column<string>(type: "nvarchar(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverVehicleTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DriverVehicleTab_DriverTab_DriverID",
                        column: x => x.DriverID,
                        principalSchema: "LabehDB",
                        principalTable: "DriverTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DriverVehicleTab_VehicleTab_VehicleID",
                        column: x => x.VehicleID,
                        principalSchema: "LabehDB",
                        principalTable: "VehicleTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "GeneralWaletTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FlagID = table.Column<int>(type: "int", nullable: false),
                    StaffId = table.Column<int>(type: "int", nullable: false),
                    BalanceValue = table.Column<decimal>(type: "decimal(13,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralWaletTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GeneralWaletTab_DriverTab_UserID",
                        column: x => x.UserID,
                        principalSchema: "LabehDB",
                        principalTable: "DriverTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_GeneralWaletTab_StaffTab_StaffId",
                        column: x => x.StaffId,
                        principalSchema: "LabehDB",
                        principalTable: "StaffTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ItemTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemsCode = table.Column<int>(type: "int", nullable: false),
                    ItemsName = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    ItemCost = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    OrgsSubRef = table.Column<int>(type: "int", nullable: false),
                    BranchesIDRef = table.Column<int>(type: "int", nullable: false),
                    FlagType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemTab_BranchTab_BranchesIDRef",
                        column: x => x.BranchesIDRef,
                        principalSchema: "LabehDB",
                        principalTable: "BranchTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ItemTab_OrgsSubTab_OrgsSubRef",
                        column: x => x.OrgsSubRef,
                        principalSchema: "LabehDB",
                        principalTable: "OrgsSubTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "MainOrgContactTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    BranchesContact = table.Column<int>(type: "int", nullable: false),
                    OrgsSubbIDRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainOrgContactTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MainOrgContactTab_BranchTab_BranchesContact",
                        column: x => x.BranchesContact,
                        principalSchema: "LabehDB",
                        principalTable: "BranchTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_MainOrgContactTab_OrgsSubTab_OrgsSubbIDRef",
                        column: x => x.OrgsSubbIDRef,
                        principalSchema: "LabehDB",
                        principalTable: "OrgsSubTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OfferTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OffersCode = table.Column<int>(type: "int", nullable: false),
                    OffersDetails = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    OffersPrice = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    BranchesIDRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OfferTab_BranchTab_BranchesIDRef",
                        column: x => x.BranchesIDRef,
                        principalSchema: "LabehDB",
                        principalTable: "BranchTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OrderTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    CurrentDate = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    BranchID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderTab_BranchTab_BranchID",
                        column: x => x.BranchID,
                        principalSchema: "LabehDB",
                        principalTable: "BranchTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OrderTab_CustomerTab_CustomerID",
                        column: x => x.CustomerID,
                        principalSchema: "LabehDB",
                        principalTable: "CustomerTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "BranchSubOrgsContractTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    OrgsSubID = table.Column<int>(type: "int", nullable: false),
                    ContractID = table.Column<int>(type: "int", nullable: false),
                    GenerationFees = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchSubOrgsContractTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BranchSubOrgsContractTab_BranchTab_BranchId",
                        column: x => x.BranchId,
                        principalSchema: "LabehDB",
                        principalTable: "BranchTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BranchSubOrgsContractTab_ContractTab_ContractID",
                        column: x => x.ContractID,
                        principalSchema: "LabehDB",
                        principalTable: "ContractTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_BranchSubOrgsContractTab_OrgsSubTab_OrgsSubID",
                        column: x => x.OrgsSubID,
                        principalSchema: "LabehDB",
                        principalTable: "OrgsSubTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CommisionTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    PaymentWayID = table.Column<int>(type: "int", nullable: false),
                    ContactID = table.Column<int>(type: "int", nullable: false),
                    Commisionamount = table.Column<decimal>(type: "decimal(13,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommisionTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CommisionTab_ContractTab_ContactID",
                        column: x => x.ContactID,
                        principalSchema: "LabehDB",
                        principalTable: "ContractTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CommisionTab_PaymentTab_PaymentWayID",
                        column: x => x.PaymentWayID,
                        principalSchema: "LabehDB",
                        principalTable: "PaymentTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ContractCCatTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractID = table.Column<int>(type: "int", nullable: false),
                    ContactCatID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractCCatTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ContractCCatTab_ContractCategoryTab_ContactCatID",
                        column: x => x.ContactCatID,
                        principalSchema: "LabehDB",
                        principalTable: "ContractCategoryTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ContractCCatTab_ContractTab_ContractID",
                        column: x => x.ContractID,
                        principalSchema: "LabehDB",
                        principalTable: "ContractTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "StockTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockCode = table.Column<int>(type: "int", nullable: false),
                    StockDetails = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    IDRef = table.Column<int>(type: "int", nullable: false),
                    FlagVal = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StockTab_ItemTab_IDRef",
                        column: x => x.IDRef,
                        principalSchema: "LabehDB",
                        principalTable: "ItemTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "OfferItemTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemIDef = table.Column<int>(type: "int", nullable: false),
                    OfferIDRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferItemTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OfferItemTab_ItemTab_ItemIDef",
                        column: x => x.ItemIDef,
                        principalSchema: "LabehDB",
                        principalTable: "ItemTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OfferItemTab_OfferTab_OfferIDRef",
                        column: x => x.OfferIDRef,
                        principalSchema: "LabehDB",
                        principalTable: "OfferTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "DriverTrackingOrderTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Longtitude = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    DriverTrackingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverTrackingOrderTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DriverTrackingOrderTab_DriverTrackingTab_DriverTrackingId",
                        column: x => x.DriverTrackingId,
                        principalSchema: "LabehDB",
                        principalTable: "DriverTrackingTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_DriverTrackingOrderTab_OrderTab_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "LabehDB",
                        principalTable: "OrderTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ItemOrderOfferTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemIDRef = table.Column<int>(type: "int", nullable: false),
                    OfferIDRef = table.Column<int>(type: "int", nullable: false),
                    OrderIDRef = table.Column<int>(type: "int", nullable: false),
                    FlagOfferItem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOrderOfferTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ItemOrderOfferTab_ItemTab_ItemIDRef",
                        column: x => x.ItemIDRef,
                        principalSchema: "LabehDB",
                        principalTable: "ItemTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ItemOrderOfferTab_OfferTab_OfferIDRef",
                        column: x => x.OfferIDRef,
                        principalSchema: "LabehDB",
                        principalTable: "OfferTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ItemOrderOfferTab_OrderTab_OrderIDRef",
                        column: x => x.OrderIDRef,
                        principalSchema: "LabehDB",
                        principalTable: "OrderTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LatLongArrivedTab",
                schema: "LabehDB",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    LongTitude = table.Column<string>(type: "nvarchar(MAX)", nullable: false),
                    OrderRef = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LatLongArrivedTab", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LatLongArrivedTab_OrderTab_OrderRef",
                        column: x => x.OrderRef,
                        principalSchema: "LabehDB",
                        principalTable: "OrderTab",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerTab_QuestionID",
                schema: "LabehDB",
                table: "AnswerTab",
                column: "QuestionID");

            migrationBuilder.CreateIndex(
                name: "IX_BranchSubOrgsContractTab_BranchId",
                schema: "LabehDB",
                table: "BranchSubOrgsContractTab",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_BranchSubOrgsContractTab_ContractID",
                schema: "LabehDB",
                table: "BranchSubOrgsContractTab",
                column: "ContractID");

            migrationBuilder.CreateIndex(
                name: "IX_BranchSubOrgsContractTab_OrgsSubID",
                schema: "LabehDB",
                table: "BranchSubOrgsContractTab",
                column: "OrgsSubID");

            migrationBuilder.CreateIndex(
                name: "IX_BranchTab_OrgsSubID",
                schema: "LabehDB",
                table: "BranchTab",
                column: "OrgsSubID");

            migrationBuilder.CreateIndex(
                name: "IX_CommisionTab_ContactID",
                schema: "LabehDB",
                table: "CommisionTab",
                column: "ContactID");

            migrationBuilder.CreateIndex(
                name: "IX_CommisionTab_PaymentWayID",
                schema: "LabehDB",
                table: "CommisionTab",
                column: "PaymentWayID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractCCatTab_ContactCatID",
                schema: "LabehDB",
                table: "ContractCCatTab",
                column: "ContactCatID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractCCatTab_ContractID",
                schema: "LabehDB",
                table: "ContractCCatTab",
                column: "ContractID");

            migrationBuilder.CreateIndex(
                name: "IX_ContractTab_OrgsSubIdRef",
                schema: "LabehDB",
                table: "ContractTab",
                column: "OrgsSubIdRef");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCusCatTab_CustomerCatID",
                schema: "LabehDB",
                table: "CustomerCusCatTab",
                column: "CustomerCatID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerCusCatTab_CustomerID",
                schema: "LabehDB",
                table: "CustomerCusCatTab",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_DriverCompanyTab_DriverCompCatID",
                schema: "LabehDB",
                table: "DriverCompanyTab",
                column: "DriverCompCatID");

            migrationBuilder.CreateIndex(
                name: "IX_DriverCompContractTab_DriverCompID",
                schema: "LabehDB",
                table: "DriverCompContractTab",
                column: "DriverCompID");

            migrationBuilder.CreateIndex(
                name: "IX_DriversContractTab_DriverId",
                schema: "LabehDB",
                table: "DriversContractTab",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverTab_DriverCompanyId",
                schema: "LabehDB",
                table: "DriverTab",
                column: "DriverCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverTab_DriverTypeId",
                schema: "LabehDB",
                table: "DriverTab",
                column: "DriverTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverTrackingOrderTab_DriverTrackingId",
                schema: "LabehDB",
                table: "DriverTrackingOrderTab",
                column: "DriverTrackingId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverTrackingOrderTab_OrderId",
                schema: "LabehDB",
                table: "DriverTrackingOrderTab",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverTrackingTab_DriverID",
                schema: "LabehDB",
                table: "DriverTrackingTab",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_DriverVehicleTab_DriverID",
                schema: "LabehDB",
                table: "DriverVehicleTab",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_DriverVehicleTab_VehicleID",
                schema: "LabehDB",
                table: "DriverVehicleTab",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralWaletTab_StaffId",
                schema: "LabehDB",
                table: "GeneralWaletTab",
                column: "StaffId");

            migrationBuilder.CreateIndex(
                name: "IX_GeneralWaletTab_UserID",
                schema: "LabehDB",
                table: "GeneralWaletTab",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrderOfferTab_ItemIDRef",
                schema: "LabehDB",
                table: "ItemOrderOfferTab",
                column: "ItemIDRef");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrderOfferTab_OfferIDRef",
                schema: "LabehDB",
                table: "ItemOrderOfferTab",
                column: "OfferIDRef");

            migrationBuilder.CreateIndex(
                name: "IX_ItemOrderOfferTab_OrderIDRef",
                schema: "LabehDB",
                table: "ItemOrderOfferTab",
                column: "OrderIDRef");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTab_BranchesIDRef",
                schema: "LabehDB",
                table: "ItemTab",
                column: "BranchesIDRef");

            migrationBuilder.CreateIndex(
                name: "IX_ItemTab_OrgsSubRef",
                schema: "LabehDB",
                table: "ItemTab",
                column: "OrgsSubRef");

            migrationBuilder.CreateIndex(
                name: "IX_LatLongArrivedTab_OrderRef",
                schema: "LabehDB",
                table: "LatLongArrivedTab",
                column: "OrderRef");

            migrationBuilder.CreateIndex(
                name: "IX_MainOrgContactTab_BranchesContact",
                schema: "LabehDB",
                table: "MainOrgContactTab",
                column: "BranchesContact");

            migrationBuilder.CreateIndex(
                name: "IX_MainOrgContactTab_OrgsSubbIDRef",
                schema: "LabehDB",
                table: "MainOrgContactTab",
                column: "OrgsSubbIDRef");

            migrationBuilder.CreateIndex(
                name: "IX_OfferItemTab_ItemIDef",
                schema: "LabehDB",
                table: "OfferItemTab",
                column: "ItemIDef");

            migrationBuilder.CreateIndex(
                name: "IX_OfferItemTab_OfferIDRef",
                schema: "LabehDB",
                table: "OfferItemTab",
                column: "OfferIDRef");

            migrationBuilder.CreateIndex(
                name: "IX_OfferTab_BranchesIDRef",
                schema: "LabehDB",
                table: "OfferTab",
                column: "BranchesIDRef");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTab_BranchID",
                schema: "LabehDB",
                table: "OrderTab",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderTab_CustomerID",
                schema: "LabehDB",
                table: "OrderTab",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_OrgsSubTab_OrganizationRef",
                schema: "LabehDB",
                table: "OrgsSubTab",
                column: "OrganizationRef");

            migrationBuilder.CreateIndex(
                name: "IX_StaffTab_StaffTypeID",
                schema: "LabehDB",
                table: "StaffTab",
                column: "StaffTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_StockTab_IDRef",
                schema: "LabehDB",
                table: "StockTab",
                column: "IDRef");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryOrgsSubTab_OrgSubIDRef",
                schema: "LabehDB",
                table: "SubCategoryOrgsSubTab",
                column: "OrgSubIDRef");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryOrgsSubTab_SubCategoryID",
                schema: "LabehDB",
                table: "SubCategoryOrgsSubTab",
                column: "SubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryTab_OrganizationRef",
                schema: "LabehDB",
                table: "SubCategoryTab",
                column: "OrganizationRef");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "BranchSubOrgsContractTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "CommisionTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "ContractCCatTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "CustomerCusCatTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "DriverCompContractTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "DriversContractTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "DriverTrackingOrderTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "DriverVehicleTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "EvaluateDriverTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "GeneralWaletTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "ItemOrderOfferTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "LatLongArrivedTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "MainOrgContactTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "OfferItemTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "StockTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "SubCategoryOrgsSubTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "EvaluateAnswerTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "PaymentTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "ContractCategoryTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "ContractTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "CustomerCategoryTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "DriverTrackingTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "VehicleTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "StaffTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "OrderTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "OfferTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "ItemTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "SubCategoryTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "DriverTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "StaffTypeTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "CustomerTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "BranchTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "DriverCompanyTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "OrgsSubTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "DriversCompaniesCatTab",
                schema: "LabehDB");

            migrationBuilder.DropTable(
                name: "OrganizationTab",
                schema: "LabehDB");
        }
    }
}
