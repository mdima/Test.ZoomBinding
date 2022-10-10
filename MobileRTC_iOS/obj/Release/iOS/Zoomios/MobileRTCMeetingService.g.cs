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
	[Register("MobileRTCMeetingService", true)]
	public unsafe partial class MobileRTCMeetingService : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingService");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCMeetingService () : base (NSObjectFlag.Empty)
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
		protected MobileRTCMeetingService (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCMeetingService (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("handZoomWebUrl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCMeetError HandZoomWebUrl (string meetingUrl)
		{
			if (meetingUrl is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (meetingUrl));
			var nsmeetingUrl = CFString.CreateNative (meetingUrl);
			MobileRTCMeetError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("handZoomWebUrl:"), nsmeetingUrl);
			} else {
				ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("handZoomWebUrl:"), nsmeetingUrl);
			}
			CFString.ReleaseNative (nsmeetingUrl);
			return ret!;
		}
		[Export ("joinMeetingWithJoinParam:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCMeetError JoinMeetingWithJoinParam (MobileRTCMeetingJoinParam param)
		{
			var param__handle__ = param!.GetNonNullHandle (nameof (param));
			MobileRTCMeetError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("joinMeetingWithJoinParam:"), param__handle__);
			} else {
				ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("joinMeetingWithJoinParam:"), param__handle__);
			}
			return ret!;
		}
		[Export ("leaveMeetingWithCmd:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void LeaveMeetingWithCmd (LeaveMeetingCmd cmd)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("leaveMeetingWithCmd:"), (UIntPtr) (ulong) cmd);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("leaveMeetingWithCmd:"), (UIntPtr) (ulong) cmd);
			}
		}
		[Export ("setCustomizedInvitationDomain:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SetCustomizedInvitationDomain (string invitationDomain)
		{
			if (invitationDomain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (invitationDomain));
			var nsinvitationDomain = CFString.CreateNative (invitationDomain);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustomizedInvitationDomain:"), nsinvitationDomain);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCustomizedInvitationDomain:"), nsinvitationDomain);
			}
			CFString.ReleaseNative (nsinvitationDomain);
			return ret!;
		}
		[Export ("startMeetingWithStartParam:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCMeetError StartMeetingWithStartParam (MobileRTCMeetingStartParam param)
		{
			var param__handle__ = param!.GetNonNullHandle (nameof (param));
			MobileRTCMeetError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("startMeetingWithStartParam:"), param__handle__);
			} else {
				ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("startMeetingWithStartParam:"), param__handle__);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MobileRTCCustomizedUIMeetingDelegate? CustomizedUImeetingDelegate {
			get {
				return (WeakCustomizedUImeetingDelegate as MobileRTCCustomizedUIMeetingDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakCustomizedUImeetingDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public IMobileRTCMeetingServiceDelegate? Delegate {
			get {
				return (WeakDelegate as IMobileRTCMeetingServiceDelegate)!;
			}
			set {
				var rvalue = value as NSObject;
				if (!(value is null) && rvalue is null)
					throw new ArgumentException ("The object passed of type " + value.GetType () + " does not derive from NSObject");
				WeakDelegate = rvalue;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCMeetingState MeetingState {
			[Export ("getMeetingState")]
			get {
				MobileRTCMeetingState ret;
				if (IsDirectBinding) {
					ret = (Zoomios.MobileRTCMeetingState) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getMeetingState"));
				} else {
					ret = (Zoomios.MobileRTCMeetingState) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getMeetingState"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UIView? MeetingView {
			[Export ("meetingView")]
			get {
				global::UIKit.UIView? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("meetingView")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("meetingView")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		object? __mt_WeakCustomizedUImeetingDelegate_var;
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSObject? WeakCustomizedUImeetingDelegate {
			[Export ("customizedUImeetingDelegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				NSObject? ret;
				if (IsDirectBinding) {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("customizedUImeetingDelegate")))!;
				} else {
					ret = Runtime.GetNSObject (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("customizedUImeetingDelegate")))!;
				}
				MarkDirty ();
				__mt_WeakCustomizedUImeetingDelegate_var = ret;
				return ret!;
			}
			[Export ("setCustomizedUImeetingDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setCustomizedUImeetingDelegate:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setCustomizedUImeetingDelegate:"), value__handle__);
				}
				MarkDirty ();
				__mt_WeakCustomizedUImeetingDelegate_var = value;
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
		public virtual MobileRTCWebinarRegistLegalNoticeContent? WebinarRegistrationLegalNoticesExplained {
			[Export ("getWebinarRegistrationLegalNoticesExplained")]
			get {
				MobileRTCWebinarRegistLegalNoticeContent? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MobileRTCWebinarRegistLegalNoticeContent> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getWebinarRegistrationLegalNoticesExplained")))!;
				} else {
					ret =  Runtime.GetNSObject<MobileRTCWebinarRegistLegalNoticeContent> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getWebinarRegistrationLegalNoticesExplained")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? WebinarRegistrationLegalNoticesPrompt {
			[Export ("getWebinarRegistrationLegalNoticesPrompt")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getWebinarRegistrationLegalNoticesPrompt")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getWebinarRegistrationLegalNoticesPrompt")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_WeakCustomizedUImeetingDelegate_var = null;
				__mt_WeakDelegate_var = null;
			}
		}
	} /* class MobileRTCMeetingService */
}
