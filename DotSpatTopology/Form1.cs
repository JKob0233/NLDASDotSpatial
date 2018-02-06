using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Controls;
using DotSpatial.Data;
using DotSpatial.Symbology;
using DotSpatial.Topology;
using NetTopologySuite.IO;
using System.Diagnostics;

namespace DotSpatTopology
{
    public partial class Form1 : Form
    {
        double squareArea = 0;//0.015625;
        double gridArea = 0;
        double polygonArea = 0;
        ArrayList polys = new ArrayList();
        ArrayList squares = new ArrayList();
        ArrayList overlap = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            map1.FunctionMode = FunctionMode.Pan;
            string gridfile = "NLDAS_Grid_Reference.shp";
            string polyfile = "..\\..\\..\\tests\\Lake_St._Clair_Shoreline.shp";//"..\\..\\..\\tests\\Catchment.shp";
            map1.AddLayer(polyfile);
            map1.AddLayer(gridfile);
            MapPolygonLayer polylayer = (MapPolygonLayer)map1.Layers[0];
            polylayer.Symbolizer = new PolygonSymbolizer(Color.LightBlue, Color.Black);
            MapPolygonLayer gridlayer = (MapPolygonLayer)map1.Layers[1];
            gridlayer.Symbolizer = new PolygonSymbolizer(Color.FromArgb(0, Color.White), Color.Black);

            //Read geometries from both shapefiles and store in array lists
            //As well as calculate shapefile areas ahead of time
            ShapefileDataReader reader = new ShapefileDataReader(polyfile, NetTopologySuite.Geometries.GeometryFactory.Default);
            while (reader.Read())
            {
                polys.Add(reader.Geometry);
                polygonArea += reader.Geometry.Area;
            }

            ShapefileDataReader reader2 = new ShapefileDataReader(gridfile, NetTopologySuite.Geometries.GeometryFactory.Default);
            while (reader2.Read())
            {
                squares.Add(reader2.Geometry);
                gridArea += reader2.Geometry.Area;
            }

            squares.TrimToSize();
            polys.TrimToSize();

            ///Creating intersections ahead of time to make selections faster at runtime
            foreach (GeoAPI.Geometries.IGeometry s in squares)
            {
                foreach (GeoAPI.Geometries.IGeometry p in polys)
                {
                    if (p.Intersects(s) && !overlap.Contains(s))
                    {
                        overlap.Add(s);
                    }
                }
            }
            overlap.TrimToSize();
            ///
            
            label4.Text = "Area of NLDAS Grid: " + gridArea.ToString();
            label4.Text += "\r\nArea of polygon: " + polygonArea.ToString();
            double percent = (polygonArea / gridArea) * 100;
            label4.Text += "\r\nPolygon covers " + percent.ToString() + "% of NLDAS Grid.";
        }

        //which type of shapefile is created
        string shapeType;
        #region Point ShapeFile class level variable

        //the new point feature set
        FeatureSet pointF = new FeatureSet(FeatureType.Point);

        //the id of point
        int pointID = 0;

        //to differentiate the right and left mouse click
        bool pointmouseClick = false;

        #endregion

        private void createPointShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Change the cursor style
            map1.Cursor = Cursors.Cross;
            //set the shape type to the classlevel string variable
            //we are going to use this variable in select case statement
            shapeType = "Point";
            //set projection
            pointF.Projection = map1.Projection;
            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("PointID");
            pointF.DataTable.Columns.Add(column);
            //add the featureSet as map layer
            MapPointLayer pointLayer = (MapPointLayer)map1.Layers.Add(pointF);
            //Create a new symbolizer
            PointSymbolizer symbol = new PointSymbolizer(Color.Red, DotSpatial.Symbology.PointShape.Ellipse, 3);
            //Set the symbolizer to the point layer
            pointLayer.Symbolizer = symbol;
            //Set the legentText as point
            pointLayer.LegendText = "point";
            //Set left mouse click as true
            pointmouseClick = true;

        }

        private void map1_MouseDown(object sender, MouseEventArgs e)
        {
            Stopwatch timer = new Stopwatch();
            timer.Start();

            Coordinate mousept = map1.PixelToProj(e.Location);
            NetTopologySuite.Geometries.Point xp = new NetTopologySuite.Geometries.Point(mousept.X, mousept.Y);
            Console.WriteLine(xp.ToString());

            MapPolygonLayer polylayer = (MapPolygonLayer)map1.Layers[0];
            MapPolygonLayer gridlayer = (MapPolygonLayer)map1.Layers[1];

            //Iterate through NLDAS grid and determine if it intersects a polygon at selected region
            gridlayer.UnSelectAll();
            double interArea = 0.0;
            
            foreach (GeoAPI.Geometries.IGeometry s in overlap)
            {
                if (s.Intersects(xp))
                {
                    squareArea = s.Area;
                    foreach (GeoAPI.Geometries.IGeometry p in polys)
                    {
                        if (p.Intersects(s))
                        {
                            GeoAPI.Geometries.IGeometry intersection = p.Intersection(s);
                            interArea += intersection.Area;
                            break;
                        }
                    }
                    break;
                }
            }

            /**
            /// slightly slower implementation, but provides visual selection.
            int iShape = 0; 
            foreach (GeoAPI.Geometries.IGeometry s in squares)
            {
                if (s.Intersects(xp))
                {
                    squareArea = s.Area;
                    gridlayer.Select(iShape);
                    foreach (GeoAPI.Geometries.IGeometry p in polys)
                    {
                        if (p.Intersects(s))
                        {
                            GeoAPI.Geometries.IGeometry intersection = p.Intersection(s);
                            interArea += intersection.Area;
                            break;
                        }
                    }
                    break;
                }
                iShape++;
            }**/

            double percent = (interArea / squareArea) * 100;
            label2.Text = "Area of square: " + squareArea.ToString() + "\r\nArea of polygon in selected square: " + interArea.ToString() + "\r\nPortion of polygon covers " + percent.ToString() + "% of this square.";

            timer.Stop();
            TimeSpan ts = timer.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            switch (shapeType)
            {
                case "Point":
                    if (e.Button == MouseButtons.Left)
                    {
                        if ((pointmouseClick))
                        {
                            //This method is used to convert the screen cordinate to map coordinate
                            //e.location is the mouse click point on the map control
                            Coordinate coord = map1.PixelToProj(e.Location);

                            //Create a new point
                            //Input parameter is clicked point coordinate
                            DotSpatial.Topology.Point point = new DotSpatial.Topology.Point(coord);

                            //Add the point into the Point Feature
                            //assigning the point feature to IFeature because via it only we can set the attributes.
                            IFeature currentFeature = pointF.AddFeature(point);

                            //increase the point id
                            pointID = pointID + 1;

                            //set the ID attribute
                            //currentFeature.DataRow["PointID"] = pointID; 

                            //refresh the map
                            map1.ResetBuffer();
                        }
                    }

                    else
                    {
                        //mouse right click
                        map1.Cursor = Cursors.Default;
                        pointmouseClick = false;
                    }
                    break;

                case "line":
                    if (e.Button == MouseButtons.Left)
                    {
                        //left click - fill array of coordinates
                        //coordinate of clicked point
                        Coordinate coord = map1.PixelToProj(e.Location);
                        if (linemouseClick)
                        {
                            //first time left click - create empty line feature
                            if (firstClick)
                            {
                                //Create a new List called lineArray.                          
                                //This list will store the Coordinates
                                //We are going to store the mouse click coordinates into this array.
                                List<Coordinate> lineArray = new List<Coordinate>();

                                //Create an instance for LineString class.
                                //We need to pass collection of list coordinates
                                LineString lineGeometry = new LineString(lineArray);

                                //Add the linegeometry to line feature
                                IFeature lineFeature = lineF.AddFeature(lineGeometry);

                                //add first coordinate to the line feature
                                lineFeature.Coordinates.Add(coord);
                                //set the line feature attribute
                                lineID = lineID + 1;
                                lineFeature.DataRow["LineID"] = lineID;
                                firstClick = false;
                            }
                            else
                            {
                                //second or more clicks - add points to the existing feature
                                IFeature existingFeature = lineF.Features[lineF.Features.Count - 1];
                                existingFeature.Coordinates.Add(coord);

                                //refresh the map if line has 2 or more points
                                if (existingFeature.Coordinates.Count >= 2)
                                {
                                    lineF.InitializeVertices();
                                    map1.ResetBuffer();
                                }
                            }
                        }
                    }
                    else
                    {
                        //right click - reset first mouse click
                        firstClick = true;
                        map1.ResetBuffer();
                    }
                    break;
                case "polygon":

                    if (e.Button == MouseButtons.Left)
                    {
                        //left click - fill array of coordinates
                        Coordinate coord = map1.PixelToProj(e.Location);

                        if (polygonmouseClick)
                        {
                            //first time left click - create empty line feature
                            if (firstClick)
                            {
                                //Create a new List called polygonArray.

                                //this list will store the Coordinates
                                //We are going to store the mouse click coordinates into this array.

                                List<Coordinate> polygonArray = new List<Coordinate>();

                                //Create an instance for LinearRing class.
                                //We pass the polygon List to the constructor of this class
                                LinearRing polygonGeometry = new LinearRing(polygonArray);

                                //Add the polygonGeometry instance to PolygonFeature
                                IFeature polygonFeature = polygonF.AddFeature(polygonGeometry);

                                //add first coordinate to the polygon feature
                                polygonFeature.Coordinates.Add(coord);

                                //set the polygon feature attribute
                                polygonID = polygonID + 1;
                                polygonFeature.DataRow["PolygonID"] = polygonID;
                                firstClick = false;
                            }
                            else
                            {
                                //second or more clicks - add points to the existing feature
                                IFeature existingFeature = (IFeature)polygonF.Features[polygonF.Features.Count - 1];

                                existingFeature.Coordinates.Add(coord);

                                //refresh the map if line has 2 or more points
                                if (existingFeature.Coordinates.Count >= 3)
                                {
                                    //refresh the map
                                    polygonF.InitializeVertices();
                                    map1.ResetBuffer();
                                }
                            }
                        }
                    }
                    else
                    {
                        //right click - reset first mouse click
                        firstClick = true;
                    }
                    break;


            }


        }

        private void savePointShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pointF.SaveAs("point.shp", true);
            MessageBox.Show("The point shapefile has been saved.");
            map1.Cursor = Cursors.Arrow;

        }



        #region Polyline  ShapeFile class level variables

        MapLineLayer lineLayer = default(MapLineLayer);

        //the line feature set
        FeatureSet lineF = new FeatureSet(FeatureType.Line);

        int lineID = 0;

        //boolean variable for first time mouse click
        bool firstClick = false;

        //It controls the drawing the polyline after the polyline saved operation.
        bool linemouseClick = false;

        #endregion

        private void createPolylineShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Change the mouse cursor
            map1.Cursor = Cursors.Cross;

            //set shape type
            shapeType = "line";

            //set projection
            lineF.Projection = map1.Projection;

            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("LineID");

            if (!lineF.DataTable.Columns.Contains("LineID"))
            {
                lineF.DataTable.Columns.Add(column);
            }

            //add the featureSet as map layer
            lineLayer = (MapLineLayer)map1.Layers.Add(lineF);

            //Set the symbolizer to the line feature. 
            LineSymbolizer symbol = new LineSymbolizer(Color.Blue, 2);
            lineLayer.Symbolizer = symbol;
            lineLayer.LegendText = "line";

            firstClick = true;

            linemouseClick = true;

        }

        private void savePolylineShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lineF.SaveAs("c:\\MW\\line.shp", true);
            MessageBox.Show("The line shapefile has been saved in C:\\MW\\");
            map1.Cursor = Cursors.Arrow;
            linemouseClick = false;

        }

        #region Polygon ShapeFile class level variables

        FeatureSet polygonF = new FeatureSet(FeatureType.Polygon);
        int polygonID = 0;

        bool polygonmouseClick = false;

        #endregion

        private void createPolygonShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //initialize polyline feature set
            map1.Cursor = Cursors.Cross;

            //set shape type
            shapeType = "polygon";

            //set projection
            polygonF.Projection = map1.Projection;

            //initialize the featureSet attribute table
            DataColumn column = new DataColumn("PolygonID");

            if (!polygonF.DataTable.Columns.Contains("PolygonID"))
            {
                polygonF.DataTable.Columns.Add(column);
            }

            //add the featureSet as map layer
            MapPolygonLayer polygonLayer = (MapPolygonLayer)map1.Layers.Add(polygonF);

            PolygonSymbolizer symbol = new PolygonSymbolizer(Color.Green);

            polygonLayer.Symbolizer = symbol;
            polygonLayer.LegendText = "polygon";

            firstClick = true;

            polygonmouseClick = true;


        }

        private void savePolygonShapefileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            polygonF.SaveAs("..\\..\\..\\tests\\custom.shp", true);
            MessageBox.Show("The polygon shapefile has been saved.");
            map1.Cursor = Cursors.Arrow;
            polygonmouseClick = false;

        }

        private void viewAttributeTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare a datatable
            System.Data.DataTable dt = null;

            if (map1.Layers.Count > 0)
            {
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                stateLayer = (MapPolygonLayer)map1.Layers[0];

                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //Get the shapefile's attribute table to our datatable dt
                    dt = stateLayer.DataSet.DataTable;
                    //Set the datagridview datasource from datatable dt
                    dgvAttributeTable.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }


        }

        private void addAColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare a datatable
            System.Data.DataTable dt = null;

            //check the layers
            if (map1.Layers.Count > 0)
            {
                //Declare a mappolygon layer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                //Assign the mappolygon layer from the map
                stateLayer = map1.Layers[0] as MapPolygonLayer;

                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //Get the shapefile's attribute table to our datatable dt
                    dt = stateLayer.DataSet.DataTable;

                    //Add new column
                    DataColumn column = new DataColumn("PercentMales");
                    dt.Columns.Add(column);

                    //calculate values
                    foreach (DataRow row in dt.Rows)
                    {

                        double males = Convert.ToDouble(row["males"]);
                        double females = Convert.ToDouble(row["females"]);
                        double malesPercentage = (males / (males + females)) * 100;
                        row["PercentMales"] = malesPercentage;
                    }
                    //Set the datagridview datasource from datatable dt
                    dgvAttributeTable.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }


        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AddLayer() method is used to add a shape file in the MapControl.
            map1.AddLayer();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear() method is used to clear the layers from the map control.
            map1.Layers.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Confirm with users that  they are ready to close application or not with the help of message box.
            if (MessageBox.Show("Do you want to close this application?", "Admin", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //Close() method is used to close the application.
                this.Close();
            }
        }

        private void zoomINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomOut();
        }

        private void zoomToExtentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomToMaxExtent();
        }

        private void panToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pan function is used to pan the map
            map1.FunctionMode = FunctionMode.Pan;
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Info function is used to get the information of the selected shape
            map1.FunctionMode = FunctionMode.Info;
        }

        private void saveColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (map1.Layers.Count > 0)
            {
                MapPolygonLayer stateLayer = default(MapPolygonLayer);
                stateLayer = map1.Layers[0] as MapPolygonLayer;
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    stateLayer.DataSet.Save();
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }

        }

        private void deleteColumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Declare a datatable
            System.Data.DataTable dt = null;

            if (map1.Layers.Count > 0)
            {
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                stateLayer = map1.Layers[0] as MapPolygonLayer;

                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //Get the shapefile's attribute table to our datatable dt
                    dt = stateLayer.DataSet.DataTable;

                    //Remove a column
                    dt.Columns.Remove("PercentMales");

                    //Set the datagridview datasource from datatable dt
                    dgvAttributeTable.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }


        }


        private void printMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DotSpatial.Controls.LayoutForm frm = new DotSpatial.Controls.LayoutForm();
            frm.MapControl = map1;
            frm.Show();

        }
                
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}