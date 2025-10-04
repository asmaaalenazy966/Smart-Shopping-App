-- MySQL setup for SmartShopping (simplified)

CREATE DATABASE IF NOT EXISTS smart_shopping;
USE smart_shopping;

CREATE TABLE users (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(100),
  email VARCHAR(150) UNIQUE,
  password_hash VARCHAR(255),
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE products (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(200),
  sku VARCHAR(50),
  price DECIMAL(10,2),
  stock INT DEFAULT 0
);

CREATE TABLE carts (
  id INT AUTO_INCREMENT PRIMARY KEY,
  user_id INT,
  status VARCHAR(20) DEFAULT 'open',
  created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
  FOREIGN KEY (user_id) REFERENCES users(id)
);

CREATE TABLE cart_items (
  id INT AUTO_INCREMENT PRIMARY KEY,
  cart_id INT,
  product_id INT,
  quantity INT DEFAULT 1,
  FOREIGN KEY (cart_id) REFERENCES carts(id),
  FOREIGN KEY (product_id) REFERENCES products(id)
);

CREATE TABLE sensors (
  id INT AUTO_INCREMENT PRIMARY KEY,
  sensor_uuid VARCHAR(100) UNIQUE,
  product_id INT,
  location VARCHAR(200),
  FOREIGN KEY (product_id) REFERENCES products(id)
);

INSERT INTO products (name, sku, price, stock) VALUES
('Milk 1L','MILK001',5.00,100),
('Bread','BREAD001',2.50,200),
('Eggs (6)','EGG006',3.00,150);
