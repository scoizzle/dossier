# django/db/models/deletion

- Subject: django/db/models/deletion (id `9f399c16-1738-4755-ae48-fed8027fd7c3`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 12 of 59
- Conflicts: 0
- Gaps: 0

## Facts

- if not model._meta.auto_created: for obj in instances: signals.post_delete.send( sender=model, instance=obj, using=self.using, origin=self.origin, ) [8f577b9f]
- # delete instances for model, instances in self.data.items(): query = sql.DeleteQuery(model) pk_list = [obj.pk for obj in instances] count = query.delete_batch(pk_list, self.using) if count: deleted_counter[model._meta.label] += count [110bf3d3]
- # fast deletes for qs in self.fast_deletes: count = qs._raw_delete(using=self.using) if count: deleted_counter[qs.model._meta.label] += count [95963696]
- # reverse instance collections for instances in self.data.values(): instances.reverse() [4f6f6f5d]
- # update fields for (field, value), instances_list in self.field_updates.items(): updates = [] objs = [] for instances in instances_list: if ( isinstance(instances, models.QuerySet) and instances._result_cache is None ): updates.append(instances) else: objs.extend(instances) if updates: combined_updates = reduce(or_, updates) combined_updates.update(**{field.name: value}) if objs: model = objs[0].__class__ query = sql.UpdateQuery(model) query.update_batch( list({obj.pk for obj in objs}), {field.name: value}, self.using ) [19102fe9]
- # Optimize for the case with a single obj and no dependencies if len(self.data) == 1 and len(instances) == 1: instance = list(instances)[0] if self.can_fast_delete(instance): with transaction.mark_for_rollback_on_error(self.using): count = sql.DeleteQuery(model).delete_batch( [instance.pk], self.using ) setattr(instance, model._meta.pk.attname, None) return count, {model._meta.label: count} [a97234df]
- # Tracks deletion-order dependency for databases without transactions # or ability to defer constraint checks. Only concrete model classes # should be included, as the dependencies exist only between actual # database tables; proxy models are represented here by their concrete # parent. self.dependencies = defaultdict(set) # {model: {models}} [0e428ff0]
- # if possible, bring the models in an order suitable for databases that # don't support transactions or cannot defer constraint checks until # the end of a transaction. self.sort() # number of objects deleted for each model label deleted_counter = Counter() [e5305022]
- If 'fail_on_restricted' is False, error won't be raised even if it's prohibited to delete such objects due to RESTRICT, that defers restricted object checking in recursive calls where the top-level call may need to collect more objects to determine whether restricted ones can be deleted. """ if self.can_fast_delete(objs): self.fast_deletes.append(objs) return new_objs = self.add( objs, source, nullable, reverse_dependency=reverse_dependency ) if not new_objs: return [afff7308]
- If 'keep_parents' is True, data of parent model's will be not deleted. [7ca5ca3d]
- If 'reverse_dependency' is True, 'source' will be deleted before the current model, rather than after. (Needed for cascading to parent models, the one case in which the cascade follows the forwards direction of an FK rather than the reverse direction.) [300490d7]
- If the call is the result of a cascade, 'source' should be the model that caused it and 'nullable' should be set to True, if the relation can be null. [910706b2]

## Beyond the budget

46 more facts did not fit in the budget: [32320fc6] [7aa26003] [abbc234d] [1331f808] [367aa431] [75a3d00c] [c63fc6e1] [dde22cc1] [f529bcae] [e3e55ab2] [4d245b88] [4151e272] [e7ee0058] [9207882d] [7bd085dc] [99edbf9a] [f472e2ab] [b8ee326c] [7294f979] [fdaf9e2b] [8d471067] [2ef03137] [7c8a8089] [79fbcf0d] [28c3eab5] [c9ac42c3] [31ebaa40] [6ad07797f4838346-10] [0b3ee881] [4ec9df7c] [a4fcbf08] [9ba64a0d] [2a61897e] [3fbc65e1] [45224dbd] [606edf88] [82282792] [a4b8f8c7] [6b1f613a] [278747d2] [f66d9cd9] [cedb1194] [6b05742b] [10d1503c] [c6447d88] [97a4b5bf]
