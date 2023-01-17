using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    public AudioSource theAudio;

    // Start is called before the first frame update
    void playAudio()
    {
        theAudio.enabled = true;
    }

    void stopAudio()
    {
        theAudio.enabled = false;
    }
}
