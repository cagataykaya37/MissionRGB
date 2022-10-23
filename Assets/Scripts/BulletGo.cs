using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGo : MonoBehaviour
{
    AudioSource audioSource;
    AudioClip deadSound;


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("Audio Manager").GetComponent<AudioSource>();
        deadSound = Resources.Load<AudioClip>("Death Sound");
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody>().velocity = this.gameObject.transform.forward * 10;
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Hostage")
        {
            audioSource.PlayOneShot(deadSound);
            Destroy(this.gameObject);
            collision.transform.GetChild(0).gameObject.SetActive(false);
            collision.transform.GetChild(1).gameObject.SetActive(true);
        }
        else if(collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }

        //else if (collision.gameObject.tag == "Player")
        //{
        //    Destroy(this.gameObject);
        //    collision.transform.GetChild(0).gameObject.SetActive(false);
        //    collision.transform.GetChild(1).gameObject.SetActive(true);
        //}

    }

}
