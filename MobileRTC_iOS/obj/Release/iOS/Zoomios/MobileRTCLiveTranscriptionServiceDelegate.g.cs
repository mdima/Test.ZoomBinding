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
	[Protocol (Name = "MobileRTCLiveTranscriptionServiceDelegate", WrapperType = typeof (MobileRTCLiveTranscriptionServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnSinkLiveTranscriptionStatus", Selector = "onSinkLiveTranscriptionStatus:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCLiveTranscriptionStatus) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnSinkLiveTranscriptionMsgReceived", Selector = "onSinkLiveTranscriptionMsgReceived:speakerId:type:", ParameterType = new Type [] { typeof (string), typeof (nuint), typeof (Zoomios.MobileRTCLiveTranscriptionOperationType) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnLiveTranscriptionMsgError", Selector = "onLiveTranscriptionMsgError:transcriptLanguage:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCLiveTranscriptionLanguage), typeof (Zoomios.MobileRTCLiveTranscriptionLanguage) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnSinkRequestForLiveTranscriptReceived", Selector = "onSinkRequestForLiveTranscriptReceived:bAnonymous:", ParameterType = new Type [] { typeof (nuint), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IMobileRTCLiveTranscriptionServiceDelegate : INativeObject, IDisposable, 
		Zoomios.IIMobileRTCMeetingServiceDelegate
	{
	}
	public static partial class MobileRTCLiveTranscriptionServiceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnSinkLiveTranscriptionStatus (this IMobileRTCLiveTranscriptionServiceDelegate This, MobileRTCLiveTranscriptionStatus status)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onSinkLiveTranscriptionStatus:"), (UIntPtr) (ulong) status);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnSinkLiveTranscriptionMsgReceived (this IMobileRTCLiveTranscriptionServiceDelegate This, string msg, nuint speakerId, MobileRTCLiveTranscriptionOperationType type)
		{
			if (msg is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (msg));
			var nsmsg = CFString.CreateNative (msg);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("onSinkLiveTranscriptionMsgReceived:speakerId:type:"), nsmsg, (UIntPtr) speakerId, (UIntPtr) (ulong) type);
			CFString.ReleaseNative (nsmsg);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnLiveTranscriptionMsgError (this IMobileRTCLiveTranscriptionServiceDelegate This, MobileRTCLiveTranscriptionLanguage? speakLanguage, MobileRTCLiveTranscriptionLanguage? transcriptLanguage)
		{
			var speakLanguage__handle__ = speakLanguage.GetHandle ();
			var transcriptLanguage__handle__ = transcriptLanguage.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onLiveTranscriptionMsgError:transcriptLanguage:"), speakLanguage__handle__, transcriptLanguage__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnSinkRequestForLiveTranscriptReceived (this IMobileRTCLiveTranscriptionServiceDelegate This, nuint requesterUserId, bool bAnonymous)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_bool (This.Handle, Selector.GetHandle ("onSinkRequestForLiveTranscriptReceived:bAnonymous:"), (UIntPtr) requesterUserId, bAnonymous);
		}
	}
	internal sealed class MobileRTCLiveTranscriptionServiceDelegateWrapper : BaseWrapper, IMobileRTCLiveTranscriptionServiceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCLiveTranscriptionServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
