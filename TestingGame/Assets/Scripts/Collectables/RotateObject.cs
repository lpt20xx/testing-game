using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public int rotateSpeed = 5;


    // Update is called once per frame
    void Update()
    {
        this.RotateGameObject();
    }

    protected virtual void RotateGameObject()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
