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
	[Register("MobileRTCRenderer", true)]
	public unsafe partial class MobileRTCRenderer : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCRenderer");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCRenderer () : base (NSObjectFlag.Empty)
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
		protected MobileRTCRenderer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCRenderer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MobileRTCRenderer (MobileRTCVideoRawDataDelegate @delegate)
			: base (NSObjectFlag.Empty)
		{
			var @delegate__handle__ = @delegate!.GetNonNullHandle (nameof (@delegate));
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithDelegate:"), @delegate__handle__), "initWithDelegate:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithDelegate:"), @delegate__handle__), "initWithDelegate:");
			}
		}
		[Export ("setRawDataResolution:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRawDataError SetRawDataResolution (MobileRTCVideoResolution resolution)
		{
			MobileRTCRawDataError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCRawDataError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setRawDataResolution:"), (UIntPtr) (ulong) resolution);
			} else {
				ret = (Zoomios.MobileRTCRawDataError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("setRawDataResolution:"), (UIntPtr) (ulong) resolution);
			}
			return ret!;
		}
		[Export ("subscribe:videoType:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRawDataError Subscribe (nuint userId, MobileRTCVideoType type)
		{
			MobileRTCRawDataError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCRawDataError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("subscribe:videoType:"), (UIntPtr) userId, (UIntPtr) (ulong) type);
			} else {
				ret = (Zoomios.MobileRTCRawDataError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr_UIntPtr (this.SuperHandle, Selector.GetHandle ("subscribe:videoType:"), (UIntPtr) userId, (UIntPtr) (ulong) type);
			}
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCVideoResolution Resolution {
			[Export ("resolution", ArgumentSemantic.UnsafeUnretained)]
			get {
				MobileRTCVideoResolution ret;
				if (IsDirectBinding) {
					ret = (Zoomios.MobileRTCVideoResolution) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("resolution"));
				} else {
					ret = (Zoomios.MobileRTCVideoResolution) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resolution"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRawDataError UnSubscribe {
			[Export ("unSubscribe")]
			get {
				MobileRTCRawDataError ret;
				if (IsDirectBinding) {
					ret = (Zoomios.MobileRTCRawDataError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("unSubscribe"));
				} else {
					ret = (Zoomios.MobileRTCRawDataError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("unSubscribe"));
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual nuint UserId {
			[Export ("userId")]
			get {
				if (IsDirectBinding) {
					return (nuint) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("userId"));
				} else {
					return (nuint) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("userId"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCVideoType VideoType {
			[Export ("videoType", ArgumentSemantic.UnsafeUnretained)]
			get {
				MobileRTCVideoType ret;
				if (IsDirectBinding) {
					ret = (Zoomios.MobileRTCVideoType) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("videoType"));
				} else {
					ret = (Zoomios.MobileRTCVideoType) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("videoType"));
				}
				return ret!;
			}
		}
	} /* class MobileRTCRenderer */
}
