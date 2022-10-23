using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuImages : MonoBehaviour
{
    public Image fr1;
    public Image fr2;
    public Image fr3;
    public Image fr4;
    public Image fr5;

    public Image cs1;
    public Image cs2;
    public Image cs3;
    public Image cs4;
    public Image cs5;

    public Image ao1;
    public Image ao2;
    public Image ao3;
    public Image ao4;
    public Image ao5;

    public Image ra1;
    public Image ra2;
    public Image ra3;
    public Image ra4;
    public Image ra5;

    public Image re1;
    public Image re2;
    public Image re3;
    public Image re4;
    public Image re5;

    public Image Afr1;
    public Image Afr2;
    public Image Afr3;
    public Image Afr4;
    public Image Afr5;

    public Image Acs1;
    public Image Acs2;
    public Image Acs3;
    public Image Acs4;
    public Image Acs5;

    public Image Aao1;
    public Image Aao2;
    public Image Aao3;
    public Image Aao4;
    public Image Aao5;

    public Image Ara1;
    public Image Ara2;
    public Image Ara3;
    public Image Ara4;
    public Image Ara5;

    public Image Are1;
    public Image Are2;
    public Image Are3;
    public Image Are4;
    public Image Are5;

    public Image Sfr1;
    public Image Sfr2;
    public Image Sfr3;
    public Image Sfr4;
    public Image Sfr5;

    public Image Scs1;
    public Image Scs2;
    public Image Scs3;
    public Image Scs4;
    public Image Scs5;

    public Image Sao1;
    public Image Sao2;
    public Image Sao3;
    public Image Sao4;
    public Image Sao5;

    public Image Sra1;
    public Image Sra2;
    public Image Sra3;
    public Image Sra4;
    public Image Sra5;

    public Image Sre1;
    public Image Sre2;
    public Image Sre3;
    public Image Sre4;
    public Image Sre5;

    public PistolUpgrades pistolUpgrades;
    public AutoUpgrades autoUpgrades;
    public ShotgunUpgrades shotgunUpgrades;

    public static float pistolA, pistolB, pistolC, pistolD, pistolE;

    Color32 green = new Color32(0, 255, 0, 40);

    // Start is called before the first frame update
    void Start()
    {
        //pistolA = PlayerPrefs.GetFloat("pistolDelayLevel");
        //pistolB = PlayerPrefs.GetFloat("pistolClipLevel");
        //pistolC = PlayerPrefs.GetFloat("pistolAmmoLevel");
        //pistolD = PlayerPrefs.GetFloat("pistolRangeLevel");
        //pistolE = PlayerPrefs.GetFloat("pistolReloadLevel");
    }

    // Update is called once per frame
    void Update()
    {
        pistolA = PlayerPrefs.GetFloat("pistolDelayLevel");
        pistolB = PlayerPrefs.GetFloat("pistolClipLevel");
        pistolC = PlayerPrefs.GetFloat("pistolAmmoLevel");
        pistolD = PlayerPrefs.GetFloat("pistolRangeLevel");
        pistolE = PlayerPrefs.GetFloat("pistolReloadLevel");

        if (pistolA == 1)
        {
            fr1.color = green;
        }
        else if (pistolA == 2)
        {
            fr1.color = green;
            fr2.color = green;
        }
        else if (pistolA == 3)
        {
            fr1.color = green;
            fr2.color = green;
            fr3.color = green;
        }
        else if (pistolA == 4)
        {
            fr1.color = green;
            fr2.color = green;
            fr3.color = green;
            fr4.color = green;
        }
        else if (pistolA == 5)
        {
            fr1.color = green;
            fr2.color = green;
            fr3.color = green;
            fr4.color = green;
            fr5.color = green;
        }

        //

        if (pistolB == 1)
        {
            cs1.color = green;
        }
        else if (pistolB == 2)
        {
            cs1.color = green;
            cs2.color = green;
        }
        else if (pistolB == 3)
        {
            cs1.color = green;
            cs2.color = green;
            cs3.color = green;
        }
        else if (pistolB == 4)
        {
            cs1.color = green;
            cs2.color = green;
            cs3.color = green;
            cs4.color = green;
        }
        else if (pistolB == 5)
        {
            cs1.color = green;
            cs2.color = green;
            cs3.color = green;
            cs4.color = green;
            cs5.color = green;
        }

        //

        if (pistolC == 1)
        {
            ao1.color = green;
        }
        else if (pistolC == 2)
        {
            ao1.color = green;
            ao2.color = green;
        }
        else if (pistolC == 3)
        {
            ao1.color = green;
            ao2.color = green;
            ao3.color = green;
        }
        else if (pistolC == 4)
        {
            ao1.color = green;
            ao2.color = green;
            ao3.color = green;
            ao4.color = green;
        }
        else if (pistolC == 5)
        {
            ao1.color = green;
            ao2.color = green;
            ao3.color = green;
            ao4.color = green;
            ao5.color = green;
        }

        //

        if (pistolD == 1)
        {
            ra1.color = green;
        }
        else if (pistolD == 2)
        {
            ra1.color = green;
            ra2.color = green;
        }
        else if (pistolD == 3)
        {
            ra1.color = green;
            ra2.color = green;
            ra3.color = green;
        }
        else if (pistolD == 4)
        {
            ra1.color = green;
            ra2.color = green;
            ra3.color = green;
            ra4.color = green;
        }
        else if (pistolD == 5)
        {
            ra1.color = green;
            ra2.color = green;
            ra3.color = green;
            ra4.color = green;
            ra5.color = green;
        }

        //

        if (pistolE == 1)
        {
            re1.color = green;
        }
        else if (pistolE == 2)
        {
            re1.color = green;
            re2.color = green;
        }
        else if (pistolE == 3)
        {
            re1.color = green;
            re2.color = green;
            re3.color = green;
        }
        else if (pistolE == 4)
        {
            re1.color = green;
            re2.color = green;
            re3.color = green;
            re4.color = green;
        }
        else if (pistolE == 5)
        {
            re1.color = green;
            re2.color = green;
            re3.color = green;
            re4.color = green;
            re5.color = green;
        }

        //

        //

        //

        //

        if (autoUpgrades.autoGunWaitLEVEL == 1)
        {
            Afr1.color = green;
        }
        else if (autoUpgrades.autoGunWaitLEVEL == 2)
        {
            Afr2.color = green;
        }
        else if (autoUpgrades.autoGunWaitLEVEL == 3)
        {
            Afr3.color = green;
        }
        else if (autoUpgrades.autoGunWaitLEVEL == 4)
        {
            Afr4.color = green;
        }
        else if (autoUpgrades.autoGunWaitLEVEL == 5)
        {
            Afr5.color = green;
        }

        //

        if (autoUpgrades.autoClipSizeLEVEL == 1)
        {
            Acs1.color = green;
        }
        else if (autoUpgrades.autoClipSizeLEVEL == 2)
        {
            Acs2.color = green;
        }
        else if (autoUpgrades.autoClipSizeLEVEL == 3)
        {
            Acs3.color = green;
        }
        else if (autoUpgrades.autoClipSizeLEVEL == 4)
        {
            Acs4.color = green;
        }
        else if (autoUpgrades.autoClipSizeLEVEL == 5)
        {
            Acs5.color = green;
        }

        //

        if (autoUpgrades.autoAmmoOnClipLEVEL == 1)
        {
            Aao1.color = green;
        }
        else if (autoUpgrades.autoAmmoOnClipLEVEL == 2)
        {
            Aao2.color = green;
        }
        else if (autoUpgrades.autoAmmoOnClipLEVEL == 3)
        {
            Aao3.color = green;
        }
        else if (autoUpgrades.autoAmmoOnClipLEVEL == 4)
        {
            Aao4.color = green;
        }
        else if (autoUpgrades.autoAmmoOnClipLEVEL == 5)
        {
            Aao5.color = green;
        }

        //

        if (autoUpgrades.autoRangeTimeLEVEL == 1)
        {
            Ara1.color = green;
        }
        else if (autoUpgrades.autoRangeTimeLEVEL == 2)
        {
            Ara2.color = green;
        }
        else if (autoUpgrades.autoRangeTimeLEVEL == 3)
        {
            Ara3.color = green;
        }
        else if (autoUpgrades.autoRangeTimeLEVEL == 4)
        {
            Ara4.color = green;
        }
        else if (autoUpgrades.autoRangeTimeLEVEL == 5)
        {
            Ara5.color = green;
        }

        //

        if (autoUpgrades.autoReloadTimeLEVEL == 1)
        {
            Are1.color = green;
        }
        else if (autoUpgrades.autoReloadTimeLEVEL == 2)
        {
            Are2.color = green;
        }
        else if (autoUpgrades.autoReloadTimeLEVEL == 3)
        {
            Are3.color = green;
        }
        else if (autoUpgrades.autoReloadTimeLEVEL == 4)
        {
            Are4.color = green;
        }
        else if (autoUpgrades.autoReloadTimeLEVEL == 5)
        {
            Are5.color = green;
        }

        //

        //

        //

        //

        if (shotgunUpgrades.shotgunGunWaitLEVEL == 1)
        {
            Sfr1.color = green;
        }
        else if (shotgunUpgrades.shotgunGunWaitLEVEL == 2)
        {
            Sfr2.color = green;
        }
        else if (shotgunUpgrades.shotgunGunWaitLEVEL == 3)
        {
            Sfr3.color = green;
        }
        else if (shotgunUpgrades.shotgunGunWaitLEVEL == 4)
        {
            Sfr4.color = green;
        }
        else if (shotgunUpgrades.shotgunGunWaitLEVEL == 5)
        {
            Sfr5.color = green;
        }

        //

        if (shotgunUpgrades.shotgunClipSizeLEVEL == 1)
        {
            Scs1.color = green;
        }
        else if (shotgunUpgrades.shotgunClipSizeLEVEL == 2)
        {
            Scs2.color = green;
        }
        else if (shotgunUpgrades.shotgunClipSizeLEVEL == 3)
        {
            Scs3.color = green;
        }
        else if (shotgunUpgrades.shotgunClipSizeLEVEL == 4)
        {
            Scs4.color = green;
        }
        else if (shotgunUpgrades.shotgunClipSizeLEVEL == 5)
        {
            Scs5.color = green;
        }

        //

        if (shotgunUpgrades.shotgunAmmoOnClipLEVEL == 1)
        {
            Sao1.color = green;
        }
        else if (shotgunUpgrades.shotgunAmmoOnClipLEVEL == 2)
        {
            Sao2.color = green;
        }
        else if (shotgunUpgrades.shotgunAmmoOnClipLEVEL == 3)
        {
            Sao3.color = green;
        }
        else if (shotgunUpgrades.shotgunAmmoOnClipLEVEL == 4)
        {
            Sao4.color = green;
        }
        else if (shotgunUpgrades.shotgunAmmoOnClipLEVEL == 5)
        {
            Sao5.color = green;
        }

        //

        if (shotgunUpgrades.shotgunlRangeTimeLEVEL == 1)
        {
            Sra1.color = green;
        }
        else if (shotgunUpgrades.shotgunlRangeTimeLEVEL == 2)
        {
            Sra2.color = green;
        }
        else if (shotgunUpgrades.shotgunlRangeTimeLEVEL == 3)
        {
            Sra3.color = green;
        }
        else if (shotgunUpgrades.shotgunlRangeTimeLEVEL == 4)
        {
            Sra4.color = green;
        }
        else if (shotgunUpgrades.shotgunlRangeTimeLEVEL == 5)
        {
            Sra5.color = green;
        }

        //

        if (shotgunUpgrades.shotgunReloadTimeLEVEL == 1)
        {
            Sre1.color = green;
        }
        else if (shotgunUpgrades.shotgunReloadTimeLEVEL == 2)
        {
            Sre2.color = green;
        }
        else if (shotgunUpgrades.shotgunReloadTimeLEVEL == 3)
        {
            Sre3.color = green;
        }
        else if (shotgunUpgrades.shotgunReloadTimeLEVEL == 4)
        {
            Sre4.color = green;
        }
        else if (shotgunUpgrades.shotgunReloadTimeLEVEL == 5)
        {
            Sre5.color = green;
        }


    }
}
