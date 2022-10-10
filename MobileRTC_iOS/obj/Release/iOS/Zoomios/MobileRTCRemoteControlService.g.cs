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
	[Register("MobileRTCRemoteControlService", true)]
	public unsafe partial class MobileRTCRemoteControlService : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCRemoteControlService");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCRemoteControlService () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCRemoteControlService (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCRemoteControlService (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("grabRemoteControl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRemoteControlError GrabRemoteControl (global::UIKit.UIView remoteShareView)
		{
			var remoteShareView__handle__ = remoteShareView!.GetNonNullHandle (nameof (remoteShareView));
			MobileRTCRemoteControlError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("grabRemoteControl:"), remoteShareView__handle__);
			} else {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("grabRemoteControl:"), remoteShareView__handle__);
			}
			return ret!;
		}
		[Export ("remoteControlCharInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRemoteControlError RemoteControlCharInput (string str)
		{
			if (str is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (str));
			var nsstr = CFString.CreateNative (str);
			MobileRTCRemoteControlError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("remoteControlCharInput:"), nsstr);
			} else {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("remoteControlCharInput:"), nsstr);
			}
			CFString.ReleaseNative (nsstr);
			return ret!;
		}
		[Export ("remoteControlDoubleScroll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRemoteControlError RemoteControlDoubleScroll (CGPoint point)
		{
			MobileRTCRemoteControlError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("remoteControlDoubleScroll:"), point);
			} else {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("remoteControlDoubleScroll:"), point);
			}
			return ret!;
		}
		[Export ("remoteControlDoubleTap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRemoteControlError RemoteControlDoubleTap (CGPoint point)
		{
			MobileRTCRemoteControlError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("remoteControlDoubleTap:"), point);
			} else {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("remoteControlDoubleTap:"), point);
			}
			return ret!;
		}
		[Export ("remoteControlKeyInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRemoteControlError RemoteControlKeyInput (MobileRTCRemoteControlInputType key)
		{
			MobileRTCRemoteControlError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("remoteControlKeyInput:"), (UInt32)key);
			} else {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("remoteControlKeyInput:"), (UInt32)key);
			}
			return ret!;
		}
		[Export ("remoteControlLongPress:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRemoteControlError RemoteControlLongPress (CGPoint point)
		{
			MobileRTCRemoteControlError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("remoteControlLongPress:"), point);
			} else {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("remoteControlLongPress:"), point);
			}
			return ret!;
		}
		[Export ("remoteControlMouseLeftDown:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRemoteControlError RemoteControlMouseLeftDown (CGPoint point)
		{
			MobileRTCRemoteControlError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("remoteControlMouseLeftDown:"), point);
			} else {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("remoteControlMouseLeftDown:"), point);
			}
			return ret!;
		}
		[Export ("remoteControlMouseLeftDrag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRemoteControlError RemoteControlMouseLeftDrag (CGPoint point)
		{
			MobileRTCRemoteControlError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("remoteControlMouseLeftDrag:"), point);
			} else {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("remoteControlMouseLeftDrag:"), point);
			}
			return ret!;
		}
		[Export ("remoteControlMouseLeftUp:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRemoteControlError RemoteControlMouseLeftUp (CGPoint point)
		{
			MobileRTCRemoteControlError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("remoteControlMouseLeftUp:"), point);
			} else {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("remoteControlMouseLeftUp:"), point);
			}
			return ret!;
		}
		[Export ("remoteControlSingleMove:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRemoteControlError RemoteControlSingleMove (CGPoint point)
		{
			MobileRTCRemoteControlError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("remoteControlSingleMove:"), point);
			} else {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("remoteControlSingleMove:"), point);
			}
			return ret!;
		}
		[Export ("remoteControlSingleTap:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRemoteControlError RemoteControlSingleTap (CGPoint point)
		{
			MobileRTCRemoteControlError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_CGPoint (this.Handle, Selector.GetHandle ("remoteControlSingleTap:"), point);
			} else {
				ret = (Zoomios.MobileRTCRemoteControlError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_CGPoint (this.SuperHandle, Selector.GetHandle ("remoteControlSingleTap:"), point);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MobileRTCRemoteControlDelegate Delegate {
			get {
				return (WeakDelegate as MobileRTCRemoteControlDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsHaveRemoteControlRight {
			[Export ("isHaveRemoteControlRight")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isHaveRemoteControlRight"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isHaveRemoteControlRight"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsRemoteController {
			[Export ("isRemoteController")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRemoteController"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRemoteController"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakDelegate {
			[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("delegate")))!;
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("delegate")))!;
				}
				MarkDirty ();
				__mt_WeakDelegate_var = ret;
				return ret!;
			}
			[Export ("setDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDelegate:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDelegate:"), value__handle__);
				}
				MarkDirty ();
				__mt_WeakDelegate_var = value;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class MobileRTCRemoteControlService */
}
