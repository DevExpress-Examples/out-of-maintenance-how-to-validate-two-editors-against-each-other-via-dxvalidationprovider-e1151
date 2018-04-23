Imports Microsoft.VisualBasic
Imports System
Namespace ValidateTwoControls
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim compareAgainstControlValidationRule1 As New DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule()
			Dim compareAgainstControlValidationRule2 As New DevExpress.XtraEditors.DXErrorProvider.CompareAgainstControlValidationRule()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.dxValidationProvider1 = New DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(Me.components)
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' textEdit2
			' 
			Me.textEdit2.EditValue = New System.DateTime(2009, 1, 27, 8, 0, 0, 0)
			Me.textEdit2.Location = New System.Drawing.Point(81, 39)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Properties.Mask.EditMask = "t"
			Me.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
			Me.textEdit2.Properties.Mask.UseMaskAsDisplayFormat = True
			Me.textEdit2.Size = New System.Drawing.Size(100, 20)
			Me.textEdit2.TabIndex = 1
			compareAgainstControlValidationRule1.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.GreaterOrEqual
			compareAgainstControlValidationRule1.Control = Me.textEdit1
			compareAgainstControlValidationRule1.ErrorText = "End time must be greater than start time"
			Me.dxValidationProvider1.SetValidationRule(Me.textEdit2, compareAgainstControlValidationRule1)
			' 
			' textEdit1
			' 
			Me.textEdit1.EditValue = New System.DateTime(2009, 1, 27, 6, 0, 0, 0)
			Me.textEdit1.Location = New System.Drawing.Point(81, 12)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Properties.Mask.EditMask = "t"
			Me.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime
			Me.textEdit1.Properties.Mask.UseMaskAsDisplayFormat = True
			Me.textEdit1.Size = New System.Drawing.Size(100, 20)
			Me.textEdit1.TabIndex = 0
			compareAgainstControlValidationRule2.CompareControlOperator = DevExpress.XtraEditors.DXErrorProvider.CompareControlOperator.LessOrEqual
			compareAgainstControlValidationRule2.Control = Me.textEdit2
			compareAgainstControlValidationRule2.ErrorText = "Start time must be less than end time"
			Me.dxValidationProvider1.SetValidationRule(Me.textEdit1, compareAgainstControlValidationRule2)
			' 
			' dxValidationProvider1
			' 
			Me.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 15)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(51, 13)
			Me.labelControl1.TabIndex = 3
			Me.labelControl1.Text = "Start time:"
			' 
			' labelControl2
			' 
			Me.labelControl2.Location = New System.Drawing.Point(12, 42)
			Me.labelControl2.Name = "labelControl2"
			Me.labelControl2.Size = New System.Drawing.Size(45, 13)
			Me.labelControl2.TabIndex = 4
			Me.labelControl2.Text = "End time:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(200, 125)
			Me.Controls.Add(Me.labelControl2)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.textEdit2)
			Me.Controls.Add(Me.textEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dxValidationProvider1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private dxValidationProvider1 As DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private labelControl2 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

