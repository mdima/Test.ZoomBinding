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
	[Register("MobileRTCBOAdmin", true)]
	public unsafe partial class MobileRTCBOAdmin : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCBOAdmin");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCBOAdmin () : base (NSObjectFlag.Empty)
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
		protected MobileRTCBOAdmin (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCBOAdmin (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("assignNewUser:toRunningBO:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AssignNewUser (string boUserId, string boId)
		{
			if (boUserId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boUserId));
			if (boId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boId));
			var nsboUserId = CFString.CreateNative (boUserId);
			var nsboId = CFString.CreateNative (boId);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("assignNewUser:toRunningBO:"), nsboUserId, nsboId);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("assignNewUser:toRunningBO:"), nsboUserId, nsboId);
			}
			CFString.ReleaseNative (nsboUserId);
			CFString.ReleaseNative (nsboId);
			return ret!;
		}
		[Export ("broadcastMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BroadcastMessage (string strMsg)
		{
			if (strMsg is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (strMsg));
			var nsstrMsg = CFString.CreateNative (strMsg);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("broadcastMessage:"), nsstrMsg);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("broadcastMessage:"), nsstrMsg);
			}
			CFString.ReleaseNative (nsstrMsg);
			return ret!;
		}
		[Export ("ignoreUserHelpRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IgnoreUserHelpRequest (string boUserId)
		{
			if (boUserId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boUserId));
			var nsboUserId = CFString.CreateNative (boUserId);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("ignoreUserHelpRequest:"), nsboUserId);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("ignoreUserHelpRequest:"), nsboUserId);
			}
			CFString.ReleaseNative (nsboUserId);
			return ret!;
		}
		[Export ("inviteBOUserReturnToMainSession:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool InviteBOUserReturnToMainSession (string boUserId)
		{
			if (boUserId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boUserId));
			var nsboUserId = CFString.CreateNative (boUserId);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("inviteBOUserReturnToMainSession:"), nsboUserId);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("inviteBOUserReturnToMainSession:"), nsboUserId);
			}
			CFString.ReleaseNative (nsboUserId);
			return ret!;
		}
		[Export ("joinBOByUserRequest:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool JoinBOByUserRequest (string boUserId)
		{
			if (boUserId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boUserId));
			var nsboUserId = CFString.CreateNative (boUserId);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("joinBOByUserRequest:"), nsboUserId);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("joinBOByUserRequest:"), nsboUserId);
			}
			CFString.ReleaseNative (nsboUserId);
			return ret!;
		}
		[Export ("switchUser:toRunningBO:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SwitchUser (string boUserId, string boId)
		{
			if (boUserId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boUserId));
			if (boId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boId));
			var nsboUserId = CFString.CreateNative (boUserId);
			var nsboId = CFString.CreateNative (boId);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("switchUser:toRunningBO:"), nsboUserId, nsboId);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("switchUser:toRunningBO:"), nsboUserId, nsboId);
			}
			CFString.ReleaseNative (nsboUserId);
			CFString.ReleaseNative (nsboId);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanStartBO {
			[Export ("canStartBO")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canStartBO"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canStartBO"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StartBO {
			[Export ("startBO")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("startBO"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startBO"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool StopBO {
			[Export ("stopBO")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("stopBO"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopBO"));
				}
			}
		}
	} /* class MobileRTCBOAdmin */
}
