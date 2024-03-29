


-- Use the newly created database
USE TedShop3;
GO

-- Create Staff table
CREATE TABLE Staff (
    ID INT PRIMARY KEY,
    Name VARCHAR(100),
    Address VARCHAR(255),
    Phone VARCHAR(20),
    Type VARCHAR(20), -- Staff/Manager
    BankAccount VARCHAR(50)
);

-- Create Product Type table
CREATE TABLE ProductType (
    ID INT PRIMARY KEY,
    Name VARCHAR(100)
);

-- Create Product table
CREATE TABLE Product (
    ID INT PRIMARY KEY,
    Name VARCHAR(100),
    Description TEXT,
    CountryOfOrigin VARCHAR(100),
    TypeID INT, -- Foreign Key to ProductType
    Price DECIMAL(10, 2),
    Quantity INT,
    FOREIGN KEY (TypeID) REFERENCES ProductType(ID)
);

-- Create Orders table (renamed from Order)
CREATE TABLE Orders (
    ID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    CustomerAddress VARCHAR(255),
    CustomerPhone VARCHAR(20),
    OrderDate DATE
);

-- Create Delivery table
CREATE TABLE Delivery (
    ID INT PRIMARY KEY,
    StaffID INT, -- Foreign Key to Staff
    OrderID INT, -- Foreign Key to Orders
    DeliveryDate DATE,
    FOREIGN KEY (StaffID) REFERENCES Staff(ID),
    FOREIGN KEY (OrderID) REFERENCES Orders(ID)
);

-- Insert sample data into Staff table
INSERT INTO Staff (ID, Name, Address, Phone, Type, BankAccount)
VALUES
    (1, 'John Doe', '123 Main St', '123-456-7890', 'Manager', '123-456-7890123'),
    (2, 'Jane Smith', '456 Elm St', '456-789-0123', 'Staff', '456-789-0123456'),
    (3, 'David Johnson', '789 Oak St', '789-012-3456', 'Staff', '789-012-3456789'),
    (4, 'Emily Brown', '321 Pine St', '321-654-9870', 'Staff', '321-654-9876543'),
    (5, 'Michael Lee', '654 Maple St', '654-987-0123', 'Staff', '654-987-0123456');

-- Insert sample data into Product Type table
INSERT INTO ProductType (ID, Name)
VALUES
    (1, 'Electronics'),
    (2, 'Clothing'),
    (3, 'Home Appliances'),
    (4, 'Books'),
    (5, 'Toys');

-- Insert sample data into Product table
INSERT INTO Product (ID, Name, Description, CountryOfOrigin, TypeID, Price, Quantity)
VALUES
    (1, 'Smartphone', 'High-end smartphone with advanced features.', 'USA', 1, 799.99, 50),
    (2, 'T-Shirt', 'Casual cotton t-shirt.', 'China', 2, 19.99, 100),
    (3, 'Refrigerator', 'Large capacity refrigerator with energy-saving features.', 'South Korea', 3, 1499.99, 20),
    (4, 'Python Programming Book', 'Comprehensive guide to Python programming language.', 'USA', 4, 39.99, 30),
    (5, 'LEGO Set', 'Building blocks toy set for kids.', 'Denmark', 5, 49.99, 200);

-- Insert sample data into Orders table
INSERT INTO Orders (ID, CustomerName, CustomerAddress, CustomerPhone, OrderDate)
VALUES
    (1, 'Alice Johnson', '789 Oak St', '789-012-3456', '2024-03-02'),
    (2, 'Bob Smith', '456 Elm St', '456-789-0123', '2024-03-06'),
    (3, 'Charlie Brown', '321 Pine St', '321-654-9870', '2024-03-11'),
    (4, 'Diana Lee', '654 Maple St', '654-987-0123', '2024-03-16'),
    (5, 'Emma White', '123 Main St', '123-456-7890', '2024-03-21');

-- Insert sample data into Delivery table
INSERT INTO Delivery (ID, StaffID, OrderID, DeliveryDate)
VALUES
    (1, 2, 1, '2024-03-03'),
    (2, 3, 2, '2024-03-07'),
    (3, 4, 3, '2024-03-12'),
    (4, 5, 4, '2024-03-17'),
    (5, 2, 5, '2024-03-22');

