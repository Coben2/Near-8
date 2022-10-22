using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SFX : MonoBehaviour
{
    private Rigidbody rb;
    public float StartingPitch;
    private int playing;

  //  public Text vc;
    public AudioSource Roll;
    public AudioSource HitWall;
    public AudioSource HitWallHard;
    public AudioSource HitWallSoft;
    public AudioSource GameStart;
    public AudioSource GameEnd;

    public GameObject ballReturn;

    private Vector3 position;

    private float vx;
    private float vy;

    void Start ()
    {
        PlayGameStart();
        StartingPitch = Roll.pitch;
    }

    void Update ()
    {
        rb = GetComponent<Rigidbody>();
    //    vc.text = rb.velocity.ToString();
        vx = rb.velocity.x;
        vy = rb.velocity.y;

        if (vx > .3 || vy > .3 || vx < -.3 || vy < -.3)
        {
            if (Roll.isPlaying == false)
            {
                Roll.Play();
            }
            Roll.pitch += (vx+vy)/360;
        }
        else
        {
            Roll.Pause();
            Roll.pitch = StartingPitch;
        }
    }
    public void PlayRoll ()
    {
        Roll.Play();

    }
    public void PlayHitWall()
    {
        HitWall.Play();

    }
    public void PlayHitWallHard()
    {
        HitWallHard.Play();

    }
    public void PlayHitWallSoft()
    {
        HitWallSoft.Play();

    }
    public void PlayGameStart()
    {
    //    GameStart.Play();

    }
    public void PlayGameEnd()
    {
      //  GameEnd.Play();

    }

    // public void OnTriggerEnter()
    // {
    //   //  PlayGameEnd();
    //
    // }

    public void OnCollisionEnter()
    {
       if (vx > .8 || vy > .8 || vx < -.8 || vy < -.8)
       {
           PlayHitWallHard();
       }
       else if (vx > .4 ||vy > .4 || vx < -.4 || vy < -.4)
       {
           PlayHitWall();
       }
       else
       {
           PlayHitWallSoft();
       }

    }
}
