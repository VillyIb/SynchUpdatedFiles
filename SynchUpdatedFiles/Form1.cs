using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SynchUpdatedFiles
{
    public partial class Form1 : Form
    {
        private List<Row> Table { get; set; }

        private Settings Settings{ get; set; }      

        public Form1()
        {
            InitializeComponent();
            Settings = new Settings();

            XuTargetFolder.Text = Settings.TargetFolder;
            XuSourceFolder.Text  = Settings.SourceFolder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Table = new List<Row>
            {
                new Row {Filename = "Alfa", Direction = Direction.Identical, LeftVersion = "A", RightVersion = "A"},
                new Row {Filename = "Brave", Direction = Direction.Left, LeftVersion = "1", RightVersion = "2"},
                new Row {Filename = "Charlie", Direction = Direction.Right, LeftVersion = "4", RightVersion = "3"}
            };


            XuTable.DataSource = Table;

        }

        private void XuTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var t1 = sender as DataGridView;
            var t2 = e as DataGridViewCellEventArgs;

        }

        private void XuTable_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var t1 = sender as DataGridView;
            var t2 = e as DataGridViewCellEventArgs;
        }

        private void XuTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void XuTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void ChangeDirection(int rowIndex)
        {
            if (rowIndex < 0) { return; }
            var row = Table[rowIndex];

            switch (row.Direction)
            {
                case Direction.Identical:
                    row.Direction = Direction.Left;
                    break;

                case Direction.Left:
                    row.Direction = Direction.Right;
                    break;

                case Direction.Right:
                    row.Direction = Direction.Identical;
                    break;
            }


            //Update();
        }


        private void XuTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //XuTable.CurrentCell = XuTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
            XuTable.BeginEdit(true);

            ChangeDirection(e.RowIndex);

            XuTable.EndEdit();
        }

        private void XuTest1_Click(object sender, EventArgs e)
        {
            var target = new DirectoryInfo(XuTargetFolder.Text);
            var source = new DirectoryInfo(XuSourceFolder.Text);
            //var right = new DirectoryInfo(@"C:\DevFrontend\M_Frontend-Master\bin");


            var api = new RepositoryApi {TargetDirectory = target, SourceDirectory = source};
            var filecount = api.Analyze();
            var x = api.FileList;

            var z1 = x;
            var z2 = filecount;

            //var x3 = x.Select(t => t.FileVersionTarget.CompareTo(t.FileVersionSource) != 0).ToList();

            var unEqualFileList = x.Where(metadata => metadata.FileVersionTarget.CompareTo(metadata.FileVersionSource) != 0).ToList();

            Table = new List<Row>();

            foreach (var fileMetadata in unEqualFileList)
            {
                var t1 = fileMetadata.FileVersionTarget.CompareTo(fileMetadata.FileVersionSource);

                var direction = Direction.Identical;

                if (t1 > 0)
                {
                    direction = Direction.Right;
                }
                else if (t1 < 0)
                {
                    direction = Direction.Left;
                }

                Table.Add(
                    new Row
                    {
                        Direction = direction
                        ,Filename = fileMetadata.Filename
                        ,LeftVersion = fileMetadata.FileVersionTarget.ToString()
                        , RightVersion = fileMetadata.FileVersionSource.ToString()
                    }
                );

                XuTable.BeginEdit(true);

                XuTable.DataSource = Table;

                XuTable.EndEdit();
                Update();
            }
            

            var z4 = unEqualFileList;
        }

        private void XuTargetFolderBrowse_Click(object sender, EventArgs e)
        {
            //XuFolderBrowser.RootFolder = XuTargetFolder.Text;
            XuFolderBrowser.ShowNewFolderButton = false;
            //XuFolderBrowser.RootFolder = Environment.SpecialFolder.Favorites;
            XuFolderBrowser.SelectedPath = XuTargetFolder.Text;
            XuFolderBrowser.ShowDialog();
            XuTargetFolder.Text = XuFolderBrowser.SelectedPath;
            Settings.TargetFolder = XuTargetFolder.Text;
            Settings.Save();
        }

        private void XuSourceFolderBrowse_Click(object sender, EventArgs e)
        {
            XuFolderBrowser.SelectedPath = XuSourceFolder.Text;
            XuFolderBrowser.ShowDialog();
            XuSourceFolder.Text = XuFolderBrowser.SelectedPath;
            Settings.SourceFolder = XuSourceFolder.Text;
            Settings.Save();
        }


    }
}
