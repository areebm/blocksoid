﻿using System;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;

// Example script showing how to invoke the Google Mobile Ads Unity plugin.
public class GoogleMobileAdsDemoScript : MonoBehaviour {
	
	private BannerView bannerView;

	void Start()
	{
		#if UNITY_EDITOR
		string adUnitId = "unused";
		#elif UNITY_ANDROID
		string adUnitId = "ca-app-pub-3396109983733486/7978931255";
		#elif UNITY_IPHONE
		string adUnitId = "ca-app-pub-3396109983733486/7978931255";
		#else
		string adUnitId = "unexpected_platform";
		#endif
		
		// Create a 320x50 banner at the top of the screen.
		bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);
//		 Register for ad events.
//		bannerView.AdLoaded = bannerView.AdLoaded + HandleAdLoaded;
//		bannerView.AdFailedToLoad = bannerView.AdFailedToLoad + HandleAdFailedToLoad;
//		bannerView.AdOpened = bannerView.AdOpened + HandleAdOpened;
//		bannerView.AdClosing = bannerView.AdClosing + HandleAdClosing;
//		bannerView.AdClosed = bannerView.AdClosed + HandleAdClosed;
//		bannerView.AdLeftApplication = bannerView.AdLeftApplication + HandleAdLeftApplication;

//'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
		RequestBanner();
		ShowBanner();
	}

	public void RequestBanner() {
		// Request a banner ad, with optional custom ad targeting.
		AdRequest request = new AdRequest.Builder()
			.AddTestDevice(AdRequest.TestDeviceSimulator)
				.AddTestDevice("0123456789ABCDEF0123456789ABCDEF")
				.AddKeyword("game")
				.SetGender(Gender.Male)
				.SetBirthday(new DateTime(2005, 1, 1))
				.TagForChildDirectedTreatment(false)
				.AddExtra("color_bg", "9B30FF")
				.Build();
		bannerView.LoadAd(request);
	}
	
	public void ShowBanner() {
		bannerView.Show();
	}
	
	public void HideBanner() {
		bannerView.Hide();
	}
	
	#region Banner callback handlers
	
	public void HandleAdLoaded()
	{
		print("HandleAdLoaded event received.");
	}
	
	public void HandleAdFailedToLoad(string message)
	{
		print("HandleFailedToReceiveAd event received with message: " + message);
	}
	
	public void HandleAdOpened()
	{
		print("HandleAdOpened event received");
	}
	
	void HandleAdClosing ()
	{
		print("HandleAdClosing event received");
	}
	
	public void HandleAdClosed()
	{
		print("HandleAdClosed event received");
	}
	
	public void HandleAdLeftApplication()
	{
		print("HandleAdLeftApplication event received");
	}
	
	#endregion
}
