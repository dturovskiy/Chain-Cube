using GoogleMobileAds.Api;
using UnityEngine;

public class InterAd : MonoBehaviour
{
    private InterstitialAd interstitialAd;

    private readonly string interstitialUnitId = "ca-app-pub-3940256099942544/1033173712";

    private void OnEnable()
    {
        interstitialAd = new InterstitialAd(interstitialUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        interstitialAd.LoadAd(adRequest);
    }

    public void ShowAd()
    {
        if (interstitialAd.IsLoaded())
        {
            interstitialAd.Show();
            AdRequest adRequest = new AdRequest.Builder().Build();
            interstitialAd.LoadAd(adRequest);
        }
    }
}
