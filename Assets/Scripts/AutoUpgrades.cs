using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AutoUpgrades : MonoBehaviour
{
    public float autoGunWait = 0.4f;
    public float autoClipSize = 1;
    public float autoTotalAmmo;
    public float autoAmmoOnClip = 10;
    public float autoAmmoOnClipFIX = 10;
    public float autoRangeTime = 0.3f;
    public float autoReloadTime = 1.6f;

    public float autoGunWaitLEVEL = 0;
    public float autoClipSizeLEVEL = 0;
    public float autoAmmoOnClipLEVEL = 0;
    public float autoRangeTimeLEVEL = 0;
    public float autoReloadTimeLEVEL = 0;

    public TMP_Text autoTotalAmmoText;
    public TMP_Text autoFireRateText;
    public TMP_Text autoAmmoClipText;
    public TMP_Text autoReloadText;
    public TMP_Text autoRangeText;

    public TMP_Text autoTotalAmmoTextLEVEL;
    public TMP_Text autoFireRateTextLEVEL;
    public TMP_Text autoAmmoClipTextLEVEL;
    public TMP_Text autoReloadTextLEVEL;
    public TMP_Text autoRangeTextLEVEL;

    public TMP_Text autoTotalAmmoGOLD;
    public TMP_Text autoFireRateGOLD;
    public TMP_Text autoAmmoClipGOLD;
    public TMP_Text autoReloadGOLD;
    public TMP_Text autoRangeGOLD;

    public TMP_Text gold;

    public GoldCount goldAmount;

    // Start is called before the first frame update
    void Start()
    {
        autoTotalAmmo = autoClipSize * autoAmmoOnClip;
        autoAmmoClipText.text = "Clip Size: " + autoAmmoOnClip;
        autoTotalAmmoText.text = "Total Ammo: " + (autoTotalAmmo + autoAmmoOnClip);
        autoReloadText.text = "Reload Time: " + autoReloadTime + " sec.";
        autoRangeText.text = "Range: " + (autoRangeTime * 10);
        autoFireRateText.text = "Weapon Cooldown: " + autoGunWait;

        autoTotalAmmoTextLEVEL.text = "Default";
        autoFireRateTextLEVEL.text = "Default";
        autoAmmoClipTextLEVEL.text = "Default";
        autoReloadTextLEVEL.text = "Default";
        autoRangeTextLEVEL.text = "Default";

        autoTotalAmmoGOLD.text = "1 gold to upgrade";
        autoFireRateGOLD.text = "1 gold to upgrade";
        autoAmmoClipGOLD.text = "1 gold to upgrade";
        autoReloadGOLD.text = "1 gold to upgrade";
        autoRangeGOLD.text = "1 gold to upgrade";

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // -----

    public void autoGunWaitUpgrade() 
    {
        if (autoGunWaitLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            autoGunWaitLEVEL = 1;
            autoGunWait = 0.35f;

            autoFireRateText.text = "Weapon Cooldown: " + autoGunWait;
            autoFireRateTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            autoFireRateGOLD.text = "2 gold to upgrade";
        }

        else if (autoGunWaitLEVEL == 1 && goldAmount.goldCount >= 2) 
        {
            autoGunWaitLEVEL = 2;
            autoGunWait = 0.3f;

            autoFireRateText.text = "Weapon Cooldown: " + autoGunWait;
            autoFireRateTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            autoFireRateGOLD.text = "3 gold to upgrade";
        }

        else if (autoGunWaitLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            autoGunWaitLEVEL = 3;
            autoGunWait = 0.25f;

            autoFireRateText.text = "Weapon Cooldown: " + autoGunWait;
            autoFireRateTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            autoFireRateGOLD.text = "5 gold to upgrade";
        }

        else if (autoGunWaitLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            autoGunWaitLEVEL = 4;
            autoGunWait = 0.2f;

            autoFireRateText.text = "Weapon Cooldown: " + autoGunWait;
            autoFireRateTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            autoFireRateGOLD.text = "7 gold to upgrade";
        }

        else if (autoGunWaitLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            autoGunWaitLEVEL = 5;
            autoGunWait = 0.1f;

            autoFireRateText.text = "Weapon Cooldown: " + autoGunWait;
            autoFireRateTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            autoFireRateGOLD.text = "DONE";
        }
    }

    // -----

    public void autoClipSizeUpgrade()
    {
        if (autoClipSizeLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            autoClipSizeLEVEL = 1;
            autoClipSize = 2f;
            autoTotalAmmo = autoClipSize * autoAmmoOnClip;

            autoTotalAmmoText.text = "Total Ammo: " + (autoTotalAmmo + autoAmmoOnClip);
            autoTotalAmmoTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            autoTotalAmmoGOLD.text = "2 gold to upgrade";
        }

        else if (autoClipSizeLEVEL == 1 && goldAmount.goldCount >= 2)
        {
            autoClipSizeLEVEL = 2;
            autoClipSize = 3f;
            autoTotalAmmo = autoClipSize * autoAmmoOnClip;

            autoTotalAmmoText.text = "Total Ammo: " + (autoTotalAmmo + autoAmmoOnClip);
            autoTotalAmmoTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            autoTotalAmmoGOLD.text = "3 gold to upgrade";
        }

        else if (autoClipSizeLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            autoClipSizeLEVEL = 3;
            autoClipSize = 4f;
            autoTotalAmmo = autoClipSize * autoAmmoOnClip;

            autoTotalAmmoText.text = "Total Ammo: " + (autoTotalAmmo + autoAmmoOnClip);
            autoTotalAmmoTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            autoTotalAmmoGOLD.text = "5 gold to upgrade";
        }

        else if (autoClipSizeLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            autoClipSizeLEVEL = 4;
            autoClipSize = 5f;
            autoTotalAmmo = autoClipSize * autoAmmoOnClip;

            autoTotalAmmoText.text = "Total Ammo: " + (autoTotalAmmo + autoAmmoOnClip);
            autoTotalAmmoTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            autoTotalAmmoGOLD.text = "7 gold to upgrade";
        }

        else if (autoClipSizeLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            autoClipSizeLEVEL = 5;
            autoClipSize = 6f;
            autoTotalAmmo = autoClipSize * autoAmmoOnClip;

            autoTotalAmmoText.text = "Total Ammo: " + (autoTotalAmmo + autoAmmoOnClip);
            autoTotalAmmoTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            autoTotalAmmoGOLD.text = "DONE";
        }
    }

    // -----

    public void autoAmmoOnClipUpgrade()
    {
        if (autoAmmoOnClipLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            autoAmmoOnClipLEVEL = 1;
            autoAmmoOnClip = 12f;
            autoAmmoOnClipFIX = 12f;
            autoTotalAmmo = autoClipSize * autoAmmoOnClip;

            autoAmmoClipText.text = "Clip Size: " + autoAmmoOnClip;
            autoTotalAmmoText.text = "Total Ammo: " + (autoTotalAmmo + autoAmmoOnClip);
            autoAmmoClipTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            autoAmmoClipGOLD.text = "2 gold to upgrade";
        }

        else if (autoAmmoOnClipLEVEL == 1 && goldAmount.goldCount >= 2)
        {
            autoAmmoOnClipLEVEL = 2;
            autoAmmoOnClip = 14f;
            autoAmmoOnClipFIX = 14f;
            autoTotalAmmo = autoClipSize * autoAmmoOnClip;

            autoAmmoClipText.text = "Clip Size: " + autoAmmoOnClip;
            autoTotalAmmoText.text = "Total Ammo: " + (autoTotalAmmo + autoAmmoOnClip);
            autoAmmoClipTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            autoAmmoClipGOLD.text = "3 gold to upgrade";
        }

        else if (autoAmmoOnClipLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            autoAmmoOnClipLEVEL = 3;
            autoAmmoOnClip = 16f;
            autoAmmoOnClipFIX = 16f;
            autoTotalAmmo = autoClipSize * autoAmmoOnClip;

            autoAmmoClipText.text = "Clip Size: " + autoAmmoOnClip;
            autoTotalAmmoText.text = "Total Ammo: " + (autoTotalAmmo + autoAmmoOnClip);
            autoAmmoClipTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            autoAmmoClipGOLD.text = "5 gold to upgrade";
        }

        else if (autoAmmoOnClipLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            autoAmmoOnClipLEVEL = 4;
            autoAmmoOnClip = 18f;
            autoAmmoOnClipFIX = 18f;
            autoTotalAmmo = autoClipSize * autoAmmoOnClip;

            autoAmmoClipText.text = "Clip Size: " + autoAmmoOnClip;
            autoTotalAmmoText.text = "Total Ammo: " + (autoTotalAmmo + autoAmmoOnClip);
            autoAmmoClipTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            autoAmmoClipGOLD.text = "7 gold to upgrade";
        }

        else if (autoAmmoOnClipLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            autoAmmoOnClipLEVEL = 5;
            autoAmmoOnClip = 20f;
            autoAmmoOnClipFIX = 20f;
            autoTotalAmmo = autoClipSize * autoAmmoOnClip;

            autoAmmoClipText.text = "Clip Size: " + autoAmmoOnClip;
            autoTotalAmmoText.text = "Total Ammo: " + (autoTotalAmmo + autoAmmoOnClip);
            autoAmmoClipTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            autoAmmoClipGOLD.text = "DONE";
        }
    }

    // -----

    public void autoRangeTimeUpgrade()
    {
        if (autoRangeTimeLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            autoRangeTimeLEVEL = 1;
            autoRangeTime = 0.35f;

            autoRangeText.text = "Range: " + (autoRangeTime * 10);
            autoRangeTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            autoRangeGOLD.text = "2 gold to upgrade";
        }

        else if (autoRangeTimeLEVEL == 1 && goldAmount.goldCount >= 2)
        {
            autoRangeTimeLEVEL = 2;
            autoRangeTime = 0.4f;

            autoRangeText.text = "Range: " + (autoRangeTime * 10);
            autoRangeTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            autoRangeGOLD.text = "3 gold to upgrade";
        }

        else if (autoRangeTimeLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            autoRangeTimeLEVEL = 3;
            autoRangeTime = 0.5f;

            autoRangeText.text = "Range: " + (autoRangeTime * 10);
            autoRangeTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            autoRangeGOLD.text = "5 gold to upgrade";
        }

        else if (autoRangeTimeLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            autoRangeTimeLEVEL = 4;
            autoRangeTime = 0.6f;

            autoRangeText.text = "Range: " + (autoRangeTime * 10);
            autoRangeTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            autoRangeGOLD.text = "7 gold to upgrade";
        }

        else if (autoRangeTimeLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            autoRangeTimeLEVEL = 5;
            autoRangeTime = 0.8f;

            autoRangeText.text = "Range: " + (autoRangeTime * 10);
            autoRangeTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            autoRangeGOLD.text = "DONE";
        }
    }

    // -----

    public void autoReloadTimeUpgrade()
    {
        if (autoReloadTimeLEVEL == 0 && goldAmount.goldCount >= 1)
        {
            autoReloadTimeLEVEL = 1;
            autoReloadTime = 1.4f;

            autoReloadText.text = "Reload Time: " + autoReloadTime + " sec.";
            autoReloadTextLEVEL.text = "Level 1";

            goldAmount.goldCount = goldAmount.goldCount - 1;
            gold.text = goldAmount.goldCount + " Gold";
            autoReloadGOLD.text = "2 gold to upgrade";
        }

        else if (autoReloadTimeLEVEL == 1 && goldAmount.goldCount >= 2)
        {
            autoReloadTimeLEVEL = 2;
            autoReloadTime = 1.2f;

            autoReloadText.text = "Reload Time: " + autoReloadTime + " sec.";
            autoReloadTextLEVEL.text = "Level 2";

            goldAmount.goldCount = goldAmount.goldCount - 2;
            gold.text = goldAmount.goldCount + " Gold";
            autoReloadGOLD.text = "3 gold to upgrade";
        }

        else if (autoReloadTimeLEVEL == 2 && goldAmount.goldCount >= 3)
        {
            autoReloadTimeLEVEL = 3;
            autoReloadTime = 1f;

            autoReloadText.text = "Reload Time: " + autoReloadTime + " sec.";
            autoReloadTextLEVEL.text = "Level 3";

            goldAmount.goldCount = goldAmount.goldCount - 3;
            gold.text = goldAmount.goldCount + " Gold";
            autoReloadGOLD.text = "5 gold to upgrade";
        }

        else if (autoReloadTimeLEVEL == 3 && goldAmount.goldCount >= 5)
        {
            autoReloadTimeLEVEL = 4;
            autoReloadTime = 0.8f;

            autoReloadText.text = "Reload Time: " + autoReloadTime + " sec.";
            autoReloadTextLEVEL.text = "Level 4";

            goldAmount.goldCount = goldAmount.goldCount - 5;
            gold.text = goldAmount.goldCount + " Gold";
            autoReloadGOLD.text = "7 gold to upgrade";
        }

        else if (autoReloadTimeLEVEL == 4 && goldAmount.goldCount >= 7)
        {
            autoReloadTimeLEVEL = 5;
            autoReloadTime = 0.6f;

            autoReloadText.text = "Reload Time: " + autoReloadTime + " sec.";
            autoReloadTextLEVEL.text = "Level MAX";

            goldAmount.goldCount = goldAmount.goldCount - 7;
            gold.text = goldAmount.goldCount + " Gold";
            autoReloadGOLD.text = "DONE";
        }
    }

}
