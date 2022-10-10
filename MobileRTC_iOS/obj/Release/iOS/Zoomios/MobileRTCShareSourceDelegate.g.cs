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
	[Protocol (Name = "MobileRTCShareSourceDelegate", WrapperType = typeof (MobileRTCShareSourceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnStartSend", Selector = "onStartSend:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCShareSender) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnStopSend", Selector = "onStopSend")]
	public partial interface IMobileRTCShareSourceDelegate : INativeObject, IDisposable
	{
	}
	public static partial class MobileRTCShareSourceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnStartSend (this IMobileRTCShareSourceDelegate This, MobileRTCShareSender sender)
		{
			var sender__handle__ = sender!.GetNonNullHandle (nameof (sender));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onStartSend:"), sender__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnStopSend (this IMobileRTCShareSourceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onStopSend"));
		}
	}
	internal sealed class MobileRTCShareSourceDelegateWrapper : BaseWrapper, IMobileRTCShareSourceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCShareSourceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_MobileRTCShareSourceDelegate", false)]
	[Model]
	public unsafe partial class MobileRTCShareSourceDelegate : NSObject, IMobileRTCShareSourceDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCShareSourceDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCShareSourceDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCShareSourceDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onStartSend:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnStartSend (MobileRTCShareSender sender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onStopSend")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnStopSend ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MobileRTCShareSourceDelegate */
}
