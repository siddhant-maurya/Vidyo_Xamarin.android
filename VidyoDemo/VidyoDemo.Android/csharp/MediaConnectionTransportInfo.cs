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
	public class MediaConnectionTransportInfo{
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		private IntPtr objPtr; // opaque VidyoMediaConnectionTransportInfo reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMediaConnectionTransportInfoGetaddressTypeNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMediaConnectionTransportInfoGetcomponentTypeNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern uint VidyoMediaConnectionTransportInfoGetconnectionIdNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMediaConnectionTransportInfoGetconnectionTypeNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMediaConnectionTransportInfoGetexternalLocalAddrNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMediaConnectionTransportInfoGetexternalRemoteAddrNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMediaConnectionTransportInfoGetinterfaceNameNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMediaConnectionTransportInfoGetinterfaceTypeNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMediaConnectionTransportInfoGetinternalLocalAddrNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMediaConnectionTransportInfoGetinternalRemoteAddrNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMediaConnectionTransportInfoGettransportPlugInNative(IntPtr obj);

		public String addressType;
		public String componentType;
		public uint connectionId;
		public String connectionType;
		public String externalLocalAddr;
		public String externalRemoteAddr;
		public String interfaceName;
		public String interfaceType;
		public String internalLocalAddr;
		public String internalRemoteAddr;
		public String transportPlugIn;
		public MediaConnectionTransportInfo(IntPtr obj){
			objPtr = obj;

			addressType = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoMediaConnectionTransportInfoGetaddressTypeNative(objPtr));
			componentType = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoMediaConnectionTransportInfoGetcomponentTypeNative(objPtr));
			connectionId = VidyoMediaConnectionTransportInfoGetconnectionIdNative(objPtr);
			connectionType = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoMediaConnectionTransportInfoGetconnectionTypeNative(objPtr));
			externalLocalAddr = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoMediaConnectionTransportInfoGetexternalLocalAddrNative(objPtr));
			externalRemoteAddr = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoMediaConnectionTransportInfoGetexternalRemoteAddrNative(objPtr));
			interfaceName = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoMediaConnectionTransportInfoGetinterfaceNameNative(objPtr));
			interfaceType = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoMediaConnectionTransportInfoGetinterfaceTypeNative(objPtr));
			internalLocalAddr = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoMediaConnectionTransportInfoGetinternalLocalAddrNative(objPtr));
			internalRemoteAddr = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoMediaConnectionTransportInfoGetinternalRemoteAddrNative(objPtr));
			transportPlugIn = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoMediaConnectionTransportInfoGettransportPlugInNative(objPtr));
		}
	};
}
