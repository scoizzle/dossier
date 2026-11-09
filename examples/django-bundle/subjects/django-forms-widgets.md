# django/forms/widgets

- Subject: django/forms/widgets (id `14f57b36-f1e0-4655-ac6f-f1457793e82f`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 14 of 180
- Conflicts: 0
- Gaps: 0

## Facts

- for subvalue, sublabel in choices: selected = (not has_selected or self.allow_multiple_selected) and str( subvalue ) in value has_selected |= selected subgroup.append( self.create_option( name, subvalue, sublabel, selected, index, subindex=subindex, attrs=attrs, ) ) if subindex is not None: subindex += 1 return groups [387454bf]
- self.year_none_value = ("", empty_label[0]) self.month_none_value = ("", empty_label[1]) self.day_none_value = ("", empty_label[2]) else: if empty_label is not None: self.none_value = ("", empty_label) [193e5204]
- self.year_none_value = self.none_value self.month_none_value = self.none_value self.day_none_value = self.none_value [f778092a]
- subgroup = [] if isinstance(option_label, (list, tuple)): group_name = option_value subindex = 0 choices = option_label else: group_name = None subindex = None choices = [(option_value, option_label)] groups.append((group_name, subgroup, index)) [67e4ef45]
- # Get the media definition for this class definition = getattr(cls, "Media", None) if definition: extend = getattr(definition, "extend", True) if extend: if extend is True: m = base else: m = Media() for medium in extend: m += base[medium] return m + Media(definition) return Media(definition) return base [61006b0b]
- # Optional dict of months to use in the "month" select box. if months: self.months = months else: self.months = MONTHS [42d8c153]
- # Optional list or tuple of years to use in the "year" select box. if years: self.years = years else: this_year = datetime.date.today().year self.years = range(this_year, this_year + 10) [1a7ec3bd]
- # Optional string, list, or tuple to use as empty_label. if isinstance(empty_label, (list, tuple)): if not len(empty_label) == 3: raise ValueError("empty_label list/tuple must have 3 elements.") [2c8a99d1]
- For static assets it can be important to have them included in the DOM in a certain order. In JavaScript you may not be able to reference a global or in CSS you might want to override a style. """ ts = TopologicalSorter() for head, *tail in filter(None, lists): ts.add(head) # Ensure that the first items are included. for item in tail: if head != item: # Avoid circular dependency to self. ts.add(item, head) head = item try: return list(ts.static_order()) except CycleError: warnings.warn( "Detected duplicate Media files in an opposite order: {}".format( ", ".join(repr(list_) for list_ in lists) ), MediaOrderConflictWarning, ) return list(dict.fromkeys(chain.from_iterable(filter(None, lists)))) [18b81d8f]
- This hook is necessary because some widgets have multiple HTML elements and, thus, multiple IDs. In that case, this method should return an ID value that corresponds to the first ID in the widget's tags. """ return id_ [7006ed72]
- context["widget"]["subwidgets"] = subwidgets return context [485a022f]
- first_choice = next(iter(self.choices), None) return ( use_required_attribute and first_choice is not None and self._choice_has_empty_value(first_choice) ) [2aa18312]
- for index, (option_value, option_label) in enumerate(self.choices): if option_value is None: option_value = "" [cbaee76a]
- if "media" not in attrs: new_class.media = media_property(new_class) [3040b0af]

## Beyond the budget

161 more facts did not fit in the budget: [f9e0e378] [c1ff1b87] [9ada69c78b7df1fa-3] [7db8db13] [f7af1fbf826e6672-2] [951e1e38] [a2246871] [90794f5d301182b5-3] [1f4eafc4] [42ca2b95] [2c82cdaa] [a6ca9152] [17cdaf5e] [e42f270e] [3913b61d] [920b4af2] [e58031f6] [466fcab7] [a688683e] [dce37405] [f28c2508] [5609b8ee] [3b6e1f73] [6ef0018a] [7e2f8666] [b88761cc] [e58cc1f3] [fa21b515] [52cb4245] [dc2011f2] [132b5f9e] [1763baf6] [01f57266] [f8b84e3d] [d006cfca] [aa9f5d7e] [c515c188] [e2406efb] [1a88e80d] [45cfced5] [604ac653] [a4e0a49c] [da5fdec7] [70b13d28] [aefa2d75] [49575884271ddde1] [f582673d] [da64cb83] [02f291c0] [3c00c02a] [885dc26d] [739b043b] [8252272a] [fd77696e] [4c9366bd] [c84d8bbd] [99ea5a05] [83519d5c] [ccc26520] [68df9bc8] [d5c0bc1b] [d5adbcdc] [338be6b7] [e51f7aad] [c3301c6b] [74e94a78] [4f6a9bf5] [91957b99] [4b299d4e] [9d0aaec2] [8b83a276] [43f4e410] [19124ff7] [917601c9] [d692ee58] [4fcabb38] [50fce84a] [fb4c60f4] [7794a001] [6092527b] [28821bfc] [80d6ac45] [4af18f1a] [0b0440bc] [565d3d57] [6242da67] [255efb2f] [99fd42f1] [75a8e2ff] [e0e994fe] [1293d5ce] [328f3f5a] [6425f3ed] [afe0c49f] [b5b93f0d] [2324318b] [c5ecbff4] [55cbd7cf] [af62755a52859f4d] [c3ce177a] [851f74bc] [3e6407d8] [a2d6394e] [dac81aef2774d71e] [e721cd6e] [08f4ed24] [9229c1dd] [5d5782e9] [3060c2c8] [b35e416f] [4659a995] [e4a2aaee] [362baafa] [ab76ca89] [5d315eec] [a1fcab99] [16bfef1d] [a4a9022e] [b99e19fe] [d45708c1] [ea8ff214] [85667418] [a1edaa02] [0f43b581] [fc9416d5] [b1f159c8] [ee98325a] [f3879d41] [fd975df4] [532e36ec] [6d619933] [dbae5824] [b000c3d7] [2c76e727] [e919e25f] [dd0b0920] [7cd7ad70] [d57b7817] [f08e4f6b] [eca9cde6] [d30b0139] [10e2904a] [527dc30f] [c0f200b7] [00b1d08f] [6eb4253d] [a886f40b] [66ee11b9] [57d7c88b] [465c57f9] [191e8fa2] [dcd5d077] [4b7750c1] [11a85e99] [d9704ff0] [3f59b63f] [d6c43bf8] [ed5bd650] [35a56185e9b19e08-2] [1c4b587a] [bccc01a4]
