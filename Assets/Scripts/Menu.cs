using UnityEngine;
using UnityEngine.SceneManagement;

// ============================================================
// Menu.cs - Gere le menu principal du jeu
// Permet de lancer la partie et de re afficher le curseur.
// ============================================================
public class Menu : MonoBehaviour
{
    // --- Charge la scene du jeu (appele par un bouton UI) ---
    public void LoadGame() => SceneManager.LoadScene("Game");

    // --- Au demarrage du menu : affiche le curseur systeme ---
    private void Start()
    {
        Cursor.visible = true;                   // Affiche le curseur (caché pendant le jeu)
        Cursor.lockState = CursorLockMode.None;  // Debloque le curseur pour qu'il puisse bouger librement
    }
}
