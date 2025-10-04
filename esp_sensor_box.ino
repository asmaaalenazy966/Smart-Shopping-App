/*
ESP8266 Example Sketch (Arduino) - Sensor Box to notify SmartShopping API
Hardware: ESP8266 (e.g., NodeMCU) + load cell / switch sensor

When the box sensor detects an item removed, it sends a POST to the API:
POST /api/sensor/event { "sensorId": "SENSOR123", "productId": 1, "event": "removed" }

Change WIFI_SSID, WIFI_PASS, API_HOST to your settings.
*/

#include <ESP8266WiFi.h>
#include <ESP8266HTTPClient.h>
#include <ArduinoJson.h>

const char* WIFI_SSID = "YOUR_SSID";
const char* WIFI_PASS = "YOUR_PASS";
const char* API_HOST = "http://your-api.example.com";

const int SENSOR_PIN = D3; // digital input from switch or sensor
const char* SENSOR_UUID = "SENSOR_BOX_1";
const int PRODUCT_ID = 1;

int lastState = HIGH;

void setup() {
  Serial.begin(115200);
  pinMode(SENSOR_PIN, INPUT_PULLUP);
  WiFi.begin(WIFI_SSID, WIFI_PASS);
  Serial.print("Connecting WiFi");
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("\nConnected.");
}

void loop() {
  int state = digitalRead(SENSOR_PIN);
  if (state == LOW && lastState == HIGH) {
    sendEvent("removed");
  } else if (state == HIGH && lastState == LOW) {
    sendEvent("returned");
  }
  lastState = state;
  delay(300);
}

void sendEvent(const char* ev) {
  if (WiFi.status() != WL_CONNECTED) return;
  HTTPClient http;
  String url = String(API_HOST) + "/api/sensor/event";
  http.begin(url);
  http.addHeader("Content-Type", "application/json");

  StaticJsonDocument<200> doc;
  doc["sensorId"] = SENSOR_UUID;
  doc["productId"] = PRODUCT_ID;
  doc["event"] = ev;
  String body;
  serializeJson(doc, body);

  int httpResponseCode = http.POST(body);
  Serial.println("POST " + url);
  if (httpResponseCode > 0) {
    String resp = http.getString();
    Serial.println("Response: " + resp);
  } else {
    Serial.println("Error on POST");
  }
  http.end();
}
