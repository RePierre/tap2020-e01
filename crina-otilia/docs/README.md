# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Tipuri valoare și tipuri referință în `.net` ##
Explicați care sunt diferențele între tipurile valoare și tipurile referință.
-O diferenta importanta este reprezentata de alocarea zonelor de memorie. Tipul valoare aloca
o singura zona de memorie in heap, pe cand tipul de valoare referinta aloca doua zone de memorie
una pentru adresa care este salvata in stiva si una pentru valoare care este salvata in heap.
-O alta diferenta este cazul special string care este de o data .net de tip referinta, 
dar aceasta actioneaza ca si data de tip valoare.

## Clase abstracte și interfețe ##
Explicați care sunt diferențele și asemănările între o clasă abstractă și o interfață.
-Clasa abstracta este mai putin abstracta decat interfata
-La clasa abstracta nu se poate crea o instanta, pe cand la interfata acest lucru este posibil
-Clasa abstracta nu are un constructor , ceea ce este posibil la interfata deoarece acesta 
are o libertate mai mare si nu este constrans
-Intr o clasa abstracta poate devia un singur tip de date, pe cand la interfata se pot 
implementa pe un tip de date mai multe interfete

## Principiile programării Orientate-Obiect ##
Enumerați principiile POO și pentru fiecare dați o descriere sau un exemplu.
-incapsularea=imbinarea datelor si metodelor pe care le proceseaza 
In cadrul cursului am realizat un exempli sugestiv legat de depunerea si extragerea 
banilor din cadrul unui cont realizandu-se astfel o legatura intre date banii si metodele
depunere si extragere.

-mostenirea=existenta unor clase superioare, superclase numite parinti si clase subordonate 
numite copii care preiau din proprietatile tipului parinte
De exemplu: Clasa parinte poate fi Figura( o figura geometrica), iar copii pot fi Dreptunghi,
Patrat si Triunghi. Acestea mostenesc de la clasa Figura elemente precum:latura, unghi dar si 
metode: Arie, Perimetru.

-polimorfismul=acelasi comportament manifestat de mai multe tipuri
Revenind la exemplul de la mostenire clasa Figura desi are metoda Arie aceasta poate fi 
abstracta. Am ales sa facem acest lucru pentru a calcula Aria pentru Triunghi, Patrat ,
respectiv, Dreptunghi intr un mod diferit, au formule de calcul diferite.
