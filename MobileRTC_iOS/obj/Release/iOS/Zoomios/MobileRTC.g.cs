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
	[Register("MobileRTC", true)]
	public unsafe partial class MobileRTC : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTC");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTC () : base (NSObjectFlag.Empty)
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
		protected MobileRTC (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTC (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("appDidBecomeActive")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppDidBecomeActive ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("appDidBecomeActive"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("appDidBecomeActive"));
			}
		}
		[Export ("appDidEnterBackgroud")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppDidEnterBackgroud ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("appDidEnterBackgroud"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("appDidEnterBackgroud"));
			}
		}
		[Export ("appWillResignActive")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppWillResignActive ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("appWillResignActive"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("appWillResignActive"));
			}
		}
		[Export ("appWillTerminate")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void AppWillTerminate ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("appWillTerminate"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("appWillTerminate"));
			}
		}
		[Export ("getAnnotationService")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCAnnotationService? GetAnnotationService ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MobileRTCAnnotationService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAnnotationService")))!;
			} else {
				return  Runtime.GetNSObject<MobileRTCAnnotationService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAnnotationService")))!;
			}
		}
		[Export ("getAuthService")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCAuthService? GetAuthService ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MobileRTCAuthService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAuthService")))!;
			} else {
				return  Runtime.GetNSObject<MobileRTCAuthService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAuthService")))!;
			}
		}
		[Export ("getDirectShareService")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCDirectShareService? GetDirectShareService ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MobileRTCDirectShareService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDirectShareService")))!;
			} else {
				return  Runtime.GetNSObject<MobileRTCDirectShareService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDirectShareService")))!;
			}
		}
		[Export ("getMeetingService")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCMeetingService? GetMeetingService ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MobileRTCMeetingService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getMeetingService")))!;
			} else {
				return  Runtime.GetNSObject<MobileRTCMeetingService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getMeetingService")))!;
			}
		}
		[Export ("getMeetingSettings")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCMeetingSettings? GetMeetingSettings ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MobileRTCMeetingSettings> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getMeetingSettings")))!;
			} else {
				return  Runtime.GetNSObject<MobileRTCMeetingSettings> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getMeetingSettings")))!;
			}
		}
		[Export ("getRemoteControlService")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRemoteControlService? GetRemoteControlService ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MobileRTCRemoteControlService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getRemoteControlService")))!;
			} else {
				return  Runtime.GetNSObject<MobileRTCRemoteControlService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getRemoteControlService")))!;
			}
		}
		[Export ("getSMSService")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCSMSService? GetSMSService ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MobileRTCSMSService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getSMSService")))!;
			} else {
				return  Runtime.GetNSObject<MobileRTCSMSService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getSMSService")))!;
			}
		}
		[Export ("getShareSourceHelper")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCShareSourceHelper? GetShareSourceHelper ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MobileRTCShareSourceHelper> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getShareSourceHelper")))!;
			} else {
				return  Runtime.GetNSObject<MobileRTCShareSourceHelper> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getShareSourceHelper")))!;
			}
		}
		[Export ("getVideoSourceHelper")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCVideoSourceHelper? GetVideoSourceHelper ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MobileRTCVideoSourceHelper> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getVideoSourceHelper")))!;
			} else {
				return  Runtime.GetNSObject<MobileRTCVideoSourceHelper> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getVideoSourceHelper")))!;
			}
		}
		[Export ("getWaitingRoomService")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCWaitingRoomService? GetWaitingRoomService ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<MobileRTCWaitingRoomService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getWaitingRoomService")))!;
			} else {
				return  Runtime.GetNSObject<MobileRTCWaitingRoomService> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getWaitingRoomService")))!;
			}
		}
		[Export ("hasRawDataLicense")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HasRawDataLicense ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hasRawDataLicense"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hasRawDataLicense"));
			}
		}
		[Export ("initialize:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Initialize (MobileRTCSDKInitContext context)
		{
			var context__handle__ = context!.GetNonNullHandle (nameof (context));
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initialize:"), context__handle__);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initialize:"), context__handle__);
			}
		}
		[Export ("isRTCAuthorized")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsRTCAuthorized ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isRTCAuthorized"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isRTCAuthorized"));
			}
		}
		[Export ("isSupportedCustomizeMeetingUI")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsSupportedCustomizeMeetingUI ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isSupportedCustomizeMeetingUI"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isSupportedCustomizeMeetingUI"));
			}
		}
		[Export ("mobileRTCVersion")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? MobileRTCVersion ()
		{
			if (IsDirectBinding) {
				return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mobileRTCVersion")))!;
			} else {
				return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mobileRTCVersion")))!;
			}
		}
		[Export ("setLanguage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetLanguage (string? lang)
		{
			var nslang = CFString.CreateNative (lang);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setLanguage:"), nslang);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setLanguage:"), nslang);
			}
			CFString.ReleaseNative (nslang);
		}
		[Export ("setMobileRTCCustomLocalizableName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMobileRTCCustomLocalizableName (string? localizableName)
		{
			var nslocalizableName = CFString.CreateNative (localizableName);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMobileRTCCustomLocalizableName:"), nslocalizableName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMobileRTCCustomLocalizableName:"), nslocalizableName);
			}
			CFString.ReleaseNative (nslocalizableName);
		}
		[Export ("supportedLanguages")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string[] SupportedLanguages ()
		{
			if (IsDirectBinding) {
				return CFArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("supportedLanguages")))!;
			} else {
				return CFArray.StringArrayFromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("supportedLanguages")))!;
			}
		}
		[Export ("switchDomain:force:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SwitchDomain (string newDomain, bool force)
		{
			if (newDomain is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (newDomain));
			var nsnewDomain = CFString.CreateNative (newDomain);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("switchDomain:force:"), nsnewDomain, force);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("switchDomain:force:"), nsnewDomain, force);
			}
			CFString.ReleaseNative (nsnewDomain);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? MobileRTCCustomLocalizableName {
			[Export ("mobileRTCCustomLocalizableName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mobileRTCCustomLocalizableName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mobileRTCCustomLocalizableName")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? MobileRTCDomain {
			[Export ("mobileRTCDomain", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mobileRTCDomain")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mobileRTCDomain")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? MobileRTCResPath {
			[Export ("mobileRTCResPath", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mobileRTCResPath")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mobileRTCResPath")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::UIKit.UINavigationController? MobileRTCRootController {
			[Export ("mobileRTCRootController")]
			get {
				global::UIKit.UINavigationController? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UINavigationController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("mobileRTCRootController")))!;
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UINavigationController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("mobileRTCRootController")))!;
				}
				return ret!;
			}
			[Export ("setMobileRTCRootController:")]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setMobileRTCRootController:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setMobileRTCRootController:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTC SharedRTC {
			[Export ("sharedRTC")]
			get {
				MobileRTC? ret;
				ret =  Runtime.GetNSObject<MobileRTC> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("sharedRTC")))!;
				return ret!;
			}
		}
	} /* class MobileRTC */
}
