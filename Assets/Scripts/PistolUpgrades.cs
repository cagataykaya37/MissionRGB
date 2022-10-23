using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PistolUpgrades : MonoBehaviour
{
    public float pistolGunWait = 0.8f;
    public float pistolClipSize = 4;
    public float pistolTotalAmmo;
    public float pistolAmmoOnClip = 6;
    public float pistolAmmoOnClipFIX = 6;
    public float pistolRangeTime = 0.25f;
    public float pistolReloadTime = 1.5f;

    public float pistolGunWaitLEVEL = 0;
    public float pistolClipSizeLEVEL = 0;
    public float pistolAmmoOnClipLEVEL = 0;
    public float pistolRangeTimeLEVEL = 0;
    public float pistolReloadTimeLEVEL = 0;

    public TMP_Text pistolTotalAmmoText;
    public TMP_Text pistolFireRateText;
    public TMP_Text pistolAmmoClipText;
    public TMP_Text pistolReloadText;
    public TMP_Text pistolRangeText;

    public TMP_Text pistolTotalAmmoTextLEVEL;
    public TMP_Text pistolFireRateTextLEVEL;
    public TMP_Text pistolAmmoClipTextLEVEL;
    public TMP_Text pistolReloadTextLEVEL;
    public TMP_Text pistolRangeTextLEVEL;

    public TMP_Text pistolTotalAmmoGOLD;
    public TMP_Text pistolFireRateGOLD;
    public TMP_Text pistolAmmoClipGOLD;
    public TMP_Text pistolReloadGOLD;
    public TMP_Text pistolRangeGOLD;

    public TMP_Text gold;

    float goldAmmount;

    public GoldCount goldAmount;

    // Start is called before the first frame update
    void Start()
    {
        pistolTotalAmmo = pistolClipSize * pistolAmmoOnClipFIX;
        pistolAmmoClipText.text = "Clip Size: " + pistolAmmoOnClip;
        pistolTotalAmmoText.text = "Total Ammo: " + (pistolTotalAmmo + pistolAmmoOnClip);
        pistolReloadText.text = "Reload Time: " + pistolReloadTime + " sec.";
        pistolRangeText.text = "Range: " + (pistolRangeTime * 10);
        pistolFireRateText.text = "Weapon Cooldown: " + pistolGunWait;

        pistolTotalAmmoTextLEVEL.text = "Default";
        pistolFireRateTextLEVEL.text = "Default";
        pistolAmmoClipTextLEVEL.text = "Default";
        pistolReloadTextLEVEL.text = "Default";
        pistolRangeTextLEVEL.text = "Default";

        pistolTotalAmmoGOLD.text = "1 gold to upgrade";
        pistolFireRateGOLD.text = "1 gold to upgrade";
        pistolAmmoClipGOLD.text = "1 gold to upgrade";
        pistolReloadGOLD.text = "1 gold to upgrade";
        pistolRangeGOLD.text = "1 gold to upgrade";

        goldAmmount = PlayerPrefs.GetFloat("goldCount");
        PlayerPrefs.SetFloat("pistolDelayLevel", pistolGunWaitLEVEL);
        gold.text = goldAmmount + " Gold";

    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetFloat("pistolDelayLevel") == 1)
        {
            pistolFireRateText.text = "Weapon Cooldown: " + pistolGunWait;
            pistolFireRateTextLEVEL.text = "Level 1";
            pistolFireRateGOLD.text = "2 gold to upgrade";
        }
        else if(PlayerPrefs.GetFloat("pistolDelayLevel") == 2)
        {
            pistolFireRateText.text = "Weapon Cooldown: " + pistolGunWait;
            pistolFireRateTextLEVEL.text = "Level 2";
            pistolFireRateGOLD.text = "3 gold to upgrade";
        }
        else if (PlayerPrefs.GetFloat("pistolDelayLevel") == 3)
        {
            pistolFireRateText.text = "Weapon Cooldown: " + pistolGunWait;
            pistolFireRateTextLEVEL.text = "Level 3";
            pistolFireRateGOLD.text = "5 gold to upgrade";
        }
        else if (PlayerPrefs.GetFloat("pistolDelayLevel") == 4)
        {
            pistolFireRateText.text = "Weapon Cooldown: " + pistolGunWait;
            pistolFireRateTextLEVEL.text = "Level 4";
            pistolFireRateGOLD.text = "7 gold to upgrade";
        }
        else if (PlayerPrefs.GetFloat("pistolDelayLevel") == 5)
        {
            pistolFireRateText.text = "Weapon Cooldown: " + pistolGunWait;
            pistolFireRateTextLEVEL.text = "Level 5";
            pistolFireRateGOLD.text = "DONE";
        }

    }

    // -----

    public void pistolGunWaitUpgrade() 
    {
        if (PlayerPrefs.GetFloat("pistolDelayLevel") == 0 && goldAmmount >= 1)
        {
            pistolGunWaitLEVEL = 1;
            PlayerPrefs.SetFloat("pistolDelayLevel", 1);
            pistolGunWait = 0.7f;

            pistolFireRateText.text = "Weapon Cooldown: " + pistolGunWait;
            pistolFireRateTextLEVEL.text = "Level 1";

            //goldAmount.goldCount = goldAmount.goldCount - 1;
            //gold.text = goldAmount.goldCount + " Gold";
            goldAmmount = goldAmmount - 1;
            PlayerPrefs.SetFloat("goldCount", goldAmmount);
            gold.text = goldAmmount + " Gold";
            pistolFireRateGOLD.text = "2 gold to upgrade";
        }

        else if (PlayerPrefs.GetFloat("pistolDelayLevel") == 1 && goldAmmount >= 2) 
        {
            pistolGunWaitLEVEL = 2;
            PlayerPrefs.SetFloat("pistolDelayLevel", 2);
            pistolGunWait = 0.6f;

            pistolFireRateText.text = "Weapon Cooldown: " + pistolGunWait;
            pistolFireRateTextLEVEL.text = "Level 2";

            goldAmmount = goldAmmount - 2;
            PlayerPrefs.SetFloat("goldCount", goldAmmount);
            gold.text = goldAmmount + " Gold";
            pistolFireRateGOLD.text = "3 gold to upgrade";
        }

        else if (PlayerPrefs.GetFloat("pistolDelayLevel") == 2 && goldAmmount >= 3)
        {
            pistolGunWaitLEVEL = 3;
            PlayerPrefs.SetFloat("pistolDelayLevel", 3);
            pistolGunWait = 0.5f;

            pistolFireRateText.text = "Weapon Cooldown: " + pistolGunWait;
            pistolFireRateTextLEVEL.text = "Level 3";

            goldAmmount = goldAmmount - 3;
            PlayerPrefs.SetFloat("goldCount", goldAmmount);
            gold.text = goldAmmount + " Gold";
            pistolFireRateGOLD.text = "5 gold to upgrade";
        }

        else if (PlayerPrefs.GetFloat("pistolDelayLevel") == 3 && goldAmmount >= 5)
        {
            pistolGunWaitLEVEL = 4;
            PlayerPrefs.SetFloat("pistolDelayLevel", 4);
            pistolGunWait = 0.4f;

            pistolFireRateText.text = "Weapon Cooldown: " + pistolGunWait;
            pistolFireRateTextLEVEL.text = "Level 4";

            goldAmmount = goldAmmount - 5;
            PlayerPrefs.SetFloat("goldCount", goldAmmount);
            gold.text = goldAmmount + " Gold";
            pistolFireRateGOLD.text = "7 gold to upgrade";
        }

        else if (PlayerPrefs.GetFloat("pistolDelayLevel") == 4 && goldAmmount >= 7)
        {
            pistolGunWaitLEVEL = 5;
            PlayerPrefs.SetFloat("pistolDelayLevel", 5);
            pistolGunWait = 0.3f;

            pistolFireRateText.text = "Weapon Cooldown: " + pistolGunWait;
            pistolFireRateTextLEVEL.text = "Level MAX";

            goldAmmount = goldAmmount - 7;
            PlayerPrefs.SetFloat("goldCount", goldAmmount);
            gold.text = goldAmmount + " Gold";
            pistolFireRateGOLD.text = "DONE";
        }
    }

    // -----

    public void pistolClipSizeUpgrade()
    {
        if (pistolClipSizeLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            pistolClipSizeLEVEL = 1;
            pistolClipSize = 6f;
            pistolTotalAmmo = pistolAmmoOnClip * pistolClipSize;

            pistolTotalAmmoText.text = "Total Ammo: " + (pistolTotalAmmo + pistolAmmoOnClip);
            pistolTotalAmmoTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            pistolTotalAmmoGOLD.text = "2 gold to upgrade";
        }

        else if (pistolClipSizeLEVEL == 1 && goldAmount.goldCount >= 2)
        {
            pistolClipSizeLEVEL = 2;
            pistolClipSize = 8f;
            pistolTotalAmmo = pistolAmmoOnClip * pistolClipSize;

            pistolTotalAmmoText.text = "Total Ammo: " + (pistolTotalAmmo + pistolAmmoOnClip);
            pistolTotalAmmoTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            pistolTotalAmmoGOLD.text = "3 gold to upgrade";
        }

        else if (pistolClipSizeLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            pistolClipSizeLEVEL = 3;
            pistolClipSize = 10f;
            pistolTotalAmmo = pistolAmmoOnClip * pistolClipSize;

            pistolTotalAmmoText.text = "Total Ammo: " + (pistolTotalAmmo + pistolAmmoOnClip);
            pistolTotalAmmoTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            pistolTotalAmmoGOLD.text = "5 gold to upgrade";
        }

        else if (pistolClipSizeLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            pistolClipSizeLEVEL = 4;
            pistolClipSize = 12f;
            pistolTotalAmmo = pistolAmmoOnClip * pistolClipSize;

            pistolTotalAmmoText.text = "Total Ammo: " + (pistolTotalAmmo + pistolAmmoOnClip);
            pistolTotalAmmoTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            pistolTotalAmmoGOLD.text = "7 gold to upgrade";
        }

        else if (pistolClipSizeLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            pistolClipSizeLEVEL = 5;
            pistolClipSize = 15f;
            pistolTotalAmmo = pistolAmmoOnClip * pistolClipSize;

            pistolTotalAmmoText.text = "Total Ammo: " + (pistolTotalAmmo + pistolAmmoOnClip);
            pistolTotalAmmoTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            pistolTotalAmmoGOLD.text = "DONE";
        }
    }

    // -----

    public void pistolAmmoOnClipUpgrade()
    {
        if (pistolAmmoOnClipLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            pistolAmmoOnClipLEVEL = 1;
            pistolAmmoOnClip = 7f;
            pistolAmmoOnClipFIX = 7f;
            pistolTotalAmmo = pistolAmmoOnClip * pistolClipSize;

            pistolAmmoClipText.text = "Clip Size: " + pistolAmmoOnClip;
            pistolTotalAmmoText.text = "Total Ammo: " + (pistolTotalAmmo + pistolAmmoOnClip);
            pistolAmmoClipTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            pistolAmmoClipGOLD.text = "2 gold to upgrade";
        }

        else if (pistolAmmoOnClipLEVEL == 1 && goldAmount.goldCount >= 2)
        {
            pistolAmmoOnClipLEVEL = 2;
            pistolAmmoOnClip = 8f;
            pistolAmmoOnClipFIX = 8f;
            pistolTotalAmmo = pistolAmmoOnClip * pistolClipSize;

            pistolAmmoClipText.text = "Clip Size: " + pistolAmmoOnClip;
            pistolTotalAmmoText.text = "Total Ammo: " + (pistolTotalAmmo + pistolAmmoOnClip);
            pistolAmmoClipTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            pistolAmmoClipGOLD.text = "3 gold to upgrade";
        }

        else if (pistolAmmoOnClipLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            pistolAmmoOnClipLEVEL = 3;
            pistolAmmoOnClip = 10f;
            pistolAmmoOnClipFIX = 10f;
            pistolTotalAmmo = pistolAmmoOnClip * pistolClipSize;

            pistolAmmoClipText.text = "Clip Size: " + pistolAmmoOnClip;
            pistolTotalAmmoText.text = "Total Ammo: " + (pistolTotalAmmo + pistolAmmoOnClip);
            pistolAmmoClipTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            pistolAmmoClipGOLD.text = "5 gold to upgrade";
        }

        else if (pistolAmmoOnClipLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            pistolAmmoOnClipLEVEL = 4;
            pistolAmmoOnClip = 12f;
            pistolAmmoOnClipFIX = 12f;
            pistolTotalAmmo = pistolAmmoOnClip * pistolClipSize;

            pistolAmmoClipText.text = "Clip Size: " + pistolAmmoOnClip;
            pistolTotalAmmoText.text = "Total Ammo: " + (pistolTotalAmmo + pistolAmmoOnClip);
            pistolAmmoClipTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            pistolAmmoClipGOLD.text = "7 gold to upgrade";
        }

        else if (pistolAmmoOnClipLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            pistolAmmoOnClipLEVEL = 5;
            pistolAmmoOnClip = 15f;
            pistolAmmoOnClipFIX = 15f;
            pistolTotalAmmo = pistolAmmoOnClip * pistolClipSize;

            pistolAmmoClipText.text = "Clip Size: " + pistolAmmoOnClip;
            pistolTotalAmmoText.text = "Total Ammo: " + (pistolTotalAmmo + pistolAmmoOnClip);
            pistolAmmoClipTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            pistolAmmoClipGOLD.text = "DONE";
        }
    }

    // -----

    public void pistolRangeTimeUpgrade()
    {
        if (pistolRangeTimeLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            pistolRangeTimeLEVEL = 1;
            pistolRangeTime = 0.35f;

            pistolRangeText.text = "Range: " + (pistolRangeTime * 10);
            pistolRangeTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            pistolRangeGOLD.text = "2 gold to upgrade";
        }

        else if (pistolRangeTimeLEVEL == 1 && goldAmount.goldCount >= 2)
        {
            pistolRangeTimeLEVEL = 2;
            pistolRangeTime = 0.5f;

            pistolRangeText.text = "Range: " + (pistolRangeTime * 10);
            pistolRangeTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            pistolRangeGOLD.text = "3 gold to upgrade";
        }

        else if (pistolRangeTimeLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            pistolRangeTimeLEVEL = 3;
            pistolRangeTime = 0.6f;

            pistolRangeText.text = "Range: " + (pistolRangeTime * 10);
            pistolRangeTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            pistolRangeGOLD.text = "5 gold to upgrade";
        }

        else if (pistolRangeTimeLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            pistolRangeTimeLEVEL = 4;
            pistolRangeTime = 0.8f;

            pistolRangeText.text = "Range: " + (pistolRangeTime * 10);
            pistolRangeTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            pistolRangeGOLD.text = "7 gold to upgrade";
        }

        else if (pistolRangeTimeLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            pistolRangeTimeLEVEL = 5;
            pistolRangeTime = 1f;

            pistolRangeText.text = "Range: " + (pistolRangeTime * 10);
            pistolRangeTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            pistolRangeGOLD.text = "DONE";
        }
    }

    // -----

    public void pistolReloadTimeUpgrade()
    {
        if (pistolReloadTimeLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            pistolReloadTimeLEVEL = 1;
            pistolReloadTime = 1.3f;

            pistolReloadText.text = "Reload Time: " + pistolReloadTime + " sec.";
            pistolReloadTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            pistolReloadGOLD.text = "2 gold to upgrade";
        }

        else if (pistolReloadTimeLEVEL == 1 && goldAmount.goldCount >= 2)
        {
            pistolReloadTimeLEVEL = 2;
            pistolReloadTime = 1.1f;

            pistolReloadText.text = "Reload Time: " + pistolReloadTime + " sec.";
            pistolReloadTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            pistolReloadGOLD.text = "3 gold to upgrade";
        }

        else if (pistolReloadTimeLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            pistolReloadTimeLEVEL = 3;
            pistolReloadTime = 0.9f;

            pistolReloadText.text = "Reload Time: " + pistolReloadTime + " sec.";
            pistolReloadTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            pistolReloadGOLD.text = "5 gold to upgrade";
        }

        else if (pistolReloadTimeLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            pistolReloadTimeLEVEL = 4;
            pistolReloadTime = 0.7f;

            pistolReloadText.text = "Reload Time: " + pistolReloadTime + " sec.";
            pistolReloadTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            pistolReloadGOLD.text = "7 gold to upgrade";
        }

        else if (pistolReloadTimeLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            pistolReloadTimeLEVEL = 5;
            pistolReloadTime = 0.5f;

            pistolReloadText.text = "Reload Time: " + pistolReloadTime + " sec.";
            pistolReloadTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            pistolReloadGOLD.text = "DONE";
        }
    }

}
