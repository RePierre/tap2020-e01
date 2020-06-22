# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare 


#

## Tipuri valoare și tipuri referință în `.net` 
##
Explicați care sunt diferențele între tipurile valoare și tipurile referință.
Tipurile valoare reprezinta o instanta a tipului respectiv. Acestea au o singura zona de memorie alocata, iar dimensiunea sa este fixa in functie de tipul declarat.
Ex: o variabila de tip int va avea alocata 2 biti in memorie.
Tipurile referinta reprezinta o adresa in zona de memorie a instantei tipului respectiv. Acestea au 2 zone de memorie: una pentru adresa(in stiva),
iar alta pentru instanta propriu-zisa(in memoria heap). Dimensiunea alocata depinde de declaratie.
Ex: un string are alocati 2 biti pentru fiecare caracter



### Clase abstracte și interfețe 
##
Explicați care sunt diferențele și asemănările între o clasă abstractă și o interfață.
Atat clasele abstracte cat si interfetele contin metode abstracte, dar in schimb o clasa abstracta poate contine si implementari.
O sub clasa poate extinde o singura clasa abstracta, insa poate implementa mai multe interfete.
De asemenea, clasele abstracte au anumite constarngeri in ceea ce priveste declararea metodelor.
O interfata nu impune niciun fel de constrangere in acest sens 


## Principiile programării Orientate-Obiect 
##
Enumerați principiile POO și pentru fiecare dați o descriere sau un exemplu.


Incapsularea- presupune imbinarea datelor si metodelor care le proceseaza.
Ex: pentru proiectul din evaluare, putem incapsula calculul tarifului cu existenta unei reduceri
Mostenirea- presupune declararea unei clase parinte care sa contina proprietatile comune, si
implementarea unor particularitati in subclasele sale
Ex: pentru proiectul din evaluare, putem declara o clasa parinte care sa aiba proprietatile comune tuturor camerelor,
iar particularitatile fiecarei tip de camera in subclase derivate
Polimorfismul- ne permite sa avem reguli diferite de calcul pentru aceeasi metoda.
Ex: pentru proiectul din evaluare, metoda de calcul pentru tariful platit de clienti se calculeaza diferit la fiecare camera,
dar putem declara metoda in clasa parinte, iar apoi sa implementam metoda in fiecare subclasa