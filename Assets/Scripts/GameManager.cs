using UnityEngine;
using System.Collections;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Mole[] moles;
    [SerializeField] private float moleShowInterval = 2f;
    [SerializeField] private TMP_Text txtCountdown;

    [SerializeField] private int startDuration = 60;
    private int currentDuration;
    private Coroutine ShowMolesCoroutine;
    private Coroutine TimerCoroutine;
    public int score;
    public TMP_Text txtScore;

    void Start()
    {
        ShowMolesCoroutine = StartCoroutine(ShowMoles());
        TimerCoroutine = StartCoroutine(Timer());
        score=0;
        txtScore.text = score.ToString("00");
    }

    IEnumerator ShowMoles()
    {
        while (true)
        {
            int randomIndex = Random.Range(0, moles.Length);
            moles[randomIndex].Animate();
            yield return new WaitForSeconds(moleShowInterval);
        }
    }

    IEnumerator Timer()
    {
        currentDuration = startDuration;
        while (currentDuration > -1)
        {
            txtCountdown.text = currentDuration.ToString("00");
            yield return new WaitForSeconds(1f);
            currentDuration--;
        }
        StopCoroutine(ShowMolesCoroutine);
    }
}
