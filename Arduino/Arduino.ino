int led = 6;

void setup()
{
  pinMode(led, OUTPUT);
  Serial.begin(9600);
}

void loop()
{
  byte in;
  
  if(Serial.available())
  {
   in = Serial.read(); 
   Serial.flush();
  }
  
  if(in == '1')
  {
   digitalWrite(led, HIGH); 
  }
  if(in == '0')
  {
    digitalWrite(led, LOW);
  }
  
  delay(200);
}
