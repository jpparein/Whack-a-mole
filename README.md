# Whack a Mole

**Whack a Mole** est un jeu d’arcade 2D développé avec **Unity**.
Le joueur doit frapper les taupes lorsqu’elles sortent de leurs trous afin de marquer un maximum de points avant la fin de la partie.

---

## 🎮 Présentation

Le jeu reprend le principe classique du **Whack-a-Mole** dans une ambiance cartoon, colorée et accessible.

Le gameplay est volontairement simple :

* une taupe apparaît
* le joueur clique dessus
* le score augmente
* la taupe redescend
* une nouvelle taupe apparaît

Ce projet est idéal pour apprendre les bases d’un jeu 2D avec Unity.

---

## 🧩 Fonctionnalités

* Apparition des taupes
* Animation de montée et de descente
* Détection du clic joueur
* Changement de sprite lorsque la taupe est frappée
* Gestion du score
* Interface utilisateur simple
* Menu principal
* Écran Game Over
* Assets graphiques 2D au style cartoon
* Sprites avec transparence

---

## 🛠️ Technologies utilisées

* **Unity**
* **C#**
* **2D Sprite Renderer**
* **Animator**
* **UI Unity**
* **Coroutines**

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

Script responsable du comportement d’une taupe.

Il gère :

* l’animation de sortie
* l’animation de rentrée
* l’autorisation du clic
* le changement de sprite quand la taupe est touchée

---

### GameManager.cs

Script responsable de la logique principale du jeu.

Il peut gérer :

* le score
* le temps de jeu
* le déclenchement des taupes
* la fin de partie
* le passage à l’écran Game Over

---

### UIManager.cs

Script responsable de l’affichage de l’interface.

Il peut gérer :

* le score affiché à l’écran
* le timer
* les boutons du menu
* l’écran de fin de partie

---

## 🚀 Installation

Cloner le dépôt :

```bash
git clone https://github.com/jpparein/Wack-a-mole.git
```

Ouvrir ensuite le projet avec **Unity Hub**.

---

## ▶️ Lancer le jeu

1. Ouvrir le projet dans Unity
2. Charger la scène principale
3. Cliquer sur **Play**
4. Frapper les taupes dès qu’elles apparaissent

---

## 🖼️ Assets graphiques

Le projet utilise des assets 2D au style cartoon :

* logo du jeu
* background
* taupes
* marteau
* boutons en bois
* sprite Game Over
* éléments de décor

Le style graphique repose sur des couleurs chaudes, avec un mélange de bois, terre, ombres cartoon et contours épais.

---

## 📌 Objectif pédagogique

Ce projet permet de travailler plusieurs notions importantes dans Unity :

* création d’un jeu 2D simple
* utilisation des sprites
* gestion des animations
* utilisation des coroutines
* détection du clic souris
* gestion d’un score
* création d’une interface utilisateur
* organisation propre d’un projet Unity

---

## ✅ Améliorations possibles

* Ajouter plusieurs types de taupes
* Ajouter des bonus
* Ajouter des malus
* Ajouter une difficulté progressive
* Ajouter un timer
* Ajouter des sons
* Ajouter une musique de fond
* Ajouter un classement des meilleurs scores
* Ajouter une version WebGL jouable dans le navigateur

---

## 📦 Plateformes possibles

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
Projet Unity 2D — **Whack a Mole**
