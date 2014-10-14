Public Class Form1
    Dim intCompScore As Integer = 0

    Dim intHumanScore As Integer = 0

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim intCompThrow As Integer
        Dim intRock As Integer = 1
        Dim intPaper As Integer = 2
        Dim intScissors As Integer = 3
        Me.lblHumanScore.Text = intHumanScore
        Me.lblCompScore.Text = intCompScore
        Randomize()
        intCompThrow = Int((3 - 1 + 1) * Rnd() + 1)

        Select Case Me.rdoRock.Checked
            Case True
                Select Case intCompThrow
                    Case 1
                        Me.lblResult.Text = "You chose rock, computer chose rock: You Tied"
                    Case 2
                        Me.lblResult.Text = "You chose rock, computer chose paper: You Lose"
                        Me.intCompScore += 1
                    Case 3
                        Me.lblResult.Text = "You chose rock, computer chose scissors: You Win"
                        Me.intHumanScore += 1

                End Select
        End Select

        Select Case Me.rdoPaper.Checked
            Case True
                Select Case intCompThrow

                    Case 1
                        Me.lblResult.Text = "You chose paper, computer chose rock: You Win"
                        Me.intHumanScore += 1
                    Case 2
                        Me.lblResult.Text = "You chose paper, computer chose paper: You Tie"
                    Case 3
                        Me.lblResult.Text = "You chose paper, computer chose scissors: You Lose"
                        Me.intCompScore += 1
                End Select
        End Select

        Select Case Me.rdoScissors.Checked
            Case True
                Select Case intCompThrow

                    Case 1
                        Me.lblResult.Text = "You chose scissors, computer chose rock: You Lose"
                        Me.intCompScore += 1

                    Case 2
                        Me.lblResult.Text = "You chose scissors, computer chose paper: You Win"
                        Me.intHumanScore += 1

                    Case 3
                        Me.lblResult.Text = "You chose scissors, commputer chose scissors: You Tie"

                End Select
        End Select

    End Sub

    
    
    Private Sub btnPlayIf_Click(sender As Object, e As EventArgs) Handles btnPlayIf.Click
        Dim intCompThrow As Integer
        Dim intRock As Integer = 1
        Dim intPaper As Integer = 2
        Dim intScissors As Integer = 3
        Me.lblHumanScore.Text = intHumanScore
        Me.lblCompScore.Text = intCompScore
        Randomize()
        intCompThrow = Int((3 - 1 + 1) * Rnd() + 1)

        If intCompThrow = 1 And Me.rdoRock.Checked = True Then
            Me.lblResult.Text = "You chose rock, commputer chose rock: You Tie"
        ElseIf intCompThrow = 1 And Me.rdoPaper.Checked = True Then
            Me.lblResult.Text = "You chose paper, commputer chose rock: You Win"
            Me.intHumanScore += 1
        ElseIf intCompThrow = 1 And Me.rdoScissors.Checked = True Then
            Me.lblResult.Text = "You chose scissors, commputer chose rock: You Lose"
            Me.intCompScore += 1
        ElseIf intCompThrow = 2 And Me.rdoRock.Checked = True Then
            Me.lblResult.Text = "You chose rock, commputer chose paper: You Lose"
            Me.intCompScore += 1
        ElseIf intCompThrow = 2 And Me.rdoPaper.Checked = True Then
            Me.lblResult.Text = "You chose paper, commputer chose paper: You Tie"
        ElseIf intCompThrow = 2 And Me.rdoScissors.Checked = True Then
            Me.lblResult.Text = "You chose scissors, commputer chose paper: You Win"
            Me.intHumanScore += 1
        ElseIf intCompThrow = 3 And Me.rdoRock.Checked = True Then
            Me.lblResult.Text = "You chose rock, commputer chose scissors: You Win"
            Me.intHumanScore += 1
        ElseIf intCompThrow = 3 And Me.rdoPaper.Checked = True Then
            Me.lblResult.Text = "You chose paper, commputer chose scissors: You Lose"
            Me.intCompScore += 1
        ElseIf intCompThrow = 3 And Me.rdoScissors.Checked = True Then
            Me.lblResult.Text = "You chose scissors, commputer chose scissors: You Tie"

        End If
    End Sub
End Class
