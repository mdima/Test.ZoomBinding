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
	[Protocol (Name = "MobileRTCBOServiceDelegate", WrapperType = typeof (MobileRTCBOServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnHasCreatorRightsNotification", Selector = "onHasCreatorRightsNotification:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCBOCreator) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnHasAdminRightsNotification", Selector = "onHasAdminRightsNotification:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCBOAdmin) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnHasAssistantRightsNotification", Selector = "onHasAssistantRightsNotification:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCBOAssistant) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnHasAttendeeRightsNotification", Selector = "onHasAttendeeRightsNotification:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCBOAttendee) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnHasDataHelperRightsNotification", Selector = "onHasDataHelperRightsNotification:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCBOData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnLostCreatorRightsNotification", Selector = "onLostCreatorRightsNotification")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnLostAdminRightsNotification", Selector = "onLostAdminRightsNotification")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnLostAssistantRightsNotification", Selector = "onLostAssistantRightsNotification")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnLostAttendeeRightsNotification", Selector = "onLostAttendeeRightsNotification")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnLostDataHelperRightsNotification", Selector = "onLostDataHelperRightsNotification")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnNewBroadcastMessageReceived", Selector = "onNewBroadcastMessageReceived:senderID:", ParameterType = new Type [] { typeof (string), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnBOStopCountDown", Selector = "onBOStopCountDown:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnHostInviteReturnToMainSession", Selector = "onHostInviteReturnToMainSession:replyHandler:", ParameterType = new Type [] { typeof (string), typeof (Zoomios.MobileRTCReturnToMainSessionHandler) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnBOStatusChanged", Selector = "onBOStatusChanged:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCBOStatus) }, ParameterByRef = new bool [] { false })]
	public partial interface IMobileRTCBOServiceDelegate : INativeObject, IDisposable, 
		Zoomios.IIMobileRTCMeetingServiceDelegate
	{
	}
	public static partial class MobileRTCBOServiceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnHasCreatorRightsNotification (this IMobileRTCBOServiceDelegate This, MobileRTCBOCreator creator)
		{
			var creator__handle__ = creator!.GetNonNullHandle (nameof (creator));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onHasCreatorRightsNotification:"), creator__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnHasAdminRightsNotification (this IMobileRTCBOServiceDelegate This, MobileRTCBOAdmin admin)
		{
			var admin__handle__ = admin!.GetNonNullHandle (nameof (admin));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onHasAdminRightsNotification:"), admin__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnHasAssistantRightsNotification (this IMobileRTCBOServiceDelegate This, MobileRTCBOAssistant assistant)
		{
			var assistant__handle__ = assistant!.GetNonNullHandle (nameof (assistant));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onHasAssistantRightsNotification:"), assistant__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnHasAttendeeRightsNotification (this IMobileRTCBOServiceDelegate This, MobileRTCBOAttendee attendee)
		{
			var attendee__handle__ = attendee!.GetNonNullHandle (nameof (attendee));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onHasAttendeeRightsNotification:"), attendee__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnHasDataHelperRightsNotification (this IMobileRTCBOServiceDelegate This, MobileRTCBOData dataHelper)
		{
			var dataHelper__handle__ = dataHelper!.GetNonNullHandle (nameof (dataHelper));
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onHasDataHelperRightsNotification:"), dataHelper__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnLostCreatorRightsNotification (this IMobileRTCBOServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onLostCreatorRightsNotification"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnLostAdminRightsNotification (this IMobileRTCBOServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onLostAdminRightsNotification"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnLostAssistantRightsNotification (this IMobileRTCBOServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onLostAssistantRightsNotification"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnLostAttendeeRightsNotification (this IMobileRTCBOServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onLostAttendeeRightsNotification"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnLostDataHelperRightsNotification (this IMobileRTCBOServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onLostDataHelperRightsNotification"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnNewBroadcastMessageReceived (this IMobileRTCBOServiceDelegate This, string? broadcastMsg, nuint senderID)
		{
			var nsbroadcastMsg = CFString.CreateNative (broadcastMsg);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UIntPtr (This.Handle, Selector.GetHandle ("onNewBroadcastMessageReceived:senderID:"), nsbroadcastMsg, (UIntPtr) senderID);
			CFString.ReleaseNative (nsbroadcastMsg);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnBOStopCountDown (this IMobileRTCBOServiceDelegate This, nuint seconds)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onBOStopCountDown:"), (UIntPtr) seconds);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnHostInviteReturnToMainSession (this IMobileRTCBOServiceDelegate This, string? hostName, MobileRTCReturnToMainSessionHandler? replyHandler)
		{
			var replyHandler__handle__ = replyHandler.GetHandle ();
			var nshostName = CFString.CreateNative (hostName);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onHostInviteReturnToMainSession:replyHandler:"), nshostName, replyHandler__handle__);
			CFString.ReleaseNative (nshostName);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnBOStatusChanged (this IMobileRTCBOServiceDelegate This, MobileRTCBOStatus status)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onBOStatusChanged:"), (UIntPtr) (ulong) status);
		}
	}
	internal sealed class MobileRTCBOServiceDelegateWrapper : BaseWrapper, IMobileRTCBOServiceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCBOServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
