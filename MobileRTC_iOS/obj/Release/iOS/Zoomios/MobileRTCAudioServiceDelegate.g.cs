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
	[Protocol (Name = "MobileRTCAudioServiceDelegate", WrapperType = typeof (MobileRTCAudioServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingAudioStatusChange", Selector = "onSinkMeetingAudioStatusChange:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingMyAudioTypeChange", Selector = "onSinkMeetingMyAudioTypeChange")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingAudioTypeChange", Selector = "onSinkMeetingAudioTypeChange:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingAudioStatusChange", Selector = "onSinkMeetingAudioStatusChange:audioStatus:", ParameterType = new Type [] { typeof (nuint), typeof (Zoomios.MobileRTC_AudioStatus) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnAudioOutputChange", Selector = "onAudioOutputChange")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnMyAudioStateChange", Selector = "onMyAudioStateChange")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingAudioRequestUnmuteByHost", Selector = "onSinkMeetingAudioRequestUnmuteByHost")]
	public partial interface IMobileRTCAudioServiceDelegate : INativeObject, IDisposable, 
		Zoomios.IIMobileRTCMeetingServiceDelegate
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingAudioStatusChange:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingAudioStatusChange (nuint userID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingMyAudioTypeChange")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingMyAudioTypeChange ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingAudioTypeChange:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingAudioTypeChange (nuint userID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingAudioStatusChange:audioStatus:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingAudioStatusChange (nuint userID, MobileRTC_AudioStatus audioStatus);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onAudioOutputChange")]
		[Preserve (Conditional = true)]
		void OnAudioOutputChange ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onMyAudioStateChange")]
		[Preserve (Conditional = true)]
		void OnMyAudioStateChange ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingAudioRequestUnmuteByHost")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingAudioRequestUnmuteByHost ();
	}
	internal sealed class MobileRTCAudioServiceDelegateWrapper : BaseWrapper, IMobileRTCAudioServiceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCAudioServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onSinkMeetingAudioStatusChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingAudioStatusChange (nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingAudioStatusChange:"), (UIntPtr) userID);
		}
		[Export ("onSinkMeetingMyAudioTypeChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingMyAudioTypeChange ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onSinkMeetingMyAudioTypeChange"));
		}
		[Export ("onSinkMeetingAudioTypeChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingAudioTypeChange (nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingAudioTypeChange:"), (UIntPtr) userID);
		}
		[Export ("onSinkMeetingAudioStatusChange:audioStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingAudioStatusChange (nuint userID, MobileRTC_AudioStatus audioStatus)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingAudioStatusChange:audioStatus:"), (UIntPtr) userID, (UIntPtr) (ulong) audioStatus);
		}
		[Export ("onAudioOutputChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnAudioOutputChange ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onAudioOutputChange"));
		}
		[Export ("onMyAudioStateChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnMyAudioStateChange ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onMyAudioStateChange"));
		}
		[Export ("onSinkMeetingAudioRequestUnmuteByHost")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingAudioRequestUnmuteByHost ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onSinkMeetingAudioRequestUnmuteByHost"));
		}
	}
}
