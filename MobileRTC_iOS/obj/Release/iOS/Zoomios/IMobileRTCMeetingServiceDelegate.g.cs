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
	[Protocol (Name = "IMobileRTCMeetingServiceDelegate", WrapperType = typeof (IMobileRTCMeetingServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnMeetingError", Selector = "onMeetingError:message:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCMeetError), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnMeetingStateChange", Selector = "onMeetingStateChange:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCMeetingState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnMeetingParameterNotification", Selector = "onMeetingParameterNotification:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCMeetingParameter) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnJoinMeetingConfirmed", Selector = "onJoinMeetingConfirmed")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnMeetingReady", Selector = "onMeetingReady")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnJBHWaitingWithCmd", Selector = "onJBHWaitingWithCmd:", ParameterType = new Type [] { typeof (Zoomios.JBHCmd) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnCheckCMRPrivilege", Selector = "onCheckCMRPrivilege:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCCMRError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnRecordingStatus", Selector = "onRecordingStatus:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCRecordingStatus) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnLocalRecordingStatus", Selector = "onLocalRecordingStatus:status:", ParameterType = new Type [] { typeof (nint), typeof (Zoomios.MobileRTCRecordingStatus) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnMeetingEndedReason", Selector = "onMeetingEndedReason:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCMeetingEndReason) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnNoHostMeetingWillTerminate", Selector = "onNoHostMeetingWillTerminate:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnMicrophoneStatusError", Selector = "onMicrophoneStatusError:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCMicrophoneError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnJoinMeetingInfo", Selector = "onJoinMeetingInfo:completion:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCJoinMeetingInfo), typeof (global::System.Action<NSString, NSString, bool>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDActionArity3V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnProxyAuth", Selector = "onProxyAuth:port:completion:", ParameterType = new Type [] { typeof (string), typeof (nuint), typeof (global::System.Action<NSString, nuint, NSString, NSString, bool>) }, ParameterByRef = new bool [] { false, false, false }, ParameterBlockProxy = new Type? [] { null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity5V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAskToEndOtherMeeting", Selector = "onAskToEndOtherMeeting:", ParameterType = new Type [] { typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnMicrophoneNoPrivilege", Selector = "onMicrophoneNoPrivilege")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnCameraNoPrivilege", Selector = "onCameraNoPrivilege")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnFreeMeetingReminder", Selector = "onFreeMeetingReminder:canFreeUpgrade:isFirstGift:completion:", ParameterType = new Type [] { typeof (bool), typeof (bool), typeof (bool), typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnUpgradeFreeMeetingResult", Selector = "onUpgradeFreeMeetingResult:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnFreeMeetingNeedToUpgrade", Selector = "onFreeMeetingNeedToUpgrade:giftUpgradeURL:", ParameterType = new Type [] { typeof (Zoomios.FreeMeetingNeedUpgradeType), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnFreeMeetingUpgradeToGiftFreeTrialStart", Selector = "onFreeMeetingUpgradeToGiftFreeTrialStart")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnFreeMeetingUpgradeToGiftFreeTrialStop", Selector = "onFreeMeetingUpgradeToGiftFreeTrialStop")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnFreeMeetingUpgradedToProMeeting", Selector = "onFreeMeetingUpgradedToProMeeting")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnClickedInviteButton", Selector = "onClickedInviteButton:addInviteActionItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIViewController), typeof (NSMutableArray) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnClickedAudioButton", Selector = "onClickedAudioButton:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnClickedParticipantsButton", Selector = "onClickedParticipantsButton:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnClickedShareButton", Selector = "onClickedShareButton:addShareActionItem:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIViewController), typeof (NSMutableArray) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnClickedEndButton", Selector = "onClickedEndButton:endButton:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIViewController), typeof (UIButton) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnOngoingShareStopped", Selector = "onOngoingShareStopped")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnClickedDialOut", Selector = "onClickedDialOut:isCallMe:", ParameterType = new Type [] { typeof (UIViewController), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnDialOutStatusChanged", Selector = "onDialOutStatusChanged:", ParameterType = new Type [] { typeof (Zoomios.DialOutStatus) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnSendPairingCodeStateChanged", Selector = "onSendPairingCodeStateChanged:MeetingNumber:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCH323ParingStatus), typeof (ulong) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnCallRoomDeviceStateChanged", Selector = "onCallRoomDeviceStateChanged:", ParameterType = new Type [] { typeof (Zoomios.H323CallOutStatus) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnInMeetingChat", Selector = "onInMeetingChat:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnChatMsgDeleteNotification", Selector = "onChatMsgDeleteNotification:deleteBy:", ParameterType = new Type [] { typeof (string), typeof (Zoomios.MobileRTCChatMessageDeleteType) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnLiveStreamStatusChange", Selector = "onLiveStreamStatusChange:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCLiveStreamStatus) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnZoomIdentityExpired", Selector = "onZoomIdentityExpired")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnClickShareScreen", Selector = "onClickShareScreen:", ParameterType = new Type [] { typeof (UIViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnClosedCaptionReceived", Selector = "onClosedCaptionReceived:speakerId:msgTime:", ParameterType = new Type [] { typeof (string), typeof (nuint), typeof (NSDate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnWaitingRoomStatusChange", Selector = "onWaitingRoomStatusChange:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnSinkAttendeeChatPriviledgeChanged", Selector = "onSinkAttendeeChatPriviledgeChanged:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCMeetingChatPriviledgeType) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnSinkPanelistChatPrivilegeChanged", Selector = "onSinkPanelistChatPrivilegeChanged:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCPanelistChatPrivilegeType) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnSubscribeUserFail", Selector = "onSubscribeUserFail:size:userId:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCSubscribeFailReason), typeof (nint), typeof (nuint) }, ParameterByRef = new bool [] { false, false, false })]
	public partial interface IIMobileRTCMeetingServiceDelegate : INativeObject, IDisposable
	{
	}
	public static partial class IMobileRTCMeetingServiceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnMeetingError (this IIMobileRTCMeetingServiceDelegate This, MobileRTCMeetError error, string? message)
		{
			var nsmessage = CFString.CreateNative (message);
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("onMeetingError:message:"), (UIntPtr) (ulong) error, nsmessage);
			CFString.ReleaseNative (nsmessage);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnMeetingStateChange (this IIMobileRTCMeetingServiceDelegate This, MobileRTCMeetingState state)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onMeetingStateChange:"), (UIntPtr) (ulong) state);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnMeetingParameterNotification (this IIMobileRTCMeetingServiceDelegate This, MobileRTCMeetingParameter? meetingParam)
		{
			var meetingParam__handle__ = meetingParam.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onMeetingParameterNotification:"), meetingParam__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnJoinMeetingConfirmed (this IIMobileRTCMeetingServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onJoinMeetingConfirmed"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnMeetingReady (this IIMobileRTCMeetingServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onMeetingReady"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnJBHWaitingWithCmd (this IIMobileRTCMeetingServiceDelegate This, JBHCmd cmd)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onJBHWaitingWithCmd:"), (UIntPtr) (ulong) cmd);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnCheckCMRPrivilege (this IIMobileRTCMeetingServiceDelegate This, MobileRTCCMRError result)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onCheckCMRPrivilege:"), (UIntPtr) (ulong) result);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnRecordingStatus (this IIMobileRTCMeetingServiceDelegate This, MobileRTCRecordingStatus status)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onRecordingStatus:"), (UIntPtr) (ulong) status);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnLocalRecordingStatus (this IIMobileRTCMeetingServiceDelegate This, nint userId, MobileRTCRecordingStatus status)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("onLocalRecordingStatus:status:"), (IntPtr) userId, (UIntPtr) (ulong) status);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnMeetingEndedReason (this IIMobileRTCMeetingServiceDelegate This, MobileRTCMeetingEndReason reason)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onMeetingEndedReason:"), (UIntPtr) (ulong) reason);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnNoHostMeetingWillTerminate (this IIMobileRTCMeetingServiceDelegate This, nuint minutes)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onNoHostMeetingWillTerminate:"), (UIntPtr) minutes);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnMicrophoneStatusError (this IIMobileRTCMeetingServiceDelegate This, MobileRTCMicrophoneError error)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onMicrophoneStatusError:"), (UIntPtr) (ulong) error);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void OnJoinMeetingInfo (this IIMobileRTCMeetingServiceDelegate This, MobileRTCJoinMeetingInfo info, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSString, NSString, bool> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity3V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("onJoinMeetingInfo:completion:"), (UIntPtr) (ulong) info, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void OnProxyAuth (this IIMobileRTCMeetingServiceDelegate This, string host, nuint port, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity5V0))]global::System.Action<NSString, nuint, NSString, NSString, bool> completion)
		{
			if (host is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (host));
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			var nshost = CFString.CreateNative (host);
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity5V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("onProxyAuth:port:completion:"), nshost, (UIntPtr) port, (IntPtr) block_ptr_completion);
			CFString.ReleaseNative (nshost);
			block_ptr_completion->CleanupBlock ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void OnAskToEndOtherMeeting (this IIMobileRTCMeetingServiceDelegate This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onAskToEndOtherMeeting:"), (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnMicrophoneNoPrivilege (this IIMobileRTCMeetingServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onMicrophoneNoPrivilege"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnCameraNoPrivilege (this IIMobileRTCMeetingServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onCameraNoPrivilege"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void OnFreeMeetingReminder (this IIMobileRTCMeetingServiceDelegate This, bool host, bool freeUpgrade, bool first, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool_bool_IntPtr (This.Handle, Selector.GetHandle ("onFreeMeetingReminder:canFreeUpgrade:isFirstGift:completion:"), host, freeUpgrade, first, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnUpgradeFreeMeetingResult (this IIMobileRTCMeetingServiceDelegate This, nuint result)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onUpgradeFreeMeetingResult:"), (UIntPtr) result);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnFreeMeetingNeedToUpgrade (this IIMobileRTCMeetingServiceDelegate This, FreeMeetingNeedUpgradeType type, string? giftURL)
		{
			var nsgiftURL = CFString.CreateNative (giftURL);
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("onFreeMeetingNeedToUpgrade:giftUpgradeURL:"), (UIntPtr) (ulong) type, nsgiftURL);
			CFString.ReleaseNative (nsgiftURL);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnFreeMeetingUpgradeToGiftFreeTrialStart (this IIMobileRTCMeetingServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onFreeMeetingUpgradeToGiftFreeTrialStart"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnFreeMeetingUpgradeToGiftFreeTrialStop (this IIMobileRTCMeetingServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onFreeMeetingUpgradeToGiftFreeTrialStop"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnFreeMeetingUpgradedToProMeeting (this IIMobileRTCMeetingServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onFreeMeetingUpgradedToProMeeting"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool OnClickedInviteButton (this IIMobileRTCMeetingServiceDelegate This, global::UIKit.UIViewController parentVC, NSMutableArray? array)
		{
			var parentVC__handle__ = parentVC!.GetNonNullHandle (nameof (parentVC));
			var array__handle__ = array.GetHandle ();
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onClickedInviteButton:addInviteActionItem:"), parentVC__handle__, array__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool OnClickedAudioButton (this IIMobileRTCMeetingServiceDelegate This, global::UIKit.UIViewController parentVC)
		{
			var parentVC__handle__ = parentVC!.GetNonNullHandle (nameof (parentVC));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onClickedAudioButton:"), parentVC__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool OnClickedParticipantsButton (this IIMobileRTCMeetingServiceDelegate This, global::UIKit.UIViewController parentVC)
		{
			var parentVC__handle__ = parentVC!.GetNonNullHandle (nameof (parentVC));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onClickedParticipantsButton:"), parentVC__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool OnClickedShareButton (this IIMobileRTCMeetingServiceDelegate This, global::UIKit.UIViewController parentVC, NSMutableArray array)
		{
			var parentVC__handle__ = parentVC!.GetNonNullHandle (nameof (parentVC));
			var array__handle__ = array!.GetNonNullHandle (nameof (array));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onClickedShareButton:addShareActionItem:"), parentVC__handle__, array__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool OnClickedEndButton (this IIMobileRTCMeetingServiceDelegate This, global::UIKit.UIViewController parentVC, global::UIKit.UIButton endButton)
		{
			var parentVC__handle__ = parentVC!.GetNonNullHandle (nameof (parentVC));
			var endButton__handle__ = endButton!.GetNonNullHandle (nameof (endButton));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onClickedEndButton:endButton:"), parentVC__handle__, endButton__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnOngoingShareStopped (this IIMobileRTCMeetingServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onOngoingShareStopped"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnClickedDialOut (this IIMobileRTCMeetingServiceDelegate This, global::UIKit.UIViewController parentVC, bool me)
		{
			var parentVC__handle__ = parentVC!.GetNonNullHandle (nameof (parentVC));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("onClickedDialOut:isCallMe:"), parentVC__handle__, me);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnDialOutStatusChanged (this IIMobileRTCMeetingServiceDelegate This, DialOutStatus status)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onDialOutStatusChanged:"), (UIntPtr) (ulong) status);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnSendPairingCodeStateChanged (this IIMobileRTCMeetingServiceDelegate This, MobileRTCH323ParingStatus state, ulong meetingNumber)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_UInt64 (This.Handle, Selector.GetHandle ("onSendPairingCodeStateChanged:MeetingNumber:"), (UIntPtr) (ulong) state, meetingNumber);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnCallRoomDeviceStateChanged (this IIMobileRTCMeetingServiceDelegate This, H323CallOutStatus state)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onCallRoomDeviceStateChanged:"), (UIntPtr) (ulong) state);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnInMeetingChat (this IIMobileRTCMeetingServiceDelegate This, string messageID)
		{
			if (messageID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageID));
			var nsmessageID = CFString.CreateNative (messageID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onInMeetingChat:"), nsmessageID);
			CFString.ReleaseNative (nsmessageID);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnChatMsgDeleteNotification (this IIMobileRTCMeetingServiceDelegate This, string msgID, MobileRTCChatMessageDeleteType deleteBy)
		{
			if (msgID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (msgID));
			var nsmsgID = CFString.CreateNative (msgID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("onChatMsgDeleteNotification:deleteBy:"), nsmsgID, (UIntPtr) (ulong) deleteBy);
			CFString.ReleaseNative (nsmsgID);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnLiveStreamStatusChange (this IIMobileRTCMeetingServiceDelegate This, MobileRTCLiveStreamStatus liveStreamStatus)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onLiveStreamStatusChange:"), (UIntPtr) (ulong) liveStreamStatus);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnZoomIdentityExpired (this IIMobileRTCMeetingServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onZoomIdentityExpired"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnClickShareScreen (this IIMobileRTCMeetingServiceDelegate This, global::UIKit.UIViewController parentVC)
		{
			var parentVC__handle__ = parentVC!.GetNonNullHandle (nameof (parentVC));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onClickShareScreen:"), parentVC__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnClosedCaptionReceived (this IIMobileRTCMeetingServiceDelegate This, string message, nuint speakerID, NSDate? msgTime)
		{
			if (message is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (message));
			var msgTime__handle__ = msgTime.GetHandle ();
			var nsmessage = CFString.CreateNative (message);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("onClosedCaptionReceived:speakerId:msgTime:"), nsmessage, (UIntPtr) speakerID, msgTime__handle__);
			CFString.ReleaseNative (nsmessage);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnWaitingRoomStatusChange (this IIMobileRTCMeetingServiceDelegate This, bool needWaiting)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("onWaitingRoomStatusChange:"), needWaiting);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnSinkAttendeeChatPriviledgeChanged (this IIMobileRTCMeetingServiceDelegate This, MobileRTCMeetingChatPriviledgeType currentPrivilege)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onSinkAttendeeChatPriviledgeChanged:"), (UIntPtr) (ulong) currentPrivilege);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnSinkPanelistChatPrivilegeChanged (this IIMobileRTCMeetingServiceDelegate This, MobileRTCPanelistChatPrivilegeType privilege)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onSinkPanelistChatPrivilegeChanged:"), (UIntPtr) (ulong) privilege);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnSubscribeUserFail (this IIMobileRTCMeetingServiceDelegate This, MobileRTCSubscribeFailReason errorCode, nint size, nuint userId)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("onSubscribeUserFail:size:userId:"), (IntPtr) (long) errorCode, (IntPtr) size, (UIntPtr) userId);
		}
	}
	internal sealed class IMobileRTCMeetingServiceDelegateWrapper : BaseWrapper, IIMobileRTCMeetingServiceDelegate {
		[Preserve (Conditional = true)]
		public IMobileRTCMeetingServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_IMobileRTCMeetingServiceDelegate", false)]
	[Model]
	public unsafe partial class IMobileRTCMeetingServiceDelegate : NSObject, IIMobileRTCMeetingServiceDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public IMobileRTCMeetingServiceDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected IMobileRTCMeetingServiceDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal IMobileRTCMeetingServiceDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onAskToEndOtherMeeting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OnAskToEndOtherMeeting ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onCallRoomDeviceStateChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnCallRoomDeviceStateChanged (H323CallOutStatus state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onCameraNoPrivilege")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnCameraNoPrivilege ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onChatMsgDeleteNotification:deleteBy:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnChatMsgDeleteNotification (string msgID, MobileRTCChatMessageDeleteType deleteBy)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onCheckCMRPrivilege:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnCheckCMRPrivilege (MobileRTCCMRError result)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onClickShareScreen:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnClickShareScreen (global::UIKit.UIViewController parentVC)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onClickedAudioButton:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OnClickedAudioButton (global::UIKit.UIViewController parentVC)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onClickedDialOut:isCallMe:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnClickedDialOut (global::UIKit.UIViewController parentVC, bool me)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onClickedEndButton:endButton:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OnClickedEndButton (global::UIKit.UIViewController parentVC, global::UIKit.UIButton endButton)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onClickedInviteButton:addInviteActionItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OnClickedInviteButton (global::UIKit.UIViewController parentVC, NSMutableArray? array)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onClickedParticipantsButton:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OnClickedParticipantsButton (global::UIKit.UIViewController parentVC)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onClickedShareButton:addShareActionItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool OnClickedShareButton (global::UIKit.UIViewController parentVC, NSMutableArray array)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onClosedCaptionReceived:speakerId:msgTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnClosedCaptionReceived (string message, nuint speakerID, NSDate? msgTime)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onDialOutStatusChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnDialOutStatusChanged (DialOutStatus status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onFreeMeetingNeedToUpgrade:giftUpgradeURL:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnFreeMeetingNeedToUpgrade (FreeMeetingNeedUpgradeType type, string? giftURL)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onFreeMeetingReminder:canFreeUpgrade:isFirstGift:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OnFreeMeetingReminder (bool host, bool freeUpgrade, bool first, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onFreeMeetingUpgradeToGiftFreeTrialStart")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnFreeMeetingUpgradeToGiftFreeTrialStart ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onFreeMeetingUpgradeToGiftFreeTrialStop")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnFreeMeetingUpgradeToGiftFreeTrialStop ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onFreeMeetingUpgradedToProMeeting")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnFreeMeetingUpgradedToProMeeting ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onInMeetingChat:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnInMeetingChat (string messageID)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onJBHWaitingWithCmd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnJBHWaitingWithCmd (JBHCmd cmd)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onJoinMeetingConfirmed")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnJoinMeetingConfirmed ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onJoinMeetingInfo:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OnJoinMeetingInfo (MobileRTCJoinMeetingInfo info, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity3V0))]global::System.Action<NSString, NSString, bool> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onLiveStreamStatusChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnLiveStreamStatusChange (MobileRTCLiveStreamStatus liveStreamStatus)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onLocalRecordingStatus:status:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnLocalRecordingStatus (nint userId, MobileRTCRecordingStatus status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onMeetingEndedReason:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnMeetingEndedReason (MobileRTCMeetingEndReason reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onMeetingError:message:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnMeetingError (MobileRTCMeetError error, string? message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onMeetingParameterNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnMeetingParameterNotification (MobileRTCMeetingParameter? meetingParam)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onMeetingReady")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnMeetingReady ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onMeetingStateChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnMeetingStateChange (MobileRTCMeetingState state)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onMicrophoneNoPrivilege")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnMicrophoneNoPrivilege ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onMicrophoneStatusError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnMicrophoneStatusError (MobileRTCMicrophoneError error)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onNoHostMeetingWillTerminate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnNoHostMeetingWillTerminate (nuint minutes)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onOngoingShareStopped")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnOngoingShareStopped ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onProxyAuth:port:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void OnProxyAuth (string host, nuint port, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity5V0))]global::System.Action<NSString, nuint, NSString, NSString, bool> completion)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onRecordingStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnRecordingStatus (MobileRTCRecordingStatus status)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onSendPairingCodeStateChanged:MeetingNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnSendPairingCodeStateChanged (MobileRTCH323ParingStatus state, ulong meetingNumber)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onSinkAttendeeChatPriviledgeChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnSinkAttendeeChatPriviledgeChanged (MobileRTCMeetingChatPriviledgeType currentPrivilege)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onSinkPanelistChatPrivilegeChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnSinkPanelistChatPrivilegeChanged (MobileRTCPanelistChatPrivilegeType privilege)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onSubscribeUserFail:size:userId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnSubscribeUserFail (MobileRTCSubscribeFailReason errorCode, nint size, nuint userId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onUpgradeFreeMeetingResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnUpgradeFreeMeetingResult (nuint result)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onWaitingRoomStatusChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnWaitingRoomStatusChange (bool needWaiting)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onZoomIdentityExpired")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnZoomIdentityExpired ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class IMobileRTCMeetingServiceDelegate */
}
