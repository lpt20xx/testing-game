using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameObject thePlayer;
    public static GameObject charModel;
    
    public AudioSource crashThud;

    public Animator animator, animatorCam;
    public GameObject mainCam;

    public GameObject levelControl;


    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            thePlayer.GetComponent<PlayerMove>().enabled = false;
            animator.Play("Stumble Backwards");
            crashThud.Play();
            animatorCam.enabled = true;

            PlayerMove.canMove = false;

            levelControl.GetComponent<EndRunSequence>().enabled = true;

            EndRunSequence.isFall = true;
        }
    }
}
