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
	[Protocol (Name = "MobileRTCRemoteControlDelegate", WrapperType = typeof (MobileRTCRemoteControlDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RemoteControlPrivilegeChanged", Selector = "remoteControlPrivilegeChanged:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "StartRemoteControlCallBack", Selector = "startRemoteControlCallBack:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCRemoteControlError) }, ParameterByRef = new bool [] { false })]
	public partial interface IMobileRTCRemoteControlDelegate : INativeObject, IDisposable
	{
	}
	public static partial class MobileRTCRemoteControlDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoteControlPrivilegeChanged (this IMobileRTCRemoteControlDelegate This, bool isMyControl)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("remoteControlPrivilegeChanged:"), isMyControl);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void StartRemoteControlCallBack (this IMobileRTCRemoteControlDelegate This, MobileRTCRemoteControlError resultValue)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("startRemoteControlCallBack:"), (UIntPtr) (ulong) resultValue);
		}
	}
	internal sealed class MobileRTCRemoteControlDelegateWrapper : BaseWrapper, IMobileRTCRemoteControlDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCRemoteControlDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_MobileRTCRemoteControlDelegate", false)]
	[Model]
	public unsafe partial class MobileRTCRemoteControlDelegate : NSObject, IMobileRTCRemoteControlDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCRemoteControlDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCRemoteControlDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCRemoteControlDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("remoteControlPrivilegeChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RemoteControlPrivilegeChanged (bool isMyControl)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("startRemoteControlCallBack:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StartRemoteControlCallBack (MobileRTCRemoteControlError resultValue)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MobileRTCRemoteControlDelegate */
}
