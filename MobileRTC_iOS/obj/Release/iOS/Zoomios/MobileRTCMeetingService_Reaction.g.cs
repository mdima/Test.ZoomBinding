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
	public unsafe static partial class MobileRTCMeetingService_Reaction  {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingService");
		[Export ("isEmojiReactionEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool IsEmojiReactionEnabled (this MobileRTCMeetingService This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isEmojiReactionEnabled"));
		}
		[Export ("sendEmojiReaction:reactionSkinTone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetError SendEmojiReaction (this MobileRTCMeetingService This, MobileRTCEmojiReactionType type, MobileRTCEmojiReactionSkinTone skinTone)
		{
			MobileRTCMeetError ret;
			ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("sendEmojiReaction:reactionSkinTone:"), (UIntPtr) (ulong) type, (UIntPtr) (ulong) skinTone);
			return ret!;
		}
		[Export ("sendEmojiReaction:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static MobileRTCMeetError SendEmojiReaction (this MobileRTCMeetingService This, MobileRTCEmojiReactionType type)
		{
			MobileRTCMeetError ret;
			ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("sendEmojiReaction:"), (UIntPtr) (ulong) type);
			return ret!;
		}
	} /* class MobileRTCMeetingService_Reaction */
}
