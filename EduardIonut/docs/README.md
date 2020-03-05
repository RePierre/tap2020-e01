1. Tipuri valoare si tipuri referinta in .net:

Exemplu tip referinta: string
Exemplu tip valoare: int

*Tip Valoare:
-O variabilă a unui tip valoare contine o instanta a tipului respectiv
-Se creaza o singura zona de memorie la crearea unei instante
-Memoria alocata este in functie de tip

*Tip Referinta:
-O variabila a unui tip referinta contine adresa de memorie unde este alocata instanta
-Se creaza doua zone de memorie la crearea unei instante (Stiva si Heap)
-Memoria alocata poate sa varieze

String este imuabilizabil




2. Clase ABSTRACTE si INTERFETE:

*Clasele Abstracte:
-Sunt mai putin abstracte decat interfetele
-Nu se pot crea constructori (impune inele constrangeri)
-Nu pot crea instante ale claselor abstracte
-ofera o implementare implicita pentru metode si proprietati
-doar un tip de date poate deriva dintr-o clasa abstracta

*Interfetele:
-Au cel mai mare nivel de abstractizare
-Se pot crea constructori
-Nu ofera o implementare implicita
-un tip de date implementeaza mai multe interfete


3. Principiile programării Orientate-Obiect 
Principiile POO sunt: Inharritance, Polymorfism , Abstraction, Incapsulation
*Mostenirea: este de 4 tipuri
1. Mostenire in line  ( A -> B ) Clasa A este subclasa clasei B
2. Mostenire ierarhica ( A -> B -> C) Clasa A este subclasa clasei B , iar clasa C este subclasa clasei B --> A subclasa clasei C
3. Mostenire Multipla ( A este superclasa pentru B,C,D)
4. (A,B,C superclasa pentru D)
Prin mostenire, clasa copil mosteneste atributele si metodele clasei parinte.

*Polymorfism:
1. Overloading (Metodele au parametri diferiti sau numar diferit de parametri, metoda avand acelasi nume)
2. Overriding (Folosit pentru a suprascrie metodele)

*Incapsulation: getters si setters , imbina metodele
*Abstraction: Clase abstracte