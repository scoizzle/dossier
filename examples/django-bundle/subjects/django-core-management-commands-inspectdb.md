# django/core/management/commands/inspectdb

- Subject: django/core/management/commands/inspectdb (id `48d62656-0b5e-49aa-9591-e1d6a4a2fc72`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 10 of 41
- Conflicts: 0
- Gaps: 0

## Facts

- field_type += "(" [422de0d8]
- # Add 'null' and 'blank', if the 'null_ok' flag was present # in the table description. if row.null_ok: # If it's NULL... extra_params["blank"] = True extra_params["null"] = True [a6255ab3]
- # Add comment. if connection.features.supports_comments and row.comment: extra_params["db_comment"] = row.comment [99169a71]
- # Add primary_key and unique, if necessary. if column_name == primary_key_column: extra_params["primary_key"] = True elif column_name in unique_columns: extra_params["unique"] = True [8cc68826]
- # Don't output 'id = meta.AutoField(primary_key=True)', # because that's assumed if it doesn't exist. if att_name == "id" and extra_params == {"primary_key": True}: if field_type == "AutoField(": continue elif ( field_type == connection.features.introspected_field_types["AutoField"] + "(" ): comment_notes.append("AutoField?") [d7c0ec0e]
- att_name, params, notes = self.normalize_col_name( column_name, used_column_names, is_relation ) extra_params.update(params) comment_notes.extend(notes) [5d0c1451]
- field_desc = "%s = %s%s" % ( att_name, # Custom fields will have a dotted path "" if "." in field_type else "models.", field_type, ) on_delete_qualname = extra_params.pop("on_delete", None) if field_type.startswith(("ForeignKey(", "OneToOneField(")): if on_delete_qualname: field_desc += f", {on_delete_qualname}" else: field_desc += ", models.DO_NOTHING" [44998b0b]
- if extra_params: if not field_desc.endswith("("): field_desc += ", " field_desc += ", ".join( "%s=%r" % (k, v) for k, v in extra_params.items() ) field_desc += ")" if comment_notes: field_desc += " # " + " ".join(comment_notes) yield " %s" % field_desc comment = None if info := table_info.get(table_name): is_view = info.type == "v" is_partition = info.type == "p" if connection.features.supports_comments: comment = info.comment else: is_view = False is_partition = False yield from self.get_meta( table_name, constraints, column_to_field_name, is_view, is_partition, comment, ) [635f6935]
- if is_relation: ref_db_column, ref_db_table, db_on_delete = relations[ column_name ] if extra_params.pop("unique", False) or extra_params.get( "primary_key" ): rel_type = "OneToOneField" else: rel_type = "ForeignKey" ref_pk_column = ( connection.introspection.get_primary_key_column( cursor, ref_db_table ) ) if ref_pk_column and ref_pk_column != ref_db_column: extra_params["to_field"] = ref_db_column rel_to = ( "self" if ref_db_table == table_name else self.normalize_table_name(ref_db_table) ) if rel_to in known_models: field_type = "%s(%s" % (rel_type, rel_to) else: field_type = "%s('%s'" % (rel_type, rel_to) if rel_to in used_relations: extra_params["related_name"] = "%s_%s_set" % ( model_name.lower(), att_name, ) if db_on_delete and isinstance(db_on_delete, DatabaseOnDelete): extra_params["on_delete"] = f"models.{db_on_delete}" used_relations.add(rel_to) else: # Calling `get_field_type` to get the field type string # and any additional parameters and notes. field_type, field_params, field_notes = self.get_field_type( connection, table_name, row ) extra_params.update(field_params) comment_notes.extend(field_notes) [29482955]
- used_column_names.append(att_name) column_to_field_name[column_name] = att_name [578490c7]

## Beyond the budget

31 more facts did not fit in the budget: [5bc4c8c0] [fc0cab27] [9a5a9631] [8383f812] [7d228aa1] [48ccd42c] [af6a795a] [10b00139] [fddfbeef] [b09f79b2] [2dcd7427] [f0be337b] [a539a383] [1e71183d] [5965887f] [2a4b8520] [9f47afdc] [879dc376] [f48c0538] [85ca35dc] [989cc72c] [6ecab001] [4ddb0e45] [fdbdbede] [79f144c8] [b63a05eb] [2d6cc124] [560c2dc1] [c95d9ed6] [a0decd23] [b71b0003]
