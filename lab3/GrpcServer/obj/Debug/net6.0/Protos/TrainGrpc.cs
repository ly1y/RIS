// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/train.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class Train
  {
    static readonly string __ServiceName = "train.Train";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.Request> __Marshaller_train_Request = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.Request.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.ResponseCountePeople> __Marshaller_train_ResponseCountePeople = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.ResponseCountePeople.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::GrpcServer.ResponseCountBag> __Marshaller_train_ResponseCountBag = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.ResponseCountBag.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServer.Request, global::GrpcServer.ResponseCountePeople> __Method_GetCountPeople = new grpc::Method<global::GrpcServer.Request, global::GrpcServer.ResponseCountePeople>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCountPeople",
        __Marshaller_train_Request,
        __Marshaller_train_ResponseCountePeople);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::GrpcServer.Request, global::GrpcServer.ResponseCountBag> __Method_GetCountBag = new grpc::Method<global::GrpcServer.Request, global::GrpcServer.ResponseCountBag>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCountBag",
        __Marshaller_train_Request,
        __Marshaller_train_ResponseCountBag);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.TrainReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Train</summary>
    [grpc::BindServiceMethod(typeof(Train), "BindService")]
    public abstract partial class TrainBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.ResponseCountePeople> GetCountPeople(global::GrpcServer.Request request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.ResponseCountBag> GetCountBag(global::GrpcServer.Request request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(TrainBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCountPeople, serviceImpl.GetCountPeople)
          .AddMethod(__Method_GetCountBag, serviceImpl.GetCountBag).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, TrainBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCountPeople, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.Request, global::GrpcServer.ResponseCountePeople>(serviceImpl.GetCountPeople));
      serviceBinder.AddMethod(__Method_GetCountBag, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.Request, global::GrpcServer.ResponseCountBag>(serviceImpl.GetCountBag));
    }

  }
}
#endregion
