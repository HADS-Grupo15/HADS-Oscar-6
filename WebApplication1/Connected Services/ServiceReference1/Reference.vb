﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace ServiceReference1
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.IService1")>  _
    Public Interface IService1
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService1/GetDedicacionMedia", ReplyAction:="http://tempuri.org/IService1/GetDedicacionMediaResponse")>  _
        Function GetDedicacionMedia(ByVal value As Integer) As Double
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService1/GetDedicacionMedia", ReplyAction:="http://tempuri.org/IService1/GetDedicacionMediaResponse")>  _
        Function GetDedicacionMediaAsync(ByVal value As Integer) As System.Threading.Tasks.Task(Of Double)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IService1Channel
        Inherits ServiceReference1.IService1, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class Service1Client
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.IService1)
        Implements ServiceReference1.IService1
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function GetDedicacionMedia(ByVal value As Integer) As Double Implements ServiceReference1.IService1.GetDedicacionMedia
            Return MyBase.Channel.GetDedicacionMedia(value)
        End Function
        
        Public Function GetDedicacionMediaAsync(ByVal value As Integer) As System.Threading.Tasks.Task(Of Double) Implements ServiceReference1.IService1.GetDedicacionMediaAsync
            Return MyBase.Channel.GetDedicacionMediaAsync(value)
        End Function
    End Class
End Namespace
