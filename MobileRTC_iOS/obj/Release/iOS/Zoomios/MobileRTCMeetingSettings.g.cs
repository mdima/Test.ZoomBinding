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
	[Register("MobileRTCMeetingSettings", true)]
	public unsafe partial class MobileRTCMeetingSettings : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("MobileRTCMeetingSettings");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public MobileRTCMeetingSettings () : base (NSObjectFlag.Empty)
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
		protected MobileRTCMeetingSettings (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal MobileRTCMeetingSettings (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("callInDisabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CallInDisabled ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("callInDisabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("callInDisabled"));
			}
		}
		[Export ("callOutDisabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CallOutDisabled ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("callOutDisabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("callOutDisabled"));
			}
		}
		[Export ("copyMeetingUrlDisabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CopyMeetingUrlDisabled ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("copyMeetingUrlDisabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("copyMeetingUrlDisabled"));
			}
		}
		[Export ("disableCallIn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableCallIn (bool disabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("disableCallIn:"), disabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("disableCallIn:"), disabled);
			}
		}
		[Export ("disableCallOut:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableCallOut (bool disabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("disableCallOut:"), disabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("disableCallOut:"), disabled);
			}
		}
		[Export ("disableClearWebKitCache:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableClearWebKitCache (bool disabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("disableClearWebKitCache:"), disabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("disableClearWebKitCache:"), disabled);
			}
		}
		[Export ("disableCloudWhiteboard:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableCloudWhiteboard (bool disabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("disableCloudWhiteboard:"), disabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("disableCloudWhiteboard:"), disabled);
			}
		}
		[Export ("disableConfidentialWatermark:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisableConfidentialWatermark (bool disable)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_bool (this.Handle, Selector.GetHandle ("disableConfidentialWatermark:"), disable);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("disableConfidentialWatermark:"), disable);
			}
		}
		[Export ("disableCopyMeetingUrl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableCopyMeetingUrl (bool disabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("disableCopyMeetingUrl:"), disabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("disableCopyMeetingUrl:"), disabled);
			}
		}
		[Export ("disableDriveMode:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableDriveMode (bool disabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("disableDriveMode:"), disabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("disableDriveMode:"), disabled);
			}
		}
		[Export ("disableFreeMeetingUpgradeTips:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableFreeMeetingUpgradeTips (bool disabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("disableFreeMeetingUpgradeTips:"), disabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("disableFreeMeetingUpgradeTips:"), disabled);
			}
		}
		[Export ("disableGalleryView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableGalleryView (bool disabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("disableGalleryView:"), disabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("disableGalleryView:"), disabled);
			}
		}
		[Export ("disableMinimizeMeeting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableMinimizeMeeting (bool disabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("disableMinimizeMeeting:"), disabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("disableMinimizeMeeting:"), disabled);
			}
		}
		[Export ("disableShowVideoPreviewWhenJoinMeeting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableShowVideoPreviewWhenJoinMeeting (bool disabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("disableShowVideoPreviewWhenJoinMeeting:"), disabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("disableShowVideoPreviewWhenJoinMeeting:"), disabled);
			}
		}
		[Export ("disableVirtualBackground:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisableVirtualBackground (bool disabled)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("disableVirtualBackground:"), disabled);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("disableVirtualBackground:"), disabled);
			}
		}
		[Export ("driveModeDisabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DriveModeDisabled ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("driveModeDisabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("driveModeDisabled"));
			}
		}
		[Export ("enableMicOriginalInput:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnableMicOriginalInput (bool enable)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("enableMicOriginalInput:"), enable);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("enableMicOriginalInput:"), enable);
			}
		}
		[Export ("enableMirrorEffect:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnableMirrorEffect (bool enable)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("enableMirrorEffect:"), enable);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("enableMirrorEffect:"), enable);
			}
		}
		[Export ("enableShowMyMeetingElapseTime:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void EnableShowMyMeetingElapseTime (bool enable)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("enableShowMyMeetingElapseTime:"), enable);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("enableShowMyMeetingElapseTime:"), enable);
			}
		}
		[Export ("faceBeautyEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FaceBeautyEnabled ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("faceBeautyEnabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("faceBeautyEnabled"));
			}
		}
		[Export ("freeMeetingUpgradeTipsDisabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool FreeMeetingUpgradeTipsDisabled ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("freeMeetingUpgradeTipsDisabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("freeMeetingUpgradeTipsDisabled"));
			}
		}
		[Export ("galleryViewDisabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool GalleryViewDisabled ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("galleryViewDisabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("galleryViewDisabled"));
			}
		}
		[Export ("hideReactionsOnMeetingUI:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void HideReactionsOnMeetingUI (bool hidden)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("hideReactionsOnMeetingUI:"), hidden);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("hideReactionsOnMeetingUI:"), hidden);
			}
		}
		[Export ("isDisabledClearWebKitCache")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsDisabledClearWebKitCache ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isDisabledClearWebKitCache"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isDisabledClearWebKitCache"));
			}
		}
		[Export ("isMirrorEffectEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool IsMirrorEffectEnabled ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("isMirrorEffectEnabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("isMirrorEffectEnabled"));
			}
		}
		[Export ("micOriginalInputEnabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MicOriginalInputEnabled ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("micOriginalInputEnabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("micOriginalInputEnabled"));
			}
		}
		[Export ("minimizeMeetingDisabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MinimizeMeetingDisabled ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("minimizeMeetingDisabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("minimizeMeetingDisabled"));
			}
		}
		[Export ("muteAudioWhenJoinMeeting")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MuteAudioWhenJoinMeeting ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("muteAudioWhenJoinMeeting"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("muteAudioWhenJoinMeeting"));
			}
		}
		[Export ("muteVideoWhenJoinMeeting")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MuteVideoWhenJoinMeeting ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("muteVideoWhenJoinMeeting"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("muteVideoWhenJoinMeeting"));
			}
		}
		[Export ("prePopulateWebinarRegistrationInfo:username:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void PrePopulateWebinarRegistrationInfo (string email, string username)
		{
			if (email is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (email));
			if (username is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (username));
			var nsemail = CFString.CreateNative (email);
			var nsusername = CFString.CreateNative (username);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("prePopulateWebinarRegistrationInfo:username:"), nsemail, nsusername);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("prePopulateWebinarRegistrationInfo:username:"), nsemail, nsusername);
			}
			CFString.ReleaseNative (nsemail);
			CFString.ReleaseNative (nsusername);
		}
		[Export ("reactionSkinTone")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCEmojiReactionSkinTone ReactionSkinTone ()
		{
			MobileRTCEmojiReactionSkinTone ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCEmojiReactionSkinTone) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("reactionSkinTone"));
			} else {
				ret = (Zoomios.MobileRTCEmojiReactionSkinTone) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reactionSkinTone"));
			}
			return ret!;
		}
		[Export ("reactionsOnMeetingUIHidden")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ReactionsOnMeetingUIHidden ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("reactionsOnMeetingUIHidden"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("reactionsOnMeetingUIHidden"));
			}
		}
		[Export ("setFaceBeautyEnabled:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetFaceBeautyEnabled (bool enable)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setFaceBeautyEnabled:"), enable);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setFaceBeautyEnabled:"), enable);
			}
		}
		[Export ("setMuteAudioWhenJoinMeeting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMuteAudioWhenJoinMeeting (bool muted)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMuteAudioWhenJoinMeeting:"), muted);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMuteAudioWhenJoinMeeting:"), muted);
			}
		}
		[Export ("setMuteVideoWhenJoinMeeting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetMuteVideoWhenJoinMeeting (bool muted)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMuteVideoWhenJoinMeeting:"), muted);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMuteVideoWhenJoinMeeting:"), muted);
			}
		}
		[Export ("setReactionSkinTone:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual MobileRTCMeetError SetReactionSkinTone (MobileRTCEmojiReactionSkinTone skinTone)
		{
			MobileRTCMeetError ret;
			if (IsDirectBinding) {
				ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSend_UIntPtr (this.Handle, Selector.GetHandle ("setReactionSkinTone:"), (UIntPtr) (ulong) skinTone);
			} else {
				ret = (Zoomios.MobileRTCMeetError) (ulong) global::ApiDefinition.Messaging.UIntPtr_objc_msgSendSuper_UIntPtr (this.SuperHandle, Selector.GetHandle ("setReactionSkinTone:"), (UIntPtr) (ulong) skinTone);
			}
			return ret!;
		}
		[Export ("setSpeakerOffWhenInMeeting:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void SetSpeakerOffWhenInMeeting (bool speakerOff)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setSpeakerOffWhenInMeeting:"), speakerOff);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setSpeakerOffWhenInMeeting:"), speakerOff);
			}
		}
		[Export ("showMyMeetingElapseTime")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowMyMeetingElapseTime ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showMyMeetingElapseTime"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showMyMeetingElapseTime"));
			}
		}
		[Export ("showVideoPreviewWhenJoinMeetingDisabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ShowVideoPreviewWhenJoinMeetingDisabled ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("showVideoPreviewWhenJoinMeetingDisabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("showVideoPreviewWhenJoinMeetingDisabled"));
			}
		}
		[Export ("speakerOffWhenInMeeting")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool SpeakerOffWhenInMeeting ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("speakerOffWhenInMeeting"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("speakerOffWhenInMeeting"));
			}
		}
		[Export ("virtualBackgroundDisabled")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool VirtualBackgroundDisabled ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("virtualBackgroundDisabled"));
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("virtualBackgroundDisabled"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool AutoConnectInternetAudio {
			[Export ("autoConnectInternetAudio")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("autoConnectInternetAudio"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("autoConnectInternetAudio"));
				}
			}
			[Export ("setAutoConnectInternetAudio:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setAutoConnectInternetAudio:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setAutoConnectInternetAudio:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool BottomBarHidden {
			[Export ("bottomBarHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("bottomBarHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("bottomBarHidden"));
				}
			}
			[Export ("setBottomBarHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setBottomBarHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setBottomBarHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CallinRoomSystemHidden {
			[Export ("callinRoomSystemHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("callinRoomSystemHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("callinRoomSystemHidden"));
				}
			}
			[Export ("setCallinRoomSystemHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCallinRoomSystemHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCallinRoomSystemHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CalloutRoomSystemHidden {
			[Export ("calloutRoomSystemHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("calloutRoomSystemHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("calloutRoomSystemHidden"));
				}
			}
			[Export ("setCalloutRoomSystemHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCalloutRoomSystemHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCalloutRoomSystemHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ChangeToAttendeeHidden {
			[Export ("changeToAttendeeHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("changeToAttendeeHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("changeToAttendeeHidden"));
				}
			}
			[Export ("setChangeToAttendeeHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setChangeToAttendeeHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setChangeToAttendeeHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ClaimHostWithHostKeyHidden {
			[Export ("claimHostWithHostKeyHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("claimHostWithHostKeyHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("claimHostWithHostKeyHidden"));
				}
			}
			[Export ("setClaimHostWithHostKeyHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setClaimHostWithHostKeyHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setClaimHostWithHostKeyHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool CloseCaptionHidden {
			[Export ("closeCaptionHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("closeCaptionHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("closeCaptionHidden"));
				}
			}
			[Export ("setCloseCaptionHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setCloseCaptionHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setCloseCaptionHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisconnectAudioHidden {
			[Export ("disconnectAudioHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("disconnectAudioHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disconnectAudioHidden"));
				}
			}
			[Export ("setDisconnectAudioHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDisconnectAudioHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDisconnectAudioHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EnableCustomMeeting {
			[Export ("enableCustomMeeting")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableCustomMeeting"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableCustomMeeting"));
				}
			}
			[Export ("setEnableCustomMeeting:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableCustomMeeting:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableCustomMeeting:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool EnableKubi {
			[Export ("enableKubi")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("enableKubi"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("enableKubi"));
				}
			}
			[Export ("setEnableKubi:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setEnableKubi:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setEnableKubi:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HideFeedbackButtonOnCloudWhiteboard {
			[Export ("hideFeedbackButtonOnCloudWhiteboard")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hideFeedbackButtonOnCloudWhiteboard"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideFeedbackButtonOnCloudWhiteboard"));
				}
			}
			[Export ("setHideFeedbackButtonOnCloudWhiteboard:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHideFeedbackButtonOnCloudWhiteboard:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHideFeedbackButtonOnCloudWhiteboard:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HideShareButtonOnCloudWhiteboard {
			[Export ("hideShareButtonOnCloudWhiteboard")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hideShareButtonOnCloudWhiteboard"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hideShareButtonOnCloudWhiteboard"));
				}
			}
			[Export ("setHideShareButtonOnCloudWhiteboard:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHideShareButtonOnCloudWhiteboard:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHideShareButtonOnCloudWhiteboard:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HintHidden {
			[Export ("hintHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hintHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hintHidden"));
				}
			}
			[Export ("setHintHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHintHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHintHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HostLeaveHidden {
			[Export ("hostLeaveHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hostLeaveHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hostLeaveHidden"));
				}
			}
			[Export ("setHostLeaveHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHostLeaveHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHostLeaveHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MeetingAudioHidden {
			[Export ("meetingAudioHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("meetingAudioHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("meetingAudioHidden"));
				}
			}
			[Export ("setMeetingAudioHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMeetingAudioHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMeetingAudioHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MeetingChatHidden {
			[Export ("meetingChatHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("meetingChatHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("meetingChatHidden"));
				}
			}
			[Export ("setMeetingChatHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMeetingChatHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMeetingChatHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MeetingInviteHidden {
			[Export ("meetingInviteHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("meetingInviteHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("meetingInviteHidden"));
				}
			}
			[Export ("setMeetingInviteHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMeetingInviteHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMeetingInviteHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MeetingInviteUrlHidden {
			[Export ("meetingInviteUrlHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("meetingInviteUrlHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("meetingInviteUrlHidden"));
				}
			}
			[Export ("setMeetingInviteUrlHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMeetingInviteUrlHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMeetingInviteUrlHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MeetingLeaveHidden {
			[Export ("meetingLeaveHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("meetingLeaveHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("meetingLeaveHidden"));
				}
			}
			[Export ("setMeetingLeaveHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMeetingLeaveHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMeetingLeaveHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MeetingMoreHidden {
			[Export ("meetingMoreHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("meetingMoreHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("meetingMoreHidden"));
				}
			}
			[Export ("setMeetingMoreHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMeetingMoreHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMeetingMoreHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MeetingParticipantHidden {
			[Export ("meetingParticipantHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("meetingParticipantHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("meetingParticipantHidden"));
				}
			}
			[Export ("setMeetingParticipantHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMeetingParticipantHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMeetingParticipantHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MeetingPasswordHidden {
			[Export ("meetingPasswordHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("meetingPasswordHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("meetingPasswordHidden"));
				}
			}
			[Export ("setMeetingPasswordHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMeetingPasswordHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMeetingPasswordHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MeetingShareHidden {
			[Export ("meetingShareHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("meetingShareHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("meetingShareHidden"));
				}
			}
			[Export ("setMeetingShareHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMeetingShareHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMeetingShareHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MeetingTitleHidden {
			[Export ("meetingTitleHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("meetingTitleHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("meetingTitleHidden"));
				}
			}
			[Export ("setMeetingTitleHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMeetingTitleHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMeetingTitleHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool MeetingVideoHidden {
			[Export ("meetingVideoHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("meetingVideoHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("meetingVideoHidden"));
				}
			}
			[Export ("setMeetingVideoHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setMeetingVideoHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setMeetingVideoHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool PromoteToPanelistHidden {
			[Export ("promoteToPanelistHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("promoteToPanelistHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("promoteToPanelistHidden"));
				}
			}
			[Export ("setPromoteToPanelistHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setPromoteToPanelistHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setPromoteToPanelistHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ProximityMonitoringDisable {
			[Export ("proximityMonitoringDisable")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("proximityMonitoringDisable"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("proximityMonitoringDisable"));
				}
			}
			[Export ("setProximityMonitoringDisable:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setProximityMonitoringDisable:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setProximityMonitoringDisable:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool QaButtonHidden {
			[Export ("qaButtonHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("qaButtonHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("qaButtonHidden"));
				}
			}
			[Export ("setQaButtonHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setQaButtonHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setQaButtonHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool RecordButtonHidden {
			[Export ("recordButtonHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("recordButtonHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("recordButtonHidden"));
				}
			}
			[Export ("setRecordButtonHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setRecordButtonHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setRecordButtonHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool ThumbnailInShare {
			[Export ("thumbnailInShare")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("thumbnailInShare"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("thumbnailInShare"));
				}
			}
			[Export ("setThumbnailInShare:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setThumbnailInShare:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setThumbnailInShare:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool TopBarHidden {
			[Export ("topBarHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("topBarHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("topBarHidden"));
				}
			}
			[Export ("setTopBarHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setTopBarHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setTopBarHidden:"), value);
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool WaitingHUDHidden {
			[Export ("waitingHUDHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("waitingHUDHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("waitingHUDHidden"));
				}
			}
			[Export ("setWaitingHUDHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setWaitingHUDHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setWaitingHUDHidden:"), value);
				}
			}
		}
	} /* class MobileRTCMeetingSettings */
}
