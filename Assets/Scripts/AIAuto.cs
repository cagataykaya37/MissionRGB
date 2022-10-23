using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAuto : MonoBehaviour
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
        yield return new WaitForSeconds(0.7f);
        GameObject bullet = Instantiate(bulletPrefab);
        bullet.transform.position = this.transform.GetChild(0).GetChild(3).GetChild(2).position;
        bullet.transform.rotation = this.transform.GetChild(0).GetChild(3).GetChild(2).rotation;
        StartCoroutine(gunFireLight());
        shotActive = true;
        Destroy(bullet, 0.3f);
    }

    IEnumerator gunFireLight()
    {
        this.transform.GetChild(0).GetChild(3).GetChild(3).gameObject.SetActive(true);
        this.transform.GetChild(0).GetChild(3).GetChild(4).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.18f);
        this.transform.GetChild(0).GetChild(3).GetChild(3).gameObject.SetActive(false);
        this.transform.GetChild(0).GetChild(3).GetChild(4).gameObject.SetActive(false);
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
