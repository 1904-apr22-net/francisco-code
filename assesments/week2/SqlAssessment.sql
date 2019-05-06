create table products (
product_id int identity(1,1)primary key,
product_name nvarchar(30) not null,
price decimal(10,2) not null
);