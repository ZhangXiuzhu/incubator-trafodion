// @@@ START COPYRIGHT @@@
//
// (C) Copyright 2015 Hewlett-Packard Development Company, L.P.
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
// @@@ END COPYRIGHT @@@
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: common.info_header.proto
// Note: requires additional types generated from: common.qpid_header.proto
namespace common
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"info_header")]
  public partial class info_header : global::ProtoBuf.IExtensible
  {
    public info_header() {}
    
    private common.qpid_header _header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public common.qpid_header header
    {
      get { return _header; }
      set { _header = value; }
    }
    private long _info_generation_time_ts_utc;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"info_generation_time_ts_utc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long info_generation_time_ts_utc
    {
      get { return _info_generation_time_ts_utc; }
      set { _info_generation_time_ts_utc = value; }
    }
    private long _info_generation_time_ts_lct;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"info_generation_time_ts_lct", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long info_generation_time_ts_lct
    {
      get { return _info_generation_time_ts_lct; }
      set { _info_generation_time_ts_lct = value; }
    }
    private uint _info_version;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"info_version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint info_version
    {
      get { return _info_version; }
      set { _info_version = value; }
    }
    private uint _info_cluster_id;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"info_cluster_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint info_cluster_id
    {
      get { return _info_cluster_id; }
      set { _info_cluster_id = value; }
    }
    private uint _info_domain_id;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"info_domain_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint info_domain_id
    {
      get { return _info_domain_id; }
      set { _info_domain_id = value; }
    }
    private uint _info_subdomain_id;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"info_subdomain_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint info_subdomain_id
    {
      get { return _info_subdomain_id; }
      set { _info_subdomain_id = value; }
    }
    private uint _info_instance_id;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"info_instance_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint info_instance_id
    {
      get { return _info_instance_id; }
      set { _info_instance_id = value; }
    }
    private uint _info_tenant_id;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"info_tenant_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint info_tenant_id
    {
      get { return _info_tenant_id; }
      set { _info_tenant_id = value; }
    }
    private uint _info_component_id;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"info_component_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint info_component_id
    {
      get { return _info_component_id; }
      set { _info_component_id = value; }
    }
    private int _info_process_id;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"info_process_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int info_process_id
    {
      get { return _info_process_id; }
      set { _info_process_id = value; }
    }
    private uint _info_thread_id;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"info_thread_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint info_thread_id
    {
      get { return _info_thread_id; }
      set { _info_thread_id = value; }
    }

    private uint _info_node_id = default(uint);
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"info_node_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint info_node_id
    {
      get { return _info_node_id; }
      set { _info_node_id = value; }
    }

    private uint _info_pnid_id = default(uint);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"info_pnid_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint info_pnid_id
    {
      get { return _info_pnid_id; }
      set { _info_pnid_id = value; }
    }
    private string _info_ip_address_id;
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"info_ip_address_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string info_ip_address_id
    {
      get { return _info_ip_address_id; }
      set { _info_ip_address_id = value; }
    }
    private uint _info_sequence_num;
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"info_sequence_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint info_sequence_num
    {
      get { return _info_sequence_num; }
      set { _info_sequence_num = value; }
    }

    private string _info_process_name = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"info_process_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string info_process_name
    {
      get { return _info_process_name; }
      set { _info_process_name = value; }
    }
    private uint _info_host_id;
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"info_host_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint info_host_id
    {
      get { return _info_host_id; }
      set { _info_host_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}