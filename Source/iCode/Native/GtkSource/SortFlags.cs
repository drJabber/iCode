// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

using System;
using System.Runtime.InteropServices;

namespace iCode.Native.GtkSource {
	#region Autogenerated code
	[Flags]
	[GLib.GType (typeof (GtkSource.SortFlagsGType))]
	public enum SortFlags {

		None = 0,
		CaseSensitive = 1,
		ReverseOrder = 2,
		RemoveDuplicates = 4,
	}

	internal class SortFlagsGType {
		[DllImport ("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_sort_flags_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_source_sort_flags_get_type ());
			}
		}
	}
#endregion
}