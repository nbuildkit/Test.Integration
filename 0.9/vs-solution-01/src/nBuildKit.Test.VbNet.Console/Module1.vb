Imports NBuildKit.Test.VBNet.Library


Module Module1

    Sub Main()
        Dim helloWorld As HelloWorld = New HelloWorld
        System.Console.WriteLine(helloWorld.SayHello())
    End Sub

End Module
