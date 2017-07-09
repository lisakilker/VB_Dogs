Public Class frmDogs

    Private Sub AvailableDogsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AvailableDogsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AvailableDogsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DogsDataSet)

    End Sub

    Private Sub frmDogs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DogsDataSet.AvailableDogs' table. You can move, or remove it, as needed.
        Me.AvailableDogsTableAdapter.Fill(Me.DogsDataSet.AvailableDogs)

    End Sub
End Class
