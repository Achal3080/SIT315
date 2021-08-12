const uint8_t LedPin = 13;
const uint8_t PIR = 
    2;

uint8_t PIRstate = LOW;

void setup()
{
    pinMode(LedPin, OUTPUT);
    pinMode(PIR, INPUT);

    Serial.begin(9600);

    attachInterrupt(digitalPinToInterrupt(PIR), MotionDetected, CHANGE);
}

void loop()
{
}

void MotionDetected()
{
    PIRstate = digitalRead(PIR);
    if (PIRstate)
    {
        digitalWrite(LedPin, HIGH);
        Serial.println("Motion Has Been Detected");
    }
    else
    {
        digitalWrite(LedPin, LOW);
        Serial.println("There is no Motion Detected");
    }
}