# Encuentros Probados de la Tierra Media

Este ejercicio está basado en el ejercicio [Roleplay Game](https://github.com/ucudal/PII_RoleplayGame_CompDel_Start) que hicimos anteriormente.

En esta versión del juego encontrarán algunas modificaciones respecto de la versión "Start" anterior del juego, con algunos elementos nuevos y algunos cambios en el funcionamiento del juego que deberán ir descubriendo.

## Objetivo

El desafío de este ejercicio es probar que la lógica del juego funciona correctamente. Para ellos escribiremos una serie de casos de Test.

Se provee un proyecto de Test en el directorio `tests/` con un [Test de ejemplo](tests/items/Gauntlet.cs).

## Desafío

El desafío será probar que los siguientes escenarios funcionan correctamente:

### 1. Items

🥉1. El item `MagicStick` tiene un poder de ataque equivalente a (`ataque de magia + ( ataque de stick * 3 )` )

🥉2. El item `MagicStick` tiene el poder de defensa de la magia que tiene.

### 2. Characters

🥉3. La creación de un Elf le asigna vida 120 y un item `Robes`.

🥉4. La creación de un Troll le asigna vida 150 y los items `Armor` y `Stick`.

🥉5. La creación de un Wizard le asigna vida 80 y un item `Magic`.

🥉6. Cuando un character tiene vida 0, su propiedad `isDead` es verdadera; de lo contrario es falsa.

🥈7. Al crear un personaje y asignarle un item `Magic` su poder de ataque aumenta de forma acorde.

🥈8. Al crear un personaje y asignarle un item `Magic` su poder de defensa aumenta de forma acorde.

🥈9. Al quitarle el item `Magic` su poder de ataque se reduce de forma acorde.

🥈10. Al quitarle el item `Magic` su poder de defensase reduce de forma acorde.

🥈11. Al crear un personaje y asignarle dos items de ataque, el poder de ataque es la suma de los poderes de ataque de ambos.

🥈12. Al crear un personaje y asignarle dos items de defensa, el poder de defensa la suma de los poderes de ataque de ambos.

🏅13. Al quitarle a un personaje un item que no tiene se tira una excepción de tipo `ItemNotFoundException`.

🥈14. Cuando un personaje recibe un ataque, su vida disminuye según `poder de ataque - defensa del personaje`.

🥈15. Cuando un personaje recibe un ataque, su vida nunca puede ser menor que 0.

🥈16. Cuando un personaje recibe un ataque y su defensa es _mayor_ al ataque, su vida no se modifica.

### 3. Encounters

🥈17. Cuando se da un encuentro de tipo `ExchangeEncounter` entre dos personajes y un elemento, el emisor pierde el elemento y el receptor lo gana.

🏅18. Cuando se da un encuentro de tipo `ExchangeEncounter` entre dos personajes y varios elementos, el emisor pierde todos los elementos y el receptor los gana.

🏅19. Cuando se da un encuentro de tipo `ExchangeEncounter` entre dos personajes y un elemento que el emisor no tiene, se genera una excepción de tipo ItemNotFoundException.

🏅20. Cuando se da un encuentro de tipo `AttackEncounter` entre dos personajes, la batalla debe tener el resultado esperado. **Aquí se generan varios casos de Test**, por ejemplo:

-   20.1. Si un personaje no tiene defensa ni ataque y el otro tiene ataque, el primero debe perder.
-   Etc.

💎21. Cuando se da un encuentro de tipo `AttackEncounter`, el encuentro termina en el momento en que uno de los dos personajes muere. **Aquí también se generan varios tests**.

### Nota:
Algunos de estos puntos generan más de un test. Como ejercicio, deberán identificar ustedes los casos a probar en cada uno de esos casos. 

Como referencia, una implementación "_solución_" de este ejercicio cuenta con 28 casos de test.
