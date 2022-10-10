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
	[Protocol (Name = "MobileRTCBOAdminDelegate", WrapperType = typeof (MobileRTCBOAdminDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnHelpRequestReceived", Selector = "onHelpRequestReceived:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnStartBOError", Selector = "onStartBOError:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCBOControllerError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnBOEndTimerUpdated", Selector = "onBOEndTimerUpdated:isTimesUpNotice:", ParameterType = new Type [] { typeof (nuint), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IMobileRTCBOAdminDelegate : INativeObject, IDisposable, 
		Zoomios.IIMobileRTCMeetingServiceDelegate
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onHelpRequestReceived:")]
		[Preserve (Conditional = true)]
		void OnHelpRequestReceived (string? strUserID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onStartBOError:")]
		[Preserve (Conditional = true)]
		void OnStartBOError (MobileRTCBOControllerError errType);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onBOEndTimerUpdated:isTimesUpNotice:")]
		[Preserve (Conditional = true)]
		void OnBOEndTimerUpdated (nuint remaining, bool isTimesUpNotice);
	}
	internal sealed class MobileRTCBOAdminDelegateWrapper : BaseWrapper, IMobileRTCBOAdminDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCBOAdminDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onHelpRequestReceived:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnHelpRequestReceived (string? strUserID)
		{
			var nsstrUserID = CFString.CreateNative (strUserID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onHelpRequestReceived:"), nsstrUserID);
			CFString.ReleaseNative (nsstrUserID);
		}
		[Export ("onStartBOError:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnStartBOError (MobileRTCBOControllerError errType)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onStartBOError:"), (UIntPtr) (ulong) errType);
		}
		[Export ("onBOEndTimerUpdated:isTimesUpNotice:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnBOEndTimerUpdated (nuint remaining, bool isTimesUpNotice)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_bool (this.Handle, Selector.GetHandle ("onBOEndTimerUpdated:isTimesUpNotice:"), (UIntPtr) remaining, isTimesUpNotice);
		}
	}
}
