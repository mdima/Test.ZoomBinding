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
	public unsafe static partial class MobileRTCMeetingService_Interpretation  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingService");
		[Export ("addInterpreter:lan1:andLan2:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AddInterpreter (this MobileRTCMeetingService This, nuint userID, nint lanID1, nint lanID2)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("addInterpreter:lan1:andLan2:"), (UIntPtr) userID, (IntPtr) lanID1, (IntPtr) lanID2);
		}
		[Export ("getAllLanguageList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCInterpretationLanguage[] AllLanguageList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCInterpretationLanguage>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAllLanguageList")))!;
		}
		[Export ("getAvailableLanguageList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCInterpretationLanguage[] AvailableLanguageList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCInterpretationLanguage>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAvailableLanguageList")))!;
		}
		[Export ("getInterpretationLanguageByID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCInterpretationLanguage? GetInterpretationLanguageByID (this MobileRTCMeetingService This, nint lanID)
		{
			return  Runtime.GetNSObject<MobileRTCInterpretationLanguage> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("getInterpretationLanguageByID:"), (IntPtr) lanID))!;
		}
		[Export ("getInterpreterActiveLan")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint InterpreterActiveLan (this MobileRTCMeetingService This)
		{
			return (nint) global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getInterpreterActiveLan"));
		}
		[Export ("getInterpreterAvailableLanguages")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCInterpretationLanguage[] InterpreterAvailableLanguages (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCInterpretationLanguage>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getInterpreterAvailableLanguages")))!;
		}
		[Export ("getInterpreterLans")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCInterpretationLanguage[] InterpreterLans (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCInterpretationLanguage>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getInterpreterLans")))!;
		}
		[Export ("getInterpreterList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetingInterpreter[] InterpreterList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCMeetingInterpreter>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getInterpreterList")))!;
		}
		[Export ("getInterpreterListenLan")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint InterpreterListenLan (this MobileRTCMeetingService This)
		{
			return (nint) global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getInterpreterListenLan"));
		}
		[Export ("isInterpretationEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsInterpretationEnabled (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isInterpretationEnabled"));
		}
		[Export ("isInterpretationStarted")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsInterpretationStarted (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isInterpretationStarted"));
		}
		[Export ("isInterpreter")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsInterpreter (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isInterpreter"));
		}
		[Export ("isMajorAudioTurnOff")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsMajorAudioTurnOff (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isMajorAudioTurnOff"));
		}
		[Export ("joinLanguageChannel:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool JoinLanguageChannel (this MobileRTCMeetingService This, nint lanID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("joinLanguageChannel:"), (IntPtr) lanID);
		}
		[Export ("getJoinedLanguageID")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nint JoinedLanguageID (this MobileRTCMeetingService This)
		{
			return (nint) global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getJoinedLanguageID"));
		}
		[Export ("modifyInterpreter:lan1:andLan2:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ModifyInterpreter (this MobileRTCMeetingService This, nuint userID, nint lanID1, nint lanID2)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("modifyInterpreter:lan1:andLan2:"), (UIntPtr) userID, (IntPtr) lanID1, (IntPtr) lanID2);
		}
		[Export ("removeInterpreter:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool RemoveInterpreter (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("removeInterpreter:"), (UIntPtr) userID);
		}
		[Export ("setInterpreterActiveLan:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetInterpreterActiveLan (this MobileRTCMeetingService This, nint activeLanID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setInterpreterActiveLan:"), (IntPtr) activeLanID);
		}
		[Export ("setInterpreterListenLan:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool SetInterpreterListenLan (this MobileRTCMeetingService This, nint lanID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setInterpreterListenLan:"), (IntPtr) lanID);
		}
		[Export ("startInterpretation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool StartInterpretation (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("startInterpretation"));
		}
		[Export ("stopInterpretation")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool StopInterpretation (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("stopInterpretation"));
		}
		[Export ("turnOffMajorAudio")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool TurnOffMajorAudio (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("turnOffMajorAudio"));
		}
		[Export ("turnOnMajorAudio")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool TurnOnMajorAudio (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("turnOnMajorAudio"));
		}
	} /* class MobileRTCMeetingService_Interpretation */
}
