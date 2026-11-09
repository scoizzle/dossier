# django/core/management/commands/dumpdata

- Subject: django/core/management/commands/dumpdata (id `ce025a60-d49a-436f-bb84-2854094ebd94`)
- Kind: subject
- Budget: 1200 tokens
- Used: 888 tokens
- Facts shown: 9 of 20
- Conflicts: 0
- Gaps: 0

## Facts

- # We may have previously seen an "all-models" request for # this app (no model qualifier was given). In this case # there is no need adding specific models to the list. if app_list_value is not None and model not in app_list_value: app_list_value.append(model) except ValueError: if primary_keys: raise CommandError( "You can only use --pks option with one model" ) # This is just an app - no model qualifier app_label = label try: app_config = apps.get_app_config(app_label) except LookupError as e: raise CommandError(str(e)) if app_config.models_module is None or app_config in excluded_apps: continue app_list[app_config] = None [51bbf856]
- app_list_value = app_list.setdefault(app_config, []) [94f93533]
- queryset = objects.using(using).order_by(model._meta.pk.name) if primary_keys: queryset = queryset.filter(pk__in=primary_keys) if count_only: yield queryset.order_by().count() else: chunk_size = ( 2000 if queryset._prefetch_related_lookups else None ) yield from queryset.iterator(chunk_size=chunk_size) [58b8bbfa]
- raise CommandError("Unknown serialization format: %s" % format) [f3a68646]
- # Check that the serialization format exists; this is a shortcut to # avoid collating all the objects and _then_ failing. if format not in serializers.get_public_serializer_formats(): try: serializers.get_serializer(format) except serializers.SerializerDoesNotExist: pass [dfd49907]
- def get_objects(count_only=False): """ Collate the objects to be serialized. If count_only is True, just count the number of objects to be serialized. """ if use_natural_foreign_keys: models = serializers.sort_dependencies( app_list.items(), allow_cycles=True ) else: # There is no need to sort dependencies when natural foreign # keys are not used. models = [] for app_config, model_list in app_list.items(): if model_list is None: models.extend(app_config.get_models()) else: models.extend(model_list) for model in models: if model in excluded_models: continue if model._meta.proxy and model._meta.proxy_for_model not in models: warnings.warn( "%s is a proxy model and won't be serialized." % model._meta.label, category=ProxyModelWarning, ) if not model._meta.proxy and router.allow_migrate_model(using, model): if use_base_manager: objects = model._base_manager else: objects = model._default_manager [0b58ecc7]
- excluded_models, excluded_apps = parse_apps_and_model_labels(excludes) [2b0a50d0]
- if not app_labels: if primary_keys: raise CommandError("You can only use --pks option with one model") app_list = dict.fromkeys( app_config for app_config in apps.get_app_configs() if app_config.models_module is not None and app_config not in excluded_apps ) else: if len(app_labels) > 1 and primary_keys: raise CommandError("You can only use --pks option with one model") app_list = {} for label in app_labels: try: app_label, model_label = label.split(".") try: app_config = apps.get_app_config(app_label) except LookupError as e: raise CommandError(str(e)) if app_config.models_module is None or app_config in excluded_apps: continue try: model = app_config.get_model(model_label) except LookupError: raise CommandError( "Unknown model: %s.%s" % (app_label, model_label) ) [094407f5]
- if pks: primary_keys = [pk.strip() for pk in pks.split(",")] else: primary_keys = [] [1d63c17b]

## Beyond the budget

11 more facts did not fit in the budget: [8762aaea] [bc009600] [98e50e90] [774b9cde7dc731fe] [c57526821f3d9823] [1b370c82] [ba1c9e72] [b20d2f09] [e10d798c] [b8873fe84a6dd996] [72504776bae1f8f5]
