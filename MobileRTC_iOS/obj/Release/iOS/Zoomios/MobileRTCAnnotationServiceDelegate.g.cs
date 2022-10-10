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
	[Protocol (Name = "MobileRTCAnnotationServiceDelegate", WrapperType = typeof (MobileRTCAnnotationServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SupportStatusChanged", Selector = "onAnnotationService:supportStatusChanged:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCAnnotationService), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IMobileRTCAnnotationServiceDelegate : INativeObject, IDisposable
	{
	}
	public static partial class MobileRTCAnnotationServiceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SupportStatusChanged (this IMobileRTCAnnotationServiceDelegate This, MobileRTCAnnotationService? service, bool support)
		{
			var service__handle__ = service.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("onAnnotationService:supportStatusChanged:"), service__handle__, support);
		}
	}
	internal sealed class MobileRTCAnnotationServiceDelegateWrapper : BaseWrapper, IMobileRTCAnnotationServiceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCAnnotationServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_MobileRTCAnnotationServiceDelegate", false)]
	[Model]
	public unsafe partial class MobileRTCAnnotationServiceDelegate : NSObject, IMobileRTCAnnotationServiceDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCAnnotationServiceDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCAnnotationServiceDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCAnnotationServiceDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onAnnotationService:supportStatusChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SupportStatusChanged (MobileRTCAnnotationService? service, bool support)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MobileRTCAnnotationServiceDelegate */
}
