<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDogs
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDogs))
        Dim Dog_TagLabel As System.Windows.Forms.Label
        Dim Dog_BreedLabel As System.Windows.Forms.Label
        Dim ColorLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Me.picDog = New System.Windows.Forms.PictureBox()
        Me.lblAdoptMe = New System.Windows.Forms.Label()
        Me.DogsDataSet = New Week4Day2Dogs.DogsDataSet()
        Me.AvailableDogsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AvailableDogsTableAdapter = New Week4Day2Dogs.DogsDataSetTableAdapters.AvailableDogsTableAdapter()
        Me.TableAdapterManager = New Week4Day2Dogs.DogsDataSetTableAdapters.TableAdapterManager()
        Me.AvailableDogsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.AvailableDogsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Dog_TagTextBox = New System.Windows.Forms.TextBox()
        Me.Dog_BreedComboBox = New System.Windows.Forms.ComboBox()
        Me.ColorTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Dog_TagLabel = New System.Windows.Forms.Label()
        Dog_BreedLabel = New System.Windows.Forms.Label()
        ColorLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DogsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvailableDogsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AvailableDogsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AvailableDogsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'picDog
        '
        Me.picDog.Image = Global.Week4Day2Dogs.My.Resources.Resources.Dog
        Me.picDog.Location = New System.Drawing.Point(0, 28)
        Me.picDog.Name = "picDog"
        Me.picDog.Size = New System.Drawing.Size(203, 270)
        Me.picDog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDog.TabIndex = 0
        Me.picDog.TabStop = False
        '
        'lblAdoptMe
        '
        Me.lblAdoptMe.AutoSize = True
        Me.lblAdoptMe.Font = New System.Drawing.Font("Brush Script MT", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdoptMe.Location = New System.Drawing.Point(322, 56)
        Me.lblAdoptMe.Name = "lblAdoptMe"
        Me.lblAdoptMe.Size = New System.Drawing.Size(162, 29)
        Me.lblAdoptMe.TabIndex = 1
        Me.lblAdoptMe.Text = "Adopt Me Today!"
        '
        'DogsDataSet
        '
        Me.DogsDataSet.DataSetName = "DogsDataSet"
        Me.DogsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AvailableDogsBindingSource
        '
        Me.AvailableDogsBindingSource.DataMember = "AvailableDogs"
        Me.AvailableDogsBindingSource.DataSource = Me.DogsDataSet
        '
        'AvailableDogsTableAdapter
        '
        Me.AvailableDogsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AvailableDogsTableAdapter = Me.AvailableDogsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Week4Day2Dogs.DogsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AvailableDogsBindingNavigator
        '
        Me.AvailableDogsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AvailableDogsBindingNavigator.BindingSource = Me.AvailableDogsBindingSource
        Me.AvailableDogsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AvailableDogsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AvailableDogsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AvailableDogsBindingNavigatorSaveItem})
        Me.AvailableDogsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AvailableDogsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AvailableDogsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AvailableDogsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AvailableDogsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AvailableDogsBindingNavigator.Name = "AvailableDogsBindingNavigator"
        Me.AvailableDogsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AvailableDogsBindingNavigator.Size = New System.Drawing.Size(621, 25)
        Me.AvailableDogsBindingNavigator.TabIndex = 2
        Me.AvailableDogsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'AvailableDogsBindingNavigatorSaveItem
        '
        Me.AvailableDogsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AvailableDogsBindingNavigatorSaveItem.Image = CType(resources.GetObject("AvailableDogsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AvailableDogsBindingNavigatorSaveItem.Name = "AvailableDogsBindingNavigatorSaveItem"
        Me.AvailableDogsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.AvailableDogsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Dog_TagLabel
        '
        Dog_TagLabel.AutoSize = True
        Dog_TagLabel.Location = New System.Drawing.Point(215, 136)
        Dog_TagLabel.Name = "Dog_TagLabel"
        Dog_TagLabel.Size = New System.Drawing.Size(52, 13)
        Dog_TagLabel.TabIndex = 3
        Dog_TagLabel.Text = "Dog Tag:"
        '
        'Dog_TagTextBox
        '
        Me.Dog_TagTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvailableDogsBindingSource, "Dog Tag", True))
        Me.Dog_TagTextBox.Location = New System.Drawing.Point(273, 133)
        Me.Dog_TagTextBox.Name = "Dog_TagTextBox"
        Me.Dog_TagTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Dog_TagTextBox.TabIndex = 4
        '
        'Dog_BreedLabel
        '
        Dog_BreedLabel.AutoSize = True
        Dog_BreedLabel.Location = New System.Drawing.Point(396, 135)
        Dog_BreedLabel.Name = "Dog_BreedLabel"
        Dog_BreedLabel.Size = New System.Drawing.Size(61, 13)
        Dog_BreedLabel.TabIndex = 5
        Dog_BreedLabel.Text = "Dog Breed:"
        '
        'Dog_BreedComboBox
        '
        Me.Dog_BreedComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvailableDogsBindingSource, "Dog Breed", True))
        Me.Dog_BreedComboBox.DataSource = Me.AvailableDogsBindingSource
        Me.Dog_BreedComboBox.DisplayMember = "Dog Breed"
        Me.Dog_BreedComboBox.FormattingEnabled = True
        Me.Dog_BreedComboBox.Location = New System.Drawing.Point(463, 132)
        Me.Dog_BreedComboBox.Name = "Dog_BreedComboBox"
        Me.Dog_BreedComboBox.Size = New System.Drawing.Size(121, 21)
        Me.Dog_BreedComboBox.TabIndex = 6
        '
        'ColorLabel
        '
        ColorLabel.AutoSize = True
        ColorLabel.Location = New System.Drawing.Point(233, 184)
        ColorLabel.Name = "ColorLabel"
        ColorLabel.Size = New System.Drawing.Size(34, 13)
        ColorLabel.TabIndex = 7
        ColorLabel.Text = "Color:"
        '
        'ColorTextBox
        '
        Me.ColorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvailableDogsBindingSource, "Color", True))
        Me.ColorTextBox.Location = New System.Drawing.Point(273, 181)
        Me.ColorTextBox.Name = "ColorTextBox"
        Me.ColorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ColorTextBox.TabIndex = 8
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Location = New System.Drawing.Point(428, 181)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(29, 13)
        AgeLabel.TabIndex = 9
        AgeLabel.Text = "Age:"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvailableDogsBindingSource, "Age", True))
        Me.AgeTextBox.Location = New System.Drawing.Point(463, 178)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AgeTextBox.TabIndex = 10
        '
        'frmDogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 303)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(ColorLabel)
        Me.Controls.Add(Me.ColorTextBox)
        Me.Controls.Add(Dog_BreedLabel)
        Me.Controls.Add(Me.Dog_BreedComboBox)
        Me.Controls.Add(Dog_TagLabel)
        Me.Controls.Add(Me.Dog_TagTextBox)
        Me.Controls.Add(Me.AvailableDogsBindingNavigator)
        Me.Controls.Add(Me.lblAdoptMe)
        Me.Controls.Add(Me.picDog)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AvailableDogsBindingSource, "Dog Breed", True))
        Me.Name = "frmDogs"
        Me.Text = "Humane Society Available Dogs for Adoption"
        CType(Me.picDog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DogsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvailableDogsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AvailableDogsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AvailableDogsBindingNavigator.ResumeLayout(False)
        Me.AvailableDogsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picDog As System.Windows.Forms.PictureBox
    Friend WithEvents lblAdoptMe As System.Windows.Forms.Label
    Friend WithEvents DogsDataSet As Week4Day2Dogs.DogsDataSet
    Friend WithEvents AvailableDogsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AvailableDogsTableAdapter As Week4Day2Dogs.DogsDataSetTableAdapters.AvailableDogsTableAdapter
    Friend WithEvents TableAdapterManager As Week4Day2Dogs.DogsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AvailableDogsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AvailableDogsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Dog_TagTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Dog_BreedComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ColorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox

End Class
