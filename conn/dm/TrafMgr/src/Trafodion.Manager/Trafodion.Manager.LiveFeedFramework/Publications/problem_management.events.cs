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

// Generated from: problem_management.events.proto
// Note: requires additional types generated from: common.event_header.proto
namespace problem_management
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"events")]
  public partial class events : global::ProtoBuf.IExtensible
  {
    public events() {}
    
    private common.event_header _header;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"header", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public common.event_header header
    {
      get { return _header; }
      set { _header = value; }
    }

    private string _error_string = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"error_string", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string error_string
    {
      get { return _error_string; }
      set { _error_string = value; }
    }

    private string _directory_name = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"directory_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string directory_name
    {
      get { return _directory_name; }
      set { _directory_name = value; }
    }

    private string _file_name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"file_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string file_name
    {
      get { return _file_name; }
      set { _file_name = value; }
    }

    private int _file_line_number = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"file_line_number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int file_line_number
    {
      get { return _file_line_number; }
      set { _file_line_number = value; }
    }

    private int _file_column_number = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"file_column_number", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int file_column_number
    {
      get { return _file_column_number; }
      set { _file_column_number = value; }
    }

    private string _repository_table = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"repository_table", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string repository_table
    {
      get { return _repository_table; }
      set { _repository_table = value; }
    }

    private string _repository_column = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"repository_column", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string repository_column
    {
      get { return _repository_column; }
      set { _repository_column = value; }
    }

    private string _publication_name = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"publication_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string publication_name
    {
      get { return _publication_name; }
      set { _publication_name = value; }
    }

    private string _publication_field = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"publication_field", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string publication_field
    {
      get { return _publication_field; }
      set { _publication_field = value; }
    }

    private string _routing_key = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"routing_key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string routing_key
    {
      get { return _routing_key; }
      set { _routing_key = value; }
    }

    private int _sql_error_code = default(int);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"sql_error_code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int sql_error_code
    {
      get { return _sql_error_code; }
      set { _sql_error_code = value; }
    }

    private string _sql_error_text = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"sql_error_text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sql_error_text
    {
      get { return _sql_error_text; }
      set { _sql_error_text = value; }
    }

    private int _seabed_error_code = default(int);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"seabed_error_code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int seabed_error_code
    {
      get { return _seabed_error_code; }
      set { _seabed_error_code = value; }
    }

    private string _seabed_function_name = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"seabed_function_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string seabed_function_name
    {
      get { return _seabed_function_name; }
      set { _seabed_function_name = value; }
    }

    private string _amqp_function_name = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"amqp_function_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string amqp_function_name
    {
      get { return _amqp_function_name; }
      set { _amqp_function_name = value; }
    }

    private int _amqp_error_code = default(int);
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"amqp_error_code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int amqp_error_code
    {
      get { return _amqp_error_code; }
      set { _amqp_error_code = value; }
    }

    private string _amqp_error_text = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"amqp_error_text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string amqp_error_text
    {
      get { return _amqp_error_text; }
      set { _amqp_error_text = value; }
    }

    private int _lua_error_code = default(int);
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"lua_error_code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int lua_error_code
    {
      get { return _lua_error_code; }
      set { _lua_error_code = value; }
    }

    private string _lua_error_text = "";
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"lua_error_text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string lua_error_text
    {
      get { return _lua_error_text; }
      set { _lua_error_text = value; }
    }

    private int _lua_stack_index = default(int);
    [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"lua_stack_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int lua_stack_index
    {
      get { return _lua_stack_index; }
      set { _lua_stack_index = value; }
    }

    private string _lua_field_type1 = "";
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"lua_field_type1", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string lua_field_type1
    {
      get { return _lua_field_type1; }
      set { _lua_field_type1 = value; }
    }

    private string _lua_field_type2 = "";
    [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"lua_field_type2", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string lua_field_type2
    {
      get { return _lua_field_type2; }
      set { _lua_field_type2 = value; }
    }

    private string _syscall_name = "";
    [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"syscall_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string syscall_name
    {
      get { return _syscall_name; }
      set { _syscall_name = value; }
    }

    private string _syscall_arg = "";
    [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"syscall_arg", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string syscall_arg
    {
      get { return _syscall_arg; }
      set { _syscall_arg = value; }
    }

    private int _syscall_error_code = default(int);
    [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"syscall_error_code", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int syscall_error_code
    {
      get { return _syscall_error_code; }
      set { _syscall_error_code = value; }
    }

    private string _syscall_error_text = "";
    [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"syscall_error_text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string syscall_error_text
    {
      get { return _syscall_error_text; }
      set { _syscall_error_text = value; }
    }

    private string _conf_lua_source = "";
    [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"conf_lua_source", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string conf_lua_source
    {
      get { return _conf_lua_source; }
      set { _conf_lua_source = value; }
    }

    private string _conf_proto_source = "";
    [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"conf_proto_source", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string conf_proto_source
    {
      get { return _conf_proto_source; }
      set { _conf_proto_source = value; }
    }

    private string _conf_context_source = "";
    [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"conf_context_source", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string conf_context_source
    {
      get { return _conf_context_source; }
      set { _conf_context_source = value; }
    }

    private int _conf_logical_node_count = default(int);
    [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"conf_logical_node_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int conf_logical_node_count
    {
      get { return _conf_logical_node_count; }
      set { _conf_logical_node_count = value; }
    }

    private string _conf_seapilot_source = "";
    [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"conf_seapilot_source", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string conf_seapilot_source
    {
      get { return _conf_seapilot_source; }
      set { _conf_seapilot_source = value; }
    }

    private int _unexpected_phase = default(int);
    [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"unexpected_phase", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int unexpected_phase
    {
      get { return _unexpected_phase; }
      set { _unexpected_phase = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}