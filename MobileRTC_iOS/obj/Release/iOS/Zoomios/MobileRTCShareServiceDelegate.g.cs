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
	[Protocol (Name = "MobileRTCShareServiceDelegate", WrapperType = typeof (MobileRTCShareServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnAppShareSplash", Selector = "onAppShareSplash")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingActiveShare", Selector = "onSinkMeetingActiveShare:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingShareReceiving", Selector = "onSinkMeetingShareReceiving:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkSharingStatus", Selector = "onSinkSharingStatus:userID:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCSharingStatus), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkShareSettingTypeChanged", Selector = "onSinkShareSettingTypeChanged:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCShareSettingType) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkShareSizeChange", Selector = "onSinkShareSizeChange:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	public partial interface IMobileRTCShareServiceDelegate : INativeObject, IDisposable, 
		Zoomios.IIMobileRTCMeetingServiceDelegate
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onAppShareSplash")]
		[Preserve (Conditional = true)]
		void OnAppShareSplash ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingActiveShare:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingActiveShare (nuint userID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingShareReceiving:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingShareReceiving (nuint userID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkSharingStatus:userID:")]
		[Preserve (Conditional = true)]
		void OnSinkSharingStatus (MobileRTCSharingStatus status, nuint userID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkShareSettingTypeChanged:")]
		[Preserve (Conditional = true)]
		void OnSinkShareSettingTypeChanged (MobileRTCShareSettingType shareSettingType);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkShareSizeChange:")]
		[Preserve (Conditional = true)]
		void OnSinkShareSizeChange (nuint userID);
	}
	internal sealed class MobileRTCShareServiceDelegateWrapper : BaseWrapper, IMobileRTCShareServiceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCShareServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onAppShareSplash")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnAppShareSplash ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onAppShareSplash"));
		}
		[Export ("onSinkMeetingActiveShare:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingActiveShare (nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingActiveShare:"), (UIntPtr) userID);
		}
		[Export ("onSinkMeetingShareReceiving:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingShareReceiving (nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingShareReceiving:"), (UIntPtr) userID);
		}
		[Export ("onSinkSharingStatus:userID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkSharingStatus (MobileRTCSharingStatus status, nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("onSinkSharingStatus:userID:"), (UIntPtr) (ulong) status, (UIntPtr) userID);
		}
		[Export ("onSinkShareSettingTypeChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkShareSettingTypeChanged (MobileRTCShareSettingType shareSettingType)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkShareSettingTypeChanged:"), (UIntPtr) (ulong) shareSettingType);
		}
		[Export ("onSinkShareSizeChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkShareSizeChange (nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkShareSizeChange:"), (UIntPtr) userID);
		}
	}
}
