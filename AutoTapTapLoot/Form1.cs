using System.Collections.Generic;
using System.Drawing;
using System.IO.Pipes;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AutoTapTapLoot
{
    public partial class Form1 : Form
    {
        private static readonly Color DarkBackground = Color.FromArgb(30, 30, 30);
        private static readonly Color DarkControl    = Color.FromArgb(50, 50, 50);

        private static readonly string[] BuffNames =
        {
            "Health", "Attack", "Armor", "CritChance", "Regeneration",
            "SpellPower", "Thorns", "Block", "Dodge", "Slow"
        };

        private readonly Dictionary<string, CheckBox>       _buffChecks = [];
        private readonly Dictionary<string, NumericUpDown>  _buffValues = [];

        private NamedPipeServerStream? _buffPipe;
        private NamedPipeServerStream? _tapPipe;
        private volatile bool _tapEnabled;

        public Form1()
        {
            InitializeComponent();
            BuildBuffTable();
            ApplyDarkTheme();
            StartBuffPipe();
            StartTapPipeWorker();
        }

        // ── Buff UI ──────────────────────────────────────────────────────────

        private void BuildBuffTable()
        {
            labelStatusBuff.Text     = "Unknown";
            labelStatusBuff.ForeColor = Color.Gray;

            tableLayoutPanelBuffs.AutoSize  = true;
            tableLayoutPanelBuffs.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
            tableLayoutPanelBuffs.SuspendLayout();
            tableLayoutPanelBuffs.RowCount = BuffNames.Length;
            tableLayoutPanelBuffs.Controls.Clear();

            for (int i = 0; i < BuffNames.Length; i++)
            {
                string name = BuffNames[i];

                var chk = new CheckBox { 
                    Checked = true, 
                    AutoSize = true 
                };
                var lbl = new Label { 
                    Text = name, 
                    AutoSize = true, 
                    ForeColor = Color.White 
                };
                var num = new NumericUpDown {
                    Minimum       = -10_000_000,
                    Maximum       = 10_000_000,
                    DecimalPlaces = 2,
                    Value         = (name != "Slow") ? 100 : -100,
                    Width         = 120
                };

                _buffChecks[name] = chk;
                _buffValues[name] = num;

                tableLayoutPanelBuffs.Controls.Add(chk, 0, i);
                tableLayoutPanelBuffs.Controls.Add(lbl, 1, i);
                tableLayoutPanelBuffs.Controls.Add(num, 2, i);
            }

            tableLayoutPanelBuffs.ResumeLayout();
        }

        // ── Theme ─────────────────────────────────────────────────────────────

        private void ApplyDarkTheme()
        {
            BackColor = DarkBackground;
            ForeColor = Color.White;
            ApplyThemeToControls(Controls);
        }

        private void ApplyThemeToControls(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                switch (c)
                {
                    case Button btn:
                        btn.BackColor = DarkControl;
                        btn.ForeColor = Color.White;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.FlatAppearance.BorderColor = Color.Gray;
                        break;
                    case CheckBox cb:
                        cb.ForeColor = Color.White;
                        cb.BackColor = DarkBackground;
                        break;
                    case NumericUpDown num:
                        num.BackColor = DarkControl;
                        num.ForeColor = Color.White;
                        break;
                    case TextBox tb:
                        tb.BackColor = DarkControl;
                        tb.ForeColor = Color.White;
                        tb.BorderStyle = BorderStyle.FixedSingle;
                        break;
                    case GroupBox gb:
                        gb.ForeColor = Color.White;
                        gb.BackColor = DarkBackground;
                        break;
                }

                if (c.HasChildren)
                    ApplyThemeToControls(c.Controls);
            }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static void SetLabelStatus(Label label, string text, Color color)
        {
            if (label.InvokeRequired)
            {
                label.Invoke(() => SetLabelStatus(label, text, color));
                return;
            }
            label.Text      = text;
            label.ForeColor = color;
        }

        private static void SendString(NamedPipeServerStream? pipe, string msg)
        {
            if (pipe == null || !pipe.IsConnected)
                return;

            byte[] data   = Encoding.Unicode.GetBytes(msg);
            ushort len    = (ushort)data.Length;
            byte[] prefix = [(byte)(len >> 8), (byte)(len & 0xFF)];

            pipe.Write(prefix, 0, 2);
            pipe.Write(data, 0, data.Length);
            pipe.Flush();
        }

        // ── Pipes ─────────────────────────────────────────────────────────────

        private void StartTapPipeWorker()
        {
            SetLabelStatus(labelStatusTap, "Disabled", Color.Red);

            var thread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        SetLabelStatus(labelStatusPipeTap, "Waiting...", Color.Orange);

                        _tapPipe = new NamedPipeServerStream(
                            "TapTapLootxTheFarmerWasReplaced",
                            PipeDirection.InOut, 1,
                            PipeTransmissionMode.Byte, PipeOptions.None);

                        _tapPipe.WaitForConnection();
                        SetLabelStatus(labelStatusPipeTap, "Connected", Color.Lime);

                        while (_tapPipe.IsConnected)
                        {
                            if (!_tapEnabled)
                            {
                                Thread.Sleep(50);
                                continue;
                            }

                            int pps = Math.Max(1, (int)numericUpDownPacketsPerSecond.Value);
                            SendString(_tapPipe, ((int)numericUpDownTapsPerPacket.Value).ToString());
                            Thread.Sleep(1000 / pps);
                        }

                        SetLabelStatus(labelStatusPipeTap, "Disconnected", Color.Red);
                    }
                    catch
                    {
                        SetLabelStatus(labelStatusPipeTap, "Error", Color.Red);
                    }
                    finally
                    {
                        _tapPipe?.Dispose();
                        _tapPipe = null;
                    }

                    Thread.Sleep(1000);
                }
            }) { IsBackground = true };

            thread.Start();
        }

        private void StartBuffPipe()
        {
            var thread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        SetLabelStatus(labelStatusPipeBuff, "Waiting...", Color.Orange);

                        _buffPipe = new NamedPipeServerStream(
                            "TapTapLootxBongoCat",
                            PipeDirection.InOut, 1,
                            PipeTransmissionMode.Byte, PipeOptions.None);

                        _buffPipe.WaitForConnection();
                        SetLabelStatus(labelStatusPipeBuff, "Connected", Color.Lime);

                        while (_buffPipe.IsConnected)
                            Thread.Sleep(100);

                        SetLabelStatus(labelStatusPipeBuff, "Disconnected", Color.Red);
                    }
                    catch
                    {
                        SetLabelStatus(labelStatusPipeBuff, "Error", Color.Red);
                    }
                    finally
                    {
                        _buffPipe?.Dispose();
                        _buffPipe = null;
                    }

                    Thread.Sleep(1000);
                }
            }) { IsBackground = true };

            thread.Start();
        }

        // ── Button handlers ───────────────────────────────────────────────────

        private void buttonBuffsApply_Click(object sender, EventArgs e)
        {
            SetLabelStatus(labelStatusBuff, "Applied", Color.Lime);

            var buffs = new List<object>();
            foreach (string name in BuffNames)
            {
                if (!_buffChecks[name].Checked) continue;
                buffs.Add(new { Name = name, Value = (float)_buffValues[name].Value });
            }

            SendString(_buffPipe, JsonConvert.SerializeObject(buffs));
        }

        private void buttonBuffsDefault_Click(object sender, EventArgs e)
        {
            SetLabelStatus(labelStatusBuff, "Default", Color.White);

            var buffs = new List<object>();
            foreach (string name in BuffNames)
                buffs.Add(new { Name = name, Value = 0f });

            SendString(_buffPipe, JsonConvert.SerializeObject(buffs));
        }

        private void buttonAutoTapEnable_Click(object sender, EventArgs e)
        {
            SetLabelStatus(labelStatusTap, "Enabled", Color.Lime);
            _tapEnabled = true;
        }

        private void buttonAutoTapDisable_Click(object sender, EventArgs e)
        {
            SetLabelStatus(labelStatusTap, "Disabled", Color.Red);
            _tapEnabled = false;
        }

    }
}
