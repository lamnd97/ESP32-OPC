using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPCAutomation;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public OPCAutomation.OPCServer AnOPCServer;
        public OPCAutomation.OPCServer ConnectedOPCServer;
        public OPCAutomation.OPCGroups ConnectedServerGroup;
        public OPCAutomation.OPCGroup ConnectedGroup;
        public string Groupname;

        int ItemCount;
        Array OPCItemIDs = Array.CreateInstance(typeof(string), 10);
        Array ItemServerHandles = Array.CreateInstance(typeof(Int32), 10);
        Array ItemServerErrors = Array.CreateInstance(typeof(Int32), 10);
        Array ClientHandles = Array.CreateInstance(typeof(Int32), 10);
        Array RequestedDataTypes = Array.CreateInstance(typeof(Int16), 10);
        Array AccessPaths = Array.CreateInstance(typeof(string), 10);
        Array WriteItems = Array.CreateInstance(typeof(object), 9);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb1.ReadOnly = true;
            tb2.ReadOnly = true;
            
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            try
            {
                string IOServer = "Kepware.KEPServerEX.V6";
                string IOGroup = "OPCGroup1";

                ConnectedOPCServer = new OPCAutomation.OPCServer();
                ConnectedOPCServer.Connect(IOServer, "");
                ConnectedGroup = ConnectedOPCServer.OPCGroups.Add(IOGroup);
                ConnectedGroup.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(ObjOPCGroup_DataChange);
                ConnectedGroup.UpdateRate = 1000;
                ConnectedGroup.IsSubscribed = ConnectedGroup.IsActive;


                ItemCount = 8;
                OPCItemIDs.SetValue("Channel1.ESP32.MB0", 1);
                ClientHandles.SetValue(1, 1);
                OPCItemIDs.SetValue("Channel1.ESP32.MB1", 2);
                ClientHandles.SetValue(2, 2);
                OPCItemIDs.SetValue("Channel1.ESP32.MB14", 3);
                ClientHandles.SetValue(3, 3);
                OPCItemIDs.SetValue("PLC.S7-300.Seperator", 4);
                ClientHandles.SetValue(4, 4);
                OPCItemIDs.SetValue("PLC.S7-300.Pumping", 5);
                ClientHandles.SetValue(5, 5);
                OPCItemIDs.SetValue("PLC.S7-300.PumpIntensity", 6);
                ClientHandles.SetValue(6, 6);
                OPCItemIDs.SetValue("PLC.S7-300.WaterLevel", 7);
                ClientHandles.SetValue(7, 7);
                OPCItemIDs.SetValue("Channel1.ESP32.MB13", 8);
                ClientHandles.SetValue(8, 8);

                ConnectedGroup.OPCItems.DefaultIsActive = true;
                ConnectedGroup.OPCItems.AddItems(ItemCount, ref OPCItemIDs, ref ClientHandles, out ItemServerHandles, out ItemServerErrors, RequestedDataTypes, AccessPaths);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ObjOPCGroup_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            try
            {
                for (int i = 1; i <= NumItems; i++)
                {
                    if ((Convert.ToInt32(ClientHandles.GetValue(i)) == 1))
                    {
                        try
                        {
                            WriteItems.SetValue(tb1.Text = ItemValues.GetValue(i).ToString(), 1);
                        }
                        catch(Exception)
                        {
                            continue;
                        }
                    }
                    if ((Convert.ToInt32(ClientHandles.GetValue(i)) == 2))
                    {
                        try
                        {
                            WriteItems.SetValue(tb2.Text = ItemValues.GetValue(i).ToString(), 2);
                        }
                        catch(Exception)
                        {
                            continue;
                        }
                    }
                    if ((Convert.ToInt32(ClientHandles.GetValue(i)) == 3))
                    {
                        try
                        {
                            WriteItems.SetValue(tb3.Text = ItemValues.GetValue(i).ToString(), 3);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    if ((Convert.ToInt32(ClientHandles.GetValue(i)) == 4))
                    {
                        try
                        {
                            WriteItems.SetValue(tb4.Text = ItemValues.GetValue(i).ToString(), 4);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    if ((Convert.ToInt32(ClientHandles.GetValue(i)) == 5))
                    {
                        try
                        {
                            WriteItems.SetValue(tb5.Text = ItemValues.GetValue(i).ToString(), 5);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    if ((Convert.ToInt32(ClientHandles.GetValue(i)) == 6))
                    {
                        try
                        {
                            WriteItems.SetValue(tb6.Text = ItemValues.GetValue(i).ToString(), 6);

                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    if ((Convert.ToInt32(ClientHandles.GetValue(i)) == 7))
                    {
                        try
                        {
                            WriteItems.SetValue(tb7.Text = ItemValues.GetValue(i).ToString(), 7);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                    if ((Convert.ToInt32(ClientHandles.GetValue(i)) == 8))
                    {
                        try
                        {
                            WriteItems.SetValue(lbbutton.Text = ItemValues.GetValue(i).ToString(), 8);
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btLed_Click(object sender, EventArgs e)
        {
           try
            {
                if (tb3.Text == "0")
                {
                    btLed.Text = "Off";
                    btLed.ForeColor = Color.Red;
                    WriteItems.SetValue(1, 3);
                    ConnectedGroup.SyncWrite(ItemCount, ref ItemServerHandles, ref WriteItems, out ItemServerErrors);
                    tb3.Text = "1";
                }
                else if(tb3.Text == "1")
                {
                    btLed.Text = "On";
                    btLed.ForeColor = Color.Green;
                    WriteItems.SetValue(0, 3);
                    ConnectedGroup.SyncWrite(ItemCount, ref ItemServerHandles, ref WriteItems, out ItemServerErrors);
                    tb3.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void btDis_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectedOPCServer.Disconnect();
                
            }
            catch(Exception)
            {
                
            }
        }


        private void btOn_Click(object sender, EventArgs e)
        {
            try
            {
                WriteItems.SetValue(1, 4);//set button On = 1
                ConnectedGroup.SyncWrite(ItemCount, ref ItemServerHandles, ref WriteItems, out ItemServerErrors);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btOff_Click(object sender, EventArgs e)
        {
            try
            {
                WriteItems.SetValue(0, 4);//set button On = 0
                ConnectedGroup.SyncWrite(ItemCount, ref ItemServerHandles, ref WriteItems, out ItemServerErrors);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb4_TextChanged(object sender, EventArgs e)
        {
            if (tb4.Text == "False")
                pb1.Image = Image.FromFile(@"E:\[Phanmem123.com] KEPServerEX v6.6.350.0\WindowsFormsApp1\Pic\Cylinder off.bmp");
            else if (tb4.Text == "True")
                pb1.Image = Image.FromFile(@"E:\[Phanmem123.com] KEPServerEX v6.6.350.0\WindowsFormsApp1\Pic\Cylinder on.bmp");
        }

        private void btOn1_Click(object sender, EventArgs e)//water pump
        {
            try
            {
                WriteItems.SetValue(1, 5);//set button On = 1
                ConnectedGroup.SyncWrite(ItemCount, ref ItemServerHandles, ref WriteItems, out ItemServerErrors);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btOff1_Click(object sender, EventArgs e)//water pump
        {
            try
            {
                WriteItems.SetValue(0, 5);//set button On = 0
                ConnectedGroup.SyncWrite(ItemCount, ref ItemServerHandles, ref WriteItems, out ItemServerErrors);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tb5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void vscroll1_Scroll(object sender, ScrollEventArgs e)
        {

            try
            {
                WriteItems.SetValue(10-vscroll1.Value, 6);
                ConnectedGroup.SyncWrite(ItemCount, ref ItemServerHandles, ref WriteItems, out ItemServerErrors);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void tb7_TextChanged(object sender, EventArgs e)
        {
            int waterlevel;
            waterlevel = (int) Math.Round(float.Parse(tb7.Text)/1000);
            progressBar1.Value = waterlevel;
        }

        private void tb6_TextChanged(object sender, EventArgs e)
        {
            vscroll1.Value = 10-int.Parse(tb6.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectedOPCServer.Disconnect();
                this.Close();
            }
            catch (Exception)
            {
                this.Close();
            }
        }

        

        private void lbbutton_TextChanged(object sender, EventArgs e)
        {
            if (lbbutton.Text == "1")
            {
                btOn1.PerformClick();
                lbbutton.ForeColor = Color.Green;
            }
            else if (lbbutton.Text == "0")
            {
                btOff1.PerformClick();
                lbbutton.ForeColor = Color.Red;
            }
        }
    }

    
}
