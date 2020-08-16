Imports Microsoft.Win32

Public Class Common
    Enum LoginMode
        DOWNLOAD_MODE
        US_UNBLOCK
        US_UNBLOCK_WAIT
    End Enum
    Public Class LanguageMapping
        Dim shortStringValue, fullTextValue As String

        Public Property shortString() As String
            Get
                Return shortStringValue
            End Get
            Set(value As String)
                shortStringValue = value
            End Set
        End Property

        Public Property fullText() As String
            Get
                Return fullTextValue
            End Get
            Set(value As String)
                fullTextValue = value
            End Set
        End Property

        Public Sub New(shortString As String, fullText As String)
            Me.shortString = shortString
            Me.fullText = fullText
        End Sub

        Public Overrides Function ToString() As String
            Return fullTextValue
        End Function

    End Class

    Public Shared supportedHardSubs = {
        New LanguageMapping("None", "[ null ]"),
        New LanguageMapping("arME", "العربية (Arabic)"),
        New LanguageMapping("deDE", "Deutsch"),
        New LanguageMapping("enUS", "English"),
        New LanguageMapping("esES", "Español (España)"),
        New LanguageMapping("esLA", "Español (LA)"),
        New LanguageMapping("frFR", "Français (France)"),
        New LanguageMapping("ptBR", "Português (Brasil)"),
        New LanguageMapping("itIT", "Italiano (Italian)"),
        New LanguageMapping("ruRU", "Русский (Russian)")
    }

    Private Shared registryKey As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\CRDownloader")
    Public Shared Function GetRegistryValue(registryValueName As String)
        Dim currentValues = registryKey.GetValueNames()
        If currentValues.Contains(registryValueName) Then
            Dim dataType = registryKey.GetValueKind(registryValueName)
            Dim dataValue = registryKey.GetValue(registryValueName)
            If dataType = RegistryValueKind.DWord Then
                Return CType(dataValue, Integer)
            ElseIf dataType = RegistryValueKind.QWord Then
                Return CType(dataValue, Long)
            ElseIf (dataType = RegistryValueKind.String) Or (dataType = RegistryValueKind.ExpandString) Then
                Return CType(dataValue, String)
            ElseIf dataType = RegistryValueKind.MultiString Then
                Return CType(dataValue, String())
            Else
                Return dataValue
            End If
        Else
            Return Nothing
        End If
    End Function

    Public Shared Sub SetRegistryValue(registryValueName, value, registryValueType)
        registryKey.SetValue(registryValueName, value, registryValueType)
    End Sub


    Public Shared Function CheckIfExistsInRegistry(registryValuename As String)
        Dim currentValues = registryKey.GetValueNames()
        If currentValues.Contains(registryValuename) Then
            Return True
        End If
        Return False
    End Function

    Public Shared Sub MigrateStringsToDWords()
        Dim registryUpdated = CBool(GetRegistryValue("MigratedToDword"))
        If registryUpdated = False Then
            Dim valueNames = {"Resu", "MergeMP4", "LoginDialog", "SaveLog", "SubFolder", "SL_DL", "NoUse", "QueueMode"}
            For Each valueName As String In valueNames
                If CheckIfExistsInRegistry(valueName) Then
                    Dim value = Integer.Parse(GetRegistryValue(valueName))
                    registryKey.DeleteValue(valueName)
                    registryKey.SetValue(valueName, value, RegistryValueKind.DWord)
                End If
            Next
            registryKey.SetValue("MigratedToDword", 1, RegistryValueKind.DWord)
        End If
    End Sub

End Class
