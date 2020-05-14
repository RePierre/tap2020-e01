# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Tipuri valoare și tipuri referință în `.net` ##
Explicați care sunt diferențele între tipurile valoare și tipurile referință.

O variabila a tipului valoare contine o instanta a tipului respectiv.
Atunci cand se creeaza se aloca o singura zona de memorie. 
Dimensiunea zonei alocate este data de tip (ex. int, float, bool)

O variabila a tipul de referinta contine adresa de memorie unde este alocata instanta respectiva.
La creerea unei instante se creeaza 2 zone de memorie:
Una pentru adresa care este stocata in stiva de executie si o alta pentru instanta care este stocata in memoria heap.
Dimensiunea zonei alocate poate sa difere.(exemplu: List<>)

O variabila a tipului de referinta poate avea si valoarea 0 inintial.

## Clase abstracte și interfețe ##
Explicați care sunt diferențele și asemănările între o clasă abstractă și o interfață.

Clasele abstracte ofera o implementare a metodelor deja existente.
Au un grad de abstractizare mai mic decat cel al interfetelor.
Nu se pot crea instante ale unei clase abstracte.
Un obiect poate mosteni o singura clasa abstracta.
Uneori clasele abstracte pot impune bariere (exemplu: construcorii) in implementare.

Clasele abstracte

O interfata nu ofera nicio implementare.
Are cel mai mare grad de abstractizare
Un tip de date poate implementa mai multe interfete.
Nu presupune constrangeri.


## Principiile programării Orientate-Obiect ##
Enumerați principiile POO și pentru fiecare dați o descriere sau un exemplu.

Incapsularea: se presupune imbinarea datelor si metodelor flosite

Mostenirea: clasele copil pot mosteni anumite metode de la clasele parinte pe care le mostenesc.
Ex: Clasa Masina este copilul clasei parinte Automobil

Polimorfismul: mai multe tipuri se comporta asemantor 
Putem defini o metoda cu acelasi nume intr-o alta clasa dar numarul de parametrii sa difere.
O metoda din clasa de baza este redefinita in clasele copil cu aceiasi paramterii
