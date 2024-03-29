// DO NOT EDIT! This is an autogenerated file. All changes will be
// overwritten!

//	Copyright (c) 2016 Vidyo, Inc. All rights reserved.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Runtime.InteropServices;

namespace VidyoClient
{
	public class Call{
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		private IntPtr objPtr; // opaque VidyoCall reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoCallAcceptNative(IntPtr c, OnInitiated onInitiated, OnEnded onEnded);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoCallConstructCopyNative(IntPtr other);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoCallDestructNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoCallGetIdNative(IntPtr c);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoCallGetParticipantsNative(IntPtr c, IntPtr participants);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoCallGetRemoteRenderersNative(IntPtr c, IntPtr renderers);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoCallGetRemoteSpeakersNative(IntPtr c, IntPtr speakers);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoCallGetSubjectNative(IntPtr c);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoCallGetUserNative(IntPtr c);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoCallHangUpNative(IntPtr c);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoCallInitiateNative(IntPtr c, OnInitiated onInitiated, OnEnded onEnded);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoCallRegisterMessageEventListenerNative(IntPtr c, OnMessageReceived onMessageReceived, OnMessageAcknowledged onMessageAcknowledged, OnMessageRead onMessageRead, OnMessageTypingIndication onMessageTypingIndication);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoCallRegisterSubjectEventListenerNative(IntPtr c, OnSetSubject onSetSubject);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoCallRejectNative(IntPtr c);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoCallSendMessageNative(IntPtr c, IntPtr message);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoCallSetSubjectNative(IntPtr c, IntPtr subject);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoCallGetUserDataNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoCallSetUserDataNative(IntPtr obj, IntPtr userData);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void OnEnded(IntPtr c, IntPtr p, CallEndReason reason);
		private static OnEnded _mOnEnded;
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void OnInitiated(IntPtr c, CallInitiatedResult result, IntPtr p);
		private static OnInitiated _mOnInitiated;
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void OnMessageAcknowledged(IntPtr c, IntPtr chatMessage);
		private static OnMessageAcknowledged _mOnMessageAcknowledged;
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void OnMessageRead(IntPtr c, IntPtr participant, long messageId);
		private static OnMessageRead _mOnMessageRead;
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void OnMessageReceived(IntPtr c, IntPtr participant, IntPtr chatMessage);
		private static OnMessageReceived _mOnMessageReceived;
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void OnMessageTypingIndication(IntPtr c, IntPtr participant, ChatMessage.ChatMessageTypingIndication typingIndication);
		private static OnMessageTypingIndication _mOnMessageTypingIndication;
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void OnSetSubject(IntPtr c, IntPtr subject);
		private static OnSetSubject _mOnSetSubject;
		public enum CallEndReason{
			CallendreasonEnded,
			CallendreasonConnectionFailed,
			CallendreasonConnectionLost,
			CallendreasonParticipantBusy,
			CallendreasonParticipantRejected,
			CallendreasonParticipantEnded,
			CallendreasonMiscError
		}
		public enum CallInitiatedResult{
			CallinitiatedresultOK,
			CallinitiatedresultCancelled,
			CallinitiatedresultNoResponse,
			CallinitiatedresultUnknownParticipant,
			CallinitiatedresultMiscLocalError,
			CallinitiatedresultMiscRemoteError
		}
		public interface IAccept{

			void OnInitiated(CallInitiatedResult result, Participant p);
			void OnEnded(Participant p, CallEndReason reason);
		}
		public interface IRegisterMessageEventListener{

			void OnMessageReceived(Participant participant, ChatMessage chatMessage);
			void OnMessageAcknowledged(ChatMessage chatMessage);
			void OnMessageRead(Participant participant, long messageId);
			void OnMessageTypingIndication(Participant participant, ChatMessage.ChatMessageTypingIndication typingIndication);
		}
		public interface IRegisterSubjectEventListener{

			void OnSetSubject(String subject);
		}
		private static IAccept _mIAccept;
		private static IRegisterMessageEventListener _mIRegisterMessageEventListener;
		private static IRegisterSubjectEventListener _mIRegisterSubjectEventListener;
		public Call(IntPtr other){
			objPtr = VidyoCallConstructCopyNative(other);
			VidyoCallSetUserDataNative(objPtr, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Weak)));
		}
		~Call(){
			if(objPtr != IntPtr.Zero){
				VidyoCallSetUserDataNative(objPtr, IntPtr.Zero);
				VidyoCallDestructNative(objPtr);
			}
		}
		public Boolean Accept(IAccept _iIAccept){
			_mIAccept = _iIAccept;
			_mOnInitiated = OnInitiatedDelegate;
			_mOnEnded = OnEndedDelegate;

			Boolean ret = VidyoCallAcceptNative(objPtr, _mOnInitiated, _mOnEnded);

			return ret;
		}
		public String GetId(){

			IntPtr ret = VidyoCallGetIdNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public Boolean GetParticipants(List<Participant> participants){

			IntPtr nParticipants = IntPtr.Zero;

			Boolean ret = VidyoCallGetParticipantsNative(objPtr, nParticipants);

			return ret;
		}
		public Boolean GetRemoteRenderers(List<RemoteRenderer> renderers){

			IntPtr nRenderers = IntPtr.Zero;

			Boolean ret = VidyoCallGetRemoteRenderersNative(objPtr, nRenderers);

			return ret;
		}
		public Boolean GetRemoteSpeakers(List<RemoteSpeaker> speakers){

			IntPtr nSpeakers = IntPtr.Zero;

			Boolean ret = VidyoCallGetRemoteSpeakersNative(objPtr, nSpeakers);

			return ret;
		}
		public String GetSubject(){

			IntPtr ret = VidyoCallGetSubjectNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public User GetUser(){

			IntPtr ret = VidyoCallGetUserNative(objPtr);
			User csRet = null;
			if(ret != IntPtr.Zero){
				if(User.VidyoUserGetUserDataNative(ret) == IntPtr.Zero)
					csRet = new User(ret);
				else{
					GCHandle objHandle = (GCHandle)User.VidyoUserGetUserDataNative(ret);
					csRet = (User)objHandle.Target;
				}
			}

			return csRet;
		}
		public void HangUp(){

			VidyoCallHangUpNative(objPtr);
		}
		public Boolean Initiate(IAccept _iIAccept){
			_mIAccept = _iIAccept;
			_mOnInitiated = OnInitiatedDelegate;
			_mOnEnded = OnEndedDelegate;

			Boolean ret = VidyoCallInitiateNative(objPtr, _mOnInitiated, _mOnEnded);

			return ret;
		}
		public Boolean RegisterMessageEventListener(IRegisterMessageEventListener _iIRegisterMessageEventListener){
			_mIRegisterMessageEventListener = _iIRegisterMessageEventListener;
			_mOnMessageReceived = OnMessageReceivedDelegate;
			_mOnMessageAcknowledged = OnMessageAcknowledgedDelegate;
			_mOnMessageRead = OnMessageReadDelegate;
			_mOnMessageTypingIndication = OnMessageTypingIndicationDelegate;

			Boolean ret = VidyoCallRegisterMessageEventListenerNative(objPtr, _mOnMessageReceived, _mOnMessageAcknowledged, _mOnMessageRead, _mOnMessageTypingIndication);

			return ret;
		}
		public Boolean RegisterSubjectEventListener(IRegisterSubjectEventListener _iIRegisterSubjectEventListener){
			_mIRegisterSubjectEventListener = _iIRegisterSubjectEventListener;
			_mOnSetSubject = OnSetSubjectDelegate;

			Boolean ret = VidyoCallRegisterSubjectEventListenerNative(objPtr, _mOnSetSubject);

			return ret;
		}
		public void Reject(){

			VidyoCallRejectNative(objPtr);
		}
		public Boolean SendMessage(String message){

			IntPtr nMessage = MarshalPtrToUtf8.GetInstance().MarshalManagedToNative(message ?? string.Empty);
			Boolean ret = VidyoCallSendMessageNative(objPtr, nMessage);
			Marshal.FreeHGlobal(nMessage);

			return ret;
		}
		public Boolean SetSubject(String subject){

			IntPtr nSubject = MarshalPtrToUtf8.GetInstance().MarshalManagedToNative(subject ?? string.Empty);
			Boolean ret = VidyoCallSetSubjectNative(objPtr, nSubject);
			Marshal.FreeHGlobal(nSubject);

			return ret;
		}
#if __IOS__
[ObjCRuntime.MonoPInvokeCallback(typeof(OnEnded))]
#endif
		private static void OnEndedDelegate(IntPtr c, IntPtr p, CallEndReason reason){
			Participant csP = null;
			if(p != IntPtr.Zero){
				if(Participant.VidyoParticipantGetUserDataNative(p) == IntPtr.Zero)
					csP = new Participant(p);
				else{
					GCHandle objHandle = (GCHandle)Participant.VidyoParticipantGetUserDataNative(p);
					csP = (Participant)objHandle.Target;
				}
			}
			if(_mIAccept != null)
				_mIAccept.OnEnded(csP, reason);
		}
#if __IOS__
[ObjCRuntime.MonoPInvokeCallback(typeof(OnInitiated))]
#endif
		private static void OnInitiatedDelegate(IntPtr c, CallInitiatedResult result, IntPtr p){
			Participant csP = null;
			if(p != IntPtr.Zero){
				if(Participant.VidyoParticipantGetUserDataNative(p) == IntPtr.Zero)
					csP = new Participant(p);
				else{
					GCHandle objHandle = (GCHandle)Participant.VidyoParticipantGetUserDataNative(p);
					csP = (Participant)objHandle.Target;
				}
			}
			if(_mIAccept != null)
				_mIAccept.OnInitiated(result, csP);
		}
#if __IOS__
[ObjCRuntime.MonoPInvokeCallback(typeof(OnMessageAcknowledged))]
#endif
		private static void OnMessageAcknowledgedDelegate(IntPtr c, IntPtr chatMessage){
			ChatMessage csChatMessage = new ChatMessage(chatMessage);
			if(_mIRegisterMessageEventListener != null)
				_mIRegisterMessageEventListener.OnMessageAcknowledged(csChatMessage);
		}
#if __IOS__
[ObjCRuntime.MonoPInvokeCallback(typeof(OnMessageRead))]
#endif
		private static void OnMessageReadDelegate(IntPtr c, IntPtr participant, long messageId){
			Participant csParticipant = null;
			if(participant != IntPtr.Zero){
				if(Participant.VidyoParticipantGetUserDataNative(participant) == IntPtr.Zero)
					csParticipant = new Participant(participant);
				else{
					GCHandle objHandle = (GCHandle)Participant.VidyoParticipantGetUserDataNative(participant);
					csParticipant = (Participant)objHandle.Target;
				}
			}
			if(_mIRegisterMessageEventListener != null)
				_mIRegisterMessageEventListener.OnMessageRead(csParticipant, messageId);
		}
#if __IOS__
[ObjCRuntime.MonoPInvokeCallback(typeof(OnMessageReceived))]
#endif
		private static void OnMessageReceivedDelegate(IntPtr c, IntPtr participant, IntPtr chatMessage){
			Participant csParticipant = null;
			if(participant != IntPtr.Zero){
				if(Participant.VidyoParticipantGetUserDataNative(participant) == IntPtr.Zero)
					csParticipant = new Participant(participant);
				else{
					GCHandle objHandle = (GCHandle)Participant.VidyoParticipantGetUserDataNative(participant);
					csParticipant = (Participant)objHandle.Target;
				}
			}
			ChatMessage csChatMessage = new ChatMessage(chatMessage);
			if(_mIRegisterMessageEventListener != null)
				_mIRegisterMessageEventListener.OnMessageReceived(csParticipant, csChatMessage);
		}
#if __IOS__
[ObjCRuntime.MonoPInvokeCallback(typeof(OnMessageTypingIndication))]
#endif
		private static void OnMessageTypingIndicationDelegate(IntPtr c, IntPtr participant, ChatMessage.ChatMessageTypingIndication typingIndication){
			Participant csParticipant = null;
			if(participant != IntPtr.Zero){
				if(Participant.VidyoParticipantGetUserDataNative(participant) == IntPtr.Zero)
					csParticipant = new Participant(participant);
				else{
					GCHandle objHandle = (GCHandle)Participant.VidyoParticipantGetUserDataNative(participant);
					csParticipant = (Participant)objHandle.Target;
				}
			}
			if(_mIRegisterMessageEventListener != null)
				_mIRegisterMessageEventListener.OnMessageTypingIndication(csParticipant, typingIndication);
		}
#if __IOS__
[ObjCRuntime.MonoPInvokeCallback(typeof(OnSetSubject))]
#endif
		private static void OnSetSubjectDelegate(IntPtr c, IntPtr subject){
			if(_mIRegisterSubjectEventListener != null)
				_mIRegisterSubjectEventListener.OnSetSubject((string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(subject));
		}
	};
}
