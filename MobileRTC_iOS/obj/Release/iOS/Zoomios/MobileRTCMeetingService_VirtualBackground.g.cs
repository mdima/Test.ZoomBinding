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
	public unsafe static partial class MobileRTCMeetingService_VirtualBackground  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingService");
		[Export ("addBGImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetError AddBGImage (this MobileRTCMeetingService This, global::UIKit.UIImage image)
		{
			var image__handle__ = image!.GetNonNullHandle (nameof (image));
			MobileRTCMeetError ret;
			ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("addBGImage:"), image__handle__);
			return ret!;
		}
		[Export ("getBGImageList")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCVirtualBGImageInfo[] BGImageList (this MobileRTCMeetingService This)
		{
			return CFArray.ArrayFromHandle<MobileRTCVirtualBGImageInfo>(global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getBGImageList")))!;
		}
		[Export ("enableGreenVB:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetError EnableGreenVB (this MobileRTCMeetingService This, bool enable)
		{
			MobileRTCMeetError ret;
			ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_bool (This.Handle, Selector.GetHandle ("enableGreenVB:"), enable);
			return ret!;
		}
		[Export ("isSupportSmartVirtualBG")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsSupportSmartVirtualBG (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSupportSmartVirtualBG"));
		}
		[Export ("isSupportVirtualBG")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsSupportVirtualBG (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isSupportVirtualBG"));
		}
		[Export ("isUsingGreenVB")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsUsingGreenVB (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isUsingGreenVB"));
		}
		[Export ("removeBGImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetError RemoveBGImage (this MobileRTCMeetingService This, MobileRTCVirtualBGImageInfo bgImageInfo)
		{
			var bgImageInfo__handle__ = bgImageInfo!.GetNonNullHandle (nameof (bgImageInfo));
			MobileRTCMeetError ret;
			ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("removeBGImage:"), bgImageInfo__handle__);
			return ret!;
		}
		[Export ("selectGreenVBPoint:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetError SelectGreenVBPoint (this MobileRTCMeetingService This, CGPoint point)
		{
			MobileRTCMeetError ret;
			ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_CGPoint (This.Handle, Selector.GetHandle ("selectGreenVBPoint:"), point);
			return ret!;
		}
		[Export ("startPreviewWithFrame:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool StartPreviewWithFrame (this MobileRTCMeetingService This, CGRect frame)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend_CGRect (This.Handle, Selector.GetHandle ("startPreviewWithFrame:"), frame);
		}
		[Export ("useBGImage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetError UseBGImage (this MobileRTCMeetingService This, MobileRTCVirtualBGImageInfo bgImage)
		{
			var bgImage__handle__ = bgImage!.GetNonNullHandle (nameof (bgImage));
			MobileRTCMeetError ret;
			ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("useBGImage:"), bgImage__handle__);
			return ret!;
		}
		[Export ("useNoneImage")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetError UseNoneImage (this MobileRTCMeetingService This)
		{
			MobileRTCMeetError ret;
			ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("useNoneImage"));
			return ret!;
		}
	} /* class MobileRTCMeetingService_VirtualBackground */
}
