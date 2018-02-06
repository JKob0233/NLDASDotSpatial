namespace DotSpatTopology
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlOperations = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapefileOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPointShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePointShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polylineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPolylineShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolylineShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPolygonShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePolygonShapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToExtentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attributeTableOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAttributeTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAttributeTableToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAttribute = new System.Windows.Forms.Panel();
            this.dgvAttributeTable = new System.Windows.Forms.DataGridView();
            this.sdmDockManger = new DotSpatial.Controls.SpatialDockManager();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Legend1 = new DotSpatial.Controls.Legend();
            this.map1 = new DotSpatial.Controls.Map();
            this.spatialHeaderControl1 = new DotSpatial.Controls.SpatialHeaderControl();
            this.pnlOperations.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlAttribute.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sdmDockManger)).BeginInit();
            this.sdmDockManger.Panel1.SuspendLayout();
            this.sdmDockManger.Panel2.SuspendLayout();
            this.sdmDockManger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spatialHeaderControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOperations
            // 
            this.pnlOperations.Controls.Add(this.menuStrip1);
            this.pnlOperations.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOperations.Location = new System.Drawing.Point(0, 0);
            this.pnlOperations.Name = "pnlOperations";
            this.pnlOperations.Size = new System.Drawing.Size(629, 33);
            this.pnlOperations.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.shapefileOperationsToolStripMenuItem,
            this.mapOptionsToolStripMenuItem,
            this.attributeTableOperationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // shapefileOperationsToolStripMenuItem
            // 
            this.shapefileOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pointToolStripMenuItem,
            this.polylineToolStripMenuItem,
            this.polygonToolStripMenuItem});
            this.shapefileOperationsToolStripMenuItem.Name = "shapefileOperationsToolStripMenuItem";
            this.shapefileOperationsToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.shapefileOperationsToolStripMenuItem.Text = "Shapefile Operations";
            // 
            // pointToolStripMenuItem
            // 
            this.pointToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPointShapefileToolStripMenuItem,
            this.savePointShapefileToolStripMenuItem});
            this.pointToolStripMenuItem.Name = "pointToolStripMenuItem";
            this.pointToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pointToolStripMenuItem.Text = "Point";
            // 
            // createPointShapefileToolStripMenuItem
            // 
            this.createPointShapefileToolStripMenuItem.Name = "createPointShapefileToolStripMenuItem";
            this.createPointShapefileToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.createPointShapefileToolStripMenuItem.Text = "Create Point Shapefile";
            this.createPointShapefileToolStripMenuItem.Click += new System.EventHandler(this.createPointShapefileToolStripMenuItem_Click);
            // 
            // savePointShapefileToolStripMenuItem
            // 
            this.savePointShapefileToolStripMenuItem.Name = "savePointShapefileToolStripMenuItem";
            this.savePointShapefileToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.savePointShapefileToolStripMenuItem.Text = "Save Point Shapefile";
            this.savePointShapefileToolStripMenuItem.Click += new System.EventHandler(this.savePointShapefileToolStripMenuItem_Click);
            // 
            // polylineToolStripMenuItem
            // 
            this.polylineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPolylineShapefileToolStripMenuItem,
            this.savePolylineShapefileToolStripMenuItem});
            this.polylineToolStripMenuItem.Name = "polylineToolStripMenuItem";
            this.polylineToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.polylineToolStripMenuItem.Text = "Polyline";
            // 
            // createPolylineShapefileToolStripMenuItem
            // 
            this.createPolylineShapefileToolStripMenuItem.Name = "createPolylineShapefileToolStripMenuItem";
            this.createPolylineShapefileToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.createPolylineShapefileToolStripMenuItem.Text = "Create Polyline Shapefile";
            this.createPolylineShapefileToolStripMenuItem.Click += new System.EventHandler(this.createPolylineShapefileToolStripMenuItem_Click);
            // 
            // savePolylineShapefileToolStripMenuItem
            // 
            this.savePolylineShapefileToolStripMenuItem.Name = "savePolylineShapefileToolStripMenuItem";
            this.savePolylineShapefileToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.savePolylineShapefileToolStripMenuItem.Text = "Save Polyline Shapefile";
            this.savePolylineShapefileToolStripMenuItem.Click += new System.EventHandler(this.savePolylineShapefileToolStripMenuItem_Click);
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPolygonShapefileToolStripMenuItem,
            this.savePolygonShapefileToolStripMenuItem});
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.polygonToolStripMenuItem.Text = "Polygon";
            // 
            // createPolygonShapefileToolStripMenuItem
            // 
            this.createPolygonShapefileToolStripMenuItem.Name = "createPolygonShapefileToolStripMenuItem";
            this.createPolygonShapefileToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.createPolygonShapefileToolStripMenuItem.Text = "Create Polygon Shapefile";
            this.createPolygonShapefileToolStripMenuItem.Click += new System.EventHandler(this.createPolygonShapefileToolStripMenuItem_Click);
            // 
            // savePolygonShapefileToolStripMenuItem
            // 
            this.savePolygonShapefileToolStripMenuItem.Name = "savePolygonShapefileToolStripMenuItem";
            this.savePolygonShapefileToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.savePolygonShapefileToolStripMenuItem.Text = "Save Polygon Shapefile";
            this.savePolygonShapefileToolStripMenuItem.Click += new System.EventHandler(this.savePolygonShapefileToolStripMenuItem_Click);
            // 
            // mapOptionsToolStripMenuItem
            // 
            this.mapOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.zoomINToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoomToExtentToolStripMenuItem,
            this.panToolStripMenuItem,
            this.printMapToolStripMenuItem});
            this.mapOptionsToolStripMenuItem.Name = "mapOptionsToolStripMenuItem";
            this.mapOptionsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.mapOptionsToolStripMenuItem.Text = "Map Options";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.informationToolStripMenuItem.Text = "Information";
            this.informationToolStripMenuItem.Click += new System.EventHandler(this.informationToolStripMenuItem_Click);
            // 
            // zoomINToolStripMenuItem
            // 
            this.zoomINToolStripMenuItem.Name = "zoomINToolStripMenuItem";
            this.zoomINToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zoomINToolStripMenuItem.Text = "Zoom In";
            this.zoomINToolStripMenuItem.Click += new System.EventHandler(this.zoomINToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // zoomToExtentToolStripMenuItem
            // 
            this.zoomToExtentToolStripMenuItem.Name = "zoomToExtentToolStripMenuItem";
            this.zoomToExtentToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zoomToExtentToolStripMenuItem.Text = "Zoom to Extent";
            this.zoomToExtentToolStripMenuItem.Click += new System.EventHandler(this.zoomToExtentToolStripMenuItem_Click);
            // 
            // panToolStripMenuItem
            // 
            this.panToolStripMenuItem.Name = "panToolStripMenuItem";
            this.panToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.panToolStripMenuItem.Text = "Pan";
            this.panToolStripMenuItem.Click += new System.EventHandler(this.panToolStripMenuItem_Click);
            // 
            // printMapToolStripMenuItem
            // 
            this.printMapToolStripMenuItem.Name = "printMapToolStripMenuItem";
            this.printMapToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.printMapToolStripMenuItem.Text = "Print Map";
            this.printMapToolStripMenuItem.Click += new System.EventHandler(this.printMapToolStripMenuItem_Click);
            // 
            // attributeTableOperationsToolStripMenuItem
            // 
            this.attributeTableOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAttributeTableToolStripMenuItem,
            this.addAColumnToolStripMenuItem,
            this.saveColumnToolStripMenuItem,
            this.deleteColumnToolStripMenuItem,
            this.exportAttributeTableToExcelToolStripMenuItem});
            this.attributeTableOperationsToolStripMenuItem.Name = "attributeTableOperationsToolStripMenuItem";
            this.attributeTableOperationsToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.attributeTableOperationsToolStripMenuItem.Text = "Attribute Table Operations";
            // 
            // viewAttributeTableToolStripMenuItem
            // 
            this.viewAttributeTableToolStripMenuItem.Name = "viewAttributeTableToolStripMenuItem";
            this.viewAttributeTableToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.viewAttributeTableToolStripMenuItem.Text = "View Attribute Table";
            this.viewAttributeTableToolStripMenuItem.Click += new System.EventHandler(this.viewAttributeTableToolStripMenuItem_Click);
            // 
            // addAColumnToolStripMenuItem
            // 
            this.addAColumnToolStripMenuItem.Name = "addAColumnToolStripMenuItem";
            this.addAColumnToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.addAColumnToolStripMenuItem.Text = "Add a Column";
            this.addAColumnToolStripMenuItem.Click += new System.EventHandler(this.addAColumnToolStripMenuItem_Click);
            // 
            // saveColumnToolStripMenuItem
            // 
            this.saveColumnToolStripMenuItem.Name = "saveColumnToolStripMenuItem";
            this.saveColumnToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.saveColumnToolStripMenuItem.Text = "Save Column  ";
            this.saveColumnToolStripMenuItem.Click += new System.EventHandler(this.saveColumnToolStripMenuItem_Click);
            // 
            // deleteColumnToolStripMenuItem
            // 
            this.deleteColumnToolStripMenuItem.Name = "deleteColumnToolStripMenuItem";
            this.deleteColumnToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.deleteColumnToolStripMenuItem.Text = "Delete Column";
            this.deleteColumnToolStripMenuItem.Click += new System.EventHandler(this.deleteColumnToolStripMenuItem_Click);
            // 
            // exportAttributeTableToExcelToolStripMenuItem
            // 
            this.exportAttributeTableToExcelToolStripMenuItem.Name = "exportAttributeTableToExcelToolStripMenuItem";
            this.exportAttributeTableToExcelToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.exportAttributeTableToExcelToolStripMenuItem.Text = "Export Attribute Table to Excel";
            // 
            // pnlAttribute
            // 
            this.pnlAttribute.Controls.Add(this.dgvAttributeTable);
            this.pnlAttribute.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAttribute.Location = new System.Drawing.Point(0, 418);
            this.pnlAttribute.Name = "pnlAttribute";
            this.pnlAttribute.Size = new System.Drawing.Size(629, 126);
            this.pnlAttribute.TabIndex = 1;
            // 
            // dgvAttributeTable
            // 
            this.dgvAttributeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttributeTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttributeTable.Location = new System.Drawing.Point(0, 0);
            this.dgvAttributeTable.Name = "dgvAttributeTable";
            this.dgvAttributeTable.Size = new System.Drawing.Size(629, 126);
            this.dgvAttributeTable.TabIndex = 0;
            // 
            // sdmDockManger
            // 
            this.sdmDockManger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdmDockManger.Location = new System.Drawing.Point(0, 33);
            this.sdmDockManger.Name = "sdmDockManger";
            // 
            // sdmDockManger.Panel1
            // 
            this.sdmDockManger.Panel1.Controls.Add(this.label4);
            this.sdmDockManger.Panel1.Controls.Add(this.label3);
            this.sdmDockManger.Panel1.Controls.Add(this.label2);
            this.sdmDockManger.Panel1.Controls.Add(this.label1);
            this.sdmDockManger.Panel1.Controls.Add(this.Legend1);
            // 
            // sdmDockManger.Panel2
            // 
            this.sdmDockManger.Panel2.Controls.Add(this.map1);
            this.sdmDockManger.Size = new System.Drawing.Size(629, 385);
            this.sdmDockManger.SplitterDistance = 209;
            this.sdmDockManger.TabControl1 = null;
            this.sdmDockManger.TabControl2 = null;
            this.sdmDockManger.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 106);
            this.label4.TabIndex = 4;
            this.label4.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Percent Coverage:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 70);
            this.label2.TabIndex = 2;
            this.label2.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Selection:";
            // 
            // Legend1
            // 
            this.Legend1.BackColor = System.Drawing.Color.White;
            this.Legend1.ControlRectangle = new System.Drawing.Rectangle(0, 0, 209, 385);
            this.Legend1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Legend1.DocumentRectangle = new System.Drawing.Rectangle(0, 0, 113, 103);
            this.Legend1.HorizontalScrollEnabled = true;
            this.Legend1.Indentation = 30;
            this.Legend1.IsInitialized = false;
            this.Legend1.Location = new System.Drawing.Point(0, 0);
            this.Legend1.MinimumSize = new System.Drawing.Size(5, 5);
            this.Legend1.Name = "Legend1";
            this.Legend1.ProgressHandler = null;
            this.Legend1.ResetOnResize = false;
            this.Legend1.SelectionFontColor = System.Drawing.Color.Black;
            this.Legend1.SelectionHighlight = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(238)))), ((int)(((byte)(252)))));
            this.Legend1.Size = new System.Drawing.Size(209, 385);
            this.Legend1.TabIndex = 0;
            this.Legend1.Text = "legend1";
            this.Legend1.VerticalScrollEnabled = true;
            // 
            // map1
            // 
            this.map1.AllowDrop = true;
            this.map1.BackColor = System.Drawing.Color.White;
            this.map1.CollectAfterDraw = false;
            this.map1.CollisionDetection = false;
            this.map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map1.ExtendBuffer = false;
            this.map1.FunctionMode = DotSpatial.Controls.FunctionMode.None;
            this.map1.IsBusy = false;
            this.map1.IsZoomedToMaxExtent = false;
            this.map1.Legend = this.Legend1;
            this.map1.Location = new System.Drawing.Point(0, 0);
            this.map1.Name = "map1";
            this.map1.ProgressHandler = null;
            this.map1.ProjectionModeDefine = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.ProjectionModeReproject = DotSpatial.Controls.ActionMode.Prompt;
            this.map1.RedrawLayersWhileResizing = false;
            this.map1.SelectionEnabled = true;
            this.map1.Size = new System.Drawing.Size(416, 385);
            this.map1.TabIndex = 0;
            this.map1.ZoomOutFartherThanMaxExtent = false;
            this.map1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.map1_MouseDown);
            // 
            // spatialHeaderControl1
            // 
            this.spatialHeaderControl1.ApplicationManager = null;
            this.spatialHeaderControl1.MenuStrip = null;
            this.spatialHeaderControl1.ToolbarsContainer = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 544);
            this.Controls.Add(this.sdmDockManger);
            this.Controls.Add(this.pnlAttribute);
            this.Controls.Add(this.pnlOperations);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tutorial 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlOperations.ResumeLayout(false);
            this.pnlOperations.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAttribute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttributeTable)).EndInit();
            this.sdmDockManger.Panel1.ResumeLayout(false);
            this.sdmDockManger.Panel1.PerformLayout();
            this.sdmDockManger.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sdmDockManger)).EndInit();
            this.sdmDockManger.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spatialHeaderControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperations;
        private System.Windows.Forms.Panel pnlAttribute;
        private DotSpatial.Controls.SpatialDockManager sdmDockManger;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapefileOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPointShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePointShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polylineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPolylineShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePolylineShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPolygonShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePolygonShapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToExtentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem panToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attributeTableOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAttributeTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveColumnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteColumnToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvAttributeTable;
        private DotSpatial.Controls.Legend Legend1;
        private DotSpatial.Controls.Map map1;
        private System.Windows.Forms.ToolStripMenuItem exportAttributeTableToExcelToolStripMenuItem;
        private DotSpatial.Controls.SpatialHeaderControl spatialHeaderControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

