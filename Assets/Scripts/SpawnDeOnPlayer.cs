using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDeOnPlayer : MonoBehaviour
{
    public GameObject despawn1;
    public GameObject despawn2;
    public GameObject despawn3;
    public GameObject despawn4;
    public GameObject despawn5;
    public GameObject despawn6;

    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public GameObject spawn4;
    public GameObject spawn5;
    public GameObject spawn6;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.CompareTag("Player"))
        {
            //despawn
            despawn1.SetActive(false);
            despawn2.SetActive(false);
            despawn3.SetActive(false);
            despawn4.SetActive(false);
            despawn5.SetActive(false);
            despawn6.SetActive(false);

            //spawn
            spawn1.SetActive(true);
            spawn2.SetActive(true);
            spawn3.SetActive(true);
            spawn4.SetActive(true);
            spawn5.SetActive(true);
            spawn6.SetActive(true);
        }
    }
}
