using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Agilor.Interface;

namespace AgilorACIAndRTDBCShap
{
    public partial class Form1 : Form
    {
        public static ACI aci = null;
        //public static RTDB rtdb = null;

        public static Dictionary<string, RTDB> rtdbs = new Dictionary<string, RTDB>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_conncet_rtdb_Click(object sender, EventArgs e)
        {
            button_conncet_rtdb.Enabled = false;
            try
            {
                string deviceName = textBox_agilor_rtdb_device_name.Text;
                if (!rtdbs.ContainsKey(deviceName))
                {
                    RTDB rtdb = RTDB.Instance(deviceName, textBox_agilor_server_ip.Text, int.Parse(textBox_agilor_rtdb_port.Text));
                    rtdb.ValueReceived += Rtdb_ValueReceived;

                    rtdbs[deviceName] = rtdb;
                    textBox_log_messages.AppendText("Agilor Device: "+ deviceName + " RTDB Connected!\n");
                }
                else
                {
                    textBox_log_messages.AppendText("Agilor Device: " + deviceName + " RTDB Is Connected!\n");
                }
            }
            catch (Exception ex)
            {
                textBox_log_messages.AppendText(ex.ToString() + "\n");
            }
            button_conncet_rtdb.Enabled = true;
        }

        private void Rtdb_ValueReceived(Agilor.Interface.Val.Value value)
        {
            //throw new NotImplementedException();

            // set target value 
            textBox_log_messages.Invoke(new Action<string> (textBox_log_messages.AppendText), new string[] { "Agilor RTDB Value Received!\n" });

            foreach (var device in rtdbs)
            {
                device.Value.WriteValue(value);
            }
            
            textBox_log_messages.Invoke(new Action<string>(textBox_log_messages.AppendText), new string[] { "Agilor RTDB Value Set:\n" });
            textBox_log_messages.Invoke(new Action<string>(textBox_log_messages.AppendText), new string[] { "Name:" + value.Name + "\n" });
            textBox_log_messages.Invoke(new Action<string>(textBox_log_messages.AppendText), new string[] { "Value:" + value.Val + "\n" });
            textBox_log_messages.Invoke(new Action<string>(textBox_log_messages.AppendText), new string[] { "Type:" + value.Type + "\n" });
            textBox_log_messages.Invoke(new Action<string>(textBox_log_messages.AppendText), new string[] { "Time:" + value.Time + "\n" });
            textBox_log_messages.Invoke(new Action<string>(textBox_log_messages.AppendText), new string[] { "State:" + value.State + "\n" });

        }

        private void button_connect_aci_Click(object sender, EventArgs e)
        {
            button_connect_aci.Enabled = false;

            if(aci == null)
            {
                aci = ACI.Instance(textBox_agilor_aci_server_name.Text, textBox_agilor_server_ip.Text, int.Parse(textBox_agilor_aci_port.Text));
                textBox_log_messages.AppendText("Agilor ACI Connected!\n");
                button_connect_aci.Text = "Disconnect ACI";
            } else
            {
                aci.Close();
                aci = null;

                textBox_log_messages.AppendText("Agilor ACI Disconnected!\n");
                button_connect_aci.Text = "Connect ACI";
            }

            button_connect_aci.Enabled = true;
        }

        private void button_show_all_devices_Click(object sender, EventArgs e)
        {
            if(aci == null)
            {
                textBox_log_messages.AppendText("Agilor ACI Is NULL!\n");
                return;
            }

            button_show_all_devices.Enabled = false;

            try
            {
                var result = aci.getDevices();
                textBox_log_messages.AppendText("Agilor Devices Count:" + result.Count + "\n");
                foreach (var device in result)
                {
                    textBox_log_messages.AppendText("Devices Name:" + device.Name + "\n");
                    textBox_log_messages.AppendText("Devices IsOnline:" + device.IsOnline + "\n");
                }
            } catch (Exception ex)
            {
                textBox_log_messages.AppendText(ex.ToString() + "\n");
            }

            button_show_all_devices.Enabled = true;
        }

        private void button_show_target_property_Click(object sender, EventArgs e)
        {
            if (aci == null)
            {
                textBox_log_messages.AppendText("Agilor ACI Is NULL!\n");
                return;
            }

            button_show_target_property.Enabled = false;

            var result = aci.GetTarget(textBox_agilor_target_name.Text);
            textBox_log_messages.AppendText("ID:" + result.Id + "\n");
            textBox_log_messages.AppendText("Name:" + result.Name + "\n");
            textBox_log_messages.AppendText("SourceName:" + result.SourceName + "\n");
            textBox_log_messages.AppendText("Device:" + result.Device + "\n");
            textBox_log_messages.AppendText("Type:" + result.Type + "\n");
            textBox_log_messages.AppendText("Scan:" + result.Scan + "\n");

            button_show_target_property.Enabled = true;
        }

        private void button_show_target_value_Click(object sender, EventArgs e)
        {
            if (aci == null)
            {
                textBox_log_messages.AppendText("Agilor ACI Is NULL!\n");
                return;
            }

            button_show_target_property.Enabled = false;

            var result = aci.QuerySnapshots(textBox_agilor_target_name.Text);
            textBox_log_messages.AppendText("Name:" + result.Name + "\n");
            textBox_log_messages.AppendText("Type:" + result.Type + "\n");
            textBox_log_messages.AppendText("Value:" + result.Val + "\n");
            textBox_log_messages.AppendText("State:" + result.State + "\n");
            textBox_log_messages.AppendText("Time:" + result.Time + "\n");

            button_show_target_property.Enabled = true;
        }

        private void button_show_device_targets_Click(object sender, EventArgs e)
        {
            if (aci == null)
            {
                textBox_log_messages.AppendText("Agilor ACI Is NULL!\n");
                return;
            }

            button_show_device_targets.Enabled = false;

            var result = aci.getTargetsByDevice(textBox_agilor_device_name.Text);
            textBox_log_messages.AppendText("Agilor Device '" + textBox_agilor_device_name.Text + "' Targets Count:" + result.Count + "\n");
            foreach (var simpleTarget in result)
            {
                textBox_log_messages.AppendText("Target ID:" + simpleTarget.Id + "\n");
                textBox_log_messages.AppendText("Target Name:" + simpleTarget.Name + "\n");
            }

            button_show_device_targets.Enabled = true;
        }

        private void button_set_target_value_Click(object sender, EventArgs e)
        {
            if (aci == null)
            {
                textBox_log_messages.AppendText("Agilor ACI Is NULL!\n");
                return;
            }

            button_set_target_value.Enabled = false;

            object val = textBox_target_to_set_value.Text;
            try
            {
                switch (listBox_target_type.Text)
                {
                    case "LONG":
                        val = long.Parse(textBox_target_to_set_value.Text);
                        break;
                    case "FLOAT":
                        val = float.Parse(textBox_target_to_set_value.Text);
                        break;
                    case "BOOL":
                        val = bool.Parse(textBox_target_to_set_value.Text);
                        break;
                    case "STRING":
                        val = textBox_target_to_set_value.Text;
                        break;
                }
            } catch(Exception ex)
            {
                textBox_log_messages.AppendText(ex .ToString() + "\n");
                val = textBox_target_to_set_value.Text;
            }

            aci.SetValue(new Agilor.Interface.Val.Value(textBox_target_to_set_name.Text, val));
            textBox_log_messages.AppendText("Agilor ACI Value Set:"+ textBox_target_to_set_name.Text + " - " + textBox_target_to_set_value.Text + "\n");

            button_set_target_value.Enabled = true;
        }

        private void button_clear_log_messages_Click(object sender, EventArgs e)
        {
            textBox_log_messages.Clear();
        }

        private void button_show_target_history_Click(object sender, EventArgs e)
        {
            if (aci == null)
            {
                textBox_log_messages.AppendText("Agilor ACI Is NULL!\n");
                return;
            }

            var result = aci.QueryTagHistory(textBox_agilor_target_name.Text, DateTime.Now.AddMonths(-1), DateTime.Now);
            textBox_log_messages.AppendText("Agilor Target " + textBox_agilor_target_name.Text + " History Count:" + result.Count + "\n");
            foreach (var value in result)
            {
                textBox_log_messages.AppendText("Name:" + value.Name + "\n");
                textBox_log_messages.AppendText("Value:" + value.Val + "\n");
                textBox_log_messages.AppendText("Type:" + value.Type + "\n");
                textBox_log_messages.AppendText("Time:" + value.Time + "\n");
                textBox_log_messages.AppendText("State:" + value.State + "\n");
            }
            textBox_log_messages.AppendText("Agilor Target " + textBox_agilor_target_name.Text + " History Count:" + result.Count + "\n");
        }

        private void button_get_target_name_by_id_Click(object sender, EventArgs e)
        {
            if (aci == null)
            {
                textBox_log_messages.AppendText("Agilor ACI Is NULL!\n");
                return;
            }

            int id = int.Parse(textBox_agilor_target_id.Text);
            string targetName = aci.getTargetNameById(id);

            textBox_log_messages.AppendText("Agilor Target:\nID:" + id.ToString() + "\nTarget Name:" + targetName + "\n");
        }

        private void button_disconncet_rtdb_Click(object sender, EventArgs e)
        {
            button_disconncet_rtdb.Enabled = false;
            try
            {
                string deviceName = textBox_agilor_rtdb_device_name.Text;
                if (rtdbs.ContainsKey(deviceName))
                {
                    rtdbs[deviceName].Close();
                    rtdbs.Remove(deviceName);
                    textBox_log_messages.AppendText("Agilor Device: " + deviceName + " RTDB Disconnected!\n");
                }
                else
                {
                    textBox_log_messages.AppendText("Agilor Device: " + deviceName + " RTDB Is Not Connected!\n");
                }
            }
            catch (Exception ex)
            {
                textBox_log_messages.AppendText(ex.ToString() + "\n");
            }
            button_disconncet_rtdb.Enabled = true;
        }

        private void button_disconnect_rtbd_all_Click(object sender, EventArgs e)
        {
            button_disconnect_rtbd_all.Enabled = false;
            try
            {
                foreach (var device in rtdbs)
                {
                    device.Value.Close();
                }
                rtdbs.Clear();
                textBox_log_messages.AppendText("Agilor Devices RTDB All Disconnected!\n");
            }
            catch (Exception ex)
            {
                textBox_log_messages.AppendText(ex.ToString() + "\n");
            }
            button_disconnect_rtbd_all.Enabled = true;
        }
    }
}
