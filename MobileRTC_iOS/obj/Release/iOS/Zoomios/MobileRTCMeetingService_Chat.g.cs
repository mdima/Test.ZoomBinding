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
	public unsafe static partial class MobileRTCMeetingService_Chat  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingService");
		[Export ("getAllChatMessageID")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string[] AllChatMessageID (this MobileRTCMeetingService This)
		{
			return CFArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAllChatMessageID")))!;
		}
		[Export ("getAttendeeChatPriviledge")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetingChatPriviledgeType AttendeeChatPriviledge (this MobileRTCMeetingService This)
		{
			MobileRTCMeetingChatPriviledgeType ret;
			ret = (Zoomios.MobileRTCMeetingChatPriviledgeType) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAttendeeChatPriviledge"));
			return ret!;
		}
		[Export ("changeAttendeeChatPriviledge:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ChangeAttendeeChatPriviledge (this MobileRTCMeetingService This, MobileRTCMeetingChatPriviledgeType privilege)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("changeAttendeeChatPriviledge:"), (UIntPtr) (ulong) privilege);
		}
		[Export ("getChatLegalNoticesExplained")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string ChatLegalNoticesExplained (this MobileRTCMeetingService This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getChatLegalNoticesExplained")))!;
		}
		[Export ("getChatLegalNoticesPrompt")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string ChatLegalNoticesPrompt (this MobileRTCMeetingService This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getChatLegalNoticesPrompt")))!;
		}
		[Export ("deleteChatMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DeleteChatMessage (this MobileRTCMeetingService This, string msgId)
		{
			if (msgId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (msgId));
			var nsmsgId = CFString.CreateNative (msgId);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("deleteChatMessage:"), nsmsgId);
			CFString.ReleaseNative (nsmsgId);
			return ret!;
		}
		[Export ("isChatDisabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsChatDisabled (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isChatDisabled"));
		}
		[Export ("isChatMessageCanBeDeleted:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsChatMessageCanBeDeleted (this MobileRTCMeetingService This, string msgId)
		{
			if (msgId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (msgId));
			var nsmsgId = CFString.CreateNative (msgId);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("isChatMessageCanBeDeleted:"), nsmsgId);
			CFString.ReleaseNative (nsmsgId);
			return ret!;
		}
		[Export ("isMeetingChatLegalNoticeAvailable")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMeetingChatLegalNoticeAvailable (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMeetingChatLegalNoticeAvailable"));
		}
		[Export ("isPrivateChatDisabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsPrivateChatDisabled (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isPrivateChatDisabled"));
		}
		[Export ("isShareMeetingChatLegalNoticeAvailable")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsShareMeetingChatLegalNoticeAvailable (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isShareMeetingChatLegalNoticeAvailable"));
		}
		[Export ("meetingChatByID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetingChat? MeetingChatByID (this MobileRTCMeetingService This, string messageID)
		{
			if (messageID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (messageID));
			var nsmessageID = CFString.CreateNative (messageID);
			MobileRTCMeetingChat? ret;
			ret =  Runtime.GetNSObject<MobileRTCMeetingChat> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("meetingChatByID:"), nsmessageID))!;
			CFString.ReleaseNative (nsmessageID);
			return ret!;
		}
		[Export ("sendChatToGroup:WithContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCSendChatError SendChatToGroup (this MobileRTCMeetingService This, MobileRTCChatGroup group, string content)
		{
			if (content is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (content));
			var nscontent = CFString.CreateNative (content);
			MobileRTCSendChatError ret;
			ret = (Zoomios.MobileRTCSendChatError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_UInt32_IntPtr (This.Handle, Selector.GetHandle ("sendChatToGroup:WithContent:"), (UInt32)group, nscontent);
			CFString.ReleaseNative (nscontent);
			return ret!;
		}
		[Export ("sendChatToUser:WithContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCSendChatError SendChatToUser (this MobileRTCMeetingService This, nuint userID, string content)
		{
			if (content is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (content));
			var nscontent = CFString.CreateNative (content);
			MobileRTCSendChatError ret;
			ret = (Zoomios.MobileRTCSendChatError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("sendChatToUser:WithContent:"), (UIntPtr) userID, nscontent);
			CFString.ReleaseNative (nscontent);
			return ret!;
		}
		[Export ("getShareMeetingChatStartedLegalNoticeContent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string ShareMeetingChatStartedLegalNoticeContent (this MobileRTCMeetingService This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getShareMeetingChatStartedLegalNoticeContent")))!;
		}
		[Export ("getShareMeetingChatStoppedLegalNoticeContent")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string ShareMeetingChatStoppedLegalNoticeContent (this MobileRTCMeetingService This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getShareMeetingChatStoppedLegalNoticeContent")))!;
		}
	} /* class MobileRTCMeetingService_Chat */
}
