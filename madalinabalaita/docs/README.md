# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Tipuri valoare și tipuri referință în `.net` ##
Explicați care sunt diferențele între tipurile valoare și tipurile referință.

O variabila a unui tip valoare contine o instanta a tipului respectiv pe cand o variabila a unui tip referinta contine adresa de memorie unde este alocata instanta propriu-zisa.
La crearea unei instante(tip valoare) se aloca o singura zona de memorie, acestea sunt stocate intr-o stiva de executie,iar valoarea lor  este stocata si accesata in mod direct.(exemple: byte,int,long,float,double etc.
Tipurile de referinta nu detin valori directe.Acestea pastreaza o adresa(referinta) in stiva de executie a programului si aceasta este cea care indica spre valoarea reala stocata in memoria dinamica(heap).
Spre deosebire de tipurile valoare, tipurile de referinta pot avea valori nule,iar ele pot indica doar obiecte de acelasi tip.Aloca memoria dinamic pentru declaratia lor.Sunt gestionate de Garbage Collector de aceea pot fi mai lente decat tipurile valoare.

Cum tipurile referinta sunt alocate si eliberate dinamic si automat, este  posibil ca dimensiunile lor sa nu fie cunoscute dinainte(de exemplu la un sir de caractere) pe cand la tipurile valore sunt.
La creearea unei instante se aloca doua zone de memorie una pentru adrese(stiva) si una pentru instanta(memoria heap_ la tipuri referinta .
Desi tipul string se comporta ca un tip valoare acesta este un tip referinta(aceasta poprietate se numeste imuabilitate)
## Clase abstracte și interfețe ##
Explicați care sunt diferențele și asemănările între o clasă abstractă și o interfață.

Scopul unei clase abstracte este de a defini un comportament comun care poate fi mostenit de mai  multe clase fara a implementa intreaga clasa.Interfetele forteaza clasa care le pune in aplicatie sa implementeze toti membrii. (interfetele sunt ca niste schelete pe cand clasele abstracte sunt niste schelete cu ceva carne si piele.)
.Clasele abstracte ofera o implementare implicita pentru metode si proprietati pe cand interfetele nu ofera nicio implementare.
Cele doua nuu se pot instantia.
Clasa abstracta este mai putin abstracta decat interfata .De seamenea o clasa abstracta poate impune anumite constrangeri pe cand interfetele nu.
O alta diferenta este ca un tip de date poate deriva dintr-o singura clasa abstracta iar la interfete un tip de date poate implementa mai multe interfete.

## Principiile programării Orientate-Obiect ##
Enumerați principiile POO și pentru fiecare dați o descriere sau un exemplu.


Incapsularea:
 este actiunea de a ascunde orice lucru care nu este esential pentru lumea exterioara.
Modificatorii de acces sunt : private,protected,internal si public.
Pentru a ilustra acest principiu luam acest exemplu: noi dorim sa pastram varsta unei persoane deci am putea declara o variabila int de tip public.Astfel,utilizatorii pot atribui orice numar,chiar si negativ ceea ce ar fi eronat.Pentru a corecta acest lucru declaram vriabila int de tip private si sa atribuim valori doar printr-o proprietate sau metoda publica. 

Mostenirea: 
implica ca proprietatile tipului parinte se pastraza si la copii.
Un exemplu ar fi :Avem clasa parinte feline iar o clasa fiu/subclasa ar fi leu sau tigru deoarece fac parte din aceasta categorie.


Polimorfism:
implica acelasi comportament manifestat de mai multe tipuri.
Polimorfismul este capacitatea de a avea mai multe forme.
Permite tratarea obiectelor unei clase derivate ca obiecte  ale clasei sale baza.

