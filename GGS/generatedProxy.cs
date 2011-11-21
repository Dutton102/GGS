[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(Namespace="http://GGShost", ConfigurationName="ICalculator")]
public interface ICalculator
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://GGShost/ICalculator/Add", ReplyAction="http://GGShost/ICalculator/AddResponse")]
    double Add(double n1, double n2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://GGShost/ICalculator/Subtract", ReplyAction="http://GGShost/ICalculator/SubtractResponse")]
    double Subtract(double n1, double n2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://GGShost/ICalculator/Multiply", ReplyAction="http://GGShost/ICalculator/MultiplyResponse")]
    double Multiply(double n1, double n2);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://GGShost/ICalculator/Divide", ReplyAction="http://GGShost/ICalculator/DivideResponse")]
    double Divide(double n1, double n2);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public interface ICalculatorChannel : ICalculator, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
public partial class CalculatorClient : System.ServiceModel.ClientBase<ICalculator>, ICalculator
{
    
    public CalculatorClient()
    {
    }
    
    public CalculatorClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public double Add(double n1, double n2)
    {
        return base.Channel.Add(n1, n2);
    }
    
    public double Subtract(double n1, double n2)
    {
        return base.Channel.Subtract(n1, n2);
    }
    
    public double Multiply(double n1, double n2)
    {
        return base.Channel.Multiply(n1, n2);
    }
    
    public double Divide(double n1, double n2)
    {
        return base.Channel.Divide(n1, n2);
    }
}
