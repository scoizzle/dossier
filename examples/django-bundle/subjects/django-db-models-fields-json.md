# django/db/models/fields/json

- Subject: django/db/models/fields/json (id `032cfb80-23c8-420c-9bbe-27c799aa6ad6`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 10 of 89
- Conflicts: 0
- Gaps: 0

## Facts

- # RemovedInDjango2028Warning: When the deprecation ends, remove # The following if-block entirely. # Treat None lookup values as null. if rhs == "%s" and (*rhs_params,) == (None,): rhs_params = ("null",) if connection.vendor == "mysql" and not isinstance( self.rhs, expressions.JSONNull ): func = ["JSON_EXTRACT(%s, '$')"] * len(rhs_params) rhs %= tuple(func) return rhs, rhs_params [ea11c47c]
- rhs, rhs_params = super().process_rhs(compiler, connection) [308bd52d]
- @classmethod def from_lookup(cls, lookup): transform, *keys = lookup.split(LOOKUP_SEP) if not keys: raise ValueError("Lookup must contain key or index transforms.") for key in keys: transform = cls(key, transform) return transform [de1edbc2]
- def __call__(self, *args, **kwargs): return KeyTransform(self.key_name, *args, **kwargs) [9370409e6227d4c7-2]
- def __init__( self, verbose_name=None, name=None, encoder=None, decoder=None, **kwargs, ): if encoder and not callable(encoder): raise ValueError("The encoder parameter must be a callable object.") if decoder and not callable(decoder): raise ValueError("The decoder parameter must be a callable object.") self.encoder = encoder self.decoder = decoder super().__init__(verbose_name, name, **kwargs) [1f25dd27]
- def __init__(self, key_name, *args, **kwargs): super().__init__(*args, **kwargs) self.key_name = str(key_name) [99ba9c13]
- def __init__(self, key_transform, *args, **kwargs): if not isinstance(key_transform, KeyTransform): raise TypeError( "Transform should be an instance of KeyTransform in order to " "use this lookup." ) key_text_transform = KeyTextTransform( key_transform.key_name, *key_transform.source_expressions, **key_transform.extra, ) super().__init__(key_text_transform, *args, **kwargs) [dc374e92]
- def _as_sql_parts(self, compiler, connection): # Process JSON path from the left-hand side. if isinstance(self.lhs, KeyTransform): lhs_sql, lhs_params, lhs_key_transforms = self.lhs.preprocess_lhs( compiler, connection ) lhs_json_path = connection.ops.compile_json_path(lhs_key_transforms) else: lhs_sql, lhs_params = self.process_lhs(compiler, connection) lhs_json_path = "$" # Process JSON path from the right-hand side. rhs = self.rhs if not isinstance(rhs, (list, tuple)): rhs = [rhs] for key in rhs: if isinstance(key, KeyTransform): *_, rhs_key_transforms = key.preprocess_lhs(compiler, connection) else: rhs_key_transforms = [key] *rhs_key_transforms, final_key = rhs_key_transforms rhs_json_path = connection.ops.compile_json_path( rhs_key_transforms, include_root=False ) rhs_json_path += self.compile_json_path_final_key(connection, final_key) yield lhs_sql, lhs_params, lhs_json_path + rhs_json_path [66cbcb2d]
- def _check_supported(self, databases): errors = [] for db in databases: if not router.allow_migrate_model(db, self.model): continue connection = connections[db] if ( self.model._meta.required_db_vendor and self.model._meta.required_db_vendor != connection.vendor ): continue if not ( "supports_json_field" in self.model._meta.required_db_features or connection.features.supports_json_field ): errors.append( checks.Error( "%s does not support JSONFields." % connection.display_name, obj=self.model, id="fields.E180", ) ) return errors [34937f0b]
- def get_internal_type(self): return "JSONField" [289167f6]

## Beyond the budget

75 more facts did not fit in the budget: [233bf0d6] [eebea3df] [21417f25] [547c1715] [8eeca5e9] [e9db6008] [8e4861aa] [a33c3f8b] [283210fd] [c93a1962] [d9a0d0b9] [3033e620] [44d6bcac] [769aac06] [ee479f0c] [c2d14e83] [1fe1e488] [0a2ddbb0] [e677b186] [12795c95] [3b36d0fa] [40ae2304] [b9e55f03] [9c65761a] [c592af7d] [278896c9d72511e0-2] [e9a990fae654588b-2] [badc91fa] [46b954f6] [7b4a40a5] [beb9fb51] [508988f2] [0a12109b] [afd9886f] [7ee44052] [c4ae43e1] [8cf87333] [ab59a50b] [27dfe3814c9a1ab6-2] [ac3c55e2] [61e2dd40] [25c15e6a] [076e4f3f] [eb682313] [b95b5ce3] [7d9bb68d] [d7372d33] [dfa9657e] [67a41168] [ec29a9ee] [e18afb1a] [5ffb129c] [dacb2807] [65e001fe] [3e158017] [f81964eaee3a6789-2] [019fc384] [1658a07a] [007a6a54] [34dc8809] [ebede203] [606ee050] [586b8cfe] [f9a0e607] [e12c1bdf] [4ed56107] [36c8a52c] [ac9be064] [8c1b0549] [e85b5856] [b6b83a47] [d196a88b] [43c65704] [b865d02b] [9c1bf3f5]
