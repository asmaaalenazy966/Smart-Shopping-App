 #  Smart Shopping Application  

A graduation project developed at **Taibah University (2023)**.  
This system simulates a **cashier-less smart store** using **AI, computer vision, IoT sensors, and cloud technology**.

---

##  Project Overview  
The **Smart Shopping App** provides a seamless and secure shopping experience:  
- Customers enter the store using a **QR code**.  
- Items are added to their cart by **scanning barcodes** or automatically through **smart boxes** equipped with sensors (Arduino-based).  
- Each sensor detects when an item is taken and updates the cart in real time.  
- The system connects with the user's bank account for automatic checkout.  
- Admins can manage users and products through a web dashboard.  

---

##  Technologies Used  
- **Mobile App:** Xamarin.Forms (C#)  
- **Backend API:** ASP.NET Core  
- **Database:** MySQL  
- **IoT Integration:** Arduino + ESP8266 sensors  
- **Admin Dashboard:** HTML, CSS, JavaScript  
- **Cloud Simulation:** Microsoft Azure  

---

## 📂 Project Structure  
SmartShoppingApp/
├── MobileApp/       # Xamarin app (Login, Cart, QR/Barcode scanning)
├── API_Server/      # ASP.NET Core Web API
├── Database/        # MySQL schema & sample data
├── Website/         # Admin dashboard (HTML/JS)
├── Arduino/         # ESP8266 sketch for sensor boxes
├── Screenshots/     # App interface images
└── README.md        # Project documentation

---

##  App Screenshots  
Here are some previews of the Smart Shopping App:  

![Login Page](Screenshots/login_page.png)  
*User login interface*  

![Cart Page](Screenshots/cart_page.png)  
*Smart cart showing selected items*  

![Dashboard](Screenshots/dashboard.png)  
*Admin dashboard for product management*  

---

##  Security & IoT Enhancements  
To improve safety and automation:  
- Smart boxes include **motion or weight sensors** connected to **Arduino + ESP8266**.  
- Each sensor sends data to the server via API when a product is removed or returned.  
- Future versions will include **JWT authentication** and **data encryption** for better security.  

---

##  How to Run  
1. Import `Database/schema.sql` into MySQL.  
2. Run the backend API using Visual Studio or .NET CLI (`API_Server/Program.cs`).  
3. Open the `Website/index.html` for admin management.  
4. Build and run the Xamarin project from `MobileApp/` for mobile.  
5. Flash the Arduino sketch (`Arduino/esp_sensor_box.ino`) to your ESP8266 and update Wi-Fi + API host info.  

---

##  Future Improvements  
- Integrate **payment gateways** for online checkout.  
- Add **AI-based recommendations** for users.  
- Improve **cloud hosting & scalability**.  
- Add **real-time analytics dashboard** for admins.  

---

##  Author  
**Asmaa Abdulrahman Al-Enazi**  
📍 Yanbu Industrial City, Saudi Arabia  
📧 asmaazi966@gmail.com | 📞+966550030467  
🔗 [GitHub Profile](https://github.com/asmaaalenazy966)

---

##  Acknowledgment  
This project was built as part of a graduation requirement and reflects a passion for **technology, innovation, and AI-driven smart retail solutions**.
