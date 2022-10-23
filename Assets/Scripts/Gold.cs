using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gold : MonoBehaviour
{
    static float gold;
    static int control = 1;

    public TMP_Text goldText;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("controlKey", control);
        //if (PlayerPrefs.GetInt("controlKey") == 1) gold = 5;
        //control++;
        //PlayerPrefs.SetInt("controlKey", control);

        goldText.text = PlayerPrefs.GetFloat("goldCount") + " Gold";
        PlayerPrefs.SetFloat("goldCount", gold);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
