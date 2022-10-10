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
	[Register("MobileRTCAlternativeHost", true)]
	public unsafe partial class MobileRTCAlternativeHost : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCAlternativeHost");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCAlternativeHost () : base (NSObjectFlag.Empty)
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
		protected MobileRTCAlternativeHost (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCAlternativeHost (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithEmailAddress:firstname:lastName:PMI:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MobileRTCAlternativeHost (string emailAddress, string firstName, string lastName, ulong PMINumber)
			: base (NSObjectFlag.Empty)
		{
			if (emailAddress is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (emailAddress));
			if (firstName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (firstName));
			if (lastName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (lastName));
			var nsemailAddress = CFString.CreateNative (emailAddress);
			var nsfirstName = CFString.CreateNative (firstName);
			var nslastName = CFString.CreateNative (lastName);
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64 (this.Handle, Selector.GetHandle ("initWithEmailAddress:firstname:lastName:PMI:"), nsemailAddress, nsfirstName, nslastName, PMINumber), "initWithEmailAddress:firstname:lastName:PMI:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64 (this.SuperHandle, Selector.GetHandle ("initWithEmailAddress:firstname:lastName:PMI:"), nsemailAddress, nsfirstName, nslastName, PMINumber), "initWithEmailAddress:firstname:lastName:PMI:");
			}
			CFString.ReleaseNative (nsemailAddress);
			CFString.ReleaseNative (nsfirstName);
			CFString.ReleaseNative (nslastName);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? Email {
			[Export ("email", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("email")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("email")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? FirstName {
			[Export ("firstName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("firstName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("firstName")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? LastName {
			[Export ("lastName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("lastName")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("lastName")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual ulong PMINumber {
			[Export ("PMINumber")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("PMINumber"));
				} else {
					return global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("PMINumber"));
				}
			}
		}
	} /* class MobileRTCAlternativeHost */
}
