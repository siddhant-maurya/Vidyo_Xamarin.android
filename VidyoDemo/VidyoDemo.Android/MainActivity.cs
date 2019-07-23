using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace VidyoDemo.Droid
{
    [Activity(Label = "VidyoDemo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : Activity
    {
        VidyoController vc = new VidyoController();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);

            Button initButton = FindViewById<Button>(Resource.Id.initialize);
            Button connectButton = FindViewById<Button>(Resource.Id.connect);
            Button disconnectButton = FindViewById<Button>(Resource.Id.disconnect);
            Button cycleCameraButton = FindViewById<Button>(Resource.Id.cycleCamera);
            FrameLayout videoView = FindViewById<FrameLayout>(Resource.Id.videoView);

            initButton.Click += delegate {
                VidyoClient.ConnectorPKG.SetApplicationUIContext(this);
                vc.Initialize(videoView.Handle, (uint)videoView.Width, (uint)videoView.Height);
            };
            connectButton.Click += delegate { vc.Connect(); };
            disconnectButton.Click += delegate { vc.Disconnect(); };
            cycleCameraButton.Click += delegate { vc.CycleCamer(); };
        }
    }
}