# docs/ref/contrib/admin/actions

- Subject: docs/ref/contrib/admin/actions (id `c2e1f2e2-7ce7-4e8f-a23a-ed02bde13e21`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 23 of 174
- Conflicts: 0
- Gaps: 0

## Facts

- def get_actions(self, request, action_location=ActionLocation.CHANGE_LIST): actions = super().get_actions(request, action_location=action_location) if request.user.username[0].upper() != "J": if "delete_selected" in actions: del actions["delete_selected"] return actions [fefad1e0]
- # Globally disable delete selected admin.site.disable_action("delete_selected") [8cc11bc9]
- # This ModelAdmin will not have delete_selected available class SomeModelAdmin(admin.ModelAdmin): actions = ["some_other_action"] ... [44864a6f]
- # This one will class AnotherModelAdmin(admin.ModelAdmin): actions = ["delete_selected", "a_third_action"] ... [03f68aa2]
- @admin.action def make_inactive(self, request, queryset): queryset.update(is_active=False) [0838e845]
- @admin.action( permissions=["publish"], description="Mark selected stories as published", ) def make_published(self, request, queryset): queryset.update(status="p") [5a2490f1]
- @admin.action(permissions=["change"]) def make_published(self, request, queryset): for obj in queryset: if self.has_change_permission(request, obj=obj): obj.status = "p" obj.save(update_fields=["status"]) [05cf6bc1]
- @admin.action(permissions=["publish"]) def make_published(self, request, queryset): queryset.update(status="p") [d04e9e72]
- A human-readable description of the action to be rendered in the admin. [b08f3a1c]
- A human-readable description of the action used in contexts where plural wording is required. [c71ee10a]
- A list of :class:`ActionLocation` values the admin action can be rendered. [4ba42f67]
- Action descriptions support ``%``-formatting and may include ``'%(verbose_name)s'`` and ``'%(verbose_name_plural)s'`` placeholders. These are replaced with the model’s :attr:`~django.db.models.Options.verbose_name` and :attr:`~django.db.models.Options.verbose_name_plural`. [7a5bb2e2]
- The action function name. [960de050]
- The action function. See :ref:`action-function` for details. [c6d93546]
- The keyword argument ``action_location`` was added. The return type was changed to a dictionary where the keys are action names and the values are :class:`Action` objects, previously the values were ``(function, name, description)`` tuples. [0bee031a]
- The keyword arguments ``description_plural`` and ``location`` were added. [2bf4cf5c]
- actions = ["make_published"] [8bdfbe19]
- admin.site.add_action(export_selected_objects) [cc1055dd]
- class MyModelAdmin(admin.ModelAdmin): ... [27cabe28]
- def __str__(self): return self.title [e11058e0]
- def has_publish_permission(self, request): """Does the user have the publish permission?""" opts = self.opts codename = get_permission_codename("publish", opts) return request.user.has_perm("%s.%s" % (opts.app_label, codename)) [9142a4eb]
- def make_published(self, request, queryset): queryset.update(status="p") [97ff1f8c]
- for obj in queryset: do_something_with(obj) [6295b89e]

## Beyond the budget

144 more facts did not fit in the budget: [f4214c59] [13fbe7fc2a5a9c75-8] [012c9ea9] [31c8b63e] [8f021413] [64f1a494] [62642ae79cdd8ad4] [69458c34] [911ba915] [80d47dc5547c9038] [b46828cc] [2a966a198e13032b-2] [2a966a198e13032b-3] [c059dbb7f93ef187-7] [2e041db2] [0564ac69] [7705716d] [cd73424d] [9ce5569e] [a60bf2e2e676c80b] [5797d68e] [158461e3] [bc37a8c8] [fd242d93] [284ef505] [98ca94c6] [cbbd8e6c] [73519aab] [a7e5499b] [b39dcce8] [265b45df788406c8] [18fded40] [111e14c7] [66031b32] [ef7f6052] [a832229a] [8cf94418] [e25a640b1b2e58eb] [9bfbd9cf] [1317b1f9] [d9df7e1f] [93a38f5d] [4d1080f7] [b772f7e5] [9d7a9b2b38b9a19e] [fb7b26f1d1cd45d5] [7b63a026] [72f2a4eb] [24133552] [caec589c] [482b408b] [5bd45197] [ecd62bb7] [6f9eda1b] [71e51752] [e7a9750b] [e0a348eb] [4af926756c29efa6-9] [5675ed0d] [c94506d4] [e6758c8d] [1a38583b] [73ffc1a1] [cdffb868] [8de4bb82] [b9c97d67] [5e7e5d81] [6509bfe4] [26dee6ef] [982890c8] [0d5ffd3b] [ec0c550817dfd42f] [670dbebc] [89898537] [889cf822] [65128467] [c3c0f269] [3967c5c9] [a1f94339] [942ae6c11625c81c-31] [942ae6c11625c81c-32] [0cf180bcf4ecfab5-2] [0cf180bcf4ecfab5-3] [0cf180bcf4ecfab5-4] [c54b54cb0805732a-14] [992509bf] [8e41546d] [b1fbf47f] [5f78d402] [477ec8a4] [9e2e08ef] [6c6c80ff] [19e7ac0b] [44bf00ec] [f67a507d] [60383e02] [1cde0213] [000ef820] [4c4f54de] [acd6c997] [4a0f3167] [fc7ceaf2] [218f3188] [14f4a55d] [f10c7814] [207eaba8] [28edef836ab93f57-5] [146e6865] [e7d93d45] [818946bc] [ed78a8c2] [0e67e7c4] [976066e3] [efe622e8] [6f160d11] [aefe3d13] [cd37d2ed] [9a413ff7] [0a825bf7] [ade552dd] [1af116bb] [3f23415b] [bc6aaece] [6db4303a] [5686e23e] [b8492f1d] [73700abc] [67fab799] [26a619e3] [b82870b4] [08542ba1] [22986792] [d2b8e4bf] [eee22f73] [578ca24e] [4e16adbd] [291cc924] [fb95f2be] [39ddffd3] [91c4ef25] [2d35a075] [108db846] [4319f732] [57030c54]
