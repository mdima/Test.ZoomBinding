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
	public unsafe static partial class MobileRTCMeetingService_Audio  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingService");
		[Export ("askAllToUnmute")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AskAllToUnmute (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("askAllToUnmute"));
		}
		[Export ("canUnmuteMyAudio")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanUnmuteMyAudio (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canUnmuteMyAudio"));
		}
		[Export ("connectMyAudio:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ConnectMyAudio (this MobileRTCMeetingService This, bool on)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("connectMyAudio:"), on);
		}
		[Export ("isMuteOnEntryOn")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMuteOnEntryOn (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMuteOnEntryOn"));
		}
		[Export ("isMyAudioMuted")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMyAudioMuted (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMyAudioMuted"));
		}
		[Export ("isPlayChimeOn")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsPlayChimeOn (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isPlayChimeOn"));
		}
		[Export ("isSupportedVOIP")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsSupportedVOIP (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSupportedVOIP"));
		}
		[Export ("isUserAudioMuted:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsUserAudioMuted (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("isUserAudioMuted:"), (UIntPtr) userID);
		}
		[Export ("muteAllUserAudio:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool MuteAllUserAudio (this MobileRTCMeetingService This, bool allowSelfUnmute)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("muteAllUserAudio:"), allowSelfUnmute);
		}
		[Export ("muteMyAudio:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCAudioError MuteMyAudio (this MobileRTCMeetingService This, bool mute)
		{
			MobileRTCAudioError ret;
			ret = (Zoomios.MobileRTCAudioError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_bool (This.Handle, Selector.GetHandle ("muteMyAudio:"), mute);
			return ret!;
		}
		[Export ("muteOnEntry:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool MuteOnEntry (this MobileRTCMeetingService This, bool on)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("muteOnEntry:"), on);
		}
		[Export ("muteUserAudio:withUID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool MuteUserAudio (this MobileRTCMeetingService This, bool mute, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool_UIntPtr (This.Handle, Selector.GetHandle ("muteUserAudio:withUID:"), mute, (UIntPtr) userID);
		}
		[Export ("myAudioOutputDescription")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCAudioOutput MyAudioOutputDescription (this MobileRTCMeetingService This)
		{
			MobileRTCAudioOutput ret;
			ret = (Zoomios.MobileRTCAudioOutput) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("myAudioOutputDescription"));
			return ret!;
		}
		[Export ("myAudioType")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCAudioType MyAudioType (this MobileRTCMeetingService This)
		{
			MobileRTCAudioType ret;
			ret = (Zoomios.MobileRTCAudioType) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("myAudioType"));
			return ret!;
		}
		[Export ("playChime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PlayChime (this MobileRTCMeetingService This, bool on)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("playChime:"), on);
		}
		[Export ("resetMeetingAudioForCallKitHeld")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResetMeetingAudioForCallKitHeld (this MobileRTCMeetingService This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("resetMeetingAudioForCallKitHeld"));
		}
		[Export ("resetMeetingAudioSession")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResetMeetingAudioSession (this MobileRTCMeetingService This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("resetMeetingAudioSession"));
		}
		[Export ("switchMyAudioSource")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCAudioError SwitchMyAudioSource (this MobileRTCMeetingService This)
		{
			MobileRTCAudioError ret;
			ret = (Zoomios.MobileRTCAudioError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("switchMyAudioSource"));
			return ret!;
		}
	} /* class MobileRTCMeetingService_Audio */
}
