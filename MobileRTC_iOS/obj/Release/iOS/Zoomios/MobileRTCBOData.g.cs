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
	[Register("MobileRTCBOData", true)]
	public unsafe partial class MobileRTCBOData : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCBOData");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCBOData () : base (NSObjectFlag.Empty)
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
		protected MobileRTCBOData (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCBOData (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("getBOMeetingByID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCBOMeeting? GetBOMeetingByID (string boId)
		{
			if (boId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boId));
			var nsboId = CFString.CreateNative (boId);
			MobileRTCBOMeeting? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MobileRTCBOMeeting> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getBOMeetingByID:"), nsboId))!;
			} else {
				ret =  Runtime.GetNSObject<MobileRTCBOMeeting> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getBOMeetingByID:"), nsboId))!;
			}
			CFString.ReleaseNative (nsboId);
			return ret!;
		}
		[Export ("getBOUserByUserID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCBOUser? GetBOUserByUserID (string userId)
		{
			if (userId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userId));
			var nsuserId = CFString.CreateNative (userId);
			MobileRTCBOUser? ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<MobileRTCBOUser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getBOUserByUserID:"), nsuserId))!;
			} else {
				ret =  Runtime.GetNSObject<MobileRTCBOUser> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getBOUserByUserID:"), nsuserId))!;
			}
			CFString.ReleaseNative (nsuserId);
			return ret!;
		}
		[Export ("isBOUserMyself:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsBOUserMyself (string boUserId)
		{
			if (boUserId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boUserId));
			var nsboUserId = CFString.CreateNative (boUserId);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("isBOUserMyself:"), nsboUserId);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("isBOUserMyself:"), nsboUserId);
			}
			CFString.ReleaseNative (nsboUserId);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[]? BOMeetingIDList {
			[Export ("getBOMeetingIDList")]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getBOMeetingIDList")))!;
				} else {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getBOMeetingIDList")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? CurrentBOName {
			[Export ("getCurrentBOName")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getCurrentBOName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getCurrentBOName")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject[]? UnassignedUserList {
			[Export ("getUnassignedUserList")]
			get {
				NSObject[]? ret;
				if (IsDirectBinding) {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getUnassignedUserList")))!;
				} else {
					ret = CFArray.ArrayFromHandle<NSObject>(global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getUnassignedUserList")))!;
				}
				return ret!;
			}
		}
	} /* class MobileRTCBOData */
}
