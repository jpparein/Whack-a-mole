using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

// ============================================================
// GameOver.cs - Gere l'ecran de game over
// Attend 5 secondes puis retourne au menu principal.
// ============================================================
public class GameOver : MonoBehaviour
{
    // --- Coroutine demarree automatiquement au lancement ---
    IEnumerator Start()
    {
        yield return new WaitForSeconds(5f);        // Attend 5 secondes avant de revenir au menu
        SceneManager.LoadScene("Menu");              // Charge la scene du menu principal
    }
}
