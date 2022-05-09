CREATE TABLE szerzo (
  szerzoID INT PRIMARY KEY,
  nev VARCHAR(100));
  
CREATE TABLE tema (
  temaID INT PRIMARY KEY,
  megnevezes VARCHAR(100));
  
CREATE TABLE forras (
  forrasID INT PRIMARY KEY,
  cim VARCHAR(100),
  szerzoID INT FOREIGN KEY REFERENCES szerzo(szerzoID));

CREATE TABLE idezet (
  idezetID INT PRIMARY KEY,
  szoveg TEXT,
  forrasID INT FOREIGN KEY REFERENCES forras(forrasID));
  
CREATE TABLE utalas (
  idezetID INT FOREIGN KEY REFERENCES idezet(idezetID),
  temaID INT FOREIGN KEY REFERENCES tema(temaID));

INSERT INTO szerzo VALUES
(1,'Milan Kundera'),
(2,'Thomas Mann'),
(3,'Voltaire'),
(4,'Lev Tolsztoj'),
(5,'Stendhal'),
(6,'John Steinbeck'),
(7,'William Shakespeare'),
(8,'Seneca'),
(9,'Antione de Saint Exupery'),
(10,'Edmond Rostand'),
(11,'George Orwell'),
(12,'Ernest Hemingway'),
(13,'Friedrich Dürenmatt'),
(14,'Dosztojevszkij'),
(15,'Albert Camus');
  
INSERT INTO tema VALUES
(1,'Félelem'),
(2,'Tolerancia'),
(3,'Tanulás'),
(4,'Mûvészet'),
(5,'Optimizmus'),
(6,'Becsület'),
(7,'Szeretet'),
(8,'Nyelv'),
(9,'Együttérzés'),
(10,'Önismeret'),
(11,'Munka'),
(12,'Szabadság'),
(13,'Beszéd');

INSERT INTO forras VALUES
(2,'Lassúság',1),
(3,'A varázshegy',2),
(4,'Halál Velencében',2),
(5,'Candide vagy az optimizmus',3),
(6,'Anna Karenina',4),
(7,'Vörös és fekete',5),
(8,'Édentõl keletre',6),
(9,'Sok hûhó semmiért',7),
(10,'Hamlet, dán királyfi',7),
(11,'Vigasztalások',8),
(12,'Erkölcsi levelek',8),
(13,'Az ember földje',9),
(14,'Cyrano De Bergerac',10),
(15,'1984',11),
(16,'A jéghegy csúcsa',12),
(17,'Fizikusok',13),
(18,'Ördögök',14),
(19,'Megalázottak és megszomorítottak',14),
(20,'A közöny',15);

INSERT INTO idezet VALUES
(2,'A félelem forrása a jövõben van, s aki megszabadul a jövõtõl, annak nincs félnivalója.',2),
(3,'A tolerancia bûn, ha a gonosz megtûrését jelenti.',3),
(4,'Az ember gyorsan beletanul abba, aminek belsõleg szükségét érzi.',3),
(5,'A mûvészet fölfokozott élet. Mélyebben boldogít, gyorsabban fölemészt.',4),
(6,'- Mi az az optimizmus? (...) - Semmi más, sajnos (...), mint annak a dühös bizonygatása, hogy minden a legeslegjobb, mikor minden a legrosszabb.',3),
(7,'Örülök annak, amim van, s nem búsulok azon, amim nincs.',4),
(8,'Minden olyan szerzemény, amely nem felel meg a ráfordított munkának, becstelen.',4),
(9,'Ha szeretünk, az egész embert szeretjük, amilyen, nem amilyennek akarom, hogy legyen.',4),
(10,'A szavak arra valók, hogy elrejtsék gondolatainkat.',7),
(11,'Egy embert csak akkor érthetsz meg, ha bele tudod képzelni magadat az érzelmeibe.',8),
(12,'Minden jó azoknak jut, akik megszerzik a tudást.',8),
(13,'Jobban szeretem, ha mindenki utál, mint ha színeskednem kell bárki szeretetéért.',9),
(14,'Mindenek fölött Légy hû magadhoz: így, mint napra éj, Következik, hogy ál máshoz se léssz.',10),
(15,'Nincs miért félned, hogy kárba vész a fáradságod: magadnak tanultál.',11),
(16,'A legnagyobb hatalom: önmagunknak parancsolni.',12),
(17,'Az ember akkor fedezi föl magát, amikor megmérkõzik az akadállyal.',13),
(18,'Szeretni nem annyit jelent, mint egymás szemébe nézni, hanem azt jelenti: együtt nézni ugyanabba az irányba.',13),
(19,'Mert magamat kigúnyolom, ha kell, De hogy más mondja, azt nem tûröm el!',14),
(20,'Talán nem is annyira azt kívánja az ember, hogy szeressék, inkább azt, hogy megértsék.',15),
(21,'Mindnyájan arra születtünk, amit csinálunk (...). Ahhoz van tehetséged, amivel a megélhetésedet megszerzed, mindegy, hogy mivel.',16),
(22,'Az igazi szabadság nem más, mint annak belátása, hogy nem vagyunk szabadok.',17),
(23,'Azok, akik jól tudnak beszélni, röviden beszélnek.',18),
(24,'Nincs is a földön olyan szerelem, hogy mind a ketten egyformán szeressék egymást.',14),
(25,'Abban talán nem vagyok biztos, hogy mi érdekel valójában, de hogy mi nem érdekel, abban egészen biztos vagyok.',15);

INSERT INTO utalas VALUES
(2,1),
(3,2),
(4,3),
(5,4),
(6,5),
(7,5),
(8,6),
(9,7),
(10,8),
(11,9),
(12,3),
(13,10),
(14,10),
(15,3),
(16,10),
(17,10),
(18,7),
(19,10),
(20,7),
(21,11),
(22,12),
(23,13),
(24,7),
(25,10);