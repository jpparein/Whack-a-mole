using UnityEngine;
using System.Collections;
public class Mole : MonoBehaviour
{
    private Animator animator;
    private bool canClick = false;   
    private Coroutine moleCoroutine;
  
    public float speed = 1f;
    public float duration = 3f;

    [SerializeField] private Sprite moleNormal, MoleClicked;
    [SerializeField] private SpriteRenderer moleSpriteRenderer;
    [SerializeField] private GameManager gameManager;

    void Awake()
    {
        animator = GetComponentInParent<Animator>();       
        animator.speed = speed;         
    }

    IEnumerator AnimateMole()
    {
       moleSpriteRenderer.sprite = moleNormal;
       animator.speed = speed;
       animator.SetTrigger("goup");
       canClick = true;
       yield return new WaitForSeconds(duration); 
       animator.SetTrigger("godown");
       canClick = false;
    }

    public void Animate()
    {
        moleCoroutine = StartCoroutine(AnimateMole());
    }

    void OnMouseDown()
    {
        if (!canClick) return;        
        moleSpriteRenderer.sprite = MoleClicked;
        gameManager.score++;
        gameManager.txtScore.text = gameManager.score.ToString("00");

        StopCoroutine(moleCoroutine);
        animator.SetTrigger("godown");
        canClick = false;
        
    } 

       
}
