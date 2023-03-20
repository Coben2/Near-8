using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackState : StateMachineBehaviour
{
    Transform player;
    //public float Speed = 1f;
    CreditsVariable credits;
    public float waitTilDamage;
    public Text assigned;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        assigned = GameObject.FindGameObjectWithTag("assigned").GetComponent<Text>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        credits = GameObject.FindGameObjectWithTag("Player").GetComponent<CreditsVariable>();
        assigned.color = Color.black;
        waitTilDamage = 10f;
        //animator.GetComponent<LookAtCoroutine>().DoRotate();
    }

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        waitTilDamage -= 1;

        animator.GetComponent<LookAtCoroutine>().DoRotate();
        //StartCoroutine(LookAt());
        //animator.transform.LookAt(player);
        float distanceFromPlayer = Vector3.Distance(player.position, animator.transform.position);

        if (waitTilDamage <= 0)
        {
            assigned.color = Color.cyan;
            credits.DrainCredits();
            waitTilDamage = 10f;
        }


        if (distanceFromPlayer > 1.3f)
        {
            animator.SetBool("IsAttacking", false);
        }
    }

    //private IEnumerator LookAt()
    //{
    //    Quaternion lookRotation = Quaternion.LookRotation(player.position - animator.transform.position);

    //    float time = 0;

    //    while (time < 1) 
    //    {
    //        animator.transform.rotation = Quaternion.Slerp(animator.transform.rotation, lookRotation, time);
    //        time += Time.deltaTime * Speed;
    //        yield return null;
    //    }
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

    }

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
