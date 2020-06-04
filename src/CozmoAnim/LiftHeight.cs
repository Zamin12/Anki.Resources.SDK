// Copyright � 2020 Randall Maas. All rights reserved.
// See LICENSE file in the project root for full license information.  
// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace Anki.CozmoAnim
{

using global::System;
using global::FlatBuffers;

/// <summary>
/// The LiftHeight structure is used to specify how to move Vector�s lift.  The
/// lift should reach the target height in the duration given, ramping up the
/// movement speed smoothly (with some variability) until it reaches that.  
/// </summary>
public struct LiftHeight : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static LiftHeight GetRootAsLiftHeight(ByteBuffer _bb) { return GetRootAsLiftHeight(_bb, new LiftHeight()); }
  public static LiftHeight GetRootAsLiftHeight(ByteBuffer _bb, LiftHeight obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public LiftHeight __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  /// <summary>
  /// The time at which the lift should begin motion.
  /// </summary>
  public uint TriggerTimeMs { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  /// <summary>
  /// How long the lift motion should last.
  /// </summary>
  public uint DurationTimeMs { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetUint(o + __p.bb_pos) : (uint)0; } }
  /// <summary>
  /// The height to lift the arms to.
  /// </summary>
  public byte HeightMm { get { int o = __p.__offset(8); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }
  /// <summary>
  /// The amount of randomness allowed for the target height.  default: 0
  /// </summary>
  public byte HeightVariabilityMm { get { int o = __p.__offset(10); return o != 0 ? __p.bb.Get(o + __p.bb_pos) : (byte)0; } }

  public static Offset<LiftHeight> CreateLiftHeight(FlatBufferBuilder builder,
      uint triggerTime_ms = 0,
      uint durationTime_ms = 0,
      byte height_mm = 0,
      byte heightVariability_mm = 0) {
    builder.StartObject(4);
    LiftHeight.AddDurationTimeMs(builder, durationTime_ms);
    LiftHeight.AddTriggerTimeMs(builder, triggerTime_ms);
    LiftHeight.AddHeightVariabilityMm(builder, heightVariability_mm);
    LiftHeight.AddHeightMm(builder, height_mm);
    return LiftHeight.EndLiftHeight(builder);
  }

  public static void StartLiftHeight(FlatBufferBuilder builder) { builder.StartObject(4); }
  public static void AddTriggerTimeMs(FlatBufferBuilder builder, uint triggerTimeMs) { builder.AddUint(0, triggerTimeMs, 0); }
  public static void AddDurationTimeMs(FlatBufferBuilder builder, uint durationTimeMs) { builder.AddUint(1, durationTimeMs, 0); }
  public static void AddHeightMm(FlatBufferBuilder builder, byte heightMm) { builder.AddByte(2, heightMm, 0); }
  public static void AddHeightVariabilityMm(FlatBufferBuilder builder, byte heightVariabilityMm) { builder.AddByte(3, heightVariabilityMm, 0); }
  public static Offset<LiftHeight> EndLiftHeight(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<LiftHeight>(o);
  }
};


}