using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState2defalt : MonoBehaviour
{

    public gameManager1 Gmanager;

    public int StateChange;
    // Start is called before the first frame update
    void Update()
    {
        Gmanager.gameState = StateChange;
    }
}
