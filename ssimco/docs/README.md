# Evaluarea nr. 1 pentru cursul Tehnici Avansate de Programare #

## Tipuri valoare și tipuri referință în `.net` ##
Explicați care sunt diferențele între tipurile valoare și tipurile referință.
<br>
<b>
Pentru tipurile valoare la creare, se aloca memorie unde se va afla valoarea sa, iar pentru tipul referință, la creare, mai întâi se aloca memorie pentru adresa sa, după care la adresa respectivă se va afla valoarea sa. Dimensiunea alocată pentru tipurile valoare depind numai de ce tip sunt, dar pentru cele referință, sunt unele pentru care variază, de exemplu ar fi instanțele la clasele de tip template.
</b>
## Clase abstracte și interfețe ##
Explicați care sunt diferențele și asemănările între o clasă abstractă și o interfață.
<br>
<b>
O clasă abstractă poate avea metode care nu sunt abstracte, pe când la o interfață toate metodele sunt abstracte. O clasă poate implementa mai multe interfețe și poate moșteni doar o singură clasă abstractă. Nu se poate crea obiecte de tipul unei clase abstracte sau a unei interfețe. O clasă care moștenește/implementează o clasă abstractă/intefață, pentru a putea crea un obiect de acel tip trebuie ca să suprascrie toate metodele abstracte.
</b>
## Principiile programării Orientate-Obiect ##
<br>
Enumerați principiile POO și pentru fiecare dați o descriere sau un exemplu.
<b>
<br>
Încapsularea: încapsularea ar însemna să restricționăm accesul direct la unele atribute ale unui obiect și să controlăm accesul la acele atribute prin intermediul unor metode, de exemplu ar fi cele 'set' și 'get'.
<br>
Polimorfism: proprietatea ca unele obiecte să se comporte la fel, deși fiind de tipuri diferite. De exemplu ar fi două clase 'square' și 'circle' care moștenesc o clasa abstractă 'shape' care are metoda 'void draw()'. Deși sunt de tipuri diferite, am putea să le considerăm ca fiind de tipul shape și la monentul când apelăm metoda 'draw' fiecare obiect va executa metoda implementată de clasa sa.
<br>
Moștenire: unele proprietați ale claselor parinte se vor manifesta la fel ca la clasele care le moștenesc. Vor avea acces la atributele și metodele publice/protejate ale clasei parinte și să le folosească.
</b>