/* Copy and paste the code below into the Arduino software */
int E1 = 6; //M1 Speed Control
int E2 = 5; //M2 Speed Control
int M1 = 8; //M1 Direction Control
int M2 = 7; //M2 Direction Control
int pingpin = 4;
void setup()
{
int i;
for(i=5;i<=8;i++)
pinMode(i, OUTPUT);
Serial.begin(9600);
}
void loop()
{
while (Serial.available() < 1) {} // Wait until a character is received
 char val = Serial.read();
if (val == 'w')
{
  forward();
}
else if(val == 'a')
{
  left();
}
else if(val == 's')
{
  reverse();
}
else if(val == 'd')
{
  right();
}
else if(val == 'q')
{
  stopall();
}

/*switch(val) // Perform an action depending on the command
{
case 'w'://Move Forward
{
forward ();
break;
}
case 's'://Move Backwards
{
reverse ();
break;
}
case 'a'://Turn Left
{
left ();
break;
}
case 'd'://Turn Right
{
right ();
break;
}
default:
{
stopall();
break;
}
}*/
}



long ping(long time)
{
  pinMode(pingpin, OUTPUT);
  digitalWrite(pingpin, LOW);
  delayMicroseconds(2);
  digitalWrite(pingpin, HIGH);
  delayMicroseconds(5);
  digitalWrite(pingpin, LOW);
  pinMode(pingpin, INPUT);
  time=pulseIn(pingpin, HIGH);
  return(time);
}
void forward(void)
{

analogWrite (E1,255);
digitalWrite(M1,HIGH);
analogWrite (E2,255);
digitalWrite(M2,HIGH);
}
void reverse(void)
{

analogWrite (E1,255);
digitalWrite(M1,LOW);
analogWrite (E2,255);
digitalWrite(M2,LOW);
}
void stopall(void)
{

analogWrite (E1,0);
digitalWrite(M1,HIGH);
analogWrite (E2,0);
digitalWrite(M2,HIGH);
}
void left(void)
{
  analogWrite (E1,255);
digitalWrite(M1,LOW);
analogWrite (E2,255);
digitalWrite(M2,HIGH);
}
void right(void)
{
  analogWrite (E1,255);
digitalWrite(M1,HIGH);
analogWrite (E2,255);
digitalWrite(M2,LOW);
}
