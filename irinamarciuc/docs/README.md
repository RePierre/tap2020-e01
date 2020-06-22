# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Tipuri valoare și tipuri referință în `.net` ##
Explicați care sunt diferențele între tipurile valoare și tipurile referință.

O variabila de tip valoare contine o instanta a tipului respectiv in timp ce o variabila de tip referinta contine adresa de memorie unde este alocata instanta variabilei.
Instanta unei variabile de tip valoare aloca o singura zona de memorie, iar in cazul unei variabile de tip referinta se aloca 2 zone de memorie: pentru adresa instantei(stiva) si pentru instanta propriu-zisa(memoria HEAP)
Dimensiunea zonei alocate de o variabila de tip valoare este data de tipul sau, iar in cazul unei variabile de tip referinta dimensiunea poate sa difere pentru acelasi tip de data(de exemplu List<T>)

## Clase abstracte și interfețe ##
Explicați care sunt diferențele și asemănările între o clasă abstractă și o interfață.

O clasa abstracta este mai putin abstracta decat o interfata: interfata avand cel mai inalt nivel de abstractizare.
Un tip de date poate deriva doar dintr-o singura clasa abstracta, insa poate implementa mai multe interfete.
In cazul claselor abstracte pot aparea anumite constrangeri, iar in cazul interfetelor nu sunt constrangeri decat asupra semnaturii metodelor.

## Principiile programării Orientate-Obiect ##
Enumerați principiile POO și pentru fiecare dați o descriere sau un exemplu.

Incapsularea: reprezinta punerea datelor si metodelor care lucreaza cu acele date impreuna 
de exemplu: 
public abstract class RealEstate
    {
        public decimal price;
        
        protected RealEstate(decimal price)
        {
            this.price = price;
        }
        public abstract decimal Finalprice();

    }
	
	
Mostenirea: Implementarea unei clase parinte(care poate fi abstracta sau nu) cu metode si variabile care vor fi mostenite de alte clase-copil; cu alte cuvinte reutilizarea 

de exemplu: folosind clasa de mai sus avem clasa House care mosteneste clasa parinte

public class House: RealEstate
{
public House(decimal price): base(price){}

public override decimal Finalprice(){
return price+price*0.7/100;
}
}

Polimorfismul: exemplul de mai sus este si un exemplu de polimorfism prin suprascrierea metodei Finalprice() (putem folosi metoda abstracta mostenita de la clasa RealEstate si sa punem implementa cerinte diferite in fiecare clasa ce mosteneste clasa parinte 
prin polimorfism putem refolosi metode, insa in contexte diferite 
