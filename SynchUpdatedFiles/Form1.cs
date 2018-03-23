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

        private Settings Settings { get; set; }

        public List<FileMetadata> UnequalFileList { get; set; }

        public Form1()
        {
            InitializeComponent();
            Settings = new Settings();

            XuTargetFolder.Text = Settings.TargetFolder;
            XuSourceFolder.Text = Settings.SourceFolder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //XuTest1_Click(sender, e);
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
            XuTable.BeginEdit(true);

            ChangeDirection(e.RowIndex);

            XuTable.EndEdit();
        }

        private void XuTable_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void ChangeDirection(int rowIndex)
        {
            if (rowIndex < 0) { return; }
            var row = Table[rowIndex];

            var direction = MapDirection(row.Direction);

            switch (direction)
            {
                case Direction.Identical:
                    row.Direction = MapDirection(Direction.Left);
                    break;

                case Direction.Left:
                    row.Direction = MapDirection(Direction.Right);
                    break;

                case Direction.Right:
                    row.Direction = MapDirection(Direction.Identical);
                    break;
            }

            Update();
        }


        private void XuTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //XuTable.CurrentCell = XuTable.Rows[e.RowIndex].Cells[e.ColumnIndex];
            XuTable.BeginEdit(true);

            ChangeDirection(e.RowIndex);

            XuTable.EndEdit();
        }


        private static String MapDirection(Direction value)
        {
            switch (value)
            {
                case Direction.Identical:
                    return "==";

                case Direction.Left:
                    return "<<<---";

                case Direction.Right:
                    return "--->>>";

                default:
                    return "--->>><<<---";
            }
        }

        private static Direction MapDirection(String value)
        {
            switch (value)
            {
                case "==":
                    return Direction.Identical;

                case "<<<---":
                    return Direction.Left;

                case "--->>>":
                    return Direction.Right;

                default:
                    return Direction.Identical;
            }
        }

        private void XuTest1_Click(object sender, EventArgs e)
        {
            XuTest1.Enabled = false;

            var target = new DirectoryInfo(XuTargetFolder.Text);
            var source = new DirectoryInfo(XuSourceFolder.Text);
            //var right = new DirectoryInfo(@"C:\DevFrontend\M_Frontend-Master\bin");


            var api = new RepositoryApi { TargetDirectory = target, SourceDirectory = source };
            var filecount = api.Analyze();
            var x = api.TargetFileList;

            var z1 = x;
            var z2 = filecount;

            //var x3 = x.Select(t => t.FileVersionTarget.CompareTo(t.FileVersionSource) != 0).ToList();

            UnequalFileList = new List<FileMetadata>();

            foreach (var current in x)
            {
                var compare = current.FileVersionTarget.CompareTo(current.FileVersionSource);

                if (compare < 0 && XuShowNewer.Checked)
                {
                    UnequalFileList.Add(current);
                }
                else if (compare > 0 && XuShowOlder.Checked)
                {
                    UnequalFileList.Add(current);
                }
                else if (compare == 0 && XuShowEqual.Checked)
                {
                    UnequalFileList.Add(current);
                }
            }

            //UnequalFileList = x.Where(metadata => metadata.FileVersionTarget.CompareTo(metadata.FileVersionSource) != 0).ToList();

            Table = new List<Row>();

            foreach (var fileMetadata in UnequalFileList)
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
                        Direction = MapDirection(direction),
                        Filename = fileMetadata.Filename,
                        TargetVersion = fileMetadata.FileVersionTarget.ToString(),
                        SourceVersion = fileMetadata.FileVersionSource.ToString()
                    }
                );

            }

            //XuTable.BeginEdit(true);
            XuTable.DataSource = Table;
            //XuTable.EndEdit();
            Update();

            XuTest1.Enabled = true;
            Clipboard.SetText(api.GetLogger);
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

        private void XuSynch_Click(object sender, EventArgs e)
        {

            for(var index = 0; index< UnequalFileList.Count ;index++)
            
            //foreach (var current in UnequalFileList)
            {
                var current = UnequalFileList[index];

                var row = XuTable.Rows[index];
                var direction = (row.DataBoundItem as Row).Direction;

                //var compare = current.FileVersionTarget.CompareTo(current.FileVersionSource);
                //if (compare < 0)

                if(Direction.Left == MapDirection(direction))
                {
                    var source = new FileInfo(Path.Combine(current.DirectorySource.FullName, current.Filename));
                    var target = new FileInfo(Path.Combine(XuTargetFolder.Text, current.Filename));

                    target.Delete();
                    source.CopyTo(target.FullName);

                    var source2 = new FileInfo(Path.Combine(current.DirectorySource.FullName, Path.GetFileNameWithoutExtension(current.Filename) + ".pdb"));
                    var target2 = new FileInfo(Path.Combine(XuTargetFolder.Text, Path.GetFileNameWithoutExtension(current.Filename) + ".pdb"));

                    if (target2.Exists)
                    {
                        target2.Delete();
                    }

                    if (source2.Exists)
                    {
                        source2.CopyTo(target2.FullName);
                    }

                }

            }

            XuTest1_Click(sender, e);
        }

        private void XuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
