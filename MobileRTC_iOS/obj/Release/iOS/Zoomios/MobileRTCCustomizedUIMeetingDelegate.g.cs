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
	[Protocol (Name = "MobileRTCCustomizedUIMeetingDelegate", WrapperType = typeof (MobileRTCCustomizedUIMeetingDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnInitMeetingView", Selector = "onInitMeetingView")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnDestroyMeetingView", Selector = "onDestroyMeetingView")]
	public partial interface IMobileRTCCustomizedUIMeetingDelegate : INativeObject, IDisposable
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onInitMeetingView")]
		[Preserve (Conditional = true)]
		void OnInitMeetingView ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onDestroyMeetingView")]
		[Preserve (Conditional = true)]
		void OnDestroyMeetingView ();
	}
	internal sealed class MobileRTCCustomizedUIMeetingDelegateWrapper : BaseWrapper, IMobileRTCCustomizedUIMeetingDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCCustomizedUIMeetingDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onInitMeetingView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnInitMeetingView ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onInitMeetingView"));
		}
		[Export ("onDestroyMeetingView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnDestroyMeetingView ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onDestroyMeetingView"));
		}
	}
}
namespace Zoomios {
	[Protocol()]
	[Register("ApiDefinition__Zoomios_MobileRTCCustomizedUIMeetingDelegate", false)]
	[Model]
	public unsafe abstract partial class MobileRTCCustomizedUIMeetingDelegate : NSObject, IMobileRTCCustomizedUIMeetingDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected MobileRTCCustomizedUIMeetingDelegate () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = false;
			InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected MobileRTCCustomizedUIMeetingDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = false;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCCustomizedUIMeetingDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = false;
		}

		[Export ("onDestroyMeetingView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void OnDestroyMeetingView ();
		[Export ("onInitMeetingView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public abstract void OnInitMeetingView ();
	} /* class MobileRTCCustomizedUIMeetingDelegate */
}
