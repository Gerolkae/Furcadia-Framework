<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.clientGroup = New System.Windows.Forms.GroupBox()
        Me.ServerList = New System.Windows.Forms.ListBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BTN_Config = New System.Windows.Forms.Button()
        Me.BTN_Go = New System.Windows.Forms.Button()
        Me.GrpAction = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BTN_TurnR = New System.Windows.Forms.Button()
        Me._ne = New System.Windows.Forms.PictureBox()
        Me._nw = New System.Windows.Forms.PictureBox()
        Me.use_ = New System.Windows.Forms.Button()
        Me.get_ = New System.Windows.Forms.Button()
        Me.se_ = New System.Windows.Forms.PictureBox()
        Me.sw_ = New System.Windows.Forms.PictureBox()
        Me.DreamList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.toServer = New System.Windows.Forms.TextBox()
        Me.sendToServer = New System.Windows.Forms.Button()
        Me.clientGroup.SuspendLayout()
        Me.GrpAction.SuspendLayout()
        CType(Me._ne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._nw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.se_, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sw_, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'clientGroup
        '
        Me.clientGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.clientGroup.Controls.Add(Me.ServerList)
        Me.clientGroup.Location = New System.Drawing.Point(12, 12)
        Me.clientGroup.Name = "clientGroup"
        Me.clientGroup.Size = New System.Drawing.Size(229, 166)
        Me.clientGroup.TabIndex = 0
        Me.clientGroup.TabStop = False
        Me.clientGroup.Text = "From Client"
        '
        'ServerList
        '
        Me.ServerList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ServerList.FormattingEnabled = True
        Me.ServerList.Location = New System.Drawing.Point(18, 19)
        Me.ServerList.Name = "ServerList"
        Me.ServerList.Size = New System.Drawing.Size(193, 134)
        Me.ServerList.TabIndex = 0
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'BTN_Config
        '
        Me.BTN_Config.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Config.Location = New System.Drawing.Point(30, 320)
        Me.BTN_Config.Name = "BTN_Config"
        Me.BTN_Config.Size = New System.Drawing.Size(80, 30)
        Me.BTN_Config.TabIndex = 11
        Me.BTN_Config.Text = "Config"
        Me.BTN_Config.UseVisualStyleBackColor = True
        '
        'BTN_Go
        '
        Me.BTN_Go.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN_Go.Location = New System.Drawing.Point(125, 320)
        Me.BTN_Go.Name = "BTN_Go"
        Me.BTN_Go.Size = New System.Drawing.Size(98, 30)
        Me.BTN_Go.TabIndex = 10
        Me.BTN_Go.Text = "Go!"
        Me.BTN_Go.UseVisualStyleBackColor = True
        '
        'GrpAction
        '
        Me.GrpAction.Controls.Add(Me.Button4)
        Me.GrpAction.Controls.Add(Me.Button1)
        Me.GrpAction.Controls.Add(Me.Button3)
        Me.GrpAction.Controls.Add(Me.Button2)
        Me.GrpAction.Controls.Add(Me.BTN_TurnR)
        Me.GrpAction.Controls.Add(Me._ne)
        Me.GrpAction.Controls.Add(Me._nw)
        Me.GrpAction.Controls.Add(Me.use_)
        Me.GrpAction.Controls.Add(Me.get_)
        Me.GrpAction.Controls.Add(Me.se_)
        Me.GrpAction.Controls.Add(Me.sw_)
        Me.GrpAction.Location = New System.Drawing.Point(253, 201)
        Me.GrpAction.Name = "GrpAction"
        Me.GrpAction.Size = New System.Drawing.Size(164, 162)
        Me.GrpAction.TabIndex = 14
        Me.GrpAction.TabStop = False
        Me.GrpAction.Text = "Actios"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(116, 69)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(41, 23)
        Me.Button4.TabIndex = 46
        Me.Button4.Text = "Stand"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(116, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Lie"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(116, 43)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(41, 23)
        Me.Button3.TabIndex = 44
        Me.Button3.Text = "Sit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(3, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 23)
        Me.Button2.TabIndex = 43
        Me.Button2.Text = "<="
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BTN_TurnR
        '
        Me.BTN_TurnR.Location = New System.Drawing.Point(3, 43)
        Me.BTN_TurnR.Name = "BTN_TurnR"
        Me.BTN_TurnR.Size = New System.Drawing.Size(30, 23)
        Me.BTN_TurnR.TabIndex = 42
        Me.BTN_TurnR.Text = "=>"
        Me.BTN_TurnR.UseVisualStyleBackColor = True
        '
        '_ne
        '
        Me._ne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._ne.Cursor = System.Windows.Forms.Cursors.Hand
        Me._ne.Image = CType(resources.GetObject("_ne.Image"), System.Drawing.Image)
        Me._ne.Location = New System.Drawing.Point(74, 19)
        Me._ne.Name = "_ne"
        Me._ne.Size = New System.Drawing.Size(36, 36)
        Me._ne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._ne.TabIndex = 41
        Me._ne.TabStop = False
        Me._ne.WaitOnLoad = True
        '
        '_nw
        '
        Me._nw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me._nw.Cursor = System.Windows.Forms.Cursors.Hand
        Me._nw.Image = CType(resources.GetObject("_nw.Image"), System.Drawing.Image)
        Me._nw.Location = New System.Drawing.Point(38, 19)
        Me._nw.Name = "_nw"
        Me._nw.Size = New System.Drawing.Size(36, 36)
        Me._nw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me._nw.TabIndex = 40
        Me._nw.TabStop = False
        Me._nw.WaitOnLoad = True
        '
        'use_
        '
        Me.use_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.use_.FlatAppearance.BorderSize = 0
        Me.use_.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.use_.Location = New System.Drawing.Point(74, 95)
        Me.use_.Name = "use_"
        Me.use_.Size = New System.Drawing.Size(35, 23)
        Me.use_.TabIndex = 38
        Me.use_.Text = "Use"
        Me.use_.UseVisualStyleBackColor = True
        '
        'get_
        '
        Me.get_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.get_.FlatAppearance.BorderSize = 0
        Me.get_.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.get_.Location = New System.Drawing.Point(38, 95)
        Me.get_.Name = "get_"
        Me.get_.Size = New System.Drawing.Size(32, 23)
        Me.get_.TabIndex = 37
        Me.get_.Text = "Get"
        Me.get_.UseVisualStyleBackColor = True
        '
        'se_
        '
        Me.se_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.se_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.se_.Image = CType(resources.GetObject("se_.Image"), System.Drawing.Image)
        Me.se_.Location = New System.Drawing.Point(74, 56)
        Me.se_.Name = "se_"
        Me.se_.Size = New System.Drawing.Size(36, 36)
        Me.se_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.se_.TabIndex = 36
        Me.se_.TabStop = False
        Me.se_.WaitOnLoad = True
        '
        'sw_
        '
        Me.sw_.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.sw_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sw_.Image = CType(resources.GetObject("sw_.Image"), System.Drawing.Image)
        Me.sw_.Location = New System.Drawing.Point(38, 56)
        Me.sw_.Name = "sw_"
        Me.sw_.Size = New System.Drawing.Size(36, 36)
        Me.sw_.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.sw_.TabIndex = 35
        Me.sw_.TabStop = False
        Me.sw_.WaitOnLoad = True
        '
        'DreamList
        '
        Me.DreamList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DreamList.FormattingEnabled = True
        Me.DreamList.Location = New System.Drawing.Point(6, 19)
        Me.DreamList.Name = "DreamList"
        Me.DreamList.Size = New System.Drawing.Size(158, 134)
        Me.DreamList.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Furres in Dream:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 163)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(68, 20)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.Text = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.DreamList)
        Me.GroupBox1.Location = New System.Drawing.Point(247, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 194)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dream List"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.toServer)
        Me.GroupBox3.Controls.Add(Me.sendToServer)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(229, 130)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Chat"
        '
        'toServer
        '
        Me.toServer.AcceptsReturn = True
        Me.toServer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toServer.Location = New System.Drawing.Point(18, 19)
        Me.toServer.Multiline = True
        Me.toServer.Name = "toServer"
        Me.toServer.Size = New System.Drawing.Size(193, 79)
        Me.toServer.TabIndex = 3
        '
        'sendToServer
        '
        Me.sendToServer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sendToServer.Location = New System.Drawing.Point(176, 104)
        Me.sendToServer.Name = "sendToServer"
        Me.sendToServer.Size = New System.Drawing.Size(35, 20)
        Me.sendToServer.TabIndex = 4
        Me.sendToServer.Text = "->"
        Me.sendToServer.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 362)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GrpAction)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.clientGroup)
        Me.Controls.Add(Me.BTN_Config)
        Me.Controls.Add(Me.BTN_Go)
        Me.MinimumSize = New System.Drawing.Size(445, 400)
        Me.Name = "Main"
        Me.Text = "Simple Proxy"
        Me.clientGroup.ResumeLayout(False)
        Me.GrpAction.ResumeLayout(False)
        Me.GrpAction.PerformLayout()
        CType(Me._ne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._nw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.se_, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sw_, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents clientGroup As System.Windows.Forms.GroupBox
    Friend WithEvents ServerList As System.Windows.Forms.ListBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents BTN_Config As System.Windows.Forms.Button
    Friend WithEvents BTN_Go As System.Windows.Forms.Button
    Friend WithEvents GrpAction As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BTN_TurnR As System.Windows.Forms.Button
    Friend WithEvents _ne As System.Windows.Forms.PictureBox
    Friend WithEvents _nw As System.Windows.Forms.PictureBox
    Friend WithEvents use_ As System.Windows.Forms.Button
    Friend WithEvents get_ As System.Windows.Forms.Button
    Friend WithEvents se_ As System.Windows.Forms.PictureBox
    Friend WithEvents sw_ As System.Windows.Forms.PictureBox
    Friend WithEvents DreamList As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents toServer As System.Windows.Forms.TextBox
    Friend WithEvents sendToServer As System.Windows.Forms.Button

End Class
