using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShotgunUpgrades : MonoBehaviour
{
    public float shotgunGunWait = 1f;
    public float shotgunClipSize = 1;
    public float shotgunTotalAmmo;
    public float shotgunAmmoOnClip = 5;
    public float shotgunAmmoOnClipFIX = 5;
    public float shotgunRangeTime = 0.2f;
    public float shotgunReloadTime = 1.8f;

    public float shotgunGunWaitLEVEL = 0;
    public float shotgunClipSizeLEVEL = 0;
    public float shotgunAmmoOnClipLEVEL = 0;
    public float shotgunlRangeTimeLEVEL = 0;
    public float shotgunReloadTimeLEVEL = 0;

    public TMP_Text shotgunTotalAmmoText;
    public TMP_Text shotgunFireRateText;
    public TMP_Text shotgunAmmoClipText;
    public TMP_Text shotgunReloadText; 
    public TMP_Text shotgunRangeText;

    public TMP_Text shotgunTotalAmmoTextLEVEL;
    public TMP_Text shotgunFireRateTextLEVEL;
    public TMP_Text shotgunAmmoClipTextLEVEL;
    public TMP_Text shotgunReloadTextLEVEL;
    public TMP_Text shotgunRangeTextLEVEL;

    public TMP_Text shotgunTotalAmmoGOLD;
    public TMP_Text shotgunFireRateGOLD;
    public TMP_Text shotgunAmmoClipGOLD;
    public TMP_Text shotgunReloadGOLD;
    public TMP_Text shotgunRangeGOLD;

    public TMP_Text gold;

    public GoldCount goldAmount;

    // Start is called before the first frame update
    void Start()
    {
        shotgunTotalAmmo = shotgunAmmoOnClip * shotgunClipSize;
        shotgunAmmoClipText.text = "Clip Size: " + shotgunAmmoOnClip;
        shotgunTotalAmmoText.text = "Total Ammo: " + (shotgunTotalAmmo + shotgunAmmoOnClip);
        shotgunReloadText.text = "Reload Time: " + shotgunReloadTime + " sec.";
        shotgunRangeText.text = "Range: " + (shotgunRangeTime * 10);
        shotgunFireRateText.text = "Weapon Cooldown: " + shotgunGunWait;

        shotgunTotalAmmoTextLEVEL.text = "Default";
        shotgunFireRateTextLEVEL.text = "Default";
        shotgunAmmoClipTextLEVEL.text = "Default";
        shotgunReloadTextLEVEL.text = "Default";
        shotgunRangeTextLEVEL.text = "Default";

        shotgunTotalAmmoGOLD.text = "1 gold to upgrade";
        shotgunFireRateGOLD.text = "1 gold to upgrade";
        shotgunAmmoClipGOLD.text = "1 gold to upgrade";
        shotgunReloadGOLD.text = "1 gold to upgrade";
        shotgunRangeGOLD.text = "1 gold to upgrade";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // -----

    public void shotgunGunWaitUpgrade() 
    {
        if (shotgunGunWaitLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            shotgunGunWaitLEVEL = 1;
            shotgunGunWait = 0.9f;

            shotgunFireRateText.text = "Weapon Cooldown: " + shotgunGunWait;
            shotgunFireRateTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunFireRateGOLD.text = "2 gold to upgrade";
        }

        else if (shotgunGunWaitLEVEL == 1 && goldAmount.goldCount >= 2) 
        {
            shotgunGunWaitLEVEL = 2;
            shotgunGunWait = 0.8f;

            shotgunFireRateText.text = "Weapon Cooldown: " + shotgunGunWait;
            shotgunFireRateTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunFireRateGOLD.text = "3 gold to upgrade";
        }

        else if (shotgunGunWaitLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            shotgunGunWaitLEVEL = 3;
            shotgunGunWait = 0.7f;

            shotgunFireRateText.text = "Weapon Cooldown: " + shotgunGunWait;
            shotgunFireRateTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunFireRateGOLD.text = "5 gold to upgrade";
        }

        else if (shotgunGunWaitLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            shotgunGunWaitLEVEL = 4;
            shotgunGunWait = 0.6f;

            shotgunFireRateText.text = "Weapon Cooldown: " + shotgunGunWait;
            shotgunFireRateTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunFireRateGOLD.text = "7 gold to upgrade";
        }

        else if (shotgunGunWaitLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            shotgunGunWaitLEVEL = 5;
            shotgunGunWait = 0.5f;

            shotgunFireRateText.text = "Weapon Cooldown: " + shotgunGunWait;
            shotgunFireRateTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunFireRateGOLD.text = "DONE";
        }
    }

    // -----

    public void shotgunClipSizeUpgrade()
    {
        if (shotgunClipSizeLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            shotgunClipSizeLEVEL = 1;
            shotgunClipSize = 2f;
            shotgunTotalAmmo = shotgunClipSize * shotgunAmmoOnClip;

            shotgunTotalAmmoText.text = "Total Ammo: " + (shotgunTotalAmmo + shotgunAmmoOnClip);
            shotgunTotalAmmoTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunTotalAmmoGOLD.text = "2 gold to upgrade";
        }

        else if (shotgunClipSizeLEVEL == 1 && goldAmount.goldCount >= 2)
        {
            shotgunClipSizeLEVEL = 2;
            shotgunClipSize = 3f;
            shotgunTotalAmmo = shotgunClipSize * shotgunAmmoOnClip;

            shotgunTotalAmmoText.text = "Total Ammo: " + (shotgunTotalAmmo + shotgunAmmoOnClip);
            shotgunTotalAmmoTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunTotalAmmoGOLD.text = "3 gold to upgrade";
        }

        else if (shotgunClipSizeLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            shotgunClipSizeLEVEL = 3;
            shotgunClipSize = 4f;
            shotgunTotalAmmo = shotgunClipSize * shotgunAmmoOnClip;

            shotgunTotalAmmoText.text = "Total Ammo: " + (shotgunTotalAmmo + shotgunAmmoOnClip);
            shotgunTotalAmmoTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunTotalAmmoGOLD.text = "5 gold to upgrade";
        }

        else if (shotgunClipSizeLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            shotgunClipSizeLEVEL = 4;
            shotgunClipSize = 5f;
            shotgunTotalAmmo = shotgunClipSize * shotgunAmmoOnClip;

            shotgunTotalAmmoText.text = "Total Ammo: " + (shotgunTotalAmmo + shotgunAmmoOnClip);
            shotgunTotalAmmoTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunTotalAmmoGOLD.text = "7 gold to upgrade";
        }

        else if (shotgunClipSizeLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            shotgunClipSizeLEVEL = 5;
            shotgunClipSize = 6f;
            shotgunTotalAmmo = shotgunClipSize * shotgunAmmoOnClip;

            shotgunTotalAmmoText.text = "Total Ammo: " + (shotgunTotalAmmo + shotgunAmmoOnClip);
            shotgunTotalAmmoTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunTotalAmmoGOLD.text = "DONE";
        }
    }

    // -----

    public void shotgunAmmoOnClipUpgrade()
    {
        if (shotgunAmmoOnClipLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            shotgunAmmoOnClipLEVEL = 1;
            shotgunAmmoOnClip = 6f;
            shotgunAmmoOnClipFIX = 6f;
            shotgunTotalAmmo = shotgunClipSize * shotgunAmmoOnClip;

            shotgunAmmoClipText.text = "Clip Size: " + shotgunAmmoOnClip;
            shotgunTotalAmmoText.text = "Total Ammo: " + (shotgunTotalAmmo + shotgunAmmoOnClip);
            shotgunAmmoClipTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunAmmoClipGOLD.text = "2 gold to upgrade";
        }

        else if (shotgunAmmoOnClipLEVEL == 1 && goldAmount.goldCount >= 2)
        {
            shotgunAmmoOnClipLEVEL = 2;
            shotgunAmmoOnClip = 7f;
            shotgunAmmoOnClipFIX = 7f;
            shotgunTotalAmmo = shotgunClipSize * shotgunAmmoOnClip;

            shotgunAmmoClipText.text = "Clip Size: " + shotgunAmmoOnClip;
            shotgunTotalAmmoText.text = "Total Ammo: " + (shotgunTotalAmmo + shotgunAmmoOnClip);
            shotgunAmmoClipTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunAmmoClipGOLD.text = "3 gold to upgrade";
        }

        else if (shotgunAmmoOnClipLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            shotgunAmmoOnClipLEVEL = 3;
            shotgunAmmoOnClip = 8f;
            shotgunAmmoOnClipFIX = 8f;
            shotgunTotalAmmo = shotgunClipSize * shotgunAmmoOnClip;

            shotgunAmmoClipText.text = "Clip Size: " + shotgunAmmoOnClip;
            shotgunTotalAmmoText.text = "Total Ammo: " + (shotgunTotalAmmo + shotgunAmmoOnClip);
            shotgunAmmoClipTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunAmmoClipGOLD.text = "5 gold to upgrade";
        }

        else if (shotgunAmmoOnClipLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            shotgunAmmoOnClipLEVEL = 4;
            shotgunAmmoOnClip = 10f;
            shotgunAmmoOnClipFIX = 10f;
            shotgunTotalAmmo = shotgunClipSize * shotgunAmmoOnClip;

            shotgunAmmoClipText.text = "Clip Size: " + shotgunAmmoOnClip;
            shotgunTotalAmmoText.text = "Total Ammo: " + (shotgunTotalAmmo + shotgunAmmoOnClip);
            shotgunAmmoClipTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunAmmoClipGOLD.text = "7 gold to upgrade";
        }

        else if (shotgunAmmoOnClipLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            shotgunAmmoOnClipLEVEL = 5;
            shotgunAmmoOnClip = 12f;
            shotgunAmmoOnClipFIX = 12f;
            shotgunTotalAmmo = shotgunClipSize * shotgunAmmoOnClip;

            shotgunAmmoClipText.text = "Clip Size: " + shotgunAmmoOnClip;
            shotgunTotalAmmoText.text = "Total Ammo: " + (shotgunTotalAmmo + shotgunAmmoOnClip);
            shotgunAmmoClipTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunAmmoClipGOLD.text = "DONE";
        }
    }

    // -----

    public void shotgunRangeTimeUpgrade()
    {
        if (shotgunlRangeTimeLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            shotgunlRangeTimeLEVEL = 1;
            shotgunRangeTime = 0.3f;

            shotgunRangeText.text = "Range: " + (shotgunRangeTime * 10);
            shotgunRangeTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunRangeGOLD.text = "2 gold to upgrade";
        }

        else if (shotgunlRangeTimeLEVEL == 1 && goldAmount.goldCount >= 2)
        {
            shotgunlRangeTimeLEVEL = 2;
            shotgunRangeTime = 0.4f;

            shotgunRangeText.text = "Range: " + (shotgunRangeTime * 10);
            shotgunRangeTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunRangeGOLD.text = "3 gold to upgrade";
        }

        else if (shotgunlRangeTimeLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            shotgunlRangeTimeLEVEL = 3;
            shotgunRangeTime = 0.5f;

            shotgunRangeText.text = "Range: " + (shotgunRangeTime * 10);
            shotgunRangeTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunRangeGOLD.text = "5 gold to upgrade";
        }

        else if (shotgunlRangeTimeLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            shotgunlRangeTimeLEVEL = 4;
            shotgunRangeTime = 0.6f;

            shotgunRangeText.text = "Range: " + (shotgunRangeTime * 10);
            shotgunRangeTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunRangeGOLD.text = "7 gold to upgrade";
        }

        else if (shotgunlRangeTimeLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            shotgunlRangeTimeLEVEL = 5;
            shotgunRangeTime = 0.8f;

            shotgunRangeText.text = "Range: " + (shotgunRangeTime * 10);
            shotgunRangeTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunRangeGOLD.text = "DONE";
        }
    }

    // -----

    public void shotgunReloadTimeUpgrade()
    {
        if (shotgunReloadTimeLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            shotgunReloadTimeLEVEL = 1;
            shotgunReloadTime = 1.6f;

            shotgunReloadText.text = "Reload Time: " + shotgunReloadTime + " sec.";
            shotgunReloadTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunReloadGOLD.text = "2 gold to upgrade";
        }

        else if (shotgunReloadTimeLEVEL == 1 && goldAmount.goldCount >= 2)
        {
            shotgunReloadTimeLEVEL = 2;
            shotgunReloadTime = 1.4f;

            shotgunReloadText.text = "Reload Time: " + shotgunReloadTime + " sec.";
            shotgunReloadTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunReloadGOLD.text = "3 gold to upgrade";
        }

        else if (shotgunReloadTimeLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            shotgunReloadTimeLEVEL = 3;
            shotgunReloadTime = 1.2f;

            shotgunReloadText.text = "Reload Time: " + shotgunReloadTime + " sec.";
            shotgunReloadTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunReloadGOLD.text = "5 gold to upgrade";
        }

        else if (shotgunReloadTimeLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            shotgunReloadTimeLEVEL = 4;
            shotgunReloadTime = 1f;

            shotgunReloadText.text = "Reload Time: " + shotgunReloadTime + " sec.";
            shotgunReloadTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunReloadGOLD.text = "7 gold to upgrade";
        }

        else if (shotgunReloadTimeLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            shotgunReloadTimeLEVEL = 5;
            shotgunReloadTime = 0.8f;

            shotgunReloadText.text = "Reload Time: " + shotgunReloadTime + " sec.";
            shotgunReloadTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            shotgunReloadGOLD.text = "DONE";
        }
    }

}
