using System;
using UnityEngine;
using UnityEngine.Events;

public class ChallengeEventBehaviors : MonoBehaviour
{
    public UnityEvent mouseDownEvent, enableEvent, exitEvent, mouseDragEvent;

    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }

    private void OnEnable()
    {
        enableEvent.Invoke();
    }

    private void OnCollisionExit(Collision other)
    {
        exitEvent.Invoke();
    }

    private void OnMouseDrag()
    {
        mouseDragEvent.Invoke();
    }
}
