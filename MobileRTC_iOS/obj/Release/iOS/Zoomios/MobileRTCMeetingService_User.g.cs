//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace Zoomios {
	public unsafe static partial class MobileRTCMeetingService_User  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingService");
		[Export ("activeShareUserID")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint ActiveShareUserID (this MobileRTCMeetingService This)
		{
			return (nuint) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("activeShareUserID"));
		}
		[Export ("activeUserID")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint ActiveUserID (this MobileRTCMeetingService This)
		{
			return (nuint) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("activeUserID"));
		}
		[Export ("assignCohost:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AssignCohost (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("assignCohost:"), (UIntPtr) userID);
		}
		[Export ("attendeeInfoByID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetingWebinarAttendeeInfo? AttendeeInfoByID (this MobileRTCMeetingService This, nuint userId)
		{
			return  Runtime.GetNSObject<MobileRTCMeetingWebinarAttendeeInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("attendeeInfoByID:"), (UIntPtr) userId))!;
		}
		[Export ("canBeCoHost:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanBeCoHost (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("canBeCoHost:"), (UIntPtr) userID);
		}
		[Export ("canClaimhost")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanClaimhost (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canClaimhost"));
		}
		[Export ("changeName:withUserID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ChangeName (this MobileRTCMeetingService This, string inputName, nuint userId)
		{
			if (inputName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inputName));
			var nsinputName = CFString.CreateNative (inputName);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("changeName:withUserID:"), nsinputName, (UIntPtr) userId);
			CFString.ReleaseNative (nsinputName);
			return ret!;
		}
		[Export ("claimHostWithHostKey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ClaimHostWithHostKey (this MobileRTCMeetingService This, string hostKey)
		{
			if (hostKey is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (hostKey));
			var nshostKey = CFString.CreateNative (hostKey);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("claimHostWithHostKey:"), nshostKey);
			CFString.ReleaseNative (nshostKey);
			return ret!;
		}
		[Export ("getInMeetingUserList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber[] InMeetingUserList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getInMeetingUserList")))!;
		}
		[Export ("isH323User:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsH323User (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("isH323User:"), (UIntPtr) userID);
		}
		[Export ("isHostUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsHostUser (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("isHostUser:"), (UIntPtr) userID);
		}
		[Export ("isMyself:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMyself (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("isMyself:"), (UIntPtr) userID);
		}
		[Export ("isSameUser:compareTo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsSameUser (this MobileRTCMeetingService This, nuint user1, nuint user2)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("isSameUser:compareTo:"), (UIntPtr) user1, (UIntPtr) user2);
		}
		[Export ("lowerAllHand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool LowerAllHand (this MobileRTCMeetingService This, bool isWebinarAttendee)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("lowerAllHand:"), isWebinarAttendee);
		}
		[Export ("lowerHand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool LowerHand (this MobileRTCMeetingService This, nuint userId)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("lowerHand:"), (UIntPtr) userId);
		}
		[Export ("makeHost:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool MakeHost (this MobileRTCMeetingService This, nuint userId)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("makeHost:"), (UIntPtr) userId);
		}
		[Export ("myselfUserID")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint MyselfUserID (this MobileRTCMeetingService This)
		{
			return (nuint) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("myselfUserID"));
		}
		[Export ("raiseMyHand")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool RaiseMyHand (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("raiseMyHand"));
		}
		[Export ("reclaimHost")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ReclaimHost (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("reclaimHost"));
		}
		[Export ("removeUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool RemoveUser (this MobileRTCMeetingService This, nuint userId)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("removeUser:"), (UIntPtr) userId);
		}
		[Export ("revokeCoHost:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool RevokeCoHost (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("revokeCoHost:"), (UIntPtr) userID);
		}
		[Export ("userInfoByID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetingUserInfo? UserInfoByID (this MobileRTCMeetingService This, nuint userId)
		{
			return  Runtime.GetNSObject<MobileRTCMeetingUserInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("userInfoByID:"), (UIntPtr) userId))!;
		}
		[Export ("getWebinarAttendeeList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber[] WebinarAttendeeList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getWebinarAttendeeList")))!;
		}
	} /* class MobileRTCMeetingService_User */
}
