using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    public AudioSource coinFX;

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            coinFX.Play();
            CollectableControl.coinCount += 1;
            this.gameObject.SetActive(false);
        }
        
    }
}
