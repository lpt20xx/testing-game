using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelDistance : MonoBehaviour
{
    public GameObject disDisplay;

    public int disRun;
    public static bool addingDis = false;
    public float disDelay = 0.35f;

    public GameObject player;

    public GameObject disEndDisplay;


    // Update is called once per frame
    private void Update()
    {
        this.AddDistance();
    }



    

    protected virtual void AddDistance()
    {
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && PlayerMove.canMove == true)
        {
            if (addingDis == false)
            {
                addingDis = true;
                StartCoroutine(AddingDis());
            }
        }

    }

    IEnumerator AddingDis()
    {
       //distance count
        disRun += 1;
        disDisplay.GetComponent<Text>().text = "" + disRun;
        yield return new WaitForSeconds(disDelay);
        addingDis = false;
        //distance end display
        disEndDisplay.GetComponent<Text>().text = "" + disRun;
    }

}
