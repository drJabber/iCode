// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace iCode.Native.GtkSource {
	public delegate void ChangeCaseHandler(object o, ChangeCaseArgs args);

	public class ChangeCaseArgs : GLib.SignalArgs {
		public GtkSource.ChangeCaseType CaseType{
			get {
				return (GtkSource.ChangeCaseType) Args [0];
			}
		}

	}
}