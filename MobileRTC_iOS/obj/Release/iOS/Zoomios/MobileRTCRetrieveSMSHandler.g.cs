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
	[Register("MobileRTCRetrieveSMSHandler", true)]
	public unsafe partial class MobileRTCRetrieveSMSHandler : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCRetrieveSMSHandler");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCRetrieveSMSHandler () : base (NSObjectFlag.Empty)
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
		protected MobileRTCRetrieveSMSHandler (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCRetrieveSMSHandler (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("retrieve:andPhoneNumber:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Retrieve (string? countryCode, string? phoneNum)
		{
			var nscountryCode = CFString.CreateNative (countryCode);
			var nsphoneNum = CFString.CreateNative (phoneNum);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("retrieve:andPhoneNumber:"), nscountryCode, nsphoneNum);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("retrieve:andPhoneNumber:"), nscountryCode, nsphoneNum);
			}
			CFString.ReleaseNative (nscountryCode);
			CFString.ReleaseNative (nsphoneNum);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CancelAndLeaveMeeting {
			[Export ("cancelAndLeaveMeeting")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("cancelAndLeaveMeeting"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cancelAndLeaveMeeting"));
				}
			}
		}
	} /* class MobileRTCRetrieveSMSHandler */
}
