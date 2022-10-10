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
	public unsafe static partial class MobileRTCMeetingService_InMeeting  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingService");
		[Export ("allowParticipantsToRename:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AllowParticipantsToRename (this MobileRTCMeetingService This, bool allow)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("allowParticipantsToRename:"), allow);
		}
		[Export ("allowParticipantsToUnmuteSelf:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void AllowParticipantsToUnmuteSelf (this MobileRTCMeetingService This, bool allow)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("allowParticipantsToUnmuteSelf:"), allow);
		}
		[Export ("backZoomUIMeetingFromMinimizeMeeting")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool BackZoomUIMeetingFromMinimizeMeeting (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("backZoomUIMeetingFromMinimizeMeeting"));
		}
		[Export ("getCloudRecordingStatus")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCRecordingStatus CloudRecordingStatus (this MobileRTCMeetingService This)
		{
			MobileRTCRecordingStatus ret;
			ret = (Zoomios.MobileRTCRecordingStatus) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getCloudRecordingStatus"));
			return ret!;
		}
		[Export ("configDSCPWithAudioValue:VideoValue:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ConfigDSCPWithAudioValue (this MobileRTCMeetingService This, nuint audioValue, nuint videoValue)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("configDSCPWithAudioValue:VideoValue:"), (UIntPtr) audioValue, (UIntPtr) videoValue);
		}
		[Export ("hideAANPanel")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCANNError HideAANPanel (this MobileRTCMeetingService This)
		{
			MobileRTCANNError ret;
			ret = (Zoomios.MobileRTCANNError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("hideAANPanel"));
			return ret!;
		}
		[Export ("hideMobileRTCMeeting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool HideMobileRTCMeeting (this MobileRTCMeetingService This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("hideMobileRTCMeeting:"), (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			return ret!;
		}
		[Export ("isCMREnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsCMREnabled (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isCMREnabled"));
		}
		[Export ("isCMRInProgress")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsCMRInProgress (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isCMRInProgress"));
		}
		[Export ("isCMRPaused")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsCMRPaused (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isCMRPaused"));
		}
		[Export ("isFailoverMeeting")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsFailoverMeeting (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isFailoverMeeting"));
		}
		[Export ("isLiveTranscriptLegalNoticeAvailable")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsLiveTranscriptLegalNoticeAvailable (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isLiveTranscriptLegalNoticeAvailable"));
		}
		[Export ("isMeetingCoHost")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMeetingCoHost (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMeetingCoHost"));
		}
		[Export ("isMeetingHost")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMeetingHost (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMeetingHost"));
		}
		[Export ("isMeetingLocked")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMeetingLocked (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMeetingLocked"));
		}
		[Export ("isParticipantsRenameAllowed")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsParticipantsRenameAllowed (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isParticipantsRenameAllowed"));
		}
		[Export ("isParticipantsUnmuteSelfAllowed")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsParticipantsUnmuteSelfAllowed (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isParticipantsUnmuteSelfAllowed"));
		}
		[Export ("isQAEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsQAEnabled (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isQAEnabled"));
		}
		[Export ("isShareLocked")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsShareLocked (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isShareLocked"));
		}
		[Export ("isWebinarAttendee")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsWebinarAttendee (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isWebinarAttendee"));
		}
		[Export ("isWebinarMeeting")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsWebinarMeeting (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isWebinarMeeting"));
		}
		[Export ("isWebinarPanelist")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsWebinarPanelist (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isWebinarPanelist"));
		}
		[Export ("getLiveStreamURL")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSDictionary LiveStreamURL (this MobileRTCMeetingService This)
		{
			return  Runtime.GetNSObject<NSDictionary> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getLiveStreamURL")))!;
		}
		[Export ("getLiveTranscriptLegalNoticesExplained")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string LiveTranscriptLegalNoticesExplained (this MobileRTCMeetingService This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getLiveTranscriptLegalNoticesExplained")))!;
		}
		[Export ("getLiveTranscriptLegalNoticesPrompt")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string LiveTranscriptLegalNoticesPrompt (this MobileRTCMeetingService This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getLiveTranscriptLegalNoticesPrompt")))!;
		}
		[Export ("lockMeeting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool LockMeeting (this MobileRTCMeetingService This, bool @lock)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("lockMeeting:"), @lock);
		}
		[Export ("lockShare:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool LockShare (this MobileRTCMeetingService This, bool @lock)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("lockShare:"), @lock);
		}
		[Export ("getMeetingPassword")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string MeetingPassword (this MobileRTCMeetingService This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getMeetingPassword")))!;
		}
		[Export ("getMeetingType")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetingType MeetingType (this MobileRTCMeetingService This)
		{
			MobileRTCMeetingType ret;
			ret = (Zoomios.MobileRTCMeetingType) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getMeetingType"));
			return ret!;
		}
		[Export ("presentMeetingChatViewController:userId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PresentMeetingChatViewController (this MobileRTCMeetingService This, global::UIKit.UIViewController parentVC, nint userId)
		{
			var parentVC__handle__ = parentVC!.GetNonNullHandle (nameof (parentVC));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("presentMeetingChatViewController:userId:"), parentVC__handle__, (IntPtr) userId);
		}
		[Export ("presentParticipantsViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PresentParticipantsViewController (this MobileRTCMeetingService This, global::UIKit.UIViewController parentVC)
		{
			var parentVC__handle__ = parentVC!.GetNonNullHandle (nameof (parentVC));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("presentParticipantsViewController:"), parentVC__handle__);
		}
		[Export ("presentQAViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PresentQAViewController (this MobileRTCMeetingService This, global::UIKit.UIViewController parentVC)
		{
			var parentVC__handle__ = parentVC!.GetNonNullHandle (nameof (parentVC));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("presentQAViewController:"), parentVC__handle__);
		}
		[Export ("queryNetworkQuality:withDataFlow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCNetworkQuality QueryNetworkQuality (this MobileRTCMeetingService This, MobileRTCComponentType type, bool sending)
		{
			MobileRTCNetworkQuality ret;
			ret = (Zoomios.MobileRTCNetworkQuality) (long) global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UIntPtr_bool (This.Handle, Selector.GetHandle ("queryNetworkQuality:withDataFlow:"), (UIntPtr) (ulong) type, sending);
			return ret!;
		}
		[Export ("resumePauseCMR")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ResumePauseCMR (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("resumePauseCMR"));
		}
		[Export ("showAANPanelInView:originPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCANNError ShowAANPanelInView (this MobileRTCMeetingService This, global::UIKit.UIView? containerView, CGPoint originXY)
		{
			var containerView__handle__ = containerView.GetHandle ();
			MobileRTCANNError ret;
			ret = (Zoomios.MobileRTCANNError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_IntPtr_CGPoint (This.Handle, Selector.GetHandle ("showAANPanelInView:originPoint:"), containerView__handle__, originXY);
			return ret!;
		}
		[Export ("showMeetingControlBar")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ShowMeetingControlBar (this MobileRTCMeetingService This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("showMeetingControlBar"));
		}
		[Export ("showMinimizeMeetingFromZoomUIMeeting")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ShowMinimizeMeetingFromZoomUIMeeting (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("showMinimizeMeetingFromZoomUIMeeting"));
		}
		[Export ("showMobileRTCMeeting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static bool ShowMobileRTCMeeting (this MobileRTCMeetingService This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDAction.Handler, completion);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("showMobileRTCMeeting:"), (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			return ret!;
		}
		[Export ("startLiveStreamWithStreamingURL:StreamingKey:BroadcastURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool StartLiveStreamWithStreamingURL (this MobileRTCMeetingService This, string streamingURL, string key, string broadcastURL)
		{
			if (streamingURL is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (streamingURL));
			if (key is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (key));
			if (broadcastURL is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (broadcastURL));
			var nsstreamingURL = CFString.CreateNative (streamingURL);
			var nskey = CFString.CreateNative (key);
			var nsbroadcastURL = CFString.CreateNative (broadcastURL);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("startLiveStreamWithStreamingURL:StreamingKey:BroadcastURL:"), nsstreamingURL, nskey, nsbroadcastURL);
			CFString.ReleaseNative (nsstreamingURL);
			CFString.ReleaseNative (nskey);
			CFString.ReleaseNative (nsbroadcastURL);
			return ret!;
		}
		[Export ("startRawLiveStream:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool StartRawLiveStream (this MobileRTCMeetingService This, string broadcastURL)
		{
			if (broadcastURL is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (broadcastURL));
			var nsbroadcastURL = CFString.CreateNative (broadcastURL);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("startRawLiveStream:"), nsbroadcastURL);
			CFString.ReleaseNative (nsbroadcastURL);
			return ret!;
		}
		[Export ("stopLiveStream")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool StopLiveStream (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("stopLiveStream"));
		}
		[Export ("stopRawLiveStream")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool StopRawLiveStream (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("stopRawLiveStream"));
		}
		[Export ("switchToActiveSpeaker")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SwitchToActiveSpeaker (this MobileRTCMeetingService This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("switchToActiveSpeaker"));
		}
		[Export ("switchToDriveScene")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SwitchToDriveScene (this MobileRTCMeetingService This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("switchToDriveScene"));
		}
		[Export ("switchToVideoWall")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SwitchToVideoWall (this MobileRTCMeetingService This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("switchToVideoWall"));
		}
		[Export ("turnOnCMR:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void TurnOnCMR (this MobileRTCMeetingService This, bool on)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("turnOnCMR:"), on);
		}
	} /* class MobileRTCMeetingService_InMeeting */
}
