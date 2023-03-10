using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectableControl : MonoBehaviour
{

    public static int coinCount;
    public GameObject coinCountDisplay;
    public GameObject coinEndDisplay;


    // Start is called before the first frame update

    // Update is called once per frame
    private void Update()
    {
        this.CoinCount();
    }

    protected virtual void CoinCount()
    {
        coinCountDisplay.GetComponent<Text>().text = "" + coinCount;
        coinEndDisplay.GetComponent<Text>().text = "" + coinCount;
    }
}
