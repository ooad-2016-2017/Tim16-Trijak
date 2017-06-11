#include "dht.h"
#define DHT11_PIN A0
dht DHT;

int info = 0;

int zelosvj = 12;
int crvosvj = 11;
int zeltemp = 10;
int crvtemp = 9;
int zelvlzr = 8;
int crvvlzr = 7;
int zelvlzem = 6;
int crvvlzem = 5;
int zelrez = 4;
int crvrez = 3;

int threshold_osvjetljenje = 450;
int threshold_temperatura = 17;
int threshlod_vlaznostzraka = 40;
int threshold_vlaznostzemlje = 100;
int threshold_navodnjavanje = 50;

int osvjetlj = 1;
int vlazZemlj = 2;
int rezervoar = 3;

void setup(){
    Serial.begin(9600);  
    pinMode(zelosvj, OUTPUT);
    pinMode(crvosvj, OUTPUT);
    pinMode(zeltemp, OUTPUT);
    pinMode(crvtemp, OUTPUT);
    pinMode(zelvlzr, OUTPUT);
    pinMode(crvvlzr, OUTPUT);
    pinMode(zelvlzem, OUTPUT);
    pinMode(crvvlzem, OUTPUT);
    pinMode(zelrez, OUTPUT);
    pinMode(crvrez, OUTPUT);
    pinMode(osvjetlj, INPUT);
    pinMode(vlazZemlj, INPUT);
    pinMode(rezervoar, INPUT);
}

int dajOsvjetljenje(){
  int osvjetljenje = analogRead(osvjetlj); 
  if(osvjetljenje > threshold_osvjetljenje ){    
        digitalWrite(zelosvj, HIGH);
        digitalWrite(crvosvj, LOW); 
    }else{
        digitalWrite(zelosvj, LOW);
        digitalWrite(crvosvj, HIGH); 
    }
    return osvjetljenje;
}

int dajVlaznostZemlje(){
  int vlaznostZemlje = 1023-analogRead(vlazZemlj); 
  if(vlaznostZemlje > threshold_vlaznostzemlje){    
        digitalWrite(zelvlzem, HIGH);
        digitalWrite(crvvlzem, LOW); 
    }else{
        digitalWrite(zelvlzem, LOW);
        digitalWrite(crvvlzem, HIGH); 
    }
    return vlaznostZemlje;
}

int dajTemperaturu(){
   DHT.read11(DHT11_PIN);
    if(DHT.temperature > threshold_temperatura){    
        digitalWrite(zeltemp, HIGH);
        digitalWrite(crvtemp, LOW); 
    }else{
        digitalWrite(zeltemp, LOW);
        digitalWrite(crvtemp, HIGH); 
    }
    return DHT.temperature;
}

int dajVlaznostZraka(){
   DHT.read11(DHT11_PIN);
    if(DHT.humidity > threshlod_vlaznostzraka){    
        digitalWrite(zelvlzr, HIGH);
        digitalWrite(crvvlzr, LOW); 
    }else{
        digitalWrite(zelvlzr, LOW);
        digitalWrite(crvvlzr, HIGH); 
    }
    return DHT.humidity;
}

int dajStanjeRezervoara(){
  int stanjeRezervoara = analogRead(rezervoar); 
  if(stanjeRezervoara > threshold_navodnjavanje){    
        digitalWrite(zelrez, HIGH);
        digitalWrite(crvrez, LOW); 
    }else{
        digitalWrite(zelrez, LOW);
        digitalWrite(crvrez, HIGH); 
    }
    return stanjeRezervoara;
}

void loop(){
  if(Serial.available())
    info=Serial.parseInt();
  switch(info){
    case 1 : 
      Serial.println(dajOsvjetljenje());
      break;
    case 2 :
      Serial.println(dajVlaznostZemlje());
      break;
    case 3 :
      Serial.println(dajTemperaturu());
      break;
    case 4 :
      Serial.println(dajVlaznostZraka());
      break;
    case 5 :
      Serial.println(dajStanjeRezervoara());
      break;
    default :
      break;
  }
  info = 0;
    

}
