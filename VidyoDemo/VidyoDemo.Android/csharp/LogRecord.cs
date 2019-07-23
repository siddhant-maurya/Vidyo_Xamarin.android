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
	public class LogRecord{
#if __IOS__
		const string importLib = "__Internal";
#else
		const string importLib = "libVidyoClient";
#endif
		private IntPtr objPtr; // opaque VidyoLogRecord reference.
		public IntPtr GetObjectPtr(){
			return objPtr;
		}
		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLogRecordGetcategoryNameNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern ulong VidyoLogRecordGeteventTimeNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLogRecordGetfileNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLogRecordGetfunctionNameNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.I4)]
		private static extern LogLevel VidyoLogRecordGetlevelNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern int VidyoLogRecordGetlineNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLogRecordGetmessageNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLogRecordGetnameNative(IntPtr obj);

		[DllImport(importLib, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr VidyoLogRecordGetthreadNameNative(IntPtr obj);

		public enum LogLevel{
			LoglevelFATAL,
			LoglevelERROR,
			LoglevelWARNING,
			LoglevelINFO,
			LoglevelDEBUG,
			LoglevelSENT,
			LoglevelRECEIVED,
			LoglevelENTER,
			LoglevelLEAVE,
			LoglevelINVALID
		}
		public ulong categoryName;
		public ulong eventTime;
		public String file;
		public String functionName;
		public LogLevel level;
		public int line;
		public String message;
		public String name;
		public String threadName;
		public LogRecord(IntPtr obj){
			objPtr = obj;

			categoryName = VidyoLogRecordGetcategoryNameNative(objPtr);
			eventTime = VidyoLogRecordGeteventTimeNative(objPtr);
			file = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoLogRecordGetfileNative(objPtr));
			functionName = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoLogRecordGetfunctionNameNative(objPtr));
			level = VidyoLogRecordGetlevelNative(objPtr);
			line = VidyoLogRecordGetlineNative(objPtr);
			message = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoLogRecordGetmessageNative(objPtr));
			name = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoLogRecordGetnameNative(objPtr));
			threadName = (string)MarshalPtrToUtf8.GetInstance().MarshalNativeToManaged(VidyoLogRecordGetthreadNameNative(objPtr));
		}
	};
}