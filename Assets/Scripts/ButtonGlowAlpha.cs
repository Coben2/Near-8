using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum FadeAction
{
//    FadeIn,
//    FadeOut,
    FadeInAndOut,
//    FadeOutAndIn
}


public class ButtonGlowAlpha : MonoBehaviour
{
        [Tooltip("The Fade Type.")]
        [SerializeField] private FadeAction fadeType;

        [Tooltip("the image you want to fade, assign in inspector")]
        [SerializeField] private Image img;

    public Color color;

        void OnEnable()
        {
        //        if (fadeType == FadeAction.FadeIn)
        //        {

        //            StartCoroutine(FadeIn());

        //        }

        //        else if (fadeType == FadeAction.FadeOut)
        //        {

        //            StartCoroutine(FadeOut());

        //        }

        //        else if (fadeType == FadeAction.FadeInAndOut)
        //        {
        if (fadeType == FadeAction.FadeInAndOut)
        {
            StartCoroutine(FadeInAndOut());
        }

    //        }

    //        else if (fadeType == FadeAction.FadeOutAndIn)
    //        {

    //            StartCoroutine(FadeOutAndIn());

    //        }
        }

    //    // fade from transparent to opaque
    //    IEnumerator FadeIn()
    //    {

    //        // loop over 1 second
    //        for (float i = 0; i <= 1; i += Time.deltaTime)
    //        {
    //            // set color with i as alpha
    //            img.color = new Color(1, 1, 1, i);
    //            yield return null;
    //        }

    //    }

    //    // fade from opaque to transparent
    //    IEnumerator FadeOut()
    //    {
    //        // loop over 1 second backwards
    //        for (float i = 1; i >= 0; i -= Time.deltaTime)
    //        {
    //            // set color with i as alpha
    //            img.color = new Color(1, 1, 1, i);
    //            yield return null;
    //        }
    //    }

    IEnumerator FadeInAndOut()
    {
        // loop over 1 second
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(color.r, color.g, color.b, i);
            yield return null;
        }

        //Temp to Fade Out
        yield return new WaitForSeconds(0);

        // loop over 1 second backwards
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {
            // set color with i as alpha
            img.color = new Color(color.r, color.g, color.b, i);
            yield return null;
        }
        for (int x = 1; x <= 5; x++)
        {
            StartCoroutine(FadeInAndOut());
        }
        
    }

    //    IEnumerator FadeOutAndIn()
    //    {
    //        // loop over 1 second backwards
    //        for (float i = 1; i >= 0; i -= Time.deltaTime)
    //        {
    //            // set color with i as alpha
    //            img.color = new Color(1, 1, 1, i);
    //            yield return null;
    //        }

    //        //Temp to Fade In
    //        yield return new WaitForSeconds(1);

    //        // loop over 1 second
    //        for (float i = 0; i <= 1; i += Time.deltaTime)
    //        {
    //            // set color with i as alpha
    //            img.color = new Color(1, 1, 1, i);
    //            yield return null;
    //        }
    //    }
    //}
}

    //public GameObject button;
    //public byte Alpha;
    //[Range(0.0f, 1.0f)]
    //public float AlphaFloat;

//// Start is called before the first frame update
//void Start()
//{
//    AlphaFloat = 0f;
//}

//// Update is called once per frame
//void Update()
//{

//    if (AlphaFloat >= 0)
//    {
//        AlphaFloat += Time.deltaTime;
//    }
//    //if (AlphaFloat <= 1)
//   // {
//    //    AlphaFloat -= Time.deltaTime;
//    //}
//    Alpha = (byte) ((int)AlphaFloat * 255);
//    button.GetComponent<Image>().color = new Color32(255, 255, 225, Alpha);
//}

