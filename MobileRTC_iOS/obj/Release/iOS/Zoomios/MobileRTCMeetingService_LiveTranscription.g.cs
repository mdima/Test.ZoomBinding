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
	public unsafe static partial class MobileRTCMeetingService_LiveTranscription  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingService");
		[Export ("assignCCPrivilege:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AssignCCPrivilege (this MobileRTCMeetingService This, nuint userId)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("assignCCPrivilege:"), (UIntPtr) userId);
		}
		[Export ("getAvailableMeetingSpokenLanguages")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCLiveTranscriptionLanguage[] AvailableMeetingSpokenLanguages (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCLiveTranscriptionLanguage>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAvailableMeetingSpokenLanguages")))!;
		}
		[Export ("getAvailableTranslationLanguages")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCLiveTranscriptionLanguage[] AvailableTranslationLanguages (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCLiveTranscriptionLanguage>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAvailableTranslationLanguages")))!;
		}
		[Export ("canAssignOthersToSendCC")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanAssignOthersToSendCC (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canAssignOthersToSendCC"));
		}
		[Export ("canBeAssignedToSendCC:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanBeAssignedToSendCC (this MobileRTCMeetingService This, nuint userId)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("canBeAssignedToSendCC:"), (UIntPtr) userId);
		}
		[Export ("canStartLiveTranscription")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CanStartLiveTranscription (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("canStartLiveTranscription"));
		}
		[Export ("enableMeetingManualCaption:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool EnableMeetingManualCaption (this MobileRTCMeetingService This, bool bEnable)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("enableMeetingManualCaption:"), bEnable);
		}
		[Export ("enableRequestLiveTranscription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool EnableRequestLiveTranscription (this MobileRTCMeetingService This, bool enable)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("enableRequestLiveTranscription:"), enable);
		}
		[Export ("isLiveTranscriptionFeatureEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsLiveTranscriptionFeatureEnabled (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isLiveTranscriptionFeatureEnabled"));
		}
		[Export ("isMeetingManualCaptionEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMeetingManualCaptionEnabled (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMeetingManualCaptionEnabled"));
		}
		[Export ("isMeetingSupportCC")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMeetingSupportCC (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMeetingSupportCC"));
		}
		[Export ("isMultiLanguageTranscriptionEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMultiLanguageTranscriptionEnabled (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMultiLanguageTranscriptionEnabled"));
		}
		[Export ("isRequestToStartLiveTranscriptionEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsRequestToStartLiveTranscriptionEnabled (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isRequestToStartLiveTranscriptionEnabled"));
		}
		[Export ("isTextLiveTranslationEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsTextLiveTranslationEnabled (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isTextLiveTranslationEnabled"));
		}
		[Export ("getLiveTranscriptionStatus")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCLiveTranscriptionStatus LiveTranscriptionStatus (this MobileRTCMeetingService This)
		{
			MobileRTCLiveTranscriptionStatus ret;
			ret = (Zoomios.MobileRTCLiveTranscriptionStatus) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getLiveTranscriptionStatus"));
			return ret!;
		}
		[Export ("getMeetingSpokenLanguage")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCLiveTranscriptionLanguage MeetingSpokenLanguage (this MobileRTCMeetingService This)
		{
			return  Runtime.GetNSObject<MobileRTCLiveTranscriptionLanguage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getMeetingSpokenLanguage")))!;
		}
		[Export ("requestToStartLiveTranscription:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool RequestToStartLiveTranscription (this MobileRTCMeetingService This, bool requestAnonymous)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("requestToStartLiveTranscription:"), requestAnonymous);
		}
		[Export ("setMeetingSpokenLanguage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetMeetingSpokenLanguage (this MobileRTCMeetingService This, nint languageID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setMeetingSpokenLanguage:"), (IntPtr) languageID);
		}
		[Export ("setTranslationLanguage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetTranslationLanguage (this MobileRTCMeetingService This, nint languageID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setTranslationLanguage:"), (IntPtr) languageID);
		}
		[Export ("startLiveTranscription")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool StartLiveTranscription (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("startLiveTranscription"));
		}
		[Export ("stopLiveTranscription")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool StopLiveTranscription (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("stopLiveTranscription"));
		}
		[Export ("getTranslationLanguage")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCLiveTranscriptionLanguage TranslationLanguage (this MobileRTCMeetingService This)
		{
			return  Runtime.GetNSObject<MobileRTCLiveTranscriptionLanguage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getTranslationLanguage")))!;
		}
		[Export ("withdrawCCPrivilege:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool WithdrawCCPrivilege (this MobileRTCMeetingService This, nuint userId)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("withdrawCCPrivilege:"), (UIntPtr) userId);
		}
	} /* class MobileRTCMeetingService_LiveTranscription */
}
