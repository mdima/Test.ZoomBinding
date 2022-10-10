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
	public unsafe static partial class MobileRTCMeetingService_Webinar  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingService");
		[Export ("getALLQuestionCount")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int ALLQuestionCount (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("getALLQuestionCount"));
		}
		[Export ("addQuestion:anonymous:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AddQuestion (this MobileRTCMeetingService This, string content, bool anonymous)
		{
			if (content is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (content));
			var nscontent = CFString.CreateNative (content);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("addQuestion:anonymous:"), nscontent, anonymous);
			CFString.ReleaseNative (nscontent);
			return ret!;
		}
		[Export ("getAllQuestionList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCQAItem[] AllQuestionList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCQAItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAllQuestionList")))!;
		}
		[Export ("allowAskQuestionAnonymously:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AllowAskQuestionAnonymously (this MobileRTCMeetingService This, bool enable)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("allowAskQuestionAnonymously:"), enable);
		}
		[Export ("allowAttenddeTalk:allow:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AllowAttenddeTalk (this MobileRTCMeetingService This, nuint userID, bool enable)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr_bool (This.Handle, Selector.GetHandle ("allowAttenddeTalk:allow:"), (UIntPtr) userID, enable);
		}
		[Export ("allowAttendeeChat:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AllowAttendeeChat (this MobileRTCMeetingService This, MobileRTCChatAllowAttendeeChat privilegeType)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("allowAttendeeChat:"), (UIntPtr) (ulong) privilegeType);
		}
		[Export ("allowAttendeeUpVoteQuestion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AllowAttendeeUpVoteQuestion (this MobileRTCMeetingService This, bool enable)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("allowAttendeeUpVoteQuestion:"), enable);
		}
		[Export ("allowAttendeeViewAllQuestion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AllowAttendeeViewAllQuestion (this MobileRTCMeetingService This, bool enable)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("allowAttendeeViewAllQuestion:"), enable);
		}
		[Export ("allowCommentQuestion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AllowCommentQuestion (this MobileRTCMeetingService This, bool enable)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("allowCommentQuestion:"), enable);
		}
		[Export ("allowPanelistStartVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AllowPanelistStartVideo (this MobileRTCMeetingService This, bool enable)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (This.Handle, Selector.GetHandle ("allowPanelistStartVideo:"), enable);
		}
		[Export ("answerQuestionPrivate:answerContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AnswerQuestionPrivate (this MobileRTCMeetingService This, string questionID, string answerContent)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			if (answerContent is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (answerContent));
			var nsquestionID = CFString.CreateNative (questionID);
			var nsanswerContent = CFString.CreateNative (answerContent);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("answerQuestionPrivate:answerContent:"), nsquestionID, nsanswerContent);
			CFString.ReleaseNative (nsquestionID);
			CFString.ReleaseNative (nsanswerContent);
			return ret!;
		}
		[Export ("answerQuestionPublic:answerContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AnswerQuestionPublic (this MobileRTCMeetingService This, string questionID, string answerContent)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			if (answerContent is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (answerContent));
			var nsquestionID = CFString.CreateNative (questionID);
			var nsanswerContent = CFString.CreateNative (answerContent);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("answerQuestionPublic:answerContent:"), nsquestionID, nsanswerContent);
			CFString.ReleaseNative (nsquestionID);
			CFString.ReleaseNative (nsanswerContent);
			return ret!;
		}
		[Export ("getAnsweredQuestionCount")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int AnsweredQuestionCount (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("getAnsweredQuestionCount"));
		}
		[Export ("getAnsweredQuestionList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCQAItem[] AnsweredQuestionList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCQAItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAnsweredQuestionList")))!;
		}
		[Export ("changePanelistChatPrivilege:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ChangePanelistChatPrivilege (this MobileRTCMeetingService This, MobileRTCPanelistChatPrivilegeType privilege)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("changePanelistChatPrivilege:"), (UIntPtr) (ulong) privilege);
		}
		[Export ("commentQuestion:commentContent:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool CommentQuestion (this MobileRTCMeetingService This, string questionID, string commentContent)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			if (commentContent is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (commentContent));
			var nsquestionID = CFString.CreateNative (questionID);
			var nscommentContent = CFString.CreateNative (commentContent);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("commentQuestion:commentContent:"), nsquestionID, nscommentContent);
			CFString.ReleaseNative (nsquestionID);
			CFString.ReleaseNative (nscommentContent);
			return ret!;
		}
		[Export ("dePromptPanelist2Attendee:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DePromptPanelist2Attendee (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("dePromptPanelist2Attendee:"), (UIntPtr) userID);
		}
		[Export ("deleteAnswer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DeleteAnswer (this MobileRTCMeetingService This, string answerID)
		{
			if (answerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (answerID));
			var nsanswerID = CFString.CreateNative (answerID);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("deleteAnswer:"), nsanswerID);
			CFString.ReleaseNative (nsanswerID);
			return ret!;
		}
		[Export ("deleteQuestion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DeleteQuestion (this MobileRTCMeetingService This, string questionID)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("deleteQuestion:"), nsquestionID);
			CFString.ReleaseNative (nsquestionID);
			return ret!;
		}
		[Export ("dismissQuestion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DismissQuestion (this MobileRTCMeetingService This, string questionID)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("dismissQuestion:"), nsquestionID);
			CFString.ReleaseNative (nsquestionID);
			return ret!;
		}
		[Export ("getDismissedQuestionCount")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int DismissedQuestionCount (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("getDismissedQuestionCount"));
		}
		[Export ("getDismissedQuestionList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCQAItem[] DismissedQuestionList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCQAItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getDismissedQuestionList")))!;
		}
		[Export ("endLiving:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool EndLiving (this MobileRTCMeetingService This, string questionID)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("endLiving:"), nsquestionID);
			CFString.ReleaseNative (nsquestionID);
			return ret!;
		}
		[Export ("getAnswer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCQAAnswerItem? GetAnswer (this MobileRTCMeetingService This, string answerID)
		{
			if (answerID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (answerID));
			var nsanswerID = CFString.CreateNative (answerID);
			MobileRTCQAAnswerItem? ret;
			ret =  Runtime.GetNSObject<MobileRTCQAAnswerItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("getAnswer:"), nsanswerID))!;
			CFString.ReleaseNative (nsanswerID);
			return ret!;
		}
		[Export ("getQuestion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCQAItem? GetQuestion (this MobileRTCMeetingService This, string questionID)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			MobileRTCQAItem? ret;
			ret =  Runtime.GetNSObject<MobileRTCQAItem> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("getQuestion:"), nsquestionID))!;
			CFString.ReleaseNative (nsquestionID);
			return ret!;
		}
		[Export ("hasPromptAndDePromptPrivilige")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HasPromptAndDePromptPrivilige (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hasPromptAndDePromptPrivilige"));
		}
		[Export ("isAllowAskQuestionAnonymously")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAllowAskQuestionAnonymously (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAllowAskQuestionAnonymously"));
		}
		[Export ("isAllowAttendeeTalk:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAllowAttendeeTalk (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("isAllowAttendeeTalk:"), (UIntPtr) userID);
		}
		[Export ("isAllowAttendeeUpVoteQuestion")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAllowAttendeeUpVoteQuestion (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAllowAttendeeUpVoteQuestion"));
		}
		[Export ("isAllowAttendeeViewAllQuestion")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAllowAttendeeViewAllQuestion (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAllowAttendeeViewAllQuestion"));
		}
		[Export ("isAllowCommentQuestion")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAllowCommentQuestion (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAllowCommentQuestion"));
		}
		[Export ("isAllowPanelistStartVideo")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsAllowPanelistStartVideo (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAllowPanelistStartVideo"));
		}
		[Export ("isPollingLegalNoticeAvailable")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsPollingLegalNoticeAvailable (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isPollingLegalNoticeAvailable"));
		}
		[Export ("isQALegalNoticeAvailable")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsQALegalNoticeAvailable (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isQALegalNoticeAvailable"));
		}
		[Export ("getMyQuestionCount")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int MyQuestionCount (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("getMyQuestionCount"));
		}
		[Export ("getMyQuestionList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCQAItem[] MyQuestionList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCQAItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getMyQuestionList")))!;
		}
		[Export ("getOpenQuestionCount")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static int OpenQuestionCount (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("getOpenQuestionCount"));
		}
		[Export ("getOpenQuestionList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCQAItem[] OpenQuestionList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCQAItem>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getOpenQuestionList")))!;
		}
		[Export ("getPanelistChatPrivilege")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCPanelistChatPrivilegeType PanelistChatPrivilege (this MobileRTCMeetingService This)
		{
			MobileRTCPanelistChatPrivilegeType ret;
			ret = (Zoomios.MobileRTCPanelistChatPrivilegeType) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getPanelistChatPrivilege"));
			return ret!;
		}
		[Export ("getPollAnonymousLegalNoticesExplained")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string PollAnonymousLegalNoticesExplained (this MobileRTCMeetingService This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getPollAnonymousLegalNoticesExplained")))!;
		}
		[Export ("getPollLegalNoticesExplained")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string PollLegalNoticesExplained (this MobileRTCMeetingService This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getPollLegalNoticesExplained")))!;
		}
		[Export ("getPollLegalNoticesPrompt")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string PollLegalNoticesPrompt (this MobileRTCMeetingService This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getPollLegalNoticesPrompt")))!;
		}
		[Export ("promptAttendee2Panelist:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool PromptAttendee2Panelist (this MobileRTCMeetingService This, nuint userID)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("promptAttendee2Panelist:"), (UIntPtr) userID);
		}
		[Export ("getQALegalNoticesExplained")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string QALegalNoticesExplained (this MobileRTCMeetingService This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getQALegalNoticesExplained")))!;
		}
		[Export ("getQALegalNoticesPrompt")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string QALegalNoticesPrompt (this MobileRTCMeetingService This)
		{
			return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getQALegalNoticesPrompt")))!;
		}
		[Export ("reopenQuestion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool ReopenQuestion (this MobileRTCMeetingService This, string questionID)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("reopenQuestion:"), nsquestionID);
			CFString.ReleaseNative (nsquestionID);
			return ret!;
		}
		[Export ("startLiving:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool StartLiving (this MobileRTCMeetingService This, string questionID)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("startLiving:"), nsquestionID);
			CFString.ReleaseNative (nsquestionID);
			return ret!;
		}
		[Export ("voteupQuestion:voteup:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool VoteupQuestion (this MobileRTCMeetingService This, string questionID, bool voteup)
		{
			if (questionID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (questionID));
			var nsquestionID = CFString.CreateNative (questionID);
			bool ret;
			ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_bool (This.Handle, Selector.GetHandle ("voteupQuestion:voteup:"), nsquestionID, voteup);
			CFString.ReleaseNative (nsquestionID);
			return ret!;
		}
		[Export ("getWebinarAttendeeChatPrivilege")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCChatAllowAttendeeChat WebinarAttendeeChatPrivilege (this MobileRTCMeetingService This)
		{
			MobileRTCChatAllowAttendeeChat ret;
			ret = (Zoomios.MobileRTCChatAllowAttendeeChat) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getWebinarAttendeeChatPrivilege"));
			return ret!;
		}
	} /* class MobileRTCMeetingService_Webinar */
}
