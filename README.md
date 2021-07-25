# CertifCalculator

Application dektop pour faciliter le décompte des scores lorsque l'on fait des dumps.

A chaque question on enregistre le nombre de points attribués (partie gauche du formulaire). A chaque réponse on enregistre le nombre de points marqués (partie droite du formulaire).
L'application calcule alors le score et l'affiche. Elle affiche également un rappel du score précédent (11).
Elle surveille également le nombre de questions posées et le nombre de questions répondues. Un visuel alerte si ces valeurs sont différentes.

L'application assure également une persistance. Si on la relance elle redémarre là où on l'a fermée.


![image](https://user-images.githubusercontent.com/5559134/126912732-921e1b58-c3e6-496c-ae39-57ad9d959c68.png)

1 => zone des questions, entre parenthèse nombre de points de la question précédente
2 => zone des réponse. Entre parenthèse nombre de points enregistré à la question qui précède
3 => affiche du score. Si le fond est vert le nombre de réponse est le même que le nombre de questions. Sinon il est vert
4 => cumul points des questions (modifiable)
5=> cumul points des réponses (modifiable)
6 => nombre de points associés à la question en court. Incrémente 4
7 => nombre de points gagnés. Incrémente 5
8 => nombre de questions posées (modifiable)
9 => nombre de questions répondues (modifiable)
10 => zone de saisie utile si on referme le formulaire. On peut y mettre par exemple le numéro de la dernière question répondue
11 => score précédent

