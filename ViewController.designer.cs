// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TP3_KPL
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField label { get; set; }

		[Action ("button:")]
		partial void button (AppKit.NSButton sender);

		[Action ("Inputan:")]
		partial void Inputan (AppKit.NSTextField sender);

		[Action ("Isian:")]
		partial void Isian (Foundation.NSObject sender);

		[Action ("label:")]
		partial void label (AppKit.NSTextField sender);

		[Action ("LabelNama:")]
		partial void LabelNama (Foundation.NSObject sender);

		[Action ("Output:")]
		partial void Output (AppKit.NSTokenField sender);

		[Action ("pencetan:")]
		partial void pencetan (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (label != null) {
				label.Dispose ();
				label = null;
			}
		}
	}
}
