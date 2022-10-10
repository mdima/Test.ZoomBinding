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
	[Register("MobileRTCMeetingChat", true)]
	public unsafe partial class MobileRTCMeetingChat : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingChat");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCMeetingChat () : base (NSObjectFlag.Empty)
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
		protected MobileRTCMeetingChat (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCMeetingChat (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ChatId {
			[Export ("chatId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("chatId")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("chatId")))!;
				}
			}
			[Export ("setChatId:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setChatId:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setChatId:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCChatMessageType ChatMessageType {
			[Export ("chatMessageType", ArgumentSemantic.UnsafeUnretained)]
			get {
				MobileRTCChatMessageType ret;
				if (IsDirectBinding) {
					ret = (Zoomios.MobileRTCChatMessageType) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("chatMessageType"));
				} else {
					ret = (Zoomios.MobileRTCChatMessageType) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("chatMessageType"));
				}
				return ret!;
			}
			[Export ("setChatMessageType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setChatMessageType:"), (UIntPtr) (ulong) value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("setChatMessageType:"), (UIntPtr) (ulong) value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Content {
			[Export ("content", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("content")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("content")))!;
				}
			}
			[Export ("setContent:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setContent:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setContent:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual NSDate? Date {
			[Export ("date", ArgumentSemantic.Retain)]
			get {
				NSDate? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("date")))!;
				} else {
					ret =  Runtime.GetNSObject<NSDate> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("date")))!;
				}
				return ret!;
			}
			[Export ("setDate:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value.GetHandle ();
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setDate:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setDate:"), value__handle__);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsChatToAll {
			[Export ("isChatToAll")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isChatToAll"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isChatToAll"));
				}
			}
			[Export ("setIsChatToAll:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsChatToAll:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsChatToAll:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsChatToAllPanelist {
			[Export ("isChatToAllPanelist")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isChatToAllPanelist"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isChatToAllPanelist"));
				}
			}
			[Export ("setIsChatToAllPanelist:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsChatToAllPanelist:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsChatToAllPanelist:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsChatToWaitingroom {
			[Export ("isChatToWaitingroom")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isChatToWaitingroom"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isChatToWaitingroom"));
				}
			}
			[Export ("setIsChatToWaitingroom:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsChatToWaitingroom:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsChatToWaitingroom:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsMyself {
			[Export ("isMyself")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMyself"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isMyself"));
				}
			}
			[Export ("setIsMyself:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsMyself:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsMyself:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsPrivate {
			[Export ("isPrivate")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isPrivate"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isPrivate"));
				}
			}
			[Export ("setIsPrivate:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setIsPrivate:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setIsPrivate:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ReceiverId {
			[Export ("receiverId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("receiverId")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("receiverId")))!;
				}
			}
			[Export ("setReceiverId:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReceiverId:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReceiverId:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? ReceiverName {
			[Export ("receiverName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("receiverName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("receiverName")))!;
				}
			}
			[Export ("setReceiverName:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReceiverName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReceiverName:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SenderId {
			[Export ("senderId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("senderId")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("senderId")))!;
				}
			}
			[Export ("setSenderId:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSenderId:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSenderId:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SenderName {
			[Export ("senderName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("senderName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("senderName")))!;
				}
			}
			[Export ("setSenderName:", ArgumentSemantic.Retain)]
			set {
				var nsvalue = CFString.CreateNative (value);
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setSenderName:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setSenderName:"), nsvalue);
				}
				CFString.ReleaseNative (nsvalue);
			}
		}
	} /* class MobileRTCMeetingChat */
}
