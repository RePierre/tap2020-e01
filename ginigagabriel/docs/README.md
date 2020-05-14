# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Tipuri valoare și tipuri referință în `.net` ##
Explicați care sunt diferențele între tipurile valoare și tipurile referință.

Un tip de date este 'value type' daca tine valoarea in propriea memorie. Avem -> int i=1; , sistemul salveaza valoarea '1' direct in memoria alocata pentru variabila i.

Tipul 'Reference type' nu stocheaza direct valori ,ci adresele unde se afla valorile.Practic, reprezinta un container de adrese de memorie. De exemplu , vectorul
int[] array=new int[2]; 
array[0]=i;
array[1]=i;

Vectorul tine doar doua adrese identice.

## Clase abstracte și interfețe ##
Explicați care sunt diferențele și asemănările între o clasă abstractă și o interfață.

O clasa poate deriva doar dintr-o unica clasa  abstracta sau din mai multe interfete.
In clasa abstracta putem crea metode pe care o le implementam in clasa derivata .





## Principiile programării Orientate-Obiect ##
Enumerați principiile POO și pentru fiecare dați o descriere sau un exemplu.


Incapsularea - organizarea tuturor metodelor/proprietatilor si setarea gradului de vizibilitate.
Polimorfism-creem functii cu acelasi nume ,dar functionalitate diferita in functie de parametrii dati.
Mostenirea-Transmiterea metodelor/proprietatilor din clasa parinte .



