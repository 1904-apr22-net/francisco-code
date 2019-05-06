create table products (
product_id int identity(1,1)primary key,
product_name nvarchar(30) not null,
price decimal(10,2) not null
);

create table orders(
order_id int identity(1,1) primary key,
product_id int not null,
customer_id int not null
);

ALTER TABLE orders  
ADD CONSTRAINT FK_orders_product_id FOREIGN KEY (product_id)     
    REFERENCES products (product_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE    
; 

create table customers(
customer_id int identity(1,1) primary key,
first_name nvarchar(20) not null,
last_name nvarchar(20) not null,
card_number nvarchar(15) not null 
);

ALTER TABLE orders  
ADD CONSTRAINT FK_orders_customer_id FOREIGN KEY (customer_id)     
    REFERENCES customers (customer_id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE    
; 

insert into products(
product_name,
price
)
values(
'iphone',
200
),
(
'headphones',
50
),
('charging cable',
30
);

insert into customers(
first_name,
last_name,
card_number
)
values(
'tina',
'smith',
'111122224444'
),
(
'bob',
'smith',
'333355558888')
;

insert into customers(
first_name,
last_name,
card_number
)
values(
'jake',
'dylan',
'121123224544'
)

insert into orders(
product_id,
customer_id
)
values(
1,
1
),
(
2,
2
),
(3,3);

select first_name, order_id from customers, orders where customers.customer_id=1 and orders.customer_id=1;
