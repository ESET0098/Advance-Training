create database BookManagement
use BookManagement

SET IDENTITY_INSERT Books ON;
CREATE TABLE Book (
    book_id INT PRIMARY KEY IDENTITY(1,1),
    title VARCHAR(255) NOT NULL,
    author VARCHAR(255),
    current_price DECIMAL(10, 2) NOT NULL,
    stock_quantity INT NOT NULL CHECK (stock_quantity >= 0)
);
CREATE TABLE Customer (
    customer_id INT PRIMARY KEY IDENTITY(1,1),
    customer_name VARCHAR(255) NOT NULL,
    
);

CREATE TABLE Sale (
    sale_id INT PRIMARY KEY IDENTITY(1,1),
    customer_id INT FOREIGN KEY REFERENCES Customers(customer_id),
    sale_date DATETIME NOT NULL DEFAULT GETDATE()
);

CREATE TABLE SaleItem (
    sale_item_id INT PRIMARY KEY IDENTITY(1,1),
    sale_id INT FOREIGN KEY REFERENCES Sales(sale_id) ON DELETE CASCADE,
    book_id INT FOREIGN KEY REFERENCES Books(book_id),
    quantity_sold INT NOT NULL CHECK (quantity_sold > 0),
    sale_price DECIMAL(10, 2) NOT NULL,
    CONSTRAINT UQ_SaleItem UNIQUE (sale_id, book_id)
);

Create table User1(user_id int primary key identity(1,1),username varchar(50), password varchar(50));

select *from Book;