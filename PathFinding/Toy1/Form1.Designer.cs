namespace PathFinding
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_monitor = new System.Windows.Forms.Panel();
            this.panel_button = new System.Windows.Forms.TableLayoutPanel();
            this.text_thinktime = new System.Windows.Forms.TextBox();
            this.button_dfs = new System.Windows.Forms.Button();
            this.textbox_thinktime = new System.Windows.Forms.TextBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_astar = new System.Windows.Forms.Button();
            this.button_greedy = new System.Windows.Forms.Button();
            this.button_UCS = new System.Windows.Forms.Button();
            this.button_bfs = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.updown_iterative = new System.Windows.Forms.NumericUpDown();
            this.textbox_iterative = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel_button.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updown_iterative)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 650F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel_monitor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_button, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 650);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel_monitor
            // 
            this.panel_monitor.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel_monitor.Location = new System.Drawing.Point(3, 3);
            this.panel_monitor.Name = "panel_monitor";
            this.panel_monitor.Size = new System.Drawing.Size(644, 644);
            this.panel_monitor.TabIndex = 1;
            this.panel_monitor.Paint += new System.Windows.Forms.PaintEventHandler(this.makingEnvironment);
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_button.ColumnCount = 1;
            this.panel_button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panel_button.Controls.Add(this.text_thinktime, 0, 0);
            this.panel_button.Controls.Add(this.button_dfs, 0, 2);
            this.panel_button.Controls.Add(this.textbox_thinktime, 0, 1);
            this.panel_button.Controls.Add(this.button_exit, 0, 8);
            this.panel_button.Controls.Add(this.button_astar, 0, 7);
            this.panel_button.Controls.Add(this.button_greedy, 0, 6);
            this.panel_button.Controls.Add(this.button_UCS, 0, 5);
            this.panel_button.Controls.Add(this.button_bfs, 0, 4);
            this.panel_button.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.panel_button.Location = new System.Drawing.Point(653, 3);
            this.panel_button.Name = "panel_button";
            this.panel_button.RowCount = 9;
            this.panel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.panel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.panel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.71158F));
            this.panel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.70289F));
            this.panel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.71549F));
            this.panel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.71549F));
            this.panel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.71549F));
            this.panel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.71857F));
            this.panel_button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.72047F));
            this.panel_button.Size = new System.Drawing.Size(181, 634);
            this.panel_button.TabIndex = 2;
            // 
            // text_thinktime
            // 
            this.text_thinktime.BackColor = System.Drawing.SystemColors.MenuText;
            this.text_thinktime.ForeColor = System.Drawing.SystemColors.Window;
            this.text_thinktime.Location = new System.Drawing.Point(3, 3);
            this.text_thinktime.Name = "text_thinktime";
            this.text_thinktime.Size = new System.Drawing.Size(175, 28);
            this.text_thinktime.TabIndex = 10;
            this.text_thinktime.Text = "How much I think?";
            this.text_thinktime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_dfs
            // 
            this.button_dfs.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_dfs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_dfs.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_dfs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.button_dfs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_dfs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_dfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dfs.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_dfs.Location = new System.Drawing.Point(3, 219);
            this.button_dfs.Name = "button_dfs";
            this.button_dfs.Size = new System.Drawing.Size(175, 52);
            this.button_dfs.TabIndex = 6;
            this.button_dfs.Text = "DFS";
            this.button_dfs.UseVisualStyleBackColor = false;
            this.button_dfs.Click += new System.EventHandler(this.button_algo_Click);
            // 
            // textbox_thinktime
            // 
            this.textbox_thinktime.BackColor = System.Drawing.SystemColors.MenuText;
            this.textbox_thinktime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_thinktime.Enabled = false;
            this.textbox_thinktime.ForeColor = System.Drawing.Color.Lime;
            this.textbox_thinktime.HideSelection = false;
            this.textbox_thinktime.Location = new System.Drawing.Point(3, 43);
            this.textbox_thinktime.Name = "textbox_thinktime";
            this.textbox_thinktime.Size = new System.Drawing.Size(175, 21);
            this.textbox_thinktime.TabIndex = 13;
            // 
            // button_exit
            // 
            this.button_exit.BackColor = System.Drawing.Color.Gray;
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_exit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.button_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_exit.Location = new System.Drawing.Point(3, 572);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(175, 56);
            this.button_exit.TabIndex = 12;
            this.button_exit.Text = "EXIT";
            this.button_exit.UseVisualStyleBackColor = false;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_astar
            // 
            this.button_astar.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_astar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_astar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_astar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.button_astar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_astar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_astar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_astar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_astar.Location = new System.Drawing.Point(3, 511);
            this.button_astar.Name = "button_astar";
            this.button_astar.Size = new System.Drawing.Size(175, 52);
            this.button_astar.TabIndex = 9;
            this.button_astar.Text = "A*";
            this.button_astar.UseVisualStyleBackColor = false;
            this.button_astar.Click += new System.EventHandler(this.button_algo_Click);
            // 
            // button_greedy
            // 
            this.button_greedy.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_greedy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_greedy.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_greedy.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.button_greedy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_greedy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_greedy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_greedy.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_greedy.Location = new System.Drawing.Point(3, 450);
            this.button_greedy.Name = "button_greedy";
            this.button_greedy.Size = new System.Drawing.Size(175, 52);
            this.button_greedy.TabIndex = 8;
            this.button_greedy.Text = "Greedy";
            this.button_greedy.UseVisualStyleBackColor = false;
            this.button_greedy.Click += new System.EventHandler(this.button_algo_Click);
            // 
            // button_UCS
            // 
            this.button_UCS.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_UCS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_UCS.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_UCS.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.button_UCS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_UCS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_UCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UCS.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_UCS.Location = new System.Drawing.Point(3, 389);
            this.button_UCS.Name = "button_UCS";
            this.button_UCS.Size = new System.Drawing.Size(175, 52);
            this.button_UCS.TabIndex = 7;
            this.button_UCS.Text = "UCS";
            this.button_UCS.UseVisualStyleBackColor = false;
            this.button_UCS.Click += new System.EventHandler(this.button_algo_Click);
            // 
            // button_bfs
            // 
            this.button_bfs.BackColor = System.Drawing.SystemColors.Desktop;
            this.button_bfs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_bfs.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button_bfs.FlatAppearance.CheckedBackColor = System.Drawing.Color.Green;
            this.button_bfs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.button_bfs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.button_bfs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_bfs.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button_bfs.Location = new System.Drawing.Point(3, 328);
            this.button_bfs.Name = "button_bfs";
            this.button_bfs.Size = new System.Drawing.Size(175, 52);
            this.button_bfs.TabIndex = 6;
            this.button_bfs.Text = "BFS";
            this.button_bfs.UseVisualStyleBackColor = false;
            this.button_bfs.Click += new System.EventHandler(this.button_algo_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.14286F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.85714F));
            this.tableLayoutPanel2.Controls.Add(this.updown_iterative, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textbox_iterative, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 280);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(175, 42);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // updown_iterative
            // 
            this.updown_iterative.BackColor = System.Drawing.SystemColors.MenuText;
            this.updown_iterative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updown_iterative.ForeColor = System.Drawing.SystemColors.Window;
            this.updown_iterative.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updown_iterative.Location = new System.Drawing.Point(89, 3);
            this.updown_iterative.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.updown_iterative.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updown_iterative.Name = "updown_iterative";
            this.updown_iterative.Size = new System.Drawing.Size(83, 28);
            this.updown_iterative.TabIndex = 15;
            this.updown_iterative.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textbox_iterative
            // 
            this.textbox_iterative.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_iterative.BackColor = System.Drawing.SystemColors.MenuText;
            this.textbox_iterative.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_iterative.ForeColor = System.Drawing.SystemColors.Window;
            this.textbox_iterative.Location = new System.Drawing.Point(3, 10);
            this.textbox_iterative.Name = "textbox_iterative";
            this.textbox_iterative.Size = new System.Drawing.Size(79, 21);
            this.textbox_iterative.TabIndex = 10;
            this.textbox_iterative.Text = "Iterative";
            this.textbox_iterative.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(850, 650);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(900, 650);
            this.MinimumSize = new System.Drawing.Size(850, 650);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel_button.ResumeLayout(false);
            this.panel_button.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updown_iterative)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_monitor;
        private System.Windows.Forms.TableLayoutPanel panel_button;
        private System.Windows.Forms.TextBox text_thinktime;
        private System.Windows.Forms.Button button_greedy;
        private System.Windows.Forms.Button button_UCS;
        private System.Windows.Forms.Button button_astar;
        private System.Windows.Forms.Button button_bfs;
        private System.Windows.Forms.Button button_dfs;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.TextBox textbox_thinktime;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown updown_iterative;
        private System.Windows.Forms.TextBox textbox_iterative;
    }
}

