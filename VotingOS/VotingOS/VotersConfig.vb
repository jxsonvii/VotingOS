﻿Public Class VotersConfig
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        'This is the saving module that allows a save to take place
        Try
            Me.Validate()
            Me.UsersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)
            MsgBox("Update Successful")
        Catch ex As Exception
            MsgBox("Update Failed. Please try again later or conbtact your administrator.")
        End Try


    End Sub

    Private Sub VotersConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.DatabaseDataSet.users)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class