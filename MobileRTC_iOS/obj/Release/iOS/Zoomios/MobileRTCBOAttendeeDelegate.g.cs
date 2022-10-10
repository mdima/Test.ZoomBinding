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
	[Protocol (Name = "MobileRTCBOAttendeeDelegate", WrapperType = typeof (MobileRTCBOAttendeeDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnHelpRequestHandleResultReceived", Selector = "onHelpRequestHandleResultReceived:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCBOHelpReply) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnHostJoinedThisBOMeeting", Selector = "onHostJoinedThisBOMeeting")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnHostLeaveThisBOMeeting", Selector = "onHostLeaveThisBOMeeting")]
	public partial interface IMobileRTCBOAttendeeDelegate : INativeObject, IDisposable, 
		Zoomios.IIMobileRTCMeetingServiceDelegate
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onHelpRequestHandleResultReceived:")]
		[Preserve (Conditional = true)]
		void OnHelpRequestHandleResultReceived (MobileRTCBOHelpReply eResult);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onHostJoinedThisBOMeeting")]
		[Preserve (Conditional = true)]
		void OnHostJoinedThisBOMeeting ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onHostLeaveThisBOMeeting")]
		[Preserve (Conditional = true)]
		void OnHostLeaveThisBOMeeting ();
	}
	internal sealed class MobileRTCBOAttendeeDelegateWrapper : BaseWrapper, IMobileRTCBOAttendeeDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCBOAttendeeDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onHelpRequestHandleResultReceived:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnHelpRequestHandleResultReceived (MobileRTCBOHelpReply eResult)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onHelpRequestHandleResultReceived:"), (UIntPtr) (ulong) eResult);
		}
		[Export ("onHostJoinedThisBOMeeting")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnHostJoinedThisBOMeeting ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onHostJoinedThisBOMeeting"));
		}
		[Export ("onHostLeaveThisBOMeeting")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnHostLeaveThisBOMeeting ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onHostLeaveThisBOMeeting"));
		}
	}
}
