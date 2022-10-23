using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotgunBulletAdd : MonoBehaviour
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
            bulletShot.shotgunTotalAmmo = bulletShot.shotgunTotalAmmo + bulletShot.shotgunClipSizeFIX;

            if (bulletShot.selectShotgun)
            {
                bulletShot.ammoClipText.text = bulletShot.shotgunClipSize + "/" + bulletShot.shotgunTotalAmmo;
            }
            
        }
    }

}
