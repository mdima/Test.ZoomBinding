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
	[Register("MobileRTCBOCreator", true)]
	public unsafe partial class MobileRTCBOCreator : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCBOCreator");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCBOCreator () : base (NSObjectFlag.Empty)
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
		protected MobileRTCBOCreator (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCBOCreator (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("assignUser:toBO:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AssignUser (string boUserId, string boId)
		{
			if (boUserId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boUserId));
			if (boId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boId));
			var nsboUserId = CFString.CreateNative (boUserId);
			var nsboId = CFString.CreateNative (boId);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("assignUser:toBO:"), nsboUserId, nsboId);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("assignUser:toBO:"), nsboUserId, nsboId);
			}
			CFString.ReleaseNative (nsboUserId);
			CFString.ReleaseNative (nsboId);
			return ret!;
		}
		[Export ("createBO:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? CreateBO (string boName)
		{
			if (boName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boName));
			var nsboName = CFString.CreateNative (boName);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("createBO:"), nsboName))!;
			} else {
				ret = CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("createBO:"), nsboName))!;
			}
			CFString.ReleaseNative (nsboName);
			return ret!;
		}
		[Export ("createGroupBO:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CreateGroupBO (string[] boNameList)
		{
			if (boNameList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boNameList));
			var nsa_boNameList = NSArray.FromStrings (boNameList);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("createGroupBO:"), nsa_boNameList.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("createGroupBO:"), nsa_boNameList.Handle);
			}
			nsa_boNameList.Dispose ();
			return ret!;
		}
		[Export ("removeBO:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RemoveBO (string boId)
		{
			if (boId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boId));
			var nsboId = CFString.CreateNative (boId);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("removeBO:"), nsboId);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("removeBO:"), nsboId);
			}
			CFString.ReleaseNative (nsboId);
			return ret!;
		}
		[Export ("removeUser:fromBO:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RemoveUser (string boUserId, string boId)
		{
			if (boUserId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boUserId));
			if (boId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boId));
			var nsboUserId = CFString.CreateNative (boUserId);
			var nsboId = CFString.CreateNative (boId);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("removeUser:fromBO:"), nsboUserId, nsboId);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("removeUser:fromBO:"), nsboUserId, nsboId);
			}
			CFString.ReleaseNative (nsboUserId);
			CFString.ReleaseNative (nsboId);
			return ret!;
		}
		[Export ("setBOOption:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SetBOOption (MobileRTCBOOption option)
		{
			var option__handle__ = option!.GetNonNullHandle (nameof (option));
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBOOption:"), option__handle__);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBOOption:"), option__handle__);
			}
		}
		[Export ("updateBO:name:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool UpdateBO (string boId, string boName)
		{
			if (boId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boId));
			if (boName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (boName));
			var nsboId = CFString.CreateNative (boId);
			var nsboName = CFString.CreateNative (boName);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("updateBO:name:"), nsboId, nsboName);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("updateBO:name:"), nsboId, nsboName);
			}
			CFString.ReleaseNative (nsboId);
			CFString.ReleaseNative (nsboName);
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCBOOption? BOOption {
			[Export ("getBOOption")]
			get {
				MobileRTCBOOption? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<MobileRTCBOOption> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getBOOption")))!;
				} else {
					ret =  Runtime.GetNSObject<MobileRTCBOOption> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getBOOption")))!;
				}
				return ret!;
			}
		}
	} /* class MobileRTCBOCreator */
}
