using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EndGameManager : MonoBehaviour
{

    public MenuManage menuManage;

    //public GameObject endMenuButtonSelect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");

    }

    public void Retry()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(menuManage.sceneName);
    }

    public void NextMission()
    {
        menuManage.levelNumber++;
        menuManage.sceneName = "Level" + menuManage.levelNumber;
        UnityEngine.SceneManagement.SceneManager.LoadScene(menuManage.sceneName);
    } 

}
