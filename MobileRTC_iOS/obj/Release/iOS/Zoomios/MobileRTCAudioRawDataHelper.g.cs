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
	[Register("MobileRTCAudioRawDataHelper", true)]
	public unsafe partial class MobileRTCAudioRawDataHelper : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCAudioRawDataHelper");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCAudioRawDataHelper () : base (NSObjectFlag.Empty)
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
		protected MobileRTCAudioRawDataHelper (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCAudioRawDataHelper (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDelegate:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public MobileRTCAudioRawDataHelper (MobileRTCAudioRawDataDelegate @delegate)
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
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCRawDataError Subscribe {
			[Export ("subscribe")]
			get {
				MobileRTCRawDataError ret;
				if (IsDirectBinding) {
					ret = (Zoomios.MobileRTCRawDataError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("subscribe"));
				} else {
					ret = (Zoomios.MobileRTCRawDataError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("subscribe"));
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
	} /* class MobileRTCAudioRawDataHelper */
}
