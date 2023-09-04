<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFindCustomer
    Inherits System.Windows.Forms.Form

    Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim InternalSerialLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindCustomer))
        Me.txtSearchFor = New System.Windows.Forms.TextBox()
        Me.lblInternalSerial = New System.Windows.Forms.Label()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.txtSoldRetail = New System.Windows.Forms.TextBox()
        Me.txtOSType = New System.Windows.Forms.TextBox()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.lblFormFactor = New System.Windows.Forms.Label()
        Me.lblSerial = New System.Windows.Forms.Label()
        Me.tmrFlash = New System.Windows.Forms.Timer(Me.components)
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.lstResults = New System.Windows.Forms.ListView()
        InternalSerialLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'InternalSerialLabel
        '
        InternalSerialLabel.AutoSize = True
        InternalSerialLabel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InternalSerialLabel.Location = New System.Drawing.Point(3, 3)
        InternalSerialLabel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        InternalSerialLabel.Name = "InternalSerialLabel"
        InternalSerialLabel.Size = New System.Drawing.Size(111, 22)
        InternalSerialLabel.TabIndex = 105
        InternalSerialLabel.Text = "Search for:"
        '
        'txtSearchFor
        '
        Me.txtSearchFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearchFor.Location = New System.Drawing.Point(7, 30)
        Me.txtSearchFor.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtSearchFor.Name = "txtSearchFor"
        Me.txtSearchFor.Size = New System.Drawing.Size(618, 40)
        Me.txtSearchFor.TabIndex = 1
        '
        'lblInternalSerial
        '
        Me.lblInternalSerial.AutoSize = True
        Me.lblInternalSerial.Location = New System.Drawing.Point(162, 4)
        Me.lblInternalSerial.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblInternalSerial.Name = "lblInternalSerial"
        Me.lblInternalSerial.Size = New System.Drawing.Size(0, 22)
        Me.lblInternalSerial.TabIndex = 2
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(3, 73)
        Me.lblResults.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(84, 22)
        Me.lblResults.TabIndex = 113
        Me.lblResults.Text = "Results:"
        '
        'txtSoldRetail
        '
        Me.txtSoldRetail.Location = New System.Drawing.Point(506, 514)
        Me.txtSoldRetail.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtSoldRetail.Name = "txtSoldRetail"
        Me.txtSoldRetail.ReadOnly = True
        Me.txtSoldRetail.Size = New System.Drawing.Size(186, 29)
        Me.txtSoldRetail.TabIndex = 130
        Me.txtSoldRetail.TabStop = False
        Me.txtSoldRetail.Text = "SOLD_RETAIL"
        Me.txtSoldRetail.Visible = False
        '
        'txtOSType
        '
        Me.txtOSType.Location = New System.Drawing.Point(506, 408)
        Me.txtOSType.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.txtOSType.Name = "txtOSType"
        Me.txtOSType.ReadOnly = True
        Me.txtOSType.Size = New System.Drawing.Size(186, 29)
        Me.txtOSType.TabIndex = 133
        Me.txtOSType.TabStop = False
        Me.txtOSType.Visible = False
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.BackColor = System.Drawing.Color.Black
        Me.lblManufacturer.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblManufacturer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblManufacturer.Location = New System.Drawing.Point(205, 75)
        Me.lblManufacturer.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(0, 22)
        Me.lblManufacturer.TabIndex = 140
        '
        'lblFormFactor
        '
        Me.lblFormFactor.AutoSize = True
        Me.lblFormFactor.BackColor = System.Drawing.Color.Black
        Me.lblFormFactor.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormFactor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblFormFactor.Location = New System.Drawing.Point(205, 99)
        Me.lblFormFactor.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblFormFactor.Name = "lblFormFactor"
        Me.lblFormFactor.Size = New System.Drawing.Size(0, 22)
        Me.lblFormFactor.TabIndex = 141
        '
        'lblSerial
        '
        Me.lblSerial.AutoSize = True
        Me.lblSerial.BackColor = System.Drawing.Color.Black
        Me.lblSerial.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSerial.Location = New System.Drawing.Point(205, 171)
        Me.lblSerial.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSerial.Name = "lblSerial"
        Me.lblSerial.Size = New System.Drawing.Size(0, 22)
        Me.lblSerial.TabIndex = 142
        Me.lblSerial.Tag = ""
        '
        'tmrFlash
        '
        Me.tmrFlash.Interval = 1000
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.BackColor = System.Drawing.Color.Black
        Me.lblModel.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblModel.Location = New System.Drawing.Point(205, 123)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(0, 22)
        Me.lblModel.TabIndex = 144
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.BackColor = System.Drawing.Color.Black
        Me.lblSpeed.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeed.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSpeed.Location = New System.Drawing.Point(205, 147)
        Me.lblSpeed.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(0, 14)
        Me.lblSpeed.TabIndex = 146
        Me.lblSpeed.Tag = ""
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.HideSelection = False
        Me.lstResults.Location = New System.Drawing.Point(4, 101)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(621, 173)
        Me.lstResults.TabIndex = 147
        Me.lstResults.UseCompatibleStateImageBehavior = False
        '
        'frmFindCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 281)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.lblSpeed)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblSerial)
        Me.Controls.Add(Me.lblFormFactor)
        Me.Controls.Add(Me.lblManufacturer)
        Me.Controls.Add(Me.txtOSType)
        Me.Controls.Add(Me.txtSoldRetail)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(InternalSerialLabel)
        Me.Controls.Add(Me.lblInternalSerial)
        Me.Controls.Add(Me.txtSearchFor)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFindCustomer"
        Me.Text = "find Customer ID"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSearchFor As System.Windows.Forms.TextBox
    Friend WithEvents lblInternalSerial As System.Windows.Forms.Label
    Friend WithEvents lblResults As Label
    Friend WithEvents txtSoldRetail As TextBox
    Friend WithEvents txtOSType As TextBox
    Friend WithEvents lblManufacturer As Label
    Friend WithEvents lblFormFactor As Label
    Friend WithEvents lblSerial As Label
    Friend WithEvents tmrFlash As Timer
    Friend WithEvents lblModel As Label
    Friend WithEvents lblSpeed As Label
    Friend WithEvents lstResults As ListView
End Class
