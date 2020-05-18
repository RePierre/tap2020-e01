# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Tipuri valoare și tipuri referință în `.net` ##
Explicați care sunt diferențele între tipurile valoare și tipurile referință.

O variabilă a unui tip valoare conține o instanță a tipului respectiv, pe când o variabilă de tip referință conține adresa de memorie unde este alocata instanța propriu-zisă.
La crearea unei instanțe pentru datele de tip valoare se alocă o singură zonă de memorie, iar la crearea unei instanțe pentru tipurile referință se alocă două zone de memorie: o zonă de pentru adresă și o zonă pentru instanță(memoria HEAP).
Dimensiunea zonei alocate pentru este dată de tip pentru datele de tip valoare, iar dimensiunea zonei alocate pentru instanță variază pentru tipurile referință.
Tipul string este un tip referință, dar acesta se comportă ca un tip valoare. Aceasta caracteristică se numește imuabilitate.

## Clase abstracte și interfețe ##
Explicați care sunt diferențele și asemănările între o clasă abstractă și o interfață.

Clasa abstractă ne oferă o implementare implicită pentru metode și proprietăți, pe când interfața nu oferă nicio implementare. 
Clasa abstractă este mai puțin abstractă decât interfața. 
Un tip de date poate deriva dintr-o singură clasă abstractă, iar pe de altă parte un tip de date poate implementa mai multe interfețe. 
Clasa abstractă poate impune anumite constângeri, de exemplu pentru constructor, pe când interfața nu impune constângeri decât asupra semnăturii metodelor.

## Principiile programării Orientate-Obiect ##
Enumerați principiile POO și pentru fiecare dați o descriere sau un exemplu.

Principiile POO sunt:
a. Încapsularea- capacitatea de a oferi garanții ca o abstactizare este utilizată numai în conformitate cu specificațiile sale(îmbinarea datelor și metodelor care le procesează).
Exemplu: Ca posesor de cont bancare, vrea să pot depune și extrage diferite sume de bani din cont.
Încapsularea ne permite să îmbinăm retragerea de fonduri cu verificarea dacă sunt fonduri suficiente.

b.Moștenirea-posibilitatea de a construi noi abstractizări pornind de la una deja existentă. Este una dintre cele mai puternice moduri de construcție de abstractțiuni utile.(proprietățile tipului părinte se păstrează si la copii).
Exemplu:Ca posesor de conturi bancare, pot avra conturi de diferite tipuri: credit, debit, economii. Pentru retragere, fiecaare cont are comision diferit in functie de tipul acestuia.
Moștenirea ne permite să declarăm o clasă de bază cu prorietățile comune și să implementăm particularitățile în clasele derivate.

c.Polimorfism-capacitatea de a oferi aceeași interfață pentru obiecte cu implementări diferite.(Același comporrtament manifestat de mai multe tipuri.
Exemplu: Polimorfismul ne permite să aplicăm reguli diferite pentru aceeași metodă.
