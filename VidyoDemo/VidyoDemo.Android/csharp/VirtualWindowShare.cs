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
	public class VirtualWindowShare{
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		private IntPtr objPtr; // opaque VidyoVirtualWindowShare reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVirtualWindowShareAddToLocalRendererNative(IntPtr w, IntPtr renderer);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualWindowShareAddToRemoteRendererNative(IntPtr w, IntPtr remoteRenderer);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoVirtualWindowShareClearConstraintsNative(IntPtr w);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoVirtualWindowShareConstructNative(IntPtr id, IntPtr windowName, IntPtr applicationName, StartCallback onStart, ReconfigureCallback onReconfigure, StopCallback onStop);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoVirtualWindowShareConstructCopyNative(IntPtr other);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoVirtualWindowShareDestructNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoVirtualWindowShareGetApplicationNameNative(IntPtr w);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoVirtualWindowShareGetIdNative(IntPtr w);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoVirtualWindowShareGetNameNative(IntPtr w);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoVirtualWindowShareGetPreviewLabelNative(IntPtr w);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualWindowShareGetStatsNative(IntPtr windowShare, IntPtr stats);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoVirtualWindowShareGetUserDataNative(IntPtr w);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoVirtualWindowShareOnFrameNative(IntPtr w, IntPtr videoFrame, [MarshalAs(UnmanagedType.I4)]MediaFormat mediaFormat);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualWindowShareRemoveFromLocalRendererNative(IntPtr w, IntPtr renderer);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualWindowShareRemoveFromRemoteRendererNative(IntPtr w, IntPtr remoteRenderer);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualWindowShareSetBoundsConstraintsNative(IntPtr w, ulong maxFrameInterval, ulong minFrameInterval, uint maxWidth, uint minWidth, uint maxHeight, uint minHeight);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualWindowShareSetDiscreteConstraintsNative(IntPtr w, ulong maxFrameInterval, ulong minFrameInterval, uint width, uint height, double scaleFactor);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualWindowShareSetFrameIntervalNative(IntPtr w, ulong frameInterval);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualWindowShareSetLowLatencyProfileNative(IntPtr w, Boolean profile);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualWindowShareSetPositionInLocalRendererNative(IntPtr w, IntPtr localRenderer, int x, int y, uint width, uint height, ulong frameInterval);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualWindowShareSetPreviewLabelNative(IntPtr w, IntPtr previewLabel);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoVirtualWindowShareSetScaleFactorNative(IntPtr w, double scaleFactor);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoVirtualWindowShareSetUserDataNative(IntPtr obj, IntPtr userData);

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void ReconfigureCallback(IntPtr w, ulong frameInterval, MediaFormat mediaFormat, ulong userData);
		private static ReconfigureCallback _mReconfigureCallback;
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void StartCallback(IntPtr w, ulong frameInterval, MediaFormat mediaFormat, ulong userData);
		private static StartCallback _mStartCallback;
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		private delegate void StopCallback(IntPtr c, ulong userData);
		private static StopCallback _mStopCallback;
		public enum VirtualWindowShareState{
			VirtualwindowsharestateOk,
			VirtualwindowsharestateNotVisible,
			VirtualwindowsharestateMinimized,
			VirtualwindowsharestateClosed,
			VirtualwindowsharestateMiscError
		}
		public interface IConstruct{

			void StartCallback(ulong frameInterval, MediaFormat mediaFormat, ulong userData);
			void ReconfigureCallback(ulong frameInterval, MediaFormat mediaFormat, ulong userData);
			void StopCallback(ulong userData);
		}
		private static IConstruct _mIConstruct;
		public VirtualWindowShare(String id, String windowName, String applicationName, IConstruct _iIConstruct){
			_mIConstruct = _iIConstruct;

			IntPtr nId = MarshalPtrToUtf8.GetInstance().MarshalManagedToNative(id ?? string.Empty);
			IntPtr nWindowName = MarshalPtrToUtf8.GetInstance().MarshalManagedToNative(windowName ?? string.Empty);
			IntPtr nApplicationName = MarshalPtrToUtf8.GetInstance().MarshalManagedToNative(applicationName ?? string.Empty);
			objPtr = VidyoVirtualWindowShareConstructNative(nId, nWindowName, nApplicationName, _mStartCallback, _mReconfigureCallback, _mStopCallback);
			Marshal.FreeHGlobal(nApplicationName);
			Marshal.FreeHGlobal(nWindowName);
			Marshal.FreeHGlobal(nId);
			VidyoVirtualWindowShareSetUserDataNative(objPtr, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Weak)));
		}
		public VirtualWindowShare(IntPtr other){
			objPtr = VidyoVirtualWindowShareConstructCopyNative(other);
			VidyoVirtualWindowShareSetUserDataNative(objPtr, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Weak)));
		}
		~VirtualWindowShare(){
			if(objPtr != IntPtr.Zero){
				VidyoVirtualWindowShareSetUserDataNative(objPtr, IntPtr.Zero);
				VidyoVirtualWindowShareDestructNative(objPtr);
			}
		}
		public ulong AddToLocalRenderer(LocalRenderer renderer){

			ulong ret = VidyoVirtualWindowShareAddToLocalRendererNative(objPtr, (renderer != null) ? renderer.GetObjectPtr():IntPtr.Zero);

			return ret;
		}
		public Boolean AddToRemoteRenderer(RemoteRenderer remoteRenderer){

			Boolean ret = VidyoVirtualWindowShareAddToRemoteRendererNative(objPtr, (remoteRenderer != null) ? remoteRenderer.GetObjectPtr():IntPtr.Zero);

			return ret;
		}
		public void ClearConstraints(){

			VidyoVirtualWindowShareClearConstraintsNative(objPtr);
		}
		public String GetApplicationName(){

			IntPtr ret = VidyoVirtualWindowShareGetApplicationNameNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public String GetId(){

			IntPtr ret = VidyoVirtualWindowShareGetIdNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public String GetName(){

			IntPtr ret = VidyoVirtualWindowShareGetNameNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public String GetPreviewLabel(){

			IntPtr ret = VidyoVirtualWindowShareGetPreviewLabelNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public Boolean GetStats(LocalVideoSourceStats stats){

			Boolean ret = VidyoVirtualWindowShareGetStatsNative(objPtr, (stats != null) ? stats.GetObjectPtr():IntPtr.Zero);

			return ret;
		}
		public ulong GetUserData(){

			ulong ret = VidyoVirtualWindowShareGetUserDataNative(objPtr);

			return ret;
		}
		public void OnFrame(VideoFrame videoFrame, MediaFormat mediaFormat){

			VidyoVirtualWindowShareOnFrameNative(objPtr, (videoFrame != null) ? videoFrame.GetObjectPtr():IntPtr.Zero, mediaFormat);
		}
		public Boolean RemoveFromLocalRenderer(LocalRenderer renderer){

			Boolean ret = VidyoVirtualWindowShareRemoveFromLocalRendererNative(objPtr, (renderer != null) ? renderer.GetObjectPtr():IntPtr.Zero);

			return ret;
		}
		public Boolean RemoveFromRemoteRenderer(RemoteRenderer remoteRenderer){

			Boolean ret = VidyoVirtualWindowShareRemoveFromRemoteRendererNative(objPtr, (remoteRenderer != null) ? remoteRenderer.GetObjectPtr():IntPtr.Zero);

			return ret;
		}
		public Boolean SetBoundsConstraints(ulong maxFrameInterval, ulong minFrameInterval, uint maxWidth, uint minWidth, uint maxHeight, uint minHeight){

			Boolean ret = VidyoVirtualWindowShareSetBoundsConstraintsNative(objPtr, maxFrameInterval, minFrameInterval, maxWidth, minWidth, maxHeight, minHeight);

			return ret;
		}
		public Boolean SetDiscreteConstraints(ulong maxFrameInterval, ulong minFrameInterval, uint width, uint height, double scaleFactor){

			Boolean ret = VidyoVirtualWindowShareSetDiscreteConstraintsNative(objPtr, maxFrameInterval, minFrameInterval, width, height, scaleFactor);

			return ret;
		}
		public Boolean SetFrameInterval(ulong frameInterval){

			Boolean ret = VidyoVirtualWindowShareSetFrameIntervalNative(objPtr, frameInterval);

			return ret;
		}
		public Boolean SetLowLatencyProfile(Boolean profile){

			Boolean ret = VidyoVirtualWindowShareSetLowLatencyProfileNative(objPtr, profile);

			return ret;
		}
		public Boolean SetPositionInLocalRenderer(LocalRenderer localRenderer, int x, int y, uint width, uint height, ulong frameInterval){

			Boolean ret = VidyoVirtualWindowShareSetPositionInLocalRendererNative(objPtr, (localRenderer != null) ? localRenderer.GetObjectPtr():IntPtr.Zero, x, y, width, height, frameInterval);

			return ret;
		}
		public Boolean SetPreviewLabel(String previewLabel){

			IntPtr nPreviewLabel = MarshalPtrToUtf8.GetInstance().MarshalManagedToNative(previewLabel ?? string.Empty);
			Boolean ret = VidyoVirtualWindowShareSetPreviewLabelNative(objPtr, nPreviewLabel);
			Marshal.FreeHGlobal(nPreviewLabel);

			return ret;
		}
		public Boolean SetScaleFactor(double scaleFactor){

			Boolean ret = VidyoVirtualWindowShareSetScaleFactorNative(objPtr, scaleFactor);

			return ret;
		}
#if __IOS__
[ObjCRuntime.MonoPInvokeCallback(typeof(ReconfigureCallback))]
#endif
		private static void ReconfigureCallbackDelegate(IntPtr w, ulong frameInterval, MediaFormat mediaFormat, ulong userData){
			if(_mIConstruct != null)
				_mIConstruct.ReconfigureCallback(frameInterval, mediaFormat, userData);
		}
#if __IOS__
[ObjCRuntime.MonoPInvokeCallback(typeof(StartCallback))]
#endif
		private static void StartCallbackDelegate(IntPtr w, ulong frameInterval, MediaFormat mediaFormat, ulong userData){
			if(_mIConstruct != null)
				_mIConstruct.StartCallback(frameInterval, mediaFormat, userData);
		}
#if __IOS__
[ObjCRuntime.MonoPInvokeCallback(typeof(StopCallback))]
#endif
		private static void StopCallbackDelegate(IntPtr c, ulong userData){
			if(_mIConstruct != null)
				_mIConstruct.StopCallback(userData);
		}
	};
}
