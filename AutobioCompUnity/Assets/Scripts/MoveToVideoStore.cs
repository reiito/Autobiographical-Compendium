using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToVideoStore : StateMachineBehaviour
{
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameManager.Instance.StartCoroutine(GameManager.Instance.RunVideoStore());
    }
}
