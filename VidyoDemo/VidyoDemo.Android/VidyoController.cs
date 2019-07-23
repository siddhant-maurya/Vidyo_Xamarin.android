using System;
using System.Collections.Generic;
using VidyoClient;

namespace VidyoDemo.Droid
{
    public class VidyoController : Connector.IConnect, Connector.IRegisterLocalSpeakerEventListener, Connector.IRegisterLocalMicrophoneEventListener
    {
        Connector c;
        List<LocalMicrophone> _localMicrophones = new List<LocalMicrophone>();
        List<LocalSpeaker> _localSpeakers = new List<LocalSpeaker>();
        public VidyoController()
        {
                
        }

        public void Initialize(IntPtr viewId, uint width, uint height)
        {
            ConnectorPKG.Initialize();
            c = new Connector(viewId, Connector.ConnectorViewStyle.ConnectorviewstyleDefault, 15, "", "", 0);
            c.ShowViewAt(viewId, 0, 0, width, height);
            c.SetMicrophonePrivacy(false);
            c.SetSpeakerPrivacy(false);
            c.SelectDefaultCamera();
            c.SelectDefaultMicrophone();
            c.SelectDefaultSpeaker();
            
        }

        public void Connect()
        {
            string token = "";
            c.Connect("prod.vidyo.io", token, "Sid", "Taritas", this);
        }

        public void Disconnect()
        {
            c.Disconnect();
        }

        public void CycleCamer()
        {
            c.CycleCamera();
        }

        public void SetMicrophonePrivacy(bool privacy)
        {
            c.SetMicrophonePrivacy(privacy);
        }

        public void OnSuccess()
        {
        }

        public void OnFailure(Connector.ConnectorFailReason reason)
        {
        }

        public void OnDisconnected(Connector.ConnectorDisconnectReason reason)
        {
        }
        public void OnLocalMicrophoneAdded(LocalMicrophone localMicrophone)
        {
            _localMicrophones.Add(localMicrophone);
        }

        public void OnLocalMicrophoneRemoved(LocalMicrophone localMicrophone)
        {
            _localMicrophones.Remove(localMicrophone);
        }

        public void OnLocalMicrophoneSelected(LocalMicrophone localMicrophone)
        {
            
        }

        public void OnLocalMicrophoneStateUpdated(LocalMicrophone localMicrophone, Device.DeviceState state)
        {

        }

        public void OnLocalSpeakerAdded(LocalSpeaker localSpeaker)
        {
            _localSpeakers.Add(localSpeaker);
        }

        public void OnLocalSpeakerRemoved(LocalSpeaker localSpeaker)
        {
            _localSpeakers.Remove(localSpeaker);
        }

        public void OnLocalSpeakerSelected(LocalSpeaker localSpeaker)
        {
            
        }

        public void OnLocalSpeakerStateUpdated(LocalSpeaker localSpeaker, Device.DeviceState state)
        {

        }
    }
}