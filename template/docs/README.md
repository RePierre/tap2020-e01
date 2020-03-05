# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Tipuri valoare și tipuri referință în `.net` ##
Explicați care sunt diferențele între tipurile valoare și tipurile referință.

Principala diferenta intre tipurile valoare si tipurile referinta este modul in care sunt stocate in memorie.
Tipul valoare este stocat pe stack, alocandu-i-se o singura zona de memorie, variabila continand valoarea. Copierea este facuta direct in cazul in care se doreste ca aceasta sa fie copiata intr-o alta variabila, fiecare dintre cele doua functionand independent. GC nu poate accesa stack-ul. Exemple de tipuri valoare: int, float, enum, struct.
Tipul referinta este folosit pentru a retine o referinta(adresa) catre obiect, dar nu obiectul in sine. Acestea ocupa doua zone de memorie, atat stack(unde este salvata referinta), cat si heap(unde este salvata instanta). Exemple de tipuri referinta: Obiecte, Colectii, Clase, Liste.

## Clase abstracte și interfețe ##
Explicați care sunt diferențele și asemănările între o clasă abstractă și o interfață.

Clasa abstracta permite ca metodele sale sa fie implementate, pe cand interfata isi va implementa metodele doar in cadrul claselor derivate. Din acest motiv, putem spune ca o interfata este "mai abstracta" decat o clasa abstracta. O clasa derivata poate mosteni o singura clasa abstracta, dar poate mosteni mai multe interfete. Niciuna dintre cele doua nu se instantiaza.  

## Principiile programării Orientate-Obiect ##
Enumerați principiile POO și pentru fiecare dați o descriere sau un exemplu.

1. Incapsularea - putem imbina datele si metodele care le proceseaza. Putem accesa atributele cu ajutorul get si set, astfel putandu-le folosi in cadrul metodelor. Acestia pot avea si modificatori de acces: provate, protected si public. 
2. Mostenirea - o clasa derivata ce mosteneste clasa parinte pastreaza toate proprietatile acesteia, putandu-le modifica prin:
3. Polimorfismul - se realizeaza cu ajutorul overload sau override. Override reprezinta faptul ca putem redefini o metoda din clasa parinte, iar overload faptul ca o metoda poate avea acelasi nume, dar numar diferit de parametri. Un exemplu concludent pentru overload sunt constructorii care in functie de numarul de parametri pot face diferite lucruri.
