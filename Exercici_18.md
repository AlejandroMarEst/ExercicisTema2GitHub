## Exercici 18
Disposem d’un mètode que valida les edats que rep com a argument. Una edat és vàlida si està en l'interval de 0 a 120.

### Defineix les classes d'equivalència per al mètode que valida les edats.
De 0 a 120
### Indica quins casos d'edat podrien considerar-se extrems i per què.
Valors Limits:
Minim 0
Maxim 120
Valors fora del limit 321 777 -12
### Escriu tests per a cadascun dels casos de prova.
1. Test 1
   
   Entrada: 120
   
   Resultat Esperat: True
   
   Resultat Obtingut: True
   
3. Test 1
   
   Entrada: 0
   
   Resultat Esperat: True
   
   Resultat Obtingut: True
   
6. Test 1
   
   Entrada: 321
   
   Resultat Esperat: False

   Resultat Obtingut: False
   
8. Test 1
   
   Entrada: 777
   
   Resultat Esperat: False
   
   Resultat Obtingut: False
   
10. Test 1
    
   Entrada: -12
   
   Resultat Esperat: False
   
   Resultat Obtingut: False
   
### La declaració del mètode és la següent: public static bool IsValidAge(int age);


