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
	[Protocol (Name = "MobileRTCDirectShareServiceDelegate", WrapperType = typeof (MobileRTCDirectShareServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Handler", Selector = "onDirectShareStatusUpdate:handler:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCDirectShareStatus), typeof (Zoomios.MobileRTCDirectShareViaMeetingIDOrPairingCodeHandler) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IMobileRTCDirectShareServiceDelegate : INativeObject, IDisposable
	{
	}
	public static partial class MobileRTCDirectShareServiceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void Handler (this IMobileRTCDirectShareServiceDelegate This, MobileRTCDirectShareStatus status, MobileRTCDirectShareViaMeetingIDOrPairingCodeHandler? handler)
		{
			var handler__handle__ = handler.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("onDirectShareStatusUpdate:handler:"), (UIntPtr) (ulong) status, handler__handle__);
		}
	}
	internal sealed class MobileRTCDirectShareServiceDelegateWrapper : BaseWrapper, IMobileRTCDirectShareServiceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCDirectShareServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_MobileRTCDirectShareServiceDelegate", false)]
	[Model]
	public unsafe partial class MobileRTCDirectShareServiceDelegate : NSObject, IMobileRTCDirectShareServiceDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCDirectShareServiceDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCDirectShareServiceDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCDirectShareServiceDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onDirectShareStatusUpdate:handler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void Handler (MobileRTCDirectShareStatus status, MobileRTCDirectShareViaMeetingIDOrPairingCodeHandler? handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MobileRTCDirectShareServiceDelegate */
}
