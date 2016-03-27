#include <SoftwareSerial.h>
SoftwareSerial ftdi(4, 5);

boolean keys[4][4] = {{LOW, LOW, LOW, LOW},{LOW, LOW, LOW, LOW}};

void setup() {
  pinMode(6, INPUT);
  pinMode(7, INPUT);
  pinMode(8, INPUT);
  pinMode(9, INPUT);
  pinMode(10, INPUT);
  pinMode(11, INPUT);
  pinMode(12, INPUT);
  pinMode(13, INPUT);
  ftdi.begin(9600);
}

void loop() {
  if (digitalRead(6) == HIGH && keys[0][0] == LOW) {
    ftdi.print("c1\n\r");
    keys[0][0] = HIGH;
  }
  if (digitalRead(6) == LOW) {
    keys[0][0] = LOW;
  }
  if (digitalRead(7) == HIGH && keys[0][1] == LOW) {
    ftdi.print("b1\n\r");
    keys[0][1] = HIGH;
  }
  if (digitalRead(7) == LOW) {
    keys[0][1] = LOW;
  }
  if (digitalRead(8) == HIGH && keys[0][2] == LOW) {
    ftdi.print("c2\n\r");
    keys[0][2] = HIGH;
  }
  if (digitalRead(8) == LOW) {
    keys[0][2] = LOW;
  }
  if (digitalRead(9) == HIGH && keys[0][3] == LOW) {
    ftdi.print("b2\n\r");
    keys[0][3] = HIGH;
  }
  if (digitalRead(9) == LOW) {
    keys[0][3] = LOW;
  }
  if (digitalRead(10) == HIGH && keys[1][0] == LOW) {
    ftdi.print("c3\n\r");
    keys[1][0] = HIGH;
  }
  if (digitalRead(10) == LOW) {
    keys[1][0] = LOW;
  }
  if (digitalRead(11) == HIGH && keys[1][1] == LOW) {
    ftdi.print("b3\n\r");
    keys[1][1] = HIGH;
  }
  if (digitalRead(11) == LOW) {
    keys[1][1] = LOW;
  }
  if (digitalRead(12) == HIGH && keys[1][2] == LOW) {
    ftdi.print("c4\n\r");
    keys[1][2] = HIGH;
  }
  if (digitalRead(12) == LOW) {
    keys[1][2] = LOW;
  }
  if (digitalRead(13) == HIGH && keys[1][3] == LOW) {
    ftdi.print("b4\n\r");
    keys[1][3] = HIGH;
  }
  if (digitalRead(13) == LOW) {
    keys[1][3] = LOW;
  }
}
