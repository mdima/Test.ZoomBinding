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
	[Register("MobileRTCPreviewVideoView", true)]
	public unsafe partial class MobileRTCPreviewVideoView : MobileRTCVideoView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCPreviewVideoView");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCPreviewVideoView () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public MobileRTCPreviewVideoView (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCPreviewVideoView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCPreviewVideoView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		public partial class MobileRTCPreviewVideoViewAppearance : global::Zoomios.MobileRTCVideoView.MobileRTCVideoViewAppearance {
			protected internal MobileRTCPreviewVideoViewAppearance (IntPtr handle) : base (handle) {}
		}
		public static new MobileRTCPreviewVideoViewAppearance Appearance {
			get { return new MobileRTCPreviewVideoViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		public static new MobileRTCPreviewVideoViewAppearance GetAppearance<T> () where T: MobileRTCPreviewVideoView {
			return new MobileRTCPreviewVideoViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		public static new MobileRTCPreviewVideoViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MobileRTCPreviewVideoViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		public static new MobileRTCPreviewVideoViewAppearance GetAppearance (UITraitCollection traits) {
			return new MobileRTCPreviewVideoViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		public static new MobileRTCPreviewVideoViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MobileRTCPreviewVideoViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		public static new MobileRTCPreviewVideoViewAppearance GetAppearance<T> (UITraitCollection traits) where T: MobileRTCPreviewVideoView {
			return new MobileRTCPreviewVideoViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		public static new MobileRTCPreviewVideoViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MobileRTCPreviewVideoView{
			return new MobileRTCPreviewVideoViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class MobileRTCPreviewVideoView */
}
