using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{

    public GameObject thePlayer;
    public Animator animator;
    public GameObject liveCoins;
    public GameObject liveDis;

    public GameObject FadeOut;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            animator.SetBool("isVictory", true);
            PlayerMove.canMove = false;
            //StartCoroutine(FinishLv());
        }
    }

    IEnumerator FinishLv()
    {
        yield return new WaitForSeconds(3);
        liveCoins.SetActive(false);
        liveDis.SetActive(false);
        FadeOut.SetActive(true);
    }
}
