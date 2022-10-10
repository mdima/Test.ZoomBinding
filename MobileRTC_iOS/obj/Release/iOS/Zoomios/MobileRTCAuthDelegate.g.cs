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
	[Protocol (Name = "MobileRTCAuthDelegate", WrapperType = typeof (MobileRTCAuthDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnMobileRTCAuthReturn", Selector = "onMobileRTCAuthReturn:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCAuthError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnMobileRTCAuthExpired", Selector = "onMobileRTCAuthExpired")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnMobileRTCLoginResult", Selector = "onMobileRTCLoginResult:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCLoginFailReason) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnMobileRTCLogoutReturn", Selector = "onMobileRTCLogoutReturn:", ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	public partial interface IMobileRTCAuthDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onMobileRTCAuthReturn:")]
		[Preserve (Conditional = true)]
		void OnMobileRTCAuthReturn (MobileRTCAuthError returnValue);
	}
	public static partial class MobileRTCAuthDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnMobileRTCAuthExpired (this IMobileRTCAuthDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onMobileRTCAuthExpired"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnMobileRTCLoginResult (this IMobileRTCAuthDelegate This, MobileRTCLoginFailReason resultValue)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onMobileRTCLoginResult:"), (UIntPtr) (ulong) resultValue);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnMobileRTCLogoutReturn (this IMobileRTCAuthDelegate This, nint returnValue)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onMobileRTCLogoutReturn:"), (IntPtr) returnValue);
		}
	}
	internal sealed class MobileRTCAuthDelegateWrapper : BaseWrapper, IMobileRTCAuthDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCAuthDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onMobileRTCAuthReturn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnMobileRTCAuthReturn (MobileRTCAuthError returnValue)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onMobileRTCAuthReturn:"), (UIntPtr) (ulong) returnValue);
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_MobileRTCAuthDelegate", false)]
	[Model]
	public unsafe abstract partial class MobileRTCAuthDelegate : NSObject, IMobileRTCAuthDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MobileRTCAuthDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCAuthDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCAuthDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onMobileRTCAuthExpired")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnMobileRTCAuthExpired ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onMobileRTCAuthReturn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void OnMobileRTCAuthReturn (MobileRTCAuthError returnValue);
		[Export ("onMobileRTCLoginResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnMobileRTCLoginResult (MobileRTCLoginFailReason resultValue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onMobileRTCLogoutReturn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnMobileRTCLogoutReturn (nint returnValue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MobileRTCAuthDelegate */
}
