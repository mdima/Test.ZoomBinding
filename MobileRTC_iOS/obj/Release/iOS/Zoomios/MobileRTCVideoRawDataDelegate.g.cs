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
	[Protocol (Name = "MobileRTCVideoRawDataDelegate", WrapperType = typeof (MobileRTCVideoRawDataDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FramePixelBuffer", Selector = "onMobileRTCRender:framePixelBuffer:rotation:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCRenderer), typeof (CVPixelBuffer), typeof (Zoomios.MobileRTCVideoRawDataRotation) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "FrameRawData", Selector = "onMobileRTCRender:frameRawData:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCRenderer), typeof (Zoomios.MobileRTCVideoRawData) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RawDataSending", Selector = "onMobileRTCRender:rawDataSending:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCRenderer), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IMobileRTCVideoRawDataDelegate : INativeObject, IDisposable
	{
	}
	public static partial class MobileRTCVideoRawDataDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FramePixelBuffer (this IMobileRTCVideoRawDataDelegate This, MobileRTCRenderer renderer, global::CoreVideo.CVPixelBuffer? pixelBuffer, MobileRTCVideoRawDataRotation rotation)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var pixelBuffer__handle__ = pixelBuffer.GetHandle ();
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onMobileRTCRender:framePixelBuffer:rotation:"), renderer__handle__, pixelBuffer__handle__, (IntPtr) (long) rotation);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FrameRawData (this IMobileRTCVideoRawDataDelegate This, MobileRTCRenderer renderer, MobileRTCVideoRawData rawData)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			var rawData__handle__ = rawData!.GetNonNullHandle (nameof (rawData));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onMobileRTCRender:frameRawData:"), renderer__handle__, rawData__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RawDataSending (this IMobileRTCVideoRawDataDelegate This, MobileRTCRenderer renderer, bool on)
		{
			var renderer__handle__ = renderer!.GetNonNullHandle (nameof (renderer));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("onMobileRTCRender:rawDataSending:"), renderer__handle__, on);
		}
	}
	internal sealed class MobileRTCVideoRawDataDelegateWrapper : BaseWrapper, IMobileRTCVideoRawDataDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCVideoRawDataDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_MobileRTCVideoRawDataDelegate", false)]
	[Model]
	public unsafe partial class MobileRTCVideoRawDataDelegate : NSObject, IMobileRTCVideoRawDataDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCVideoRawDataDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCVideoRawDataDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCVideoRawDataDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onMobileRTCRender:framePixelBuffer:rotation:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FramePixelBuffer (MobileRTCRenderer renderer, global::CoreVideo.CVPixelBuffer? pixelBuffer, MobileRTCVideoRawDataRotation rotation)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onMobileRTCRender:frameRawData:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void FrameRawData (MobileRTCRenderer renderer, MobileRTCVideoRawData rawData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onMobileRTCRender:rawDataSending:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RawDataSending (MobileRTCRenderer renderer, bool on)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MobileRTCVideoRawDataDelegate */
}
