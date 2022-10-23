using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundInvisiblity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            this.transform.GetChild(0).gameObject.SetActive(false);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

}
