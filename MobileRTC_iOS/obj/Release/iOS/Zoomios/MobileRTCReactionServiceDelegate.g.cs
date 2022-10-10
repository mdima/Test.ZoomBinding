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
	[Protocol (Name = "MobileRTCReactionServiceDelegate", WrapperType = typeof (MobileRTCReactionServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnEmojiReactionReceived", Selector = "onEmojiReactionReceived:reactionType:reactionSkinTone:", ParameterType = new Type [] { typeof (nuint), typeof (Zoomios.MobileRTCEmojiReactionType), typeof (Zoomios.MobileRTCEmojiReactionSkinTone) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnEmojiReactionReceivedInWebinar", Selector = "onEmojiReactionReceivedInWebinar:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCEmojiReactionType) }, ParameterByRef = new bool [] { false })]
	public partial interface IMobileRTCReactionServiceDelegate : INativeObject, IDisposable, 
		Zoomios.IIMobileRTCMeetingServiceDelegate
	{
	}
	public static partial class MobileRTCReactionServiceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnEmojiReactionReceived (this IMobileRTCReactionServiceDelegate This, nuint userId, MobileRTCEmojiReactionType type, MobileRTCEmojiReactionSkinTone skinTone)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_UIntPtr_UIntPtr (This.Handle, Selector.GetHandle ("onEmojiReactionReceived:reactionType:reactionSkinTone:"), (UIntPtr) userId, (UIntPtr) (ulong) type, (UIntPtr) (ulong) skinTone);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnEmojiReactionReceivedInWebinar (this IMobileRTCReactionServiceDelegate This, MobileRTCEmojiReactionType type)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr (This.Handle, Selector.GetHandle ("onEmojiReactionReceivedInWebinar:"), (UIntPtr) (ulong) type);
		}
	}
	internal sealed class MobileRTCReactionServiceDelegateWrapper : BaseWrapper, IMobileRTCReactionServiceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCReactionServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
