using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ProjektWinForm.Abfrage
{
    internal class AbfrageWinFormLogik
    {
        private OleDbConnection conn;
        private OleDbDataAdapter da;
        private OleDbCommandBuilder cmd;
        private OleDbCommand cmdd;
        private DataSet ds;
        private ProjektWinForm.Application.Application _form1Application;
        private AbfrageWinForm _application;
        private BindingSource bs;

        public void loadConn(string text)
        {
            try
            {
                conn = new OleDbConnection(
                    $"provider=Microsoft.ACE.OLEDB.12.0;Data Source = {Properties.Settings.Default.StartFile}");
                da = new OleDbDataAdapter($"select * from {text}", conn);
                cmd = new OleDbCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds);
            }
            catch (Exception e)
            {
                MessageBox.Show($"There Was an Error:\n{e.Message}", "Error", MessageBoxButtons.OK);
            }

        }

        public void setProperties(AbfrageWinForm abfrageWinForm, ProjektWinForm.Application.Application form1Application)
        {
            _application = abfrageWinForm;
            _form1Application = form1Application;
        }

        public void SQLSHOW(string text)
        {
            loadConn(text);
            da.Fill(ds);
            string SQL =
                $"SELECT DISTINCT Fahrer.*, Team.Teamname, Teilnahme.Streckenzeit,Wettkampf.WettkampfID, Wettkampf.Bezeichnung, Teilnahme.Platzierung\r\nFROM Wettkampf INNER JOIN (Team INNER JOIN (Fahrer INNER JOIN Teilnahme ON Fahrer.Startnummer=Teilnahme.Startnummer) ON Team.TeamID=Fahrer.TeamID) ON Wettkampf.WettkampfID = Teilnahme.WettkampfID\r\nWHERE Wettkampf.WettkampfID = {_form1Application.WettkampfID}\r\n AND Teilnahme.Streckenzeit IS NOT NULL ORDER BY Teilnahme.Streckenzeit;";
            try
            {
                conn.Open();
                cmdd = new OleDbCommand($"{SQL}", conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.SelectCommand = cmdd;
                adapter.Fill(table);
                var i = table.Rows.Count;
                if (i != 0)
                {
                    _application.dataGridView1.DataSource = table;
                    _application.dataGridView1.Columns["Streckenzeit"].DefaultCellStyle.Format = "HH:mm:ss";
                    platzierung(table);
                }
                else
                {
                    MessageBox.Show(
                        "Es wurden keine Satensätze mit gefüllten Streckenzeiten gefunden.\nBitte pflegen Sie die Streckenzeiten ein.", "Error", MessageBoxButtons.OK);
                    _application.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                _application.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        private void platzierung(DataTable dataTable)
        {
            var dt = dataTable.Rows;
            var i = 0;
            foreach (DataRow dataRow in dt)
            {
                i++;
                dataRow["Platzierung"] = i;
            }
        }
    }
}