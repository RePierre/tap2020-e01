# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Tipuri valoare și tipuri referință în `.net` ##
Explicați care sunt diferențele între tipurile valoare și tipurile referință.

Un tip valoare contine o singura instanta a acestui tip, pe cand tipul referinta contine adresa de memorie unde este alocata instanta.
La tip valoare, la crearea unei instate se aoca o singura zona de memorie, pe cand in tipul referinta se aloca 2 zone de memorie: steak( pentru adresa) si heap(pentru instanta)
Dimensiunea unei zonei alocate in tip valoare este data de tip ( Ex. bool, int, etc.), iar in tipul referinta dimenisunea zonei alocate pentru instanta poate varia.


## Clase abstracte și interfețe ##
Explicați care sunt diferențele și asemănările între o clasă abstractă și o interfață.
Una dintre asemanari poate fi ca si interfata este abstracta (mai mult ce e drept decat clasa abstracta)
Iar ca diferente, clasa abstracta implementeza doar unele din metodele clasei, iar interfata face doar o descriere a structurii, fara sa implementeze ceva.
Un tip de date poate deriva dintr-o singura clasa abstracta, pe cand la interfere un tip de date poate implementa mai multe interfete

## Principiile programării Orientate-Obiect ##
Enumerați principiile POO și pentru fiecare dați o descriere sau un exemplu.
Incapsularea: Metoda prin care tinem datele separate de exterior.
Mostenirea: Daca avem de exemplu clasa caine si clasa mamifer, clasa caine deriva din clasa mamifer. 
Polimorfismul: Se refera la atribuirea unor particularitati de metode pentru o clasa derivata. De exemplu, in clasa mamifer putem declara o metoda ca fiind abstracta, iar acea metoda o putem folosi in clasa caine cu funcionalitatea sa, iar daca avem o alta clasa derivata, vom folosi pentru acea metoda o alta descriere.