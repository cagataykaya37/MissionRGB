using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deadge : MonoBehaviour
{
    bool oneShot = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (oneShot) StartCoroutine(explode());
    }

    

    IEnumerator explode()
    {
        oneShot = false;
        this.gameObject.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
        yield return new WaitForSeconds(0.1f);
        this.gameObject.transform.localScale = new Vector3(0.09f, 0.09f, 0.09f);
    }

}
