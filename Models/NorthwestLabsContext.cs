using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NorthwestLabsPrep.Models
{
    public partial class NorthwestLabsContext : DbContext
    {
        public virtual DbSet<Assay> Assay { get; set; }
        public virtual DbSet<AssayType> AssayType { get; set; }
        public virtual DbSet<AssayTypeTest> AssayTypeTest { get; set; }
        public virtual DbSet<ClientContact> ClientContact { get; set; }
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Compound> Compound { get; set; }
        public virtual DbSet<CompoundReceipt> CompoundReceipt { get; set; }
        public virtual DbSet<ConditionalTests> ConditionalTests { get; set; }
        public virtual DbSet<Discount> Discount { get; set; }
        public virtual DbSet<DiscountType> DiscountType { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeTitle> EmployeeTitle { get; set; }
        public virtual DbSet<Literature> Literature { get; set; }
        public virtual DbSet<Materials> Materials { get; set; }
        public virtual DbSet<OrderCharges> OrderCharges { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersDiscounts> OrdersDiscounts { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PotentialClients> PotentialClients { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<TestEmployee> TestEmployee { get; set; }
        public virtual DbSet<TestMaterials> TestMaterials { get; set; }
        public virtual DbSet<TestResults> TestResults { get; set; }
        public virtual DbSet<TestType> TestType { get; set; }
        public virtual DbSet<TestTypeLiterature> TestTypeLiterature { get; set; }
        public virtual DbSet<TestTypeMaterials> TestTypeMaterials { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Data Source=sqlsv-instance1.ce61i890rwzw.us-west-2.rds.amazonaws.com,1433; Initial Catalog=NorthwestLabs; Persist Security Info=True; User ID=sqlsv_i1_admin; Password=goKCaG86rsKVhtET3;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assay>(entity =>
            {
                entity.HasIndex(e => e.AssayTypeId)
                    .HasName("assayTypeIDAssay");

                entity.Property(e => e.AssayId).HasColumnName("assayID");

                entity.Property(e => e.AssayTypeId).HasColumnName("assayTypeID");

                entity.Property(e => e.DateEnded)
                    .HasColumnName("dateEnded")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStarted)
                    .HasColumnName("dateStarted")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.AssayType)
                    .WithMany(p => p.Assay)
                    .HasForeignKey(d => d.AssayTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("AssayFK00");
            });

            modelBuilder.Entity<AssayType>(entity =>
            {
                entity.Property(e => e.AssayTypeId).HasColumnName("assayTypeID");

                entity.Property(e => e.AssayTypeDescription)
                    .HasColumnName("assayTypeDescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.AssayTypeName)
                    .HasColumnName("assayTypeName")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxCost).HasColumnName("maxCost");

                entity.Property(e => e.MinCost).HasColumnName("minCost");
            });

            modelBuilder.Entity<AssayTypeTest>(entity =>
            {
                entity.HasKey(e => new { e.AssayTypeId, e.TestSequence })
                    .HasName("AssayType_Test_PK");

                entity.ToTable("AssayType_Test");

                entity.HasIndex(e => e.AssayTypeId)
                    .HasName("assayTypeIDAssayType_Test");

                entity.HasIndex(e => e.TestSequence)
                    .HasName("testSequenceAssayType_Test");

                entity.Property(e => e.AssayTypeId).HasColumnName("assayTypeID");

                entity.Property(e => e.TestSequence).HasColumnName("testSequence");

                entity.Property(e => e.Required).HasColumnName("required");

                entity.HasOne(d => d.AssayType)
                    .WithMany(p => p.AssayTypeTest)
                    .HasForeignKey(d => d.AssayTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("AssayType_TestFK00");
            });

            modelBuilder.Entity<ClientContact>(entity =>
            {
                entity.HasIndex(e => e.ClientId)
                    .HasName("clientIDClientContact");

                entity.Property(e => e.ClientContactId).HasColumnName("clientContactID");

                entity.Property(e => e.ClientContactEmail)
                    .HasColumnName("clientContactEmail")
                    .HasMaxLength(40);

                entity.Property(e => e.ClientContactFirstName)
                    .HasColumnName("clientContactFirstName")
                    .HasMaxLength(40);

                entity.Property(e => e.ClientContactLastName)
                    .HasColumnName("clientContactLastName")
                    .HasMaxLength(40);

                entity.Property(e => e.ClientContactPhone)
                    .HasColumnName("clientContactPhone")
                    .HasMaxLength(20);

                entity.Property(e => e.ClientId).HasColumnName("clientID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientContact)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("ClientContactFK00");
            });

            modelBuilder.Entity<Clients>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .HasName("Clients_PK");

                entity.Property(e => e.ClientId).HasColumnName("clientID");

                entity.Property(e => e.ClientBalance).HasColumnName("clientBalance");

                entity.Property(e => e.ClientCity)
                    .HasColumnName("clientCity")
                    .HasMaxLength(40);

                entity.Property(e => e.ClientCountry)
                    .HasColumnName("clientCountry")
                    .HasMaxLength(40);

                entity.Property(e => e.ClientEmail)
                    .HasColumnName("clientEmail")
                    .HasMaxLength(20);

                entity.Property(e => e.ClientName)
                    .HasColumnName("clientName")
                    .HasMaxLength(20);

                entity.Property(e => e.ClientPhone)
                    .HasColumnName("clientPhone")
                    .HasMaxLength(20);

                entity.Property(e => e.ClientPostalCode)
                    .HasColumnName("clientPostalCode")
                    .HasMaxLength(20);

                entity.Property(e => e.ClientStateProvince)
                    .HasColumnName("clientStateProvince")
                    .HasMaxLength(30);

                entity.Property(e => e.ClientStreet)
                    .HasColumnName("clientStreet")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Compound>(entity =>
            {
                entity.HasKey(e => e.Ltnumber)
                    .HasName("LTNumberCompound");

                entity.HasIndex(e => e.OrderId)
                    .HasName("orderIDCompound");

                entity.Property(e => e.Ltnumber).HasColumnName("LTNumber");

                entity.Property(e => e.CompoundName)
                    .HasColumnName("compoundName")
                    .HasMaxLength(40);

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Compound)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("CompoundFK00");
            });

            modelBuilder.Entity<CompoundReceipt>(entity =>
            {
                entity.HasKey(e => new { e.Ltnumber, e.CompoundSequenceCode })
                    .HasName("CompoundReceipt_PK");

                entity.HasIndex(e => e.AssayId)
                    .HasName("assayIDCompoundReceipt");

                entity.HasIndex(e => e.CompoundSequenceCode)
                    .HasName("compoundSequenceCodeCompoundReceipt");

                entity.HasIndex(e => e.Ltnumber)
                    .HasName("LTNumberCompoundReceipt");

                entity.HasIndex(e => e.ReceivedByEmpId)
                    .HasName("receivedByEmpIDCompoundReceipt");

                entity.Property(e => e.Ltnumber).HasColumnName("LTNumber");

                entity.Property(e => e.CompoundSequenceCode).HasColumnName("compoundSequenceCode");

                entity.Property(e => e.ActualWeight).HasColumnName("actualWeight");

                entity.Property(e => e.Appearance)
                    .HasColumnName("appearance")
                    .HasMaxLength(1000);

                entity.Property(e => e.AssayId).HasColumnName("assayID");

                entity.Property(e => e.DateArrived)
                    .HasColumnName("dateArrived")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateDue)
                    .HasColumnName("dateDue")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaximumToleratedDose).HasColumnName("maximumToleratedDose");

                entity.Property(e => e.MolecularMass).HasColumnName("molecularMass");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.ReceivedByEmpId).HasColumnName("receivedByEmpID");

                entity.Property(e => e.WeightClient).HasColumnName("weightClient");

                entity.HasOne(d => d.Assay)
                    .WithMany(p => p.CompoundReceipt)
                    .HasForeignKey(d => d.AssayId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("CompoundReceiptFK02");

                entity.HasOne(d => d.LtnumberNavigation)
                    .WithMany(p => p.CompoundReceipt)
                    .HasForeignKey(d => d.Ltnumber)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("CompoundReceiptFK00");

                entity.HasOne(d => d.ReceivedByEmp)
                    .WithMany(p => p.CompoundReceipt)
                    .HasForeignKey(d => d.ReceivedByEmpId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("CompoundReceiptFK01");
            });

            modelBuilder.Entity<ConditionalTests>(entity =>
            {
                entity.HasKey(e => e.TestId)
                    .HasName("ConditionalTests_PK");

                entity.Property(e => e.TestId)
                    .HasColumnName("testID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerApproval).HasColumnName("customerApproval");

                entity.Property(e => e.CustomerRequestDate)
                    .HasColumnName("customerRequestDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerResponseDate)
                    .HasColumnName("customerResponseDate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.Property(e => e.DiscountId).HasColumnName("discountID");

                entity.Property(e => e.DiscountAmount).HasColumnName("discountAmount");

                entity.Property(e => e.DiscountName)
                    .HasColumnName("discountName")
                    .HasMaxLength(20);

                entity.Property(e => e.DiscountTypeId).HasColumnName("discountTypeID");

                entity.HasOne(d => d.DiscountType)
                    .WithMany(p => p.Discount)
                    .HasForeignKey(d => d.DiscountTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("DiscountFK00");
            });

            modelBuilder.Entity<DiscountType>(entity =>
            {
                entity.Property(e => e.DiscountTypeId).HasColumnName("discountTypeID");

                entity.Property(e => e.DiscountDescription)
                    .HasColumnName("discountDescription")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasIndex(e => e.EmployeeTitleId)
                    .HasName("employeeTitleIDEmployee");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.EmployeeFirstName)
                    .HasColumnName("employeeFirstName")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeHourlyRate).HasColumnName("employeeHourlyRate");

                entity.Property(e => e.EmployeeLastName)
                    .HasColumnName("employeeLastName")
                    .HasMaxLength(30);

                entity.Property(e => e.EmployeeTitleId).HasColumnName("employeeTitleID");

                entity.HasOne(d => d.EmployeeTitle)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.EmployeeTitleId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("EmployeeFK00");
            });

            modelBuilder.Entity<EmployeeTitle>(entity =>
            {
                entity.Property(e => e.EmployeeTitleId).HasColumnName("employeeTitleID");

                entity.Property(e => e.EmployeeTitleDescription)
                    .HasColumnName("employeeTitleDescription")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Literature>(entity =>
            {
                entity.Property(e => e.LiteratureId).HasColumnName("literatureID");

                entity.Property(e => e.LiteratureDescription)
                    .HasColumnName("literatureDescription")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Materials>(entity =>
            {
                entity.HasKey(e => e.MaterialId)
                    .HasName("Materials_PK");

                entity.Property(e => e.MaterialId).HasColumnName("materialID");

                entity.Property(e => e.MaterialCost).HasColumnName("materialCost");

                entity.Property(e => e.MaterialDescription)
                    .HasColumnName("materialDescription")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<OrderCharges>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.OrderSequence })
                    .HasName("OrderCharges_PK");

                entity.HasIndex(e => e.OrderId)
                    .HasName("orderIDOrderCharges");

                entity.HasIndex(e => e.OrderSequence)
                    .HasName("orderSequenceOrderCharges");

                entity.HasIndex(e => e.TestId)
                    .HasName("testIDOrderCharges");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.OrderSequence).HasColumnName("orderSequence");

                entity.Property(e => e.ChargeCost).HasColumnName("chargeCost");

                entity.Property(e => e.ChargeDate)
                    .HasColumnName("chargeDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.OrderCharges)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("OrderChargesFK00");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.LineItemId })
                    .HasName("OrderDetails_PK");

                entity.HasIndex(e => e.AssayTypeId)
                    .HasName("assayTypeIDOrderDetails");

                entity.HasIndex(e => e.LineItemId)
                    .HasName("lineItemIDOrderDetails");

                entity.HasIndex(e => e.OrderId)
                    .HasName("orderIDOrderDetails");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.LineItemId).HasColumnName("lineItemID");

                entity.Property(e => e.AssayTypeId).HasColumnName("assayTypeID");

                entity.HasOne(d => d.AssayType)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.AssayTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("OrderDetailsFK00");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("Orders_PK");

                entity.HasIndex(e => e.ClientContactId)
                    .HasName("clientContactIDOrders");

                entity.HasIndex(e => e.ClientId)
                    .HasName("clientIDOrders");

                entity.HasIndex(e => e.EarlyPaymentDiscountId)
                    .HasName("earlyPaymentDiscountIDOrders");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.ClientContactId).HasColumnName("clientContactID");

                entity.Property(e => e.ClientId).HasColumnName("clientID");

                entity.Property(e => e.CostEstimate).HasColumnName("costEstimate");

                entity.Property(e => e.DueDate)
                    .HasColumnName("dueDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EarlyPaymentDate)
                    .HasColumnName("earlyPaymentDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EarlyPaymentDiscountId).HasColumnName("earlyPaymentDiscountID");

                entity.Property(e => e.OrderBalance).HasColumnName("orderBalance");

                entity.Property(e => e.OrderComments)
                    .HasColumnName("orderComments")
                    .HasMaxLength(1000);

                entity.Property(e => e.OrderCost).HasColumnName("orderCost");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("orderDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderRush).HasColumnName("orderRush");

                entity.HasOne(d => d.ClientContact)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ClientContactId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("OrdersFK01");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("OrdersFK00");
            });

            modelBuilder.Entity<OrdersDiscounts>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.DiscountId })
                    .HasName("Orders_Discounts_PK");

                entity.ToTable("Orders_Discounts");

                entity.HasIndex(e => e.DiscountId)
                    .HasName("discountIDOrders_Discounts");

                entity.HasIndex(e => e.OrderId)
                    .HasName("orderIDOrders_Discounts");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.DiscountId).HasColumnName("discountID");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.OrdersDiscounts)
                    .HasForeignKey(d => d.DiscountId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Orders_DiscountsFK01");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrdersDiscounts)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Orders_DiscountsFK00");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.Property(e => e.PaymentTypeId).HasColumnName("paymentTypeID");

                entity.Property(e => e.PaymentDescription)
                    .HasColumnName("paymentDescription")
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<Payments>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("Payments_PK");

                entity.HasIndex(e => e.OrderId)
                    .HasName("orderIDPayments");

                entity.HasIndex(e => e.PaymentTypeId)
                    .HasName("paymentTypeIDPayments");

                entity.Property(e => e.PaymentId).HasColumnName("paymentID");

                entity.Property(e => e.OrderId).HasColumnName("orderID");

                entity.Property(e => e.PaymentAmount).HasColumnName("paymentAmount");

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("paymentDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentTypeId).HasColumnName("paymentTypeID");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PaymentsFK00");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("PaymentsFK01");
            });

            modelBuilder.Entity<PotentialClients>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .HasName("PotentialClients_PK");

                entity.Property(e => e.ClientId)
                    .HasColumnName("clientID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(1000);

                entity.Property(e => e.DateContacted)
                    .HasColumnName("dateContacted")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasIndex(e => e.AssayId)
                    .HasName("assayIDTest");

                entity.HasIndex(e => e.TestTypeId)
                    .HasName("testTypeIDTest");

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.AssayId).HasColumnName("assayID");

                entity.Property(e => e.Concentration).HasColumnName("concentration");

                entity.Property(e => e.DateEnded)
                    .HasColumnName("dateEnded")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStarted)
                    .HasColumnName("dateStarted")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeCost).HasColumnName("employeeCost");

                entity.Property(e => e.MaterialCost).HasColumnName("materialCost");

                entity.Property(e => e.Requested).HasColumnName("requested");

                entity.Property(e => e.Required).HasColumnName("required");

                entity.Property(e => e.TestPrice).HasColumnName("testPrice");

                entity.Property(e => e.TestTubeNumber).HasColumnName("testTubeNumber");

                entity.Property(e => e.TestTypeId).HasColumnName("testTypeID");

                entity.Property(e => e.TotalCost).HasColumnName("totalCost");

                entity.HasOne(d => d.Assay)
                    .WithMany(p => p.Test)
                    .HasForeignKey(d => d.AssayId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("TestFK00");

                entity.HasOne(d => d.TestType)
                    .WithMany(p => p.Test)
                    .HasForeignKey(d => d.TestTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("TestFK01");
            });

            modelBuilder.Entity<TestEmployee>(entity =>
            {
                entity.HasKey(e => new { e.TestId, e.EmployeeId })
                    .HasName("Test_Employee_PK");

                entity.ToTable("Test_Employee");

                entity.HasIndex(e => e.EmployeeId)
                    .HasName("employeeIDTest_Employee");

                entity.HasIndex(e => e.TestId)
                    .HasName("testIDTest_Employee");

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.EmployeeId).HasColumnName("employeeID");

                entity.Property(e => e.DateEnded)
                    .HasColumnName("dateEnded")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateStarted)
                    .HasColumnName("dateStarted")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TestEmployee)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Test_EmployeeFK01");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.TestEmployee)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Test_EmployeeFK00");
            });

            modelBuilder.Entity<TestMaterials>(entity =>
            {
                entity.HasKey(e => new { e.TestId, e.MaterialId })
                    .HasName("Test_Materials_PK");

                entity.ToTable("Test_Materials");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("materialIDTest_Materials");

                entity.HasIndex(e => e.TestId)
                    .HasName("testIDTest_Materials");

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.MaterialId).HasColumnName("materialID");

                entity.Property(e => e.MaterialUsed).HasColumnName("materialUsed");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.TestMaterials)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Test_MaterialsFK01");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.TestMaterials)
                    .HasForeignKey(d => d.TestId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("Test_MaterialsFK00");
            });

            modelBuilder.Entity<TestResults>(entity =>
            {
                entity.HasKey(e => new { e.TestId, e.TestSequence })
                    .HasName("TestResults_PK");

                entity.HasIndex(e => e.TestId)
                    .HasName("testIDTestResults");

                entity.HasIndex(e => e.TestSequence)
                    .HasName("testSequenceTestResults");

                entity.Property(e => e.TestId).HasColumnName("testID");

                entity.Property(e => e.TestSequence).HasColumnName("testSequence");

                entity.Property(e => e.TestResult)
                    .HasColumnName("testResult")
                    .HasMaxLength(40);

                entity.Property(e => e.TestResultComments)
                    .HasColumnName("testResultComments")
                    .HasMaxLength(1000);

                entity.Property(e => e.TestResultVal)
                    .HasColumnName("testResultVal")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<TestType>(entity =>
            {
                entity.Property(e => e.TestTypeId).HasColumnName("testTypeID");

                entity.Property(e => e.DaysToComplete).HasColumnName("daysToComplete");

                entity.Property(e => e.TestName)
                    .HasColumnName("testName")
                    .HasMaxLength(30);

                entity.Property(e => e.TestTypeDescription)
                    .HasColumnName("testTypeDescription")
                    .HasMaxLength(1000);

                entity.Property(e => e.TestTypePrice).HasColumnName("testTypePrice");
            });

            modelBuilder.Entity<TestTypeLiterature>(entity =>
            {
                entity.HasKey(e => new { e.TestTypeId, e.LiteratureId })
                    .HasName("TestType_Literature_PK");

                entity.ToTable("TestType_Literature");

                entity.HasIndex(e => e.LiteratureId)
                    .HasName("literatureIDTestType_Literature");

                entity.HasIndex(e => e.TestTypeId)
                    .HasName("testTypeIDTestType_Literature");

                entity.Property(e => e.TestTypeId).HasColumnName("testTypeID");

                entity.Property(e => e.LiteratureId).HasColumnName("literatureID");

                entity.HasOne(d => d.Literature)
                    .WithMany(p => p.TestTypeLiterature)
                    .HasForeignKey(d => d.LiteratureId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("TestType_LiteratureFK01");

                entity.HasOne(d => d.TestType)
                    .WithMany(p => p.TestTypeLiterature)
                    .HasForeignKey(d => d.TestTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("TestType_LiteratureFK00");
            });

            modelBuilder.Entity<TestTypeMaterials>(entity =>
            {
                entity.HasKey(e => new { e.TestTypeId, e.MaterialId })
                    .HasName("TestType_Materials_PK");

                entity.ToTable("TestType_Materials");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("materialIDTestType_Materials");

                entity.HasIndex(e => e.TestTypeId)
                    .HasName("testTypeIDTestType_Materials");

                entity.Property(e => e.TestTypeId).HasColumnName("testTypeID");

                entity.Property(e => e.MaterialId).HasColumnName("materialID");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.TestTypeMaterials)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("TestType_MaterialsFK01");

                entity.HasOne(d => d.TestType)
                    .WithMany(p => p.TestTypeMaterials)
                    .HasForeignKey(d => d.TestTypeId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("TestType_MaterialsFK00");
            });
        }
    }
}