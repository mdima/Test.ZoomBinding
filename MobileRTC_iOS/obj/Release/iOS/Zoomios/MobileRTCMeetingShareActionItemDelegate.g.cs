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
	[Protocol (Name = "MobileRTCMeetingShareActionItemDelegate", WrapperType = typeof (MobileRTCMeetingShareActionItemDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "Completion", Selector = "onShareItemClicked:completion:", ParameterType = new Type [] { typeof (nuint), typeof (global::System.Func<global::UIKit.UIViewController, bool>) }, ParameterByRef = new bool [] { false, false }, ParameterBlockProxy = new Type? [] { null, typeof (ObjCRuntime.Trampolines.NIDFuncArity2V0) })]
	public partial interface IMobileRTCMeetingShareActionItemDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onShareItemClicked:completion:")]
		[Preserve (Conditional = true)]
		unsafe void Completion (nuint tag, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V0))]global::System.Func<global::UIKit.UIViewController, bool> completion);
	}
	internal sealed class MobileRTCMeetingShareActionItemDelegateWrapper : BaseWrapper, IMobileRTCMeetingShareActionItemDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCMeetingShareActionItemDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onShareItemClicked:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void Completion (nuint tag, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V0))]global::System.Func<global::UIKit.UIViewController, bool> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDFuncArity2V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_IntPtr (this.Handle, Selector.GetHandle ("onShareItemClicked:completion:"), (UIntPtr) tag, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_MobileRTCMeetingShareActionItemDelegate", false)]
	[Model]
	public unsafe abstract partial class MobileRTCMeetingShareActionItemDelegate : NSObject, IMobileRTCMeetingShareActionItemDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MobileRTCMeetingShareActionItemDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCMeetingShareActionItemDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCMeetingShareActionItemDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onShareItemClicked:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe abstract void Completion (nuint tag, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V0))]global::System.Func<global::UIKit.UIViewController, bool> completion);
	} /* class MobileRTCMeetingShareActionItemDelegate */
}
