# django/contrib/admin/templatetags/admin_list

- Subject: django/contrib/admin/templatetags/admin_list (id `6c038cee-329c-402d-a003-b3731ece4647`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 9 of 41
- Conflicts: 0
- Gaps: 0

## Facts

- # Display link to the result's change_view if the url exists, else # display just the result's representation. try: url = cl.url_for_result(result) except NoReverseMatch: link_or_text = result_repr else: url = add_preserved_filters( {"preserved_filters": cl.preserved_filters, "opts": cl.opts}, url ) # Convert the pk to something that can be used in JavaScript. # Problem cases are non-ASCII strings. if cl.to_field: attr = str(cl.to_field) else: attr = pk value = result.serializable_value(attr) link_or_text = format_html( '<a href="{}"{}>{}</a>', url, ( format_html(' data-popup-opener="{}"', value) if cl.is_popup else "" ), result_repr, ) [e0a9ff05]
- # if the field is the action checkbox: no sorting and special class if field_name == "action_checkbox": aria_label = _("Select all objects on this page for an action") yield { "text": SafeString( f'<input type="checkbox" id="action-toggle" ' f'aria-label="{aria_label}">' ), "class_attrib": SafeString(' class="action-checkbox-column"'), "sortable": False, } continue [279ad12b]
- admin_order_field = getattr(attr, "admin_order_field", None) # Set ordering for attr that is a property, if defined. if isinstance(attr, property) and hasattr(attr, "fget"): admin_order_field = getattr(attr.fget, "admin_order_field", None) if not admin_order_field and LOOKUP_SEP not in field_name: is_field_sortable = False [c47fb638]
- yield format_html( "<{}{}>{}</{}>", table_tag, row_class, link_or_text, table_tag ) else: # By default the fields come from ModelAdmin.list_editable, but if # we pull the fields out of the form instead of list_editable # custom admins can provide fields on a per request basis if ( form and field_name in form.fields and not ( field_name == cl.model._meta.pk.name and form[cl.model._meta.pk.name].is_hidden ) ): bf = form[field_name] result_repr = mark_safe(str(bf.errors) + str(bf)) yield format_html("<td{}>{}</td>", row_class, result_repr) if form and not form[cl.model._meta.pk.name].is_hidden: yield format_html("<td>{}</td>", form[cl.model._meta.pk.name]) [89da0b2c]
- # OK, it is sortable if we got this far th_classes = ["sortable", "column-{}".format(field_name)] order_type = "" new_order_type = "asc" sort_priority = 0 # Is it currently being sorted on? is_sorted = i in ordering_field_columns if is_sorted: order_type = ordering_field_columns.get(i).lower() sort_priority = list(ordering_field_columns).index(i) + 1 th_classes.append("sorted %sending" % order_type) new_order_type = {"asc": "desc", "desc": "asc"}[order_type] [43ba4858]
- # build new ordering param o_list_primary = [] # URL for making this field the primary sort o_list_remove = [] # URL for removing this field from sort o_list_toggle = [] # URL for toggling order type for this field [7b70ff8f]
- def link(filters): return cl.get_query_string(filters, [field_generic]) [b025b4e5]
- def make_qs_param(t, n): return ("-" if t == "desc" else "") + str(n) [29f4b911]
- for j, ot in ordering_field_columns.items(): if j == i: # Same column param = make_qs_param(new_order_type, j) # We want clicking on this header to bring the ordering to the # front o_list_primary.insert(0, param) o_list_toggle.append(param) # o_list_remove - omit else: param = make_qs_param(ot, j) o_list_primary.append(param) o_list_toggle.append(param) o_list_remove.append(param) [f7e2e8d2]

## Beyond the budget

32 more facts did not fit in the budget: [71d6aa4b] [5e63c4e5] [b1daf3a8] [4b64bc43] [d364fa1d] [14b84ed0] [30fbffa9] [d0956fc0] [b44d7b95] [4e8776f7] [f364fe3d] [9082f31b] [bbf796a1] [fa6aeff5] [ae35987a] [4f84879c] [f48b74d1] [7f3c5d42] [714ec1ca] [ff96f2f5] [f2099803] [ef1e288d] [05c814a5] [91fbf223] [da71758d] [fb77f3d9] [fd677fed] [ea2fb0fd] [bd487a19b389f0e8] [8166bf23] [d152a5ac4c0db78d-2] [c8c0ccd629deb6b1]
