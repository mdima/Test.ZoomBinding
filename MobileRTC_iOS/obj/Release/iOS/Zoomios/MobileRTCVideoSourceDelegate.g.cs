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
	[Protocol (Name = "MobileRTCVideoSourceDelegate", WrapperType = typeof (MobileRTCVideoSourceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnInitialize", Selector = "onInitialize:supportCapabilityArray:suggestCapabilityItem:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCVideoSender), typeof (NSObject[]), typeof (Zoomios.MobileRTCVideoCapabilityItem) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnPropertyChange", Selector = "onPropertyChange:suggestCapabilityItem:", ParameterType = new Type [] { typeof (NSObject[]), typeof (Zoomios.MobileRTCVideoCapabilityItem) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnStartSend", Selector = "onStartSend")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnStopSend", Selector = "onStopSend")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnUninitialized", Selector = "onUninitialized")]
	public partial interface IMobileRTCVideoSourceDelegate : INativeObject, IDisposable
	{
	}
	public static partial class MobileRTCVideoSourceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnInitialize (this IMobileRTCVideoSourceDelegate This, MobileRTCVideoSender rawDataSender, NSObject[] supportCapabilityArray, MobileRTCVideoCapabilityItem suggestCapabilityItem)
		{
			var rawDataSender__handle__ = rawDataSender!.GetNonNullHandle (nameof (rawDataSender));
			if (supportCapabilityArray is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (supportCapabilityArray));
			var suggestCapabilityItem__handle__ = suggestCapabilityItem!.GetNonNullHandle (nameof (suggestCapabilityItem));
			var nsa_supportCapabilityArray = NSArray.FromNSObjects (supportCapabilityArray);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onInitialize:supportCapabilityArray:suggestCapabilityItem:"), rawDataSender__handle__, nsa_supportCapabilityArray.Handle, suggestCapabilityItem__handle__);
			nsa_supportCapabilityArray.Dispose ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnPropertyChange (this IMobileRTCVideoSourceDelegate This, NSObject[] supportCapabilityArray, MobileRTCVideoCapabilityItem suggestCapabilityItem)
		{
			if (supportCapabilityArray is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (supportCapabilityArray));
			var suggestCapabilityItem__handle__ = suggestCapabilityItem!.GetNonNullHandle (nameof (suggestCapabilityItem));
			var nsa_supportCapabilityArray = NSArray.FromNSObjects (supportCapabilityArray);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onPropertyChange:suggestCapabilityItem:"), nsa_supportCapabilityArray.Handle, suggestCapabilityItem__handle__);
			nsa_supportCapabilityArray.Dispose ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnStartSend (this IMobileRTCVideoSourceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onStartSend"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnStopSend (this IMobileRTCVideoSourceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onStopSend"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnUninitialized (this IMobileRTCVideoSourceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onUninitialized"));
		}
	}
	internal sealed class MobileRTCVideoSourceDelegateWrapper : BaseWrapper, IMobileRTCVideoSourceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCVideoSourceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_MobileRTCVideoSourceDelegate", false)]
	[Model]
	public unsafe partial class MobileRTCVideoSourceDelegate : NSObject, IMobileRTCVideoSourceDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCVideoSourceDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCVideoSourceDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCVideoSourceDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onInitialize:supportCapabilityArray:suggestCapabilityItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnInitialize (MobileRTCVideoSender rawDataSender, NSObject[] supportCapabilityArray, MobileRTCVideoCapabilityItem suggestCapabilityItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onPropertyChange:suggestCapabilityItem:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnPropertyChange (NSObject[] supportCapabilityArray, MobileRTCVideoCapabilityItem suggestCapabilityItem)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onStartSend")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnStartSend ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onStopSend")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnStopSend ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onUninitialized")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnUninitialized ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MobileRTCVideoSourceDelegate */
}
