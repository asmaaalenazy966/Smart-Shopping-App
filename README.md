# Smart-Shopping-App
Graduation project: Smart shopping system with AI and computer vision.
# Smart Shopping Application 🛒

A graduation project developed at **Taibah University (2023)**.  
The system simulates a **cashier-less smart store** using **AI, computer vision, cloud hosting, and IoT sensors**.

---

## 📌 Overview
This project provides a seamless shopping experience:
- Customers enter the store using a **QR code**.
- Products are added to the cart by **scanning barcodes** or automatically via **IoT sensor boxes**.
- The system updates the cart in real time and connects to the user’s bank account for payment.
- Store administrators can manage products and users through a web dashboard.

---

## 🛠️ Technologies Used
- **Mobile App:** Xamarin Forms (C#)
- **API Server:** ASP.NET Core Web API
- **Database:** MySQL
- **Admin Website:** HTML, CSS, JavaScript
- **IoT Integration:** Arduino/ESP8266 with sensors
- **Cloud Hosting:** Microsoft Azure (simulated)

---

## 📂 Project Structure

SmartShoppingApp/
├── MobileApp/       # Xamarin app (Login, Cart, QR/Barcode scanning)
├── API_Server/      # ASP.NET Core Web API (Products, Cart, Sensors)
├── Website/         # Admin dashboard (HTML/JS)
├── Database/        # MySQL schema & sample data
├── Arduino/         # ESP8266 sketch for smart boxes
└── README.md        # Project description


---

## ⚙️ Features
- User registration and login  
- QR code for store entry/exit  
- Barcode scanning (ZXing integration placeholder)  
- Smart cart system (manual & IoT auto-update)  
- Admin dashboard for product/user management  
- Database with sample products and inventory tracking  

---

## 🔒 Future Enhancements
- Stronger **security and authentication** (JWT tokens, encrypted communication).  
- Advanced **AI models** for customer behavior analysis.  
- **Integration with payment gateways**.  
- Improved IoT security for sensor boxes.  

---

## 🚀 How to Run
1. Import `Database/schema.sql` into MySQL.  
2. Run `API_Server/Program.cs` with .NET 6+.  
3. Open `Website/index.html` to manage products.  
4. Build the Xamarin project from `MobileApp/` in Visual Studio.  
5. Flash the ESP8266 sketch in `Arduino/` and configure WiFi + API host.  

---

## 👩‍💻 Author
**Asmaa Abdulrahman Al-Enazi**  
📍 Yanbu Industrial City, Saudi Arabia  
📧 asmaazi966@gmail.com | 📞 +966 55 003 0467  

---

## 🌟 Acknowledgment
This project was built as a graduation project and reflects a passion for **technology, creativity, and problem-solving** in real-world retail solutions.
