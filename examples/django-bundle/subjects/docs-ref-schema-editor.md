# docs/ref/schema-editor

- Subject: docs/ref/schema-editor (id `389baf5b-74ae-4fc3-86c6-fc1c3f093259`)
- Kind: subject
- Budget: 1200 tokens
- Used: 894 tokens
- Facts shown: 30 of 70
- Conflicts: 0
- Gaps: 0

## Facts

- with connection.schema_editor() as schema_editor: schema_editor.delete_model(MyModel) [45a2c8c2]
- .. attribute:: SchemaEditor.connection [a55b62d5]
- .. class:: BaseDatabaseSchemaEditor [9cfb1957]
- .. method:: BaseDatabaseSchemaEditor.add_constraint(model, constraint) [84e3ef62]
- .. method:: BaseDatabaseSchemaEditor.add_field(model, field) [cba8fd40]
- .. method:: BaseDatabaseSchemaEditor.add_index(model, index) [8ac67b3b]
- .. method:: BaseDatabaseSchemaEditor.alter_db_table(model, old_db_table, new_db_table) [2c4c0ce9]
- .. method:: BaseDatabaseSchemaEditor.alter_db_tablespace(model, old_db_tablespace, new_db_tablespace) [f50916c4]
- .. method:: BaseDatabaseSchemaEditor.alter_field(model, old_field, new_field, strict=False) [a04efc30]
- .. method:: BaseDatabaseSchemaEditor.alter_index_together(model, old_index_together, new_index_together) [360e52d2]
- .. method:: BaseDatabaseSchemaEditor.alter_unique_together(model, old_unique_together, new_unique_together) [9a87033c]
- .. method:: BaseDatabaseSchemaEditor.create_model(model) [60c74c8f]
- .. method:: BaseDatabaseSchemaEditor.delete_model(model) [be3dba8e]
- .. method:: BaseDatabaseSchemaEditor.execute(sql, params=()) [a59708a8]
- .. method:: BaseDatabaseSchemaEditor.remove_constraint(model, constraint) [58deaa22]
- .. method:: BaseDatabaseSchemaEditor.remove_field(model, field) [574f2f34]
- .. method:: BaseDatabaseSchemaEditor.remove_index(model, index) [84349b1a]
- .. method:: BaseDatabaseSchemaEditor.rename_index(model, old_index, new_index) [566e4125]
- .. module:: django.db.backends.base.schema [24f9cc8d]
- ================ ``SchemaEditor`` ================ [9ab9d3a5]
- A connection object to the database. A useful attribute of the connection is ``alias`` which can be used to determine the name of the database being accessed. [267397b9]
- Adds ``constraint`` to ``model``'s table. [c48d0a41]
- Adds ``index`` to ``model``’s table. [e78bda3a]
- Adds a column (or sometimes multiple) to the model's table to represent the field. This will also add indexes or a unique constraint if the field has ``db_index=True`` or ``unique=True``. [553da0f9]
- All attributes should be considered read-only unless stated otherwise. [924df133]
- Attributes ========== [1aaa4a27458d239d-2]
- Change the ``model``’s table comment to ``new_db_table_comment``. [e02c3489]
- Changes a model's :attr:`~django.db.models.Options.unique_together` value; this will add or remove unique constraints from the model's table until they match the new value. [690b891a]
- Changes a model's ``index_together`` value; this will add or remove indexes from the model's table until they match the new value. [8428a7ff]
- Methods ======= [ec8366aa0d7b3837-2]

## Beyond the budget

39 more facts did not fit in the budget: [f6103c2f] [29c76d32] [1bff3a8a] [71d3a129] [0f1e04b1] [0c0b3aa9] [450e2d50] [62171d93] [e4788018] [685a1ed7] [6665990b] [2fe0ab9f] [52142ec2] [ec2a312e] [d33e9e65] [48c29172] [7270e81f] [9dcdb9a6] [e8de5193] [f19b3d68] [3a635d1f] [c3298783] [ef99d405] [0fc7f004] [ec533205] [ce9081d4] [18b3d2d6] [29c11dc6] [84f0fa00] [9d24df44] [cf7f28d8] [005be3c6] [14b94ab0] [62cd38af] [c923a96f] [ced86606] [bfdafc92] [e0dc6033] [caceb211]
