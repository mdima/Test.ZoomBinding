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
	[Register("MobileRTCVideoView", true)]
	public unsafe partial class MobileRTCVideoView : global::UIKit.UIView {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCVideoView");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCVideoView () : base (NSObjectFlag.Empty)
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
		public MobileRTCVideoView (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected MobileRTCVideoView (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCVideoView (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setVideoAspect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetVideoAspect (MobileRTCVideoAspect aspect)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setVideoAspect:"), (UInt32)aspect);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setVideoAspect:"), (UInt32)aspect);
			}
		}
		[Export ("showAttendeeVideoWithUserID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowAttendeeVideoWithUserID (nuint userID)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("showAttendeeVideoWithUserID:"), (UIntPtr) userID);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("showAttendeeVideoWithUserID:"), (UIntPtr) userID);
			}
		}
		[Export ("stopAttendeeVideo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void StopAttendeeVideo ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("stopAttendeeVideo"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopAttendeeVideo"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nint UserID {
			[Export ("getUserID")]
			get {
				if (IsDirectBinding) {
					return (nint) global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getUserID"));
				} else {
					return (nint) global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getUserID"));
				}
			}
		}
		public partial class MobileRTCVideoViewAppearance : global::UIKit.UIView.UIViewAppearance {
			protected internal MobileRTCVideoViewAppearance (IntPtr handle) : base (handle) {}
		}
		public static new MobileRTCVideoViewAppearance Appearance {
			get { return new MobileRTCVideoViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		public static new MobileRTCVideoViewAppearance GetAppearance<T> () where T: MobileRTCVideoView {
			return new MobileRTCVideoViewAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		public static new MobileRTCVideoViewAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new MobileRTCVideoViewAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		public static new MobileRTCVideoViewAppearance GetAppearance (UITraitCollection traits) {
			return new MobileRTCVideoViewAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		public static new MobileRTCVideoViewAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new MobileRTCVideoViewAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		public static new MobileRTCVideoViewAppearance GetAppearance<T> (UITraitCollection traits) where T: MobileRTCVideoView {
			return new MobileRTCVideoViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		public static new MobileRTCVideoViewAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: MobileRTCVideoView{
			return new MobileRTCVideoViewAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
	} /* class MobileRTCVideoView */
}
