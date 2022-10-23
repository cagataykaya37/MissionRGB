using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoldCount : MonoBehaviour
{
    public float goldCount;

    AudioSource audioSource;
    AudioClip itemSound;

    // Start is called before the first frame update
    void Start()
    {
        goldCount = PlayerPrefs.GetFloat("goldCount");

        audioSource = GameObject.Find("Audio Manager").GetComponent<AudioSource>();
        itemSound = Resources.Load<AudioClip>("Item Pick");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            audioSource.PlayOneShot(itemSound);
            //goldCount++;
            PlayerPrefs.SetFloat("goldCount", goldCount + 1);
        } 
    }
}
