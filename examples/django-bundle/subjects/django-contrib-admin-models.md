# django/contrib/admin/models

- Subject: django/contrib/admin/models (id `7b7a44c9-8f34-4617-8b05-37d111fa4f45`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 14 of 24
- Conflicts: 0
- Gaps: 0

## Facts

- elif "changed" in sub_message: sub_message["changed"]["fields"] = get_text_list( [ gettext(field_name) for field_name in sub_message["changed"]["fields"] ], gettext("and"), ) if "name" in sub_message["changed"]: sub_message["changed"]["name"] = gettext( sub_message["changed"]["name"] ) messages.append( gettext("Changed {fields} for {name} “{object}”.").format( **sub_message["changed"] ) ) else: messages.append( gettext("Changed {fields}.").format( **sub_message["changed"] ) ) [ffd7941f]
- elif "deleted" in sub_message: sub_message["deleted"]["name"] = gettext( sub_message["deleted"]["name"] ) messages.append( gettext("Deleted {name} “{object}”.").format( **sub_message["deleted"] ) ) [ee47051f]
- change_message = " ".join(msg[0].upper() + msg[1:] for msg in messages) return change_message or gettext("No fields changed.") else: return self.change_message [658b70bf]
- if len(log_entry_list) == 1: instance = log_entry_list[0] instance.save() if single_object: return instance return [instance] [30bc5bdb]
- log_entry_list = [ self.model( user_id=user_id, content_type_id=ContentType.objects.get_for_model( obj, for_concrete_model=False ).id, object_id=obj.pk, object_repr=str(obj)[:200], action_flag=action_flag, change_message=change_message, ) for obj in queryset ] [7ff364b5]
- return gettext("LogEntry Object") [534c7813]
- return self.model.objects.bulk_create(log_entry_list) [5e3c0256]
- class Meta: verbose_name = _("log entry") verbose_name_plural = _("log entries") db_table = "django_admin_log" ordering = ["-action_time"] [f30b71a2]
- def __repr__(self): return str(self.action_time) [e8cb395f]
- def __str__(self): if self.is_addition(): return gettext("Added “%(object)s”.") % {"object": self.object_repr} elif self.is_change(): return gettext("Changed “%(object)s” — %(changes)s") % { "object": self.object_repr, "changes": self.get_change_message(), } elif self.is_deletion(): return gettext("Deleted “%(object)s.”") % {"object": self.object_repr} [92aca109]
- def get_admin_url(self): """ Return the admin URL to edit the object represented by this log entry. """ if self.content_type and self.object_id: url_name = "admin:%s_%s_change" % ( self.content_type.app_label, self.content_type.model, ) try: return reverse(url_name, args=(quote(self.object_id),)) except NoReverseMatch: pass return None [4ac6c916]
- def get_change_message(self): """ If self.change_message is a JSON structure, interpret it as a change string, properly translated. """ if self.change_message and self.change_message[0] == "[": try: change_message = json.loads(self.change_message) except json.JSONDecodeError: return self.change_message messages = [] for sub_message in change_message: if "added" in sub_message: if sub_message["added"]: sub_message["added"]["name"] = gettext( sub_message["added"]["name"] ) messages.append( gettext("Added {name} “{object}”.").format( **sub_message["added"] ) ) else: messages.append(gettext("Added.")) [5084db24]
- def get_edited_object(self): """Return the edited object represented by this log entry.""" return self.content_type.get_object_for_this_type(pk=self.object_id) [1d32897d]
- objects = LogEntryManager() [8feec33d]

## Beyond the budget

10 more facts did not fit in the budget: [f8da17d6] [3da3e178] [5db6e966] [aa8da647] [4212baa1] [49c23151] [fac44db9] [d6be63b8] [8a258693] [5766bf5bad9de4d2-2]
