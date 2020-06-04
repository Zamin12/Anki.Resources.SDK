// Copyright � 2020 Randall Maas. All rights reserved.
// See LICENSE file in the project root for full license information.  
// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Anki.CozmoAnim
{

using global::System;
using global::FlatBuffers;

public struct ProceduralFace : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static ProceduralFace GetRootAsProceduralFace(ByteBuffer _bb) { return GetRootAsProceduralFace(_bb, new ProceduralFace()); }
  public static ProceduralFace GetRootAsProceduralFace(ByteBuffer _bb, ProceduralFace obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public ProceduralFace __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint TriggerTimeMs { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public float FaceAngle { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float FaceCenterX { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float FaceCenterY { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)0.0f; } }
  public float FaceScaleX { get { int o = __p.__offset(12); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)1.0f; } }
  public float FaceScaleY { get { int o = __p.__offset(14); return o != 0 ? __p.bb.GetFloat(o + __p.bb_pos) : (float)1.0f; } }
  public float LeftEye(int j) { int o = __p.__offset(16); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int LeftEyeLength { get { int o = __p.__offset(16); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetLeftEyeBytes() { return __p.__vector_as_span(16); }
#else
  public ArraySegment<byte>? GetLeftEyeBytes() { return __p.__vector_as_arraysegment(16); }
#endif
  public float[] GetLeftEyeArray() { return __p.__vector_as_array<float>(16); }
  public float RightEye(int j) { int o = __p.__offset(18); return o != 0 ? __p.bb.GetFloat(__p.__vector(o) + j * 4) : (float)0; }
  public int RightEyeLength { get { int o = __p.__offset(18); return o != 0 ? __p.__vector_len(o) : 0; } }
#if ENABLE_SPAN_T
  public Span<byte> GetRightEyeBytes() { return __p.__vector_as_span(18); }
#else
  public ArraySegment<byte>? GetRightEyeBytes() { return __p.__vector_as_arraysegment(18); }
#endif
  public float[] GetRightEyeArray() { return __p.__vector_as_array<float>(18); }

  public static Offset<ProceduralFace> CreateProceduralFace(FlatBufferBuilder builder,
      uint triggerTime_ms = 0,
      float faceAngle = 0.0f,
      float faceCenterX = 0.0f,
      float faceCenterY = 0.0f,
      float faceScaleX = 1.0f,
      float faceScaleY = 1.0f,
      VectorOffset leftEyeOffset = default(VectorOffset),
      VectorOffset rightEyeOffset = default(VectorOffset)) {
    builder.StartObject(8);
    ProceduralFace.AddRightEye(builder, rightEyeOffset);
    ProceduralFace.AddLeftEye(builder, leftEyeOffset);
    ProceduralFace.AddFaceScaleY(builder, faceScaleY);
    ProceduralFace.AddFaceScaleX(builder, faceScaleX);
    ProceduralFace.AddFaceCenterY(builder, faceCenterY);
    ProceduralFace.AddFaceCenterX(builder, faceCenterX);
    ProceduralFace.AddFaceAngle(builder, faceAngle);
    ProceduralFace.AddTriggerTimeMs(builder, triggerTime_ms);
    return ProceduralFace.EndProceduralFace(builder);
  }

  public static void StartProceduralFace(FlatBufferBuilder builder) { builder.StartObject(8); }
  public static void AddTriggerTimeMs(FlatBufferBuilder builder, uint triggerTimeMs) { builder.AddUint(0, triggerTimeMs, 0); }
  public static void AddFaceAngle(FlatBufferBuilder builder, float faceAngle) { builder.AddFloat(1, faceAngle, 0.0f); }
  public static void AddFaceCenterX(FlatBufferBuilder builder, float faceCenterX) { builder.AddFloat(2, faceCenterX, 0.0f); }
  public static void AddFaceCenterY(FlatBufferBuilder builder, float faceCenterY) { builder.AddFloat(3, faceCenterY, 0.0f); }
  public static void AddFaceScaleX(FlatBufferBuilder builder, float faceScaleX) { builder.AddFloat(4, faceScaleX, 1.0f); }
  public static void AddFaceScaleY(FlatBufferBuilder builder, float faceScaleY) { builder.AddFloat(5, faceScaleY, 1.0f); }
  public static void AddLeftEye(FlatBufferBuilder builder, VectorOffset leftEyeOffset) { builder.AddOffset(6, leftEyeOffset.Value, 0); }
  public static VectorOffset CreateLeftEyeVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateLeftEyeVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartLeftEyeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddRightEye(FlatBufferBuilder builder, VectorOffset rightEyeOffset) { builder.AddOffset(7, rightEyeOffset.Value, 0); }
  public static VectorOffset CreateRightEyeVector(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddFloat(data[i]); return builder.EndVector(); }
  public static VectorOffset CreateRightEyeVectorBlock(FlatBufferBuilder builder, float[] data) { builder.StartVector(4, data.Length, 4); builder.Add(data); return builder.EndVector(); }
  public static void StartRightEyeVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<ProceduralFace> EndProceduralFace(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<ProceduralFace>(o);
  }
};


}
