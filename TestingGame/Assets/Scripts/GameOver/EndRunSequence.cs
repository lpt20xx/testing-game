using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndRunSequence : MonoBehaviour
{

    public GameObject liveCoins;
    public GameObject liveDis;
    public GameObject endScreen;
    public GameObject FadeOut;

    public static bool isFall;

    private void Update()
    {
        this.EndRun();
    }

    protected virtual void EndRun()
    {
        if (isFall)
        {
            StartCoroutine(EndSequence());
        }
        
    }

    IEnumerator EndSequence()
    {
        yield return new WaitForSeconds(3);
        liveCoins.SetActive(false);
        liveDis.SetActive(false);
        endScreen.SetActive(true);
        FadeOut.SetActive(true);
    }
}
