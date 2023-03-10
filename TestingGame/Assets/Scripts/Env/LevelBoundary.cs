using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -4f;
    public static float rightSide = 4f;

    [SerializeField] private float internalLeft;
    [SerializeField] private float internalRight;

    // Update is called once per frame
    private void Update()
    {
        this.GetSide();
    }

    protected virtual void GetSide()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
