// Copyright � 2020 Randall Maas. All rights reserved.
// See LICENSE file in the project root for full license information.  
// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Anki.CozmoAnim
{

using global::System;
using global::FlatBuffers;

public struct FaceAnimation : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static FaceAnimation GetRootAsFaceAnimation(ByteBuffer _bb) { return GetRootAsFaceAnimation(_bb, new FaceAnimation()); }
  public static FaceAnimation GetRootAsFaceAnimation(ByteBuffer _bb, FaceAnimation obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public FaceAnimation __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public uint TriggerTimeMs { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  public string AnimName { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAnimNameBytes() { return __p.__vector_as_span(6); }
#else
  public ArraySegment<byte>? GetAnimNameBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetAnimNameArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<FaceAnimation> CreateFaceAnimation(FlatBufferBuilder builder,
      uint triggerTime_ms = 0,
      StringOffset animNameOffset = default(StringOffset)) {
    builder.StartObject(2);
    FaceAnimation.AddAnimName(builder, animNameOffset);
    FaceAnimation.AddTriggerTimeMs(builder, triggerTime_ms);
    return FaceAnimation.EndFaceAnimation(builder);
  }

  public static void StartFaceAnimation(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddTriggerTimeMs(FlatBufferBuilder builder, uint triggerTimeMs) { builder.AddUint(0, triggerTimeMs, 0); }
  public static void AddAnimName(FlatBufferBuilder builder, StringOffset animNameOffset) { builder.AddOffset(1, animNameOffset.Value, 0); }
  public static Offset<FaceAnimation> EndFaceAnimation(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    builder.Required(o, 6);  // animName
    return new Offset<FaceAnimation>(o);
  }
};


}
