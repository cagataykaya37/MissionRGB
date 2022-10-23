using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBulletAdd : MonoBehaviour
{

    public BulletShot bulletShot;

    bool control = true;

    AudioSource audioSource;
    AudioClip itemSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GameObject.Find("Audio Manager").GetComponent<AudioSource>();
        itemSound = Resources.Load<AudioClip>("Item Pick");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player" && control)
        {
            control = false;
            Destroy(this.gameObject);
            audioSource.PlayOneShot(itemSound);
            bulletShot.autoTotalAmmo = bulletShot.autoTotalAmmo + bulletShot.autoClipSizeFIX;

            if (bulletShot.selectAuto)
            {
                bulletShot.ammoClipText.text = bulletShot.autoClipSize + "/" + bulletShot.autoTotalAmmo;
            }
            
        }
    }

}
