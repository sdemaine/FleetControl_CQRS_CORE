using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FleetControl.WebUI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
        //    migrationBuilder.CreateTable(
        //        name: "AspNetRoles",
        //        columns: table => new
        //        {
        //            Id = table.Column<string>(nullable: false),
        //            Name = table.Column<string>(maxLength: 256, nullable: true),
        //            NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
        //            ConcurrencyStamp = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetRoles", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AspNetUsers",
        //        columns: table => new
        //        {
        //            Id = table.Column<string>(nullable: false),
        //            UserName = table.Column<string>(maxLength: 256, nullable: true),
        //            NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
        //            Email = table.Column<string>(maxLength: 256, nullable: true),
        //            NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
        //            EmailConfirmed = table.Column<bool>(nullable: false),
        //            PasswordHash = table.Column<string>(nullable: true),
        //            SecurityStamp = table.Column<string>(nullable: true),
        //            ConcurrencyStamp = table.Column<string>(nullable: true),
        //            PhoneNumber = table.Column<string>(nullable: true),
        //            PhoneNumberConfirmed = table.Column<bool>(nullable: false),
        //            TwoFactorEnabled = table.Column<bool>(nullable: false),
        //            LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
        //            LockoutEnabled = table.Column<bool>(nullable: false),
        //            AccessFailedCount = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetUsers", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AuditDataType",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Name = table.Column<string>(maxLength: 30, nullable: false),
        //            KeyDataType = table.Column<string>(maxLength: 100, nullable: true),
        //            ValueDataType = table.Column<string>(maxLength: 100, nullable: false),
        //            KeyCaption = table.Column<string>(maxLength: 100, nullable: true),
        //            ValueCaption = table.Column<string>(maxLength: 100, nullable: false),
        //            KeyTable = table.Column<string>(maxLength: 100, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AuditDataType", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AuditEvent",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Name = table.Column<string>(maxLength: 30, nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AuditEvent", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "BusinessAssociate",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            BAID = table.Column<int>(nullable: false),
        //            Name = table.Column<string>(nullable: true),
        //            AbbreviatedName = table.Column<string>(nullable: true),
        //            IsFleetControlBAID = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_BusinessAssociate", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "BusinessHours",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            ClosedSunday = table.Column<bool>(nullable: false),
        //            ClosedMonday = table.Column<bool>(nullable: false),
        //            ClosedTuesday = table.Column<bool>(nullable: false),
        //            ClosedWednesday = table.Column<bool>(nullable: false),
        //            ClosedThursday = table.Column<bool>(nullable: false),
        //            ClosedFriday = table.Column<bool>(nullable: false),
        //            ClosedSaturday = table.Column<bool>(nullable: false),
        //            SundayOpen = table.Column<string>(nullable: true),
        //            SundayClose = table.Column<string>(nullable: true),
        //            MondayOpen = table.Column<string>(nullable: true),
        //            MondayClose = table.Column<string>(nullable: true),
        //            TuesdayOpen = table.Column<string>(nullable: true),
        //            TuesdayClose = table.Column<string>(nullable: true),
        //            WednesdayOpen = table.Column<string>(nullable: true),
        //            WednesdayClose = table.Column<string>(nullable: true),
        //            ThursdayOpen = table.Column<string>(nullable: true),
        //            ThursdayClose = table.Column<string>(nullable: true),
        //            FridayClose = table.Column<string>(nullable: true),
        //            FridayOpen = table.Column<string>(nullable: true),
        //            SaturdayOpen = table.Column<string>(nullable: true),
        //            SaturdayClose = table.Column<string>(nullable: true),
        //            Sunday24Hours = table.Column<bool>(nullable: false),
        //            Monday24Hours = table.Column<bool>(nullable: false),
        //            Tuesday24Hours = table.Column<bool>(nullable: false),
        //            Wednesday24Hours = table.Column<bool>(nullable: false),
        //            Thursday24Hours = table.Column<bool>(nullable: false),
        //            Friday24Hours = table.Column<bool>(nullable: false),
        //            Saturday24Hours = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_BusinessHours", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CardAddress",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            NickName = table.Column<string>(maxLength: 50, nullable: true),
        //            ExternalAddressId = table.Column<int>(nullable: false),
        //            CustomerId = table.Column<int>(nullable: false),
        //            AddressLine1 = table.Column<string>(maxLength: 75, nullable: true),
        //            AddressLine2 = table.Column<string>(maxLength: 75, nullable: true),
        //            City = table.Column<string>(maxLength: 25, nullable: true),
        //            State = table.Column<string>(maxLength: 2, nullable: true),
        //            ZipCode = table.Column<string>(maxLength: 9, nullable: true),
        //            PhoneNumber = table.Column<string>(maxLength: 10, nullable: true),
        //            Status = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CardAddress", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CardCategory",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Name = table.Column<string>(nullable: true),
        //            Description = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CardCategory", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CardClass",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Class = table.Column<string>(nullable: true),
        //            Description = table.Column<string>(maxLength: 20, nullable: true),
        //            MaxFuel = table.Column<double>(nullable: false),
        //            MinRange = table.Column<double>(nullable: false),
        //            MaxRange = table.Column<double>(nullable: false),
        //            ProductId = table.Column<int>(nullable: true),
        //            ProductsNotAllowed = table.Column<string>(nullable: true),
        //            LastUpdated = table.Column<DateTime>(nullable: true),
        //            AccountNumber = table.Column<int>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CardClass", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CardNumberRegistry",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            CardNumber = table.Column<string>(nullable: true),
        //            CardType = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CardNumberRegistry", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CardPinRegistry",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            PinNumber = table.Column<int>(nullable: false),
        //            PinType = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CardPinRegistry", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ContractTaxLocation",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CurrentTaxLocationId = table.Column<int>(nullable: false),
        //            ContractTaxLocaleId = table.Column<int>(nullable: false),
        //            PricingLocationGroupId = table.Column<int>(nullable: false),
        //            FromDate = table.Column<DateTime>(nullable: false),
        //            ToDate = table.Column<DateTime>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ContractTaxLocation", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CustClass",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            CustClassId = table.Column<string>(maxLength: 10, nullable: true),
        //            CustClassDesc = table.Column<string>(maxLength: 30, nullable: true),
        //            MaxFuel = table.Column<decimal>(nullable: false),
        //            MinRange = table.Column<decimal>(nullable: false),
        //            MaxRange = table.Column<decimal>(nullable: false),
        //            AllowedProducts = table.Column<string>(nullable: true),
        //            ProductsNotAllowed = table.Column<string>(nullable: true),
        //            LastUpdated = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: true),
        //            ExternalCustomerId = table.Column<int>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CustClass", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Customer",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            BAID = table.Column<int>(nullable: false),
        //            LiftingNumber = table.Column<string>(maxLength: 25, nullable: true),
        //            VoyagerAccountId = table.Column<int>(nullable: true),
        //            CustName = table.Column<string>(maxLength: 100, nullable: true),
        //            EmbossedCustomerName = table.Column<string>(maxLength: 25, nullable: true),
        //            Address1 = table.Column<string>(maxLength: 35, nullable: false),
        //            Address2 = table.Column<string>(maxLength: 35, nullable: true),
        //            City = table.Column<string>(maxLength: 15, nullable: true),
        //            State = table.Column<string>(maxLength: 2, nullable: true),
        //            ZipCode = table.Column<string>(maxLength: 9, nullable: false),
        //            Telephone = table.Column<string>(maxLength: 10, nullable: false),
        //            Contact = table.Column<string>(maxLength: 25, nullable: true),
        //            CredLimit = table.Column<int>(nullable: true),
        //            LockCode = table.Column<string>(maxLength: 1, nullable: true),
        //            LockDate = table.Column<DateTime>(nullable: true),
        //            SalesPerson = table.Column<string>(maxLength: 25, nullable: true),
        //            BillingCode = table.Column<string>(maxLength: 1, nullable: true),
        //            WetHosing = table.Column<string>(maxLength: 1, nullable: true),
        //            NYCAccount = table.Column<string>(maxLength: 1, nullable: true),
        //            LastActivityDate = table.Column<DateTime>(nullable: true),
        //            SpecialCustomerCode = table.Column<string>(maxLength: 1, nullable: true),
        //            FMRGroup = table.Column<string>(maxLength: 3, nullable: true),
        //            InvoiceSeparation = table.Column<string>(maxLength: 1, nullable: true),
        //            PinGeneration = table.Column<string>(maxLength: 1, nullable: true),
        //            ProductUse = table.Column<int>(nullable: false),
        //            TransactionDollarLimit = table.Column<int>(nullable: true),
        //            TransactionDollarLimitMode = table.Column<int>(nullable: false),
        //            DailyDollarLimit = table.Column<int>(nullable: true),
        //            DailyDollarLimitMode = table.Column<int>(nullable: false),
        //            WeeklyDollarLimit = table.Column<int>(nullable: true),
        //            WeeklyDollarLimitMode = table.Column<int>(nullable: false),
        //            MonthlyDollarLimit = table.Column<int>(nullable: true),
        //            MonthlyDollarLimitMode = table.Column<int>(nullable: false),
        //            DailyTransactionLimit = table.Column<int>(nullable: true),
        //            DailyTransactionLimitMode = table.Column<int>(nullable: false),
        //            WeeklyTransactionLimit = table.Column<int>(nullable: true),
        //            WeeklyTransactionLimitMode = table.Column<int>(nullable: false),
        //            MonthlyTransactionLimit = table.Column<int>(nullable: true),
        //            MonthlyTransactionLimitMode = table.Column<int>(nullable: false),
        //            PurchaseDay = table.Column<int>(nullable: false),
        //            PurchaseDayMode = table.Column<int>(nullable: false),
        //            PurchaseFromTimeBand1 = table.Column<DateTime>(nullable: true),
        //            PurchaseToTimeBand1 = table.Column<DateTime>(nullable: true),
        //            PurchaseDayBand1Mode = table.Column<int>(nullable: false),
        //            PurchaseFromTimeBand2 = table.Column<DateTime>(nullable: true),
        //            PurchaseToTimeBand2 = table.Column<DateTime>(nullable: true),
        //            PurchaseDayBand2Mode = table.Column<int>(nullable: false),
        //            OdometerValidation = table.Column<int>(nullable: false),
        //            OdometerType = table.Column<int>(nullable: false),
        //            OrgLevelsUsed = table.Column<int>(nullable: false),
        //            DepartmentRequired = table.Column<int>(nullable: false),
        //            CompanySelectsPin = table.Column<int>(nullable: false),
        //            CompanySelectsCardNumber = table.Column<int>(nullable: false),
        //            CompanySelectsVehicleNumber = table.Column<int>(nullable: false),
        //            CompanySelectsDriverNumber = table.Column<int>(nullable: false),
        //            CardsTiedToEntity = table.Column<int>(nullable: false),
        //            CardPromptPattern = table.Column<int>(nullable: false),
        //            EmbossingOnCard = table.Column<int>(nullable: false),
        //            EmbossingElement1 = table.Column<int>(nullable: false),
        //            EmbossingElement2 = table.Column<int>(nullable: false),
        //            EmbossingElement3 = table.Column<int>(nullable: false),
        //            InternalCustomer = table.Column<int>(nullable: false),
        //            Status = table.Column<int>(nullable: false),
        //            RetailCustomer = table.Column<int>(nullable: false),
        //            PORequired = table.Column<int>(nullable: false),
        //            BillingFrequency = table.Column<string>(maxLength: 1, nullable: true),
        //            RestrictionCode = table.Column<int>(nullable: false),
        //            CustNo = table.Column<string>(nullable: true),
        //            ExternalDatabaseFilePath = table.Column<string>(nullable: true),
        //            IsConsignment = table.Column<bool>(nullable: false),
        //            MinDriverNumber = table.Column<int>(nullable: false),
        //            MaxDriverNumber = table.Column<int>(nullable: false),
        //            ExternalFMSNumber = table.Column<string>(maxLength: 25, nullable: true),
        //            IsFuelMaster = table.Column<bool>(nullable: false),
        //            IsWinC6 = table.Column<bool>(nullable: false),
        //            IsVoyager = table.Column<bool>(nullable: false),
        //            DepartmentRequiredForDriver = table.Column<int>(nullable: false),
        //            DepartmentRequiredForCard = table.Column<int>(nullable: false),
        //            DepartmentRequiredForVehicle = table.Column<int>(nullable: false),
        //            CardAddressId = table.Column<int>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Customer", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CustomerAssignment",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            UserProfileId = table.Column<int>(nullable: false),
        //            BAID = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CustomerAssignment", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CustomerGroup",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Name = table.Column<string>(nullable: true),
        //            Text = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CustomerGroup", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CustomerPricingLocationGroup",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            PricingLocationGroupId = table.Column<int>(nullable: false),
        //            PriceServiceId = table.Column<int>(nullable: true),
        //            FromDate = table.Column<DateTime>(nullable: false),
        //            ToDate = table.Column<DateTime>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CustomerPricingLocationGroup", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CustomerPricingLocationWorkEntry",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            LocationId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CustomerPricingLocationWorkEntry", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DAMCardConfirmation",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            LockCode = table.Column<string>(maxLength: 1, nullable: true),
        //            LockDate = table.Column<DateTime>(nullable: true),
        //            ExternalCardId = table.Column<int>(nullable: false),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            CardNo = table.Column<int>(nullable: true),
        //            TheirCardNumber = table.Column<string>(nullable: true),
        //            EntityType = table.Column<int>(nullable: false),
        //            Date1stPur = table.Column<DateTime>(nullable: true),
        //            MaxGalTrn = table.Column<decimal>(nullable: true),
        //            MaxGalDay = table.Column<decimal>(nullable: true),
        //            MaxGalCycl = table.Column<decimal>(nullable: true),
        //            MaxMotorOil = table.Column<decimal>(nullable: true),
        //            LastActivityDate = table.Column<DateTime>(nullable: true),
        //            LastGallons = table.Column<decimal>(nullable: true),
        //            BAID = table.Column<int>(nullable: false),
        //            CardLevel2Id = table.Column<int>(nullable: false),
        //            CardLevel3Id = table.Column<int>(nullable: true),
        //            CardLevel4Id = table.Column<int>(nullable: true),
        //            CardLevel5Id = table.Column<int>(nullable: true),
        //            CardLevel6Id = table.Column<int>(nullable: true),
        //            CardLevel7Id = table.Column<int>(nullable: true),
        //            CardUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            CardUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            CardUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            ProductUse = table.Column<int>(nullable: false),
        //            DailyDollarLimit = table.Column<int>(nullable: true),
        //            DailyDollarLimitMode = table.Column<int>(nullable: true),
        //            WeeklyDollarLimit = table.Column<int>(nullable: true),
        //            WeeklyDollarLimitMode = table.Column<int>(nullable: true),
        //            MonthlyDollarLimit = table.Column<int>(nullable: true),
        //            MonthlyDollarLimitMode = table.Column<int>(nullable: true),
        //            DailyTransactionLimit = table.Column<int>(nullable: true),
        //            DailyTransactionLimitMode = table.Column<int>(nullable: true),
        //            WeeklyTransactionLimit = table.Column<int>(nullable: true),
        //            WeeklyTransactionLimitMode = table.Column<int>(nullable: true),
        //            MonthlyTransactionLimit = table.Column<int>(nullable: true),
        //            MonthlyTransactionLimitMode = table.Column<int>(nullable: true),
        //            PurchaseDay = table.Column<int>(nullable: true),
        //            PurchaseDayMode = table.Column<int>(nullable: true),
        //            PurchaseFromTimeBand1 = table.Column<DateTime>(nullable: true),
        //            PurchaseToTimeBand1 = table.Column<DateTime>(nullable: true),
        //            PurchaseDayBand1Mode = table.Column<int>(nullable: true),
        //            PurchaseFromTimeBand2 = table.Column<DateTime>(nullable: true),
        //            PurchaseToTimeBand2 = table.Column<DateTime>(nullable: true),
        //            PurchaseDayBand2Mode = table.Column<int>(nullable: true),
        //            OdometerValidation = table.Column<int>(nullable: false),
        //            OdometerValidationMode = table.Column<int>(nullable: false),
        //            OdometerLimit = table.Column<int>(nullable: false),
        //            Status = table.Column<int>(nullable: false),
        //            LastUseDate = table.Column<DateTime>(nullable: true),
        //            UseCount = table.Column<int>(nullable: true),
        //            QTY = table.Column<decimal>(nullable: true),
        //            LastOdometer = table.Column<DateTime>(nullable: true),
        //            DriverId = table.Column<int>(nullable: true),
        //            VehicleId = table.Column<int>(nullable: true),
        //            CardExpirationDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            CardStatusIndicator = table.Column<int>(nullable: false),
        //            ErrorCode1 = table.Column<string>(maxLength: 5, nullable: true),
        //            ErrorCode2 = table.Column<string>(maxLength: 5, nullable: true),
        //            ErrorCode3 = table.Column<string>(maxLength: 5, nullable: true),
        //            ErrorCode4 = table.Column<string>(maxLength: 5, nullable: true),
        //            ErrorCode5 = table.Column<string>(maxLength: 5, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DAMCardConfirmation", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DAMCustomer",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            EntityType = table.Column<int>(nullable: false),
        //            EntityId = table.Column<int>(nullable: false),
        //            DAMAction = table.Column<int>(nullable: false),
        //            DAMStatus = table.Column<int>(nullable: false),
        //            CustomerId = table.Column<int>(nullable: false),
        //            ControlNumber = table.Column<int>(nullable: false),
        //            SequenceNumber = table.Column<int>(nullable: false),
        //            ErrorCode1 = table.Column<string>(nullable: true),
        //            ErrorCode2 = table.Column<string>(nullable: true),
        //            ErrorCode3 = table.Column<string>(nullable: true),
        //            ErrorCode4 = table.Column<string>(nullable: true),
        //            ErrorCode1Description = table.Column<string>(nullable: true),
        //            ErrorCode2Description = table.Column<string>(nullable: true),
        //            ErrorCode3Description = table.Column<string>(nullable: true),
        //            ErrorCode4Description = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DAMCustomer", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DAMUploadDetail",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            ControlNumber = table.Column<int>(nullable: false),
        //            UploadDate = table.Column<DateTime>(nullable: false),
        //            TotalCardsCreated = table.Column<int>(nullable: false),
        //            TotalVehiclesCreated = table.Column<int>(nullable: false),
        //            TotalDriversCreated = table.Column<int>(nullable: false),
        //            TotalCardsUpdated = table.Column<int>(nullable: false),
        //            TotalVehiclesUpdated = table.Column<int>(nullable: false),
        //            TotalDriversUpdated = table.Column<int>(nullable: false),
        //            TotalCards = table.Column<int>(nullable: false),
        //            TotalVehicles = table.Column<int>(nullable: false),
        //            TotalDrivers = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DAMUploadDetail", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DriverAssignment",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            AccountNumber = table.Column<string>(maxLength: 50, nullable: true),
        //            DriverId = table.Column<string>(maxLength: 20, nullable: true),
        //            LastName = table.Column<string>(maxLength: 50, nullable: true),
        //            FirstName = table.Column<string>(maxLength: 50, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DriverAssignment", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DriverImport",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            ExternalDriverId = table.Column<string>(nullable: true),
        //            NameLast = table.Column<string>(maxLength: 20, nullable: true),
        //            NameFirst = table.Column<string>(maxLength: 20, nullable: true),
        //            MiddleInitial = table.Column<string>(maxLength: 1, nullable: true),
        //            Pin = table.Column<int>(nullable: false),
        //            LastActivityDate = table.Column<DateTime>(nullable: true),
        //            LockCode = table.Column<string>(maxLength: 1, nullable: true),
        //            LockDate = table.Column<DateTime>(nullable: true),
        //            TheirEmployeeNumber = table.Column<string>(maxLength: 10, nullable: true),
        //            DriverLevel2Id = table.Column<int>(nullable: false),
        //            DriverLevel3Id = table.Column<int>(nullable: true),
        //            DriverLevel4Id = table.Column<int>(nullable: true),
        //            DriverLevel5Id = table.Column<int>(nullable: true),
        //            DriverLevel6Id = table.Column<int>(nullable: true),
        //            DriverLevel7Id = table.Column<int>(nullable: true),
        //            Class = table.Column<string>(maxLength: 10, nullable: true),
        //            Dept = table.Column<string>(nullable: true),
        //            Sequence = table.Column<int>(nullable: false),
        //            MENU = table.Column<int>(nullable: false),
        //            Status = table.Column<int>(nullable: false),
        //            UseCount = table.Column<int>(nullable: false),
        //            Quantity = table.Column<decimal>(nullable: false),
        //            MinVehc = table.Column<int>(nullable: true),
        //            MaxVehc = table.Column<int>(nullable: true),
        //            DriverUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            DriverUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            DriverUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            Synchronized = table.Column<int>(nullable: false),
        //            SyncStatus = table.Column<int>(nullable: false),
        //            OriginCreateDate = table.Column<DateTime>(nullable: true),
        //            OriginModifyDate = table.Column<DateTime>(nullable: true),
        //            CopyRecord = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DriverImport", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DriverPinRegistry",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            PinNumber = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DriverPinRegistry", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DuplicateTransactions",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            AccountNumber = table.Column<int>(nullable: true),
        //            AccountLevel1Id = table.Column<int>(nullable: true),
        //            CustNo = table.Column<string>(maxLength: 5, nullable: true),
        //            LocationId = table.Column<int>(nullable: false),
        //            ParticipantCode = table.Column<int>(nullable: false),
        //            MerchantAccountId = table.Column<string>(nullable: true),
        //            TranDate = table.Column<DateTime>(nullable: false),
        //            TranTime = table.Column<string>(maxLength: 4, nullable: true),
        //            TranType4 = table.Column<string>(maxLength: 4, nullable: true),
        //            PostDate = table.Column<DateTime>(nullable: true),
        //            CardId = table.Column<int>(nullable: true),
        //            ExternalCardId = table.Column<string>(nullable: true),
        //            VehicleId = table.Column<int>(nullable: true),
        //            ExternalVehicleId = table.Column<string>(nullable: true),
        //            DriverId = table.Column<int>(nullable: true),
        //            ExternalDriverId = table.Column<string>(nullable: true),
        //            Odometer = table.Column<int>(nullable: true),
        //            Pump = table.Column<string>(maxLength: 2, nullable: true),
        //            Prod = table.Column<string>(maxLength: 4, nullable: true),
        //            ProdId = table.Column<int>(nullable: false),
        //            Price = table.Column<double>(nullable: true),
        //            AmtGal = table.Column<double>(nullable: false),
        //            PumpPrice = table.Column<double>(nullable: false),
        //            CostPerMile = table.Column<double>(nullable: true),
        //            MilesPerGallon = table.Column<double>(nullable: true),
        //            FedEx = table.Column<double>(nullable: true),
        //            StaEx = table.Column<double>(nullable: true),
        //            StaSales = table.Column<double>(nullable: true),
        //            OtherTax = table.Column<double>(nullable: true),
        //            TaxFlag = table.Column<string>(maxLength: 1, nullable: true),
        //            CaptureMethod = table.Column<string>(nullable: true),
        //            ServiceTypeIndicator = table.Column<string>(nullable: true),
        //            MicrofileRefNumber = table.Column<string>(maxLength: 15, nullable: true),
        //            ExceptionFlags = table.Column<string>(maxLength: 3, nullable: true),
        //            CustomerSalesAmount = table.Column<double>(nullable: true),
        //            UnpaidTaxes = table.Column<double>(nullable: true),
        //            StationReimbursementAmount = table.Column<double>(nullable: true),
        //            TaxArea = table.Column<string>(maxLength: 2, nullable: true),
        //            StationReimbursementActual = table.Column<double>(nullable: true),
        //            MerchantInvoiceNumber = table.Column<string>(maxLength: 8, nullable: true),
        //            Source = table.Column<string>(maxLength: 2, nullable: true),
        //            SRAExtrnlDcmntNmbr = table.Column<string>(maxLength: 80, nullable: true),
        //            FederalExciseTaxAmount = table.Column<decimal>(nullable: true),
        //            StateExciseTaxAmount = table.Column<decimal>(nullable: true),
        //            PBTAmount = table.Column<decimal>(nullable: true),
        //            SalesTaxPerGallonAmount = table.Column<decimal>(nullable: true),
        //            SalesTaxPercentAmount = table.Column<decimal>(nullable: true),
        //            PBTRate = table.Column<double>(nullable: true),
        //            SalesTaxPerGallonRate = table.Column<double>(nullable: true),
        //            SalesTaxPercentRate = table.Column<double>(nullable: true),
        //            ProductBasePrice = table.Column<double>(nullable: true),
        //            SolarcProductPrice = table.Column<double>(nullable: true),
        //            FullPrice = table.Column<double>(nullable: true),
        //            TaxLocaleId = table.Column<int>(nullable: false),
        //            VoyagerPostDate = table.Column<DateTime>(nullable: false),
        //            PerUnitCOGS = table.Column<double>(nullable: true),
        //            HourMeter = table.Column<int>(nullable: true),
        //            DriverLevel2Id = table.Column<int>(nullable: false),
        //            DriverLevel3Id = table.Column<int>(nullable: true),
        //            DriverLevel4Id = table.Column<int>(nullable: true),
        //            DriverLevel5Id = table.Column<int>(nullable: true),
        //            DriverLevel6Id = table.Column<int>(nullable: true),
        //            DriverLevel7Id = table.Column<int>(nullable: true),
        //            VehicleLevel2Id = table.Column<int>(nullable: false),
        //            VehicleLevel3Id = table.Column<int>(nullable: true),
        //            VehicleLevel4Id = table.Column<int>(nullable: true),
        //            VehicleLevel5Id = table.Column<int>(nullable: true),
        //            VehicleLevel6Id = table.Column<int>(nullable: true),
        //            VehicleLevel7Id = table.Column<int>(nullable: true),
        //            CardLevel2Id = table.Column<int>(nullable: false),
        //            CardLevel3Id = table.Column<int>(nullable: true),
        //            CardLevel4Id = table.Column<int>(nullable: true),
        //            CardLevel5Id = table.Column<int>(nullable: true),
        //            CardLevel6Id = table.Column<int>(nullable: true),
        //            CardLevel7Id = table.Column<int>(nullable: true),
        //            DriverUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            DriverUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            DriverUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            VehicleUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            VehicleUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            CardUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            CardUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            PricingLocationGroupId = table.Column<int>(nullable: true),
        //            CustomerPricingLocationGroupId = table.Column<int>(nullable: true),
        //            PriceServiceId = table.Column<int>(nullable: true),
        //            BillToOrgLevelDefinitionId = table.Column<int>(nullable: false),
        //            ShipToOrgLevelDefinitionId = table.Column<int>(nullable: false),
        //            IsRetail = table.Column<int>(nullable: false),
        //            VoyagerCardLevel2Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel3Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel4Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel5Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel6Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel7Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel2Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel3Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel4Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel5Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel6Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel7Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel2Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel3Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel4Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel5Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel6Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel7Id = table.Column<int>(nullable: false),
        //            Filename = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DuplicateTransactions", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ExternalDatabase",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            DatabaseName = table.Column<string>(maxLength: 50, nullable: true),
        //            Path = table.Column<string>(maxLength: 1000, nullable: true),
        //            IsActive = table.Column<bool>(nullable: false),
        //            ProcessorPath = table.Column<string>(nullable: true),
        //            ProcessorName = table.Column<string>(nullable: true),
        //            SourceSystem = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ExternalDatabase", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "FleetRec",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            BillingWeek = table.Column<string>(maxLength: 10, nullable: true),
        //            IssueLicensee = table.Column<string>(maxLength: 10, nullable: true),
        //            IssueLicenseeName = table.Column<string>(maxLength: 50, nullable: true),
        //            ReceiveLicensee = table.Column<string>(maxLength: 10, nullable: true),
        //            ReceiveLicenseeName = table.Column<string>(maxLength: 50, nullable: true),
        //            Division = table.Column<string>(maxLength: 10, nullable: true),
        //            DivisionName = table.Column<string>(maxLength: 50, nullable: true),
        //            Merchant = table.Column<string>(maxLength: 10, nullable: true),
        //            MerchantName = table.Column<string>(maxLength: 50, nullable: true),
        //            DeviceNo = table.Column<string>(maxLength: 10, nullable: true),
        //            DeviceName = table.Column<string>(maxLength: 50, nullable: true),
        //            Customer = table.Column<string>(maxLength: 10, nullable: true),
        //            CustomerName = table.Column<string>(maxLength: 50, nullable: true),
        //            TranDate = table.Column<DateTime>(nullable: false),
        //            TranNo = table.Column<string>(maxLength: 50, nullable: true),
        //            AuthorizationNumber = table.Column<string>(maxLength: 50, nullable: true),
        //            Product = table.Column<string>(maxLength: 50, nullable: true),
        //            ProductDescription = table.Column<string>(maxLength: 50, nullable: true),
        //            ProductType = table.Column<string>(maxLength: 50, nullable: true),
        //            QTY = table.Column<decimal>(nullable: false),
        //            CustomerPrice = table.Column<decimal>(nullable: false),
        //            MerchantPrice = table.Column<double>(nullable: false),
        //            NetworkPrice = table.Column<decimal>(nullable: false),
        //            RetailPrice = table.Column<decimal>(nullable: false),
        //            Basis = table.Column<double>(nullable: false),
        //            CardNumber = table.Column<string>(maxLength: 20, nullable: true),
        //            UserId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_FleetRec", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "FuelManagementGroup",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            FMRGroup = table.Column<string>(maxLength: 3, nullable: true),
        //            Description = table.Column<string>(maxLength: 30, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_FuelManagementGroup", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "FuelMasterTransactionLog",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            TranNum = table.Column<int>(nullable: false),
        //            CustId = table.Column<string>(nullable: true),
        //            SiteId = table.Column<string>(nullable: true),
        //            VehicleId = table.Column<string>(nullable: true),
        //            UserId = table.Column<string>(nullable: true),
        //            Hose = table.Column<int>(nullable: false),
        //            TranTime = table.Column<DateTime>(nullable: false),
        //            Quantity = table.Column<double>(nullable: false),
        //            Product = table.Column<int>(nullable: false),
        //            InterfaceDatasourceId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_FuelMasterTransactionLog", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "InterfaceDatasource",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Name = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_InterfaceDatasource", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "List",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            List = table.Column<string>(maxLength: 5, nullable: true),
        //            Description = table.Column<string>(maxLength: 30, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_List", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Location",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            DeviceNo = table.Column<string>(maxLength: 13, nullable: true),
        //            Name = table.Column<string>(maxLength: 25, nullable: true),
        //            Fuels = table.Column<string>(maxLength: 50, nullable: true),
        //            Address = table.Column<string>(maxLength: 25, nullable: true),
        //            City = table.Column<string>(maxLength: 17, nullable: true),
        //            State = table.Column<string>(maxLength: 2, nullable: true),
        //            County = table.Column<string>(maxLength: 50, nullable: true),
        //            Zip = table.Column<string>(maxLength: 5, nullable: true),
        //            Zip4 = table.Column<string>(maxLength: 4, nullable: true),
        //            Phone = table.Column<string>(maxLength: 12, nullable: true),
        //            Hour1 = table.Column<string>(maxLength: 9, nullable: true),
        //            Hour2 = table.Column<string>(maxLength: 9, nullable: true),
        //            Truck = table.Column<string>(maxLength: 1, nullable: true),
        //            Contact = table.Column<string>(maxLength: 25, nullable: true),
        //            Direc1 = table.Column<string>(maxLength: 40, nullable: true),
        //            Direc2 = table.Column<string>(maxLength: 40, nullable: true),
        //            Private = table.Column<string>(maxLength: 1, nullable: true),
        //            ParticipantCD = table.Column<int>(nullable: false),
        //            Closed = table.Column<string>(maxLength: 1, nullable: true),
        //            SiteType = table.Column<int>(nullable: false),
        //            SourceSystem = table.Column<int>(nullable: false),
        //            ExternalSiteId = table.Column<int>(nullable: true),
        //            ViewOnTaxListing = table.Column<string>(maxLength: 1, nullable: true),
        //            TaxArea = table.Column<string>(maxLength: 2, nullable: true),
        //            NYCContractSite = table.Column<string>(maxLength: 1, nullable: true),
        //            ExceptionReportAltPhone = table.Column<string>(maxLength: 10, nullable: true),
        //            SiteName = table.Column<string>(maxLength: 25, nullable: true),
        //            ConsignmentEffectiveDate = table.Column<string>(maxLength: 8, nullable: true),
        //            BrandedStation = table.Column<string>(maxLength: 15, nullable: true),
        //            EOMTaxExempt = table.Column<string>(maxLength: 1, nullable: true),
        //            CostPlusPubCode = table.Column<string>(maxLength: 3, nullable: true),
        //            MailName = table.Column<string>(maxLength: 40, nullable: true),
        //            MailAddress = table.Column<string>(maxLength: 40, nullable: true),
        //            MailCity = table.Column<string>(maxLength: 20, nullable: true),
        //            MailState = table.Column<string>(maxLength: 2, nullable: true),
        //            MailZip = table.Column<string>(maxLength: 10, nullable: true),
        //            MailAttn = table.Column<string>(maxLength: 20, nullable: true),
        //            BillingCycle = table.Column<string>(maxLength: 1, nullable: true),
        //            Off_OnSiteType = table.Column<string>(maxLength: 1, nullable: true),
        //            IGASCAShipTo = table.Column<string>(maxLength: 2, nullable: true),
        //            JDELocation = table.Column<string>(maxLength: 4, nullable: true),
        //            _01Minus = table.Column<double>(name: "01Minus", nullable: false),
        //            _02Minus = table.Column<double>(name: "02Minus", nullable: false),
        //            _03Minus = table.Column<double>(name: "03Minus", nullable: false),
        //            _31Minus = table.Column<double>(name: "31Minus", nullable: false),
        //            RemitPercent = table.Column<double>(nullable: false),
        //            IGASCA = table.Column<string>(maxLength: 6, nullable: true),
        //            TaxLocaleId = table.Column<int>(nullable: true),
        //            Notes = table.Column<string>(nullable: true),
        //            NeedsReview = table.Column<string>(nullable: true),
        //            HasRelatedTransactions = table.Column<bool>(nullable: false),
        //            Active = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Location", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "MasterGroups",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            MasterGroupCode = table.Column<string>(maxLength: 3, nullable: true),
        //            MasterGroupDesc = table.Column<string>(maxLength: 30, nullable: true),
        //            MasterGroupSumCode = table.Column<string>(maxLength: 3, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_MasterGroups", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "NBCSProducts",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            ProductNumber = table.Column<double>(nullable: false),
        //            ProductDescription = table.Column<string>(maxLength: 16, nullable: true),
        //            Units = table.Column<string>(maxLength: 10, nullable: true),
        //            Fuel = table.Column<bool>(nullable: false),
        //            FleetCorProduct = table.Column<string>(maxLength: 10, nullable: true),
        //            PrdctId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_NBCSProducts", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "NumberRegistry",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            Number = table.Column<string>(nullable: true),
        //            NumberType = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_NumberRegistry", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "NYCHALabels",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerNumber = table.Column<string>(maxLength: 5, nullable: true),
        //            GroupNumber = table.Column<string>(maxLength: 5, nullable: true),
        //            AttnTo = table.Column<string>(maxLength: 30, nullable: true),
        //            Address = table.Column<string>(maxLength: 30, nullable: true),
        //            City = table.Column<string>(maxLength: 24, nullable: true),
        //            State = table.Column<string>(maxLength: 2, nullable: true),
        //            ZipCode = table.Column<string>(maxLength: 10, nullable: true),
        //            Description = table.Column<string>(maxLength: 40, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_NYCHALabels", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "OrgLevelDefinition",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Name = table.Column<string>(nullable: true),
        //            DisplayName = table.Column<string>(maxLength: 25, nullable: true),
        //            BillToLocation = table.Column<int>(nullable: true),
        //            ShipToLocation = table.Column<int>(nullable: true),
        //            ParentId = table.Column<int>(nullable: true),
        //            OrgId = table.Column<int>(nullable: true),
        //            LevelDepth = table.Column<int>(nullable: false),
        //            CustomerId = table.Column<int>(nullable: false),
        //            CustomerDepartmentNumber = table.Column<string>(nullable: true),
        //            Active = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_OrgLevelDefinition", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "OrgLevelName",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Level3Name = table.Column<string>(nullable: true),
        //            Level4Name = table.Column<string>(nullable: true),
        //            Level5Name = table.Column<string>(nullable: true),
        //            Level6Name = table.Column<string>(nullable: true),
        //            Level7Name = table.Column<string>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_OrgLevelName", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ParticipantCode",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Code = table.Column<string>(maxLength: 5, nullable: true),
        //            BrandName = table.Column<string>(maxLength: 50, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ParticipantCode", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "PricingLocationGroup",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            PricingLocationGroupCode = table.Column<int>(nullable: true),
        //            PricingLocationGroupName = table.Column<string>(maxLength: 50, nullable: true),
        //            IsRetail = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_PricingLocationGroup", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Product",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            ProdCode = table.Column<string>(nullable: true),
        //            ExternalProductId = table.Column<int>(nullable: true),
        //            ProdDesc = table.Column<string>(nullable: true),
        //            ProdSumDesc = table.Column<string>(nullable: true),
        //            ProdType = table.Column<string>(nullable: true),
        //            ProdAbbrev = table.Column<string>(nullable: true),
        //            WinC6ProductName = table.Column<string>(nullable: true),
        //            IsActive = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Product", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "PumpPrices",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Site = table.Column<string>(maxLength: 6, nullable: true),
        //            Date = table.Column<DateTime>(nullable: false),
        //            RegUnleaded = table.Column<double>(nullable: false),
        //            MidUnleaded = table.Column<double>(nullable: false),
        //            PremUnleaded = table.Column<double>(nullable: false),
        //            Diesel = table.Column<double>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_PumpPrices", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "PurchaseOrder",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            ShipTo = table.Column<int>(nullable: false),
        //            ProductId = table.Column<int>(nullable: false),
        //            RequiredAdvance = table.Column<int>(nullable: false),
        //            TotalAmount = table.Column<double>(nullable: true),
        //            PurchaseOrderNumber = table.Column<string>(maxLength: 30, nullable: true),
        //            EffectiveDate = table.Column<DateTime>(nullable: false),
        //            EndDate = table.Column<DateTime>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_PurchaseOrder", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "RetailAdder",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            AdderAmount = table.Column<decimal>(nullable: false),
        //            StartDate = table.Column<DateTime>(nullable: false),
        //            EndDate = table.Column<DateTime>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_RetailAdder", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SampleTable",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Name = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SampleTable", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SiteCustomers",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustNo = table.Column<string>(maxLength: 5, nullable: true),
        //            DeviceNo = table.Column<string>(maxLength: 7, nullable: true),
        //            CardPrefix = table.Column<string>(maxLength: 1, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SiteCustomers", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Sites",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            SiteNumber = table.Column<double>(nullable: true),
        //            Island = table.Column<double>(nullable: true),
        //            SiteName = table.Column<string>(maxLength: 50, nullable: true),
        //            Address = table.Column<string>(maxLength: 50, nullable: true),
        //            City = table.Column<string>(maxLength: 50, nullable: true),
        //            State = table.Column<string>(maxLength: 2, nullable: true),
        //            Zip = table.Column<string>(maxLength: 15, nullable: true),
        //            Phone = table.Column<string>(maxLength: 15, nullable: true),
        //            ModemNumber = table.Column<string>(maxLength: 30, nullable: true),
        //            Port = table.Column<double>(nullable: true),
        //            Baud = table.Column<double>(nullable: true),
        //            Parity = table.Column<string>(maxLength: 1, nullable: true),
        //            DataBits = table.Column<double>(nullable: true),
        //            COS = table.Column<double>(nullable: true),
        //            ReceiptLine1 = table.Column<string>(maxLength: 17, nullable: true),
        //            ReceiptLine2 = table.Column<string>(maxLength: 17, nullable: true),
        //            ReceiptLine3 = table.Column<string>(maxLength: 17, nullable: true),
        //            ReceiptLine4 = table.Column<string>(maxLength: 17, nullable: true),
        //            LastConnection = table.Column<DateTime>(nullable: true),
        //            InitString = table.Column<string>(maxLength: 50, nullable: true),
        //            ICU_Init = table.Column<string>(maxLength: 40, nullable: true),
        //            ROM_Desc = table.Column<string>(maxLength: 40, nullable: true),
        //            LcleId = table.Column<int>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Sites", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SolarcLocale",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            OfficeBAID = table.Column<int>(nullable: false),
        //            LocaleStatus = table.Column<string>(maxLength: 1, nullable: true),
        //            LocaleTypeId = table.Column<int>(nullable: false),
        //            OfficeLocaleId = table.Column<int>(nullable: false),
        //            LocaleName = table.Column<string>(nullable: true),
        //            LocaleAbbreviation = table.Column<string>(maxLength: 20, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SolarcLocale", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SolArcProduct",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            ProductId = table.Column<int>(nullable: false),
        //            ProductStatus = table.Column<string>(maxLength: 1, nullable: true),
        //            ProductName = table.Column<string>(maxLength: 50, nullable: true),
        //            ProductAbbreviation = table.Column<string>(maxLength: 3, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SolArcProduct", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Source",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Code = table.Column<string>(maxLength: 5, nullable: true),
        //            Description = table.Column<string>(maxLength: 50, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Source", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SpecialCustomer",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            SpecialCustomerCode = table.Column<string>(maxLength: 1, nullable: true),
        //            Description = table.Column<string>(maxLength: 30, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SpecialCustomer", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SPR_CreateFleetRecExceptions",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            BillingWeek = table.Column<string>(maxLength: 6, nullable: true),
        //            FleetTranNo = table.Column<string>(maxLength: 10, nullable: true),
        //            ImportValue = table.Column<string>(maxLength: 20, nullable: true),
        //            GasCardValue = table.Column<string>(maxLength: 20, nullable: true),
        //            ErrorDesc = table.Column<string>(maxLength: 200, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SPR_CreateFleetRecExceptions", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "State",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            State = table.Column<string>(maxLength: 2, nullable: true),
        //            Description = table.Column<string>(maxLength: 30, nullable: true),
        //            TaxArea = table.Column<string>(maxLength: 2, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_State", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SyncVehicle",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            VehicleId = table.Column<int>(nullable: false),
        //            LockCode = table.Column<string>(maxLength: 1, nullable: true),
        //            LockDate = table.Column<DateTime>(nullable: true),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            Date1stPur = table.Column<DateTime>(nullable: true),
        //            VIN = table.Column<string>(maxLength: 17, nullable: true),
        //            VehicleLicenseTag = table.Column<string>(maxLength: 10, nullable: true),
        //            VehicleLicenseTagState = table.Column<string>(maxLength: 2, nullable: true),
        //            VehDesc = table.Column<string>(maxLength: 25, nullable: true),
        //            ProductType1 = table.Column<string>(maxLength: 25, nullable: true),
        //            Product1Capacity = table.Column<int>(nullable: false),
        //            ProductType2 = table.Column<string>(maxLength: 25, nullable: true),
        //            Product2Capacity = table.Column<int>(nullable: false),
        //            ProductCapPercentVar = table.Column<int>(nullable: true),
        //            MileageUnitsPerGallon = table.Column<int>(nullable: true),
        //            MileageUnitsOfMeasure = table.Column<string>(maxLength: 10, nullable: true),
        //            MaxGalTrn = table.Column<decimal>(nullable: true),
        //            MaxGalDay = table.Column<decimal>(nullable: true),
        //            MaxGalCycl = table.Column<decimal>(nullable: true),
        //            MaxMotorOil = table.Column<decimal>(nullable: true),
        //            LastActivityDate = table.Column<DateTime>(nullable: true),
        //            LastGallons = table.Column<decimal>(nullable: true),
        //            TheirVehicleNumber = table.Column<string>(maxLength: 20, nullable: true),
        //            VehicleType = table.Column<string>(maxLength: 2, nullable: true),
        //            UsedOnRoad = table.Column<string>(maxLength: 1, nullable: true),
        //            VehicleLevel2Id = table.Column<int>(nullable: false),
        //            VehicleLevel3Id = table.Column<int>(nullable: false),
        //            VehicleLevel4Id = table.Column<int>(nullable: false),
        //            VehicleLevel5Id = table.Column<int>(nullable: false),
        //            VehicleLevel6Id = table.Column<int>(nullable: false),
        //            VehicleLevel7Id = table.Column<int>(nullable: false),
        //            VehicleUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            VehicleUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            VehicleUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            Class = table.Column<string>(maxLength: 10, nullable: true),
        //            Odometer = table.Column<int>(nullable: true),
        //            ExternalPin = table.Column<string>(maxLength: 10, nullable: true),
        //            Pin = table.Column<int>(nullable: false),
        //            Sequence = table.Column<int>(nullable: false),
        //            Status = table.Column<int>(nullable: false),
        //            LastUseDate = table.Column<DateTime>(nullable: true),
        //            UseCount = table.Column<int>(nullable: true),
        //            MeterType = table.Column<string>(maxLength: 12, nullable: true),
        //            Qty = table.Column<decimal>(nullable: true),
        //            LastOdometer = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SyncVehicle", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TaxAreas",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            TaxArea = table.Column<string>(maxLength: 2, nullable: true),
        //            TaxAreaDesc = table.Column<string>(maxLength: 30, nullable: true),
        //            County = table.Column<string>(maxLength: 30, nullable: true),
        //            SalesTaxRegion = table.Column<string>(maxLength: 1, nullable: true),
        //            State = table.Column<string>(maxLength: 2, nullable: true),
        //            MCTD = table.Column<string>(maxLength: 1, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_TaxAreas", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TaxLocation",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            SolarcTaxLocaleId = table.Column<int>(nullable: false),
        //            Name = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_TaxLocation", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TempTransaction",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            RecordType = table.Column<string>(nullable: true),
        //            AccountId = table.Column<int>(nullable: false),
        //            AccountLevel1Id = table.Column<int>(nullable: false),
        //            DriverLevel2Id = table.Column<int>(nullable: false),
        //            DriverLevel3Id = table.Column<int>(nullable: false),
        //            DriverId = table.Column<int>(nullable: false),
        //            DriverLastName = table.Column<string>(nullable: true),
        //            DriverFirstName = table.Column<string>(nullable: true),
        //            DriverMiddleInitial = table.Column<string>(nullable: true),
        //            VehicleLevel2Id = table.Column<int>(nullable: false),
        //            VehicleLevel3Id = table.Column<int>(nullable: false),
        //            VehicleId = table.Column<int>(nullable: false),
        //            VehicleVinNumber = table.Column<string>(nullable: true),
        //            VehicleDescription = table.Column<string>(nullable: true),
        //            VehicleLicenseTag = table.Column<string>(nullable: true),
        //            VehicleLicenseTagState = table.Column<string>(nullable: true),
        //            CardLevel2Id = table.Column<int>(nullable: false),
        //            CardLevel3Id = table.Column<int>(nullable: false),
        //            CardId = table.Column<int>(nullable: false),
        //            ParticipantCode = table.Column<int>(nullable: false),
        //            PurchaseDate = table.Column<string>(nullable: true),
        //            PurchaseTime = table.Column<int>(nullable: false),
        //            InvoiceNumber = table.Column<string>(nullable: true),
        //            MerchantAccountNumber = table.Column<string>(nullable: true),
        //            MerchantAddress = table.Column<string>(nullable: true),
        //            MerchantCity = table.Column<string>(nullable: true),
        //            MerchantState = table.Column<string>(nullable: true),
        //            MerchantZipCode = table.Column<string>(nullable: true),
        //            MerchantZipCode4 = table.Column<string>(nullable: true),
        //            ProductCode = table.Column<string>(nullable: true),
        //            ProductAmount = table.Column<decimal>(nullable: false),
        //            ProductUnits = table.Column<decimal>(nullable: false),
        //            CostPerUnit = table.Column<decimal>(nullable: false),
        //            CostPerMile = table.Column<decimal>(nullable: false),
        //            MilesPerGallon = table.Column<decimal>(nullable: false),
        //            Odometer = table.Column<int>(nullable: false),
        //            MessageIdPosition = table.Column<string>(nullable: true),
        //            ServiceTypeIndicator = table.Column<string>(nullable: true),
        //            MicrofilmReferenceNumber = table.Column<string>(nullable: true),
        //            Flags = table.Column<string>(nullable: true),
        //            ExemptFederalTax = table.Column<decimal>(nullable: false),
        //            ExemptPrimaryMotorFuelTax = table.Column<decimal>(nullable: false),
        //            ExemptSecondaryMotorFuelTax = table.Column<decimal>(nullable: false),
        //            ExemptLocalSalesTax = table.Column<decimal>(nullable: false),
        //            ExemptStateSalesTax = table.Column<decimal>(nullable: false),
        //            ExemptMiscTax = table.Column<decimal>(nullable: false),
        //            OrgNumber = table.Column<string>(nullable: true),
        //            Filler = table.Column<string>(nullable: true),
        //            DriverLevel2Name = table.Column<string>(nullable: true),
        //            DriverLevel3Name = table.Column<string>(nullable: true),
        //            VehicleLevel2Name = table.Column<string>(nullable: true),
        //            VehicleLevel3Name = table.Column<string>(nullable: true),
        //            CardLevel2Name = table.Column<string>(nullable: true),
        //            CardLevel3Name = table.Column<string>(nullable: true),
        //            DriverLevel4Id = table.Column<int>(nullable: false),
        //            DriverLevel4Name = table.Column<string>(nullable: true),
        //            DriverLevel5Id = table.Column<int>(nullable: false),
        //            DriverLevel5Name = table.Column<string>(nullable: true),
        //            DriverLevel6Id = table.Column<int>(nullable: false),
        //            DriverLevel6Name = table.Column<string>(nullable: true),
        //            DriverLevel7Id = table.Column<int>(nullable: false),
        //            DriverLevel7Name = table.Column<string>(nullable: true),
        //            VehicleLevel4Id = table.Column<int>(nullable: false),
        //            VehicleLevel4Name = table.Column<string>(nullable: true),
        //            VehicleLevel5Id = table.Column<int>(nullable: false),
        //            VehicleLevel5Name = table.Column<string>(nullable: true),
        //            VehicleLevel6Id = table.Column<int>(nullable: false),
        //            VehicleLevel6Name = table.Column<string>(nullable: true),
        //            VehicleLevel7Id = table.Column<int>(nullable: false),
        //            VehicleLevel7Name = table.Column<string>(nullable: true),
        //            CardLevel4Id = table.Column<int>(nullable: false),
        //            CardLevel4Name = table.Column<string>(nullable: true),
        //            CardLevel5Id = table.Column<int>(nullable: false),
        //            FileName = table.Column<string>(nullable: true),
        //            SenderName = table.Column<string>(nullable: true),
        //            CustomerName = table.Column<string>(nullable: true),
        //            FileDate = table.Column<DateTime>(nullable: true),
        //            FileType = table.Column<string>(nullable: true),
        //            FooterStamped = table.Column<bool>(nullable: false),
        //            ExemptTaxes = table.Column<decimal>(nullable: false),
        //            InvoiceCount = table.Column<int>(nullable: false),
        //            TotalProductUnits = table.Column<decimal>(nullable: false),
        //            TotalProductAmount = table.Column<decimal>(nullable: false),
        //            StatementDate = table.Column<DateTime>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_TempTransaction", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TransactionError",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Code = table.Column<string>(maxLength: 50, nullable: true),
        //            Description = table.Column<string>(maxLength: 100, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_TransactionError", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TransactionException",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Code = table.Column<string>(maxLength: 50, nullable: true),
        //            Description = table.Column<string>(maxLength: 100, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_TransactionException", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TransactionFlag",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Name = table.Column<string>(nullable: true),
        //            Description = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_TransactionFlag", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TransactionImportLog",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            NumberOfInvoices = table.Column<int>(nullable: false),
        //            TotalProductUnits = table.Column<decimal>(nullable: false),
        //            TotalProductAmount = table.Column<decimal>(nullable: false),
        //            StatementDate = table.Column<DateTime>(nullable: true),
        //            Filename = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_TransactionImportLog", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "VehicleImport",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            LockCode = table.Column<string>(maxLength: 1, nullable: true),
        //            LockDate = table.Column<DateTime>(nullable: true),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            Date1stPur = table.Column<DateTime>(nullable: true),
        //            VIN = table.Column<string>(maxLength: 17, nullable: true),
        //            VehicleLicenseTag = table.Column<string>(maxLength: 10, nullable: true),
        //            VehicleLicenseTagState = table.Column<string>(maxLength: 2, nullable: true),
        //            ExternalVehicleId = table.Column<int>(nullable: false),
        //            VehDesc = table.Column<string>(maxLength: 25, nullable: true),
        //            ProductType1 = table.Column<int>(nullable: true),
        //            Product1Capacity = table.Column<int>(nullable: false),
        //            ProductType2 = table.Column<int>(nullable: true),
        //            Product2Capacity = table.Column<int>(nullable: false),
        //            ProductCapPercentVar = table.Column<int>(nullable: true),
        //            MileageUnitsPerGallon = table.Column<int>(nullable: true),
        //            MileageUnitsOfMeasure = table.Column<string>(maxLength: 10, nullable: true),
        //            MaxGalTrn = table.Column<decimal>(nullable: true),
        //            MaxGalDay = table.Column<decimal>(nullable: true),
        //            MaxGalCycl = table.Column<decimal>(nullable: true),
        //            MaxMotorOil = table.Column<decimal>(nullable: true),
        //            LastActivityDate = table.Column<DateTime>(nullable: true),
        //            LastGallons = table.Column<decimal>(nullable: true),
        //            TheirVehicleNumber = table.Column<string>(maxLength: 20, nullable: true),
        //            VehicleType = table.Column<string>(maxLength: 2, nullable: true),
        //            UsedOnRoad = table.Column<string>(maxLength: 1, nullable: true),
        //            VehicleLevel2Id = table.Column<int>(nullable: false),
        //            VehicleLevel3Id = table.Column<int>(nullable: true),
        //            VehicleLevel4Id = table.Column<int>(nullable: true),
        //            VehicleLevel5Id = table.Column<int>(nullable: true),
        //            VehicleLevel6Id = table.Column<int>(nullable: true),
        //            VehicleLevel7Id = table.Column<int>(nullable: true),
        //            VehicleUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            VehicleUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            VehicleUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            Class = table.Column<string>(maxLength: 10, nullable: true),
        //            Dept = table.Column<string>(nullable: true),
        //            CardNo = table.Column<string>(maxLength: 10, nullable: true),
        //            Odometer = table.Column<int>(nullable: true),
        //            ExternalPin = table.Column<string>(maxLength: 10, nullable: true),
        //            Pin = table.Column<int>(nullable: false),
        //            Sequence = table.Column<int>(nullable: false),
        //            Status = table.Column<int>(nullable: false),
        //            LastUseDate = table.Column<DateTime>(nullable: true),
        //            UseCount = table.Column<int>(nullable: true),
        //            MeterType = table.Column<string>(maxLength: 12, nullable: true),
        //            Qty = table.Column<decimal>(nullable: true),
        //            LastOdometer = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            Synchronized = table.Column<int>(nullable: false),
        //            LegacyProductCode1 = table.Column<string>(maxLength: 5, nullable: true),
        //            LegacyProductCode2 = table.Column<string>(maxLength: 5, nullable: true),
        //            SyncStatus = table.Column<int>(nullable: false),
        //            OriginProduct = table.Column<string>(nullable: true),
        //            OriginCreateDate = table.Column<DateTime>(nullable: true),
        //            OriginModifyDate = table.Column<DateTime>(nullable: true),
        //            CustNo = table.Column<string>(maxLength: 10, nullable: true),
        //            ClassId = table.Column<int>(nullable: true),
        //            CopyRecord = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_VehicleImport", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "VehicleType",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            VehicleType = table.Column<string>(maxLength: 2, nullable: true),
        //            VehicleTypeDesc = table.Column<string>(maxLength: 30, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_VehicleType", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "VoidTransactions",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            DeviceNo = table.Column<string>(maxLength: 7, nullable: true),
        //            TranDate = table.Column<DateTime>(nullable: false),
        //            TranTime = table.Column<string>(maxLength: 4, nullable: true),
        //            TranNo = table.Column<string>(maxLength: 4, nullable: true),
        //            TranType4 = table.Column<string>(maxLength: 4, nullable: true),
        //            Item = table.Column<string>(maxLength: 2, nullable: true),
        //            SiteFran = table.Column<string>(maxLength: 5, nullable: true),
        //            CardNo = table.Column<string>(maxLength: 19, nullable: true),
        //            CustomerCardNumber = table.Column<string>(nullable: true),
        //            FranNo = table.Column<string>(maxLength: 10, nullable: true),
        //            CustNo = table.Column<string>(maxLength: 5, nullable: true),
        //            VehcNo = table.Column<string>(maxLength: 5, nullable: true),
        //            EmplNo = table.Column<string>(maxLength: 5, nullable: true),
        //            Odometer = table.Column<string>(maxLength: 6, nullable: true),
        //            Pump = table.Column<string>(maxLength: 2, nullable: true),
        //            Prod = table.Column<string>(maxLength: 2, nullable: true),
        //            AmtGal = table.Column<double>(nullable: false),
        //            Price = table.Column<decimal>(nullable: false),
        //            TaxFlag = table.Column<string>(maxLength: 1, nullable: true),
        //            ErrorCond = table.Column<string>(maxLength: 2, nullable: true),
        //            StationReimbursementAmount = table.Column<decimal>(nullable: false),
        //            CardNoShort = table.Column<string>(maxLength: 6, nullable: true),
        //            StationReimbursementActual = table.Column<double>(nullable: false),
        //            FleetNetWeek = table.Column<string>(maxLength: 6, nullable: true),
        //            FleetNetTranNo = table.Column<string>(maxLength: 10, nullable: true),
        //            PumpPrice = table.Column<double>(nullable: false),
        //            OrgnlSRAExtnlDcmntNmbr = table.Column<string>(maxLength: 80, nullable: true),
        //            CreationDate = table.Column<DateTime>(nullable: false),
        //            UserId = table.Column<int>(nullable: false),
        //            DateProcessed = table.Column<DateTime>(nullable: false),
        //            SRAExtnlDcmntNmbr = table.Column<string>(maxLength: 80, nullable: true),
        //            PostedCustomerSaleAmount = table.Column<double>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_VoidTransactions", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "VoyagerErrorCodes",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            ErrorCode = table.Column<string>(nullable: true),
        //            ErrorDescription = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_VoyagerErrorCodes", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "VoyagerSyncCard",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            SpragueEntityId = table.Column<string>(nullable: true),
        //            LockCode = table.Column<string>(maxLength: 1, nullable: true),
        //            LockDate = table.Column<DateTime>(nullable: true),
        //            ExternalCardId = table.Column<int>(nullable: false),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            CustomerId = table.Column<int>(nullable: false),
        //            DriverId = table.Column<int>(nullable: true),
        //            VehicleId = table.Column<int>(nullable: true),
        //            CardNo = table.Column<int>(nullable: true),
        //            TheirCardNumber = table.Column<string>(nullable: true),
        //            EmbossedCardNumber = table.Column<string>(maxLength: 15, nullable: true),
        //            EntityType = table.Column<int>(nullable: false),
        //            Date1stPur = table.Column<DateTime>(nullable: true),
        //            MaxGalTrn = table.Column<decimal>(nullable: true),
        //            MaxGalDay = table.Column<decimal>(nullable: true),
        //            MaxGalCycl = table.Column<decimal>(nullable: true),
        //            MaxMotorOil = table.Column<decimal>(nullable: true),
        //            LastActivityDate = table.Column<DateTime>(nullable: true),
        //            LastGallons = table.Column<decimal>(nullable: true),
        //            CardLevel2Id = table.Column<int>(nullable: false),
        //            CardLevel3Id = table.Column<int>(nullable: true),
        //            CardLevel4Id = table.Column<int>(nullable: true),
        //            CardLevel5Id = table.Column<int>(nullable: true),
        //            CardLevel6Id = table.Column<int>(nullable: true),
        //            CardLevel7Id = table.Column<int>(nullable: true),
        //            CardUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            CardUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            CardUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardLevel2Name = table.Column<string>(maxLength: 25, nullable: true),
        //            CardLevel3Name = table.Column<string>(maxLength: 25, nullable: true),
        //            CardLevel4Name = table.Column<string>(maxLength: 25, nullable: true),
        //            CardLevel5Name = table.Column<string>(maxLength: 25, nullable: true),
        //            CardLevel6Name = table.Column<string>(maxLength: 25, nullable: true),
        //            CardLevel7Name = table.Column<string>(maxLength: 25, nullable: true),
        //            ProductUse = table.Column<int>(nullable: false),
        //            TransactionDollarLimit = table.Column<int>(nullable: true),
        //            TransactionDollarLimitMode = table.Column<int>(nullable: true),
        //            DailyDollarLimit = table.Column<int>(nullable: true),
        //            DailyDollarLimitMode = table.Column<int>(nullable: true),
        //            WeeklyDollarLimit = table.Column<int>(nullable: true),
        //            WeeklyDollarLimitMode = table.Column<int>(nullable: true),
        //            MonthlyDollarLimit = table.Column<int>(nullable: true),
        //            MonthlyDollarLimitMode = table.Column<int>(nullable: true),
        //            DailyTransactionLimit = table.Column<int>(nullable: true),
        //            DailyTransactionLimitMode = table.Column<int>(nullable: true),
        //            WeeklyTransactionLimit = table.Column<int>(nullable: true),
        //            WeeklyTransactionLimitMode = table.Column<int>(nullable: true),
        //            MonthlyTransactionLimit = table.Column<int>(nullable: true),
        //            MonthlyTransactionLimitMode = table.Column<int>(nullable: true),
        //            PurchaseDay = table.Column<int>(nullable: true),
        //            PurchaseDayMode = table.Column<int>(nullable: true),
        //            PurchaseFromTimeBand1 = table.Column<DateTime>(nullable: true),
        //            PurchaseToTimeBand1 = table.Column<DateTime>(nullable: true),
        //            PurchaseTimeBand1Mode = table.Column<int>(nullable: true),
        //            PurchaseFromTimeBand2 = table.Column<DateTime>(nullable: true),
        //            PurchaseToTimeBand2 = table.Column<DateTime>(nullable: true),
        //            PurchaseTimeBand2Mode = table.Column<int>(nullable: true),
        //            OdometerValidation = table.Column<int>(nullable: false),
        //            OdometerValidationMode = table.Column<int>(nullable: true),
        //            OdometerLimit = table.Column<int>(nullable: true),
        //            Status = table.Column<int>(nullable: false),
        //            LastUseDate = table.Column<DateTime>(nullable: true),
        //            UseCount = table.Column<int>(nullable: true),
        //            QTY = table.Column<decimal>(nullable: true),
        //            LastOdometer = table.Column<DateTime>(nullable: true),
        //            CardExpirationDate = table.Column<DateTime>(nullable: true),
        //            DAMCardStatusIndicator = table.Column<int>(nullable: true),
        //            CardPromptPattern = table.Column<int>(nullable: false),
        //            PinNumber = table.Column<int>(nullable: true),
        //            RestrictionCode = table.Column<int>(nullable: false),
        //            Synchronized = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_VoyagerSyncCard", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "VoyagerSyncDriver",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            ExternalDriverId = table.Column<string>(nullable: true),
        //            NameLast = table.Column<string>(maxLength: 20, nullable: true),
        //            NameFirst = table.Column<string>(maxLength: 20, nullable: true),
        //            MiddleInitial = table.Column<string>(maxLength: 1, nullable: true),
        //            Pin = table.Column<int>(nullable: false),
        //            LastActivityDate = table.Column<DateTime>(nullable: true),
        //            LockCode = table.Column<string>(maxLength: 1, nullable: true),
        //            LockDate = table.Column<DateTime>(nullable: true),
        //            TheirEmployeeNumber = table.Column<string>(maxLength: 10, nullable: true),
        //            DriverLevel2Id = table.Column<int>(nullable: false),
        //            DriverLevel3Id = table.Column<int>(nullable: true),
        //            DriverLevel4Id = table.Column<int>(nullable: true),
        //            DriverLevel5Id = table.Column<int>(nullable: true),
        //            DriverLevel6Id = table.Column<int>(nullable: true),
        //            DriverLevel7Id = table.Column<int>(nullable: true),
        //            DriverLevel2Name = table.Column<string>(maxLength: 25, nullable: true),
        //            DriverLevel3Name = table.Column<string>(maxLength: 25, nullable: true),
        //            DriverLevel4Name = table.Column<string>(maxLength: 25, nullable: true),
        //            DriverLevel5Name = table.Column<string>(maxLength: 25, nullable: true),
        //            DriverLevel6Name = table.Column<string>(maxLength: 25, nullable: true),
        //            DriverLevel7Name = table.Column<string>(maxLength: 25, nullable: true),
        //            Class = table.Column<string>(maxLength: 10, nullable: true),
        //            Sequence = table.Column<int>(nullable: false),
        //            MENU = table.Column<int>(nullable: false),
        //            Status = table.Column<int>(nullable: false),
        //            UseCount = table.Column<int>(nullable: false),
        //            Quantity = table.Column<decimal>(nullable: false),
        //            MinVehc = table.Column<int>(nullable: true),
        //            MaxVehc = table.Column<int>(nullable: true),
        //            DriverUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            DriverUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            DriverUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            Synchronized = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_VoyagerSyncDriver", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "VoyagerSyncVehicle",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            LockCode = table.Column<string>(maxLength: 1, nullable: true),
        //            LockDate = table.Column<DateTime>(nullable: true),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            Date1stPur = table.Column<DateTime>(nullable: true),
        //            VIN = table.Column<string>(maxLength: 17, nullable: true),
        //            VehicleLicenseTag = table.Column<string>(maxLength: 10, nullable: true),
        //            VehicleLicenseTagState = table.Column<string>(maxLength: 2, nullable: true),
        //            ExternalVehicleId = table.Column<int>(nullable: false),
        //            VehDesc = table.Column<string>(maxLength: 25, nullable: true),
        //            ProductType1 = table.Column<int>(nullable: true),
        //            Product1Capacity = table.Column<int>(nullable: false),
        //            ProductType2 = table.Column<int>(nullable: true),
        //            Product2Capacity = table.Column<int>(nullable: false),
        //            ProductCapPercentVar = table.Column<int>(nullable: true),
        //            MileageUnitsPerGallon = table.Column<int>(nullable: true),
        //            MileageUnitsOfMeasure = table.Column<string>(maxLength: 10, nullable: true),
        //            MaxGalTrn = table.Column<decimal>(nullable: true),
        //            MaxGalDay = table.Column<decimal>(nullable: true),
        //            MaxGalCycl = table.Column<decimal>(nullable: true),
        //            MaxMotorOil = table.Column<decimal>(nullable: true),
        //            LastActivityDate = table.Column<DateTime>(nullable: true),
        //            LastGallons = table.Column<decimal>(nullable: true),
        //            TheirVehicleNumber = table.Column<string>(maxLength: 20, nullable: true),
        //            VehicleType = table.Column<string>(maxLength: 2, nullable: true),
        //            UsedOnRoad = table.Column<string>(maxLength: 1, nullable: true),
        //            VehicleLevel2Id = table.Column<int>(nullable: false),
        //            VehicleLevel3Id = table.Column<int>(nullable: true),
        //            VehicleLevel4Id = table.Column<int>(nullable: true),
        //            VehicleLevel5Id = table.Column<int>(nullable: true),
        //            VehicleLevel6Id = table.Column<int>(nullable: true),
        //            VehicleLevel7Id = table.Column<int>(nullable: true),
        //            VehicleUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            VehicleUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            VehicleUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleLevel2Name = table.Column<string>(maxLength: 25, nullable: true),
        //            VehicleLevel3Name = table.Column<string>(maxLength: 25, nullable: true),
        //            VehicleLevel4Name = table.Column<string>(maxLength: 25, nullable: true),
        //            VehicleLevel5Name = table.Column<string>(maxLength: 25, nullable: true),
        //            VehicleLevel6Name = table.Column<string>(maxLength: 25, nullable: true),
        //            VehicleLevel7Name = table.Column<string>(maxLength: 25, nullable: true),
        //            Class = table.Column<string>(maxLength: 10, nullable: true),
        //            Odometer = table.Column<int>(nullable: true),
        //            ExternalPin = table.Column<string>(maxLength: 10, nullable: true),
        //            Pin = table.Column<int>(nullable: false),
        //            Sequence = table.Column<int>(nullable: false),
        //            Status = table.Column<int>(nullable: false),
        //            LastUseDate = table.Column<DateTime>(nullable: true),
        //            UseCount = table.Column<int>(nullable: true),
        //            MeterType = table.Column<string>(maxLength: 12, nullable: true),
        //            Qty = table.Column<decimal>(nullable: true),
        //            LastOdometer = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            Synchronized = table.Column<int>(nullable: false),
        //            LegacyProductCode1 = table.Column<string>(maxLength: 5, nullable: true),
        //            LegacyProductCode2 = table.Column<string>(maxLength: 5, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_VoyagerSyncVehicle", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "WinC6TransactionLog",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            SequenceNumber = table.Column<int>(nullable: false),
        //            SiteId = table.Column<int>(nullable: false),
        //            TransactionDate = table.Column<DateTime>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_WinC6TransactionLog", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "YTD_Product_Totals",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerNumber = table.Column<string>(maxLength: 5, nullable: true),
        //            Product = table.Column<string>(maxLength: 2, nullable: true),
        //            _Year = table.Column<string>(maxLength: 4, nullable: true),
        //            _Month = table.Column<string>(maxLength: 2, nullable: true),
        //            Total = table.Column<double>(nullable: false),
        //            Dollars = table.Column<double>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_YTD_Product_Totals", x => x.Id);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AspNetRoleClaims",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            RoleId = table.Column<string>(nullable: false),
        //            ClaimType = table.Column<string>(nullable: true),
        //            ClaimValue = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
        //                column: x => x.RoleId,
        //                principalTable: "AspNetRoles",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AspNetUserClaims",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            UserId = table.Column<string>(nullable: false),
        //            ClaimType = table.Column<string>(nullable: true),
        //            ClaimValue = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AspNetUserLogins",
        //        columns: table => new
        //        {
        //            LoginProvider = table.Column<string>(nullable: false),
        //            ProviderKey = table.Column<string>(nullable: false),
        //            ProviderDisplayName = table.Column<string>(nullable: true),
        //            UserId = table.Column<string>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
        //            table.ForeignKey(
        //                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AspNetUserRoles",
        //        columns: table => new
        //        {
        //            UserId = table.Column<string>(nullable: false),
        //            RoleId = table.Column<string>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
        //            table.ForeignKey(
        //                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
        //                column: x => x.RoleId,
        //                principalTable: "AspNetRoles",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AspNetUserTokens",
        //        columns: table => new
        //        {
        //            UserId = table.Column<string>(nullable: false),
        //            LoginProvider = table.Column<string>(nullable: false),
        //            Name = table.Column<string>(nullable: false),
        //            Value = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
        //            table.ForeignKey(
        //                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
        //                column: x => x.UserId,
        //                principalTable: "AspNetUsers",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Audit",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            AuditEventId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Audit", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Audit_AuditEvent_AuditEventId",
        //                column: x => x.AuditEventId,
        //                principalTable: "AuditEvent",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AuditHistory",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            AuditEventId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AuditHistory", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_AuditHistory_AuditEvent_AuditEventId",
        //                column: x => x.AuditEventId,
        //                principalTable: "AuditEvent",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CustomerCardCategory",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            CardCategoryId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CustomerCardCategory", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_CustomerCardCategory_CardCategory_CardCategoryId",
        //                column: x => x.CardCategoryId,
        //                principalTable: "CardCategory",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_CustomerCardCategory_Customer_CustomerId",
        //                column: x => x.CustomerId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CustomerMerchantLocation",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            MerchantId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CustomerMerchantLocation", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_CustomerMerchantLocation_Customer_CustomerId",
        //                column: x => x.CustomerId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CustomerZipCodeLocation",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            ZipCode = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CustomerZipCodeLocation", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_CustomerZipCodeLocation_Customer_CustomerId",
        //                column: x => x.CustomerId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DAMDriver",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            EntityId = table.Column<int>(nullable: false),
        //            DAMAction = table.Column<int>(nullable: false),
        //            DAMStatus = table.Column<int>(nullable: false),
        //            HasDataChange = table.Column<int>(nullable: false),
        //            CustomerId = table.Column<int>(nullable: false),
        //            ControlNumber = table.Column<int>(nullable: false),
        //            SequenceNumber = table.Column<int>(nullable: false),
        //            ErrorCode1 = table.Column<string>(nullable: true),
        //            ErrorCode2 = table.Column<string>(nullable: true),
        //            ErrorCode3 = table.Column<string>(nullable: true),
        //            ErrorCode4 = table.Column<string>(nullable: true),
        //            ErrorCode1Description = table.Column<string>(nullable: true),
        //            ErrorCode2Description = table.Column<string>(nullable: true),
        //            ErrorCode3Description = table.Column<string>(nullable: true),
        //            ErrorCode4Description = table.Column<string>(nullable: true),
        //            ExternalId = table.Column<int>(nullable: false),
        //            DriverId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DAMDriver", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_DAMDriver_Customer_CustomerId",
        //                column: x => x.CustomerId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_DAMDriver_Customer_EntityId",
        //                column: x => x.EntityId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Driver",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            ExternalDriverId = table.Column<string>(maxLength: 20, nullable: true),
        //            NameLast = table.Column<string>(maxLength: 20, nullable: true),
        //            NameFirst = table.Column<string>(maxLength: 20, nullable: true),
        //            MiddleInitial = table.Column<string>(maxLength: 1, nullable: true),
        //            Pin = table.Column<string>(nullable: true),
        //            LastActivityDate = table.Column<DateTime>(nullable: true),
        //            LockCode = table.Column<string>(maxLength: 1, nullable: true),
        //            LockDate = table.Column<DateTime>(nullable: true),
        //            TheirEmployeeNumber = table.Column<string>(maxLength: 10, nullable: true),
        //            DailyTransactionLimit = table.Column<int>(nullable: true),
        //            DriverLevel2Id = table.Column<int>(nullable: false),
        //            DriverLevel3Id = table.Column<int>(nullable: true),
        //            DriverLevel4Id = table.Column<int>(nullable: true),
        //            DriverLevel5Id = table.Column<int>(nullable: true),
        //            DriverLevel6Id = table.Column<int>(nullable: true),
        //            DriverLevel7Id = table.Column<int>(nullable: true),
        //            Class = table.Column<string>(maxLength: 10, nullable: true),
        //            Sequence = table.Column<int>(nullable: false),
        //            MENU = table.Column<int>(nullable: false),
        //            Status = table.Column<int>(nullable: false),
        //            UseCount = table.Column<int>(nullable: false),
        //            Quantity = table.Column<decimal>(nullable: false),
        //            MinVehc = table.Column<int>(nullable: true),
        //            MaxVehc = table.Column<int>(nullable: true),
        //            DriverUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            DriverUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            DriverUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            Synchronized = table.Column<int>(nullable: false),
        //            SubmitPending = table.Column<bool>(nullable: true),
        //            ClassId = table.Column<int>(nullable: true),
        //            IsConsignment = table.Column<bool>(nullable: false),
        //            ExternalDeleteDate = table.Column<DateTime>(nullable: true),
        //            IsFuelMaster = table.Column<bool>(nullable: false),
        //            IsWinC6 = table.Column<bool>(nullable: false),
        //            IsVoyager = table.Column<bool>(nullable: false),
        //            ExistsInVoyager = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Driver", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Driver_Customer_CustomerId",
        //                column: x => x.CustomerId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SendTransactionsErrorLog",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            AccountNumber = table.Column<int>(nullable: true),
        //            AccountLevel1Id = table.Column<int>(nullable: true),
        //            CustNo = table.Column<string>(maxLength: 5, nullable: true),
        //            LocationId = table.Column<int>(nullable: false),
        //            ParticipantCode = table.Column<int>(nullable: false),
        //            MerchantAccountId = table.Column<string>(nullable: true),
        //            TranDate = table.Column<DateTime>(nullable: false),
        //            TranTime = table.Column<string>(maxLength: 4, nullable: true),
        //            TranType4 = table.Column<string>(maxLength: 4, nullable: true),
        //            PostDate = table.Column<DateTime>(nullable: true),
        //            CardId = table.Column<int>(nullable: true),
        //            ExternalCardId = table.Column<int>(nullable: false),
        //            VehicleId = table.Column<int>(nullable: true),
        //            ExternalVehicleId = table.Column<int>(nullable: false),
        //            DriverId = table.Column<int>(nullable: true),
        //            ExternalDriverId = table.Column<int>(nullable: false),
        //            Odometer = table.Column<int>(nullable: true),
        //            Pump = table.Column<string>(maxLength: 2, nullable: true),
        //            Prod = table.Column<string>(maxLength: 4, nullable: true),
        //            ProdId = table.Column<int>(nullable: false),
        //            Price = table.Column<decimal>(nullable: true),
        //            AmtGal = table.Column<decimal>(nullable: true),
        //            PumpPrice = table.Column<decimal>(nullable: false),
        //            CostPerMile = table.Column<decimal>(nullable: true),
        //            MilesPerGallon = table.Column<decimal>(nullable: true),
        //            FedEx = table.Column<decimal>(nullable: true),
        //            StaEx = table.Column<decimal>(nullable: true),
        //            StaSales = table.Column<decimal>(nullable: true),
        //            OtherTax = table.Column<decimal>(nullable: true),
        //            TaxFlag = table.Column<string>(maxLength: 1, nullable: true),
        //            CaptureMethod = table.Column<string>(nullable: true),
        //            ServiceTypeIndicator = table.Column<string>(nullable: true),
        //            MicrofileRefNumber = table.Column<string>(maxLength: 15, nullable: true),
        //            ExceptionFlags = table.Column<string>(maxLength: 3, nullable: true),
        //            CustomerSalesAmount = table.Column<decimal>(nullable: true),
        //            UnpaidTaxes = table.Column<decimal>(nullable: true),
        //            StationReimbursementAmount = table.Column<decimal>(nullable: true),
        //            TaxArea = table.Column<string>(maxLength: 2, nullable: true),
        //            StationReimbursementActual = table.Column<decimal>(nullable: true),
        //            MerchantInvoiceNumber = table.Column<string>(maxLength: 8, nullable: true),
        //            Source = table.Column<string>(maxLength: 2, nullable: true),
        //            SRAExtrnlDcmntNmbr = table.Column<string>(maxLength: 80, nullable: true),
        //            FederalExciseTaxAmount = table.Column<decimal>(nullable: true),
        //            StateExciseTaxAmount = table.Column<decimal>(nullable: true),
        //            PBTAmount = table.Column<decimal>(nullable: true),
        //            SalesTaxPerGallonAmount = table.Column<decimal>(nullable: true),
        //            SalesTaxPercentAmount = table.Column<decimal>(nullable: true),
        //            PBTRate = table.Column<decimal>(nullable: true),
        //            SalesTaxPerGallonRate = table.Column<decimal>(nullable: true),
        //            SalesTaxPercentRate = table.Column<decimal>(nullable: true),
        //            ProductBasePrice = table.Column<decimal>(nullable: true),
        //            SolarcProductPrice = table.Column<decimal>(nullable: true),
        //            FullPrice = table.Column<decimal>(nullable: true),
        //            TaxLocaleId = table.Column<int>(nullable: false),
        //            VoyagerPostDate = table.Column<DateTime>(nullable: false),
        //            PerUnitCOGS = table.Column<decimal>(nullable: false),
        //            HourMeter = table.Column<int>(nullable: true),
        //            DriverLevel2Id = table.Column<int>(nullable: false),
        //            DriverLevel3Id = table.Column<int>(nullable: true),
        //            DriverLevel4Id = table.Column<int>(nullable: true),
        //            DriverLevel5Id = table.Column<int>(nullable: true),
        //            DriverLevel6Id = table.Column<int>(nullable: true),
        //            DriverLevel7Id = table.Column<int>(nullable: true),
        //            VehicleLevel2Id = table.Column<int>(nullable: false),
        //            VehicleLevel3Id = table.Column<int>(nullable: true),
        //            VehicleLevel4Id = table.Column<int>(nullable: true),
        //            VehicleLevel5Id = table.Column<int>(nullable: true),
        //            VehicleLevel6Id = table.Column<int>(nullable: true),
        //            VehicleLevel7Id = table.Column<int>(nullable: true),
        //            CardLevel2Id = table.Column<int>(nullable: false),
        //            CardLevel3Id = table.Column<int>(nullable: true),
        //            CardLevel4Id = table.Column<int>(nullable: true),
        //            CardLevel5Id = table.Column<int>(nullable: true),
        //            CardLevel6Id = table.Column<int>(nullable: true),
        //            CardLevel7Id = table.Column<int>(nullable: true),
        //            DriverUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            DriverUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            DriverUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            VehicleUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            VehicleUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            CardUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            CardUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            PricingLocationGroupId = table.Column<int>(nullable: true),
        //            CustomerPricingLocationGroupId = table.Column<int>(nullable: true),
        //            PriceServiceId = table.Column<int>(nullable: true),
        //            SendErrors = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SendTransactionsErrorLog", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_SendTransactionsErrorLog_Customer_DriverId",
        //                column: x => x.DriverId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SmallGallonTransactions",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            AccountNumber = table.Column<int>(nullable: true),
        //            AccountLevel1Id = table.Column<int>(nullable: true),
        //            CustNo = table.Column<string>(maxLength: 5, nullable: true),
        //            LocationId = table.Column<int>(nullable: false),
        //            ParticipantCode = table.Column<int>(nullable: false),
        //            MerchantAccountId = table.Column<string>(nullable: true),
        //            TranDate = table.Column<DateTime>(nullable: false),
        //            TranTime = table.Column<string>(maxLength: 4, nullable: true),
        //            TranType4 = table.Column<string>(maxLength: 4, nullable: true),
        //            PostDate = table.Column<DateTime>(nullable: true),
        //            CardId = table.Column<int>(nullable: true),
        //            ExternalCardId = table.Column<int>(nullable: false),
        //            VehicleId = table.Column<int>(nullable: true),
        //            ExternalVehicleId = table.Column<int>(nullable: false),
        //            DriverId = table.Column<int>(nullable: true),
        //            ExternalDriverId = table.Column<int>(nullable: false),
        //            Odometer = table.Column<int>(nullable: true),
        //            Pump = table.Column<string>(maxLength: 2, nullable: true),
        //            Prod = table.Column<string>(maxLength: 4, nullable: true),
        //            ProdId = table.Column<int>(nullable: false),
        //            Price = table.Column<double>(nullable: true),
        //            AmtGal = table.Column<double>(nullable: false),
        //            PumpPrice = table.Column<double>(nullable: false),
        //            CostPerMile = table.Column<double>(nullable: true),
        //            MilesPerGallon = table.Column<double>(nullable: true),
        //            FedEx = table.Column<double>(nullable: true),
        //            StaEx = table.Column<double>(nullable: true),
        //            StaSales = table.Column<double>(nullable: true),
        //            OtherTax = table.Column<double>(nullable: true),
        //            TaxFlag = table.Column<string>(maxLength: 1, nullable: true),
        //            CaptureMethod = table.Column<string>(nullable: true),
        //            ServiceTypeIndicator = table.Column<string>(nullable: true),
        //            MicrofileRefNumber = table.Column<string>(maxLength: 15, nullable: true),
        //            ExceptionFlags = table.Column<string>(maxLength: 3, nullable: true),
        //            CustomerSalesAmount = table.Column<double>(nullable: true),
        //            UnpaidTaxes = table.Column<double>(nullable: true),
        //            StationReimbursementAmount = table.Column<double>(nullable: true),
        //            TaxArea = table.Column<string>(maxLength: 2, nullable: true),
        //            StationReimbursementActual = table.Column<double>(nullable: true),
        //            MerchantInvoiceNumber = table.Column<string>(maxLength: 8, nullable: true),
        //            Source = table.Column<string>(maxLength: 2, nullable: true),
        //            SRAExtrnlDcmntNmbr = table.Column<string>(maxLength: 80, nullable: true),
        //            FederalExciseTaxAmount = table.Column<decimal>(nullable: true),
        //            StateExciseTaxAmount = table.Column<decimal>(nullable: true),
        //            PBTAmount = table.Column<decimal>(nullable: true),
        //            SalesTaxPerGallonAmount = table.Column<decimal>(nullable: true),
        //            SalesTaxPercentAmount = table.Column<decimal>(nullable: true),
        //            PBTRate = table.Column<double>(nullable: true),
        //            SalesTaxPerGallonRate = table.Column<double>(nullable: true),
        //            SalesTaxPercentRate = table.Column<double>(nullable: true),
        //            ProductBasePrice = table.Column<double>(nullable: true),
        //            SolarcProductPrice = table.Column<double>(nullable: true),
        //            FullPrice = table.Column<double>(nullable: true),
        //            TaxLocaleId = table.Column<int>(nullable: false),
        //            VoyagerPostDate = table.Column<DateTime>(nullable: false),
        //            PerUnitCOGS = table.Column<double>(nullable: true),
        //            HourMeter = table.Column<int>(nullable: true),
        //            DriverLevel2Id = table.Column<int>(nullable: false),
        //            DriverLevel3Id = table.Column<int>(nullable: true),
        //            DriverLevel4Id = table.Column<int>(nullable: true),
        //            DriverLevel5Id = table.Column<int>(nullable: true),
        //            DriverLevel6Id = table.Column<int>(nullable: true),
        //            DriverLevel7Id = table.Column<int>(nullable: true),
        //            VehicleLevel2Id = table.Column<int>(nullable: false),
        //            VehicleLevel3Id = table.Column<int>(nullable: true),
        //            VehicleLevel4Id = table.Column<int>(nullable: true),
        //            VehicleLevel5Id = table.Column<int>(nullable: true),
        //            VehicleLevel6Id = table.Column<int>(nullable: true),
        //            VehicleLevel7Id = table.Column<int>(nullable: true),
        //            CardLevel2Id = table.Column<int>(nullable: false),
        //            CardLevel3Id = table.Column<int>(nullable: true),
        //            CardLevel4Id = table.Column<int>(nullable: true),
        //            CardLevel5Id = table.Column<int>(nullable: true),
        //            CardLevel6Id = table.Column<int>(nullable: true),
        //            CardLevel7Id = table.Column<int>(nullable: true),
        //            DriverUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            DriverUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            DriverUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            VehicleUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            VehicleUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            CardUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            CardUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            PricingLocationGroupId = table.Column<int>(nullable: true),
        //            CustomerPricingLocationGroupId = table.Column<int>(nullable: true),
        //            PriceServiceId = table.Column<int>(nullable: true),
        //            BillToOrgLevelDefinitionId = table.Column<int>(nullable: false),
        //            ShipToOrgLevelDefinitionId = table.Column<int>(nullable: false),
        //            IsRetail = table.Column<int>(nullable: false),
        //            VoyagerCardLevel2Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel3Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel4Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel5Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel6Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel7Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel2Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel3Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel4Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel5Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel6Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel7Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel2Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel3Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel4Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel5Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel6Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel7Id = table.Column<int>(nullable: false),
        //            Filename = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SmallGallonTransactions", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_SmallGallonTransactions_Customer_DriverId",
        //                column: x => x.DriverId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Vehicle",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            LockCode = table.Column<string>(maxLength: 1, nullable: true),
        //            LockDate = table.Column<DateTime>(nullable: true),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            Date1stPur = table.Column<DateTime>(nullable: true),
        //            VIN = table.Column<string>(maxLength: 17, nullable: true),
        //            VehicleLicenseTag = table.Column<string>(maxLength: 10, nullable: true),
        //            VehicleLicenseTagState = table.Column<string>(maxLength: 2, nullable: true),
        //            ExternalVehicleId = table.Column<string>(nullable: true),
        //            VehDesc = table.Column<string>(maxLength: 25, nullable: false),
        //            ProductType1 = table.Column<int>(nullable: true),
        //            Product1Capacity = table.Column<int>(nullable: false),
        //            ProductType2 = table.Column<int>(nullable: true),
        //            Product2Capacity = table.Column<int>(nullable: false),
        //            ProductCapPercentVar = table.Column<int>(nullable: true),
        //            MileageUnitsPerGallon = table.Column<int>(nullable: true),
        //            MileageUnitsOfMeasure = table.Column<string>(maxLength: 10, nullable: true),
        //            MaxGalTrn = table.Column<decimal>(nullable: true),
        //            MaxGalDay = table.Column<decimal>(nullable: true),
        //            MaxGalCycl = table.Column<decimal>(nullable: true),
        //            MaxMotorOil = table.Column<decimal>(nullable: true),
        //            LastActivityDate = table.Column<DateTime>(nullable: true),
        //            LastGallons = table.Column<decimal>(nullable: true),
        //            TheirVehicleNumber = table.Column<string>(maxLength: 20, nullable: true),
        //            VehicleType = table.Column<string>(maxLength: 2, nullable: true),
        //            UsedOnRoad = table.Column<string>(maxLength: 1, nullable: true),
        //            VehicleLevel2Id = table.Column<int>(nullable: false),
        //            VehicleLevel3Id = table.Column<int>(nullable: true),
        //            VehicleLevel4Id = table.Column<int>(nullable: true),
        //            VehicleLevel5Id = table.Column<int>(nullable: true),
        //            VehicleLevel6Id = table.Column<int>(nullable: true),
        //            VehicleLevel7Id = table.Column<int>(nullable: true),
        //            VehicleUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            VehicleUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            VehicleUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            Class = table.Column<string>(maxLength: 10, nullable: true),
        //            Odometer = table.Column<int>(nullable: true),
        //            ExternalPin = table.Column<string>(maxLength: 10, nullable: true),
        //            Pin = table.Column<int>(nullable: false),
        //            Sequence = table.Column<int>(nullable: false),
        //            Status = table.Column<int>(nullable: false),
        //            LastUseDate = table.Column<DateTime>(nullable: true),
        //            UseCount = table.Column<int>(nullable: true),
        //            MeterType = table.Column<string>(maxLength: 12, nullable: true),
        //            Qty = table.Column<decimal>(nullable: true),
        //            LastOdometer = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            Synchronized = table.Column<int>(nullable: false),
        //            LegacyProductCode1 = table.Column<string>(maxLength: 5, nullable: true),
        //            LegacyProductCode2 = table.Column<string>(maxLength: 5, nullable: true),
        //            SubmitPending = table.Column<bool>(nullable: true),
        //            ClassId = table.Column<int>(nullable: true),
        //            ExternalDeleteDate = table.Column<DateTime>(nullable: true),
        //            IsFuelMaster = table.Column<bool>(nullable: false),
        //            IsConsignment = table.Column<bool>(nullable: false),
        //            IsWinC6 = table.Column<bool>(nullable: false),
        //            IsVoyager = table.Column<bool>(nullable: false),
        //            ExistsInVoyager = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Vehicle", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Vehicle_Customer_CustomerId",
        //                column: x => x.CustomerId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CustomerGroupDetail",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            CustomerGroupId = table.Column<int>(nullable: false),
        //            IsActive = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CustomerGroupDetail", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_CustomerGroupDetail_CustomerGroup_CustomerGroupId",
        //                column: x => x.CustomerGroupId,
        //                principalTable: "CustomerGroup",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_CustomerGroupDetail_Customer_CustomerId",
        //                column: x => x.CustomerId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ExternalDatabaseDetail",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            Customerid = table.Column<int>(nullable: false),
        //            ExternalDatabaseId = table.Column<int>(nullable: false),
        //            SourceSystem = table.Column<int>(nullable: false),
        //            IsActive = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ExternalDatabaseDetail", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_ExternalDatabaseDetail_ExternalDatabase_ExternalDatabaseId",
        //                column: x => x.ExternalDatabaseId,
        //                principalTable: "ExternalDatabase",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "ImportedTransactions",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            TranNo = table.Column<string>(maxLength: 15, nullable: true),
        //            Filename = table.Column<string>(nullable: true),
        //            FileDate = table.Column<DateTime>(nullable: true),
        //            StatementDate = table.Column<DateTime>(nullable: true),
        //            NumberOfInvoices = table.Column<int>(nullable: true),
        //            ProcessDate = table.Column<DateTime>(nullable: true),
        //            MicrofilmReferenceNumber = table.Column<string>(nullable: true),
        //            MerchantName = table.Column<string>(nullable: true),
        //            MerchantAddress = table.Column<string>(nullable: true),
        //            MerchantCity = table.Column<string>(nullable: true),
        //            MerchantState = table.Column<string>(nullable: true),
        //            MerchantZip = table.Column<string>(nullable: true),
        //            MerchantZip4 = table.Column<string>(nullable: true),
        //            CustomerName = table.Column<string>(nullable: true),
        //            OrgNumber = table.Column<string>(nullable: true),
        //            CardLevel2Name = table.Column<string>(nullable: true),
        //            CardLevel3Name = table.Column<string>(nullable: true),
        //            CardLevel4Name = table.Column<string>(nullable: true),
        //            CardLevel5Name = table.Column<string>(nullable: true),
        //            CardLevel6Name = table.Column<string>(nullable: true),
        //            CardLevel7Name = table.Column<string>(nullable: true),
        //            DriverFirstName = table.Column<string>(nullable: true),
        //            DriverLastName = table.Column<string>(nullable: true),
        //            DriverMiddleInitial = table.Column<string>(nullable: true),
        //            VehicleVinNumber = table.Column<string>(nullable: true),
        //            VehicleDescription = table.Column<string>(nullable: true),
        //            VehicleLicenseTag = table.Column<string>(nullable: true),
        //            VehicleLicenseTagState = table.Column<string>(nullable: true),
        //            VehicleLevel2Name = table.Column<string>(nullable: true),
        //            VehicleLevel3Name = table.Column<string>(nullable: true),
        //            VehicleLevel4Name = table.Column<string>(nullable: true),
        //            VehicleLevel5Name = table.Column<string>(nullable: true),
        //            VehicleLevel6Name = table.Column<string>(nullable: true),
        //            VehicleLevel7Name = table.Column<string>(nullable: true),
        //            DriverLevel2Name = table.Column<string>(nullable: true),
        //            DriverLevel3Name = table.Column<string>(nullable: true),
        //            DriverLevel4Name = table.Column<string>(nullable: true),
        //            DriverLevel5Name = table.Column<string>(nullable: true),
        //            DriverLevel6Name = table.Column<string>(nullable: true),
        //            DriverLevel7Name = table.Column<string>(nullable: true),
        //            ExemptFederalTax = table.Column<double>(nullable: true),
        //            ExemptPrimaryMotorFuelTax = table.Column<double>(nullable: true),
        //            ExemptSecondaryMotorFuelTax = table.Column<double>(nullable: true),
        //            ExemptLocalSalesTax = table.Column<double>(nullable: true),
        //            ExemptStateSalesTax = table.Column<double>(nullable: true),
        //            ExemptMiscTax = table.Column<double>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            AccountLevel1Id = table.Column<int>(nullable: true),
        //            CustNo = table.Column<string>(maxLength: 5, nullable: true),
        //            LocationId = table.Column<int>(nullable: true),
        //            ParticipantCode = table.Column<int>(nullable: false),
        //            MerchantAccountId = table.Column<string>(nullable: true),
        //            TranDate = table.Column<DateTime>(nullable: true),
        //            TranTime = table.Column<string>(nullable: true),
        //            TranType4 = table.Column<string>(maxLength: 4, nullable: true),
        //            PostDate = table.Column<DateTime>(nullable: true),
        //            CardId = table.Column<int>(nullable: true),
        //            ExternalCardId = table.Column<string>(nullable: true),
        //            VehicleId = table.Column<int>(nullable: true),
        //            ExternalVehicleId = table.Column<string>(nullable: true),
        //            DriverId = table.Column<int>(nullable: true),
        //            ExternalDriverId = table.Column<string>(nullable: true),
        //            Odometer = table.Column<int>(nullable: true),
        //            Pump = table.Column<string>(maxLength: 2, nullable: true),
        //            Prod = table.Column<string>(maxLength: 4, nullable: true),
        //            ProdId = table.Column<int>(nullable: false),
        //            Price = table.Column<double>(nullable: true),
        //            AmtGal = table.Column<double>(nullable: false),
        //            TotalProductAmount = table.Column<double>(nullable: true),
        //            CostPerMile = table.Column<double>(nullable: true),
        //            MilesPerGallon = table.Column<double>(nullable: true),
        //            FedEx = table.Column<double>(nullable: true),
        //            StaEx = table.Column<double>(nullable: true),
        //            StaSales = table.Column<double>(nullable: true),
        //            OtherTax = table.Column<double>(nullable: true),
        //            TaxFlag = table.Column<string>(maxLength: 1, nullable: true),
        //            CaptureMethod = table.Column<string>(nullable: true),
        //            ServiceTypeIndicator = table.Column<string>(nullable: true),
        //            MicrofileRefNumber = table.Column<string>(maxLength: 15, nullable: true),
        //            ExceptionFlags = table.Column<string>(maxLength: 3, nullable: true),
        //            CustomerSalesAmount = table.Column<double>(nullable: true),
        //            UnpaidTaxes = table.Column<double>(nullable: true),
        //            StationReimbursementAmount = table.Column<double>(nullable: true),
        //            TaxArea = table.Column<string>(maxLength: 2, nullable: true),
        //            StationReimbursementActual = table.Column<double>(nullable: true),
        //            MerchantInvoiceNumber = table.Column<string>(maxLength: 8, nullable: true),
        //            PumpPrice = table.Column<double>(nullable: false),
        //            Source = table.Column<string>(maxLength: 2, nullable: true),
        //            SRAExtrnlDcmntNmbr = table.Column<string>(maxLength: 80, nullable: true),
        //            FederalExciseTaxAmount = table.Column<decimal>(nullable: true),
        //            StateExciseTaxAmount = table.Column<decimal>(nullable: true),
        //            PBTAmount = table.Column<decimal>(nullable: true),
        //            SalesTaxPerGallonAmount = table.Column<decimal>(nullable: true),
        //            SalesTaxPercentAmount = table.Column<decimal>(nullable: true),
        //            PBTRate = table.Column<double>(nullable: true),
        //            SalesTaxPerGallonRate = table.Column<double>(nullable: true),
        //            SalesTaxPercentRate = table.Column<double>(nullable: true),
        //            ProductBasePrice = table.Column<double>(nullable: true),
        //            SolarcProductPrice = table.Column<double>(nullable: true),
        //            FullPrice = table.Column<double>(nullable: true),
        //            VoyagerPostDate = table.Column<DateTime>(nullable: false),
        //            PerUnitCOGS = table.Column<double>(nullable: true),
        //            HourMeter = table.Column<int>(nullable: true),
        //            DriverLevel2Id = table.Column<int>(nullable: false),
        //            DriverLevel3Id = table.Column<int>(nullable: true),
        //            DriverLevel4Id = table.Column<int>(nullable: true),
        //            DriverLevel5Id = table.Column<int>(nullable: true),
        //            DriverLevel6Id = table.Column<int>(nullable: true),
        //            DriverLevel7Id = table.Column<int>(nullable: true),
        //            VehicleLevel2Id = table.Column<int>(nullable: false),
        //            VehicleLevel3Id = table.Column<int>(nullable: true),
        //            VehicleLevel4Id = table.Column<int>(nullable: true),
        //            VehicleLevel5Id = table.Column<int>(nullable: true),
        //            VehicleLevel6Id = table.Column<int>(nullable: true),
        //            VehicleLevel7Id = table.Column<int>(nullable: true),
        //            CardLevel2Id = table.Column<int>(nullable: false),
        //            CardLevel3Id = table.Column<int>(nullable: true),
        //            CardLevel4Id = table.Column<int>(nullable: true),
        //            CardLevel5Id = table.Column<int>(nullable: true),
        //            CardLevel6Id = table.Column<int>(nullable: true),
        //            CardLevel7Id = table.Column<int>(nullable: true),
        //            DriverUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            DriverUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            DriverUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            VehicleUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            VehicleUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            CardUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            CardUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            TaxLocaleId = table.Column<int>(nullable: true),
        //            PricingLocationGroupId = table.Column<int>(nullable: true),
        //            CustomerPricingLocationGroupId = table.Column<int>(nullable: true),
        //            HasMultiplePricingGroups = table.Column<bool>(nullable: false),
        //            PriceServiceId = table.Column<int>(nullable: true),
        //            IsPrepared = table.Column<int>(nullable: false),
        //            IsDuplicate = table.Column<bool>(nullable: false),
        //            HasLocationPricingGroup = table.Column<bool>(nullable: false),
        //            IsRetailCustomer = table.Column<bool>(nullable: false),
        //            HasCustomerLocationPricingGroup = table.Column<bool>(nullable: false),
        //            BillToOrgLevelDefinitionId = table.Column<int>(nullable: false),
        //            ShipToOrgLevelDefinitionId = table.Column<int>(nullable: false),
        //            IsRetail = table.Column<int>(nullable: false),
        //            VoyagerCardId = table.Column<string>(nullable: true),
        //            VoyagerDriverId = table.Column<string>(nullable: true),
        //            VoyagerVehicleId = table.Column<string>(nullable: true),
        //            VoyagerCardLevel2Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel3Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel4Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel5Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel6Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel7Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel2Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel3Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel4Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel5Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel6Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel7Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel2Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel3Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel4Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel5Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel6Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel7Id = table.Column<int>(nullable: false),
        //            SiteNumber = table.Column<int>(nullable: false),
        //            Sequence = table.Column<int>(nullable: false),
        //            PurchaseOrderNumber = table.Column<string>(maxLength: 30, nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_ImportedTransactions", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_ImportedTransactions_Location_LocationId",
        //                column: x => x.LocationId,
        //                principalTable: "Location",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "LocationPricingLocationGroup",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            LocationId = table.Column<int>(nullable: true),
        //            PricingLocationGroupId = table.Column<int>(nullable: true),
        //            FromDate = table.Column<DateTime>(nullable: false),
        //            ToDate = table.Column<DateTime>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_LocationPricingLocationGroup", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_LocationPricingLocationGroup_Location_LocationId",
        //                column: x => x.LocationId,
        //                principalTable: "Location",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_LocationPricingLocationGroup_PricingLocationGroup_PricingLocationGroupId",
        //                column: x => x.PricingLocationGroupId,
        //                principalTable: "PricingLocationGroup",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SiteProduct",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            LocationId = table.Column<int>(nullable: false),
        //            SiteId = table.Column<int>(nullable: false),
        //            ProductId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SiteProduct", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_SiteProduct_Location_LocationId",
        //                column: x => x.LocationId,
        //                principalTable: "Location",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_SiteProduct_Product_ProductId",
        //                column: x => x.ProductId,
        //                principalTable: "Product",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_SiteProduct_Sites_SiteId",
        //                column: x => x.SiteId,
        //                principalTable: "Sites",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CustomerStateLocation",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            StateId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CustomerStateLocation", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_CustomerStateLocation_Customer_CustomerId",
        //                column: x => x.CustomerId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_CustomerStateLocation_State_StateId",
        //                column: x => x.StateId,
        //                principalTable: "State",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AuditDetail",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            AuditId = table.Column<int>(nullable: false),
        //            AuditDataTypeId = table.Column<int>(nullable: false),
        //            Key = table.Column<string>(nullable: true),
        //            Value = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AuditDetail", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_AuditDetail_AuditDataType_AuditDataTypeId",
        //                column: x => x.AuditDataTypeId,
        //                principalTable: "AuditDataType",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_AuditDetail_Audit_AuditId",
        //                column: x => x.AuditId,
        //                principalTable: "Audit",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "AuditHistoryDetail",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            AuditHistoryId = table.Column<int>(nullable: false),
        //            AuditDataTypeId = table.Column<int>(nullable: false),
        //            Key = table.Column<string>(nullable: true),
        //            Value = table.Column<string>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_AuditHistoryDetail", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_AuditHistoryDetail_AuditDataType_AuditDataTypeId",
        //                column: x => x.AuditDataTypeId,
        //                principalTable: "AuditDataType",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_AuditHistoryDetail_AuditHistory_AuditHistoryId",
        //                column: x => x.AuditHistoryId,
        //                principalTable: "AuditHistory",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Card",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            LockCode = table.Column<string>(maxLength: 1, nullable: true),
        //            LockDate = table.Column<DateTime>(nullable: true),
        //            ExternalCardId = table.Column<string>(nullable: true),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            CardType = table.Column<int>(nullable: false),
        //            CardNo = table.Column<int>(nullable: true),
        //            TheirCardNumber = table.Column<string>(maxLength: 20, nullable: true),
        //            EmbossedCardNumber = table.Column<string>(maxLength: 15, nullable: true),
        //            EmbossingElement1 = table.Column<int>(nullable: false),
        //            EmbossingElement2 = table.Column<int>(nullable: false),
        //            EmbossingElement3 = table.Column<int>(nullable: false),
        //            EmbossLine1 = table.Column<string>(nullable: true),
        //            EmbossLine2 = table.Column<string>(nullable: true),
        //            EmbossLine3 = table.Column<string>(nullable: true),
        //            EntityType = table.Column<int>(nullable: false),
        //            Date1stPur = table.Column<DateTime>(nullable: true),
        //            MaxGalTrn = table.Column<decimal>(nullable: true),
        //            MaxGalDay = table.Column<decimal>(nullable: true),
        //            MaxGalCycl = table.Column<decimal>(nullable: true),
        //            MaxMotorOil = table.Column<decimal>(nullable: true),
        //            LastActivityDate = table.Column<DateTime>(nullable: true),
        //            LastGallons = table.Column<decimal>(nullable: true),
        //            CardLevel2Id = table.Column<int>(nullable: false),
        //            CardLevel3Id = table.Column<int>(nullable: true),
        //            CardLevel4Id = table.Column<int>(nullable: true),
        //            CardLevel5Id = table.Column<int>(nullable: true),
        //            CardLevel6Id = table.Column<int>(nullable: true),
        //            CardLevel7Id = table.Column<int>(nullable: true),
        //            CardUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            CardUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            CardUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            ProductUse = table.Column<int>(nullable: false),
        //            TransactionDollarLimit = table.Column<int>(nullable: true),
        //            TransactionDollarLimitMode = table.Column<int>(nullable: false),
        //            DailyDollarLimit = table.Column<int>(nullable: true),
        //            DailyDollarLimitMode = table.Column<int>(nullable: false),
        //            WeeklyDollarLimit = table.Column<int>(nullable: true),
        //            WeeklyDollarLimitMode = table.Column<int>(nullable: false),
        //            MonthlyDollarLimit = table.Column<int>(nullable: true),
        //            MonthlyDollarLimitMode = table.Column<int>(nullable: false),
        //            DailyTransactionLimit = table.Column<int>(nullable: true),
        //            DailyTransactionLimitMode = table.Column<int>(nullable: false),
        //            WeeklyTransactionLimit = table.Column<int>(nullable: true),
        //            WeeklyTransactionLimitMode = table.Column<int>(nullable: false),
        //            MonthlyTransactionLimit = table.Column<int>(nullable: true),
        //            MonthlyTransactionLimitMode = table.Column<int>(nullable: false),
        //            PurchaseDay = table.Column<int>(nullable: false),
        //            PurchaseDayMode = table.Column<int>(nullable: false),
        //            PurchaseFromTimeBand1 = table.Column<DateTime>(nullable: true),
        //            PurchaseToTimeBand1 = table.Column<DateTime>(nullable: true),
        //            PurchaseTimeBand1Mode = table.Column<int>(nullable: true),
        //            PurchaseFromTimeBand2 = table.Column<DateTime>(nullable: true),
        //            PurchaseToTimeBand2 = table.Column<DateTime>(nullable: true),
        //            PurchaseTimeBand2Mode = table.Column<int>(nullable: true),
        //            OdometerValidation = table.Column<int>(nullable: false),
        //            OdometerLimit = table.Column<int>(nullable: true),
        //            OdometerValidationMode = table.Column<int>(nullable: false),
        //            Status = table.Column<int>(nullable: false),
        //            LastUseDate = table.Column<DateTime>(nullable: true),
        //            UseCount = table.Column<int>(nullable: true),
        //            QTY = table.Column<decimal>(nullable: true),
        //            LastOdometer = table.Column<DateTime>(nullable: true),
        //            DriverId = table.Column<int>(nullable: true),
        //            VehicleId = table.Column<int>(nullable: true),
        //            CardExpirationDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            DAMCardStatusIndicator = table.Column<int>(nullable: false),
        //            CardPromptPattern = table.Column<int>(nullable: false),
        //            PinNumber = table.Column<int>(nullable: true),
        //            CardAddressId = table.Column<int>(nullable: true),
        //            RestrictionCode = table.Column<int>(nullable: false),
        //            Synchronized = table.Column<int>(nullable: false),
        //            SubmitPending = table.Column<bool>(nullable: true),
        //            ClassId = table.Column<int>(nullable: true),
        //            CardClassId = table.Column<int>(nullable: true),
        //            IsConsignment = table.Column<bool>(nullable: false),
        //            FormerVehicleId = table.Column<int>(nullable: false),
        //            FormerDriverId = table.Column<int>(nullable: false),
        //            ExternalDeleteDate = table.Column<DateTime>(nullable: true),
        //            IsFuelMaster = table.Column<bool>(nullable: false),
        //            IsWinC6 = table.Column<bool>(nullable: false),
        //            IsVoyager = table.Column<bool>(nullable: false),
        //            ExistsInVoyager = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Card", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Card_CardClass_ClassId",
        //                column: x => x.ClassId,
        //                principalTable: "CardClass",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Card_Customer_CustomerId",
        //                column: x => x.CustomerId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_Card_Customer_DriverId",
        //                column: x => x.DriverId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Card_Vehicle_VehicleId",
        //                column: x => x.VehicleId,
        //                principalTable: "Vehicle",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "CardImport",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            LockCode = table.Column<string>(maxLength: 1, nullable: true),
        //            LockDate = table.Column<DateTime>(nullable: true),
        //            ExternalCardId = table.Column<int>(nullable: false),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            CardNo = table.Column<string>(maxLength: 10, nullable: true),
        //            TheirCardNumber = table.Column<string>(maxLength: 20, nullable: true),
        //            EmbossedCardNumber = table.Column<string>(maxLength: 15, nullable: true),
        //            EntityType = table.Column<int>(nullable: false),
        //            Date1stPur = table.Column<DateTime>(nullable: true),
        //            MaxGalTrn = table.Column<decimal>(nullable: true),
        //            MaxGalDay = table.Column<decimal>(nullable: true),
        //            MaxGalCycl = table.Column<decimal>(nullable: true),
        //            MaxMotorOil = table.Column<decimal>(nullable: true),
        //            LastActivityDate = table.Column<DateTime>(nullable: true),
        //            LastGallons = table.Column<decimal>(nullable: true),
        //            CardLevel2Id = table.Column<int>(nullable: false),
        //            CardLevel3Id = table.Column<int>(nullable: true),
        //            CardLevel4Id = table.Column<int>(nullable: true),
        //            CardLevel5Id = table.Column<int>(nullable: true),
        //            CardLevel6Id = table.Column<int>(nullable: true),
        //            CardLevel7Id = table.Column<int>(nullable: true),
        //            CardUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            CardUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            CardUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            ProductUse = table.Column<int>(nullable: false),
        //            TransactionDollarLimit = table.Column<int>(nullable: true),
        //            TransactionDollarLimitMode = table.Column<int>(nullable: true),
        //            DailyDollarLimit = table.Column<int>(nullable: true),
        //            DailyDollarLimitMode = table.Column<int>(nullable: true),
        //            WeeklyDollarLimit = table.Column<int>(nullable: true),
        //            WeeklyDollarLimitMode = table.Column<int>(nullable: true),
        //            MonthlyDollarLimit = table.Column<int>(nullable: true),
        //            MonthlyDollarLimitMode = table.Column<int>(nullable: true),
        //            DailyTransactionLimit = table.Column<int>(nullable: true),
        //            DailyTransactionLimitMode = table.Column<int>(nullable: true),
        //            WeeklyTransactionLimit = table.Column<int>(nullable: true),
        //            WeeklyTransactionLimitMode = table.Column<int>(nullable: true),
        //            MonthlyTransactionLimit = table.Column<int>(nullable: true),
        //            MonthlyTransactionLimitMode = table.Column<int>(nullable: true),
        //            PurchaseDay = table.Column<int>(nullable: false),
        //            PurchaseDayMode = table.Column<int>(nullable: true),
        //            PurchaseFromTimeBand1 = table.Column<DateTime>(nullable: true),
        //            PurchaseToTimeBand1 = table.Column<DateTime>(nullable: true),
        //            PurchaseTimeBand1Mode = table.Column<int>(nullable: true),
        //            PurchaseFromTimeBand2 = table.Column<DateTime>(nullable: true),
        //            PurchaseToTimeBand2 = table.Column<DateTime>(nullable: true),
        //            PurchaseTimeBand2Mode = table.Column<int>(nullable: true),
        //            OdometerValidation = table.Column<int>(nullable: false),
        //            OdometerLimit = table.Column<int>(nullable: true),
        //            OdometerValidationMode = table.Column<int>(nullable: true),
        //            Status = table.Column<int>(nullable: false),
        //            LastUseDate = table.Column<DateTime>(nullable: true),
        //            UseCount = table.Column<int>(nullable: true),
        //            QTY = table.Column<decimal>(nullable: true),
        //            LastOdometer = table.Column<DateTime>(nullable: true),
        //            DriverId = table.Column<int>(nullable: true),
        //            VehicleId = table.Column<int>(nullable: true),
        //            CardExpirationDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            DAMCardStatusIndicator = table.Column<int>(nullable: true),
        //            CardPromptPattern = table.Column<int>(nullable: false),
        //            PinNumber = table.Column<int>(nullable: true),
        //            RestrictionCode = table.Column<int>(nullable: false),
        //            CardType = table.Column<string>(maxLength: 25, nullable: true),
        //            Dept = table.Column<string>(nullable: true),
        //            Synchronized = table.Column<int>(nullable: false),
        //            SyncStatus = table.Column<int>(nullable: false),
        //            VehicleImportId = table.Column<int>(nullable: true),
        //            ClassId = table.Column<int>(nullable: true),
        //            CopyRecord = table.Column<bool>(nullable: false),
        //            IsConsignment = table.Column<bool>(nullable: false),
        //            FormerVehicleId = table.Column<int>(nullable: false),
        //            FormerDriverId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_CardImport", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_CardImport_CardClass_ClassId",
        //                column: x => x.ClassId,
        //                principalTable: "CardClass",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_CardImport_Customer_DriverId",
        //                column: x => x.DriverId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_CardImport_Vehicle_VehicleId",
        //                column: x => x.VehicleId,
        //                principalTable: "Vehicle",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_CardImport_VehicleImport_VehicleImportId",
        //                column: x => x.VehicleImportId,
        //                principalTable: "VehicleImport",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DAMVehicle",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            EntityId = table.Column<int>(nullable: false),
        //            DAMAction = table.Column<int>(nullable: false),
        //            DAMStatus = table.Column<int>(nullable: false),
        //            HasDataChange = table.Column<int>(nullable: false),
        //            CustomerId = table.Column<int>(nullable: false),
        //            ControlNumber = table.Column<int>(nullable: false),
        //            SequenceNumber = table.Column<int>(nullable: false),
        //            ErrorCode1 = table.Column<string>(nullable: true),
        //            ErrorCode2 = table.Column<string>(nullable: true),
        //            ErrorCode3 = table.Column<string>(nullable: true),
        //            ErrorCode4 = table.Column<string>(nullable: true),
        //            ErrorCode1Description = table.Column<string>(nullable: true),
        //            ErrorCode2Description = table.Column<string>(nullable: true),
        //            ErrorCode3Description = table.Column<string>(nullable: true),
        //            ErrorCode4Description = table.Column<string>(nullable: true),
        //            VehicleId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DAMVehicle", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_DAMVehicle_Customer_CustomerId",
        //                column: x => x.CustomerId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_DAMVehicle_Vehicle_EntityId",
        //                column: x => x.EntityId,
        //                principalTable: "Vehicle",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "SyncCard",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CardId = table.Column<int>(nullable: false),
        //            LockCode = table.Column<string>(maxLength: 1, nullable: true),
        //            LockDate = table.Column<DateTime>(nullable: true),
        //            ExternalCardId = table.Column<int>(nullable: false),
        //            AccountNumber = table.Column<int>(nullable: false),
        //            CardNo = table.Column<int>(nullable: true),
        //            TheirCardNumber = table.Column<string>(nullable: true),
        //            EntityType = table.Column<int>(nullable: false),
        //            Date1stPur = table.Column<DateTime>(nullable: true),
        //            MaxGalTrn = table.Column<decimal>(nullable: true),
        //            MaxGalDay = table.Column<decimal>(nullable: true),
        //            MaxGalCycl = table.Column<decimal>(nullable: true),
        //            MaxMotorOil = table.Column<decimal>(nullable: true),
        //            LastActivityDate = table.Column<DateTime>(nullable: true),
        //            LastGallons = table.Column<decimal>(nullable: true),
        //            CardLevel2Id = table.Column<int>(nullable: false),
        //            CardLevel3Id = table.Column<int>(nullable: true),
        //            CardLevel4Id = table.Column<int>(nullable: true),
        //            CardLevel5Id = table.Column<int>(nullable: true),
        //            CardLevel6Id = table.Column<int>(nullable: true),
        //            CardLevel7Id = table.Column<int>(nullable: true),
        //            CardUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            CardUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            CardUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            ProductUse = table.Column<int>(nullable: false),
        //            TransactionDollarLimit = table.Column<int>(nullable: true),
        //            TransactionDollarLimitMode = table.Column<int>(nullable: true),
        //            DailyDollarLimit = table.Column<int>(nullable: true),
        //            DailyDollarLimitMode = table.Column<int>(nullable: true),
        //            WeeklyDollarLimit = table.Column<int>(nullable: true),
        //            WeeklyDollarLimitMode = table.Column<int>(nullable: true),
        //            MonthlyDollarLimit = table.Column<int>(nullable: true),
        //            MonthlyDollarLimitMode = table.Column<int>(nullable: true),
        //            DailyTransactionLimit = table.Column<int>(nullable: true),
        //            DailyTransactionLimitMode = table.Column<int>(nullable: true),
        //            WeeklyTransactionLimit = table.Column<int>(nullable: true),
        //            WeeklyTransactionLimitMode = table.Column<int>(nullable: true),
        //            MonthlyTransactionLimit = table.Column<int>(nullable: true),
        //            MonthlyTransactionLimitMode = table.Column<int>(nullable: true),
        //            PurchaseDay = table.Column<int>(nullable: false),
        //            PurchaseDayMode = table.Column<int>(nullable: true),
        //            PurchaseFromTimeBand1 = table.Column<DateTime>(nullable: true),
        //            PurchaseToTimeBand1 = table.Column<DateTime>(nullable: true),
        //            PurchaseDayBand1Mode = table.Column<int>(nullable: true),
        //            PurchaseFromTimeBand2 = table.Column<DateTime>(nullable: true),
        //            PurchaseToTimeBand2 = table.Column<DateTime>(nullable: true),
        //            PurchaseDayBand2Mode = table.Column<int>(nullable: true),
        //            OdometerValidation = table.Column<int>(nullable: false),
        //            OdometerLimit = table.Column<int>(nullable: true),
        //            OdometerLimitMode = table.Column<int>(nullable: true),
        //            LastUseDate = table.Column<DateTime>(nullable: true),
        //            UseCount = table.Column<int>(nullable: true),
        //            QTY = table.Column<decimal>(nullable: true),
        //            LastOdometer = table.Column<DateTime>(nullable: true),
        //            DriverId = table.Column<int>(nullable: true),
        //            VehicleId = table.Column<int>(nullable: true),
        //            CardExpirationDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            CardStatusIndicator = table.Column<int>(nullable: false),
        //            CardPromptPattern = table.Column<int>(nullable: false),
        //            PinNumber = table.Column<int>(nullable: true)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_SyncCard", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_SyncCard_Customer_DriverId",
        //                column: x => x.DriverId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_SyncCard_Vehicle_VehicleId",
        //                column: x => x.VehicleId,
        //                principalTable: "Vehicle",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TransactionErrorDetail",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            ImportedTransactionId = table.Column<int>(nullable: true),
        //            TransactionErrorId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_TransactionErrorDetail", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_TransactionErrorDetail_ImportedTransactions_ImportedTransactionId",
        //                column: x => x.ImportedTransactionId,
        //                principalTable: "ImportedTransactions",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_TransactionErrorDetail_TransactionError_TransactionErrorId",
        //                column: x => x.TransactionErrorId,
        //                principalTable: "TransactionError",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "DAMCard",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            EntityType = table.Column<int>(nullable: false),
        //            EntityId = table.Column<int>(nullable: false),
        //            DAMAction = table.Column<int>(nullable: false),
        //            DAMStatus = table.Column<int>(nullable: false),
        //            DAMCardStatusIndicator = table.Column<int>(nullable: true),
        //            HasDataChange = table.Column<int>(nullable: false),
        //            CustomerId = table.Column<int>(nullable: false),
        //            ControlNumber = table.Column<int>(nullable: false),
        //            SequenceNumber = table.Column<int>(nullable: false),
        //            ErrorCode1 = table.Column<string>(nullable: true),
        //            ErrorCode2 = table.Column<string>(nullable: true),
        //            ErrorCode3 = table.Column<string>(nullable: true),
        //            ErrorCode4 = table.Column<string>(nullable: true),
        //            ErrorCode1Description = table.Column<string>(nullable: true),
        //            ErrorCode2Description = table.Column<string>(nullable: true),
        //            ErrorCode3Description = table.Column<string>(nullable: true),
        //            ErrorCode4Description = table.Column<string>(nullable: true),
        //            CardId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_DAMCard", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_DAMCard_Customer_CustomerId",
        //                column: x => x.CustomerId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_DAMCard_Card_EntityId",
        //                column: x => x.EntityId,
        //                principalTable: "Card",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "Transactions",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            TranNo = table.Column<string>(maxLength: 15, nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            AccountNumber = table.Column<int>(nullable: true),
        //            AccountLevel1Id = table.Column<int>(nullable: true),
        //            CustNo = table.Column<string>(maxLength: 5, nullable: true),
        //            LocationId = table.Column<int>(nullable: false),
        //            ParticipantCode = table.Column<int>(nullable: false),
        //            MerchantAccountId = table.Column<string>(nullable: true),
        //            TranDate = table.Column<DateTime>(nullable: false),
        //            TranTime = table.Column<string>(maxLength: 4, nullable: true),
        //            TranType4 = table.Column<string>(maxLength: 4, nullable: true),
        //            PostDate = table.Column<DateTime>(nullable: true),
        //            CardId = table.Column<int>(nullable: true),
        //            ExternalCardId = table.Column<string>(nullable: true),
        //            VehicleId = table.Column<int>(nullable: true),
        //            ExternalVehicleId = table.Column<string>(nullable: true),
        //            DriverId = table.Column<int>(nullable: true),
        //            ExternalDriverId = table.Column<string>(nullable: true),
        //            Odometer = table.Column<int>(nullable: true),
        //            Pump = table.Column<string>(maxLength: 2, nullable: true),
        //            Prod = table.Column<string>(maxLength: 4, nullable: true),
        //            ProdId = table.Column<int>(nullable: false),
        //            Price = table.Column<double>(nullable: true),
        //            AmtGal = table.Column<double>(nullable: false),
        //            PumpPrice = table.Column<double>(nullable: false),
        //            CostPerMile = table.Column<double>(nullable: true),
        //            MilesPerGallon = table.Column<double>(nullable: true),
        //            FedEx = table.Column<double>(nullable: true),
        //            StaEx = table.Column<double>(nullable: true),
        //            StaSales = table.Column<double>(nullable: true),
        //            OtherTax = table.Column<double>(nullable: true),
        //            TaxFlag = table.Column<string>(maxLength: 1, nullable: true),
        //            CaptureMethod = table.Column<string>(nullable: true),
        //            ServiceTypeIndicator = table.Column<string>(nullable: true),
        //            MicrofileRefNumber = table.Column<string>(maxLength: 15, nullable: true),
        //            ExceptionFlags = table.Column<string>(maxLength: 3, nullable: true),
        //            CustomerSalesAmount = table.Column<double>(nullable: true),
        //            UnpaidTaxes = table.Column<double>(nullable: true),
        //            StationReimbursementAmount = table.Column<double>(nullable: true),
        //            TaxArea = table.Column<string>(maxLength: 2, nullable: true),
        //            StationReimbursementActual = table.Column<double>(nullable: true),
        //            MerchantInvoiceNumber = table.Column<string>(maxLength: 8, nullable: true),
        //            Source = table.Column<string>(maxLength: 2, nullable: true),
        //            SRAExtrnlDcmntNmbr = table.Column<string>(maxLength: 80, nullable: true),
        //            FederalExciseTaxAmount = table.Column<decimal>(nullable: true),
        //            StateExciseTaxAmount = table.Column<decimal>(nullable: true),
        //            PBTAmount = table.Column<decimal>(nullable: true),
        //            SalesTaxPerGallonAmount = table.Column<decimal>(nullable: true),
        //            SalesTaxPercentAmount = table.Column<decimal>(nullable: true),
        //            PBTRate = table.Column<double>(nullable: true),
        //            SalesTaxPerGallonRate = table.Column<double>(nullable: true),
        //            SalesTaxPercentRate = table.Column<double>(nullable: true),
        //            ProductBasePrice = table.Column<double>(nullable: true),
        //            SolarcProductPrice = table.Column<double>(nullable: true),
        //            FullPrice = table.Column<double>(nullable: true),
        //            TaxLocaleId = table.Column<int>(nullable: false),
        //            VoyagerPostDate = table.Column<DateTime>(nullable: false),
        //            PerUnitCOGS = table.Column<double>(nullable: true),
        //            HourMeter = table.Column<int>(nullable: true),
        //            DriverLevel2Id = table.Column<int>(nullable: false),
        //            DriverLevel3Id = table.Column<int>(nullable: true),
        //            DriverLevel4Id = table.Column<int>(nullable: true),
        //            DriverLevel5Id = table.Column<int>(nullable: true),
        //            DriverLevel6Id = table.Column<int>(nullable: true),
        //            DriverLevel7Id = table.Column<int>(nullable: true),
        //            VehicleLevel2Id = table.Column<int>(nullable: false),
        //            VehicleLevel3Id = table.Column<int>(nullable: true),
        //            VehicleLevel4Id = table.Column<int>(nullable: true),
        //            VehicleLevel5Id = table.Column<int>(nullable: true),
        //            VehicleLevel6Id = table.Column<int>(nullable: true),
        //            VehicleLevel7Id = table.Column<int>(nullable: true),
        //            CardLevel2Id = table.Column<int>(nullable: false),
        //            CardLevel3Id = table.Column<int>(nullable: true),
        //            CardLevel4Id = table.Column<int>(nullable: true),
        //            CardLevel5Id = table.Column<int>(nullable: true),
        //            CardLevel6Id = table.Column<int>(nullable: true),
        //            CardLevel7Id = table.Column<int>(nullable: true),
        //            DriverUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            DriverUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            DriverUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            DriverUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            VehicleUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            VehicleUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            VehicleUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode1 = table.Column<string>(maxLength: 13, nullable: true),
        //            CardUserCode2 = table.Column<string>(maxLength: 10, nullable: true),
        //            CardUserCode3 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode4 = table.Column<string>(maxLength: 8, nullable: true),
        //            CardUserCode5 = table.Column<string>(maxLength: 8, nullable: true),
        //            PricingLocationGroupId = table.Column<int>(nullable: true),
        //            CustomerPricingLocationGroupId = table.Column<int>(nullable: true),
        //            PriceServiceId = table.Column<int>(nullable: true),
        //            BillToOrgLevelDefinitionId = table.Column<int>(nullable: false),
        //            ShipToOrgLevelDefinitionId = table.Column<int>(nullable: false),
        //            IsRetail = table.Column<int>(nullable: false),
        //            VoyagerCardLevel2Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel3Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel4Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel5Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel6Id = table.Column<int>(nullable: false),
        //            VoyagerCardLevel7Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel2Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel3Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel4Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel5Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel6Id = table.Column<int>(nullable: false),
        //            VoyagerVehicleLevel7Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel2Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel3Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel4Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel5Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel6Id = table.Column<int>(nullable: false),
        //            VoyagerDriverLevel7Id = table.Column<int>(nullable: false),
        //            Filename = table.Column<string>(nullable: true),
        //            SiteNumber = table.Column<int>(nullable: false),
        //            Sequence = table.Column<int>(nullable: false),
        //            PurchaseOrderNumber = table.Column<string>(maxLength: 30, nullable: true),
        //            ExceptionsProcessed = table.Column<bool>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_Transactions", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_Transactions_Card_CardId",
        //                column: x => x.CardId,
        //                principalTable: "Card",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Transactions_Customer_CustomerId",
        //                column: x => x.CustomerId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_Transactions_Customer_DriverId",
        //                column: x => x.DriverId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //            table.ForeignKey(
        //                name: "FK_Transactions_Location_LocationId",
        //                column: x => x.LocationId,
        //                principalTable: "Location",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_Transactions_Product_ProdId",
        //                column: x => x.ProdId,
        //                principalTable: "Product",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_Transactions_Vehicle_VehicleId",
        //                column: x => x.VehicleId,
        //                principalTable: "Vehicle",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Restrict);
        //        });

        //    migrationBuilder.CreateTable(
        //        name: "TransactionExceptionDetail",
        //        columns: table => new
        //        {
        //            Id = table.Column<int>(nullable: false)
        //                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
        //            CreatedByUserId = table.Column<int>(nullable: false),
        //            CreatedDate = table.Column<DateTime>(nullable: false),
        //            RowVersion = table.Column<byte[]>(rowVersion: true, nullable: true),
        //            UniqueIdentifier = table.Column<Guid>(nullable: false),
        //            UpdatedByUserId = table.Column<int>(nullable: true),
        //            UpdatedDate = table.Column<DateTime>(nullable: true),
        //            CustomerId = table.Column<int>(nullable: false),
        //            TransactionId = table.Column<int>(nullable: false),
        //            TransactionDate = table.Column<DateTime>(nullable: false),
        //            TransactionExceptionId = table.Column<int>(nullable: false)
        //        },
        //        constraints: table =>
        //        {
        //            table.PrimaryKey("PK_TransactionExceptionDetail", x => x.Id);
        //            table.ForeignKey(
        //                name: "FK_TransactionExceptionDetail_Customer_CustomerId",
        //                column: x => x.CustomerId,
        //                principalTable: "Customer",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_TransactionExceptionDetail_TransactionException_TransactionExceptionId",
        //                column: x => x.TransactionExceptionId,
        //                principalTable: "TransactionException",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //            table.ForeignKey(
        //                name: "FK_TransactionExceptionDetail_Transactions_TransactionId",
        //                column: x => x.TransactionId,
        //                principalTable: "Transactions",
        //                principalColumn: "Id",
        //                onDelete: ReferentialAction.Cascade);
        //        });

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetRoleClaims_RoleId",
        //        table: "AspNetRoleClaims",
        //        column: "RoleId");

        //    migrationBuilder.CreateIndex(
        //        name: "RoleNameIndex",
        //        table: "AspNetRoles",
        //        column: "NormalizedName",
        //        unique: true,
        //        filter: "[NormalizedName] IS NOT NULL");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserClaims_UserId",
        //        table: "AspNetUserClaims",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserLogins_UserId",
        //        table: "AspNetUserLogins",
        //        column: "UserId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AspNetUserRoles_RoleId",
        //        table: "AspNetUserRoles",
        //        column: "RoleId");

        //    migrationBuilder.CreateIndex(
        //        name: "EmailIndex",
        //        table: "AspNetUsers",
        //        column: "NormalizedEmail");

        //    migrationBuilder.CreateIndex(
        //        name: "UserNameIndex",
        //        table: "AspNetUsers",
        //        column: "NormalizedUserName",
        //        unique: true,
        //        filter: "[NormalizedUserName] IS NOT NULL");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Audit_AuditEventId",
        //        table: "Audit",
        //        column: "AuditEventId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AuditDetail_AuditDataTypeId",
        //        table: "AuditDetail",
        //        column: "AuditDataTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AuditDetail_AuditId",
        //        table: "AuditDetail",
        //        column: "AuditId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AuditHistory_AuditEventId",
        //        table: "AuditHistory",
        //        column: "AuditEventId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AuditHistoryDetail_AuditDataTypeId",
        //        table: "AuditHistoryDetail",
        //        column: "AuditDataTypeId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_AuditHistoryDetail_AuditHistoryId",
        //        table: "AuditHistoryDetail",
        //        column: "AuditHistoryId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Card_ClassId",
        //        table: "Card",
        //        column: "ClassId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Card_CustomerId",
        //        table: "Card",
        //        column: "CustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Card_DriverId",
        //        table: "Card",
        //        column: "DriverId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Card_VehicleId",
        //        table: "Card",
        //        column: "VehicleId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CardImport_ClassId",
        //        table: "CardImport",
        //        column: "ClassId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CardImport_DriverId",
        //        table: "CardImport",
        //        column: "DriverId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CardImport_VehicleId",
        //        table: "CardImport",
        //        column: "VehicleId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CardImport_VehicleImportId",
        //        table: "CardImport",
        //        column: "VehicleImportId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CustomerCardCategory_CardCategoryId",
        //        table: "CustomerCardCategory",
        //        column: "CardCategoryId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CustomerCardCategory_CustomerId",
        //        table: "CustomerCardCategory",
        //        column: "CustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CustomerGroupDetail_CustomerGroupId",
        //        table: "CustomerGroupDetail",
        //        column: "CustomerGroupId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CustomerGroupDetail_CustomerId",
        //        table: "CustomerGroupDetail",
        //        column: "CustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CustomerMerchantLocation_CustomerId",
        //        table: "CustomerMerchantLocation",
        //        column: "CustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CustomerStateLocation_CustomerId",
        //        table: "CustomerStateLocation",
        //        column: "CustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CustomerStateLocation_StateId",
        //        table: "CustomerStateLocation",
        //        column: "StateId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_CustomerZipCodeLocation_CustomerId",
        //        table: "CustomerZipCodeLocation",
        //        column: "CustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_DAMCard_CustomerId",
        //        table: "DAMCard",
        //        column: "CustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_DAMCard_EntityId",
        //        table: "DAMCard",
        //        column: "EntityId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_DAMDriver_CustomerId",
        //        table: "DAMDriver",
        //        column: "CustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_DAMDriver_EntityId",
        //        table: "DAMDriver",
        //        column: "EntityId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_DAMVehicle_CustomerId",
        //        table: "DAMVehicle",
        //        column: "CustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_DAMVehicle_EntityId",
        //        table: "DAMVehicle",
        //        column: "EntityId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Driver_CustomerId",
        //        table: "Driver",
        //        column: "CustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ExternalDatabaseDetail_ExternalDatabaseId",
        //        table: "ExternalDatabaseDetail",
        //        column: "ExternalDatabaseId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_ImportedTransactions_LocationId",
        //        table: "ImportedTransactions",
        //        column: "LocationId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_LocationPricingLocationGroup_LocationId",
        //        table: "LocationPricingLocationGroup",
        //        column: "LocationId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_LocationPricingLocationGroup_PricingLocationGroupId",
        //        table: "LocationPricingLocationGroup",
        //        column: "PricingLocationGroupId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SendTransactionsErrorLog_DriverId",
        //        table: "SendTransactionsErrorLog",
        //        column: "DriverId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SiteProduct_LocationId",
        //        table: "SiteProduct",
        //        column: "LocationId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SiteProduct_ProductId",
        //        table: "SiteProduct",
        //        column: "ProductId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SiteProduct_SiteId",
        //        table: "SiteProduct",
        //        column: "SiteId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SmallGallonTransactions_DriverId",
        //        table: "SmallGallonTransactions",
        //        column: "DriverId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SyncCard_DriverId",
        //        table: "SyncCard",
        //        column: "DriverId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_SyncCard_VehicleId",
        //        table: "SyncCard",
        //        column: "VehicleId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_TransactionErrorDetail_ImportedTransactionId",
        //        table: "TransactionErrorDetail",
        //        column: "ImportedTransactionId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_TransactionErrorDetail_TransactionErrorId",
        //        table: "TransactionErrorDetail",
        //        column: "TransactionErrorId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_TransactionExceptionDetail_CustomerId",
        //        table: "TransactionExceptionDetail",
        //        column: "CustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_TransactionExceptionDetail_TransactionExceptionId",
        //        table: "TransactionExceptionDetail",
        //        column: "TransactionExceptionId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_TransactionExceptionDetail_TransactionId",
        //        table: "TransactionExceptionDetail",
        //        column: "TransactionId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Transactions_CardId",
        //        table: "Transactions",
        //        column: "CardId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Transactions_CustomerId",
        //        table: "Transactions",
        //        column: "CustomerId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Transactions_DriverId",
        //        table: "Transactions",
        //        column: "DriverId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Transactions_LocationId",
        //        table: "Transactions",
        //        column: "LocationId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Transactions_ProdId",
        //        table: "Transactions",
        //        column: "ProdId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Transactions_VehicleId",
        //        table: "Transactions",
        //        column: "VehicleId");

        //    migrationBuilder.CreateIndex(
        //        name: "IX_Vehicle_CustomerId",
        //        table: "Vehicle",
        //        column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AuditDetail");

            migrationBuilder.DropTable(
                name: "AuditHistoryDetail");

            migrationBuilder.DropTable(
                name: "BusinessAssociate");

            migrationBuilder.DropTable(
                name: "BusinessHours");

            migrationBuilder.DropTable(
                name: "CardAddress");

            migrationBuilder.DropTable(
                name: "CardImport");

            migrationBuilder.DropTable(
                name: "CardNumberRegistry");

            migrationBuilder.DropTable(
                name: "CardPinRegistry");

            migrationBuilder.DropTable(
                name: "ContractTaxLocation");

            migrationBuilder.DropTable(
                name: "CustClass");

            migrationBuilder.DropTable(
                name: "CustomerAssignment");

            migrationBuilder.DropTable(
                name: "CustomerCardCategory");

            migrationBuilder.DropTable(
                name: "CustomerGroupDetail");

            migrationBuilder.DropTable(
                name: "CustomerMerchantLocation");

            migrationBuilder.DropTable(
                name: "CustomerPricingLocationGroup");

            migrationBuilder.DropTable(
                name: "CustomerPricingLocationWorkEntry");

            migrationBuilder.DropTable(
                name: "CustomerStateLocation");

            migrationBuilder.DropTable(
                name: "CustomerZipCodeLocation");

            migrationBuilder.DropTable(
                name: "DAMCard");

            migrationBuilder.DropTable(
                name: "DAMCardConfirmation");

            migrationBuilder.DropTable(
                name: "DAMCustomer");

            migrationBuilder.DropTable(
                name: "DAMDriver");

            migrationBuilder.DropTable(
                name: "DAMUploadDetail");

            migrationBuilder.DropTable(
                name: "DAMVehicle");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "DriverAssignment");

            migrationBuilder.DropTable(
                name: "DriverImport");

            migrationBuilder.DropTable(
                name: "DriverPinRegistry");

            migrationBuilder.DropTable(
                name: "DuplicateTransactions");

            migrationBuilder.DropTable(
                name: "ExternalDatabaseDetail");

            migrationBuilder.DropTable(
                name: "FleetRec");

            migrationBuilder.DropTable(
                name: "FuelManagementGroup");

            migrationBuilder.DropTable(
                name: "FuelMasterTransactionLog");

            migrationBuilder.DropTable(
                name: "InterfaceDatasource");

            migrationBuilder.DropTable(
                name: "List");

            migrationBuilder.DropTable(
                name: "LocationPricingLocationGroup");

            migrationBuilder.DropTable(
                name: "MasterGroups");

            migrationBuilder.DropTable(
                name: "NBCSProducts");

            migrationBuilder.DropTable(
                name: "NumberRegistry");

            migrationBuilder.DropTable(
                name: "NYCHALabels");

            migrationBuilder.DropTable(
                name: "OrgLevelDefinition");

            migrationBuilder.DropTable(
                name: "OrgLevelName");

            migrationBuilder.DropTable(
                name: "ParticipantCode");

            migrationBuilder.DropTable(
                name: "PumpPrices");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "RetailAdder");

            migrationBuilder.DropTable(
                name: "SampleTable");

            migrationBuilder.DropTable(
                name: "SendTransactionsErrorLog");

            migrationBuilder.DropTable(
                name: "SiteCustomers");

            migrationBuilder.DropTable(
                name: "SiteProduct");

            migrationBuilder.DropTable(
                name: "SmallGallonTransactions");

            migrationBuilder.DropTable(
                name: "SolarcLocale");

            migrationBuilder.DropTable(
                name: "SolArcProduct");

            migrationBuilder.DropTable(
                name: "Source");

            migrationBuilder.DropTable(
                name: "SpecialCustomer");

            migrationBuilder.DropTable(
                name: "SPR_CreateFleetRecExceptions");

            migrationBuilder.DropTable(
                name: "SyncCard");

            migrationBuilder.DropTable(
                name: "SyncVehicle");

            migrationBuilder.DropTable(
                name: "TaxAreas");

            migrationBuilder.DropTable(
                name: "TaxLocation");

            migrationBuilder.DropTable(
                name: "TempTransaction");

            migrationBuilder.DropTable(
                name: "TransactionErrorDetail");

            migrationBuilder.DropTable(
                name: "TransactionExceptionDetail");

            migrationBuilder.DropTable(
                name: "TransactionFlag");

            migrationBuilder.DropTable(
                name: "TransactionImportLog");

            migrationBuilder.DropTable(
                name: "VehicleType");

            migrationBuilder.DropTable(
                name: "VoidTransactions");

            migrationBuilder.DropTable(
                name: "VoyagerErrorCodes");

            migrationBuilder.DropTable(
                name: "VoyagerSyncCard");

            migrationBuilder.DropTable(
                name: "VoyagerSyncDriver");

            migrationBuilder.DropTable(
                name: "VoyagerSyncVehicle");

            migrationBuilder.DropTable(
                name: "WinC6TransactionLog");

            migrationBuilder.DropTable(
                name: "YTD_Product_Totals");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Audit");

            migrationBuilder.DropTable(
                name: "AuditDataType");

            migrationBuilder.DropTable(
                name: "AuditHistory");

            migrationBuilder.DropTable(
                name: "VehicleImport");

            migrationBuilder.DropTable(
                name: "CardCategory");

            migrationBuilder.DropTable(
                name: "CustomerGroup");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "ExternalDatabase");

            migrationBuilder.DropTable(
                name: "PricingLocationGroup");

            migrationBuilder.DropTable(
                name: "Sites");

            migrationBuilder.DropTable(
                name: "ImportedTransactions");

            migrationBuilder.DropTable(
                name: "TransactionError");

            migrationBuilder.DropTable(
                name: "TransactionException");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "AuditEvent");

            migrationBuilder.DropTable(
                name: "Card");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "CardClass");

            migrationBuilder.DropTable(
                name: "Vehicle");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
