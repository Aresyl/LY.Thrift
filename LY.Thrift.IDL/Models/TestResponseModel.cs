/**
 * Autogenerated by Thrift Compiler (0.10.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace LY.Thrift.IDL
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class TestResponseModel : TBase
  {
    private bool _isTrue;
    private short _aa;
    private int _bb;
    private long _cc;
    private double _dd;
    private string _ee;
    private List<string> _ff;

    public bool IsTrue
    {
      get
      {
        return _isTrue;
      }
      set
      {
        __isset.isTrue = true;
        this._isTrue = value;
      }
    }

    public short Aa
    {
      get
      {
        return _aa;
      }
      set
      {
        __isset.aa = true;
        this._aa = value;
      }
    }

    public int Bb
    {
      get
      {
        return _bb;
      }
      set
      {
        __isset.bb = true;
        this._bb = value;
      }
    }

    public long Cc
    {
      get
      {
        return _cc;
      }
      set
      {
        __isset.cc = true;
        this._cc = value;
      }
    }

    public double Dd
    {
      get
      {
        return _dd;
      }
      set
      {
        __isset.dd = true;
        this._dd = value;
      }
    }

    public string Ee
    {
      get
      {
        return _ee;
      }
      set
      {
        __isset.ee = true;
        this._ee = value;
      }
    }

    public List<string> Ff
    {
      get
      {
        return _ff;
      }
      set
      {
        __isset.ff = true;
        this._ff = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool isTrue;
      public bool aa;
      public bool bb;
      public bool cc;
      public bool dd;
      public bool ee;
      public bool ff;
    }

    public TestResponseModel() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.Bool) {
                IsTrue = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.I16) {
                Aa = iprot.ReadI16();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.I32) {
                Bb = iprot.ReadI32();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.I64) {
                Cc = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.Double) {
                Dd = iprot.ReadDouble();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.String) {
                Ee = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.List) {
                {
                  Ff = new List<string>();
                  TList _list4 = iprot.ReadListBegin();
                  for( int _i5 = 0; _i5 < _list4.Count; ++_i5)
                  {
                    string _elem6;
                    _elem6 = iprot.ReadString();
                    Ff.Add(_elem6);
                  }
                  iprot.ReadListEnd();
                }
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("TestResponseModel");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (__isset.isTrue) {
          field.Name = "isTrue";
          field.Type = TType.Bool;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(IsTrue);
          oprot.WriteFieldEnd();
        }
        if (__isset.aa) {
          field.Name = "aa";
          field.Type = TType.I16;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteI16(Aa);
          oprot.WriteFieldEnd();
        }
        if (__isset.bb) {
          field.Name = "bb";
          field.Type = TType.I32;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteI32(Bb);
          oprot.WriteFieldEnd();
        }
        if (__isset.cc) {
          field.Name = "cc";
          field.Type = TType.I64;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Cc);
          oprot.WriteFieldEnd();
        }
        if (__isset.dd) {
          field.Name = "dd";
          field.Type = TType.Double;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteDouble(Dd);
          oprot.WriteFieldEnd();
        }
        if (Ee != null && __isset.ee) {
          field.Name = "ee";
          field.Type = TType.String;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(Ee);
          oprot.WriteFieldEnd();
        }
        if (Ff != null && __isset.ff) {
          field.Name = "ff";
          field.Type = TType.List;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          {
            oprot.WriteListBegin(new TList(TType.String, Ff.Count));
            foreach (string _iter7 in Ff)
            {
              oprot.WriteString(_iter7);
            }
            oprot.WriteListEnd();
          }
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("TestResponseModel(");
      bool __first = true;
      if (__isset.isTrue) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("IsTrue: ");
        __sb.Append(IsTrue);
      }
      if (__isset.aa) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Aa: ");
        __sb.Append(Aa);
      }
      if (__isset.bb) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Bb: ");
        __sb.Append(Bb);
      }
      if (__isset.cc) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Cc: ");
        __sb.Append(Cc);
      }
      if (__isset.dd) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Dd: ");
        __sb.Append(Dd);
      }
      if (Ee != null && __isset.ee) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Ee: ");
        __sb.Append(Ee);
      }
      if (Ff != null && __isset.ff) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Ff: ");
        __sb.Append(Ff);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
