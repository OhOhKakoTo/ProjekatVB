<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pregledajStudente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pregledajStudente))
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StudentiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BazaProjekatDataSet = New projekatFakultet.bazaProjekatDataSet()
        Me.StudentiBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentiTableAdapter = New projekatFakultet.bazaProjekatDataSetTableAdapters.studentiTableAdapter()
        Me.ImeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaticniBrojDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImeRoditeljaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndeksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BazaProjekatDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentiBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(707, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 15
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(245, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(343, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ImeDataGridViewTextBoxColumn, Me.MaticniBrojDataGridViewTextBoxColumn, Me.ImeRoditeljaDataGridViewTextBoxColumn, Me.AdresaDataGridViewTextBoxColumn, Me.IndeksDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentiBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(105, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(547, 150)
        Me.DataGridView1.TabIndex = 17
        '
        'StudentiBindingSource
        '
        Me.StudentiBindingSource.DataMember = "studenti"
        '
        'BazaProjekatDataSet
        '
        Me.BazaProjekatDataSet.DataSetName = "bazaProjekatDataSet"
        Me.BazaProjekatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentiBindingSource1
        '
        Me.StudentiBindingSource1.DataMember = "studenti"
        Me.StudentiBindingSource1.DataSource = Me.BazaProjekatDataSet
        '
        'StudentiTableAdapter
        '
        Me.StudentiTableAdapter.ClearBeforeFill = True
        '
        'ImeDataGridViewTextBoxColumn
        '
        Me.ImeDataGridViewTextBoxColumn.DataPropertyName = "ime"
        Me.ImeDataGridViewTextBoxColumn.HeaderText = "ime"
        Me.ImeDataGridViewTextBoxColumn.Name = "ImeDataGridViewTextBoxColumn"
        '
        'MaticniBrojDataGridViewTextBoxColumn
        '
        Me.MaticniBrojDataGridViewTextBoxColumn.DataPropertyName = "maticniBroj"
        Me.MaticniBrojDataGridViewTextBoxColumn.HeaderText = "maticniBroj"
        Me.MaticniBrojDataGridViewTextBoxColumn.Name = "MaticniBrojDataGridViewTextBoxColumn"
        '
        'ImeRoditeljaDataGridViewTextBoxColumn
        '
        Me.ImeRoditeljaDataGridViewTextBoxColumn.DataPropertyName = "imeRoditelja"
        Me.ImeRoditeljaDataGridViewTextBoxColumn.HeaderText = "imeRoditelja"
        Me.ImeRoditeljaDataGridViewTextBoxColumn.Name = "ImeRoditeljaDataGridViewTextBoxColumn"
        '
        'AdresaDataGridViewTextBoxColumn
        '
        Me.AdresaDataGridViewTextBoxColumn.DataPropertyName = "adresa"
        Me.AdresaDataGridViewTextBoxColumn.HeaderText = "adresa"
        Me.AdresaDataGridViewTextBoxColumn.Name = "AdresaDataGridViewTextBoxColumn"
        '
        'IndeksDataGridViewTextBoxColumn
        '
        Me.IndeksDataGridViewTextBoxColumn.DataPropertyName = "indeks"
        Me.IndeksDataGridViewTextBoxColumn.HeaderText = "indeks"
        Me.IndeksDataGridViewTextBoxColumn.Name = "IndeksDataGridViewTextBoxColumn"
        '
        'pregledajStudente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(810, 529)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "pregledajStudente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pregledajStudente"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BazaProjekatDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentiBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StudentiBindingSource As BindingSource
    Friend WithEvents ImePrezimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JmbgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImeJednogRoditeljaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdresaStanovanjaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BrojIndeksaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BazaProjekatDataSet As bazaProjekatDataSet
    Friend WithEvents StudentiBindingSource1 As BindingSource
    Friend WithEvents StudentiTableAdapter As bazaProjekatDataSetTableAdapters.studentiTableAdapter
    Friend WithEvents ImeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaticniBrojDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImeRoditeljaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdresaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndeksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
