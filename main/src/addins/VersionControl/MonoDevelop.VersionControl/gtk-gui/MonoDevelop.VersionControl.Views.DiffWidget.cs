
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.VersionControl.Views
{
	public partial class DiffWidget
	{
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.HBox hbox2;
		
		private global::Gtk.Fixed fixed1;
		
		private global::Gtk.Label labelOverview;
		
		private global::Gtk.Button buttonDiff;
		
		private global::Gtk.Button buttonNext;
		
		private global::Gtk.Button buttonPrev;
		
		private global::Gtk.Notebook notebook1;
		
		private global::Gtk.VBox vboxComparisonView;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.ScrolledWindow scrolledwindow1;
		
		private global::Gtk.Label label3;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.VersionControl.Views.DiffWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.VersionControl.Views.DiffWidget";
			// Container child MonoDevelop.VersionControl.Views.DiffWidget.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.fixed1 = new global::Gtk.Fixed ();
			this.fixed1.Name = "fixed1";
			this.fixed1.HasWindow = false;
			this.hbox2.Add (this.fixed1);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.fixed1]));
			w1.Position = 0;
			w1.Expand = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.labelOverview = new global::Gtk.Label ();
			this.labelOverview.Name = "labelOverview";
			this.hbox2.Add (this.labelOverview);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.labelOverview]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox2.Gtk.Box+BoxChild
			this.buttonDiff = new global::Gtk.Button ();
			this.buttonDiff.CanFocus = true;
			this.buttonDiff.Name = "buttonDiff";
			this.buttonDiff.UseUnderline = true;
			this.buttonDiff.Label = global::Mono.Unix.Catalog.GetString ("_Patch");
			this.hbox2.Add (this.buttonDiff);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.buttonDiff]));
			w3.PackType = ((global::Gtk.PackType)(1));
			w3.Position = 2;
			w3.Expand = false;
			w3.Fill = false;
			this.hbox1.Add (this.hbox2);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.hbox2]));
			w4.Position = 0;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonNext = new global::Gtk.Button ();
			this.buttonNext.CanFocus = true;
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.UseStock = true;
			this.buttonNext.UseUnderline = true;
			this.buttonNext.Label = "gtk-go-forward";
			this.hbox1.Add (this.buttonNext);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonNext]));
			w5.PackType = ((global::Gtk.PackType)(1));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.buttonPrev = new global::Gtk.Button ();
			this.buttonPrev.CanFocus = true;
			this.buttonPrev.Name = "buttonPrev";
			this.buttonPrev.UseStock = true;
			this.buttonPrev.UseUnderline = true;
			this.buttonPrev.Label = "gtk-go-back";
			this.hbox1.Add (this.buttonPrev);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.buttonPrev]));
			w6.PackType = ((global::Gtk.PackType)(1));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox2.Add (this.hbox1);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox1]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 0;
			this.notebook1.ShowBorder = false;
			this.notebook1.ShowTabs = false;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.vboxComparisonView = new global::Gtk.VBox ();
			this.vboxComparisonView.Name = "vboxComparisonView";
			this.vboxComparisonView.Spacing = 6;
			this.notebook1.Add (this.vboxComparisonView);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("page2");
			this.notebook1.SetTabLabel (this.vboxComparisonView,this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			this.notebook1.Add (this.scrolledwindow1);
			global::Gtk.Notebook.NotebookChild w9 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.scrolledwindow1]));
			w9.Position = 1;
			// Notebook tab
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("page2");
			this.notebook1.SetTabLabel (this.scrolledwindow1,this.label3);
			this.label3.ShowAll ();
			this.vbox2.Add (this.notebook1);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.notebook1]));
			w10.Position = 1;
			this.Add (this.vbox2);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Hide ();
		}
	}
}