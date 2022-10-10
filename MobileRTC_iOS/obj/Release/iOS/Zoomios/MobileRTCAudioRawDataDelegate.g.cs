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
	[Protocol (Name = "MobileRTCAudioRawDataDelegate", WrapperType = typeof (MobileRTCAudioRawDataDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnMobileRTCMixedAudioRawData", Selector = "onMobileRTCMixedAudioRawData:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCAudioRawData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnMobileRTCOneWayAudioAudioRawData", Selector = "onMobileRTCOneWayAudioAudioRawData:userId:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCAudioRawData), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IMobileRTCAudioRawDataDelegate : INativeObject, IDisposable
	{
	}
	public static partial class MobileRTCAudioRawDataDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnMobileRTCMixedAudioRawData (this IMobileRTCAudioRawDataDelegate This, MobileRTCAudioRawData rawData)
		{
			var rawData__handle__ = rawData!.GetNonNullHandle (nameof (rawData));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onMobileRTCMixedAudioRawData:"), rawData__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnMobileRTCOneWayAudioAudioRawData (this IMobileRTCAudioRawDataDelegate This, MobileRTCAudioRawData rawData, nuint userId)
		{
			var rawData__handle__ = rawData!.GetNonNullHandle (nameof (rawData));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("onMobileRTCOneWayAudioAudioRawData:userId:"), rawData__handle__, (UIntPtr) userId);
		}
	}
	internal sealed class MobileRTCAudioRawDataDelegateWrapper : BaseWrapper, IMobileRTCAudioRawDataDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCAudioRawDataDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_MobileRTCAudioRawDataDelegate", false)]
	[Model]
	public unsafe partial class MobileRTCAudioRawDataDelegate : NSObject, IMobileRTCAudioRawDataDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCAudioRawDataDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCAudioRawDataDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCAudioRawDataDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onMobileRTCMixedAudioRawData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnMobileRTCMixedAudioRawData (MobileRTCAudioRawData rawData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onMobileRTCOneWayAudioAudioRawData:userId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnMobileRTCOneWayAudioAudioRawData (MobileRTCAudioRawData rawData, nuint userId)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MobileRTCAudioRawDataDelegate */
}
