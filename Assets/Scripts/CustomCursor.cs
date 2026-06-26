using UnityEngine;
using UnityEngine.InputSystem;

// ============================================================
// CustomCursor.cs - Remplace le curseur systeme par un sprite anime
// Le curseur suit la souris et joue une animation au clic.
// ============================================================
public class CustomCursor : MonoBehaviour
{
    private RectTransform rectTransform;  // Position du curseur UI
    private Animator animator;            // Gere l'animation de frappe

    // --- Initialisation ---
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();  // Recupere le composant UI
        animator = GetComponent<Animator>();            // Recupere l'Animator

        Cursor.visible = false;                        // Cache le curseur systeme de Windows
        Cursor.lockState = CursorLockMode.Confined;    // Garde le curseur dans la fenetre du jeu
    }

    // --- A chaque frame ---
    void Update()
    {
        if (Mouse.current != null)  // Verifie que la souris existe (pas de gamepad)
        {
            Vector2 mousePosition = Mouse.current.position.ReadValue();  // Recupere la position de la souris
            rectTransform.position = mousePosition;                      // Deplace le curseur a cette position

            if (Mouse.current.leftButton.wasPressedThisFrame)  // Si le bouton gauche est enfonce
            {
                animator.SetTrigger("tap");  // Joue l'animation de frappe du maillet
            }
        }
    }
}
