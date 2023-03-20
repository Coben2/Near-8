using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCoroutine : MonoBehaviour
{
    Transform player;
    public float Speed = 1f;

    private Coroutine LookCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    public void DoRotate()
    {
        //Debug.Log("Rotate Called");
        if (LookCoroutine != null)
        {
            StopCoroutine(LookCoroutine);
        }
        LookCoroutine = StartCoroutine(LookAt());
    }
    private IEnumerator LookAt()
    {
        Quaternion lookRotation = Quaternion.LookRotation(player.position - transform.position);

        float time = 0;

        while (time < 1)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, time);
            time += Time.deltaTime * Speed;
            yield return null;
        }
    }
}
