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
	[Protocol (Name = "MobileRTCVideoServiceDelegate", WrapperType = typeof (MobileRTCVideoServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingActiveVideo", Selector = "onSinkMeetingActiveVideo:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingVideoStatusChange", Selector = "onSinkMeetingVideoStatusChange:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnMyVideoStateChange", Selector = "onMyVideoStateChange")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingVideoStatusChange", Selector = "onSinkMeetingVideoStatusChange:videoStatus:", ParameterType = new Type [] { typeof (nuint), typeof (Zoomios.MobileRTC_VideoStatus) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSpotlightVideoChange", Selector = "onSpotlightVideoChange:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSpotlightVideoUserChange", Selector = "onSpotlightVideoUserChange:", ParameterType = new Type [] { typeof (NSNumber[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingPreviewStopped", Selector = "onSinkMeetingPreviewStopped")]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingActiveVideoForDeck", Selector = "onSinkMeetingActiveVideoForDeck:", ParameterType = new Type [] { typeof (nuint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingVideoQualityChanged", Selector = "onSinkMeetingVideoQualityChanged:userID:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCVideoQuality), typeof (nuint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingVideoRequestUnmuteByHost", Selector = "onSinkMeetingVideoRequestUnmuteByHost:", ParameterType = new Type [] { typeof (global::System.Action<bool>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnSinkMeetingShowMinimizeMeetingOrBackZoomUI", Selector = "onSinkMeetingShowMinimizeMeetingOrBackZoomUI:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCMinimizeMeetingState) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnHostVideoOrderUpdated", Selector = "onHostVideoOrderUpdated:", ParameterType = new Type [] { typeof (NSNumber[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnLocalVideoOrderUpdated", Selector = "onLocalVideoOrderUpdated:", ParameterType = new Type [] { typeof (NSNumber[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "OnFollowHostVideoOrderChanged", Selector = "onFollowHostVideoOrderChanged:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	public partial interface IMobileRTCVideoServiceDelegate : INativeObject, IDisposable, 
		Zoomios.IIMobileRTCMeetingServiceDelegate
	{
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingActiveVideo:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingActiveVideo (nuint userID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingVideoStatusChange:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingVideoStatusChange (nuint userID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onMyVideoStateChange")]
		[Preserve (Conditional = true)]
		void OnMyVideoStateChange ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingVideoStatusChange:videoStatus:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingVideoStatusChange (nuint userID, MobileRTC_VideoStatus videoStatus);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSpotlightVideoChange:")]
		[Preserve (Conditional = true)]
		void OnSpotlightVideoChange (bool on);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSpotlightVideoUserChange:")]
		[Preserve (Conditional = true)]
		void OnSpotlightVideoUserChange (NSNumber[] spotlightedUserList);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingPreviewStopped")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingPreviewStopped ();
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingActiveVideoForDeck:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingActiveVideoForDeck (nuint userID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingVideoQualityChanged:userID:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingVideoQualityChanged (MobileRTCVideoQuality qality, nuint userID);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingVideoRequestUnmuteByHost:")]
		[Preserve (Conditional = true)]
		unsafe void OnSinkMeetingVideoRequestUnmuteByHost ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onSinkMeetingShowMinimizeMeetingOrBackZoomUI:")]
		[Preserve (Conditional = true)]
		void OnSinkMeetingShowMinimizeMeetingOrBackZoomUI (MobileRTCMinimizeMeetingState state);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onHostVideoOrderUpdated:")]
		[Preserve (Conditional = true)]
		void OnHostVideoOrderUpdated (NSNumber[]? orderArr);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onLocalVideoOrderUpdated:")]
		[Preserve (Conditional = true)]
		void OnLocalVideoOrderUpdated (NSNumber[]? localOrderArr);
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Export ("onFollowHostVideoOrderChanged:")]
		[Preserve (Conditional = true)]
		void OnFollowHostVideoOrderChanged (bool follow);
	}
	internal sealed class MobileRTCVideoServiceDelegateWrapper : BaseWrapper, IMobileRTCVideoServiceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCVideoServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("onSinkMeetingActiveVideo:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingActiveVideo (nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingActiveVideo:"), (UIntPtr) userID);
		}
		[Export ("onSinkMeetingVideoStatusChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingVideoStatusChange (nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingVideoStatusChange:"), (UIntPtr) userID);
		}
		[Export ("onMyVideoStateChange")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnMyVideoStateChange ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onMyVideoStateChange"));
		}
		[Export ("onSinkMeetingVideoStatusChange:videoStatus:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingVideoStatusChange (nuint userID, MobileRTC_VideoStatus videoStatus)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingVideoStatusChange:videoStatus:"), (UIntPtr) userID, (UIntPtr) (ulong) videoStatus);
		}
		[Export ("onSpotlightVideoChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSpotlightVideoChange (bool on)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("onSpotlightVideoChange:"), on);
		}
		[Export ("onSpotlightVideoUserChange:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSpotlightVideoUserChange (NSNumber[] spotlightedUserList)
		{
			if (spotlightedUserList is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (spotlightedUserList));
			var nsa_spotlightedUserList = NSArray.FromNSObjects (spotlightedUserList);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSpotlightVideoUserChange:"), nsa_spotlightedUserList.Handle);
			nsa_spotlightedUserList.Dispose ();
		}
		[Export ("onSinkMeetingPreviewStopped")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingPreviewStopped ()
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("onSinkMeetingPreviewStopped"));
		}
		[Export ("onSinkMeetingActiveVideoForDeck:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingActiveVideoForDeck (nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingActiveVideoForDeck:"), (UIntPtr) userID);
		}
		[Export ("onSinkMeetingVideoQualityChanged:userID:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingVideoQualityChanged (MobileRTCVideoQuality qality, nuint userID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingVideoQualityChanged:userID:"), (IntPtr) (long) qality, (UIntPtr) userID);
		}
		[Export ("onSinkMeetingVideoRequestUnmuteByHost:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe void OnSinkMeetingVideoRequestUnmuteByHost ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<bool> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlockUnsafe (Trampolines.SDActionArity1V0.Handler, completion);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingVideoRequestUnmuteByHost:"), (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
		}
		[Export ("onSinkMeetingShowMinimizeMeetingOrBackZoomUI:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnSinkMeetingShowMinimizeMeetingOrBackZoomUI (MobileRTCMinimizeMeetingState state)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("onSinkMeetingShowMinimizeMeetingOrBackZoomUI:"), (UIntPtr) (ulong) state);
		}
		[Export ("onHostVideoOrderUpdated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnHostVideoOrderUpdated (NSNumber[]? orderArr)
		{
			var nsa_orderArr = orderArr is null ? null : NSArray.FromNSObjects (orderArr);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onHostVideoOrderUpdated:"), nsa_orderArr.GetHandle ());
			if (nsa_orderArr != null)
				nsa_orderArr.Dispose ();
		}
		[Export ("onLocalVideoOrderUpdated:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnLocalVideoOrderUpdated (NSNumber[]? localOrderArr)
		{
			var nsa_localOrderArr = localOrderArr is null ? null : NSArray.FromNSObjects (localOrderArr);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("onLocalVideoOrderUpdated:"), nsa_localOrderArr.GetHandle ());
			if (nsa_localOrderArr != null)
				nsa_localOrderArr.Dispose ();
		}
		[Export ("onFollowHostVideoOrderChanged:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public void OnFollowHostVideoOrderChanged (bool follow)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("onFollowHostVideoOrderChanged:"), follow);
		}
	}
}
