using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public static AnimationManager Instance;

    public Animator playerAnimator;
    public Animator ps1Animator;

    public float awakeDelay;
    public float startDelay;
    public float ps1Delay;

    private void Awake()
    {
        Instance = this;
    }
}
