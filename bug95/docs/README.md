# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Tipuri valoare și tipuri referință în `.net` ##
Explicați care sunt diferențele între tipurile valoare și tipurile referință.

Tipurile valoare se aloca pe stiva, iar tipurile referinta pastreaza o adresa in stiva care indica spre 
valoarea stocata pe heap.

## Clase abstracte și interfețe ##
Explicați care sunt diferențele și asemănările între o clasă abstractă și o interfață.

Asemanari: Nu pot fi instantiate.
Deosebiri: O clasa poate mosteni doar o clasa abstracta, dar mai multe interfete.
O clasa care mosteneste o clasa abstracta trebuie sa implementeze doar metodele declarate abstracte,
in timp ce o clasa care mosteneste o interfata trebuie sa implementeze toate metodele declarate in interfata

## Principiile programării Orientate-Obiect ##
Enumerați principiile POO și pentru fiecare dați o descriere sau un exemplu.

Abstractizare - procesul prin care ascundem diferite informatii
Incapsulare - proprietatea datelor de a fi separate de exterior
Mostenire - procesul prin care o clasa poate prelua caracteristicile altei clase si eventual sa adauge unele noi
Polimorfism - procesul prin care se poate rescrie o metoda, dar care primeste intrari diferite