using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameGoodEnd : MonoBehaviour
{

    public GameObject endMenu;
    public GameObject player;

    private PlayerController xyz;

    public LevelCheckBool levelCheckBool;

    public bool levelEnd;

    AudioSource audioSource;
    AudioClip itemSound;

    // Start is called before the first frame update
    void Start()
    {
        levelEnd = false;

        audioSource = GameObject.Find("Audio Manager").GetComponent<AudioSource>();
        itemSound = Resources.Load<AudioClip>("Item Pick");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audioSource.PlayOneShot(itemSound);
            levelEnd = true;
            endMenu.SetActive(true);
            EventSystem.current.SetSelectedGameObject(null);
            EventSystem.current.SetSelectedGameObject(GameObject.Find("NextMissionButton"));
            xyz = player.GetComponent<PlayerController>();
            xyz.enabled = false;

            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 1) PlayerPrefs.SetString("level2bool", "true");

            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 2) PlayerPrefs.SetString("level3bool", "true");

            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 3) PlayerPrefs.SetString("level4bool", "true");

            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 4) PlayerPrefs.SetString("level5bool", "true");

            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 5) PlayerPrefs.SetString("level6bool", "true");

            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 6) PlayerPrefs.SetString("level7bool", "true");

            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 7) PlayerPrefs.SetString("level8bool", "true");

            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 8) PlayerPrefs.SetString("level9bool", "true");

            if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex == 9) PlayerPrefs.SetString("level10bool", "true");

        }
    }

}
