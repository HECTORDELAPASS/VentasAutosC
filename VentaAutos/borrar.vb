Public Class borrar
    Private Sub borrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim respuesta As MsgBoxResult
		respuesta = MsgBox("Vas a borrar la venta seleccionada " & vbCrLf & "¿Deseas continuar?", MsgBoxStyle.YesNo)

		If respuesta = MsgBoxResult.Yes Then
			MsgBox("Venta borrada. No podras acceder mas a esta venta")
		ElseIf respuesta = MsgBoxResult.No Then
			MsgBox("Seleccionaste No")
		End If
	End Sub
End Class