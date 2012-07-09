// Type: System.ServiceModel.Web.WebInvokeAttribute
// Assembly: System.ServiceModel.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.ServiceModel.Web.dll

using System;
using System.ServiceModel;
using System.ServiceModel.Administration;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace System.ServiceModel.Web
{
    /// <summary>
    /// Indicates a service operation is logically an invoke operation and that it can be called by the  REST programming model.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class WebInvokeAttribute : Attribute, IOperationContractAttributeProvider, IOperationBehavior, IWmiInstanceProvider
    {
        /// <summary>
        /// Implements the <see cref="M:System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription,System.ServiceModel.Channels.BindingParameterCollection)"/> method.
        /// </summary>
        /// <param name="operationDescription">The operation description.</param><param name="bindingParameters">A collection of binding parameters.</param>
        void IOperationBehavior.AddBindingParameters(OperationDescription operationDescription, BindingParameterCollection bindingParameters);

        /// <summary>
        /// Implements the <see cref="M:System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription,System.ServiceModel.Dispatcher.ClientOperation)"/> method.
        /// </summary>
        /// <param name="operationDescription">The operation description.</param><param name="clientOperation">The client operation.</param>
        void IOperationBehavior.ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation);

        /// <summary>
        /// Implements the <see cref="M:System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription,System.ServiceModel.Dispatcher.DispatchOperation)"/> method.
        /// </summary>
        /// <param name="operationDescription">The operation description.</param><param name="dispatchOperation">The operation to dispatch to.</param>
        void IOperationBehavior.ApplyDispatchBehavior(OperationDescription operationDescription, DispatchOperation dispatchOperation);

        /// <summary>
        /// Implements the <see cref="M:System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription)"/> method.
        /// </summary>
        /// <param name="operationDescription">The operation description.</param>
        void IOperationBehavior.Validate(OperationDescription operationDescription);

        void IWmiInstanceProvider.FillInstance(IWmiInstance wmiInstance);
        string IWmiInstanceProvider.GetInstanceType();
        OperationContractAttribute IOperationContractAttributeProvider.GetOperationContractAttribute();

        /// <summary>
        /// Gets and sets the body style of the messages that are sent to and from the service operation.
        /// </summary>
        /// 
        /// <returns>
        /// One of the <see cref="T:System.ServiceModel.Web.WebMessageBodyStyle"/> enumeration values.
        /// </returns>
        public WebMessageBodyStyle BodyStyle { get; set; }

        /// <summary>
        /// Gets the <see cref="P:System.ServiceModel.Web.WebInvokeAttribute.IsBodyStyleSetExplicitly"/> property.
        /// </summary>
        /// 
        /// <returns>
        /// A value that specifies whether the <see cref="P:System.ServiceModel.Web.WebGetAttribute.BodyStyle"/> property was set explicitly.
        /// </returns>
        public bool IsBodyStyleSetExplicitly { get; }

        /// <summary>
        /// Gets the <see cref="P:System.ServiceModel.Web.WebInvokeAttribute.IsRequestFormatSetExplicitly"/> property.
        /// </summary>
        /// 
        /// <returns>
        /// A value that specifies whether the <see cref="P:System.ServiceModel.Web.WebGetAttribute.RequestFormat"/> property was set.
        /// </returns>
        public bool IsRequestFormatSetExplicitly { get; }

        /// <summary>
        /// Gets the <see cref="P:System.ServiceModel.Web.WebInvokeAttribute.IsResponseFormatSetExplicitly"/> property.
        /// </summary>
        /// 
        /// <returns>
        /// A value that specifies whether the <see cref="P:System.ServiceModel.Web.WebGetAttribute.ResponseFormat"/> property was set.
        /// </returns>
        public bool IsResponseFormatSetExplicitly { get; }

        /// <summary>
        /// Gets and sets the protocol (for example HTTP) method the service operation responds to.
        /// </summary>
        /// 
        /// <returns>
        /// The protocol method associated with the operation.
        /// </returns>
        public string Method { get; set; }

        /// <summary>
        /// Gets and sets the <see cref="P:System.ServiceModel.Web.WebInvokeAttribute.RequestFormat"/> property.
        /// </summary>
        /// 
        /// <returns>
        /// One of the <see cref="T:System.ServiceModel.Web.WebMessageFormat"/> enumeration values.
        /// </returns>
        public WebMessageFormat RequestFormat { get; set; }

        /// <summary>
        /// Gets and sets the <see cref="P:System.ServiceModel.Web.WebInvokeAttribute.ResponseFormat"/> property.
        /// </summary>
        /// 
        /// <returns>
        /// One of the <see cref="T:System.ServiceModel.Web.WebMessageFormat"/> enumeration values.
        /// </returns>
        public WebMessageFormat ResponseFormat { get; set; }

        /// <summary>
        /// The Uniform Resource Identifier (URI) template for the service operation.
        /// </summary>
        /// 
        /// <returns>
        /// The URI template for the service operation.
        /// </returns>
        public string UriTemplate { get; set; }
    }
}
