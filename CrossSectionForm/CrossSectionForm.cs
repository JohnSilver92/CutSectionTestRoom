using System;
using Geometry;
using Scene;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using ModelController;
//using CrossSectionFront;
using GMSH_Importer;
using CrossSection_lib;
using System.IO;

namespace CrossSectionForm
{
    public partial class CrossSectionForm : Form
    {
        ModelData modelData = new ModelData();
        public CrossSectionForm()
        {
            InitializeComponent();
            sceneControl1.Initialization();
            sceneControl1.DisplayObjects();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        public Node CreateNode(List<int> sings, Point3D[] points, Plane plane)
        {

            for (int i = 0; i < points.Length; i++)
            {
                for (int k = i + 1; k < points.Length; i++)
                {
                    var d1 = Math.Abs(plane.PointPosition(points[i]));
                    var d2 = Math.Abs(plane.PointPosition(points[k]));

                    if (!sings[i].Equals(sings[k]))
                    {
                        Point3D point1 = points[i];
                        Point3D point2 = points[k];

                        var res = point2.Sub(point1);

                        var xFO = d1 / (d1 + d2) * res._x; //xFO
                        var yFO = d1 / (d1 + d2) * res._y; //yFO
                        var zFO = d1 / (d1 + d2) * res._z; //zFO

                        Point3D newPoint = new Point3D(xFO + point1._x, yFO + point1._y, zFO + point1._z);
                        Node newNode = new Node(k, newPoint);
                        newNode.MasterColor = Color.Red;
                        return newNode;
                    }
                }
            }
            return null;
        }
        private void btnAddMesh_Click(object sender, EventArgs e)
        {
            int counter = 0;
            ObjectsData objData = new ObjectsData();
            List<ModelObject> modelObj = new List<ModelObject>();
            List<Point3D> tempPoints = new List<Point3D>();
            List<Node> tempNodes = new List<Node>();
            ModelData data = new ModelData();
            
            var model = new Import_Mesh();
            model.LoadEvent += this.Model_LoadEvent;
            
            data = model.Load(Directory.GetCurrentDirectory() + "/Tube.inp");

            objData = data.ObjectData;
            var getElems = objData.FindMany("Элементы3D");
            var newElems = getElems.ToList();
           
            var plane = new Plane(new Point3D(0, 0, 0), new Point3D(1, 0, 0), new Point3D(0, 1, 1));
            var getCrossPoints = new GetCrossPoints();
            List<Element3D> elems = new List<Element3D>();
            elems.AddRange(getElems.Cast<Element3D>());

            //Dictionary<int, List<Point3D>> dic = getCrossPoints.CreateCrossNodes(elems, plane);

            //var value = dic.Values.Cast<List<Point3D>>().ToList();
            //var x = value.First();

            //foreach (var element in dic.Values)
            //{
            //    if (element.Count > 0)
            //    {
            //        for (int i = 0; i < element.Count; i++)
            //        {
            //            tempNodes.Add(new Node(counter, element[i]));
            //            tempNodes.Last().MasterColor = Color.Red;
            //            counter++;
            //        }
            //    }
            //}

            modelObj.AddRange(tempPoints.Cast<ModelObject>());
            objData.AddRange(tempPoints.Cast<ModelObject>());

            objData.AddRange(tempNodes);
            
            
            var presenter = new ModelScenePresentator(objData.ToArray());
            sceneControl1.SetPresentor(presenter);

            sceneControl1.CreateVBObjects("Узлы");
            sceneControl1.CreateVBObjects("Элементы3D");
            sceneControl1.ChangeViewModeVBObjects("Элементы3D", Scene.VBO.ObjView.Lines);
            sceneControl1.SelectionType = "Узлы";

            sceneControl1.PlugVBObjects();
            sceneControl1.DisplayObjects();
        }

        private void Model_LoadEvent(object arg1, global::ModelInterface.LoaderEventArgs arg2)
        {
            
        }

        private void sceneControl1_CreateVBObjectsEvent(object arg1, Scene.Events.VBOPresenterEventArgs arg2)
        {

        }

        private void sceneControl1_InfoObjectsEvent(object arg1, InfoObjectsEventArgs arg2)
        {
            foreach (var item in arg2.GetObjectsNumbers())
            {
                var obj = modelData.ObjectData.Find(item);

                if (obj is Node node)
                {

                }
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    var obj = new Form() { TopMost = true };
        //    var cntr = new CrossSectionControl();
        //    obj.Width = 340;
        //    obj.Height = 240;
        //    cntr.PrepareEvent += Cntr_PrepareEvent;
        //    cntr.CreateEvent += Cntr_CreateEvent;
        //    cntr.CreatePlane += Cntr_CreatePlane;
        //    obj.Controls.Add(cntr);
        //    obj.Show();
        //}

        //private void Cntr_CreateEvent(object arg1, CreateEventArgs arg2)
        //{
        //    try
        //    {
        //        var selNumbers = sceneControl1.GetSelectedObjects().ToArray();

        //        if (selNumbers.Length < 3)
        //            throw new Exception("Выбери три узла!");

        //        var node0 = (Node)modelData.ObjectData.Find(selNumbers[0]);

        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        //private void Cntr_PrepareEvent(object arg1, PrepareEventArgs arg2)
        //{
        //    sceneControl1.SelectionType = "Узлы";
        //}

        //public void Cntr_CreatePlane(object arg1, CreatePlaneArgs arg2)
        //{
        //    Plane plane = arg2.plane;
        //    int counter = 0;
        //    ObjectsData objData = new ObjectsData();
        //    List<ModelObject> modelObj = new List<ModelObject>();
        //    List<Point3D> tempPoints = new List<Point3D>();
        //    List<Node> tempNodes = new List<Node>();
        //    ModelData modelData = new ModelData();

        //    var importer = new Import_Mesh();
        //    importer.LoadEvent += Model_LoadEvent;
        //    modelData = importer.Load(@"C:\Tube.inp");


        //    var elems3D = modelData.ObjectData.FindMany<Element3D>().ToList();

        //    var getCrossPoints = new GetCrossPoints();

        //    Dictionary<int, List<Point3D>> dic = getCrossPoints.CreateCrossNodes(elems3D, plane);

        //    foreach (var element in dic.Values)
        //    {
        //        if (element.Count > 0)
        //        {
        //            for (int i = 0; i < element.Count; i++)
        //            {
        //                tempNodes.Add(new Node(counter, element[i]));
        //                tempNodes.Last().MasterColor = Color.Red;
        //                counter++;
        //            }
        //        }
        //    }
        //    modelObj.AddRange(tempNodes.Cast<ModelObject>());
        //    objData.AddRange(tempNodes.Cast<ModelObject>());
        //    objData.AddRange(tempNodes);

        //    var presenter = new ModelScenePresentator(objData.ToArray());
        //    sceneControl1.SetPresentor(presenter);

        //    sceneControl1.CreateVBObjects("Узлы");
        //    //sceneControl1.CreateVBObjects("Элементы3D");
        //    //sceneControl1.ChangeViewModeVBObjects("Элементы3D", Scene.VBO.ObjView.Lines);
        //    //sceneControl1.SelectionType = "Элементы3D";

        //    sceneControl1.PlugVBObjects();
        //    sceneControl1.DisplayObjects();

        //}
    }
}