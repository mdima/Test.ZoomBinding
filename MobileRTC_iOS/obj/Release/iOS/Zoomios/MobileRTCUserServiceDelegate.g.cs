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
	[Protocol (Name = "MobileRTCUserServiceDelegate", WrapperType = typeof (MobileRTCUserServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnMyHandStateChange", Selector = "onMyHandStateChange")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnInMeetingUserUpdated", Selector = "onInMeetingUserUpdated")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingUserJoin", Selector = "onSinkMeetingUserJoin:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingUserLeft", Selector = "onSinkMeetingUserLeft:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingUserRaiseHand", Selector = "onSinkMeetingUserRaiseHand:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingUserLowerHand", Selector = "onSinkMeetingUserLowerHand:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkLowerAllHands", Selector = "onSinkLowerAllHands")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkUserNameChanged", Selector = "onSinkUserNameChanged:userName:", ParameterType = new Type [] { typeof (nuint), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkUserNameChanged", Selector = "onSinkUserNameChanged:", ParameterType = new Type [] { typeof (NSNumber[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnMeetingHostChange", Selector = "onMeetingHostChange:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnMeetingCoHostChange", Selector = "onMeetingCoHostChange:isCoHost:", ParameterType = new Type [] { typeof (nuint), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnClaimHostResult", Selector = "onClaimHostResult:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCClaimHostError) }, ParameterByRef = new bool [] { false })]
	public partial interface IMobileRTCUserServiceDelegate : INativeObject, IDisposable, 
		Zoomios.IIMobileRTCMeetingServiceDelegate
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onMyHandStateChange")]
		[Preserve (Conditional = true)]
		void OnMyHandStateChange ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onInMeetingUserUpdated")]
		[Preserve (Conditional = true)]
		void OnInMeetingUserUpdated ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingUserJoin:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingUserJoin (nuint userID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingUserLeft:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingUserLeft (nuint userID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingUserRaiseHand:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingUserRaiseHand (nuint userID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingUserLowerHand:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingUserLowerHand (nuint userID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkLowerAllHands")]
		[Preserve (Conditional = true)]
		void OnSinkLowerAllHands ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkUserNameChanged:userName:")]
		[Preserve (Conditional = true)]
		void OnSinkUserNameChanged (nuint userID, string userName);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkUserNameChanged:")]
		[Preserve (Conditional = true)]
		void OnSinkUserNameChanged (NSNumber[]? userNameChangedArr);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onMeetingHostChange:")]
		[Preserve (Conditional = true)]
		void OnMeetingHostChange (nuint hostId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onMeetingCoHostChange:isCoHost:")]
		[Preserve (Conditional = true)]
		void OnMeetingCoHostChange (nuint userID, bool isCoHost);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onClaimHostResult:")]
		[Preserve (Conditional = true)]
		void OnClaimHostResult (MobileRTCClaimHostError error);
	}
	internal sealed class MobileRTCUserServiceDelegateWrapper : BaseWrapper, IMobileRTCUserServiceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCUserServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onMyHandStateChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnMyHandStateChange ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onMyHandStateChange"));
		}
		[Export ("onInMeetingUserUpdated")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnInMeetingUserUpdated ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onInMeetingUserUpdated"));
		}
		[Export ("onSinkMeetingUserJoin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingUserJoin (nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingUserJoin:"), (UIntPtr) userID);
		}
		[Export ("onSinkMeetingUserLeft:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingUserLeft (nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingUserLeft:"), (UIntPtr) userID);
		}
		[Export ("onSinkMeetingUserRaiseHand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingUserRaiseHand (nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingUserRaiseHand:"), (UIntPtr) userID);
		}
		[Export ("onSinkMeetingUserLowerHand:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingUserLowerHand (nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingUserLowerHand:"), (UIntPtr) userID);
		}
		[Export ("onSinkLowerAllHands")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkLowerAllHands ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onSinkLowerAllHands"));
		}
		[Export ("onSinkUserNameChanged:userName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkUserNameChanged (nuint userID, string userName)
		{
			if (userName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (userName));
			var nsuserName = CFString.CreateNative (userName);
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("onSinkUserNameChanged:userName:"), (UIntPtr) userID, nsuserName);
			CFString.ReleaseNative (nsuserName);
		}
		[Export ("onSinkUserNameChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkUserNameChanged (NSNumber[]? userNameChangedArr)
		{
			var nsa_userNameChangedArr = userNameChangedArr is null ? null : NSArray.FromNSObjects (userNameChangedArr);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSinkUserNameChanged:"), nsa_userNameChangedArr.GetHandle ());
			if (nsa_userNameChangedArr != null)
				nsa_userNameChangedArr.Dispose ();
		}
		[Export ("onMeetingHostChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnMeetingHostChange (nuint hostId)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onMeetingHostChange:"), (UIntPtr) hostId);
		}
		[Export ("onMeetingCoHostChange:isCoHost:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnMeetingCoHostChange (nuint userID, bool isCoHost)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_bool (this.Handle, Selector.GetHandle ("onMeetingCoHostChange:isCoHost:"), (UIntPtr) userID, isCoHost);
		}
		[Export ("onClaimHostResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnClaimHostResult (MobileRTCClaimHostError error)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onClaimHostResult:"), (UIntPtr) (ulong) error);
		}
	}
}
