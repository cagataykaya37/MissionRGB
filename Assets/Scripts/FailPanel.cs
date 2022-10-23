using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FailPanel : MonoBehaviour
{
    public GameObject badEndMenu;
    public GameObject player;

    bool checc = false;
    //public GameObject badEndButtonSelect;

    private PlayerController xyz;

    public Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = GameObject.Find("Main Camera").GetComponent<Timer>();

        badEndMenu.SetActive(true);
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(GameObject.Find("RetryButton"));
        xyz = player.GetComponent<PlayerController>();
        xyz.enabled = false;
        timer.check = false;
    }

    // Update is called once per frame
    void Update()
    {
        //badEndMenu.SetActive(true);
        //EventSystem.current.SetSelectedGameObject(null);
        //EventSystem.current.SetSelectedGameObject(GameObject.Find("RetryButton"));
        //xyz = player.GetComponent<PlayerController>();
        //xyz.enabled = false;
    }
}
