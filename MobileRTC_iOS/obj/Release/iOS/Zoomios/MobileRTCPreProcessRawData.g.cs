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
	[Register("MobileRTCPreProcessRawData", true)]
	public unsafe partial class MobileRTCPreProcessRawData : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCPreProcessRawData");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCPreProcessRawData () : base (NSObjectFlag.Empty)
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
		protected MobileRTCPreProcessRawData (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCPreProcessRawData (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("getUBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.IntPtr GetUBuffer (int lineNum)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("getUBuffer:"), lineNum);
			} else {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getUBuffer:"), lineNum);
			}
		}
		[Export ("getVBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.IntPtr GetVBuffer (int lineNum)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("getVBuffer:"), lineNum);
			} else {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getVBuffer:"), lineNum);
			}
		}
		[Export ("getYBuffer:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.IntPtr GetYBuffer (int lineNum)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("getYBuffer:"), lineNum);
			} else {
				return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("getYBuffer:"), lineNum);
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCVideoRawDataFormat Format {
			[Export ("format", ArgumentSemantic.UnsafeUnretained)]
			get {
				MobileRTCVideoRawDataFormat ret;
				if (IsDirectBinding) {
					ret = (Zoomios.MobileRTCVideoRawDataFormat) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("format"));
				} else {
					ret = (Zoomios.MobileRTCVideoRawDataFormat) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("format"));
				}
				return ret!;
			}
			[Export ("setFormat:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setFormat:"), (UIntPtr) (ulong) value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("setFormat:"), (UIntPtr) (ulong) value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCVideoRawDataRotation Rotation {
			[Export ("rotation", ArgumentSemantic.UnsafeUnretained)]
			get {
				MobileRTCVideoRawDataRotation ret;
				if (IsDirectBinding) {
					ret = (Zoomios.MobileRTCVideoRawDataRotation) (long) global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("rotation"));
				} else {
					ret = (Zoomios.MobileRTCVideoRawDataRotation) (long) global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("rotation"));
				}
				return ret!;
			}
			[Export ("setRotation:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setRotation:"), (IntPtr) (long) value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setRotation:"), (IntPtr) (long) value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual CGSize Size {
			[Export ("size", ArgumentSemantic.UnsafeUnretained)]
			get {
				CGSize ret;
				if (IsDirectBinding) {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("size"));
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("size"));
					} else if (Runtime.Arch == Arch.DEVICE) {
						global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret (out ret, this.Handle, Selector.GetHandle ("size"));
					} else {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (this.Handle, Selector.GetHandle ("size"));
					}
				} else {
					if (global::ObjCRuntime.Runtime.IsARM64CallingConvention) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("size"));
					} else if (IntPtr.Size == 8) {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("size"));
					} else if (Runtime.Arch == Arch.DEVICE) {
						global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper_stret (out ret, this.SuperHandle, Selector.GetHandle ("size"));
					} else {
						ret = global::ApiDefinition.Messaging.CGSize_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("size"));
					}
				}
				return ret!;
			}
			[Export ("setSize:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_CGSize (this.Handle, Selector.GetHandle ("setSize:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_CGSize (this.SuperHandle, Selector.GetHandle ("setSize:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int UStride {
			[Export ("uStride")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("uStride"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("uStride"));
				}
			}
			[Export ("setUStride:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setUStride:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setUStride:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int VStride {
			[Export ("vStride")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("vStride"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("vStride"));
				}
			}
			[Export ("setVStride:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setVStride:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setVStride:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual int YStride {
			[Export ("yStride")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("yStride"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("yStride"));
				}
			}
			[Export ("setYStride:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setYStride:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setYStride:"), value);
				}
			}
		}
	} /* class MobileRTCPreProcessRawData */
}
