# django/contrib/auth/backends

- Subject: django/contrib/auth/backends (id `bde983e7-07ad-4d71-a0c7-c1ad83b78a72`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 15 of 58
- Conflicts: 0
- Gaps: 0

## Facts

- # Note that this could be accomplished in one try-except clause, but # instead we use get_or_create when creating unknown users since it has # built-in safeguards for multiple threads. if self.create_unknown_user: user, created = UserModel._default_manager.get_or_create( **{UserModel.USERNAME_FIELD: username} ) else: try: user = UserModel._default_manager.get_by_natural_key(username) except UserModel.DoesNotExist: pass user = self.configure_user(request, user, created=created) return user if self.user_can_authenticate(user) else None [f07071a3]
- By default, return the user unmodified. """ return user [c1f62381]
- By default, return the username unchanged. """ return username [3984d2dc]
- Return None if ``create_unknown_user`` is ``False`` and a ``User`` object with the given username is not found in the database. """ if not remote_user: return created = False user = None username = self.clean_username(remote_user) [ee1a0416]
- if await acheck_password_with_timing_attack_mitigation( user, password ) and self.user_can_authenticate(user): return user [efd55ef3]
- if check_password_with_timing_attack_mitigation( user, password ) and self.user_can_authenticate(user): return user [a623b01d]
- if obj is not None: return UserModel._default_manager.none() [e94be3cb]
- perm_cache_name = "_%s_perm_cache" % from_name if not hasattr(user_obj, perm_cache_name): if user_obj.is_superuser: perms = Permission.objects.all() else: perms = getattr(self, "_get_%s_permissions" % from_name)(user_obj) perms = perms.values_list("content_type__app_label", "codename").order_by() setattr( user_obj, perm_cache_name, {"%s.%s" % (ct, name) async for ct, name in perms}, ) return getattr(user_obj, perm_cache_name) [9e2b3e50]
- permission_q = Q(group__user=OuterRef("pk")) | Q(user=OuterRef("pk")) if isinstance(perm, Permission): permission_q &= Q(pk=perm.pk) else: permission_q &= Q(codename=codename, content_type__app_label=app_label) [2fd7e217]
- return UserModel._default_manager.filter(user_q) [b2f5d000]
- user_q = Exists(Permission.objects.filter(permission_q)) if include_superusers: user_q |= Q(is_superuser=True) if is_active is not None: user_q &= Q(is_active=is_active) [9ae27f91]
- # Create a User object if not already in the database? create_unknown_user = True [77706357]
- @sensitive_variables("password") async def aauthenticate(self, request, username=None, password=None, **kwargs): if username is None: username = kwargs.get(UserModel.USERNAME_FIELD) if username is None or password is None: return try: user = await UserModel._default_manager.aget_by_natural_key(username) except UserModel.DoesNotExist: user = None [e1725c97]
- @sensitive_variables("password") def authenticate(self, request, username=None, password=None, **kwargs): if username is None: username = kwargs.get(UserModel.USERNAME_FIELD) if username is None or password is None: return try: user = UserModel._default_manager.get_by_natural_key(username) except UserModel.DoesNotExist: user = None [2ad236b4]
- async def aauthenticate(self, request, **kwargs): return await sync_to_async(self.authenticate)(request, **kwargs) [d0073321]

## Beyond the budget

38 more facts did not fit in the budget: [a50dacf9] [89e0a5f7] [78b9039e] [219952b2] [8f21a94e] [54938a23] [18fa69ea] [f1ac8696] [645708b7] [bb003043] [dfe838b2] [15ffbdc9] [21d64d9f] [d186b7af] [87c542cf] [4db0a6ba] [3962fa19] [ff7fccdb] [faa0b205] [7aea0538] [159a4f37] [57b455db] [c8ea7f9a] [1ef0c525] [9ece32ea] [9093d043] [6ede519d] [fc0e72ac] [c77e3c8d] [b5c803a7] [890d18efd7375f44] [008f21c1] [e1776cb3] [2e09d870] [9a5b897c] [b61875f9] [770890ad88958a4c-2] [af643d3f]
