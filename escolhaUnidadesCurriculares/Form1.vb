Public Class Form1

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Dim indexCurso As Integer = listBoxUCs.SelectedIndex
        Dim cursosSelecionados As String = vbCrLf

        If (indexCurso = -1) Then
            MsgBox("Por favor, selecione pelo menos uma UC.", MsgBoxStyle.Critical, "Atenção:")
        Else
            For counter As Integer = 0 To listBoxUCs.Items.Count - 1
                If listBoxUCs.GetItemChecked(counter) Then
                    cursosSelecionados = cursosSelecionados + listBoxUCs.Items(counter) + vbCrLf
                End If
            Next
            MsgBox("Cursos selecionados:" & cursosSelecionados, MsgBoxStyle.Information, "RESULTADO")
        End If
    End Sub
End Class

