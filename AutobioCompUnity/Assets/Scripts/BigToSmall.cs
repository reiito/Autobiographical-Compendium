using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigToSmall : StateMachineBehaviour
{
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        PlayerManager.Instance.StartCoroutine(PlayerManager.Instance.DelayAndMove());
    }
}
