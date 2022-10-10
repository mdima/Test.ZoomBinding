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
	[Register("MobileRTCAnnotationService", true)]
	public unsafe partial class MobileRTCAnnotationService : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCAnnotationService");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCAnnotationService () : base (NSObjectFlag.Empty)
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
		protected MobileRTCAnnotationService (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCAnnotationService (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("disableViewerAnnoataion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCAnnotationError DisableViewerAnnoataion (bool isDisable)
		{
			MobileRTCAnnotationError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_bool (this.Handle, Selector.GetHandle ("disableViewerAnnoataion:"), isDisable);
			} else {
				ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("disableViewerAnnoataion:"), isDisable);
			}
			return ret!;
		}
		[Export ("getToolColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIColor? GetToolColor (MobileRTCAnnoTool tooltype)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("getToolColor:"), (UInt32)tooltype))!;
			} else {
				return  Runtime.GetNSObject<global::UIKit.UIColor> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("getToolColor:"), (UInt32)tooltype))!;
			}
		}
		[Export ("setToolColor:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCAnnotationError SetToolColor (global::UIKit.UIColor? toolColor)
		{
			var toolColor__handle__ = toolColor.GetHandle ();
			MobileRTCAnnotationError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setToolColor:"), toolColor__handle__);
			} else {
				ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setToolColor:"), toolColor__handle__);
			}
			return ret!;
		}
		[Export ("setToolType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCAnnotationError SetToolType (MobileRTCAnnoTool type)
		{
			MobileRTCAnnotationError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_UInt32 (this.Handle, Selector.GetHandle ("setToolType:"), (UInt32)type);
			} else {
				ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_UInt32 (this.SuperHandle, Selector.GetHandle ("setToolType:"), (UInt32)type);
			}
			return ret!;
		}
		[Export ("setToolWidth:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCAnnotationError SetToolWidth (nuint width)
		{
			MobileRTCAnnotationError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setToolWidth:"), (UIntPtr) width);
			} else {
				ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("setToolWidth:"), (UIntPtr) width);
			}
			return ret!;
		}
		[Export ("startAnnotationWithSharedView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCAnnotationError StartAnnotationWithSharedView (global::UIKit.UIView? view)
		{
			var view__handle__ = view.GetHandle ();
			MobileRTCAnnotationError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("startAnnotationWithSharedView:"), view__handle__);
			} else {
				ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("startAnnotationWithSharedView:"), view__handle__);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AnnotationLegalNoticesExplained {
			[Export ("getAnnotationLegalNoticesExplained")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAnnotationLegalNoticesExplained")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAnnotationLegalNoticesExplained")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? AnnotationLegalNoticesPrompt {
			[Export ("getAnnotationLegalNoticesPrompt")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAnnotationLegalNoticesPrompt")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAnnotationLegalNoticesPrompt")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanDisableViewerAnnoataion {
			[Export ("canDisableViewerAnnoataion")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canDisableViewerAnnoataion"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canDisableViewerAnnoataion"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanDoAnnotation {
			[Export ("canDoAnnotation")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canDoAnnotation"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canDoAnnotation"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCAnnotationError Clear {
			[Export ("clear")]
			get {
				MobileRTCAnnotationError ret;
				if (IsDirectBinding) {
					ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("clear"));
				} else {
					ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clear"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MobileRTCAnnotationServiceDelegate? Delegate {
			get {
				return (WeakDelegate as MobileRTCAnnotationServiceDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsAnnotationLegalNoticeAvailable {
			[Export ("isAnnotationLegalNoticeAvailable")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isAnnotationLegalNoticeAvailable"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isAnnotationLegalNoticeAvailable"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPresenter {
			[Export ("isPresenter")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPresenter"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPresenter"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsViewerAnnoataionDisabled {
			[Export ("isViewerAnnoataionDisabled")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isViewerAnnoataionDisabled"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isViewerAnnoataionDisabled"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCAnnotationError Redo {
			[Export ("redo")]
			get {
				MobileRTCAnnotationError ret;
				if (IsDirectBinding) {
					ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("redo"));
				} else {
					ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("redo"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StopAnnotation {
			[Export ("stopAnnotation")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("stopAnnotation"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopAnnotation"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[]? SupportedToolType {
			[Export ("getSupportedToolType")]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getSupportedToolType")))!;
				} else {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getSupportedToolType")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCAnnotationError Undo {
			[Export ("undo")]
			get {
				MobileRTCAnnotationError ret;
				if (IsDirectBinding) {
					ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("undo"));
				} else {
					ret = (Zoomios.MobileRTCAnnotationError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("undo"));
				}
				return ret!;
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
	} /* class MobileRTCAnnotationService */
}
