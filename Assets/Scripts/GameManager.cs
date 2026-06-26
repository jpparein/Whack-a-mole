using UnityEngine;
using System.Collections;
using TMPro;

// ============================================================
// GameManager.cs - Controleur principal du jeu
// Gere le timer, le score et l'apparition des moles.
// ============================================================
public class GameManager : MonoBehaviour
{
    // --- Configuration dans l'Inspector ---
    [SerializeField] private Mole[] moles;              // Tableau contenant tous les moles de la scene
    [SerializeField] private TMP_Text txtCountdown;     // Texte affichant le temps restant
    [SerializeField] private int startDuration = 60;    // Duree de la partie en secondes
    [SerializeField] private GameObject PanelGameOver;
    // --- Variables internes ---
    private int currentDuration;                        // Temps restant en secondes
    private Coroutine ShowMolesCoroutine;               // Reference a la coroutine d'apparition
    private Coroutine TimerCoroutine;                   // Reference a la coroutine du timer
    private AudioSource audio;                          // Source audio pour le game over

    // --- Score (public pour etre accessible par Mole.cs) ---
    public int score;
    public TMP_Text txtScore;                           // Texte affichant le score

    // --- Demarre le jeu au lancement ---
    void Start()
    {
        ShowMolesCoroutine = StartCoroutine(ShowMoles());  // Lance la boucle d'apparition
        TimerCoroutine = StartCoroutine(Timer());          // Lance le decompte
        score = 0;                                         // Score a zero au depart
        txtScore.text = score.ToString("00");              // Affiche le score initial
        audio = GetComponent<AudioSource>();                // Recupere l'AudioSource       
    }

    // --- Boucle principale : fait apparaitre les moles ---
    IEnumerator ShowMoles()
    {
        while (true)  // Boucle infinie, s'arrete quand le timer arrive a zero
        {
            int randomIndex = Random.Range(0, moles.Length);   // Choisit un mole au hasard
            float ratio = (float)currentDuration / startDuration;  // Ratio du temps restant (1.0 = debut, 0.0 = fin)

            if (!moles[randomIndex].isAnimating)               // Si le mole n'est pas deja actif
                moles[randomIndex].Animate();                   // Le fait apparaitre

            // Attend avant le prochain spawn (plus court = plus dur en fin de partie)
            yield return new WaitForSeconds(Mathf.Lerp(0.5f, 2f, ratio));
        }
    }

    // --- Decompte du temps ---
    IEnumerator Timer()
    {
        currentDuration = startDuration;                    // Initialise le compteur
        while (currentDuration > -1)                        // Tant qu'il reste du temps
        {
            txtCountdown.text = currentDuration.ToString("00");  // Affiche le temps (ex: "60", "05")
            yield return new WaitForSeconds(1f);            // Attend 1 seconde
            currentDuration--;                              // Decremente le compteur
        }
        StopCoroutine(ShowMolesCoroutine);                  // Arrete l'apparition des moles
        audio.Play();                                       // Joue le son de game over
        PanelGameOver.SetActive(true);
    }
}
