﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8009
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers.MapBased {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.6.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionPropertySerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty> {
        
        private MsgPack.Serialization.MessagePackSerializer<string> _serializer0;
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>> _serializer1;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionPropertySerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema valuesSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> valuesSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            valuesSchemaTypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            valuesSchemaTypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            valuesSchemaTypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            valuesSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), valuesSchemaTypeMap0);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>), null, valuesSchema0);
            this._serializer0 = context.GetSerializer<string>(schema0);
            MsgPack.Serialization.PolymorphismSchema schema1 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema valuesSchema1 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<byte, System.Type> valuesSchema1TypeMap0 = default(System.Collections.Generic.Dictionary<byte, System.Type>);
            valuesSchema1TypeMap0 = new System.Collections.Generic.Dictionary<byte, System.Type>(2);
            valuesSchema1TypeMap0.Add(0, typeof(MsgPack.Serialization.FileEntry));
            valuesSchema1TypeMap0.Add(1, typeof(MsgPack.Serialization.DirectoryEntry));
            valuesSchema1 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(MsgPack.Serialization.FileSystemEntry), valuesSchema1TypeMap0);
            schema1 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedDictionary(typeof(System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>), null, valuesSchema1);
            this._serializer1 = context.GetSerializer<System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>>(schema1);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty objectTree) {
            packer.PackMapHeader(1);
            this._serializer0.PackTo(packer, "DictStaticKeyAndPolymorphicItem");
            this._serializer1.PackTo(packer, objectTree.DictStaticKeyAndPolymorphicItem);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty();
            if (unpacker.IsArrayHeader) {
                int unpacked = default(int);
                int itemsCount = default(int);
                itemsCount = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry> nullable = default(System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>);
                if ((unpacked < itemsCount)) {
                    if ((unpacker.Read() == false)) {
                        throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(0);
                    }
                    if (((unpacker.IsArrayHeader == false) 
                                && (unpacker.IsMapHeader == false))) {
                        nullable = this._serializer1.UnpackFrom(unpacker);
                    }
                    else {
                        MsgPack.Unpacker disposable = default(MsgPack.Unpacker);
                        disposable = unpacker.ReadSubtree();
                        try {
                            nullable = this._serializer1.UnpackFrom(disposable);
                        }
                        finally {
                            if (((disposable == null) 
                                        == false)) {
                                disposable.Dispose();
                            }
                        }
                    }
                }
                if (((nullable == null) 
                            == false)) {
                    System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, MsgPack.Serialization.FileSystemEntry>> enumerator = nullable.GetEnumerator();
                    System.Collections.Generic.KeyValuePair<string, MsgPack.Serialization.FileSystemEntry> current;
                    try {
                        for (
                        ; enumerator.MoveNext(); 
                        ) {
                            current = enumerator.Current;
                            result.DictStaticKeyAndPolymorphicItem.Add(current.Key, current.Value);
                        }
                    }
                    finally {
                        enumerator.Dispose();
                    }
                }
                unpacked = (unpacked + 1);
            }
            else {
                int itemsCount0 = default(int);
                itemsCount0 = MsgPack.Serialization.UnpackHelpers.GetItemsCount(unpacker);
                for (int i = 0; (i < itemsCount0); i = (i + 1)) {
                    string key = default(string);
                    string nullable0 = default(string);
                    nullable0 = MsgPack.Serialization.UnpackHelpers.UnpackStringValue(unpacker, typeof(MsgPack.Serialization.PolymorphicMemberTypeKnownType_Dict_DictStaticKeyAndPolymorphicItemGetOnlyCollectionProperty), "MemberName");
                    if (((nullable0 == null) 
                                == false)) {
                        key = nullable0;
                    }
                    else {
                        throw MsgPack.Serialization.SerializationExceptions.NewNullIsProhibited("MemberName");
                    }
                    if ((key == "DictStaticKeyAndPolymorphicItem")) {
                        System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry> nullable1 = default(System.Collections.Generic.IDictionary<string, MsgPack.Serialization.FileSystemEntry>);
                        if ((unpacker.Read() == false)) {
                            throw MsgPack.Serialization.SerializationExceptions.NewMissingItem(i);
                        }
                        if (((unpacker.IsArrayHeader == false) 
                                    && (unpacker.IsMapHeader == false))) {
                            nullable1 = this._serializer1.UnpackFrom(unpacker);
                        }
                        else {
                            MsgPack.Unpacker disposable0 = default(MsgPack.Unpacker);
                            disposable0 = unpacker.ReadSubtree();
                            try {
                                nullable1 = this._serializer1.UnpackFrom(disposable0);
                            }
                            finally {
                                if (((disposable0 == null) 
                                            == false)) {
                                    disposable0.Dispose();
                                }
                            }
                        }
                        if (((nullable1 == null) 
                                    == false)) {
                            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, MsgPack.Serialization.FileSystemEntry>> enumerator0 = nullable1.GetEnumerator();
                            System.Collections.Generic.KeyValuePair<string, MsgPack.Serialization.FileSystemEntry> current0;
                            try {
                                for (
                                ; enumerator0.MoveNext(); 
                                ) {
                                    current0 = enumerator0.Current;
                                    result.DictStaticKeyAndPolymorphicItem.Add(current0.Key, current0.Value);
                                }
                            }
                            finally {
                                enumerator0.Dispose();
                            }
                        }
                    }
                    else {
                        unpacker.Skip();
                    }
                }
            }
            return result;
        }
        
        private static T @__Conditional<T>(bool condition, T whenTrue, T whenFalse)
         {
            if (condition) {
                return whenTrue;
            }
            else {
                return whenFalse;
            }
        }
    }
}
