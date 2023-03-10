using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 50;
    public bool creatingSection = false;
    public int secNum;

    
    // Update is called once per frame
    private void Update()
    {
        this.CreateSection();
    }

    protected virtual void CreateSection()
    {
        if(creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    private IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 2);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 50;
        yield return new WaitForSeconds(30);
        creatingSection = false;
    }
}
