-- Create a new database
CREATE DATABASE TedShopDB2;
GO

-- Use the newly created database
USE TedShopDB2;
GO

-- Create Staff table
CREATE TABLE Staff (
    StaffID INT PRIMARY KEY,
    Name VARCHAR(100),
    Address VARCHAR(255),
    Phone VARCHAR(20),
    KindOfStaff VARCHAR(20),
    BankAccount VARCHAR(50)
);

-- Create ProductType table
CREATE TABLE ProductType (
    ProductTypeID INT PRIMARY KEY,
    ProductTypeName VARCHAR(100)
);

-- Create Product table
CREATE TABLE Product (
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Description TEXT,
    ProduceCountry VARCHAR(100),
    ProductTypeID INT,
    Price DECIMAL(10, 2),
    SellPrice DECIMAL(10, 2),
    UseGuide TEXT,
    Quantity INT,
    FOREIGN KEY (ProductTypeID) REFERENCES ProductType(ProductTypeID)
);

-- Create Importing table
CREATE TABLE Importing (
    ImportingID INT PRIMARY KEY,
    StaffID INT,
    ImportDate DATE,
    FOREIGN KEY (StaffID) REFERENCES Staff(StaffID)
);

-- Create ImportedProducts table
CREATE TABLE ImportedProducts (
    ImportingID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (ImportingID) REFERENCES Importing(ImportingID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

-- Create Order table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    CustomerAddress VARCHAR(255),
    CustomerPhone VARCHAR(20),
    OrderDate DATE
);

-- Create OrderedProducts table
CREATE TABLE OrderedProducts (
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY (ProductID) REFERENCES Product(ProductID)
);

-- Create Delivery table
CREATE TABLE Delivery (
    DeliveryID INT PRIMARY KEY,
    StaffID INT,
    OrderID INT,
    DeliveryDate DATE,
    FOREIGN KEY (StaffID) REFERENCES Staff(StaffID),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);

-- Insert sample data into Staff table
INSERT INTO Staff (StaffID, Name, Address, Phone, KindOfStaff, BankAccount)
VALUES
    (1, 'John Doe', '123 Main St', '123-456-7890', 'Manager', '123-456-7890123'),
    (2, 'Jane Smith', '456 Elm St', '456-789-0123', 'Staff', '456-789-0123456'),
    (3, 'David Johnson', '789 Oak St', '789-012-3456', 'Staff', '789-012-3456789'),
    (4, 'Emily Brown', '321 Pine St', '321-654-9870', 'Staff', '321-654-9876543'),
    (5, 'Michael Lee', '654 Maple St', '654-987-0123', 'Staff', '654-987-0123456');

-- Insert sample data into ProductType table
INSERT INTO ProductType (ProductTypeID, ProductTypeName)
VALUES
    (1, 'Electronics'),
    (2, 'Clothing'),
    (3, 'Home Appliances'),
    (4, 'Books'),
    (5, 'Toys');

-- Insert sample data into Product table
INSERT INTO Product (ProductID, ProductName, Description, ProduceCountry, ProductTypeID, Price, SellPrice, UseGuide, Quantity)
VALUES
    (1, 'Smartphone', 'High-end smartphone with advanced features.', 'USA', 1, 799.99, 959.99, 'User manual included.', 50),
    (2, 'T-Shirt', 'Casual cotton t-shirt.', 'China', 2, 19.99, 23.99, 'Machine washable.', 100),
    (3, 'Refrigerator', 'Large capacity refrigerator with energy-saving features.', 'South Korea', 3, 1499.99, 1799.99, 'Installation guide provided.', 20),
    (4, 'Python Programming Book', 'Comprehensive guide to Python programming language.', 'USA', 4, 39.99, 47.99, 'Beginner-friendly.', 30),
    (5, 'LEGO Set', 'Building blocks toy set for kids.', 'Denmark', 5, 49.99, 59.99, 'Suitable for ages 6 and above.', 200);

-- Insert sample data into Importing table
INSERT INTO Importing (ImportingID, StaffID, ImportDate)
VALUES
    (1, 2, '2024-03-01'),
    (2, 3, '2024-03-05'),
    (3, 4, '2024-03-10'),
    (4, 5, '2024-03-15'),
    (5, 2, '2024-03-20');

-- Insert sample data into ImportedProducts table
INSERT INTO ImportedProducts (ImportingID, ProductID, Quantity)
VALUES
    (1, 1, 20),
    (1, 2, 50),
    (2, 3, 10),
    (3, 4, 15),
    (4, 5, 100);

-- Insert sample data into Order table
INSERT INTO Orders (OrderID, CustomerName, CustomerAddress, CustomerPhone, OrderDate)
VALUES
    (1, 'Alice Johnson', '789 Oak St', '789-012-3456', '2024-03-02'),
    (2, 'Bob Smith', '456 Elm St', '456-789-0123', '2024-03-06'),
    (3, 'Charlie Brown', '321 Pine St', '321-654-9870', '2024-03-11'),
    (4, 'Diana Lee', '654 Maple St', '654-987-0123', '2024-03-16'),
    (5, 'Emma White', '123 Main St', '123-456-7890', '2024-03-21');

-- Insert sample data into OrderedProducts table
INSERT INTO OrderedProducts (OrderID, ProductID, Quantity)
VALUES
    (1, 1, 2),
    (1, 2, 3),
    (2, 3, 1),
    (3, 4, 2),
    (4, 5, 5);

-- Insert sample data into Delivery table
INSERT INTO Delivery (DeliveryID, StaffID, OrderID, DeliveryDate)
VALUES
    (1, 2, 1, '2024-03-03'),
    (2, 3, 2, '2024-03-07'),
    (3, 4, 3, '2024-03-12'),
    (4, 5, 4, '2024-03-17'),
    (5, 2, 5, '2024-03-22');
