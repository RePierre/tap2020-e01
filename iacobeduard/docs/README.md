# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Tipuri valoare și tipuri referință în `.net` ##
Explicați care sunt diferențele între tipurile valoare și tipurile referință.

Tipul valoare pastreaza memoria alocata intr-o stiva. Atunci cand cream un tip valoare, un singur spatiu de memorie e alocat 
pentru a stoca valoarea, aceasta isi aloca direct o valoare. Daca initializam la o alta variabila, valoarea este copiata direct
iar cele doua variabile vor functiona simultan. Tipul de date predefinit, structurile, enumeratiile sunt de asemenea tip valoare, si
functioneaza in acelasi fel. Tipul valoare poate fi creat in timpul compilarii si stocate in memoria stiva, din cauza asta, Garbage
Collector-ul nu poate accesa stiva. Un exemplu simplu este acesta int x = 10; , aici valoarea 10 e stocata in stiva.

Tipul referinta sunt utilizate de o referinta care tin o adresa catre obiect, dar nu obiectul in sine. Din cauza ca tipul referinta
reprezinta adresa unei variabile si nu data in sine, initializarea unei variabile referinta catre alta variabila nu va face o copie 
a datei. In schimb creaza o a doua copie catre referinta, care se va face referinta in aceeasi locatie in zona heap ca cea originala.
Varibilele de tip referinta sunt stocate in zone diferite de memorie numite 'heap'. Asta inseamna ca o variabila de tip referinta nu
mai e utilizata, poate fi marcata pentru Garbage Collector. Exemplele de referinta sunt clasele, obiectele, matricele.



## Clase abstracte și interfețe ##
Explicați care sunt diferențele și asemănările între o clasă abstractă și o interfață.

O clasa abstracta ofere o implementare implicita pentru metode. O clasa abstracta este o clasa care nu poate fi instantiata si este 
folosita pentru mostenire. O clasa care nu este abstracta si care deriveaza dintr-o clasa abstracta, trebuie sa includa implementarile
tuturor membrilor abstracti, un tip de date poate deriva dintr-o singura clasa abstracta.
Pe de alta parte o interfata nu ofera nici o implementare. O interfata defineste un set de metode, proprietati, evenimente, indexatori.
Acesti membri vor fi implementati de o clasa sau chiar de o structura, un tip de date poate implementa mai multe interfete.

## Principiile programării Orientate-Obiect ##
Enumerați principiile POO și pentru fiecare dați o descriere sau un exemplu.

Principiile POO sunt incapsulare, abstractizare, mostenire si polimorfism. Incapsularea este imbinarea datelor si metodelor care le 
proceseaza, mostenirea este mecanismul in care o clasa mosteneste proprietatile unei alte clase, polimorfismul are acelasi comportament
manifestat de mai multe tipuri iar abstractizarea este exprima toate caracteristicile esentiale ale unui obiect care fac ca acesta sa se 
distinga de alte obiecte.