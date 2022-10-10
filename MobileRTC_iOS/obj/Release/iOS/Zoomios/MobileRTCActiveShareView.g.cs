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
	[Register("MobileRTCActiveShareView", true)]
	public unsafe partial class MobileRTCActiveShareView : MobileRTCVideoView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCActiveShareView");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCActiveShareView () : base (NSObjectFlag.Empty)
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
		public MobileRTCActiveShareView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MobileRTCActiveShareView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCActiveShareView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("changeShareScaleWithUserID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ChangeShareScaleWithUserID (nuint userID)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("changeShareScaleWithUserID:"), (UIntPtr) userID);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("changeShareScaleWithUserID:"), (UIntPtr) userID);
			}
		}
		[Export ("showActiveShareWithUserID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ShowActiveShareWithUserID (nuint userID)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("showActiveShareWithUserID:"), (UIntPtr) userID);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("showActiveShareWithUserID:"), (UIntPtr) userID);
			}
		}
		[Export ("stopActiveShare")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopActiveShare ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopActiveShare"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopActiveShare"));
			}
		}
		public partial class MobileRTCActiveShareViewAppearance : global::Zoomios.MobileRTCVideoView.MobileRTCVideoViewAppearance {
			protected internal MobileRTCActiveShareViewAppearance (IntPtr handle) : base (handle) {}
		}
		public static new MobileRTCActiveShareViewAppearance Appearance {
			get { return new MobileRTCActiveShareViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		public static new MobileRTCActiveShareViewAppearance GetAppearance<T> () where T: MobileRTCActiveShareView {
			return new MobileRTCActiveShareViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		public static new MobileRTCActiveShareViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MobileRTCActiveShareViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		public static new MobileRTCActiveShareViewAppearance GetAppearance (UITraitCollection traits) {
			return new MobileRTCActiveShareViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		public static new MobileRTCActiveShareViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MobileRTCActiveShareViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		public static new MobileRTCActiveShareViewAppearance GetAppearance<T> (UITraitCollection traits) where T: MobileRTCActiveShareView {
			return new MobileRTCActiveShareViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		public static new MobileRTCActiveShareViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MobileRTCActiveShareView{
			return new MobileRTCActiveShareViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class MobileRTCActiveShareView */
}
