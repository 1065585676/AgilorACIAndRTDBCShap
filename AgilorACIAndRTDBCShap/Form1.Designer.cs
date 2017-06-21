namespace AgilorACIAndRTDBCShap
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            if (Form1.aci != null)
            {
                Form1.aci.Close();
                Form1.aci = null;
            }

            if (Form1.rtdbs.Count > 0)
            {
                foreach (var device in rtdbs)
                {
                    device.Value.Close();
                }
                rtdbs.Clear();
            }


            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_agilor_server_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_agilor_aci_port = new System.Windows.Forms.TextBox();
            this.textBox_agilor_rtdb_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_log_messages = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_show_all_devices = new System.Windows.Forms.Button();
            this.button_connect_aci = new System.Windows.Forms.Button();
            this.button_conncet_rtdb = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_agilor_rtdb_device_name = new System.Windows.Forms.TextBox();
            this.textBox_agilor_aci_server_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_show_target_property = new System.Windows.Forms.Button();
            this.textBox_agilor_target_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_show_target_value = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_agilor_device_name = new System.Windows.Forms.TextBox();
            this.button_show_device_targets = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_target_to_set_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_target_to_set_value = new System.Windows.Forms.TextBox();
            this.button_set_target_value = new System.Windows.Forms.Button();
            this.button_clear_log_messages = new System.Windows.Forms.Button();
            this.listBox_target_type = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button_show_target_history = new System.Windows.Forms.Button();
            this.button_get_target_name_by_id = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_agilor_target_id = new System.Windows.Forms.TextBox();
            this.button_disconncet_rtdb = new System.Windows.Forms.Button();
            this.button_disconnect_rtbd_all = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_agilor_server_ip
            // 
            this.textBox_agilor_server_ip.Location = new System.Drawing.Point(118, 28);
            this.textBox_agilor_server_ip.Name = "textBox_agilor_server_ip";
            this.textBox_agilor_server_ip.Size = new System.Drawing.Size(311, 20);
            this.textBox_agilor_server_ip.TabIndex = 0;
            this.textBox_agilor_server_ip.Text = "127.0.0.1";
            this.textBox_agilor_server_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agilor Server IP:";
            // 
            // textBox_agilor_aci_port
            // 
            this.textBox_agilor_aci_port.Location = new System.Drawing.Point(118, 68);
            this.textBox_agilor_aci_port.Name = "textBox_agilor_aci_port";
            this.textBox_agilor_aci_port.Size = new System.Drawing.Size(107, 20);
            this.textBox_agilor_aci_port.TabIndex = 2;
            this.textBox_agilor_aci_port.Text = "900";
            this.textBox_agilor_aci_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_agilor_rtdb_port
            // 
            this.textBox_agilor_rtdb_port.Location = new System.Drawing.Point(581, 68);
            this.textBox_agilor_rtdb_port.Name = "textBox_agilor_rtdb_port";
            this.textBox_agilor_rtdb_port.Size = new System.Drawing.Size(107, 20);
            this.textBox_agilor_rtdb_port.TabIndex = 3;
            this.textBox_agilor_rtdb_port.Text = "700";
            this.textBox_agilor_rtdb_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agilor ACI Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Agilor RTDB Port:";
            // 
            // textBox_log_messages
            // 
            this.textBox_log_messages.Location = new System.Drawing.Point(12, 455);
            this.textBox_log_messages.Multiline = true;
            this.textBox_log_messages.Name = "textBox_log_messages";
            this.textBox_log_messages.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_log_messages.Size = new System.Drawing.Size(417, 267);
            this.textBox_log_messages.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Log Messages:";
            // 
            // button_show_all_devices
            // 
            this.button_show_all_devices.Location = new System.Drawing.Point(33, 150);
            this.button_show_all_devices.Name = "button_show_all_devices";
            this.button_show_all_devices.Size = new System.Drawing.Size(396, 23);
            this.button_show_all_devices.TabIndex = 8;
            this.button_show_all_devices.Text = "Show All Devices";
            this.button_show_all_devices.UseVisualStyleBackColor = true;
            this.button_show_all_devices.Click += new System.EventHandler(this.button_show_all_devices_Click);
            // 
            // button_connect_aci
            // 
            this.button_connect_aci.Location = new System.Drawing.Point(32, 109);
            this.button_connect_aci.Name = "button_connect_aci";
            this.button_connect_aci.Size = new System.Drawing.Size(397, 23);
            this.button_connect_aci.TabIndex = 9;
            this.button_connect_aci.Text = "Connect ACI";
            this.button_connect_aci.UseVisualStyleBackColor = true;
            this.button_connect_aci.Click += new System.EventHandler(this.button_connect_aci_Click);
            // 
            // button_conncet_rtdb
            // 
            this.button_conncet_rtdb.Location = new System.Drawing.Point(487, 109);
            this.button_conncet_rtdb.Name = "button_conncet_rtdb";
            this.button_conncet_rtdb.Size = new System.Drawing.Size(116, 23);
            this.button_conncet_rtdb.TabIndex = 10;
            this.button_conncet_rtdb.Text = "Connect RTDB";
            this.button_conncet_rtdb.UseVisualStyleBackColor = true;
            this.button_conncet_rtdb.Click += new System.EventHandler(this.button_conncet_rtdb_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(704, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Device Name:";
            // 
            // textBox_agilor_rtdb_device_name
            // 
            this.textBox_agilor_rtdb_device_name.Location = new System.Drawing.Point(785, 68);
            this.textBox_agilor_rtdb_device_name.Name = "textBox_agilor_rtdb_device_name";
            this.textBox_agilor_rtdb_device_name.Size = new System.Drawing.Size(107, 20);
            this.textBox_agilor_rtdb_device_name.TabIndex = 12;
            this.textBox_agilor_rtdb_device_name.Text = "TestDevice";
            this.textBox_agilor_rtdb_device_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_agilor_aci_server_name
            // 
            this.textBox_agilor_aci_server_name.Location = new System.Drawing.Point(322, 68);
            this.textBox_agilor_aci_server_name.Name = "textBox_agilor_aci_server_name";
            this.textBox_agilor_aci_server_name.Size = new System.Drawing.Size(107, 20);
            this.textBox_agilor_aci_server_name.TabIndex = 14;
            this.textBox_agilor_aci_server_name.Text = "Agilor";
            this.textBox_agilor_aci_server_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Server Name:";
            // 
            // button_show_target_property
            // 
            this.button_show_target_property.Location = new System.Drawing.Point(277, 220);
            this.button_show_target_property.Name = "button_show_target_property";
            this.button_show_target_property.Size = new System.Drawing.Size(152, 23);
            this.button_show_target_property.TabIndex = 15;
            this.button_show_target_property.Text = "Show Target Property";
            this.button_show_target_property.UseVisualStyleBackColor = true;
            this.button_show_target_property.Click += new System.EventHandler(this.button_show_target_property_Click);
            // 
            // textBox_agilor_target_name
            // 
            this.textBox_agilor_target_name.Location = new System.Drawing.Point(137, 222);
            this.textBox_agilor_target_name.Name = "textBox_agilor_target_name";
            this.textBox_agilor_target_name.Size = new System.Drawing.Size(107, 20);
            this.textBox_agilor_target_name.TabIndex = 16;
            this.textBox_agilor_target_name.Text = "Station-1-Point-1";
            this.textBox_agilor_target_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Agilor Target Name:";
            // 
            // button_show_target_value
            // 
            this.button_show_target_value.Location = new System.Drawing.Point(277, 258);
            this.button_show_target_value.Name = "button_show_target_value";
            this.button_show_target_value.Size = new System.Drawing.Size(152, 23);
            this.button_show_target_value.TabIndex = 18;
            this.button_show_target_value.Text = "Show Target Value";
            this.button_show_target_value.UseVisualStyleBackColor = true;
            this.button_show_target_value.Click += new System.EventHandler(this.button_show_target_value_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Agilor Device Name:";
            // 
            // textBox_agilor_device_name
            // 
            this.textBox_agilor_device_name.Location = new System.Drawing.Point(137, 182);
            this.textBox_agilor_device_name.Name = "textBox_agilor_device_name";
            this.textBox_agilor_device_name.Size = new System.Drawing.Size(107, 20);
            this.textBox_agilor_device_name.TabIndex = 19;
            this.textBox_agilor_device_name.Text = "Station-1";
            this.textBox_agilor_device_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_show_device_targets
            // 
            this.button_show_device_targets.Location = new System.Drawing.Point(277, 180);
            this.button_show_device_targets.Name = "button_show_device_targets";
            this.button_show_device_targets.Size = new System.Drawing.Size(152, 23);
            this.button_show_device_targets.TabIndex = 21;
            this.button_show_device_targets.Text = "Show Device Targets";
            this.button_show_device_targets.UseVisualStyleBackColor = true;
            this.button_show_device_targets.Click += new System.EventHandler(this.button_show_device_targets_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Target Name:";
            // 
            // textBox_target_to_set_name
            // 
            this.textBox_target_to_set_name.Location = new System.Drawing.Point(136, 307);
            this.textBox_target_to_set_name.Name = "textBox_target_to_set_name";
            this.textBox_target_to_set_name.Size = new System.Drawing.Size(107, 20);
            this.textBox_target_to_set_name.TabIndex = 22;
            this.textBox_target_to_set_name.Text = "Station-1-Point-1";
            this.textBox_target_to_set_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Target Value:";
            // 
            // textBox_target_to_set_value
            // 
            this.textBox_target_to_set_value.Location = new System.Drawing.Point(136, 333);
            this.textBox_target_to_set_value.Name = "textBox_target_to_set_value";
            this.textBox_target_to_set_value.Size = new System.Drawing.Size(107, 20);
            this.textBox_target_to_set_value.TabIndex = 24;
            this.textBox_target_to_set_value.Text = "12.5";
            this.textBox_target_to_set_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_set_target_value
            // 
            this.button_set_target_value.Location = new System.Drawing.Point(277, 317);
            this.button_set_target_value.Name = "button_set_target_value";
            this.button_set_target_value.Size = new System.Drawing.Size(152, 23);
            this.button_set_target_value.TabIndex = 26;
            this.button_set_target_value.Text = "Set Target Value";
            this.button_set_target_value.UseVisualStyleBackColor = true;
            this.button_set_target_value.Click += new System.EventHandler(this.button_set_target_value_Click);
            // 
            // button_clear_log_messages
            // 
            this.button_clear_log_messages.Location = new System.Drawing.Point(346, 422);
            this.button_clear_log_messages.Name = "button_clear_log_messages";
            this.button_clear_log_messages.Size = new System.Drawing.Size(83, 23);
            this.button_clear_log_messages.TabIndex = 27;
            this.button_clear_log_messages.Text = "Clear";
            this.button_clear_log_messages.UseVisualStyleBackColor = true;
            this.button_clear_log_messages.Click += new System.EventHandler(this.button_clear_log_messages_Click);
            // 
            // listBox_target_type
            // 
            this.listBox_target_type.FormattingEnabled = true;
            this.listBox_target_type.Items.AddRange(new object[] {
            "FLOAT",
            "LONG",
            "STRING",
            "BOOL"});
            this.listBox_target_type.Location = new System.Drawing.Point(136, 360);
            this.listBox_target_type.Name = "listBox_target_type";
            this.listBox_target_type.Size = new System.Drawing.Size(107, 56);
            this.listBox_target_type.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Target Type:";
            // 
            // button_show_target_history
            // 
            this.button_show_target_history.Location = new System.Drawing.Point(92, 258);
            this.button_show_target_history.Name = "button_show_target_history";
            this.button_show_target_history.Size = new System.Drawing.Size(152, 23);
            this.button_show_target_history.TabIndex = 30;
            this.button_show_target_history.Text = "Show Target History";
            this.button_show_target_history.UseVisualStyleBackColor = true;
            this.button_show_target_history.Click += new System.EventHandler(this.button_show_target_history_Click);
            // 
            // button_get_target_name_by_id
            // 
            this.button_get_target_name_by_id.Location = new System.Drawing.Point(740, 185);
            this.button_get_target_name_by_id.Name = "button_get_target_name_by_id";
            this.button_get_target_name_by_id.Size = new System.Drawing.Size(152, 23);
            this.button_get_target_name_by_id.TabIndex = 33;
            this.button_get_target_name_by_id.Text = "Get Target Name By ID";
            this.button_get_target_name_by_id.UseVisualStyleBackColor = true;
            this.button_get_target_name_by_id.Click += new System.EventHandler(this.button_get_target_name_by_id_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(484, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Target ID:";
            // 
            // textBox_agilor_target_id
            // 
            this.textBox_agilor_target_id.Location = new System.Drawing.Point(545, 185);
            this.textBox_agilor_target_id.Name = "textBox_agilor_target_id";
            this.textBox_agilor_target_id.Size = new System.Drawing.Size(107, 20);
            this.textBox_agilor_target_id.TabIndex = 31;
            this.textBox_agilor_target_id.Text = "100";
            this.textBox_agilor_target_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_disconncet_rtdb
            // 
            this.button_disconncet_rtdb.Location = new System.Drawing.Point(632, 109);
            this.button_disconncet_rtdb.Name = "button_disconncet_rtdb";
            this.button_disconncet_rtdb.Size = new System.Drawing.Size(116, 23);
            this.button_disconncet_rtdb.TabIndex = 34;
            this.button_disconncet_rtdb.Text = "Disconnect RTDB";
            this.button_disconncet_rtdb.UseVisualStyleBackColor = true;
            this.button_disconncet_rtdb.Click += new System.EventHandler(this.button_disconncet_rtdb_Click);
            // 
            // button_disconnect_rtbd_all
            // 
            this.button_disconnect_rtbd_all.Location = new System.Drawing.Point(776, 109);
            this.button_disconnect_rtbd_all.Name = "button_disconnect_rtbd_all";
            this.button_disconnect_rtbd_all.Size = new System.Drawing.Size(116, 23);
            this.button_disconnect_rtbd_all.TabIndex = 35;
            this.button_disconnect_rtbd_all.Text = "Disconnect RTDB All";
            this.button_disconnect_rtbd_all.UseVisualStyleBackColor = true;
            this.button_disconnect_rtbd_all.Click += new System.EventHandler(this.button_disconnect_rtbd_all_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 734);
            this.Controls.Add(this.button_disconnect_rtbd_all);
            this.Controls.Add(this.button_disconncet_rtdb);
            this.Controls.Add(this.button_get_target_name_by_id);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_agilor_target_id);
            this.Controls.Add(this.button_show_target_history);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox_target_type);
            this.Controls.Add(this.button_clear_log_messages);
            this.Controls.Add(this.button_set_target_value);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_target_to_set_value);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_target_to_set_name);
            this.Controls.Add(this.button_show_device_targets);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_agilor_device_name);
            this.Controls.Add(this.button_show_target_value);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_agilor_target_name);
            this.Controls.Add(this.button_show_target_property);
            this.Controls.Add(this.textBox_agilor_aci_server_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_agilor_rtdb_device_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_conncet_rtdb);
            this.Controls.Add(this.button_connect_aci);
            this.Controls.Add(this.button_show_all_devices);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_log_messages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_agilor_rtdb_port);
            this.Controls.Add(this.textBox_agilor_aci_port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_agilor_server_ip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_agilor_server_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_agilor_aci_port;
        private System.Windows.Forms.TextBox textBox_agilor_rtdb_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_log_messages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_show_all_devices;
        private System.Windows.Forms.Button button_connect_aci;
        private System.Windows.Forms.Button button_conncet_rtdb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_agilor_rtdb_device_name;
        private System.Windows.Forms.TextBox textBox_agilor_aci_server_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_show_target_property;
        private System.Windows.Forms.TextBox textBox_agilor_target_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_show_target_value;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_agilor_device_name;
        private System.Windows.Forms.Button button_show_device_targets;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_target_to_set_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_target_to_set_value;
        private System.Windows.Forms.Button button_set_target_value;
        private System.Windows.Forms.Button button_clear_log_messages;
        private System.Windows.Forms.ListBox listBox_target_type;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button_show_target_history;
        private System.Windows.Forms.Button button_get_target_name_by_id;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_agilor_target_id;
        private System.Windows.Forms.Button button_disconncet_rtdb;
        private System.Windows.Forms.Button button_disconnect_rtbd_all;
    }
}

