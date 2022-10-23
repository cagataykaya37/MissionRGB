using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIShotgun : MonoBehaviour
{
    //public Transform playerRotation;

    public GameObject bulletPrefab;

    bool enemyDead = false;
    bool shotActive = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" && !enemyDead)
        {
            if(shotActive) StartCoroutine(fireShotDelay());
            this.transform.LookAt(GameObject.Find("Player").GetComponent<Transform>());
            this.GetComponent<Rigidbody>().velocity = this.gameObject.transform.forward * 1;
        }
    }

    IEnumerator fireShotDelay()
    {
        shotActive = false;
        yield return new WaitForSeconds(1.3f);
        GameObject bullet = Instantiate(bulletPrefab);
        GameObject bullet2 = Instantiate(bulletPrefab);
        GameObject bullet3 = Instantiate(bulletPrefab);
        GameObject bullet4 = Instantiate(bulletPrefab);
        GameObject bullet5 = Instantiate(bulletPrefab);
        bullet.transform.position = this.transform.GetChild(0).GetChild(4).GetChild(4).position;
        bullet.transform.rotation = this.transform.GetChild(0).GetChild(4).GetChild(4).rotation;
        bullet2.transform.position = this.transform.GetChild(0).GetChild(4).GetChild(5).position;
        bullet2.transform.rotation = this.transform.GetChild(0).GetChild(4).GetChild(5).rotation;
        bullet3.transform.position = this.transform.GetChild(0).GetChild(4).GetChild(6).position;
        bullet3.transform.rotation = this.transform.GetChild(0).GetChild(4).GetChild(6).rotation;
        bullet4.transform.position = this.transform.GetChild(0).GetChild(4).GetChild(7).position;
        bullet4.transform.rotation = this.transform.GetChild(0).GetChild(4).GetChild(7).rotation;
        bullet5.transform.position = this.transform.GetChild(0).GetChild(4).GetChild(8).position;
        bullet5.transform.rotation = this.transform.GetChild(0).GetChild(4).GetChild(8).rotation;
        StartCoroutine(gunFireLight());
        shotActive = true;
        Destroy(bullet, 0.2f);
        Destroy(bullet2, 0.2f);
        Destroy(bullet3, 0.2f);
        Destroy(bullet4, 0.2f);
        Destroy(bullet5, 0.2f);
    }

    IEnumerator gunFireLight()
    {
        this.transform.GetChild(0).GetChild(4).GetChild(3).gameObject.SetActive(true);
        this.transform.GetChild(0).GetChild(4).GetChild(4).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.18f);
        this.transform.GetChild(0).GetChild(4).GetChild(3).gameObject.SetActive(false);
        this.transform.GetChild(0).GetChild(4).GetChild(4).gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Bullet")
        {
            enemyDead = true;
            this.transform.GetChild(0).gameObject.SetActive(false);
            this.transform.GetChild(1).gameObject.SetActive(true);
        }
    }

}
