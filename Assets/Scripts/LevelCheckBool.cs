using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCheckBool : MonoBehaviour
{

    public GameObject level2buton;
    public GameObject level3buton;
    public GameObject level4buton;
    public GameObject level5buton;
    public GameObject level6buton;
    public GameObject level7buton;
    public GameObject level8buton;
    public GameObject level9buton;
    public GameObject level10buton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetString("level2bool") == "true") level2buton.SetActive(true);

        if (PlayerPrefs.GetString("level3bool") == "true") level3buton.SetActive(true);

        if (PlayerPrefs.GetString("level4bool") == "true") level4buton.SetActive(true);

        if (PlayerPrefs.GetString("level5bool") == "true") level5buton.SetActive(true);

        if (PlayerPrefs.GetString("level6bool") == "true") level6buton.SetActive(true);

        if (PlayerPrefs.GetString("level7bool") == "true") level7buton.SetActive(true);

        if (PlayerPrefs.GetString("level8bool") == "true") level8buton.SetActive(true);

        if (PlayerPrefs.GetString("level9bool") == "true") level9buton.SetActive(true);

        if (PlayerPrefs.GetString("level10bool") == "true") level10buton.SetActive(true);
    }
}
