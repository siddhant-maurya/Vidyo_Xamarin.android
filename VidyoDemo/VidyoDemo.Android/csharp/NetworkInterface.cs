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
	public class NetworkInterface{
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		private IntPtr objPtr; // opaque VidyoNetworkInterface reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoNetworkInterfaceConstructCopyNative(IntPtr s);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoNetworkInterfaceDestructNative(IntPtr n);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoNetworkInterfaceGetAddressNative(IntPtr n);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern NetworkInterfaceFamily VidyoNetworkInterfaceGetFamilyNative(IntPtr n);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoNetworkInterfaceGetNameNative(IntPtr n);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern NetworkInterfaceState VidyoNetworkInterfaceGetStateNative(IntPtr n);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern NetworkInterfaceType VidyoNetworkInterfaceGetTypeNative(IntPtr n);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoNetworkInterfaceGetUserDataNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoNetworkInterfaceSetUserDataNative(IntPtr obj, IntPtr userData);

		public enum NetworkInterfaceFamily{
			NetworkinterfacefamilyUnspecified,
			NetworkinterfacefamilyIPV4,
			NetworkinterfacefamilyIPV6
		}
		public enum NetworkInterfaceState{
			NetworkinterfacestateUnknown,
			NetworkinterfacestateUp,
			NetworkinterfacestateDown
		}
		public enum NetworkInterfaceTransportType{
			NetworkinterfacetransporttypeSignaling,
			NetworkinterfacetransporttypeMedia,
			NetworkinterfacetransporttypeData
		}
		public enum NetworkInterfaceType{
			NetworkinterfacetypeWired,
			NetworkinterfacetypeWiFi,
			NetworkinterfacetypeWwan,
			NetworkinterfacetypeLoopback,
			NetworkinterfacetypeTunneled,
			NetworkinterfacetypeOther,
			NetworkinterfacetypeNotApplicable
		}
		public NetworkInterface(IntPtr s){
			objPtr = VidyoNetworkInterfaceConstructCopyNative(s);
			VidyoNetworkInterfaceSetUserDataNative(objPtr, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Weak)));
		}
		~NetworkInterface(){
			if(objPtr != IntPtr.Zero){
				VidyoNetworkInterfaceSetUserDataNative(objPtr, IntPtr.Zero);
				VidyoNetworkInterfaceDestructNative(objPtr);
			}
		}
		public String GetAddress(){

			IntPtr ret = VidyoNetworkInterfaceGetAddressNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public NetworkInterfaceFamily GetFamily(){

			NetworkInterfaceFamily ret = VidyoNetworkInterfaceGetFamilyNative(objPtr);

			return ret;
		}
		public String GetName(){

			IntPtr ret = VidyoNetworkInterfaceGetNameNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public NetworkInterfaceState GetState(){

			NetworkInterfaceState ret = VidyoNetworkInterfaceGetStateNative(objPtr);

			return ret;
		}
		public NetworkInterfaceType GetType(){

			NetworkInterfaceType ret = VidyoNetworkInterfaceGetTypeNative(objPtr);

			return ret;
		}
	};
}