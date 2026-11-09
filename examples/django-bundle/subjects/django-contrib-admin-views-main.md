# django/contrib/admin/views/main

- Subject: django/contrib/admin/views/main (id `e5e0f514-7ef8-4e91-98aa-3850778b38d5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 12 of 38
- Conflicts: 0
- Gaps: 0

## Facts

- spec = field_list_filter_class( field, request, lookup_params, self.model, self.model_admin, field_path=field_path, ) # field_list_filter_class removes any lookup_params it # processes. If that happened, check if duplicates should be # removed. if lookup_params_count > len(lookup_params): may_have_duplicates |= lookup_spawns_duplicates( self.lookup_opts, field_path, ) if spec and spec.has_output(): filter_specs.append(spec) if lookup_params_count > len(lookup_params): has_active_filters = True [f2a422de]
- # Add the given query's ordering fields, if any. ordering.extend(queryset.query.order_by) [1e9b8f80]
- # Apply search results qs, search_may_have_duplicates = self.model_admin.get_search_results( request, qs, self.query, ) [a05a08f1]
- # At this point, all the parameters used by the various ListFilters # have been removed from lookup_params, which now only contains other # parameters passed via the query string. We now loop through the # remaining parameters both to ensure that all the parameters are valid # fields and to determine if at least one of them spawns duplicates. If # the lookup parameters aren't real fields, then bail out. try: for key, value in lookup_params.items(): lookup_params[key] = prepare_lookup_value(key, value) may_have_duplicates |= lookup_spawns_duplicates(self.lookup_opts, key) return ( filter_specs, bool(filter_specs), lookup_params, may_have_duplicates, has_active_filters, ) except FieldDoesNotExist as e: raise IncorrectLookupParameters(e) from e [73741e08]
- # Get the list of objects to display on this page. if (self.show_all and can_show_all) or not multi_page: result_list = self.queryset._clone() else: try: result_list = paginator.page(self.page_num).object_list except InvalidPage: raise IncorrectLookupParameters [822a76e2]
- # Get the total number of objects, with no admin filters applied. # Note this isn't necessarily the same as result_count in the case of # no filtering. Filters defined in list_filters may still apply some # default filtering which may be removed with query parameters. if self.model_admin.show_full_result_count: full_result_count = self.root_queryset.count() else: full_result_count = None can_show_all = result_count <= self.list_max_show_all multi_page = result_count > self.list_per_page [990e4b86]
- # Set ordering. ordering = self.get_ordering(request, qs) qs = qs.order_by(*ordering) [023d1942]
- # Set query string for clearing all filters. self.clear_all_filters_qs = self.get_query_string( new_params=remaining_lookup_params, remove=self.get_filters_params(), ) # Remove duplicates from results, if necessary if filters_may_have_duplicates | search_may_have_duplicates: return qs.distinct() else: return qs [d520e822]
- for key, value_list in lookup_params.items(): for value in value_list: if not self.model_admin.lookup_allowed(key, value, request): raise DisallowedModelAdminLookup(f"Filtering by {key} not allowed") [d32b188a]
- if not qs.query.select_related: qs = self.apply_select_related(qs) [67caf5ed]
- if queryset.order_by(*ordering).totally_ordered: return ordering return ordering + ["-pk"] [38168f90]
- if self.list_select_related is False: if fields := self.get_select_related_fields(): return qs.select_related(*fields) [210ba402]

## Beyond the budget

26 more facts did not fit in the budget: [5f1c1309] [da793400] [7c4ab8f3] [faf2ae47] [bce8db8a] [aa2c63b5] [8092ced6] [c54866e4] [ff1073ed] [978deac5] [ad155175] [373a7cc7] [abf62c67] [5803b48a] [6914beac] [e1696ce5] [a191ca02] [ac3729f8] [97980d22] [d08d85a0] [1af5445a] [73cc6046] [e1478762] [ec275c31] [35b2e0a0] [33faa71b]
