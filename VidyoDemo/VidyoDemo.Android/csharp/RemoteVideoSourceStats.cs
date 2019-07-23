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
	public class RemoteVideoSourceStats{
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		private IntPtr objPtr; // opaque VidyoRemoteVideoSourceStats reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetcodecFirNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetcodecIFramesNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetcodecLayersNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetcodecNacksNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteVideoSourceStatsGetcodecNameNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetfpsDecodedNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetfpsDecoderInputNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetfpsRenderedNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetheightNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteVideoSourceStatsGetidNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern int VidyoRemoteVideoSourceStatsGetlastFrameMsNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteVideoSourceStatsGetlocalRendererStreamsNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteVideoSourceStatsGetlocalRendererStreamsArrayNative(IntPtr obj, ref int size);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoRemoteVideoSourceStatsFreelocalRendererStreamsArrayNative(IntPtr obj, int size);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoRemoteVideoSourceStatsGetmaxStreamFrameRateNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetmaxStreamHeightNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetmaxStreamWidthNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteVideoSourceStatsGetnameNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetreceiveNetworkBitRateNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetreceiveNetworkPacketsConcealedNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetreceiveNetworkPacketsLostNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetreceiveNetworkPacketsReorderedNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetreceiveNetworkRecoveredWithFecNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoRemoteVideoSourceStatsGetshowFrameRateNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetshowHeightNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetshowPixelRateNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoRemoteVideoSourceStatsGetshowStateNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetshowWidthNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern int VidyoRemoteVideoSourceStatsGetvideoDeltaFromAudioMsNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoRemoteVideoSourceStatsGetwidthNative(IntPtr obj);

		public ulong codecFir;
		public ulong codecIFrames;
		public ulong codecLayers;
		public ulong codecNacks;
		public String codecName;
		public ulong fpsDecoded;
		public ulong fpsDecoderInput;
		public ulong fpsRendered;
		public ulong height;
		public String id;
		public int lastFrameMs;
		public List<LocalRendererStreamStats> localRendererStreams;
		public uint maxStreamFrameRate;
		public ulong maxStreamHeight;
		public ulong maxStreamWidth;
		public String name;
		public ulong receiveNetworkBitRate;
		public ulong receiveNetworkPacketsConcealed;
		public ulong receiveNetworkPacketsLost;
		public ulong receiveNetworkPacketsReordered;
		public ulong receiveNetworkRecoveredWithFec;
		public uint showFrameRate;
		public ulong showHeight;
		public ulong showPixelRate;
		public String showState;
		public ulong showWidth;
		public int videoDeltaFromAudioMs;
		public ulong width;
		public RemoteVideoSourceStats(IntPtr obj){
			objPtr = obj;

			List<LocalRendererStreamStats> csLocalRendererStreams = new List<LocalRendererStreamStats>();
			int nLocalRendererStreamsSize = 0;
			IntPtr nLocalRendererStreams = VidyoRemoteVideoSourceStatsGetlocalRendererStreamsArrayNative(VidyoRemoteVideoSourceStatsGetlocalRendererStreamsNative(objPtr), ref nLocalRendererStreamsSize);
			int nLocalRendererStreamsIndex = 0;
			while (nLocalRendererStreamsIndex < nLocalRendererStreamsSize) {
				LocalRendererStreamStats csTlocalRendererStreams = new LocalRendererStreamStats(Marshal.ReadIntPtr(nLocalRendererStreams + (nLocalRendererStreamsIndex * Marshal.SizeOf(nLocalRendererStreams))));
				csLocalRendererStreams.Add(csTlocalRendererStreams);
				nLocalRendererStreamsIndex++;
			}

			codecFir = VidyoRemoteVideoSourceStatsGetcodecFirNative(objPtr);
			codecIFrames = VidyoRemoteVideoSourceStatsGetcodecIFramesNative(objPtr);
			codecLayers = VidyoRemoteVideoSourceStatsGetcodecLayersNative(objPtr);
			codecNacks = VidyoRemoteVideoSourceStatsGetcodecNacksNative(objPtr);
			codecName = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoRemoteVideoSourceStatsGetcodecNameNative(objPtr));
			fpsDecoded = VidyoRemoteVideoSourceStatsGetfpsDecodedNative(objPtr);
			fpsDecoderInput = VidyoRemoteVideoSourceStatsGetfpsDecoderInputNative(objPtr);
			fpsRendered = VidyoRemoteVideoSourceStatsGetfpsRenderedNative(objPtr);
			height = VidyoRemoteVideoSourceStatsGetheightNative(objPtr);
			id = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoRemoteVideoSourceStatsGetidNative(objPtr));
			lastFrameMs = VidyoRemoteVideoSourceStatsGetlastFrameMsNative(objPtr);
			localRendererStreams = csLocalRendererStreams;
			maxStreamFrameRate = VidyoRemoteVideoSourceStatsGetmaxStreamFrameRateNative(objPtr);
			maxStreamHeight = VidyoRemoteVideoSourceStatsGetmaxStreamHeightNative(objPtr);
			maxStreamWidth = VidyoRemoteVideoSourceStatsGetmaxStreamWidthNative(objPtr);
			name = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoRemoteVideoSourceStatsGetnameNative(objPtr));
			receiveNetworkBitRate = VidyoRemoteVideoSourceStatsGetreceiveNetworkBitRateNative(objPtr);
			receiveNetworkPacketsConcealed = VidyoRemoteVideoSourceStatsGetreceiveNetworkPacketsConcealedNative(objPtr);
			receiveNetworkPacketsLost = VidyoRemoteVideoSourceStatsGetreceiveNetworkPacketsLostNative(objPtr);
			receiveNetworkPacketsReordered = VidyoRemoteVideoSourceStatsGetreceiveNetworkPacketsReorderedNative(objPtr);
			receiveNetworkRecoveredWithFec = VidyoRemoteVideoSourceStatsGetreceiveNetworkRecoveredWithFecNative(objPtr);
			showFrameRate = VidyoRemoteVideoSourceStatsGetshowFrameRateNative(objPtr);
			showHeight = VidyoRemoteVideoSourceStatsGetshowHeightNative(objPtr);
			showPixelRate = VidyoRemoteVideoSourceStatsGetshowPixelRateNative(objPtr);
			showState = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoRemoteVideoSourceStatsGetshowStateNative(objPtr));
			showWidth = VidyoRemoteVideoSourceStatsGetshowWidthNative(objPtr);
			videoDeltaFromAudioMs = VidyoRemoteVideoSourceStatsGetvideoDeltaFromAudioMsNative(objPtr);
			width = VidyoRemoteVideoSourceStatsGetwidthNative(objPtr);
			VidyoRemoteVideoSourceStatsFreelocalRendererStreamsArrayNative(nLocalRendererStreams, nLocalRendererStreamsSize);
		}
	};
}
