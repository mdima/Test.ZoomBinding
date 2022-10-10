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
	public unsafe static partial class MobileRTCMeetingService_Video  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingService");
		[Export ("askUserStartVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AskUserStartVideo (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("askUserStartVideo:"), (UIntPtr) userID);
		}
		[Export ("canUnmuteMyVideo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanUnmuteMyVideo (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canUnmuteMyVideo"));
		}
		[Export ("getUserVideoSize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static CGSize GetUserVideoSize (this MobileRTCMeetingService This, nuint userID)
		{
			CGSize ret;
			if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
				ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("getUserVideoSize:"), (UIntPtr) userID);
			} else if (IntPtr.Size == 8) {
				ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("getUserVideoSize:"), (UIntPtr) userID);
			} else if (Runtime.Arch == Arch.DEVICE) {
				global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret_UIntPtr (out ret, This.Handle, Selector.GetHandle ("getUserVideoSize:"), (UIntPtr) userID);
			} else {
				ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("getUserVideoSize:"), (UIntPtr) userID);
			}
			return ret!;
		}
		[Export ("isBackCamera")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsBackCamera (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isBackCamera"));
		}
		[Export ("isFollowHostVideoOrderOn")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsFollowHostVideoOrderOn (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isFollowHostVideoOrderOn"));
		}
		[Export ("isSendingMyVideo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsSendingMyVideo (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSendingMyVideo"));
		}
		[Export ("isSupportFollowHostVideoOrder")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsSupportFollowHostVideoOrder (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSupportFollowHostVideoOrder"));
		}
		[Export ("isUserPinned:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsUserPinned (this MobileRTCMeetingService This, nuint userId)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("isUserPinned:"), (UIntPtr) userId);
		}
		[Export ("isUserSpotlighted:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsUserSpotlighted (this MobileRTCMeetingService This, nuint userId)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("isUserSpotlighted:"), (UIntPtr) userId);
		}
		[Export ("isUserVideoSending:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsUserVideoSending (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("isUserVideoSending:"), (UIntPtr) userID);
		}
		[Export ("muteMyVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCVideoError MuteMyVideo (this MobileRTCMeetingService This, bool mute)
		{
			MobileRTCVideoError ret;
			ret = (Zoomios.MobileRTCVideoError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_bool (This.Handle, Selector.GetHandle ("muteMyVideo:"), mute);
			return ret!;
		}
		[Export ("pinVideo:withUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PinVideo (this MobileRTCMeetingService This, bool on, nuint userId)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool_UIntPtr (This.Handle, Selector.GetHandle ("pinVideo:withUser:"), on, (UIntPtr) userId);
		}
		[Export ("rotateMyVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool RotateMyVideo (this MobileRTCMeetingService This, global::UIKit.UIDeviceOrientation rotation)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("rotateMyVideo:"), (IntPtr) (long) rotation);
		}
		[Export ("getSpotLightedVideoUserList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber[] SpotLightedVideoUserList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getSpotLightedVideoUserList")))!;
		}
		[Export ("spotlightVideo:withUser:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SpotlightVideo (this MobileRTCMeetingService This, bool on, nuint userId)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool_UIntPtr (This.Handle, Selector.GetHandle ("spotlightVideo:withUser:"), on, (UIntPtr) userId);
		}
		[Export ("stopUserVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool StopUserVideo (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("stopUserVideo:"), (UIntPtr) userID);
		}
		[Export ("switchMyCamera")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCCameraError SwitchMyCamera (this MobileRTCMeetingService This)
		{
			MobileRTCCameraError ret;
			ret = (Zoomios.MobileRTCCameraError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("switchMyCamera"));
			return ret!;
		}
		[Export ("unSpotlightAllVideos")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool UnSpotlightAllVideos (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("unSpotlightAllVideos"));
		}
		[Export ("getVideoOrderList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSNumber[] VideoOrderList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getVideoOrderList")))!;
		}
	} /* class MobileRTCMeetingService_Video */
}
