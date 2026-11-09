# django/db/models/query_utils

- Subject: django/db/models/query_utils (id `bb60833d-f464-450f-a175-b1379c609211`)
- Kind: subject
- Budget: 1200 tokens
- Used: 882 tokens
- Facts shown: 11 of 69
- Conflicts: 0
- Gaps: 0

## Facts

- instance._state.fetch_mode.fetch(self, instance) if field_name not in data: # FETCH_PEERS may not load the field if the instance's row # was deleted after the queryset was evaluated. msg = f"{instance._meta.object_name} matching query does not exist." raise instance._meta.model.DoesNotExist(msg) else: data[field_name] = val return data[field_name] [6597d05e]
- found = self._get_lookup(lookup_name) if found is None and hasattr(self, "output_field"): return self.output_field.get_lookup(lookup_name) if found is not None and not issubclass(found, Lookup): return None return found [e17110f8]
- obj = self.create(connector=conn) obj.add(self, conn) obj.add(other, conn) return obj [f39de080]
- query = Query(None) for name, value in against.items(): if not hasattr(value, "resolve_expression"): value = Value(value) query.add_annotation(value, name, select=False) query.add_annotation(Value(1), "_check") connection = connections[using] # This will raise a FieldError if a field is missing in "against". query.add_q(self) compiler = query.get_compiler(using=using) context_manager = ( transaction.atomic(using=using) if connection.in_atomic_block else nullcontext() ) try: with context_manager: return compiler.execute_sql(SINGLE) is not None except DatabaseError as e: logger.warning("Got a database error calling check() on %r: %s", self, e) return True [8f88e786]
- return { child.split(LOOKUP_SEP, 1)[0] for child in query.get_children_from_q(self) } [01a13552]
- # Connection types AND = "AND" OR = "OR" XOR = "XOR" default = AND conditional = True connectors = (None, AND, OR, XOR) [bd6ebefb]
- # If the field is a primary key, then doing a query against the field's # model is ok, too. Consider the case: # class Restaurant(models.Model): # place = OneToOneField(Place, primary_key=True): # Restaurant.objects.filter(pk__in=Restaurant.objects.all()). # If we didn't have the primary key check, then pk__in (== place__in) would # give Place's opts as the target opts, but Restaurant isn't compatible # with that. This logic applies only to primary keys, as when doing # __in=qs, we are going to turn this into __in=qs.values('pk') later on. return check(target_opts) or ( getattr(field, "primary_key", False) and check(field.model._meta) ) [c7e830b8]
- @cached_property def identity(self): path, args, kwargs = self.deconstruct() identity = [path, *kwargs.items()] for child in args: if isinstance(child, tuple): arg, value = child value = make_hashable(value) identity.append((arg, value)) else: identity.append(child) return tuple(identity) [38b4639b]
- @cached_property def referenced_base_fields(self): """ Retrieve all base fields referenced directly or through F expressions excluding any fields referenced through joins. """ # Avoid circular imports. from django.db.models.sql import query [33df6783]
- @classmethod def _check_connector(cls, connector): if connector not in cls.connectors: connector_reprs = ", ".join(f"{conn!r}" for conn in cls.connectors[1:]) raise ValueError(f"connector must be one of {connector_reprs}, or None.") [e66acbd3]
- @classmethod def _clear_cached_class_lookups(cls): for subclass in subclasses(cls): subclass.get_class_lookups.cache_clear() [da760896]

## Beyond the budget

56 more facts did not fit in the budget: [49d06e65] [ff5766aa] [99ff28aa] [e231d794] [1df14d3e] [8d8a5852] [a038e394] [47ac40f7] [d7e1fce9] [52d02026] [35803cb27a9b3f58-3] [df2599b4] [bedd51ad] [530442ab] [1ea8f14c] [21681e25] [8a68da23] [3c29dc50] [69224896] [afd3d56e] [f15049e7] [4a0fe499] [bc77ea26] [5643919d] [9f606464] [47a84453] [62d8767f] [438cdcf0] [9cb15fc1] [722e23d8] [970ee4ca] [2b0ecd46] [9994a1e9] [17705efc] [03102fa6] [6c73efeb] [7e51e862] [09710b74] [b0eb7296] [11fe7130] [3a62849a] [140f4b13] [1252e75f] [c84a9cf4] [d45ddf13] [f2887100] [512ef63a] [ffddc953] [db5287c2] [0289e982] [18409c2a] [d7f1ba7e] [98fcc19e] [bad857ff] [9f13570d] [82e5d87d]
