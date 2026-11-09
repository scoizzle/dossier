# django/contrib/auth/backends

- Subject: django/contrib/auth/backends (id `7ff7e0d7-ef2c-4e53-8cc8-0a1615452ed7`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 2850 tokens
- Facts shown: 53 of 58
- Conflicts: 0
- Gaps: 0

## Highlights

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

## All facts

- [a50dacf9] By default, the ``authenticate`` method creates ``User`` objects for usernames that don't already exist in the database. Subclasses can disable this behavior by setting the ``create_unknown_user`` attribute to ``False``. """
- [89e0a5f7] async def _aget_permissions(self, user_obj, obj, from_name): """See _get_permissions().""" if not user_obj.is_active or user_obj.is_anonymous or obj is not None: return set()
- [78b9039e] async def aauthenticate(self, request, remote_user): """See authenticate().""" if not remote_user: return created = False user = None username = self.clean_username(remote_user)
- [219952b2] async def aconfigure_user(self, request, user, created=True): """See configure_user()""" return await sync_to_async(self.configure_user)(request, user, created)
- [8f21a94e] async def aget_all_permissions(self, user_obj, obj=None): return { *await self.aget_user_permissions(user_obj, obj=obj), *await self.aget_group_permissions(user_obj, obj=obj), }
- [54938a23] async def aget_group_permissions(self, user_obj, obj=None): """See get_group_permissions().""" return await self._aget_permissions(user_obj, obj, "group")
- [18fa69ea] async def aget_group_permissions(self, user_obj, obj=None): return await sync_to_async(self.get_group_permissions)(user_obj, obj)
- [f1ac8696] async def aget_user(self, user_id): return await sync_to_async(self.get_user)(user_id)
- [645708b7] async def aget_user(self, user_id): try: user = await UserModel._default_manager.aget(pk=user_id) except UserModel.DoesNotExist: return None return user if self.user_can_authenticate(user) else None
- [bb003043] async def ahas_module_perms(self, user_obj, app_label): """See has_module_perms()""" return user_obj.is_active and any( perm[: perm.index(".")] == app_label for perm in await self.aget_all_permissions(user_obj) )
- [dfe838b2] async def ahas_perm(self, user_obj, perm, obj=None): return perm in await self.aget_all_permissions(user_obj, obj)
- [15ffbdc9] async def ahas_perm(self, user_obj, perm, obj=None): return user_obj.is_active and await super().ahas_perm(user_obj, perm, obj=obj)
- [21d64d9f] def _get_group_permissions(self, user_obj): return Permission.objects.filter(group__in=user_obj.groups.all())
- [d186b7af] def _get_permissions(self, user_obj, obj, from_name): """ Return the permissions of `user_obj` from `from_name`. `from_name` can be either "group" or "user" to return permissions from `_get_group_permissions` or `_get_user_permissions` respectively. """ if not user_obj.is_active or user_obj.is_anonymous or obj is not None: return set()
- [87c542cf] def _get_user_permissions(self, user_obj): return user_obj.user_permissions.all()
- [4db0a6ba] def authenticate(self, request, remote_user): """ The username passed as ``remote_user`` is considered trusted. Return the ``User`` object with the given username. Create a new ``User`` object if ``create_unknown_user`` is ``True``.
- [3962fa19] def clean_username(self, username): """ Perform any cleaning on the "username" prior to using it to get or create the user object. Return the cleaned username.
- [ff7fccdb] def configure_user(self, request, user, created=True): """ Configure a user and return the updated user.
- [faa0b205] def get_all_permissions(self, user_obj, obj=None): if not user_obj.is_active or user_obj.is_anonymous or obj is not None: return set() if not hasattr(user_obj, "_perm_cache"): user_obj._perm_cache = super().get_all_permissions(user_obj) return user_obj._perm_cache
- [7aea0538] def get_all_permissions(self, user_obj, obj=None): return { *self.get_user_permissions(user_obj, obj=obj), *self.get_group_permissions(user_obj, obj=obj), }
- [159a4f37] def get_group_permissions(self, user_obj, obj=None): """ Return a set of permission strings the user `user_obj` has from the groups they belong. """ return self._get_permissions(user_obj, obj, "group")
- [57b455db] def get_group_permissions(self, user_obj, obj=None): return set()
- [c8ea7f9a] def get_user(self, user_id): return None
- [1ef0c525] def get_user(self, user_id): try: user = UserModel._default_manager.get(pk=user_id) except UserModel.DoesNotExist: return None return user if self.user_can_authenticate(user) else None
- [9ece32ea] def get_user_permissions(self, user_obj, obj=None): """ Return a set of permission strings the user `user_obj` has from their `user_permissions`. """ return self._get_permissions(user_obj, obj, "user")
- [9093d043] def has_module_perms(self, user_obj, app_label): """ Return True if user_obj has any permissions in the given app_label. """ return user_obj.is_active and any( perm[: perm.index(".")] == app_label for perm in self.get_all_permissions(user_obj) )
- [6ede519d] def has_perm(self, user_obj, perm, obj=None): return perm in self.get_all_permissions(user_obj, obj=obj)
- [fc0e72ac] def has_perm(self, user_obj, perm, obj=None): return user_obj.is_active and super().has_perm(user_obj, perm, obj=obj)
- [c77e3c8d] def user_can_authenticate(self, user): """ Reject users with is_active=False. Custom user models that don't have that attribute are allowed. """ return getattr(user, "is_active", True)
- [b5c803a7] def with_perm(self, perm, is_active=True, include_superusers=True, obj=None): """ Return users that have permission "perm". By default, filter out inactive users and include superusers. """ if isinstance(perm, str): try: app_label, codename = perm.split(".") except ValueError: raise ValueError( "Permission name should be in the form " "app_label.permission_codename." ) elif not isinstance(perm, Permission): raise TypeError( "The `perm` argument must be a string or a permission instance." )
- [890d18efd7375f44] UserModel = get_user_model()
- [008f21c1] class AllowAllUsersModelBackend(ModelBackend): def user_can_authenticate(self, user): return True
- [e1776cb3] class AllowAllUsersRemoteUserBackend(RemoteUserBackend): def user_can_authenticate(self, user): return True
- [2e09d870] class BaseBackend: def authenticate(self, request, **kwargs): return None
- [9a5b897c] class ModelBackend(BaseBackend): """ Authenticates against settings.AUTH_USER_MODEL. """
- [b61875f9] class RemoteUserBackend(ModelBackend): """ This backend is to be used in conjunction with the ``RemoteUserMiddleware`` found in the middleware module of this package, and is used when the server is handling authentication outside of Django.
- [770890ad88958a4c-2] from asgiref.sync import sync_to_async
- [af643d3f] from django.contrib.auth import ( acheck_password_with_timing_attack_mitigation, check_password_with_timing_attack_mitigation, get_user_model, ) from django.contrib.auth.models import Permission from django.db.models import Exists, OuterRef, Q from django.views.decorators.debug import sensitive_variables
