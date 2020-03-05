# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare

## Context ##
Properitarul unei pensiuni din Bucovina vă angajează pentru a implementa o aplicație de management al rezervărilor.

Pensiunea are 6 camere (numerotate de la 1 la 6) situate pe 3 niveluri: la parter - o cameră de familie, la etaj - trei camere duble dintre care două sunt cu vedere la munte și încă două camere de o persoană la mansardă.

Prețul pentru fiecare cameră diferă în funcție de capacitatea și particularitățile oferite de acestea astfel:
- Camera de familie costă 200 RON/noapte,
- O cameră dublă simplă costă 120 RON/noapte,
- O cameră dublă cu vedere la munte costă 150 RON/noapte,
- O cameră la mansardă costă 100 RON/noapte.
În plus, dacă rezervarea este de mai mult de 3 nopți, proprietarul vrea să acorde o reducere de 20% din prețul fiecărei nopți suplimentare.

Din discuția cu properitarul pensiunii vă faceți o imagine a modului în care modelați aplicația dar vă dați seama că mai aveți nevoie să revizuiți câteva noțiuni teoretice.

## Cerințe ##
1. Faceți fork la acest proiect.
2. Faceți o copie directorul a `template` și numiți directorul nou-creat cu numele utilizatorului vostru de GitHub scris cu litere mici (ex. `NumeUtilizator`-> `numeutilizator`).
3. În `numeutilizator/docs` veți găsi un fișier numit `README.md`. Deschideți fișierul cu orice editor de text și completați cerințele.
4. În `numeutilizator/src` creați o soluție `Visual Studio` în care să dezvoltați o micro-aplicație pentru contextul dat mai sus, cu următoarele cerințe suplimentare:
   - Creați un fișier nou pentru fiecare clasă,
   - Creați o clasă suplimentară care să reprezinte recepția pensiunii,
   - Expuneți o metodă în clasa nouă care primește ca parametri numărul camerei, data de început și data de sfârșit a rezervări și afișează prețul total,
   - În `Program.cs` apelați metoda pentru cel puțin două tipuri de cameră și afișați prețul calculat apelând `Console.WriteLine()`.
5. După ce ați terminat de completat cerințele sau la sfârșitul laboratorului faceți un Pull-Request.

## Observații ##
- La această cerință se va lucra exclusiv în timpul laboratorului. Pull-request-ul cu rezolvarea trebuie să fie inițiat înainte de sfârșitul laboratorului.
