using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpToPosition : MonoBehaviour  //Some of code referenced from user achimmihca https://forum.unity.com/threads/ui-animate-fullscreen-panel-from-off-screen.271751/
{
    public enum Sides
    {
        Left,
        Right,
        Top,
        Bottom
    }

    /// The side from where the rect transform should fly in.
    public Sides side;

    /// The transition factor (from 0 to 1) between inside and outside.
    [Range(0, 1)]
    public float transition;

    /// Inside is assumed to be the start position of the RectTransform.
    private Vector2 inside;
    private Vector2 globalPosition;

    /// Outside is the position
    /// where the rect transform is completely outside of its canvas on the given side.
    private Vector2 outside;

    /// Reference to the rect transform component.
    private RectTransform rectTransform;
    /// Reference to the canvas component this RectTransform is placed on.
    private Canvas canvas;

    private bool clicked = false;
    public int duration;
    public float down;
    void Start()
    {
        transition = 0.28f;
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
        globalPosition = GetGlobalPosition(rectTransform);
        inside = rectTransform.localPosition;
        outside = inside + GetDifferenceToOutside();
    }
    Vector2 GetGlobalPosition(RectTransform trans)
    {
        // Calculate the global position of the RectTransform on the canvas
        // by summing up all local positions of parents.
        var pos = Vector3.zero;
        foreach (var parent in trans.GetComponentsInParent<RectTransform>())
        {
            if (parent.GetComponent<Canvas>() == null)
            {
                pos += parent.localPosition;
            }
            else
            {
                return pos;
            }
        }
        return pos;
    }
    void Update()
    {
        rectTransform.localPosition = Vector2.Lerp(outside, inside, transition);
    }
    //void CalculateOutside()
    //{
    //    outside = inside + GetDifferenceToOutside();
    //}
    Vector2 GetDifferenceToOutside()
    {
        // Pixel size of this RectTransform in normal resolution
        var size = rectTransform.rect.size;
        var pivot = rectTransform.pivot;
        // Pixel size of the canvas in normal resolution
        var canvasSize = canvas.GetComponent<RectTransform>().rect.size;
        // The summed up position has its origin in the center of the canvas.
        // However, in the calculation below, the position is assumed to have its origin in the lower left corner.
        // So we move the coords by canvasSize/2.
        var pos = globalPosition + (canvasSize / 2.0f);

        switch (side)
        {
            case Sides.Top:
                var distanceToTop = canvasSize.y - pos.y;
                return new Vector2(0f, distanceToTop + size.y * (pivot.y));
            case Sides.Bottom:
                var distanceToBottom = pos.y;
                return new Vector2(0f, -distanceToBottom - size.y * (1 - pivot.y));
            case Sides.Left:
                var distanceToLeft = pos.x;
                return new Vector2(-distanceToLeft - size.x * (1 - pivot.x), 0f);
            case Sides.Right:
                var distanceToRight = canvasSize.x - pos.x;
                return new Vector2(distanceToRight + size.x * (pivot.x), 0f);
            default:
                return Vector2.zero;
        }
    }

    public void Drawer()
    {
        if (clicked)
        {
            //transition = 0.28f;
            StartCoroutine(LerpUp());
            clicked = false;
        }
        else
        {
            //transition = 1f;
            StartCoroutine(LerpDown());
            clicked = true;
        }
    }
    public IEnumerator LerpDown()
    {
        //float time = 0;
        while (transition < duration)
        {
            transition += 0.05f;
            //time += Time.deltaTime;
            yield return null;
            if (transition >= 1)
            {
                yield break;
            }
        }
        
    }
    public IEnumerator LerpUp()
    {
        //float time = 0;
        while (transition > down)
        {
            transition -= 0.05f;
            //time += Time.deltaTime;
            yield return null;
            if (transition <= 0.28f)
            {
                yield break;
            }
        }
        
    }
}