## Exercici_19
Imagina una funció que rep l'edat d'un usuari i calcula el descompte aplicable segons un sistema de tarifes 
(p. ex., nens de 0-12 anys: 50% de descompte, joves de 13-17 anys: 25%, adults de 18-64 anys: 0%, majors de 65 anys: 30%)

### Defineix les classes d'equivalència per al mètode que valida les edats.
De 0 a 12 es 50%, de 13 a 17 es 25%, de 18 a 64 es 0% i 65 en devant es 30%
### Indica quins casos d'edat podrien considerar-se extrems i per què.
Valors Limits:
Minim 0
Maxim No hi ha
Valors limits -1 0 12 13 17 18 64 65 -48 1987
### Escriu tests per a cadascun dels casos de prova.
- Test 1:

   Entrada: -1

   Resultat Esperat: Error
   
   Resultat Obtingut: Error
   
- Test 2

   Entrada: 0

   Resultat Esperat: 50
   
   Resultat Obtingut: 50
   
3. Test 3
   
   Entrada: 12
   
   Resultat Esperat: 50

   Resultat Obtingut: 50
   
4. Test 4
   
   Entrada: 13
   
   Resultat Esperat: 25
   
   Resultat Obtingut: 25
   
5. Test 5
    
   Entrada: 17
   
   Resultat Esperat: 25
   
   Resultat Obtingut: 25

6. Test 6
  
   Entrada: 18
   
   Resultat Esperat: 0
   
   Resultat Obtingut: 0 

7. Test 7
  
   Entrada: 64
   
   Resultat Esperat: 0
   
   Resultat Obtingut: 0

8. Test 8
  
   Entrada: 65
   
   Resultat Esperat: 30
   
   Resultat Obtingut: 30

9. Test 9
  
   Entrada: -48
   
   Resultat Esperat: Error
   
   Resultat Obtingut: Error

10. Test 10
  
   Entrada: 1987
   
   Resultat Esperat: 30
   
   Resultat Obtingut: 30  

## La declaració del mètode és la següent: public static int AppliedDiscount(int age);



