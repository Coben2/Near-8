using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookingToPlayerState : StateMachineBehaviour
{
    public float lookatTimer;
    LookAtCoroutine childLookScript;
    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        childLookScript = animator.GetComponentInChildren<LookAtCoroutine>();
        //    MyScript childScript = originalGameObject.GetComponentInChildren<MyScript>();
        lookatTimer = 10;
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        lookatTimer -= Time.deltaTime;

        childLookScript.DoRotate();

        if (lookatTimer <= 0)
        {
            animator.SetBool("PlayerPresent", false);
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}
}
