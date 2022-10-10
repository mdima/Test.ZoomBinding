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
	[Protocol (Name = "MobileRTCWaitingRoomServiceDelegate", WrapperType = typeof (MobileRTCWaitingRoomServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnWaitingRoomUserJoin", Selector = "onWaitingRoomUserJoin:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnWaitingRoomUserLeft", Selector = "onWaitingRoomUserLeft:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	public partial interface IMobileRTCWaitingRoomServiceDelegate : INativeObject, IDisposable
	{
	}
	public static partial class MobileRTCWaitingRoomServiceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnWaitingRoomUserJoin (this IMobileRTCWaitingRoomServiceDelegate This, nuint userId)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onWaitingRoomUserJoin:"), (UIntPtr) userId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnWaitingRoomUserLeft (this IMobileRTCWaitingRoomServiceDelegate This, nuint userId)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onWaitingRoomUserLeft:"), (UIntPtr) userId);
		}
	}
	internal sealed class MobileRTCWaitingRoomServiceDelegateWrapper : BaseWrapper, IMobileRTCWaitingRoomServiceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCWaitingRoomServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_MobileRTCWaitingRoomServiceDelegate", false)]
	[Model]
	public unsafe partial class MobileRTCWaitingRoomServiceDelegate : NSObject, IMobileRTCWaitingRoomServiceDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCWaitingRoomServiceDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCWaitingRoomServiceDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCWaitingRoomServiceDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onWaitingRoomUserJoin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnWaitingRoomUserJoin (nuint userId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onWaitingRoomUserLeft:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnWaitingRoomUserLeft (nuint userId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MobileRTCWaitingRoomServiceDelegate */
}
