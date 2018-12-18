void setup() {
  Serial.begin(9600);
  

  pinMode(12, OUTPUT);
  pinMode(2, OUTPUT);
  pinMode(3, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(11, OUTPUT);

}

void loop() {
  if (Serial.available() > 0)
  {
    int a = Serial.parseInt();
    if (a == -1) {
        ledsondur();
      digitalWrite(12, HIGH);
    
    }
    else if (a == -2) {
      ledsondur();
      digitalWrite(2, HIGH);
      
    }

    else if (a == -3) {
      ledsondur();
      digitalWrite(3, HIGH);
   
    }

    else if (a == -4) {
      ledsondur();
      digitalWrite(4, HIGH);
     
    }
    else if (a == -5) {
      ledsondur();
      digitalWrite(5, HIGH);
  
    }

    else if (a == -6) {
      ledsondur();
      digitalWrite(6, HIGH);
     
    }
    else if (a == -7) {
      ledsondur();
      digitalWrite(7, HIGH);
     
    }
    else if (a == -8) {
      ledsondur();
      digitalWrite(8, HIGH);
      
    }
    else if (a == -9) {
      ledsondur();
      digitalWrite(11, HIGH);
      
    }
  }
}

void ledsondur()
{ digitalWrite(12, LOW);
  digitalWrite(2, LOW);
  digitalWrite(3, LOW);
  digitalWrite(4, LOW);
  digitalWrite(5, LOW);
  digitalWrite(6, LOW);
  digitalWrite(7, LOW);
  digitalWrite(8, LOW);
  digitalWrite(11, LOW);


}
