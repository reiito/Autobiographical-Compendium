using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroManager : MonoBehaviour
{
    public Text titleText;
    public float timeLimit = 1;
    public float dotLimit = 4;

    float dotTimer = 0;
    float dotCounter = 0;
    bool cycleDots;

    private void Start()
    {
        cycleDots = true;
    }

    private void Update()
    {
        UpdateDots();
    }

    void UpdateDots()
    {
        if (cycleDots)
        {
            if (dotTimer > timeLimit)
            {
                if (dotCounter < dotLimit)
                {
                    titleText.text += ".";
                    dotCounter++;
                }
                else
                {
                    cycleDots = false;
                    gameObject.SetActive(false);
                    AudioManager.Instance.PlayIntroSound();
                    AnimationManager.Instance.playerAnimator.SetTrigger("BigToSmall");
                }

                dotTimer = 0;
            }

            dotTimer += Time.deltaTime;
        }
    }
}
