namespace CrossSectionForm
{
    partial class CrossSectionForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sceneControl1 = new Scene.SceneControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInvokeCntrl = new System.Windows.Forms.Button();
            this.btnAddMesh = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.14639F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.85361F));
            this.tableLayoutPanel1.Controls.Add(this.sceneControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 611);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // sceneControl1
            // 
            this.sceneControl1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sceneControl1.BackGroundColor = System.Drawing.Color.Ivory;
            this.sceneControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sceneControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sceneControl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sceneControl1.IsLighting = true;
            this.sceneControl1.Location = new System.Drawing.Point(321, 3);
            this.sceneControl1.Name = "sceneControl1";
            this.sceneControl1.RotationAngle = 2.5F;
            this.sceneControl1.RotationAxis = Scene.ViewAxis.XYZ;
            this.sceneControl1.SelectionColor = System.Drawing.Color.Green;
            this.sceneControl1.SelectionType = "Узлы";
            this.sceneControl1.Size = new System.Drawing.Size(667, 605);
            this.sceneControl1.TabIndex = 1;
            this.sceneControl1.CreateVBObjectsEvent += new System.Action<object, Scene.Events.VBOPresenterEventArgs>(this.sceneControl1_CreateVBObjectsEvent);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnInvokeCntrl, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnAddMesh, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 483F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(312, 605);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnInvokeCntrl
            // 
            this.btnInvokeCntrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvokeCntrl.Location = new System.Drawing.Point(3, 83);
            this.btnInvokeCntrl.Name = "btnInvokeCntrl";
            this.btnInvokeCntrl.Size = new System.Drawing.Size(306, 34);
            this.btnInvokeCntrl.TabIndex = 2;
            this.btnInvokeCntrl.Text = "InvokeControl";
            this.btnInvokeCntrl.UseVisualStyleBackColor = true;
            //this.btnInvokeCntrl.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddMesh
            // 
            this.btnAddMesh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMesh.Location = new System.Drawing.Point(3, 43);
            this.btnAddMesh.Name = "btnAddMesh";
            this.btnAddMesh.Size = new System.Drawing.Size(306, 34);
            this.btnAddMesh.TabIndex = 3;
            this.btnAddMesh.Text = "AddMesh";
            this.btnAddMesh.UseVisualStyleBackColor = true;
            this.btnAddMesh.Click += new System.EventHandler(this.btnAddMesh_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrossSectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 611);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CrossSectionForm";
            this.Text = "m";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Scene.SceneControl sceneControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnInvokeCntrl;
        private System.Windows.Forms.Button btnAddMesh;
        private System.Windows.Forms.Button button1;
    }
}