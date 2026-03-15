apbd-cw1-git-s33622

"CalculateAverage"
"CalculateMax"
"CalculateMin"




1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
odp: Git wykona fast-forward kiedy stworzymy gałąź i bedziemy na niej tworzyć 
commity i w tym samym nic na 'main' nie będziemy nic zmieniać, czyli będzie taka prosta linia.
Merge commit powstaje podczas, gdy twprzymy gałąź i np. dodamy na niej dwa commity, przejdziemy
na 'main' i tutaj też w tym samym czasie zrobimy jakieś commity. Wtedy git tworzy nowy dodatkowy
commit, żeby połączyć te dwie drogi.

2. Czym w praktyce różni się merge od rebase?
odp: W merge widać nasze rozwidlenia pracy, czyli kiedy dodawaliśmy coś do 'main', a kiedy do naszej
stworzonej gałęzi. Natomiast w rebase widać tylko prostą linię, która połączyła nasze commity
z 'main' i stworzonej gałęzi w jedną całość.

3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
odp: Rozwiązałem konflikt poprzez ręczny wybór finalnej wersji w Rider. W miejscu, gdzie obie 
gałęzie zmieniały tę samą linię kodu(w obu gałęziach dałem inną nazwę zmiennej w metodzie CalculateMin)
wybrałem ostateczną wersję nazwy zmiennej, ostatecznie w 'main' uzyskałem docelową nazwę zmiennej,
po czym zrobiłem commit'a i upewniłem się, że wszystko działa