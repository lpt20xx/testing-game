using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CDStartLevel : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownGO;


    public GameObject fadeIn;

    public AudioSource readyFX;
    public AudioSource goFX;

    // Start is called before the first frame update
    private void Start()
    { 
        this.StartCountDown();
    }

    


    protected virtual void StartCountDown()
    {
        StartCoroutine(CountSequence());
    }

    IEnumerator CountSequence()
    {
        //countdown
        yield return new WaitForSeconds(1.5f);
        countDown3.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countDown2.SetActive(true);
        readyFX.Play();
        yield return new WaitForSeconds(1);
        countDown1.SetActive(true);
        readyFX.Play();

        //GO!
        yield return new WaitForSeconds(1);
        countDownGO.SetActive(true);
        goFX.Play();

        //player is able to move
        PlayerMove.canMove = true;
    }
}
