using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tap2Move : MonoBehaviour
{
    public int tapCount;
    public float doubleTapTimer;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tap();
    }

    void tap()
    {
        
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began)
         {
             tapCount++;
         }
         if (tapCount > 0)
         {
             doubleTapTimer += Time.deltaTime;
             
         }
         if (tapCount >= 2)
         {
             //What you want to do
             transform.Translate(Vector3.forward * speed );
             doubleTapTimer = 0.0f;
             tapCount = 0;
         }
         if (doubleTapTimer > 0.5f)
         {
             doubleTapTimer = 0f;
             tapCount = 0;
         }
    }

    public void moveUp()
    {
        transform.Translate(Vector3.forward * .08f );
    }

    public void moveDown()
    {
        transform.Translate(Vector3.back * .08f);
    }
}

