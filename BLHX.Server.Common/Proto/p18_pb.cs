// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: p18_pb.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace BLHX.Server.Common.Proto.p18
{

    [global::ProtoBuf.ProtoContract(Name = @"arenarank")]
    public partial class Arenarank : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"level", IsRequired = true)]
        public uint Level { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"name", IsRequired = true)]
        public string Name { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"score", IsRequired = true)]
        public uint Score { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"display")]
        public global::BLHX.Server.Common.Proto.common.Displayinfo Display { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"arenashop")]
    public partial class Arenashop : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"shop_id", IsRequired = true)]
        public uint ShopId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"count", IsRequired = true)]
        public uint Count { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_18001")]
    public partial class Cs18001 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type", IsRequired = true)]
        public uint Type { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_18003")]
    public partial class Cs18003 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type", IsRequired = true)]
        public uint Type { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_18006")]
    public partial class Cs18006 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type", IsRequired = true)]
        public uint Type { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_18008")]
    public partial class Cs18008 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"vanguard_ship_id_list")]
        public global::System.Collections.Generic.List<uint> VanguardShipIdLists { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(2, Name = @"main_ship_id_list")]
        public global::System.Collections.Generic.List<uint> MainShipIdLists { get; set; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_18100")]
    public partial class Cs18100 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type", IsRequired = true)]
        public uint Type { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_18102")]
    public partial class Cs18102 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type", IsRequired = true)]
        public uint Type { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_18104")]
    public partial class Cs18104 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_18201")]
    public partial class Cs18201 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"page", IsRequired = true)]
        public uint Page { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"type", IsRequired = true)]
        public uint Type { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"act_id")]
        public uint ActId
        {
            get => __pbn__ActId.GetValueOrDefault();
            set => __pbn__ActId = value;
        }
        public bool ShouldSerializeActId() => __pbn__ActId != null;
        public void ResetActId() => __pbn__ActId = null;
        private uint? __pbn__ActId;

    }

    [global::ProtoBuf.ProtoContract(Name = @"cs_18203")]
    public partial class Cs18203 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"type", IsRequired = true)]
        public uint Type { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"act_id")]
        public uint ActId
        {
            get => __pbn__ActId.GetValueOrDefault();
            set => __pbn__ActId = value;
        }
        public bool ShouldSerializeActId() => __pbn__ActId != null;
        public void ResetActId() => __pbn__ActId = null;
        private uint? __pbn__ActId;

    }

    [global::ProtoBuf.ProtoContract(Name = @"rank_info")]
    public partial class RankInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"user_id", IsRequired = true)]
        public uint UserId { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"point", IsRequired = true)]
        public uint Point { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"name", IsRequired = true)]
        public string Name { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"lv", IsRequired = true)]
        public uint Lv { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"arena_rank", IsRequired = true)]
        public uint ArenaRank { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"display")]
        public global::BLHX.Server.Common.Proto.common.Displayinfo Display { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_18002")]
    public partial class Sc18002 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"score", IsRequired = true)]
        public uint Score { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"rank", IsRequired = true)]
        public uint Rank { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"fight_count", IsRequired = true)]
        public uint FightCount { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"fight_count_reset_time", IsRequired = true)]
        public uint FightCountResetTime { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"flash_target_count", IsRequired = true)]
        public uint FlashTargetCount { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"vanguard_ship_id_list")]
        public global::System.Collections.Generic.List<uint> VanguardShipIdLists { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(7, Name = @"main_ship_id_list")]
        public global::System.Collections.Generic.List<uint> MainShipIdLists { get; set; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(8, Name = @"target_list")]
        public global::System.Collections.Generic.List<Targetinfo> TargetLists { get; set; } = new global::System.Collections.Generic.List<Targetinfo>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_18004")]
    public partial class Sc18004 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"target_list")]
        public global::System.Collections.Generic.List<Targetinfo> TargetLists { get; set; } = new global::System.Collections.Generic.List<Targetinfo>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_18005")]
    public partial class Sc18005 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"score", IsRequired = true)]
        public uint Score { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"rank", IsRequired = true)]
        public uint Rank { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"target_list")]
        public global::System.Collections.Generic.List<Targetinfo> TargetLists { get; set; } = new global::System.Collections.Generic.List<Targetinfo>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_18007")]
    public partial class Sc18007 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"arena_rank_lsit")]
        public global::System.Collections.Generic.List<Arenarank> ArenaRankLsits { get; set; } = new global::System.Collections.Generic.List<Arenarank>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_18009")]
    public partial class Sc18009 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_18101")]
    public partial class Sc18101 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"flash_count", IsRequired = true)]
        public uint FlashCount { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"arena_shop_list")]
        public global::System.Collections.Generic.List<Arenashop> ArenaShopLists { get; set; } = new global::System.Collections.Generic.List<Arenashop>();

        [global::ProtoBuf.ProtoMember(3, Name = @"next_flash_time", IsRequired = true)]
        public uint NextFlashTime { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_18103")]
    public partial class Sc18103 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"result", IsRequired = true)]
        public uint Result { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"arena_shop_list")]
        public global::System.Collections.Generic.List<Arenashop> ArenaShopLists { get; set; } = new global::System.Collections.Generic.List<Arenashop>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_18105")]
    public partial class Sc18105 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"info", IsRequired = true)]
        public Targetinfo Info { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_18202")]
    public partial class Sc18202 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"list")]
        public global::System.Collections.Generic.List<RankInfo> Lists { get; set; } = new global::System.Collections.Generic.List<RankInfo>();

    }

    [global::ProtoBuf.ProtoContract(Name = @"sc_18204")]
    public partial class Sc18204 : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"point", IsRequired = true)]
        public uint Point { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"rank", IsRequired = true)]
        public uint Rank { get; set; }

    }

    [global::ProtoBuf.ProtoContract(Name = @"targetinfo")]
    public partial class Targetinfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"id", IsRequired = true)]
        public uint Id { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"level", IsRequired = true)]
        public uint Level { get; set; }

        [global::ProtoBuf.ProtoMember(3, Name = @"name", IsRequired = true)]
        public string Name { get; set; }

        [global::ProtoBuf.ProtoMember(4, Name = @"score", IsRequired = true)]
        public uint Score { get; set; }

        [global::ProtoBuf.ProtoMember(5, Name = @"rank", IsRequired = true)]
        public uint Rank { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"vanguard_ship_list")]
        public global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.common.Shipinfo> VanguardShipLists { get; set; } = new global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.common.Shipinfo>();

        [global::ProtoBuf.ProtoMember(7, Name = @"main_ship_list")]
        public global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.common.Shipinfo> MainShipLists { get; set; } = new global::System.Collections.Generic.List<global::BLHX.Server.Common.Proto.common.Shipinfo>();

        [global::ProtoBuf.ProtoMember(8, Name = @"display")]
        public global::BLHX.Server.Common.Proto.common.Displayinfo Display { get; set; }

    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, CS8981, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
