using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class Timer : MonoBehaviour
{
    float startTime;
    float currentTime;

    public GameObject badEndMenu;
    public GameObject player;

    private PlayerController xyz;
    public GameGoodEnd gameGoodEnd;

    public bool check = true;

    public TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 1) startTime = 15;

        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 2) startTime = 20;

        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 3) startTime = 30;

        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 4) startTime = 40;

        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 5) startTime = 50;

        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 6) startTime = 60;

        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 7) startTime = 70;

        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 8) startTime = 80;

        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 9) startTime = 90;

        if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 10) startTime = 100;

        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (check)
        {
            if (currentTime > 0 && !gameGoodEnd.levelEnd)
            {
                currentTime = currentTime - Time.deltaTime;
                timerText.text = currentTime.ToString("0.00");
            }
            else if (gameGoodEnd.levelEnd)
            {
                timerText.text = currentTime.ToString("0.00");
            }
            else
            {
                timerText.text = "00.00";
                badEndMenu.SetActive(true);
                EventSystem.current.SetSelectedGameObject(null);
                EventSystem.current.SetSelectedGameObject(GameObject.Find("RetryButton"));
                xyz = player.GetComponent<PlayerController>();
                xyz.enabled = false;
                check = false;
            }
        }


    }


}
