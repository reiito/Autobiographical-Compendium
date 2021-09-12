using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    AnimationManager animationManager;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        animationManager = AnimationManager.Instance;
    }

    public IEnumerator DelayAndMove()
    {
        animationManager.playerAnimator.SetTrigger("StartBobbing");

        yield return new WaitForSeconds(animationManager.startDelay);

        GameManager.Instance.GameState = GameState.MOVING;

        animationManager.playerAnimator.SetTrigger("MoveToVideo");

        yield return new WaitForSeconds(animationManager.ps1Delay);

        animationManager.ps1Animator.SetTrigger("PopIn");
        AudioManager.Instance.PlayPSSound();
    }
}
