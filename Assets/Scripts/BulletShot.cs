using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletShot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform SpawnPoint;
    public Transform SpawnPoint2;
    public Transform SpawnPoint3;
    public Transform SpawnPoint4;
    public Transform SpawnPoint5;

    public TMP_Text ammoClipText;

    int gunNumber = 1;

    bool gunControlBool = true;
    bool selectPistol = true;
    bool gunChangeWait = true;
    public bool selectAuto = false;
    public bool selectShotgun = false;

    public GameObject playerPistol;
    public GameObject playerAuto;
    public GameObject playerShotgun;

    public GameObject pistolImage;
    public GameObject autoImage;
    public GameObject shotgunImage;

    public PistolUpgrades getPistolData;
    public AutoUpgrades getAutoData;
    public ShotgunUpgrades getShotgunData;

    public float autoDelayTime;
    public float autoClipSize;
    public float autoClipSizeFIX;
    public float autoTotalAmmo;
    public float autoRange;
    public float autoReload;

    public float pistolDelayTime;
    public float pistolClipSize;
    public float pistolClipSizeFIX;
    public float pistolTotalAmmo;
    public float pistolRange;
    public float pistolReload;

    public float shotgunDelayTime;
    public float shotgunClipSize;
    public float shotgunClipSizeFIX;
    public float shotgunTotalAmmo;
    public float shotgunRange;
    public float shotgunReload;

    public Light pointGunLight;
    public Light pointGunLight2;

    public Light autoPointGunLight;
    public Light autoPointGunLight2;

    public Light shotgunPointGunLight;
    public Light shotgunPointGunLight2;

    AudioSource audioSource;
    AudioClip bulletSound, shotgunSound;

    // Start is called before the first frame update
    void Start()
    {
        getPistolData.pistolTotalAmmo = getPistolData.pistolClipSize * getPistolData.pistolAmmoOnClipFIX;
        getAutoData.autoTotalAmmo = getAutoData.autoClipSize * getAutoData.autoAmmoOnClipFIX;
        getShotgunData.shotgunTotalAmmo = getShotgunData.shotgunClipSize * getShotgunData.shotgunAmmoOnClipFIX;
        ammoClipText.text = getPistolData.pistolAmmoOnClip + "/" + getPistolData.pistolTotalAmmo;

        autoDelayTime = getAutoData.autoGunWait;
        autoClipSize = getAutoData.autoAmmoOnClip;
        autoClipSizeFIX = getAutoData.autoAmmoOnClipFIX;
        autoTotalAmmo = getAutoData.autoTotalAmmo;
        autoRange = getAutoData.autoRangeTime;
        autoReload = getAutoData.autoReloadTime;

        pistolDelayTime = getPistolData.pistolGunWait;
        pistolClipSize = getPistolData.pistolAmmoOnClip;
        pistolClipSizeFIX = getPistolData.pistolAmmoOnClipFIX;
        pistolTotalAmmo = getPistolData.pistolTotalAmmo;
        pistolRange = getPistolData.pistolRangeTime;
        pistolReload = getPistolData.pistolReloadTime;

        shotgunDelayTime = getShotgunData.shotgunGunWait;
        shotgunClipSize = getShotgunData.shotgunAmmoOnClip;
        shotgunClipSizeFIX = getShotgunData.shotgunAmmoOnClipFIX;
        shotgunTotalAmmo = getShotgunData.shotgunTotalAmmo;
        shotgunRange = getShotgunData.shotgunRangeTime;
        shotgunReload = getShotgunData.shotgunReloadTime;

        audioSource = GameObject.Find("Audio Manager").GetComponent<AudioSource>();
        bulletSound = Resources.Load<AudioClip>("Bullet");
        shotgunSound = Resources.Load<AudioClip>("Shotgun");

    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.JoystickButton2)) && gunChangeWait)
        {
            StartCoroutine(gunChangeWaitDelay());
            switchGun();
        }
        

        if (selectPistol) 
        {
            if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.JoystickButton0)) && gunControlBool && pistolClipSize > 0)
            {
                StartCoroutine(pistolDelay());

                GameObject bullet = Instantiate(bulletPrefab);
                pistolClipSize--;
                StartCoroutine(gunFireLight());
                audioSource.PlayOneShot(bulletSound);
                ammoClipText.text = pistolClipSize + "/" + pistolTotalAmmo;
                bullet.transform.position = SpawnPoint.transform.position;
                bullet.transform.rotation = SpawnPoint.transform.rotation;
                GameObject.Find("PlayerPistol").GetComponent<Animator>().Play("Gun Shot");
                Destroy(bullet, pistolRange);

            }
            else if ((Input.GetKey(KeyCode.R) || Input.GetKey(KeyCode.JoystickButton1)) && pistolTotalAmmo > 0 && pistolClipSizeFIX != pistolClipSize)
            {
                StartCoroutine(pistolReloadDelay());
            }
        }
        else if (selectAuto) 
        {
            if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.JoystickButton0)) && gunControlBool && autoClipSize > 0)
            {
                StartCoroutine(autoDelay());

                GameObject bullet = Instantiate(bulletPrefab);
                autoClipSize--;
                StartCoroutine(autoGunFireLight());
                audioSource.PlayOneShot(bulletSound);
                ammoClipText.text = autoClipSize + "/" + autoTotalAmmo;
                bullet.transform.position = SpawnPoint.transform.position;
                bullet.transform.rotation = SpawnPoint.transform.rotation;
                GameObject.Find("PlayerAuto").GetComponent<Animator>().Play("Gun Shot");
                Destroy(bullet, autoRange);

            }
            else if ((Input.GetKey(KeyCode.R) || Input.GetKey(KeyCode.JoystickButton1)) && autoTotalAmmo > 0 && autoClipSizeFIX != autoClipSize)
            {
                StartCoroutine(autoReloadDelay());
            }
        }
        else if (selectShotgun) 
        {
            if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.JoystickButton0)) && gunControlBool && shotgunClipSize > 0)
            {
                StartCoroutine(shotgunDelay());

                GameObject bullet = Instantiate(bulletPrefab);
                GameObject bullet1 = Instantiate(bulletPrefab);
                GameObject bullet2 = Instantiate(bulletPrefab);
                GameObject bullet3 = Instantiate(bulletPrefab);
                GameObject bullet4 = Instantiate(bulletPrefab);
                shotgunClipSize--;
                StartCoroutine(shotgunFireLight());
                audioSource.PlayOneShot(shotgunSound);
                ammoClipText.text = shotgunClipSize + "/" + shotgunTotalAmmo;
                bullet.transform.position = SpawnPoint.transform.position;
                bullet1.transform.position = SpawnPoint.transform.position;
                bullet2.transform.position = SpawnPoint.transform.position;
                bullet3.transform.position = SpawnPoint.transform.position;
                bullet4.transform.position = SpawnPoint.transform.position;
                bullet.transform.rotation = SpawnPoint.transform.rotation;
                bullet1.transform.rotation = SpawnPoint2.transform.rotation;
                bullet2.transform.rotation = SpawnPoint3.transform.rotation;
                bullet3.transform.rotation = SpawnPoint4.transform.rotation;
                bullet4.transform.rotation = SpawnPoint5.transform.rotation;
                GameObject.Find("PlayerShotgun").GetComponent<Animator>().Play("Gun Shot");
                Destroy(bullet, shotgunRange);
                Destroy(bullet1, shotgunRange);
                Destroy(bullet2, shotgunRange);
                Destroy(bullet3, shotgunRange);
                Destroy(bullet4, shotgunRange);

            }

            else if ((Input.GetKey(KeyCode.R) || Input.GetKey(KeyCode.JoystickButton1)) && shotgunTotalAmmo > 0 && shotgunClipSizeFIX != shotgunClipSize)
            {
                StartCoroutine(shotgunReloadDelay());
            }
        }

    }

    IEnumerator pistolDelay()
    {
        gunControlBool = false;
        yield return new WaitForSeconds(pistolDelayTime);
        gunControlBool = true;
    }

    IEnumerator autoDelay()
    {
        gunControlBool = false;
        yield return new WaitForSeconds(autoDelayTime);
        gunControlBool = true;
    }

    IEnumerator shotgunDelay()
    {
        gunControlBool = false;
        yield return new WaitForSeconds(shotgunDelayTime);
        gunControlBool = true;
    }

    IEnumerator pistolReloadDelay()
    {

        if (pistolTotalAmmo >= pistolClipSizeFIX)
        {
            ammoClipText.text = "reloading...";
            gunControlBool = false;
            yield return new WaitForSeconds(pistolReload);
            float valuePistol = pistolClipSizeFIX - pistolClipSize;
            pistolTotalAmmo = pistolTotalAmmo - valuePistol;
            pistolClipSize = pistolClipSizeFIX;
            ammoClipText.text = pistolClipSize + "/" + pistolTotalAmmo;
            gunControlBool = true;
        }
        else
        {
            ammoClipText.text = "reloading...";
            gunControlBool = false;
            yield return new WaitForSeconds(pistolReload);
            pistolClipSize = pistolTotalAmmo + pistolClipSize;

            if (pistolClipSize >= pistolClipSizeFIX)
            {
                pistolTotalAmmo = pistolClipSize - pistolClipSizeFIX;
                pistolClipSize = pistolClipSizeFIX;
                ammoClipText.text = pistolClipSize + "/" + pistolTotalAmmo;
                gunControlBool = true;
            }
            else
            {
                pistolTotalAmmo = 0;
                ammoClipText.text = pistolClipSize + "/" + pistolTotalAmmo;
                gunControlBool = true;
            }
        }

    }

    IEnumerator autoReloadDelay()
    {
        if(autoTotalAmmo >= autoClipSizeFIX)
        {
            ammoClipText.text = "reloading...";
            gunControlBool = false;
            yield return new WaitForSeconds(autoReload);
            float valueAuto = autoClipSizeFIX - autoClipSize;
            autoTotalAmmo = autoTotalAmmo - valueAuto;
            autoClipSize = autoClipSizeFIX;
            ammoClipText.text = autoClipSize + "/" + autoTotalAmmo;
            gunControlBool = true;
        }
        else
        {
            ammoClipText.text = "reloading...";
            gunControlBool = false;
            yield return new WaitForSeconds(autoReload);
            autoClipSize = autoTotalAmmo + autoClipSize;

            if (autoClipSize >= autoClipSizeFIX)
            {
                autoTotalAmmo = autoClipSize - autoClipSizeFIX;
                autoClipSize = autoClipSizeFIX;
                ammoClipText.text = autoClipSize + "/" + autoTotalAmmo;
                gunControlBool = true;
            }
            else
            {
                autoTotalAmmo = 0;
                ammoClipText.text = autoClipSize + "/" + autoTotalAmmo;
                gunControlBool = true;
            }
        }

    }


    IEnumerator shotgunReloadDelay()
    {

        if(shotgunTotalAmmo >= shotgunClipSizeFIX)
        {
            ammoClipText.text = "reloading...";
            gunControlBool = false;
            yield return new WaitForSeconds(shotgunReload);
            float valueShotgun = shotgunClipSizeFIX - shotgunClipSize;
            shotgunTotalAmmo = shotgunTotalAmmo - valueShotgun;
            shotgunClipSize = shotgunClipSizeFIX;
            ammoClipText.text = shotgunClipSize + "/" + shotgunTotalAmmo;
            gunControlBool = true;
        }
        else
        {
            ammoClipText.text = "reloading...";
            gunControlBool = false;
            //float valueShotgun = shotgunClipSizeFIX - shotgunClipSize;
            //shotgunTotalAmmo = shotgunTotalAmmo - valueShotgun;
            yield return new WaitForSeconds(shotgunReload);
            shotgunClipSize = shotgunTotalAmmo + shotgunClipSize;

            if(shotgunClipSize >= shotgunClipSizeFIX)
            {
                shotgunTotalAmmo = shotgunClipSize - shotgunClipSizeFIX;
                shotgunClipSize = shotgunClipSizeFIX;
                ammoClipText.text = shotgunClipSize + "/" + shotgunTotalAmmo;
                gunControlBool = true;
            }
            else
            {
                shotgunTotalAmmo = 0;
                ammoClipText.text = shotgunClipSize + "/" + shotgunTotalAmmo;
                gunControlBool = true;
            }
        }

    }

    public void switchGun()
    {
        gunNumber++;

        if(gunNumber == 1)
        {
            selectPistol = true;
            selectShotgun = false;

            playerShotgun.SetActive(false);
            playerPistol.SetActive(true);

            pistolImage.SetActive(true);
            shotgunImage.SetActive(false);

            GameObject.Find("PlayerPistol").GetComponent<Animator>().Play("Gun Switch");
            ammoClipText.text = pistolClipSize + "/" + pistolTotalAmmo;
        }
        else if (gunNumber == 2)
        {
            selectAuto = true;
            selectPistol = false;

            playerPistol.SetActive(false);
            playerAuto.SetActive(true);

            autoImage.SetActive(true);
            pistolImage.SetActive(false);

            GameObject.Find("PlayerAuto").GetComponent<Animator>().Play("Gun Switch");
            ammoClipText.text = autoClipSize + "/" + autoTotalAmmo;
        }
        else if (gunNumber == 3)
        {
            selectShotgun = true;
            selectAuto = false;

            playerAuto.SetActive(false);
            playerShotgun.SetActive(true);

            shotgunImage.SetActive(true);
            autoImage.SetActive(false);

            GameObject.Find("PlayerShotgun").GetComponent<Animator>().Play("Gun Switch");
            ammoClipText.text = shotgunClipSize + "/" + shotgunTotalAmmo;
            gunNumber = 0;
        }

    }

    IEnumerator gunFireLight()
    {
        pointGunLight.enabled = true;
        pointGunLight2.enabled = true;
        yield return new WaitForSeconds(0.18f);
        pointGunLight.enabled = false;
        pointGunLight2.enabled = false;
    }

    IEnumerator autoGunFireLight()
    {
        autoPointGunLight.enabled = true;
        autoPointGunLight2.enabled = true;
        yield return new WaitForSeconds(0.18f);
        autoPointGunLight.enabled = false;
        autoPointGunLight2.enabled = false;
    }

    IEnumerator shotgunFireLight()
    {
        shotgunPointGunLight.enabled = true;
        shotgunPointGunLight2.enabled = true;
        yield return new WaitForSeconds(0.18f);
        shotgunPointGunLight.enabled = false;
        shotgunPointGunLight2.enabled = false;
    }

    IEnumerator gunChangeWaitDelay()
    {
        gunChangeWait = false;
        yield return new WaitForSeconds(0.3f);
        gunChangeWait = true;
    }

}
