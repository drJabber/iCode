// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

using System;
using System.Runtime.InteropServices;

namespace iCode.Native.GtkSource {
	#region Autogenerated code
	[GLib.GType (typeof (GtkSource.FileLoaderErrorGType))]
	public enum FileLoaderError {

		TooBig = 0,
		EncodingAutoDetectionFailed = 1,
		ConversionFallback = 2,
	}

	internal class FileLoaderErrorGType {
		[DllImport ("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_file_loader_error_get_type ();

		public static GLib.GType GType {
			get {
				return new GLib.GType (gtk_source_file_loader_error_get_type ());
			}
		}
	}
#endregion
}