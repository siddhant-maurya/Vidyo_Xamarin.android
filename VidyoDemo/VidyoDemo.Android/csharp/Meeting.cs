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
	public class Meeting{
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		private IntPtr objPtr; // opaque VidyoMeeting reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingConstructCopyNative(IntPtr other);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern void VidyoMeetingDestructNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoMeetingGetAttendeesNative(IntPtr m, uint index, uint pageSize);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetBodyNative(IntPtr m);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetEndDateTimeNative(IntPtr m);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetIdNative(IntPtr m);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern Boolean VidyoMeetingGetIsVidyoMeetingNative(IntPtr m);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetLocationNative(IntPtr m);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern int VidyoMeetingGetNumberOfAttendeesNative(IntPtr m);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetOwnerEmailNative(IntPtr m);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetOwnerNameNative(IntPtr m);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetStartDateTimeNative(IntPtr m);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetSubjectNative(IntPtr m);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingGetVidyoMeetingRoomLinkNative(IntPtr m);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoMeetingRetrieveBodyNative(IntPtr m);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern IntPtr VidyoMeetingGetUserDataNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		public static extern void VidyoMeetingSetUserDataNative(IntPtr obj, IntPtr userData);

		public Meeting(IntPtr other){
			objPtr = VidyoMeetingConstructCopyNative(other);
			VidyoMeetingSetUserDataNative(objPtr, GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Weak)));
		}
		~Meeting(){
			if(objPtr != IntPtr.Zero){
				VidyoMeetingSetUserDataNative(objPtr, IntPtr.Zero);
				VidyoMeetingDestructNative(objPtr);
			}
		}
		public Boolean GetAttendees(uint index, uint pageSize){

			Boolean ret = VidyoMeetingGetAttendeesNative(objPtr, index, pageSize);

			return ret;
		}
		public String GetBody(){

			IntPtr ret = VidyoMeetingGetBodyNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public String GetEndDateTime(){

			IntPtr ret = VidyoMeetingGetEndDateTimeNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public String GetId(){

			IntPtr ret = VidyoMeetingGetIdNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public Boolean GetIsVidyoMeeting(){

			Boolean ret = VidyoMeetingGetIsVidyoMeetingNative(objPtr);

			return ret;
		}
		public String GetLocation(){

			IntPtr ret = VidyoMeetingGetLocationNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public int GetNumberOfAttendees(){

			int ret = VidyoMeetingGetNumberOfAttendeesNative(objPtr);

			return ret;
		}
		public String GetOwnerEmail(){

			IntPtr ret = VidyoMeetingGetOwnerEmailNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public String GetOwnerName(){

			IntPtr ret = VidyoMeetingGetOwnerNameNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public String GetStartDateTime(){

			IntPtr ret = VidyoMeetingGetStartDateTimeNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public String GetSubject(){

			IntPtr ret = VidyoMeetingGetSubjectNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public String GetVidyoMeetingRoomLink(){

			IntPtr ret = VidyoMeetingGetVidyoMeetingRoomLinkNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
		public String RetrieveBody(){

			IntPtr ret = VidyoMeetingRetrieveBodyNative(objPtr);

			return (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(ret);
		}
	};
}
