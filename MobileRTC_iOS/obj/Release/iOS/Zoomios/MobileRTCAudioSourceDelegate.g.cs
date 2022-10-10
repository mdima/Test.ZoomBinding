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
	[Protocol (Name = "MobileRTCAudioSourceDelegate", WrapperType = typeof (MobileRTCAudioSourceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnDeviceInitialize", Selector = "onDeviceInitialize:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCAudioSender) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnStartSendData", Selector = "onStartSendData")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnStopSendData", Selector = "onStopSendData")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnDeviceUninitialize", Selector = "onDeviceUninitialize")]
	public partial interface IMobileRTCAudioSourceDelegate : INativeObject, IDisposable
	{
	}
	public static partial class MobileRTCAudioSourceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnDeviceInitialize (this IMobileRTCAudioSourceDelegate This, MobileRTCAudioSender rawdataSender)
		{
			var rawdataSender__handle__ = rawdataSender!.GetNonNullHandle (nameof (rawdataSender));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onDeviceInitialize:"), rawdataSender__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnStartSendData (this IMobileRTCAudioSourceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onStartSendData"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnStopSendData (this IMobileRTCAudioSourceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onStopSendData"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnDeviceUninitialize (this IMobileRTCAudioSourceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onDeviceUninitialize"));
		}
	}
	internal sealed class MobileRTCAudioSourceDelegateWrapper : BaseWrapper, IMobileRTCAudioSourceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCAudioSourceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_MobileRTCAudioSourceDelegate", false)]
	[Model]
	public unsafe partial class MobileRTCAudioSourceDelegate : NSObject, IMobileRTCAudioSourceDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCAudioSourceDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCAudioSourceDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCAudioSourceDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onDeviceInitialize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnDeviceInitialize (MobileRTCAudioSender rawdataSender)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onDeviceUninitialize")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnDeviceUninitialize ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onStartSendData")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnStartSendData ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onStopSendData")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnStopSendData ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MobileRTCAudioSourceDelegate */
}
