# 🐹 Whack a Mole

**Whack a Mole** est un petit jeu d’arcade développé avec **Unity**, inspiré du célèbre jeu de la taupe.
Le principe est simple : des taupes apparaissent aléatoirement dans leurs trous, et le joueur doit les frapper le plus rapidement possible pour marquer un maximum de points.

---

## 🎮 Aperçu du jeu

Le jeu propose une ambiance cartoon, colorée et simple à comprendre, idéale pour un projet Unity débutant ou une démonstration pédagogique.

### Objectif

* Cliquer sur les taupes lorsqu’elles sortent
* Marquer des points
* Éviter de rater trop d’apparitions
* Faire le meilleur score possible avant la fin de la partie

---

## 🧩 Fonctionnalités

* Apparition aléatoire des taupes
* Animation montée / descente
* Détection du clic joueur
* Changement de sprite quand la taupe est touchée
* Gestion du score
* Écran de menu
* Écran Game Over
* Interface simple et lisible
* Graphismes cartoon adaptés à un jeu casual

---

## 🛠️ Technologies utilisées

* **Unity**
* **C#**
* **Sprites 2D**
* **Animator Unity**
* **UI Unity**

---

## 📁 Structure du projet

```txt
Assets/
├── _Project/
│   ├── Animations/
│   ├── Art/
│   ├── Audio/
│   ├── Prefabs/
│   ├── Scenes/
│   ├── Scripts/
│   └── UI/
```

---

## 🎯 Scripts principaux

### Mole.cs

Gère le comportement d’une taupe :

* Lancement de l’animation
* Activation du clic
* Désactivation du clic
* Changement de sprite quand la taupe est frappée

### GameManager.cs

Gère la logique globale du jeu :

* Score
* Temps de jeu
* Lancement des vagues
* Fin de partie

### UIManager.cs

Gère l’interface :

* Affichage du score
* Affichage du timer
* Menu principal
* Écran Game Over

---

## 🚀 Lancer le projet

1. Cloner le dépôt :

```bash
git clone https://github.com/ton-compte/whack-a-mole.git
```

2. Ouvrir le projet avec **Unity Hub**

3. Charger la scène principale :

```txt
Assets/_Project/Scenes/Menu.unity
```

4. Cliquer sur **Play**

---

## 🖼️ Assets graphiques

Le jeu utilise des sprites 2D avec transparence :

* Logo du jeu
* Boutons bois
* Marteau
* Taupes
* Background
* Sprite Game Over

Les visuels sont pensés pour garder un style homogène :
bois, terre, couleurs chaudes, contour cartoon et rendu arcade.

---

## 📌 Objectif pédagogique

Ce projet peut servir de base pour apprendre :

* Les bases d’un jeu 2D Unity
* Les collisions / clics souris
* Les coroutines
* Les animations avec Animator
* La gestion d’un score
* La création d’une interface simple
* L’organisation propre d’un projet Unity

---

## ✅ Améliorations possibles

* Ajouter plusieurs types de taupes
* Ajouter des bonus
* Ajouter des malus
* Ajouter un système de niveaux
* Ajouter une difficulté progressive
* Ajouter des sons et musiques
* Ajouter un classement des meilleurs scores
* Ajouter une version WebGL

---

## 📦 Build

Le projet peut être exporté vers :

* Windows
* WebGL
* Android
* Linux
* macOS

---

## 📜 Licence

Projet réalisé à des fins pédagogiques et démonstratives.

---

## 👤 Auteur

Développé par **Jean-Philippe Parein**
Projet Unity 2D — Whack a Mole
