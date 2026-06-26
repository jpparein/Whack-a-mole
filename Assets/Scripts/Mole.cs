using UnityEngine;
using System.Collections;

// ============================================================
// Mole.cs - Gere le comportement d'un seul mole
// Un mole monte, reste visible un moment, puis redescend.
// Le joueur doit cliquer dessus pendant qu'il est visible
// pour gagner des points.
// ============================================================
public class Mole : MonoBehaviour
{
    // --- Composants Unity references ---
    private Animator animator;           // Gere les animations (montee/descente)
    private Coroutine moleCoroutine;     // Reference a la coroutine en cours (pour l'arreter)
    private AudioSource audio;           // Source audio pour les sons du mole

    // --- Etat du mole ---
    public bool isAnimating = false;     // Vrai si le mole est en train de monter/descendre
    private bool canClick = false;       // Vrai si le joueur peut cliquer dessus

    // --- Parametres reglables dans l'Inspector ---
    public float speed = 1f;             // Vitesse de l'animation (multiplicateur)
    [SerializeField] private Sprite moleNormal, MoleClicked;    // Sprites : normal et touche
    [SerializeField] private SpriteRenderer moleSpriteRenderer; // Le SpriteRenderer qui affiche le mole
    [SerializeField] private GameManager gameManager;            // Reference au GameManager pour le score
    [SerializeField] private AudioClip moleUp, moleDown, moleHit; // Sons du mole

    // --- Initialisation ---
    void Awake()
    {
        animator = GetComponentInParent<Animator>();   // Recupere l'Animator sur le parent (le prefab root)
        audio = GetComponent<AudioSource>();           // Recupere l'AudioSource sur ce GameObject
        animator.speed = speed;                        // Applique la vitesse d'animation
    }

    // --- Coroutine d'animation du mole ---
    // Fait monter le mole, attend, puis le fait redescendre
    IEnumerator AnimateMole()
    {
        isAnimating = true;                            // Marque le mole comme actif
        moleSpriteRenderer.sprite = moleNormal;        // Affiche le sprite normal
        audio.PlayOneShot(moleUp);                     // Joue le son d'apparition
        animator.SetTrigger("goup");                   // Declenche l'animation de montee
        canClick = true;                               // Le joueur peut maintenant cliquer

        // Attend un temps aleatoire avant de redescendre
        yield return new WaitForSeconds(Random.Range(0.5f, 2f));

        animator.SetTrigger("godown");                 // Declenche l'animation de descente
        audio.PlayOneShot(moleDown);                   // Joue le son de disparition
        canClick = false;                              // Desactive le clic
        isAnimating = false;                           // Le mole n'est plus actif
    }

    // --- Methode publique appelee par le GameManager ---
    // Lance l'animation si le mole n'est pas deja actif
    public void Animate()
    {
        if (isAnimating) return;                       // Si deja actif, on ignore
        moleCoroutine = StartCoroutine(AnimateMole()); // Lance la coroutine d'animation
    }

    // --- Gestion du clic sur le mole ---
    // Unity appelle cette methode automatiquement quand on clique sur le collider
    void OnMouseDown()
    {
        if (!canClick) return;                         // Si le mole n'est pas cliquable, on ignore

        // --- Le joueur a touche le mole ! ---
        moleSpriteRenderer.sprite = MoleClicked;       // Affiche le sprite touche (yeux en X)
        gameManager.score++;                           // Ajoute 1 point
        gameManager.txtScore.text = gameManager.score.ToString("00");  // Met a jour le texte du score
        audio.PlayOneShot(moleHit);                    // Joue le son de hit

        StopCoroutine(moleCoroutine);                  // Arrete la coroutine (empeche la descente auto)
        isAnimating = false;                           // Le mole n'est plus actif
        animator.SetTrigger("godown");                 // Fait redescendre le mole immediatement
        canClick = false;                              // Desactive le clic
    }
}
