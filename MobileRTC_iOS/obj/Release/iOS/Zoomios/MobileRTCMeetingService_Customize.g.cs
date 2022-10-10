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
	public unsafe static partial class MobileRTCMeetingService_Customize  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingService");
		[Export ("callRoomDevice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CallRoomDevice (this MobileRTCMeetingService This, MobileRTCRoomDevice device)
		{
			var device__handle__ = device!.GetNonNullHandle (nameof (device));
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("callRoomDevice:"), device__handle__);
		}
		[Export ("cancelCallRoomDevice")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CancelCallRoomDevice (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("cancelCallRoomDevice"));
		}
		[Export ("cancelDialOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CancelDialOut (this MobileRTCMeetingService This, bool isCallMe)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("cancelDialOut:"), isCallMe);
		}
		[Export ("customizeMeetingTitle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void CustomizeMeetingTitle (this MobileRTCMeetingService This, string? title)
		{
			var nstitle = CFString.CreateNative (title);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("customizeMeetingTitle:"), nstitle);
			CFString.ReleaseNative (nstitle);
		}
		[Export ("getDialInAllCountryCodes")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCCallCountryCode[] DialInAllCountryCodes (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCCallCountryCode>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getDialInAllCountryCodes")))!;
		}
		[Export ("dialInCall:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DialInCall (this MobileRTCMeetingService This, string? countryNumber)
		{
			var nscountryNumber = CFString.CreateNative (countryNumber);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("dialInCall:"), nscountryNumber);
			CFString.ReleaseNative (nscountryNumber);
			return ret!;
		}
		[Export ("getDialInCurrentCountryCode")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCCallCountryCode DialInCurrentCountryCode (this MobileRTCMeetingService This)
		{
			return  Runtime.GetNSObject<MobileRTCCallCountryCode> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getDialInCurrentCountryCode")))!;
		}
		[Export ("dialOut:isCallMe:withName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DialOut (this MobileRTCMeetingService This, string phone, bool me, string? username)
		{
			if (phone is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (phone));
			var nsphone = CFString.CreateNative (phone);
			var nsusername = CFString.CreateNative (username);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool_IntPtr (This.Handle, Selector.GetHandle ("dialOut:isCallMe:withName:"), nsphone, me, nsusername);
			CFString.ReleaseNative (nsphone);
			CFString.ReleaseNative (nsusername);
			return ret!;
		}
		[Export ("getDialInCallCodesWithCountryId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCCallCountryCode[]? GetDialInCallCodesWithCountryId (this MobileRTCMeetingService This, string? countryId)
		{
			var nscountryId = CFString.CreateNative (countryId);
			MobileRTCCallCountryCode[]? ret;
			ret = CFArray.ArrayFromHandle<MobileRTCCallCountryCode>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("getDialInCallCodesWithCountryId:"), nscountryId))!;
			CFString.ReleaseNative (nscountryId);
			return ret!;
		}
		[Export ("getH323MeetingPassword")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string H323MeetingPassword (this MobileRTCMeetingService This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getH323MeetingPassword")))!;
		}
		[Export ("getIPAddressList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] IPAddressList (this MobileRTCMeetingService This)
		{
			return CFArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getIPAddressList")))!;
		}
		[Export ("isCallRoomDeviceSupported")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsCallRoomDeviceSupported (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isCallRoomDeviceSupported"));
		}
		[Export ("isCallingRoomDevice")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsCallingRoomDevice (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isCallingRoomDevice"));
		}
		[Export ("isDialOutInProgress")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsDialOutInProgress (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isDialOutInProgress"));
		}
		[Export ("isDialOutSupported")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsDialOutSupported (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isDialOutSupported"));
		}
		[Export ("getParticipantID")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nuint ParticipantID (this MobileRTCMeetingService This)
		{
			return (nuint) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getParticipantID"));
		}
		[Export ("getRoomDeviceList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCRoomDevice[] RoomDeviceList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCRoomDevice>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getRoomDeviceList")))!;
		}
		[Export ("sendPairingCode:WithMeetingNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SendPairingCode (this MobileRTCMeetingService This, string code, ulong meetingNumber)
		{
			if (code is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (code));
			var nscode = CFString.CreateNative (code);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_UInt64 (This.Handle, Selector.GetHandle ("sendPairingCode:WithMeetingNumber:"), nscode, meetingNumber);
			CFString.ReleaseNative (nscode);
			return ret!;
		}
		[Export ("setCloudWhiteboardFeedbackUrl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetCloudWhiteboardFeedbackUrl (this MobileRTCMeetingService This, string? feedbackUrl)
		{
			var nsfeedbackUrl = CFString.CreateNative (feedbackUrl);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setCloudWhiteboardFeedbackUrl:"), nsfeedbackUrl);
			CFString.ReleaseNative (nsfeedbackUrl);
			return ret!;
		}
		[Export ("setCustomizedPollingUrl:bCreate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetCustomizedPollingUrl (this MobileRTCMeetingService This, string? pollingURL, bool bCreate)
		{
			var nspollingURL = CFString.CreateNative (pollingURL);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("setCustomizedPollingUrl:bCreate:"), nspollingURL, bCreate);
			CFString.ReleaseNative (nspollingURL);
			return ret!;
		}
		[Export ("setMeetingTopic:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetMeetingTopic (this MobileRTCMeetingService This, string meetingTopic)
		{
			if (meetingTopic is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (meetingTopic));
			var nsmeetingTopic = CFString.CreateNative (meetingTopic);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMeetingTopic:"), nsmeetingTopic);
			CFString.ReleaseNative (nsmeetingTopic);
			return ret!;
		}
	} /* class MobileRTCMeetingService_Customize */
}
