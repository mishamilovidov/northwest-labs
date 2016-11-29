-- CREATE DATABASE
CREATE DATABASE NorthwestLabs
GO

-- SELECT CREATED DATABASE
USE NorthwestLabs
GO


-- BEGIN DROP EXISTING TABLES

DROP TABLE Discount
GO

DROP TABLE Compound
GO

DROP TABLE ConditionalTests
GO

DROP TABLE AssayType_Test
GO

DROP TABLE Test_Materials
GO

DROP TABLE Payments
GO

DROP TABLE TestType
GO

DROP TABLE CompoundReceipt
GO

DROP TABLE OrderDetails
GO

DROP TABLE Clients
GO

DROP TABLE Assay
GO

DROP TABLE ClientContact
GO

DROP TABLE Orders
GO

DROP TABLE EmployeeTitle
GO

DROP TABLE Test_Employee
GO

DROP TABLE PotentialClients
GO

DROP TABLE TestResults
GO

DROP TABLE AssayType_Literature
GO

DROP TABLE Test
GO

DROP TABLE Orders_Discounts
GO

DROP TABLE Materials
GO

DROP TABLE AssayType
GO

DROP TABLE Employee
GO

DROP TABLE TestType_Materials
GO

DROP TABLE Literature
GO

DROP TABLE OrderCharges
GO

DROP TABLE DiscountType
GO

DROP TABLE PaymentType
GO

-- END DROP EXISTING TABLES



-- BEGIN CREATE TABLES

CREATE TABLE Discount (
    discountID int IDENTITY(1,1) NOT NULL,
    discountName nvarchar(20),
    discountTypeID int NOT NULL,
    discountAmount float
)
GO

CREATE TABLE Compound (
  LTNumber int IDENTITY(100100,1) NOT NULL,
  compoundName nvarchar(40),
  orderID int NOT NULL
)
GO

CREATE TABLE ConditionalTests (
  testID int NOT NULL,
  customerRequestDate datetime,
  customerResponseDate datetime,
  customerApproval bit
)
GO

CREATE TABLE AssayType_Test (
  assayTypeID int NOT NULL,
  testSequence int NOT NULL,
  required bit,
  testTypeID int NOT NULL
)
GO

CREATE TABLE Test_Materials (
  testID int NOT NULL,
  materialID int NOT NULL,
  materialUsed float
)
GO

CREATE TABLE Payments (
  paymentID int IDENTITY(100,1) NOT NULL,
  orderID int NOT NULL,
  paymentTypeID int NOT NULL,
  paymentAmount float,
  paymentDate datetime
)
GO

CREATE TABLE TestType (
  testTypeID int IDENTITY(1,1) NOT NULL,
  testName nvarchar(30),
  testTypeDescription nvarchar(1000),
  daysToComplete float,
  testTypePrice float
)
GO

CREATE TABLE CompoundReceipt (
  LTNumber int NOT NULL,
  compoundSequenceCode int NOT NULL,
  quantity float,
  dateArrived datetime,
  receivedByEmpID int NOT NULL,
  dateDue datetime,
  appearance nvarchar(1000),
  weightClient float,
  molecularMass float,
  actualWeight float,
  maximumToleratedDose float,
  assayID int
)
GO

CREATE TABLE OrderDetails (
  orderID int NOT NULL,
  lineItemID int NOT NULL,
  assayTypeID int NOT NULL
)
GO

CREATE TABLE Clients (
  clientID int IDENTITY(100,1) NOT NULL,
  clientName nvarchar(20),
  clientStreet nvarchar(40),
  clientCity nvarchar(40),
  clientStateProvince nvarchar(30),
  clientCountry nvarchar(40),
  clientPostalCode nvarchar(20),
  clientBalance float,
  clientPhone nvarchar(20),
  clientEmail nvarchar(50)
)
GO

CREATE TABLE Assay (
  assayID int IDENTITY(100,1) NOT NULL,
  dateStarted datetime,
  dateEnded datetime,
  assayTypeID int NOT NULL
)
GO

CREATE TABLE ClientContact (
  clientContactID int IDENTITY(100,1) NOT NULL,
  clientContactFirstName nvarchar(40),
  clientContactLastName nvarchar(40),
  clientContactPhone nvarchar(20),
  clientContactEmail nvarchar(50),
  clientID int NOT NULL
)
GO

CREATE TABLE Orders (
  orderID int IDENTITY(100,1) NOT NULL,
  clientID int NOT NULL,
  clientContactID int NOT NULL,
  orderDate datetime,
  orderComments nvarchar(1000),
  orderRush bit,
  costEstimate float,
  orderCost float,
  orderBalance float,
  dueDate datetime,
  earlyPaymentDate datetime,
  earlyPaymentDiscountID int NOT NULL
)
GO

CREATE TABLE EmployeeTitle (
  employeeTitleID int IDENTITY(1,1) NOT NULL,
  employeeTitleDescription nvarchar(30)
)
GO

CREATE TABLE Test_Employee (
  testID int NOT NULL,
  employeeID int NOT NULL,
  dateStarted datetime,
  dateEnded datetime
)
GO

CREATE TABLE PotentialClients (
  clientID int NOT NULL,
  dateContacted datetime,
  comments nvarchar(1000)
)
GO

CREATE TABLE TestResults (
  testID int NOT NULL,
  testResult nvarchar(40),
  testResultVal nvarchar(100),
  testResultComments nvarchar(1000),
  testSequence int NOT NULL
)
GO

CREATE TABLE AssayType_Literature (
  assayTypeID int NOT NULL,
  literatureID int NOT NULL
)
GO

CREATE TABLE Test (
  testID int IDENTITY(100,1) NOT NULL,
  assayID int NOT NULL,
  testTypeID int NOT NULL,
  dateStarted datetime,
  dateEnded datetime,
  concentration float,
  testTubeNumber int,
  required bit,
  requested bit,
  employeeCost float,
  materialCost float,
  totalCost float,
  testPrice float
)
GO

CREATE TABLE Orders_Discounts (
  orderID int NOT NULL,
  discountID int NOT NULL
)
GO

CREATE TABLE Materials (
  materialID int IDENTITY(1,1) NOT NULL,
  materialDescription nvarchar(40),
  materialCost float
)
GO

CREATE TABLE AssayType (
  assayTypeID int IDENTITY(1,1) NOT NULL,
  assayTypeName nvarchar(40),
  assayTypeDescription nvarchar(1000),
  minCost float,
  maxCost float
)
GO

CREATE TABLE Employee (
  employeeID int IDENTITY(100,1) NOT NULL,
  employeeFirstName nvarchar(30),
  employeeLastName nvarchar(30),
  employeeTitleID int NOT NULL,
  employeeHourlyRate float
)

CREATE TABLE TestType_Materials (
  testTypeID int NOT NULL,
  materialID int NOT NULL
)
GO

CREATE TABLE Literature (
  literatureID int IDENTITY(1,1) NOT NULL,
  literatureDescription nvarchar(100)
)
GO

CREATE TABLE OrderCharges (
  orderID int NOT NULL,
  orderSequence int NOT NULL,
  testID int NOT NULL,
  chargeCost float,
  chargeDate datetime
)
GO

CREATE TABLE DiscountType (
  discountTypeID int IDENTITY(1,1) NOT NULL,
  discountDescription nvarchar(100)
)
GO

CREATE TABLE PaymentType (
  paymentTypeID int IDENTITY(1,1) NOT NULL,
  paymentDescription nvarchar(40)
)
GO

-- END CREATE TABLES



-- BEGIN ADD PRIMARY KEY CONSTRAINTS AND INDEX

ALTER TABLE Discount ADD 
    CONSTRAINT Discount_PK PRIMARY KEY   
    (
        discountID
    )  
GO

CREATE INDEX discountIDDiscount ON Discount(discountID)
GO

ALTER TABLE Compound ADD 
    CONSTRAINT Compound_PK PRIMARY KEY   
    (
        LTNumber
    )  
GO

CREATE INDEX LTNumberCompound ON Compound(LTNumber)
GO

CREATE INDEX orderIDCompound ON Compound(orderID)
GO

ALTER TABLE ConditionalTests ADD 
    CONSTRAINT ConditionalTests_PK PRIMARY KEY   
    (
        testID
    )  
GO

CREATE INDEX ConditionalTests ON ConditionalTests(testID)
GO

ALTER TABLE AssayType_Test ADD 
    CONSTRAINT AssayType_Test_PK PRIMARY KEY   
    (
        assayTypeID,
        testSequence
    )  
GO

CREATE INDEX assayTypeIDAssayType_Test ON AssayType_Test(assayTypeID)
GO

CREATE INDEX testSequenceAssayType_Test ON AssayType_Test(testSequence)
GO

CREATE INDEX testTypeIDAssayType_Test ON AssayType_Test(testTypeID)
GO

ALTER TABLE Test_Materials ADD 
    CONSTRAINT Test_Materials_PK PRIMARY KEY   
    (
        testID,
        materialID
    )  
GO

CREATE INDEX testIDTest_Materials ON Test_Materials(testID)
GO

CREATE INDEX materialIDTest_Materials ON Test_Materials(materialID)
GO

ALTER TABLE Payments ADD 
    CONSTRAINT Payments_PK PRIMARY KEY   
    (
        paymentID
    )  
GO

CREATE INDEX paymentIDPayments ON Payments(paymentID)
GO

CREATE INDEX orderIDPayments ON Payments(orderID)
GO

CREATE INDEX paymentTypeIDPayments ON Payments(paymentTypeID)
GO

ALTER TABLE TestType ADD 
    CONSTRAINT TestType_PK PRIMARY KEY   
    (
        testTypeID
    )  
GO

CREATE INDEX testTypeIDTestType ON TestType(testTypeID)
GO

ALTER TABLE CompoundReceipt ADD 
    CONSTRAINT CompoundReceipt_PK PRIMARY KEY   
    (
        LTNumber,
        compoundSequenceCode
    )  
GO

CREATE INDEX LTNumberCompoundReceipt ON CompoundReceipt(LTNumber)
GO

CREATE INDEX compoundSequenceCodeCompoundReceipt ON CompoundReceipt(compoundSequenceCode)
GO

CREATE INDEX receivedByEmpIDCompoundReceipt ON CompoundReceipt(receivedByEmpID)
GO

CREATE INDEX assayIDCompoundReceipt ON CompoundReceipt(assayID)
GO

ALTER TABLE OrderDetails ADD 
    CONSTRAINT OrderDetails_PK PRIMARY KEY   
    (
        orderID,
        lineItemID
    )  
GO

CREATE INDEX orderIDOrderDetails ON OrderDetails(orderID)
GO

CREATE INDEX lineItemIDOrderDetails ON OrderDetails(lineItemID)
GO

CREATE INDEX assayTypeIDOrderDetails ON OrderDetails(assayTypeID)
GO

ALTER TABLE Clients ADD 
    CONSTRAINT Clients_PK PRIMARY KEY   
    (
        clientID
    )  
GO

CREATE INDEX clientIDClients ON Clients(clientID)
GO

ALTER TABLE Assay ADD 
    CONSTRAINT Assay_PK PRIMARY KEY   
    (
        assayID
    )  
GO

CREATE INDEX assayIDAssay ON Assay(assayID)
GO

CREATE INDEX assayTypeIDAssay ON Assay(assayTypeID)
GO

ALTER TABLE ClientContact ADD 
    CONSTRAINT ClientContact_PK PRIMARY KEY   
    (
        clientContactID
    )  
GO

CREATE INDEX clientContactIDClientContact ON ClientContact(clientContactID)
GO

CREATE INDEX clientIDClientContact ON ClientContact(clientID)
GO

ALTER TABLE Orders ADD 
    CONSTRAINT Orders_PK PRIMARY KEY   
    (
        orderID
    )  
GO

CREATE INDEX orderIDOrders ON Orders(orderID)
GO

CREATE INDEX clientIDOrders ON Orders(clientID)
GO

CREATE INDEX clientContactIDOrders ON Orders(clientContactID)
GO

CREATE INDEX earlyPaymentDiscountIDOrders ON Orders(earlyPaymentDiscountID)
GO

ALTER TABLE EmployeeTitle ADD 
    CONSTRAINT EmployeeTitle_PK PRIMARY KEY   
    (
        employeeTitleID
    )  
GO

CREATE INDEX employeeTitleIDEmployeeTitle ON EmployeeTitle(employeeTitleID)
GO

ALTER TABLE Test_Employee ADD 
    CONSTRAINT Test_Employee_PK PRIMARY KEY   
    (
        testID,
        employeeID
    )  
GO

CREATE INDEX testIDTest_Employee ON Test_Employee(testID)
GO

CREATE INDEX employeeIDTest_Employee ON Test_Employee(employeeID)
GO

ALTER TABLE PotentialClients ADD 
    CONSTRAINT PotentialClients_PK PRIMARY KEY   
    (
        clientID
    )  
GO

CREATE INDEX clientIDPotentialClients ON PotentialClients(clientID)
GO

ALTER TABLE TestResults ADD 
    CONSTRAINT TestResults_PK PRIMARY KEY   
    (
        testID,
        testSequence
    )  
GO

CREATE INDEX testIDTestResults ON TestResults(testID)
GO

CREATE INDEX testSequenceTestResults ON TestResults(testSequence)
GO

ALTER TABLE AssayType_Literature ADD 
    CONSTRAINT AssayType_Literaturee_PK PRIMARY KEY   
    (
        assayTypeID,
        literatureID
    )  
GO

CREATE INDEX assayTypeIDAssayType_Literature ON AssayType_Literature(assayTypeID)
GO

CREATE INDEX literatureIDAssayType_Literature ON AssayType_Literature(literatureID)
GO

ALTER TABLE Test ADD 
    CONSTRAINT Test_PK PRIMARY KEY   
    (
        testID
    )  
GO

CREATE INDEX testIDTest ON Test(testID)
GO

CREATE INDEX assayIDTest ON Test(assayID)
GO

CREATE INDEX testTypeIDTest ON Test(testTypeID)
GO

ALTER TABLE Orders_Discounts ADD 
    CONSTRAINT Orders_Discounts_PK PRIMARY KEY   
    (
        orderID,
        discountID
    )  
GO

CREATE INDEX orderIDOrders_Discounts ON Orders_Discounts(orderID)
GO

CREATE INDEX discountIDOrders_Discounts ON Orders_Discounts(discountID)
GO

ALTER TABLE Materials ADD 
    CONSTRAINT Materials_PK PRIMARY KEY   
    (
        materialID
    )  
GO

CREATE INDEX materialIDMaterials ON Materials(materialID)
GO

ALTER TABLE AssayType ADD 
    CONSTRAINT AssayType_PK PRIMARY KEY   
    (
        assayTypeID
    )  
GO

CREATE INDEX assayTypeIDAssayType ON AssayType(assayTypeID)
GO

ALTER TABLE Employee ADD 
    CONSTRAINT Employee_PK PRIMARY KEY   
    (
        employeeID
    )  
GO

CREATE INDEX employeeIDEmployee ON Employee(employeeID)
GO

CREATE INDEX employeeTitleIDEmployee ON Employee(employeeTitleID)
GO

ALTER TABLE TestType_Materials ADD 
    CONSTRAINT TestType_Materials_PK PRIMARY KEY   
    (
        testTypeID,
        materialID
    )  
GO

CREATE INDEX testTypeIDTestType_Materials ON TestType_Materials(testTypeID)
GO

CREATE INDEX materialIDTestType_Materials ON TestType_Materials(materialID)
GO

ALTER TABLE Literature ADD 
    CONSTRAINT Literature_PK PRIMARY KEY   
    (
        literatureID
    )  
GO

CREATE INDEX literatureIDLiterature ON Literature(literatureID)
GO

ALTER TABLE OrderCharges ADD 
    CONSTRAINT OrderCharges_PK PRIMARY KEY   
    (
        orderID,
        orderSequence
    )  
GO

CREATE INDEX orderIDOrderCharges ON OrderCharges(orderID)
GO

CREATE INDEX orderSequenceOrderCharges ON OrderCharges(orderSequence)
GO

CREATE INDEX testIDOrderCharges ON OrderCharges(testID)
GO

ALTER TABLE DiscountType ADD 
    CONSTRAINT DiscountType_PK PRIMARY KEY   
    (
        discountTypeID
    )  
GO

CREATE INDEX discountTypeIDDiscountType ON DiscountType(discountTypeID)
GO

ALTER TABLE PaymentType ADD 
    CONSTRAINT PaymentType_PK PRIMARY KEY   
    (
        paymentTypeID
    )  
GO

CREATE INDEX PaymentType ON PaymentType(paymentTypeID)
GO

-- END ADD PRIMARY KEY CONSTRAINTS AND INDEX



-- BEGIN ADD FOREIGN KEY CONSTRAINTS

ALTER TABLE Discount ADD 
    CONSTRAINT DiscountFK00 FOREIGN KEY 
    (
        discountTypeID
    ) REFERENCES DiscountType (
        discountTypeID
    )
GO

ALTER TABLE Compound ADD 
    CONSTRAINT CompoundFK00 FOREIGN KEY 
    (
        orderID
    ) REFERENCES Orders (
        orderID
    )
GO

ALTER TABLE AssayType_Test ADD 
    CONSTRAINT AssayType_TestFK00 FOREIGN KEY 
    (
        assayTypeID
    ) REFERENCES AssayType (
        assayTypeID
    ),
    CONSTRAINT AssayType_TestFK01 FOREIGN KEY 
    (
        testTypeID
    ) REFERENCES TestType (
        testTypeID
    )
GO

ALTER TABLE Test_Materials ADD 
    CONSTRAINT Test_MaterialsFK00 FOREIGN KEY 
    (
        testID
    ) REFERENCES Test (
        testID
    ),
    CONSTRAINT Test_MaterialsFK01 FOREIGN KEY 
    (
        materialID
    ) REFERENCES Materials (
        materialID
    )
GO

ALTER TABLE Payments ADD 
    CONSTRAINT PaymentsFK00 FOREIGN KEY 
    (
        orderID
    ) REFERENCES Orders (
        orderID
    ),
    CONSTRAINT PaymentsFK01 FOREIGN KEY 
    (
        paymentTypeID
    ) REFERENCES PaymentType (
        paymentTypeID
    )
GO

ALTER TABLE CompoundReceipt ADD 
    CONSTRAINT CompoundReceiptFK00 FOREIGN KEY 
    (
        LTNumber
    ) REFERENCES Compound (
        LTNumber
    ),
    CONSTRAINT CompoundReceiptFK01 FOREIGN KEY 
    (
        receivedByEmpID
    ) REFERENCES Employee (
        employeeID
    ),
    CONSTRAINT CompoundReceiptFK02 FOREIGN KEY 
    (
        assayID
    ) REFERENCES Assay (
        assayID
    )
GO

ALTER TABLE OrderDetails ADD 
    CONSTRAINT OrderDetailsFK00 FOREIGN KEY 
    (
        assayTypeID
    ) REFERENCES AssayType (
        assayTypeID
    )
GO

ALTER TABLE Assay ADD 
    CONSTRAINT AssayFK00 FOREIGN KEY 
    (
        assayTypeID
    ) REFERENCES AssayType (
        assayTypeID
    )
GO

ALTER TABLE ClientContact ADD 
    CONSTRAINT ClientContactFK00 FOREIGN KEY 
    (
        clientID
    ) REFERENCES Clients (
        clientID
    )
GO

ALTER TABLE Orders ADD 
    CONSTRAINT OrdersFK00 FOREIGN KEY 
    (
        clientID
    ) REFERENCES Clients (
        clientID
    ),
    CONSTRAINT OrdersFK01 FOREIGN KEY 
    (
        clientContactID
    ) REFERENCES ClientContact (
        clientContactID
    )
GO

ALTER TABLE Test_Employee ADD 
    CONSTRAINT Test_EmployeeFK00 FOREIGN KEY 
    (
        testID
    ) REFERENCES Test (
        testID
    ),
    CONSTRAINT Test_EmployeeFK01 FOREIGN KEY 
    (
        employeeID
    ) REFERENCES Employee (
        employeeID
    )
GO

ALTER TABLE AssayType_Literature ADD 
    CONSTRAINT AssayType_LiteratureFK00 FOREIGN KEY 
    (
        assayTypeID
    ) REFERENCES AssayType (
        assayTypeID
    ),
    CONSTRAINT AssayType_LiteratureFK01 FOREIGN KEY 
    (
        literatureID
    ) REFERENCES Literature (
        literatureID
    )
GO

ALTER TABLE Test ADD 
    CONSTRAINT TestFK00 FOREIGN KEY 
    (
        assayID
    ) REFERENCES Assay (
        assayID
    ),
    CONSTRAINT TestFK01 FOREIGN KEY 
    (
        testTypeID
    ) REFERENCES TestType (
        testTypeID
    )
GO

ALTER TABLE Orders_Discounts ADD 
    CONSTRAINT Orders_DiscountsFK00 FOREIGN KEY 
    (
        orderID
    ) REFERENCES Orders (
        orderID
    ),
    CONSTRAINT Orders_DiscountsFK01 FOREIGN KEY 
    (
        discountID
    ) REFERENCES Discount (
        discountID
    )
GO

ALTER TABLE Employee ADD 
    CONSTRAINT EmployeeFK00 FOREIGN KEY 
    (
        employeeTitleID
    ) REFERENCES EmployeeTitle (
        employeeTitleID
    )
GO

ALTER TABLE TestType_Materials ADD 
    CONSTRAINT TestType_MaterialsFK00 FOREIGN KEY 
    (
        testTypeID
    ) REFERENCES TestType (
        testTypeID
    ),
    CONSTRAINT TestType_MaterialsFK01 FOREIGN KEY 
    (
        materialID
    ) REFERENCES Materials (
        materialID
    )
GO

ALTER TABLE OrderCharges ADD 
    CONSTRAINT OrderChargesFK00 FOREIGN KEY 
    (
        testID
    ) REFERENCES Test (
        testID
    )
GO

-- END ADD FOREIGN KEY CONSTRAINTS