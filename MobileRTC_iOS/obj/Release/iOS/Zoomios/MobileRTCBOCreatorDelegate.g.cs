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
	[Protocol (Name = "MobileRTCBOCreatorDelegate", WrapperType = typeof (MobileRTCBOCreatorDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnBOCreateSuccess", Selector = "onBOCreateSuccess:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public partial interface IMobileRTCBOCreatorDelegate : INativeObject, IDisposable, 
		Zoomios.IIMobileRTCMeetingServiceDelegate
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onBOCreateSuccess:")]
		[Preserve (Conditional = true)]
		void OnBOCreateSuccess (string? BOID);
	}
	internal sealed class MobileRTCBOCreatorDelegateWrapper : BaseWrapper, IMobileRTCBOCreatorDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCBOCreatorDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onBOCreateSuccess:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnBOCreateSuccess (string? BOID)
		{
			var nsBOID = CFString.CreateNative (BOID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onBOCreateSuccess:"), nsBOID);
			CFString.ReleaseNative (nsBOID);
		}
	}
}
