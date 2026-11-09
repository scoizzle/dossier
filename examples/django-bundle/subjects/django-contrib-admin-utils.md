# django/contrib/admin/utils

- Subject: django/contrib/admin/utils (id `9960ea80-ef32-480f-a57d-0fb150d073fa`)
- Kind: subject
- Budget: 1200 tokens
- Used: 892 tokens
- Facts shown: 12 of 57
- Conflicts: 0
- Gaps: 0

## Facts

- # Display a link to the admin page. obj_display = display_for_value(str(obj), EMPTY_VALUE_STRING) return format_html( '{}: <a href="{}">{}</a>', capfirst(opts.verbose_name), admin_url, obj_display, ) else: # Don't display link to edit, because it either has no # admin or is edited inline. return no_edit_link [6b1a7e48]
- if hasattr(attr, "short_description"): label = attr.short_description elif ( isinstance(attr, property) and hasattr(attr, "fget") and hasattr(attr.fget, "short_description") ): label = attr.fget.short_description elif callable(attr): if attr.__name__ == "<lambda>": label = "--" else: label = pretty_name(attr.__name__) else: label = pretty_name(name) except FieldIsAForeignKeyColumnName: label = pretty_name(name) attr = name [0c345084]
- # Field should point to another model if field.is_relation and not (field.auto_created and not field.concrete): related_name = field.related_query_name() parent = field.remote_field.model else: related_name = field.field.name parent = field.related_model reversed_path.insert(0, related_name) return (parent, LOOKUP_SEP.join(reversed_path)) [07547ab0]
- if admin_site.is_registered(model): if not admin_site.get_model_admin(model).has_delete_permission( request, obj ): perms_needed.add(opts.verbose_name) try: admin_url = reverse( "%s:%s_%s_change" % (admin_site.name, opts.app_label, opts.model_name), None, (quote(obj.pk),), ) except NoReverseMatch: # Change url doesn't exist -- don't display link to edit return no_edit_link [5ead5f57]
- no_edit_link = "%s: %s" % (capfirst(opts.verbose_name), obj) [7f5c7e84]
- # Avoid coercing <FK>_id fields to FK if ( field.is_relation and not field.many_to_many and hasattr(field, "attname") and field.attname == name ): raise FieldIsAForeignKeyColumnName() [8ef1b286]
- E.g. Given (Order, "user__groups"), return (Group, "user__order"). [baeda8fa]
- Final field must be a related model, not a data field. """ reversed_path = [] parent = model pieces = path.split(LOOKUP_SEP) for piece in pieces: field = parent._meta.get_field(piece) # skip trailing data field if extant: if len(reversed_path) == len(pieces) - 1: # final iteration try: get_model_from_relation(field) except NotRelationField: break [d379b060]
- Return a nested list of strings suitable for display in the template with the ``unordered_list`` and ``truncated_unordered_list`` filters. """ from django.contrib.admin.options import EMPTY_VALUE_STRING [4c6e2bfc]
- Reverse relations should also be excluded as these aren't attributes of the model (rather something like `foo_set`). """ field = opts.get_field(name) if ( field.is_relation and # Generic foreign keys OR reverse relations ((field.many_to_one and not field.related_model) or field.one_to_many) ): raise FieldDoesNotExist() [cbdc6c8a]
- `obj` may be a `Model` instance, `Model` subclass, or `QuerySet` instance. """ if isinstance(obj, (models.Model, models.base.ModelBase)): opts = obj._meta elif isinstance(obj, models.query.QuerySet): opts = obj.model._meta else: opts = obj return { "verbose_name": opts.verbose_name, "verbose_name_plural": opts.verbose_name_plural, } [4d55c123]
- def add_edge(self, source, target): self.edges.setdefault(source, []).append(target) [f64ea7a1]

## Beyond the budget

45 more facts did not fit in the budget: [910bcc6a] [aa70299a] [841a1293] [cfb5aa28] [b1a6e8d5] [3db36e02] [a22f70ab] [d403a4e9] [a93c9c6a] [908a8a2a] [b101af6b] [7655780f0d17b825-5] [59c20df3] [a6775441] [e40abb4a] [39b59001] [4e20e2c9] [ec553b83] [9a9b173d] [e90fcc1c] [fe358444] [15de94e2] [8b1e6681] [d7b18339] [1cc8e147] [0d95af81] [8517d2a6] [1d9db626] [9d2c6297] [1d9ecaac] [be481fca] [55c31dd1] [c4f03454] [24c18438] [52edeb2e] [78cadd33] [cb7bb0fb] [b0666606] [69edd3cc] [47ca1213] [37be2483] [fbce2c4f] [4626eac1] [ab26b6b2] [4d8d6ff7]
