using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset = new Vector3(0, 3, -4);
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        this.SetCameraFollowPlayer();
    }

    protected virtual void SetCameraFollowPlayer()
    {
        transform.position = this.player.transform.position + this.offset;
    }
    

}
