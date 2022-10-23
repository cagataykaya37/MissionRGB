using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class MenuManage : MonoBehaviour
{

    public GameObject upgradeObject;
    public GameObject menuObject;
    public GameObject levelObject;

    public GameObject pistolUpgrade;
    public GameObject autoUpgrade;
    public GameObject shotgunUpgrade;

    public GameObject howToPanel;
    public GameObject howToButon;

    public GameObject menuButtonSelect, levelsButtonSelect, upgradesButtonSelect, howToButtonSelect;

    public TMP_Text startGame;

    int page = 1;
    public int levelNumber = 1;

    public string sceneName = "Level1";

    AudioSource audioSource;
    AudioClip menuButtonSoundF, menuButtonSoundB;

    // Start is called before the first frame update
    void Start()
    {
        startGame.text = "START GAME " + "Level " + levelNumber;

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource = GameObject.Find("Audio Manager").GetComponent<AudioSource>();
        menuButtonSoundF = Resources.Load<AudioClip>("Menu A");
        menuButtonSoundB = Resources.Load<AudioClip>("Menu B");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame() 
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
    }

    public void GoToUpgrade() 
    {
        upgradeObject.SetActive(true);
        menuObject.SetActive(false);

        audioSource.PlayOneShot(menuButtonSoundF);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(upgradesButtonSelect);
    }

    public void GoToLevels() 
    {
        levelObject.SetActive(true);
        menuObject.SetActive(false);

        audioSource.PlayOneShot(menuButtonSoundF);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(levelsButtonSelect);
    }

    public void GoToMenuFromUpgrade()
    {
        menuObject.SetActive(true);
        upgradeObject.SetActive(false);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundB);
    }

    public void GoToMenuFromLevels() 
    {
        menuObject.SetActive(true);
        levelObject.SetActive(false);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundB);
    }

    public void changeGunInUpgrade() 
    {
        page++;

        audioSource.PlayOneShot(menuButtonSoundF);

        if (page == 1) 
        {
            pistolUpgrade.SetActive(true);
            shotgunUpgrade.SetActive(false);
        }
        else if(page == 2) 
        {
            autoUpgrade.SetActive(true);
            pistolUpgrade.SetActive(false);
        }
        else if(page == 3) 
        {
            shotgunUpgrade.SetActive(true);
            autoUpgrade.SetActive(false);
            page = 0;
        }

    }


    public void level1()
    {
        levelNumber = 1;
        sceneName = "Level" + levelNumber;

        menuObject.SetActive(true);
        levelObject.SetActive(false);

        startGame.text = "START GAME " + "Level " + levelNumber;

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundB);
    }

    public void level2()
    {
        levelNumber = 2;
        sceneName = "Level" + levelNumber;

        menuObject.SetActive(true);
        levelObject.SetActive(false);

        startGame.text = "START GAME " + "Level " + levelNumber;

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundB);
    }

    public void level3()
    {
        levelNumber = 3;
        sceneName = "Level" + levelNumber;

        menuObject.SetActive(true);
        levelObject.SetActive(false);

        startGame.text = "START GAME " + "Level " + levelNumber;

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundB);
    }

    public void level4()
    {
        levelNumber = 4;
        sceneName = "Level" + levelNumber;

        menuObject.SetActive(true);
        levelObject.SetActive(false);

        startGame.text = "START GAME " + "Level " + levelNumber;

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundB);
    }

    public void level5()
    {
        levelNumber = 5;
        sceneName = "Level" + levelNumber;

        menuObject.SetActive(true);
        levelObject.SetActive(false);

        startGame.text = "START GAME " + "Level " + levelNumber;

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundB);
    }

    public void level6()
    {
        levelNumber = 6;
        sceneName = "Level" + levelNumber;

        menuObject.SetActive(true);
        levelObject.SetActive(false);

        startGame.text = "START GAME " + "Level " + levelNumber;

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundB);
    }

    public void level7()
    {
        levelNumber = 7;
        sceneName = "Level" + levelNumber;

        menuObject.SetActive(true);
        levelObject.SetActive(false);

        startGame.text = "START GAME " + "Level " + levelNumber;

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundB);
    }

    public void level8()
    {
        levelNumber = 8;
        sceneName = "Level" + levelNumber;

        menuObject.SetActive(true);
        levelObject.SetActive(false);

        startGame.text = "START GAME " + "Level " + levelNumber;

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundB);
    }

    public void level9()
    {
        levelNumber = 9;
        sceneName = "Level" + levelNumber;

        menuObject.SetActive(true);
        levelObject.SetActive(false);

        startGame.text = "START GAME " + "Level " + levelNumber;

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundB);
    }

    public void level10()
    {
        levelNumber = 10;
        sceneName = "Level" + levelNumber;

        menuObject.SetActive(true);
        levelObject.SetActive(false);

        startGame.text = "START GAME " + "Level " + levelNumber;

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundB);
    }

    public void howToPlay()
    {
        howToPanel.SetActive(true);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(howToButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundF);
    }

    public void howToPlayBack()
    {
        howToPanel.SetActive(false);

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuButtonSelect);

        audioSource.PlayOneShot(menuButtonSoundB);
    }

}
