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
	[Register("MobileRTCVideoRawData", true)]
	public unsafe partial class MobileRTCVideoRawData : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCVideoRawData");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCVideoRawData () : base (NSObjectFlag.Empty)
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
		protected MobileRTCVideoRawData (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCVideoRawData (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AddRef {
			[Export ("addRef")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("addRef"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("addRef"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CanAddRef {
			[Export ("canAddRef")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("canAddRef"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("canAddRef"));
				}
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
		public virtual nint ReleaseRef {
			[Export ("releaseRef")]
			get {
				if (IsDirectBinding) {
					return (nint) global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("releaseRef"));
				} else {
					return (nint) global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("releaseRef"));
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
		public virtual global::System.IntPtr UBuffer {
			[Export ("uBuffer", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("uBuffer"));
				} else {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("uBuffer"));
				}
			}
			[Export ("setUBuffer:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setUBuffer:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setUBuffer:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.IntPtr VBuffer {
			[Export ("vBuffer", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("vBuffer"));
				} else {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("vBuffer"));
				}
			}
			[Export ("setVBuffer:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setVBuffer:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setVBuffer:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.IntPtr YBuffer {
			[Export ("yBuffer", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("yBuffer"));
				} else {
					return global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("yBuffer"));
				}
			}
			[Export ("setYBuffer:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setYBuffer:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setYBuffer:"), value);
				}
			}
		}
	} /* class MobileRTCVideoRawData */
}
