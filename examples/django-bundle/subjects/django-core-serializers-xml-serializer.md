# django/core/serializers/xml_serializer

- Subject: django/core/serializers/xml_serializer (id `824348c3-a66a-44f2-b0eb-9329d0a41ecc`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 11 of 66
- Conflicts: 0
- Gaps: 0

## Facts

- def handle_m2m(value): # Put each object on its own line. self.indent(self.indent_level + 1) self.xml.addQuickElement("object", attrs={"pk": str(value.pk)}) [db46ccb4]
- def queryset_iterator(obj, field): attr = getattr(obj, field.name) chunk_size = ( 2000 if getattr(attr, "prefetch_cache_name", None) else None ) query_set = attr.all() if not query_set.totally_ordered: current_ordering = ( query_set.query.order_by or query_set.model._meta.ordering or [] ) query_set = query_set.order_by(*current_ordering, "pk") return query_set.iterator(chunk_size) [c62f4a1b586b7adc-2]
- def queryset_iterator(obj, field): query_set = getattr(obj, field.name).select_related(None).only("pk") if not query_set.totally_ordered: current_ordering = ( query_set.query.order_by or query_set.model._meta.ordering or [] ) query_set = query_set.order_by(*current_ordering, "pk") chunk_size = 2000 if query_set._prefetch_related_lookups else None return query_set.iterator(chunk_size=chunk_size) [e7465ca7f2518df7-2]
- # As is usually the case, relation fields get the special # treatment. if field.remote_field and isinstance( field.remote_field, models.ManyToManyRel ): value = self._handle_m2m_field_node(field_node, field) if value == base.DEFER_FIELD: deferred_fields[field] = [ [ ( None if getChildrenByTagName(nat_node, "None") else getInnerText(nat_node).strip() ) for nat_node in getChildrenByTagName(obj_node, "natural") ] for obj_node in getChildrenByTagName(field_node, "object") ] else: m2m_data[field.name] = value elif field.remote_field and isinstance( field.remote_field, models.ManyToOneRel ): value = self._handle_fk_field_node(field_node, field) if value == base.DEFER_FIELD: deferred_fields[field] = [ ( None if getChildrenByTagName(k, "None") else getInnerText(k).strip() ) for k in getChildrenByTagName(field_node, "natural") ] else: data[field.attname] = value else: if getChildrenByTagName(field_node, "None"): value = None else: value = field.to_python(getInnerText(field_node).strip()) # Load value since JSONField.to_python() outputs strings. if field.get_internal_type() == "JSONField": value = json.loads(value, cls=field.decoder) data[field.name] = value [bfd99b63]
- # Get the field from the Model. This will raise a # FieldDoesNotExist if, well, the field doesn't exist, which will # be propagated correctly unless ignorenonexistent=True is used. if self.ignore and field_name not in field_names: continue field = Model._meta.get_field(field_name) [1187f5e1]
- def m2m_convert(n): keys = getChildrenByTagName(n, "natural") if keys: # If there are 'natural' subelements, it must be a natural # key field_value = [] for k in keys: if getChildrenByTagName(k, "None"): field_value.append(None) else: field_value.append(getInnerText(k).strip()) obj_pk = ( default_manager.db_manager(self.db) .get_by_natural_key(*field_value) .pk ) else: # Otherwise, treat like a normal PK value. obj_pk = model._meta.pk.to_python(n.getAttribute("pk")) return obj_pk [63c05353]
- def m2m_convert(n): return model._meta.pk.to_python(n.getAttribute("pk")) [e4fc35ce]
- else: [6ad07797f4838346-6]
- # Also start building a dict of m2m data (this is saved as # {m2m_accessor_attribute : [list_of_related_objects]}) m2m_data = {} deferred_fields = {} [dd86ea0c]
- else: [6ad07797f4838346-7]
- """ XML serializer. """ [c523a971]

## Beyond the budget

54 more facts did not fit in the budget: [21149876] [96292cad] [b4dcef49] [6ef960dd] [802c5697] [b74a52be] [528add3c] [c5b3cdca] [fb77d417] [3990076b] [f8603545] [ee052d18] [42f04793] [13731b3e] [144e3419] [8fe56dae] [14aeca8a] [92b4a712] [d2330ce7] [67be5f30107b5926] [f6b67dd0] [5e6187e4] [4693c9e0] [48c8c5a2] [dd3f8c38] [59025ac0] [1603a42e] [3be17380] [d63d632c] [ba41388a] [05bb5db5] [03b5a32b] [b676e9b4] [b183c687] [ac05ad71] [bda86ef7] [5f40bc07] [e7e12c0d] [dd0a65e4] [4f0094c9] [a8713d15] [0c6ca542] [3295287a] [14c7d3be] [171c7a0d] [5beb9e8b] [3972a716] [93511012] [e96d8d27] [a6870efe] [8b9368eb] [280e1e29] [a301debb] [11420c31]
