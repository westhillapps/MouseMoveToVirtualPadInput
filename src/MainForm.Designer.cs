using System.Windows.Forms;

namespace MouseMoveToVirtualPadInput
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Label Label_Line_1;
			Label Label_Line_2;
			Label Label_X_Plus_Button_1;
			Label Label_X_Plus_Button_2;
			Label Label_X_Minus_Button_1;
			Label Label_X_Minus_Button_2;
			Label Label_X_Axis_1;
			Label Label_X_Axis_2;
			Label Label_Y_Plus_Button_1;
			Label Label_Y_Plus_Button_2;
			Label Label_Y_Minus_Button_1;
			Label Label_Y_Minus_Button_2;
			Label Label_Y_Axis_1;
			Label Label_Y_Axis_2;
			Label Label_MoveStopTime;
			Label Label_MoveDeadZone;
			Label_App_Version = new Label();
			CheckBox_Enable = new CheckBox();
			ComboBox_X_Plus_Button = new ComboBox();
			ComboBox_X_Minus_Button = new ComboBox();
			ComboBox_X_Axis = new ComboBox();
			PicBox_X_Plus_Button = new PictureBox();
			PicBox_X_Minus_Button = new PictureBox();
			PicBox_X_Axis = new PictureBox();
			ComboBox_Y_Plus_Button = new ComboBox();
			ComboBox_Y_Minus_Button = new ComboBox();
			ComboBox_Y_Axis = new ComboBox();
			PicBox_Y_Plus_Button = new PictureBox();
			PicBox_Y_Minus_Button = new PictureBox();
			PicBox_Y_Axis = new PictureBox();
			NumBox_MouseStopTime = new NumericUpDown();
			NumBox_MouseDeadZone = new NumericUpDown();
			Label_Line_1 = new Label();
			Label_Line_2 = new Label();
			Label_X_Plus_Button_1 = new Label();
			Label_X_Plus_Button_2 = new Label();
			Label_X_Minus_Button_1 = new Label();
			Label_X_Minus_Button_2 = new Label();
			Label_X_Axis_1 = new Label();
			Label_X_Axis_2 = new Label();
			Label_Y_Plus_Button_1 = new Label();
			Label_Y_Plus_Button_2 = new Label();
			Label_Y_Minus_Button_1 = new Label();
			Label_Y_Minus_Button_2 = new Label();
			Label_Y_Axis_1 = new Label();
			Label_Y_Axis_2 = new Label();
			Label_MoveStopTime = new Label();
			Label_MoveDeadZone = new Label();
			((System.ComponentModel.ISupportInitialize)PicBox_X_Plus_Button).BeginInit();
			((System.ComponentModel.ISupportInitialize)PicBox_X_Minus_Button).BeginInit();
			((System.ComponentModel.ISupportInitialize)PicBox_X_Axis).BeginInit();
			((System.ComponentModel.ISupportInitialize)PicBox_Y_Plus_Button).BeginInit();
			((System.ComponentModel.ISupportInitialize)PicBox_Y_Minus_Button).BeginInit();
			((System.ComponentModel.ISupportInitialize)PicBox_Y_Axis).BeginInit();
			((System.ComponentModel.ISupportInitialize)NumBox_MouseStopTime).BeginInit();
			((System.ComponentModel.ISupportInitialize)NumBox_MouseDeadZone).BeginInit();
			SuspendLayout();
			// 
			// Label_Line_1
			// 
			Label_Line_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			Label_Line_1.BorderStyle = BorderStyle.Fixed3D;
			Label_Line_1.Location = new System.Drawing.Point(12, 41);
			Label_Line_1.Name = "Label_Line_1";
			Label_Line_1.Padding = new Padding(0, 40, 0, 0);
			Label_Line_1.Size = new System.Drawing.Size(600, 2);
			Label_Line_1.TabIndex = 0;
			// 
			// Label_Line_2
			// 
			Label_Line_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			Label_Line_2.BorderStyle = BorderStyle.Fixed3D;
			Label_Line_2.Location = new System.Drawing.Point(12, 166);
			Label_Line_2.Name = "Label_Line_2";
			Label_Line_2.Size = new System.Drawing.Size(600, 2);
			Label_Line_2.TabIndex = 22;
			// 
			// Label_X_Plus_Button_1
			// 
			Label_X_Plus_Button_1.Location = new System.Drawing.Point(12, 53);
			Label_X_Plus_Button_1.Name = "Label_X_Plus_Button_1";
			Label_X_Plus_Button_1.Size = new System.Drawing.Size(70, 23);
			Label_X_Plus_Button_1.TabIndex = 1;
			Label_X_Plus_Button_1.Text = "Move X+";
			Label_X_Plus_Button_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label_X_Plus_Button_2
			// 
			Label_X_Plus_Button_2.Location = new System.Drawing.Point(76, 53);
			Label_X_Plus_Button_2.Name = "Label_X_Plus_Button_2";
			Label_X_Plus_Button_2.Size = new System.Drawing.Size(76, 23);
			Label_X_Plus_Button_2.TabIndex = 27;
			Label_X_Plus_Button_2.Text = "Push Button";
			Label_X_Plus_Button_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label_X_Minus_Button_1
			// 
			Label_X_Minus_Button_1.Location = new System.Drawing.Point(12, 93);
			Label_X_Minus_Button_1.Name = "Label_X_Minus_Button_1";
			Label_X_Minus_Button_1.Size = new System.Drawing.Size(70, 23);
			Label_X_Minus_Button_1.TabIndex = 2;
			Label_X_Minus_Button_1.Text = "Move X-";
			Label_X_Minus_Button_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label_X_Minus_Button_2
			// 
			Label_X_Minus_Button_2.Location = new System.Drawing.Point(76, 93);
			Label_X_Minus_Button_2.Name = "Label_X_Minus_Button_2";
			Label_X_Minus_Button_2.Size = new System.Drawing.Size(76, 23);
			Label_X_Minus_Button_2.TabIndex = 28;
			Label_X_Minus_Button_2.Text = "Push Button";
			Label_X_Minus_Button_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label_X_Axis_1
			// 
			Label_X_Axis_1.Location = new System.Drawing.Point(12, 133);
			Label_X_Axis_1.Name = "Label_X_Axis_1";
			Label_X_Axis_1.Size = new System.Drawing.Size(70, 23);
			Label_X_Axis_1.TabIndex = 3;
			Label_X_Axis_1.Text = "Move X";
			Label_X_Axis_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label_X_Axis_2
			// 
			Label_X_Axis_2.Location = new System.Drawing.Point(76, 133);
			Label_X_Axis_2.Name = "Label_X_Axis_2";
			Label_X_Axis_2.Size = new System.Drawing.Size(76, 23);
			Label_X_Axis_2.TabIndex = 29;
			Label_X_Axis_2.Text = "Axis Value";
			Label_X_Axis_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label_Y_Plus_Button_1
			// 
			Label_Y_Plus_Button_1.Location = new System.Drawing.Point(330, 53);
			Label_Y_Plus_Button_1.Name = "Label_Y_Plus_Button_1";
			Label_Y_Plus_Button_1.Size = new System.Drawing.Size(70, 23);
			Label_Y_Plus_Button_1.TabIndex = 13;
			Label_Y_Plus_Button_1.Text = "Move Y+";
			Label_Y_Plus_Button_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label_Y_Plus_Button_2
			// 
			Label_Y_Plus_Button_2.Location = new System.Drawing.Point(394, 53);
			Label_Y_Plus_Button_2.Name = "Label_Y_Plus_Button_2";
			Label_Y_Plus_Button_2.Size = new System.Drawing.Size(76, 23);
			Label_Y_Plus_Button_2.TabIndex = 30;
			Label_Y_Plus_Button_2.Text = "Push Button";
			Label_Y_Plus_Button_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label_Y_Minus_Button_1
			// 
			Label_Y_Minus_Button_1.Location = new System.Drawing.Point(330, 93);
			Label_Y_Minus_Button_1.Name = "Label_Y_Minus_Button_1";
			Label_Y_Minus_Button_1.Size = new System.Drawing.Size(70, 23);
			Label_Y_Minus_Button_1.TabIndex = 14;
			Label_Y_Minus_Button_1.Text = "Move Y-";
			Label_Y_Minus_Button_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label_Y_Minus_Button_2
			// 
			Label_Y_Minus_Button_2.Location = new System.Drawing.Point(394, 93);
			Label_Y_Minus_Button_2.Name = "Label_Y_Minus_Button_2";
			Label_Y_Minus_Button_2.Size = new System.Drawing.Size(76, 23);
			Label_Y_Minus_Button_2.TabIndex = 31;
			Label_Y_Minus_Button_2.Text = "Push Button";
			Label_Y_Minus_Button_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label_Y_Axis_1
			// 
			Label_Y_Axis_1.Location = new System.Drawing.Point(330, 133);
			Label_Y_Axis_1.Name = "Label_Y_Axis_1";
			Label_Y_Axis_1.Size = new System.Drawing.Size(70, 23);
			Label_Y_Axis_1.TabIndex = 15;
			Label_Y_Axis_1.Text = "Move Y";
			Label_Y_Axis_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label_Y_Axis_2
			// 
			Label_Y_Axis_2.Location = new System.Drawing.Point(394, 133);
			Label_Y_Axis_2.Name = "Label_Y_Axis_2";
			Label_Y_Axis_2.Size = new System.Drawing.Size(76, 23);
			Label_Y_Axis_2.TabIndex = 32;
			Label_Y_Axis_2.Text = "Axis Value";
			Label_Y_Axis_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label_MoveStopTime
			// 
			Label_MoveStopTime.Location = new System.Drawing.Point(12, 178);
			Label_MoveStopTime.Name = "Label_MoveStopTime";
			Label_MoveStopTime.Size = new System.Drawing.Size(190, 23);
			Label_MoveStopTime.TabIndex = 4;
			Label_MoveStopTime.Text = "Move Stop Decision Time";
			Label_MoveStopTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label_MoveDeadZone
			// 
			Label_MoveDeadZone.Location = new System.Drawing.Point(12, 218);
			Label_MoveDeadZone.Name = "Label_MoveDeadZone";
			Label_MoveDeadZone.Size = new System.Drawing.Size(190, 23);
			Label_MoveDeadZone.TabIndex = 25;
			Label_MoveDeadZone.Text = "Move Dead Zone";
			Label_MoveDeadZone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Label_App_Version
			// 
			Label_App_Version.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			Label_App_Version.Location = new System.Drawing.Point(520, 9);
			Label_App_Version.Name = "Label_App_Version";
			Label_App_Version.Size = new System.Drawing.Size(91, 23);
			Label_App_Version.TabIndex = 24;
			Label_App_Version.Text = "ver 1.0.0.0";
			Label_App_Version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// CheckBox_Enable
			// 
			CheckBox_Enable.AutoSize = true;
			CheckBox_Enable.Checked = true;
			CheckBox_Enable.CheckState = CheckState.Checked;
			CheckBox_Enable.Location = new System.Drawing.Point(12, 12);
			CheckBox_Enable.Name = "CheckBox_Enable";
			CheckBox_Enable.Size = new System.Drawing.Size(61, 19);
			CheckBox_Enable.TabIndex = 5;
			CheckBox_Enable.Text = "Enable";
			CheckBox_Enable.UseVisualStyleBackColor = true;
			// 
			// ComboBox_X_Plus_Button
			// 
			ComboBox_X_Plus_Button.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_X_Plus_Button.FormattingEnabled = true;
			ComboBox_X_Plus_Button.Location = new System.Drawing.Point(152, 53);
			ComboBox_X_Plus_Button.Name = "ComboBox_X_Plus_Button";
			ComboBox_X_Plus_Button.Size = new System.Drawing.Size(110, 23);
			ComboBox_X_Plus_Button.TabIndex = 6;
			ComboBox_X_Plus_Button.SelectedIndexChanged += ComboBox_Input_SelectedIndexChanged;
			// 
			// ComboBox_X_Minus_Button
			// 
			ComboBox_X_Minus_Button.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_X_Minus_Button.FormattingEnabled = true;
			ComboBox_X_Minus_Button.Location = new System.Drawing.Point(152, 93);
			ComboBox_X_Minus_Button.Name = "ComboBox_X_Minus_Button";
			ComboBox_X_Minus_Button.Size = new System.Drawing.Size(110, 23);
			ComboBox_X_Minus_Button.TabIndex = 7;
			ComboBox_X_Minus_Button.SelectedIndexChanged += ComboBox_Input_SelectedIndexChanged;
			// 
			// ComboBox_X_Axis
			// 
			ComboBox_X_Axis.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_X_Axis.FormattingEnabled = true;
			ComboBox_X_Axis.Location = new System.Drawing.Point(152, 133);
			ComboBox_X_Axis.Name = "ComboBox_X_Axis";
			ComboBox_X_Axis.Size = new System.Drawing.Size(110, 23);
			ComboBox_X_Axis.TabIndex = 8;
			ComboBox_X_Axis.SelectedIndexChanged += ComboBox_Input_SelectedIndexChanged;
			// 
			// PicBox_X_Plus_Button
			// 
			PicBox_X_Plus_Button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			PicBox_X_Plus_Button.Location = new System.Drawing.Point(270, 53);
			PicBox_X_Plus_Button.Name = "PicBox_X_Plus_Button";
			PicBox_X_Plus_Button.Size = new System.Drawing.Size(23, 23);
			PicBox_X_Plus_Button.TabIndex = 9;
			PicBox_X_Plus_Button.TabStop = false;
			// 
			// PicBox_X_Minus_Button
			// 
			PicBox_X_Minus_Button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			PicBox_X_Minus_Button.Location = new System.Drawing.Point(270, 93);
			PicBox_X_Minus_Button.Name = "PicBox_X_Minus_Button";
			PicBox_X_Minus_Button.Size = new System.Drawing.Size(23, 23);
			PicBox_X_Minus_Button.TabIndex = 10;
			PicBox_X_Minus_Button.TabStop = false;
			// 
			// PicBox_X_Axis
			// 
			PicBox_X_Axis.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			PicBox_X_Axis.Location = new System.Drawing.Point(270, 133);
			PicBox_X_Axis.Name = "PicBox_X_Axis";
			PicBox_X_Axis.Size = new System.Drawing.Size(23, 23);
			PicBox_X_Axis.TabIndex = 11;
			PicBox_X_Axis.TabStop = false;
			// 
			// ComboBox_Y_Plus_Button
			// 
			ComboBox_Y_Plus_Button.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_Y_Plus_Button.FormattingEnabled = true;
			ComboBox_Y_Plus_Button.Location = new System.Drawing.Point(470, 53);
			ComboBox_Y_Plus_Button.Name = "ComboBox_Y_Plus_Button";
			ComboBox_Y_Plus_Button.Size = new System.Drawing.Size(110, 23);
			ComboBox_Y_Plus_Button.TabIndex = 16;
			ComboBox_Y_Plus_Button.SelectedIndexChanged += ComboBox_Input_SelectedIndexChanged;
			// 
			// ComboBox_Y_Minus_Button
			// 
			ComboBox_Y_Minus_Button.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_Y_Minus_Button.FormattingEnabled = true;
			ComboBox_Y_Minus_Button.Location = new System.Drawing.Point(470, 93);
			ComboBox_Y_Minus_Button.Name = "ComboBox_Y_Minus_Button";
			ComboBox_Y_Minus_Button.Size = new System.Drawing.Size(110, 23);
			ComboBox_Y_Minus_Button.TabIndex = 17;
			ComboBox_Y_Minus_Button.SelectedIndexChanged += ComboBox_Input_SelectedIndexChanged;
			// 
			// ComboBox_Y_Axis
			// 
			ComboBox_Y_Axis.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox_Y_Axis.FormattingEnabled = true;
			ComboBox_Y_Axis.Location = new System.Drawing.Point(470, 133);
			ComboBox_Y_Axis.Name = "ComboBox_Y_Axis";
			ComboBox_Y_Axis.Size = new System.Drawing.Size(110, 23);
			ComboBox_Y_Axis.TabIndex = 18;
			ComboBox_Y_Axis.SelectedIndexChanged += ComboBox_Input_SelectedIndexChanged;
			// 
			// PicBox_Y_Plus_Button
			// 
			PicBox_Y_Plus_Button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			PicBox_Y_Plus_Button.Location = new System.Drawing.Point(588, 53);
			PicBox_Y_Plus_Button.Name = "PicBox_Y_Plus_Button";
			PicBox_Y_Plus_Button.Size = new System.Drawing.Size(23, 23);
			PicBox_Y_Plus_Button.TabIndex = 19;
			PicBox_Y_Plus_Button.TabStop = false;
			// 
			// PicBox_Y_Minus_Button
			// 
			PicBox_Y_Minus_Button.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			PicBox_Y_Minus_Button.Location = new System.Drawing.Point(588, 93);
			PicBox_Y_Minus_Button.Name = "PicBox_Y_Minus_Button";
			PicBox_Y_Minus_Button.Size = new System.Drawing.Size(23, 23);
			PicBox_Y_Minus_Button.TabIndex = 20;
			PicBox_Y_Minus_Button.TabStop = false;
			// 
			// PicBox_Y_Axis
			// 
			PicBox_Y_Axis.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			PicBox_Y_Axis.Location = new System.Drawing.Point(588, 133);
			PicBox_Y_Axis.Name = "PicBox_Y_Axis";
			PicBox_Y_Axis.Size = new System.Drawing.Size(23, 23);
			PicBox_Y_Axis.TabIndex = 21;
			PicBox_Y_Axis.TabStop = false;
			// 
			// NumBox_MouseStopTime
			// 
			NumBox_MouseStopTime.DecimalPlaces = 2;
			NumBox_MouseStopTime.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
			NumBox_MouseStopTime.Location = new System.Drawing.Point(202, 178);
			NumBox_MouseStopTime.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
			NumBox_MouseStopTime.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
			NumBox_MouseStopTime.Name = "NumBox_MouseStopTime";
			NumBox_MouseStopTime.Size = new System.Drawing.Size(60, 23);
			NumBox_MouseStopTime.TabIndex = 12;
			NumBox_MouseStopTime.Value = new decimal(new int[] { 1, 0, 0, 65536 });
			// 
			// NumBox_MouseDeadZone
			// 
			NumBox_MouseDeadZone.Location = new System.Drawing.Point(202, 218);
			NumBox_MouseDeadZone.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			NumBox_MouseDeadZone.Name = "NumBox_MouseDeadZone";
			NumBox_MouseDeadZone.Size = new System.Drawing.Size(60, 23);
			NumBox_MouseDeadZone.TabIndex = 26;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(624, 261);
			Controls.Add(Label_Line_1);
			Controls.Add(Label_Line_2);
			Controls.Add(Label_X_Plus_Button_1);
			Controls.Add(Label_X_Plus_Button_2);
			Controls.Add(Label_X_Minus_Button_1);
			Controls.Add(Label_X_Minus_Button_2);
			Controls.Add(Label_X_Axis_1);
			Controls.Add(Label_X_Axis_2);
			Controls.Add(Label_Y_Plus_Button_1);
			Controls.Add(Label_Y_Plus_Button_2);
			Controls.Add(Label_Y_Minus_Button_1);
			Controls.Add(Label_Y_Minus_Button_2);
			Controls.Add(Label_Y_Axis_1);
			Controls.Add(Label_Y_Axis_2);
			Controls.Add(Label_MoveStopTime);
			Controls.Add(Label_MoveDeadZone);
			Controls.Add(Label_App_Version);
			Controls.Add(CheckBox_Enable);
			Controls.Add(ComboBox_X_Plus_Button);
			Controls.Add(ComboBox_X_Minus_Button);
			Controls.Add(ComboBox_X_Axis);
			Controls.Add(PicBox_X_Plus_Button);
			Controls.Add(PicBox_X_Minus_Button);
			Controls.Add(PicBox_X_Axis);
			Controls.Add(ComboBox_Y_Plus_Button);
			Controls.Add(ComboBox_Y_Minus_Button);
			Controls.Add(ComboBox_Y_Axis);
			Controls.Add(PicBox_Y_Plus_Button);
			Controls.Add(PicBox_Y_Minus_Button);
			Controls.Add(PicBox_Y_Axis);
			Controls.Add(NumBox_MouseStopTime);
			Controls.Add(NumBox_MouseDeadZone);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = Properties.Resource.Icon;
			Name = "MainForm";
			Text = "Form1";
			((System.ComponentModel.ISupportInitialize)PicBox_X_Plus_Button).EndInit();
			((System.ComponentModel.ISupportInitialize)PicBox_X_Minus_Button).EndInit();
			((System.ComponentModel.ISupportInitialize)PicBox_X_Axis).EndInit();
			((System.ComponentModel.ISupportInitialize)PicBox_Y_Plus_Button).EndInit();
			((System.ComponentModel.ISupportInitialize)PicBox_Y_Minus_Button).EndInit();
			((System.ComponentModel.ISupportInitialize)PicBox_Y_Axis).EndInit();
			((System.ComponentModel.ISupportInitialize)NumBox_MouseStopTime).EndInit();
			((System.ComponentModel.ISupportInitialize)NumBox_MouseDeadZone).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label Label_App_Version;
		private CheckBox CheckBox_Enable;		
		private ComboBox ComboBox_X_Plus_Button;
		private ComboBox ComboBox_X_Minus_Button;
		private ComboBox ComboBox_X_Axis;
		private PictureBox PicBox_X_Plus_Button;
		private PictureBox PicBox_X_Minus_Button;
		private PictureBox PicBox_X_Axis;
		private ComboBox ComboBox_Y_Plus_Button;
		private ComboBox ComboBox_Y_Minus_Button;
		private ComboBox ComboBox_Y_Axis;
		private PictureBox PicBox_Y_Plus_Button;
		private PictureBox PicBox_Y_Minus_Button;
		private PictureBox PicBox_Y_Axis;
		private NumericUpDown NumBox_MouseStopTime;
		private NumericUpDown NumBox_MouseDeadZone;
	}
}
