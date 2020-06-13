// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class SourceBuffer {

		public SourceBuffer (IntPtr raw) : base(raw) {}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_buffer_new_with_language(IntPtr language);

		public SourceBuffer (Gtk.SourceLanguage language) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (SourceBuffer)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			Raw = gtk_source_buffer_new_with_language(language == null ? IntPtr.Zero : language.Handle);
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_source_buffer_get_implicit_trailing_newline(IntPtr raw);

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_buffer_set_implicit_trailing_newline(IntPtr raw, bool implicit_trailing_newline);

		[GLib.Property ("implicit-trailing-newline")]
		public bool ImplicitTrailingNewline {
			get  {
				bool raw_ret = gtk_source_buffer_get_implicit_trailing_newline(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set  {
				gtk_source_buffer_set_implicit_trailing_newline(Handle, value);
			}
		}

		[GLib.Signal("undo")]
		public event System.EventHandler Undo {
			add {
				this.AddSignalHandler ("undo", value);
			}
			remove {
				this.RemoveSignalHandler ("undo", value);
			}
		}

		[GLib.Signal("redo")]
		public event System.EventHandler Redo {
			add {
				this.AddSignalHandler ("redo", value);
			}
			remove {
				this.RemoveSignalHandler ("redo", value);
			}
		}

		static UndoNativeDelegate Undo_cb_delegate;
		static UndoNativeDelegate UndoVMCallback {
			get {
				if (Undo_cb_delegate == null)
					Undo_cb_delegate = new UndoNativeDelegate (Undo_cb);
				return Undo_cb_delegate;
			}
		}

		static void OverrideUndo (GLib.GType gtype)
		{
			OverrideUndo (gtype, UndoVMCallback);
		}

		static void OverrideUndo (GLib.GType gtype, UndoNativeDelegate callback)
		{
			GtkSourceBufferClass class_iface = GetClassStruct (gtype, false);
			class_iface.Undo = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void UndoNativeDelegate (IntPtr inst);

		static void Undo_cb (IntPtr inst)
		{
			try {
				SourceBuffer __obj = GLib.Object.GetObject (inst, false) as SourceBuffer;
				__obj.OnUndo ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.SourceBuffer), ConnectionMethod="OverrideUndo")]
		protected virtual void OnUndo ()
		{
			InternalUndo ();
		}

		private void InternalUndo ()
		{
			UndoNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Undo;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		static RedoNativeDelegate Redo_cb_delegate;
		static RedoNativeDelegate RedoVMCallback {
			get {
				if (Redo_cb_delegate == null)
					Redo_cb_delegate = new RedoNativeDelegate (Redo_cb);
				return Redo_cb_delegate;
			}
		}

		static void OverrideRedo (GLib.GType gtype)
		{
			OverrideRedo (gtype, RedoVMCallback);
		}

		static void OverrideRedo (GLib.GType gtype, RedoNativeDelegate callback)
		{
			GtkSourceBufferClass class_iface = GetClassStruct (gtype, false);
			class_iface.Redo = callback;
			OverrideClassStruct (gtype, class_iface);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RedoNativeDelegate (IntPtr inst);

		static void Redo_cb (IntPtr inst)
		{
			try {
				SourceBuffer __obj = GLib.Object.GetObject (inst, false) as SourceBuffer;
				__obj.OnRedo ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.SourceBuffer), ConnectionMethod="OverrideRedo")]
		protected virtual void OnRedo ()
		{
			InternalRedo ();
		}

		private void InternalRedo ()
		{
			RedoNativeDelegate unmanaged = GetClassStruct (this.LookupGType ().GetThresholdType (), true).Redo;
			if (unmanaged == null) return;

			unmanaged (this.Handle);
		}

		[StructLayout (LayoutKind.Sequential)]
		struct GtkSourceBufferClass {
			public UndoNativeDelegate Undo;
			public RedoNativeDelegate Redo;
			IntPtr BracketMatched;
			[MarshalAs (UnmanagedType.ByValArray, SizeConst=20)]
			private IntPtr[] Padding;
		}

		static uint class_offset = 0;
		static Dictionary<GLib.GType, GtkSourceBufferClass> class_structs;

		static GtkSourceBufferClass GetClassStruct (GLib.GType gtype, bool use_cache)
		{
			if (class_structs == null)
				class_structs = new Dictionary<GLib.GType, GtkSourceBufferClass> ();

			if (use_cache && class_structs.ContainsKey (gtype))
				return class_structs [gtype];
			else {
				IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
				GtkSourceBufferClass class_struct = (GtkSourceBufferClass) Marshal.PtrToStructure (class_ptr, typeof (GtkSourceBufferClass));
				if (use_cache)
					class_structs.Add (gtype, class_struct);
				return class_struct;
			}
		}

		static void OverrideClassStruct (GLib.GType gtype, GtkSourceBufferClass class_struct)
		{
			IntPtr class_ptr = new IntPtr (gtype.GetClassPtr ().ToInt64 () + class_offset);
			Marshal.StructureToPtr (class_struct, class_ptr, false);
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_buffer_begin_not_undoable_action(IntPtr raw);

		public void BeginNotUndoableAction() {
			gtk_source_buffer_begin_not_undoable_action(Handle);
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_source_buffer_can_redo(IntPtr raw);

		public bool CanRedo() {
			bool raw_ret = gtk_source_buffer_can_redo(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_source_buffer_can_undo(IntPtr raw);

		public bool CanUndo() {
			bool raw_ret = gtk_source_buffer_can_undo(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_buffer_end_not_undoable_action(IntPtr raw);

		public void EndNotUndoableAction() {
			gtk_source_buffer_end_not_undoable_action(Handle);
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_source_buffer_get_highlight_matching_brackets(IntPtr raw);

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_buffer_set_highlight_matching_brackets(IntPtr raw, bool highlight);

		public bool HighlightMatchingBrackets { 
			get {
				bool raw_ret = gtk_source_buffer_get_highlight_matching_brackets(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_source_buffer_set_highlight_matching_brackets(Handle, value);
			}
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_source_buffer_get_highlight_syntax(IntPtr raw);

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_buffer_set_highlight_syntax(IntPtr raw, bool highlight);

		public bool HighlightSyntax { 
			get {
				bool raw_ret = gtk_source_buffer_get_highlight_syntax(Handle);
				bool ret = raw_ret;
				return ret;
			}
			set {
				gtk_source_buffer_set_highlight_syntax(Handle, value);
			}
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_buffer_get_language(IntPtr raw);

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_buffer_set_language(IntPtr raw, IntPtr language);

		public Gtk.SourceLanguage Language { 
			get {
				IntPtr raw_ret = gtk_source_buffer_get_language(Handle);
				Gtk.SourceLanguage ret = GLib.Object.GetObject(raw_ret) as Gtk.SourceLanguage;
				return ret;
			}
			set {
				gtk_source_buffer_set_language(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_source_buffer_get_max_undo_levels(IntPtr raw);

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_buffer_set_max_undo_levels(IntPtr raw, int max_undo_levels);

		public int MaxUndoLevels { 
			get {
				int raw_ret = gtk_source_buffer_get_max_undo_levels(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				gtk_source_buffer_set_max_undo_levels(Handle, value);
			}
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_buffer_get_source_marks_at_line(IntPtr raw, int line, IntPtr category);

		public GLib.SList GetSourceMarksAtLine(int line, string category) {
			IntPtr native_category = GLib.Marshaller.StringToPtrGStrdup (category);
			IntPtr raw_ret = gtk_source_buffer_get_source_marks_at_line(Handle, line, native_category);
			GLib.SList ret = new GLib.SList(raw_ret);
			GLib.Marshaller.Free (native_category);
			return ret;
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_buffer_get_style_scheme(IntPtr raw);

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_buffer_set_style_scheme(IntPtr raw, IntPtr scheme);

		public Gtk.SourceStyleScheme StyleScheme { 
			get {
				IntPtr raw_ret = gtk_source_buffer_get_style_scheme(Handle);
				Gtk.SourceStyleScheme ret = GLib.Object.GetObject(raw_ret) as Gtk.SourceStyleScheme;
				return ret;
			}
			set {
				gtk_source_buffer_set_style_scheme(Handle, value == null ? IntPtr.Zero : value.Handle);
			}
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_buffer_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_source_buffer_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_source_buffer_get_undo_manager(IntPtr raw);

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_buffer_set_undo_manager(IntPtr raw, IntPtr manager);

		public Gtk.ISourceUndoManager UndoManager { 
			get {
				IntPtr raw_ret = gtk_source_buffer_get_undo_manager(Handle);
				Gtk.ISourceUndoManager ret = Gtk.SourceUndoManagerAdapter.GetObject (raw_ret, false);
				return ret;
			}
			set {
				gtk_source_buffer_set_undo_manager(Handle, value == null ? IntPtr.Zero : ((value is GLib.Object) ? (value as GLib.Object).Handle : (value as Gtk.SourceUndoManagerAdapter).Handle));
			}
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_buffer_redo(IntPtr raw);

		public void Redo() {
			gtk_source_buffer_redo(Handle);
		}

		[DllImport("gtksourceview-4", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_source_buffer_undo(IntPtr raw);

		public void Undo() {
			gtk_source_buffer_undo(Handle);
		}

#endregion
	}
}