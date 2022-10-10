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
	[Protocol (Name = "MobileRTCInterpretationServiceDelegate", WrapperType = typeof (MobileRTCInterpretationServiceDelegateWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnInterpretationStart", Selector = "onInterpretationStart")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnInterpretationStop", Selector = "onInterpretationStop")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnInterpreterListChanged", Selector = "onInterpreterListChanged")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnInterpreterRoleChanged", Selector = "onInterpreterRoleChanged:isInterpreter:", ParameterType = new Type [] { typeof (nuint), typeof (bool) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnInterpreterActiveLanguageChanged", Selector = "onInterpreterActiveLanguageChanged:activeLanguageId:", ParameterType = new Type [] { typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnInterpreterLanguageChanged", Selector = "onInterpreterLanguageChanged:andLanguage2:", ParameterType = new Type [] { typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnAvailableLanguageListUpdated", Selector = "onAvailableLanguageListUpdated:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCInterpretationLanguage[]) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "OnInterpreterLanguagesUpdated", Selector = "onInterpreterLanguagesUpdated:", ParameterType = new Type [] { typeof (Zoomios.MobileRTCInterpretationLanguage[]) }, ParameterByRef = new bool [] { false })]
	public partial interface IMobileRTCInterpretationServiceDelegate : INativeObject, IDisposable, 
		Zoomios.IIMobileRTCMeetingServiceDelegate
	{
	}
	public static partial class MobileRTCInterpretationServiceDelegate_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnInterpretationStart (this IMobileRTCInterpretationServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onInterpretationStart"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnInterpretationStop (this IMobileRTCInterpretationServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onInterpretationStop"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnInterpreterListChanged (this IMobileRTCInterpretationServiceDelegate This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("onInterpreterListChanged"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnInterpreterRoleChanged (this IMobileRTCInterpretationServiceDelegate This, nuint userID, bool isInterpreter)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_UIntPtr_bool (This.Handle, Selector.GetHandle ("onInterpreterRoleChanged:isInterpreter:"), (UIntPtr) userID, isInterpreter);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnInterpreterActiveLanguageChanged (this IMobileRTCInterpretationServiceDelegate This, nint userID, nint activeLanID)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onInterpreterActiveLanguageChanged:activeLanguageId:"), (IntPtr) userID, (IntPtr) activeLanID);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnInterpreterLanguageChanged (this IMobileRTCInterpretationServiceDelegate This, nint lanID1, nint lanID2)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("onInterpreterLanguageChanged:andLanguage2:"), (IntPtr) lanID1, (IntPtr) lanID2);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnAvailableLanguageListUpdated (this IMobileRTCInterpretationServiceDelegate This, MobileRTCInterpretationLanguage[]? availableLanguageList)
		{
			var nsa_availableLanguageList = availableLanguageList is null ? null : NSArray.FromNSObjects (availableLanguageList);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onAvailableLanguageListUpdated:"), nsa_availableLanguageList.GetHandle ());
			if (nsa_availableLanguageList != null)
				nsa_availableLanguageList.Dispose ();
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void OnInterpreterLanguagesUpdated (this IMobileRTCInterpretationServiceDelegate This, MobileRTCInterpretationLanguage[]? availableLanguages)
		{
			var nsa_availableLanguages = availableLanguages is null ? null : NSArray.FromNSObjects (availableLanguages);
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("onInterpreterLanguagesUpdated:"), nsa_availableLanguages.GetHandle ());
			if (nsa_availableLanguages != null)
				nsa_availableLanguages.Dispose ();
		}
	}
	internal sealed class MobileRTCInterpretationServiceDelegateWrapper : BaseWrapper, IMobileRTCInterpretationServiceDelegate {
		[Preserve (Conditional = true)]
		public MobileRTCInterpretationServiceDelegateWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
