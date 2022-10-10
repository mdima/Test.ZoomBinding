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
	[Register("MobileRTCMeetingShareActionItem", true)]
	public unsafe partial class MobileRTCMeetingShareActionItem : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingShareActionItem");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCMeetingShareActionItem () : base (NSObjectFlag.Empty)
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
		protected MobileRTCMeetingShareActionItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCMeetingShareActionItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("itemWithTitle:Tag:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static NSObject ItemWithTitle (string inTitle, nuint tag)
		{
			if (inTitle is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inTitle));
			var nsinTitle = CFString.CreateNative (inTitle);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_UIntPtr (class_ptr, Selector.GetHandle ("itemWithTitle:Tag:"), nsinTitle, (UIntPtr) tag))!;
			CFString.ReleaseNative (nsinTitle);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string ActionTitle {
			[Export ("actionTitle", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("actionTitle")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actionTitle")))!;
				}
			}
			[Export ("setActionTitle:", ArgumentSemantic.Retain)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setActionTitle:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setActionTitle:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MobileRTCMeetingShareActionItemDelegate Delegate {
			get {
				return (WeakDelegate as MobileRTCMeetingShareActionItemDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint Tag {
			[Export ("tag")]
			get {
				if (IsDirectBinding) {
					return (nuint) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("tag"));
				} else {
					return (nuint) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("tag"));
				}
			}
			[Export ("setTag:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setTag:"), (UIntPtr) value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("setTag:"), (UIntPtr) value);
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
	} /* class MobileRTCMeetingShareActionItem */
}
