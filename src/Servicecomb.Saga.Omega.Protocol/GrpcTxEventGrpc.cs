/*
 * Licensed to the Apache Software Foundation (ASF) under one or more
 * contributor license agreements.  See the NOTICE file distributed with
 * this work for additional information regarding copyright ownership.
 * The ASF licenses this file to You under the Apache License, Version 2.0
 * (the "License"); you may not use this file except in compliance with
 * the License.  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protos/GrpcTxEvent.proto
// </auto-generated>
// Original file comments:
//
// Licensed to the Apache Software Foundation (ASF) under one or more
// contributor license agreements.  See the NOTICE file distributed with
// this work for additional information regarding copyright ownership.
// The ASF licenses this file to You under the Apache License, Version 2.0
// (the "License"); you may not use this file except in compliance with
// the License.  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Servicecomb.Saga.Omega.Protocol {
  public static partial class TxEventService
  {
    static readonly string __ServiceName = "TxEventService";

    static readonly grpc::Marshaller<global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig> __Marshaller_GrpcServiceConfig = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Servicecomb.Saga.Omega.Protocol.GrpcCompensateCommand> __Marshaller_GrpcCompensateCommand = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Servicecomb.Saga.Omega.Protocol.GrpcCompensateCommand.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Servicecomb.Saga.Omega.Protocol.GrpcTxEvent> __Marshaller_GrpcTxEvent = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Servicecomb.Saga.Omega.Protocol.GrpcTxEvent.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Servicecomb.Saga.Omega.Protocol.GrpcAck> __Marshaller_GrpcAck = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Servicecomb.Saga.Omega.Protocol.GrpcAck.Parser.ParseFrom);

    static readonly grpc::Method<global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig, global::Servicecomb.Saga.Omega.Protocol.GrpcCompensateCommand> __Method_OnConnected = new grpc::Method<global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig, global::Servicecomb.Saga.Omega.Protocol.GrpcCompensateCommand>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "OnConnected",
        __Marshaller_GrpcServiceConfig,
        __Marshaller_GrpcCompensateCommand);

    static readonly grpc::Method<global::Servicecomb.Saga.Omega.Protocol.GrpcTxEvent, global::Servicecomb.Saga.Omega.Protocol.GrpcAck> __Method_OnTxEvent = new grpc::Method<global::Servicecomb.Saga.Omega.Protocol.GrpcTxEvent, global::Servicecomb.Saga.Omega.Protocol.GrpcAck>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OnTxEvent",
        __Marshaller_GrpcTxEvent,
        __Marshaller_GrpcAck);

    static readonly grpc::Method<global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig, global::Servicecomb.Saga.Omega.Protocol.GrpcAck> __Method_OnDisconnected = new grpc::Method<global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig, global::Servicecomb.Saga.Omega.Protocol.GrpcAck>(
        grpc::MethodType.Unary,
        __ServiceName,
        "OnDisconnected",
        __Marshaller_GrpcServiceConfig,
        __Marshaller_GrpcAck);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Servicecomb.Saga.Omega.Protocol.GrpcTxEventReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of TxEventService</summary>
    public abstract partial class TxEventServiceBase
    {
      public virtual global::System.Threading.Tasks.Task OnConnected(global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig request, grpc::IServerStreamWriter<global::Servicecomb.Saga.Omega.Protocol.GrpcCompensateCommand> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Servicecomb.Saga.Omega.Protocol.GrpcAck> OnTxEvent(global::Servicecomb.Saga.Omega.Protocol.GrpcTxEvent request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Servicecomb.Saga.Omega.Protocol.GrpcAck> OnDisconnected(global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for TxEventService</summary>
    public partial class TxEventServiceClient : grpc::ClientBase<TxEventServiceClient>
    {
      /// <summary>Creates a new client for TxEventService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public TxEventServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for TxEventService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public TxEventServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected TxEventServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected TxEventServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncServerStreamingCall<global::Servicecomb.Saga.Omega.Protocol.GrpcCompensateCommand> OnConnected(global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnConnected(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncServerStreamingCall<global::Servicecomb.Saga.Omega.Protocol.GrpcCompensateCommand> OnConnected(global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_OnConnected, null, options, request);
      }
      public virtual global::Servicecomb.Saga.Omega.Protocol.GrpcAck OnTxEvent(global::Servicecomb.Saga.Omega.Protocol.GrpcTxEvent request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnTxEvent(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Servicecomb.Saga.Omega.Protocol.GrpcAck OnTxEvent(global::Servicecomb.Saga.Omega.Protocol.GrpcTxEvent request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OnTxEvent, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Servicecomb.Saga.Omega.Protocol.GrpcAck> OnTxEventAsync(global::Servicecomb.Saga.Omega.Protocol.GrpcTxEvent request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnTxEventAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Servicecomb.Saga.Omega.Protocol.GrpcAck> OnTxEventAsync(global::Servicecomb.Saga.Omega.Protocol.GrpcTxEvent request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OnTxEvent, null, options, request);
      }
      public virtual global::Servicecomb.Saga.Omega.Protocol.GrpcAck OnDisconnected(global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnDisconnected(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Servicecomb.Saga.Omega.Protocol.GrpcAck OnDisconnected(global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_OnDisconnected, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Servicecomb.Saga.Omega.Protocol.GrpcAck> OnDisconnectedAsync(global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return OnDisconnectedAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Servicecomb.Saga.Omega.Protocol.GrpcAck> OnDisconnectedAsync(global::Servicecomb.Saga.Omega.Protocol.GrpcServiceConfig request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_OnDisconnected, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override TxEventServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new TxEventServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(TxEventServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_OnConnected, serviceImpl.OnConnected)
          .AddMethod(__Method_OnTxEvent, serviceImpl.OnTxEvent)
          .AddMethod(__Method_OnDisconnected, serviceImpl.OnDisconnected).Build();
    }

  }
}
#endregion
