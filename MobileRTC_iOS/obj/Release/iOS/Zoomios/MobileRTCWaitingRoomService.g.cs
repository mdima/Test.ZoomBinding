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
	[Register("MobileRTCWaitingRoomService", true)]
	public unsafe partial class MobileRTCWaitingRoomService : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCWaitingRoomService");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCWaitingRoomService () : base (NSObjectFlag.Empty)
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
		protected MobileRTCWaitingRoomService (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCWaitingRoomService (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("admitToMeeting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AdmitToMeeting (nuint userId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("admitToMeeting:"), (UIntPtr) userId);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("admitToMeeting:"), (UIntPtr) userId);
			}
		}
		[Export ("enableWaitingRoomOnEntry:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCMeetError EnableWaitingRoomOnEntry (bool bEnable)
		{
			MobileRTCMeetError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_bool (this.Handle, Selector.GetHandle ("enableWaitingRoomOnEntry:"), bEnable);
			} else {
				ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("enableWaitingRoomOnEntry:"), bEnable);
			}
			return ret!;
		}
		[Export ("putInWaitingRoom:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PutInWaitingRoom (nuint userId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("putInWaitingRoom:"), (UIntPtr) userId);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("putInWaitingRoom:"), (UIntPtr) userId);
			}
		}
		[Export ("waitingRoomUserInfoByID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCMeetingUserInfo? WaitingRoomUserInfoByID (nuint userId)
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MobileRTCMeetingUserInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("waitingRoomUserInfoByID:"), (UIntPtr) userId))!;
			} else {
				return  Runtime.GetNSObject<MobileRTCMeetingUserInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("waitingRoomUserInfoByID:"), (UIntPtr) userId))!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MobileRTCWaitingRoomServiceDelegate? Delegate {
			get {
				return (WeakDelegate as MobileRTCWaitingRoomServiceDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSupportWaitingRoom {
			[Export ("isSupportWaitingRoom")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSupportWaitingRoom"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSupportWaitingRoom"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsWaitingRoomOnEntryFlagOn {
			[Export ("isWaitingRoomOnEntryFlagOn")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isWaitingRoomOnEntryFlagOn"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isWaitingRoomOnEntryFlagOn"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSNumber[]? WaitingRoomList {
			[Export ("waitingRoomList")]
			get {
				NSNumber[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("waitingRoomList")))!;
				} else {
					ret = CFArray.ArrayFromHandle<NSNumber>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("waitingRoomList")))!;
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
	} /* class MobileRTCWaitingRoomService */
}
