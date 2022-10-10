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
	[Protocol (Name = "MobileRTCWebinarServiceDelegate", WrapperType = typeof (MobileRTCWebinarServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkQAConnectStarted", Selector = "onSinkQAConnectStarted")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkQAConnected", Selector = "onSinkQAConnected:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkQAOpenQuestionChanged", Selector = "onSinkQAOpenQuestionChanged:", ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkQAAddQuestion", Selector = "onSinkQAAddQuestion:success:", ParameterType = new Type [] { typeof (string), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkQAAddAnswer", Selector = "onSinkQAAddAnswer:success:", ParameterType = new Type [] { typeof (string), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkQuestionMarkedAsDismissed", Selector = "onSinkQuestionMarkedAsDismissed:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkReopenQuestion", Selector = "onSinkReopenQuestion:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkReceiveQuestion", Selector = "onSinkReceiveQuestion:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkReceiveAnswer", Selector = "onSinkReceiveAnswer:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkUserLivingReply", Selector = "onSinkUserLivingReply:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkUserEndLiving", Selector = "onSinkUserEndLiving:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkVoteupQuestion", Selector = "onSinkVoteupQuestion:orderChanged:", ParameterType = new Type [] { typeof (string), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkRevokeVoteupQuestion", Selector = "onSinkRevokeVoteupQuestion:orderChanged:", ParameterType = new Type [] { typeof (string), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkDeleteQuestion", Selector = "onSinkDeleteQuestion:", ParameterType = new Type [] { typeof (NSObject[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkDeleteAnswer", Selector = "onSinkDeleteAnswer:", ParameterType = new Type [] { typeof (NSObject[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkQAAllowAskQuestionAnonymouslyNotification", Selector = "onSinkQAAllowAskQuestionAnonymouslyNotification:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkQAAllowAttendeeViewAllQuestionNotification", Selector = "onSinkQAAllowAttendeeViewAllQuestionNotification:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkQAAllowAttendeeUpVoteQuestionNotification", Selector = "onSinkQAAllowAttendeeUpVoteQuestionNotification:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkQAAllowAttendeeAnswerQuestionNotification", Selector = "onSinkQAAllowAttendeeAnswerQuestionNotification:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkWebinarNeedRegister", Selector = "onSinkWebinarNeedRegister:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkJoinWebinarNeedUserNameAndEmailWithCompletion", Selector = "onSinkJoinWebinarNeedUserNameAndEmailWithCompletion:", ParameterType = new Type [] { typeof (global::System.Func<NSString, NSString, bool, bool>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDFuncArity4V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkPanelistCapacityExceed", Selector = "onSinkPanelistCapacityExceed")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkPromptAttendee2PanelistResult", Selector = "onSinkPromptAttendee2PanelistResult:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCWebinarPromoteorDepromoteError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkDePromptPanelist2AttendeeResult", Selector = "onSinkDePromptPanelist2AttendeeResult:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCWebinarPromoteorDepromoteError) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkAllowAttendeeChatNotification", Selector = "onSinkAllowAttendeeChatNotification:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCChatAllowAttendeeChat) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkAttendeePromoteConfirmResult", Selector = "onSinkAttendeePromoteConfirmResult:userId:", ParameterType = new Type [] { typeof (bool), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkSelfAllowTalkNotification", Selector = "onSinkSelfAllowTalkNotification")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkSelfDisallowTalkNotification", Selector = "onSinkSelfDisallowTalkNotification")]
	public partial interface IMobileRTCWebinarServiceDelegate : INativeObject, IDisposable, 
		Zoomios.IIMobileRTCMeetingServiceDelegate
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkQAConnectStarted")]
		[Preserve (Conditional = true)]
		void OnSinkQAConnectStarted ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkQAConnected:")]
		[Preserve (Conditional = true)]
		void OnSinkQAConnected (bool connected);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkQAOpenQuestionChanged:")]
		[Preserve (Conditional = true)]
		void OnSinkQAOpenQuestionChanged (nint count);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkQAAddQuestion:success:")]
		[Preserve (Conditional = true)]
		void OnSinkQAAddQuestion (string questionID, bool success);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkQAAddAnswer:success:")]
		[Preserve (Conditional = true)]
		void OnSinkQAAddAnswer (string answerID, bool success);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkQuestionMarkedAsDismissed:")]
		[Preserve (Conditional = true)]
		void OnSinkQuestionMarkedAsDismissed (string questionID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkReopenQuestion:")]
		[Preserve (Conditional = true)]
		void OnSinkReopenQuestion (string questionID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkReceiveQuestion:")]
		[Preserve (Conditional = true)]
		void OnSinkReceiveQuestion (string questionID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkReceiveAnswer:")]
		[Preserve (Conditional = true)]
		void OnSinkReceiveAnswer (string answerID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkUserLivingReply:")]
		[Preserve (Conditional = true)]
		void OnSinkUserLivingReply (string questionID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkUserEndLiving:")]
		[Preserve (Conditional = true)]
		void OnSinkUserEndLiving (string questionID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkVoteupQuestion:orderChanged:")]
		[Preserve (Conditional = true)]
		void OnSinkVoteupQuestion (string questionID, bool orderChanged);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkRevokeVoteupQuestion:orderChanged:")]
		[Preserve (Conditional = true)]
		void OnSinkRevokeVoteupQuestion (string questionID, bool orderChanged);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkDeleteQuestion:")]
		[Preserve (Conditional = true)]
		void OnSinkDeleteQuestion (NSObject[] questionIDArray);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkDeleteAnswer:")]
		[Preserve (Conditional = true)]
		void OnSinkDeleteAnswer (NSObject[] answerIDArray);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkQAAllowAskQuestionAnonymouslyNotification:")]
		[Preserve (Conditional = true)]
		void OnSinkQAAllowAskQuestionAnonymouslyNotification (bool beAllowed);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkQAAllowAttendeeViewAllQuestionNotification:")]
		[Preserve (Conditional = true)]
		void OnSinkQAAllowAttendeeViewAllQuestionNotification (bool beAllowed);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkQAAllowAttendeeUpVoteQuestionNotification:")]
		[Preserve (Conditional = true)]
		void OnSinkQAAllowAttendeeUpVoteQuestionNotification (bool beAllowed);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkQAAllowAttendeeAnswerQuestionNotification:")]
		[Preserve (Conditional = true)]
		void OnSinkQAAllowAttendeeAnswerQuestionNotification (bool beAllowed);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkWebinarNeedRegister:")]
		[Preserve (Conditional = true)]
		void OnSinkWebinarNeedRegister (string registerURL);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkJoinWebinarNeedUserNameAndEmailWithCompletion:")]
		[Preserve (Conditional = true)]
		unsafe void OnSinkJoinWebinarNeedUserNameAndEmailWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity4V0))]global::System.Func<NSString, NSString, bool, bool> completion);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkPanelistCapacityExceed")]
		[Preserve (Conditional = true)]
		void OnSinkPanelistCapacityExceed ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkPromptAttendee2PanelistResult:")]
		[Preserve (Conditional = true)]
		void OnSinkPromptAttendee2PanelistResult (MobileRTCWebinarPromoteorDepromoteError errorCode);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkDePromptPanelist2AttendeeResult:")]
		[Preserve (Conditional = true)]
		void OnSinkDePromptPanelist2AttendeeResult (MobileRTCWebinarPromoteorDepromoteError errorCode);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkAllowAttendeeChatNotification:")]
		[Preserve (Conditional = true)]
		void OnSinkAllowAttendeeChatNotification (MobileRTCChatAllowAttendeeChat currentPrivilege);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkAttendeePromoteConfirmResult:userId:")]
		[Preserve (Conditional = true)]
		void OnSinkAttendeePromoteConfirmResult (bool agree, nuint userId);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkSelfAllowTalkNotification")]
		[Preserve (Conditional = true)]
		void OnSinkSelfAllowTalkNotification ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkSelfDisallowTalkNotification")]
		[Preserve (Conditional = true)]
		void OnSinkSelfDisallowTalkNotification ();
	}
	internal sealed class MobileRTCWebinarServiceDelegateWrapper : BaseWrapper, IMobileRTCWebinarServiceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCWebinarServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onSinkQAConnectStarted")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkQAConnectStarted ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onSinkQAConnectStarted"));
		}
		[Export ("onSinkQAConnected:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkQAConnected (bool connected)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("onSinkQAConnected:"), connected);
		}
		[Export ("onSinkQAOpenQuestionChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkQAOpenQuestionChanged (nint count)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSinkQAOpenQuestionChanged:"), (IntPtr) count);
		}
		[Export ("onSinkQAAddQuestion:success:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkQAAddQuestion (string questionID, bool success)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("onSinkQAAddQuestion:success:"), nsquestionID, success);
			CFString.ReleaseNative (nsquestionID);
		}
		[Export ("onSinkQAAddAnswer:success:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkQAAddAnswer (string answerID, bool success)
		{
			if (answerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (answerID));
			var nsanswerID = CFString.CreateNative (answerID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("onSinkQAAddAnswer:success:"), nsanswerID, success);
			CFString.ReleaseNative (nsanswerID);
		}
		[Export ("onSinkQuestionMarkedAsDismissed:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkQuestionMarkedAsDismissed (string questionID)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSinkQuestionMarkedAsDismissed:"), nsquestionID);
			CFString.ReleaseNative (nsquestionID);
		}
		[Export ("onSinkReopenQuestion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkReopenQuestion (string questionID)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSinkReopenQuestion:"), nsquestionID);
			CFString.ReleaseNative (nsquestionID);
		}
		[Export ("onSinkReceiveQuestion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkReceiveQuestion (string questionID)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSinkReceiveQuestion:"), nsquestionID);
			CFString.ReleaseNative (nsquestionID);
		}
		[Export ("onSinkReceiveAnswer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkReceiveAnswer (string answerID)
		{
			if (answerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (answerID));
			var nsanswerID = CFString.CreateNative (answerID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSinkReceiveAnswer:"), nsanswerID);
			CFString.ReleaseNative (nsanswerID);
		}
		[Export ("onSinkUserLivingReply:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkUserLivingReply (string questionID)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSinkUserLivingReply:"), nsquestionID);
			CFString.ReleaseNative (nsquestionID);
		}
		[Export ("onSinkUserEndLiving:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkUserEndLiving (string questionID)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSinkUserEndLiving:"), nsquestionID);
			CFString.ReleaseNative (nsquestionID);
		}
		[Export ("onSinkVoteupQuestion:orderChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkVoteupQuestion (string questionID, bool orderChanged)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("onSinkVoteupQuestion:orderChanged:"), nsquestionID, orderChanged);
			CFString.ReleaseNative (nsquestionID);
		}
		[Export ("onSinkRevokeVoteupQuestion:orderChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkRevokeVoteupQuestion (string questionID, bool orderChanged)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("onSinkRevokeVoteupQuestion:orderChanged:"), nsquestionID, orderChanged);
			CFString.ReleaseNative (nsquestionID);
		}
		[Export ("onSinkDeleteQuestion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkDeleteQuestion (NSObject[] questionIDArray)
		{
			if (questionIDArray is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionIDArray));
			var nsa_questionIDArray = NSArray.FromNSObjects (questionIDArray);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSinkDeleteQuestion:"), nsa_questionIDArray.Handle);
			nsa_questionIDArray.Dispose ();
		}
		[Export ("onSinkDeleteAnswer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkDeleteAnswer (NSObject[] answerIDArray)
		{
			if (answerIDArray is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (answerIDArray));
			var nsa_answerIDArray = NSArray.FromNSObjects (answerIDArray);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSinkDeleteAnswer:"), nsa_answerIDArray.Handle);
			nsa_answerIDArray.Dispose ();
		}
		[Export ("onSinkQAAllowAskQuestionAnonymouslyNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkQAAllowAskQuestionAnonymouslyNotification (bool beAllowed)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("onSinkQAAllowAskQuestionAnonymouslyNotification:"), beAllowed);
		}
		[Export ("onSinkQAAllowAttendeeViewAllQuestionNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkQAAllowAttendeeViewAllQuestionNotification (bool beAllowed)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("onSinkQAAllowAttendeeViewAllQuestionNotification:"), beAllowed);
		}
		[Export ("onSinkQAAllowAttendeeUpVoteQuestionNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkQAAllowAttendeeUpVoteQuestionNotification (bool beAllowed)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("onSinkQAAllowAttendeeUpVoteQuestionNotification:"), beAllowed);
		}
		[Export ("onSinkQAAllowAttendeeAnswerQuestionNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkQAAllowAttendeeAnswerQuestionNotification (bool beAllowed)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("onSinkQAAllowAttendeeAnswerQuestionNotification:"), beAllowed);
		}
		[Export ("onSinkWebinarNeedRegister:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkWebinarNeedRegister (string registerURL)
		{
			if (registerURL is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (registerURL));
			var nsregisterURL = CFString.CreateNative (registerURL);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSinkWebinarNeedRegister:"), nsregisterURL);
			CFString.ReleaseNative (nsregisterURL);
		}
		[Export ("onSinkJoinWebinarNeedUserNameAndEmailWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void OnSinkJoinWebinarNeedUserNameAndEmailWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity4V0))]global::System.Func<NSString, NSString, bool, bool> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDFuncArity4V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSinkJoinWebinarNeedUserNameAndEmailWithCompletion:"), (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[Export ("onSinkPanelistCapacityExceed")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkPanelistCapacityExceed ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onSinkPanelistCapacityExceed"));
		}
		[Export ("onSinkPromptAttendee2PanelistResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkPromptAttendee2PanelistResult (MobileRTCWebinarPromoteorDepromoteError errorCode)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkPromptAttendee2PanelistResult:"), (UIntPtr) (ulong) errorCode);
		}
		[Export ("onSinkDePromptPanelist2AttendeeResult:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkDePromptPanelist2AttendeeResult (MobileRTCWebinarPromoteorDepromoteError errorCode)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkDePromptPanelist2AttendeeResult:"), (UIntPtr) (ulong) errorCode);
		}
		[Export ("onSinkAllowAttendeeChatNotification:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkAllowAttendeeChatNotification (MobileRTCChatAllowAttendeeChat currentPrivilege)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkAllowAttendeeChatNotification:"), (UIntPtr) (ulong) currentPrivilege);
		}
		[Export ("onSinkAttendeePromoteConfirmResult:userId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkAttendeePromoteConfirmResult (bool agree, nuint userId)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool_UIntPtr (this.Handle, Selector.GetHandle ("onSinkAttendeePromoteConfirmResult:userId:"), agree, (UIntPtr) userId);
		}
		[Export ("onSinkSelfAllowTalkNotification")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkSelfAllowTalkNotification ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onSinkSelfAllowTalkNotification"));
		}
		[Export ("onSinkSelfDisallowTalkNotification")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkSelfDisallowTalkNotification ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onSinkSelfDisallowTalkNotification"));
		}
	}
}
