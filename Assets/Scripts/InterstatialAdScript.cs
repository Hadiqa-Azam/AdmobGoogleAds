using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterstatialAdScript : MonoBehaviour
{
    public void InterstatialAdShow()
    {
        GoogleAdMobController.Instance.ShowInterstitialAd();
    }
    public void ShowRewardedAdbUTTON()
    {
        GoogleAdMobController.Instance.ShowRewardedAd();
    }
}
