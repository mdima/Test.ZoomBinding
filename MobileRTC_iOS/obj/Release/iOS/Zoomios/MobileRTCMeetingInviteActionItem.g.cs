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
	[Register("MobileRTCMeetingInviteActionItem", true)]
	public unsafe partial class MobileRTCMeetingInviteActionItem : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingInviteActionItem");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCMeetingInviteActionItem () : base (NSObjectFlag.Empty)
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
		protected MobileRTCMeetingInviteActionItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCMeetingInviteActionItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("itemWithTitle:Action:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static NSObject ItemWithTitle (string inTitle, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMobileRTCMeetingInviteActionItemBlock))]MobileRTCMeetingInviteActionItemBlock actionHandler)
		{
			if (inTitle is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (inTitle));
			if (actionHandler is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (actionHandler));
			var nsinTitle = CFString.CreateNative (inTitle);
			BlockLiteral *block_ptr_actionHandler;
			BlockLiteral block_actionHandler;
			block_actionHandler = new BlockLiteral ();
			block_ptr_actionHandler = &block_actionHandler;
			block_actionHandler.SetupBlockUnsafe (Trampolines.SDMobileRTCMeetingInviteActionItemBlock.Handler, actionHandler);
			NSObject? ret;
			ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("itemWithTitle:Action:"), nsinTitle, (IntPtr) block_ptr_actionHandler))!;
			CFString.ReleaseNative (nsinTitle);
			block_ptr_actionHandler->CleanupBlock ();
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual MobileRTCMeetingInviteActionItemBlock ActionHandler {
			[return: DelegateProxy (typeof (ObjCRuntime.Trampolines.SDMobileRTCMeetingInviteActionItemBlock))]
			[Export ("actionHandler", ArgumentSemantic.Copy)]
			get {
				IntPtr ret;
				if (IsDirectBinding) {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("actionHandler"));
				} else {
					ret = global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("actionHandler"));
				}
				return global::ObjCRuntime.Trampolines.NIDMobileRTCMeetingInviteActionItemBlock.Create (ret)!;
			}
			[param: BlockProxy (typeof (ObjCRuntime.Trampolines.NIDMobileRTCMeetingInviteActionItemBlock))]
			[Export ("setActionHandler:", ArgumentSemantic.Copy)]
			set {
				if (value is null)
					ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (value));
				BlockLiteral *block_ptr_value;
				BlockLiteral block_value;
				block_value = new BlockLiteral ();
				block_ptr_value = &block_value;
				block_value.SetupBlockUnsafe (Trampolines.SDMobileRTCMeetingInviteActionItemBlock.Handler, value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setActionHandler:"), (IntPtr) block_ptr_value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setActionHandler:"), (IntPtr) block_ptr_value);
				}
				block_ptr_value->CleanupBlock ();
			}
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
	} /* class MobileRTCMeetingInviteActionItem */
}
