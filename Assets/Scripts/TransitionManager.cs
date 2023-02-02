using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

/* 
 * Script written by: Bethany Zeya Longid for NEAR8 | Contact: bzlongid@gmail.com
 * There are two types of transitions: intro and string.
 * Transitions work by setting the "rig" (i.e. game objects that are animated, making up the transition) active or inactive.
 * All rigs have an entry animation which make up the transition. Please see animators on each rig component for more information.
 */

public class TransitionManager : MonoBehaviour
{
    [Header("Scene type")]
    [Tooltip("If the predecessing scene is the hallway. If false, scene will default to string intro.")]
    public bool intro;
    [Space(5)]

    [Header("Transition rigs:")]
    //IntroRigs consist of one Game Object: a virtual cam and can be put into a List directily.
    public List<GameObject> IntroRigs;
    private int IntroIdx = 0;

    //StringRigs consist of multiple Game Objects: (typically) a virtual cam and a "string", these will make a List of Lists in Start.
    private List<List<GameObject>> StringRigs;
    public List<GameObject> StringRig1;
    public List<GameObject> StringRig2;
    public List<GameObject> StringRig3; // If you make a new string intro, make a new list (i.e. "StringRigX") and add it to StringRigs in Start().
    private int StringIdx = 0;
    [Space(5)]

    [Header("Outro")]
    [SerializeField] private Animator OutroAnim;

    private void Start()
    {
        //Check previous scene, if Hallway, intro bool = true
        if (Indestructable.instance.prevSceneName.Contains("Hallway Updated"))
        {
            intro = true;
        }
        else
        {
            intro = false;
        }


        //Build the StringRigs list
        StringRigs = new List<List<GameObject>>();
        StringRigs.Add(StringRig1);
        StringRigs.Add(StringRig2);
        StringRigs.Add(StringRig3);

        ClearAllTransitions();

        if (intro)
            PlayRandomIntro();
        else
            PlayRandomStringTransition();
        
    }

    private void Update()
    {
        //For demo purposes
        if (Input.GetKeyDown(KeyCode.Q))
        {
            PlayNextIntro();
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayRandomIntro();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayNextStringTransition();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            PlayRandomStringTransition();
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            PlayOutro();
        }
    }

    //Set all transition rigs to false
    public void ClearAllTransitions()
    {
        foreach (var rig in StringRigs)
        {
            foreach (var component in rig)
            {
                component.SetActive(false);
            }
        }

        for (var i = 0; i < IntroRigs.Count; i++)
        {
            IntroRigs[i].SetActive(false);
        }
    }

    public void PlayNextIntro()
    {
        ClearAllTransitions();

        //Play the next intro
        IntroRigs[IntroIdx].SetActive(true);

        //Increment the idx
        if (IntroIdx == (IntroRigs.Count - 1))
            IntroIdx = 0;
        else
            IntroIdx++;
    }

    public void PlayRandomIntro()
    {
        ClearAllTransitions();
        int RandIdx = Random.Range(0, IntroRigs.Count);
        IntroRigs[RandIdx].SetActive(true);
    }

    public void PlayNextStringTransition()
    {
        ClearAllTransitions();
        
        foreach (var component in StringRigs[StringIdx])
            component.SetActive(true);

        if (StringIdx == (StringRigs.Count - 1))
            StringIdx = 0;
        else
            StringIdx++;
    }

    public void PlayRandomStringTransition()
    {
        ClearAllTransitions();
        int RandIdx = Random.Range(0, StringRigs.Count);
        List<GameObject> RandRig = StringRigs[RandIdx];

        foreach (var component in RandRig)
            component.SetActive(true);
    }

    public void PlayOutro()
    {
        OutroAnim.Play("Outro");
    }
}
