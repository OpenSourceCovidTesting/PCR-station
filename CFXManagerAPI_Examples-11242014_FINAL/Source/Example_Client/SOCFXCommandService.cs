﻿//***********************************************************************************************************
//Copyright ©2014 Bio-Rad Laboratories, Inc. All rights reserved.
//
// This file is part of the CFX Manager API Examples kit. 
//
// It contains the service model code required to implement a C# client of the CFX Manager API service.
//
// It was generated using the Microsoft ServiceModel Metadata Utility by executing the command:
//
//     "svcutil.exe http://localhost:8003/BioRad.PCR.CommandManager/SOCFXCommandService?wsdl"
//
// from the Visual Studio command shell while CFX Manager is executing.
//
// NOTE: This file was generated in .Net 4.0 and is compatible .Net 4.0 and higher. Note, however, that
// versions of this file generated in .Net 4.5 are NOT backwards compatible and will not work in .Net 4.0. 
//***********************************************************************************************************

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


/// <summary/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace = "http://BioRad.PCR.CommandManager", ConfigurationName = "ISOCFXCommandService", CallbackContract = typeof(ISOCFXCommandServiceCallback))]
public interface ISOCFXCommandService
{
    /// <summary/>
    [System.ServiceModel.OperationContractAttribute(Action = "http://BioRad.PCR.CommandManager/ISOCFXCommandService/SubscribeToServiceIsClosing" +
        "", ReplyAction = "http://BioRad.PCR.CommandManager/ISOCFXCommandService/SubscribeToServiceIsClosing" +
        "Response")]
    void SubscribeToServiceIsClosing();

    /// <summary/>
    [System.ServiceModel.OperationContractAttribute(Action = "http://BioRad.PCR.CommandManager/ISOCFXCommandService/XmlCommand", ReplyAction = "http://BioRad.PCR.CommandManager/ISOCFXCommandService/XmlCommandResponse")]
    string XmlCommand(string xml);
}
/// <summary/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ISOCFXCommandServiceCallback
{
    /// <summary/>
    [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://BioRad.PCR.CommandManager/ISOCFXCommandService/OnServiceIsClosing")]
    void OnServiceIsClosing();
}

/// <summary/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ISOCFXCommandServiceChannel : ISOCFXCommandService, System.ServiceModel.IClientChannel
{
}
/// <summary/>
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class SOCFXCommandServiceClient : System.ServiceModel.DuplexClientBase<ISOCFXCommandService>, ISOCFXCommandService
{
    /// <summary/>
    public SOCFXCommandServiceClient(System.ServiceModel.InstanceContext callbackInstance) :
        base(callbackInstance)
    {
    }
    /// <summary/>
    public SOCFXCommandServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) :
        base(callbackInstance, endpointConfigurationName)
    {
    }
    /// <summary/>
    public SOCFXCommandServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) :
        base(callbackInstance, endpointConfigurationName, remoteAddress)
    {
    }
    /// <summary/>
    public SOCFXCommandServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
        base(callbackInstance, endpointConfigurationName, remoteAddress)
    {
    }
    /// <summary/>
    public SOCFXCommandServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
        base(callbackInstance, binding, remoteAddress)
    {
    }
    /// <summary/>
    public void SubscribeToServiceIsClosing()
    {
        base.Channel.SubscribeToServiceIsClosing();
    }
    /// <summary/>
    public string XmlCommand(string xml)
    {
        return base.Channel.XmlCommand(xml);
    }
}
