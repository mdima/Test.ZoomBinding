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
	[Protocol (Name = "MobileRTCBODataDelegate", WrapperType = typeof (MobileRTCBODataDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnBOInfoUpdated", Selector = "onBOInfoUpdated:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnUnAssignedUserUpdated", Selector = "onUnAssignedUserUpdated")]
	public partial interface IMobileRTCBODataDelegate : INativeObject, IDisposable, 
		Zoomios.IIMobileRTCMeetingServiceDelegate
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onBOInfoUpdated:")]
		[Preserve (Conditional = true)]
		void OnBOInfoUpdated (string? boId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onUnAssignedUserUpdated")]
		[Preserve (Conditional = true)]
		void OnUnAssignedUserUpdated ();
	}
	internal sealed class MobileRTCBODataDelegateWrapper : BaseWrapper, IMobileRTCBODataDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCBODataDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onBOInfoUpdated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnBOInfoUpdated (string? boId)
		{
			var nsboId = CFString.CreateNative (boId);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onBOInfoUpdated:"), nsboId);
			CFString.ReleaseNative (nsboId);
		}
		[Export ("onUnAssignedUserUpdated")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnUnAssignedUserUpdated ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onUnAssignedUserUpdated"));
		}
	}
}
