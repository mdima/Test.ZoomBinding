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
namespace ObjCRuntime {
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action))]
		internal delegate void DAction (IntPtr block);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDAction {
			static internal readonly DAction Handler = Invoke;
			[MonoPInvokeCallback (typeof (DAction))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDAction */
		internal sealed class NIDAction : TrampolineBlockBase {
			DAction invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDAction (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DAction> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action) GetExistingManagedDelegate (block);
				return del ?? new NIDAction ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke ()
			{
				invoker (BlockPointer);
			}
		} /* class NIDAction */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<bool>))]
		internal delegate void DActionArity1V0 (IntPtr block, bool obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, bool obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<bool>) (descriptor->Target);
				if (del != null)
					del (obj);
			}
		} /* class SDActionArity1V0 */
		internal sealed class NIDActionArity1V0 : TrampolineBlockBase {
			DActionArity1V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<bool>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<bool>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (bool obj)
			{
				invoker (BlockPointer, obj);
			}
		} /* class NIDActionArity1V0 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSString, NSString, bool>))]
		internal delegate void DActionArity3V0 (IntPtr block, IntPtr arg1, IntPtr arg2, bool arg3);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity3V0 {
			static internal readonly DActionArity3V0 Handler = Invoke;
			[MonoPInvokeCallback (typeof (DActionArity3V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, IntPtr arg2, bool arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSString, NSString, bool>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSString> (arg1)!,  Runtime.GetNSObject<NSString> (arg2)!, arg3);
			}
		} /* class SDActionArity3V0 */
		internal sealed class NIDActionArity3V0 : TrampolineBlockBase {
			DActionArity3V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity3V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity3V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSString, NSString, bool>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSString, NSString, bool>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity3V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSString arg1, NSString arg2, bool arg3)
			{
				var arg1__handle__ = arg1.GetHandle ();
				var arg2__handle__ = arg2.GetHandle ();
				invoker (BlockPointer, arg1__handle__, arg2__handle__, arg3);
			}
		} /* class NIDActionArity3V0 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<NSString, nuint, NSString, NSString, bool>))]
		internal delegate void DActionArity5V0 (IntPtr block, IntPtr arg1, nuint arg2, IntPtr arg3, IntPtr arg4, bool arg5);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity5V0 {
			static internal readonly DActionArity5V0 Handler = Invoke;
			[MonoPInvokeCallback (typeof (DActionArity5V0))]
			static unsafe void Invoke (IntPtr block, IntPtr arg1, nuint arg2, IntPtr arg3, IntPtr arg4, bool arg5) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<NSString, nuint, NSString, NSString, bool>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<NSString> (arg1)!, arg2,  Runtime.GetNSObject<NSString> (arg3)!,  Runtime.GetNSObject<NSString> (arg4)!, arg5);
			}
		} /* class SDActionArity5V0 */
		internal sealed class NIDActionArity5V0 : TrampolineBlockBase {
			DActionArity5V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity5V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity5V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<NSString, nuint, NSString, NSString, bool>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<NSString, nuint, NSString, NSString, bool>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity5V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (NSString arg1, nuint arg2, NSString arg3, NSString arg4, bool arg5)
			{
				var arg1__handle__ = arg1.GetHandle ();
				var arg3__handle__ = arg3.GetHandle ();
				var arg4__handle__ = arg4.GetHandle ();
				invoker (BlockPointer, arg1__handle__, arg2, arg3__handle__, arg4__handle__, arg5);
			}
		} /* class NIDActionArity5V0 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Func<global::UIKit.UIViewController, bool>))]
		internal delegate bool DFuncArity2V0 (IntPtr block, IntPtr arg);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity2V0 {
			static internal readonly DFuncArity2V0 Handler = Invoke;
			[MonoPInvokeCallback (typeof (DFuncArity2V0))]
			static unsafe bool Invoke (IntPtr block, IntPtr arg) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<global::UIKit.UIViewController, bool>) (descriptor->Target);
				bool retval = del ( Runtime.GetNSObject<UIViewController> (arg)!);
				return retval;
			}
		} /* class SDFuncArity2V0 */
		internal sealed class NIDFuncArity2V0 : TrampolineBlockBase {
			DFuncArity2V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDFuncArity2V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DFuncArity2V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Func<global::UIKit.UIViewController, bool>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Func<global::UIKit.UIViewController, bool>) GetExistingManagedDelegate (block);
				return del ?? new NIDFuncArity2V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe bool Invoke (global::UIKit.UIViewController arg)
			{
				var arg__handle__ = arg.GetHandle ();
				var ret = invoker (BlockPointer, arg__handle__);
				return ret!;
			}
		} /* class NIDFuncArity2V0 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Func<NSString, NSString, bool, bool>))]
		internal delegate bool DFuncArity4V0 (IntPtr block, IntPtr arg1, IntPtr arg2, bool arg3);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity4V0 {
			static internal readonly DFuncArity4V0 Handler = Invoke;
			[MonoPInvokeCallback (typeof (DFuncArity4V0))]
			static unsafe bool Invoke (IntPtr block, IntPtr arg1, IntPtr arg2, bool arg3) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<NSString, NSString, bool, bool>) (descriptor->Target);
				bool retval = del ( Runtime.GetNSObject<NSString> (arg1)!,  Runtime.GetNSObject<NSString> (arg2)!, arg3);
				return retval;
			}
		} /* class SDFuncArity4V0 */
		internal sealed class NIDFuncArity4V0 : TrampolineBlockBase {
			DFuncArity4V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDFuncArity4V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DFuncArity4V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Func<NSString, NSString, bool, bool>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Func<NSString, NSString, bool, bool>) GetExistingManagedDelegate (block);
				return del ?? new NIDFuncArity4V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe bool Invoke (NSString arg1, NSString arg2, bool arg3)
			{
				var arg1__handle__ = arg1.GetHandle ();
				var arg2__handle__ = arg2.GetHandle ();
				var ret = invoker (BlockPointer, arg1__handle__, arg2__handle__, arg3);
				return ret!;
			}
		} /* class NIDFuncArity4V0 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::Zoomios.MobileRTCMeetingInviteActionItemBlock))]
		internal delegate void DMobileRTCMeetingInviteActionItemBlock (IntPtr block);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDMobileRTCMeetingInviteActionItemBlock {
			static internal readonly DMobileRTCMeetingInviteActionItemBlock Handler = Invoke;
			[MonoPInvokeCallback (typeof (DMobileRTCMeetingInviteActionItemBlock))]
			static unsafe void Invoke (IntPtr block) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::Zoomios.MobileRTCMeetingInviteActionItemBlock) (descriptor->Target);
				if (del != null)
					del ();
			}
		} /* class SDMobileRTCMeetingInviteActionItemBlock */
		internal sealed class NIDMobileRTCMeetingInviteActionItemBlock : TrampolineBlockBase {
			DMobileRTCMeetingInviteActionItemBlock invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDMobileRTCMeetingInviteActionItemBlock (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DMobileRTCMeetingInviteActionItemBlock> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::Zoomios.MobileRTCMeetingInviteActionItemBlock? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::Zoomios.MobileRTCMeetingInviteActionItemBlock) GetExistingManagedDelegate (block);
				return del ?? new NIDMobileRTCMeetingInviteActionItemBlock ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke ()
			{
				invoker (BlockPointer);
			}
		} /* class NIDMobileRTCMeetingInviteActionItemBlock */
	}
}
