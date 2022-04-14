using GoogleMobileAds.Api;
using UnityEngine;
using System;

public class ADSGoogle : MonoBehaviour
{
    private BannerView bannerView;
    private void Awake()
    {
        MobileAds.Initialize(InitializationStatus => { });
        this.RequestBanner();
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3940256099942544/6300978111";
#else
        string adUnitId = "unexpected_platform";
#endif
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();
        bannerView.LoadAd(request);
    }
}