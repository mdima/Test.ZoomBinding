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
	[Protocol (Name = "MobileRTCSMSServiceDelegate", WrapperType = typeof (MobileRTCSMSServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnNeedRealNameAuth", Selector = "onNeedRealNameAuth:privacyURL:retrieveHandle:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCRealNameCountryInfo[]), typeof (string), typeof (Zoomios.MobileRTCRetrieveSMSHandler) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnRetrieveSMSVerificationCodeResultNotification", Selector = "onRetrieveSMSVerificationCodeResultNotification:verifyHandle:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCSMSRetrieveResult), typeof (Zoomios.MobileRTCVerifySMSHandler) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnVerifySMSVerificationCodeResultNotification", Selector = "onVerifySMSVerificationCodeResultNotification:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCSMSVerifyResult) }, ParameterByRef = new bool [] { false })]
	public partial interface IMobileRTCSMSServiceDelegate : INativeObject, IDisposable
	{
	}
	public static partial class MobileRTCSMSServiceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnNeedRealNameAuth (this IMobileRTCSMSServiceDelegate This, MobileRTCRealNameCountryInfo[] supportCountryList, string privacyUrl, MobileRTCRetrieveSMSHandler handle)
		{
			if (supportCountryList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (supportCountryList));
			if (privacyUrl is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (privacyUrl));
			var handle__handle__ = handle!.GetNonNullHandle (nameof (handle));
			var nsa_supportCountryList = NSArray.FromNSObjects (supportCountryList);
			var nsprivacyUrl = CFString.CreateNative (privacyUrl);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onNeedRealNameAuth:privacyURL:retrieveHandle:"), nsa_supportCountryList.Handle, nsprivacyUrl, handle__handle__);
			nsa_supportCountryList.Dispose ();
			CFString.ReleaseNative (nsprivacyUrl);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnRetrieveSMSVerificationCodeResultNotification (this IMobileRTCSMSServiceDelegate This, MobileRTCSMSRetrieveResult result, MobileRTCVerifySMSHandler handler)
		{
			var handler__handle__ = handler!.GetNonNullHandle (nameof (handler));
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_IntPtr (This.Handle, Selector.GetHandle ("onRetrieveSMSVerificationCodeResultNotification:verifyHandle:"), (UIntPtr) (ulong) result, handler__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnVerifySMSVerificationCodeResultNotification (this IMobileRTCSMSServiceDelegate This, MobileRTCSMSVerifyResult result)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onVerifySMSVerificationCodeResultNotification:"), (UIntPtr) (ulong) result);
		}
	}
	internal sealed class MobileRTCSMSServiceDelegateWrapper : BaseWrapper, IMobileRTCSMSServiceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCSMSServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_MobileRTCSMSServiceDelegate", false)]
	[Model]
	public unsafe partial class MobileRTCSMSServiceDelegate : NSObject, IMobileRTCSMSServiceDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCSMSServiceDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCSMSServiceDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCSMSServiceDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onNeedRealNameAuth:privacyURL:retrieveHandle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnNeedRealNameAuth (MobileRTCRealNameCountryInfo[] supportCountryList, string privacyUrl, MobileRTCRetrieveSMSHandler handle)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onRetrieveSMSVerificationCodeResultNotification:verifyHandle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnRetrieveSMSVerificationCodeResultNotification (MobileRTCSMSRetrieveResult result, MobileRTCVerifySMSHandler handler)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		[Export ("onVerifySMSVerificationCodeResultNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void OnVerifySMSVerificationCodeResultNotification (MobileRTCSMSVerifyResult result)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
	} /* class MobileRTCSMSServiceDelegate */
}
