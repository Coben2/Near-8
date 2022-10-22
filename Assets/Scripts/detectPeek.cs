using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectPeek : MonoBehaviour
{
    public GameObject ball;
    public gameManager gManage;
    public SwipeLogger swipeLogScript;

    public bool triggered;
    // Start is called before the first frame update
    void Start()
    {
        triggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gManage.triggered == true)
        {
            lockIn();
        }
    }

    public void lockIn()
    {
        ball.transform.position = transform.position;
       
    }


     public void OnTriggerEnter()
    {
       
       gManage.gameState = 4;
       gManage.dPeek = gameObject.GetComponent<detectPeek>();
       gManage.peekObj = transform.position;
       
    }
}
