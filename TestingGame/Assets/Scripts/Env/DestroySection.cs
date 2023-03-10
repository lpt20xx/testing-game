using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySection : MonoBehaviour
{
    public string parentName;

    // Update is called once per frame
    private void Update()
    {
        this.DestroyCloneSection();
    }

    protected virtual void DestroyCloneSection()
    {
        parentName = transform.name;
        StartCoroutine(DestroyClone());
    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(30);
        if (parentName == "Section(Clone)") 
        {
            Destroy(gameObject);
        }
    }
}
