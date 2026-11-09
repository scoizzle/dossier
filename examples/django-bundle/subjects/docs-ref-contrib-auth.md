# docs/ref/contrib/auth

- Subject: docs/ref/contrib/auth (id `3a5f9a92-af75-4359-814e-8a3bd2b6cbec`)
- Kind: subject
- Budget: 1200 tokens
- Used: 891 tokens
- Facts shown: 26 of 243
- Conflicts: 0
- Gaps: 0

## Facts

- Users having an unusable password will not able to request a password reset email via :class:`~django.contrib.auth.views.PasswordResetView`. [f11f21dd]
- group.permissions.set([permission_list]) group.permissions.add(permission, permission, ...) group.permissions.remove(permission, permission, ...) group.permissions.clear() [405522f1]
- *Asynchronous version*: ``aauthenticate()`` [1bbc357fe02502af]
- *Asynchronous version*: ``aauthenticate()`` [1bbc357fe02502af-2]
- *Asynchronous version*: ``acheck_password()`` [75235631]
- *Asynchronous version*: ``aconfigure_user()`` [93a6d96d]
- *Asynchronous version*: ``acreate_superuser()`` [234ae7af]
- *Asynchronous version*: ``acreate_user()`` [5cb44ea2]
- *Asynchronous version*: ``aget_all_permissions()`` [5201ea4856154b98]
- *Asynchronous version*: ``aget_group_permissions()`` [6d1ced41a5b69d26]
- *Asynchronous version*: ``aget_user_permissions()`` [9f52db1ad27f2df5]
- *Asynchronous version*: ``ahas_module_perms()`` [8040fa2344761cd7]
- *Asynchronous version*: ``ahas_perm()`` [f8bab9fa8f95153d]
- *Asynchronous version*: ``ahas_perms()`` [45ced810]
- .. admonition:: Password reset restriction [8c6039fb]
- .. versionadded:: 6.1 [0cf180bcf4ecfab5-6]
- A datetime of the user's last login. [fe3b8037]
- Boolean. Allows this user to access the admin site. [cc6098f8]
- Boolean. Marks this user account as active. We recommend that you set this flag to ``False`` instead of deleting accounts. That way, if your applications have any foreign keys to users, the foreign keys won't break. [8f777d61]
- Boolean. Treats this user as having all permissions without assigning any permission to it in particular. [157e2598]
- Configures the user on each authentication attempt. This method is called immediately after fetching or creating the user being authenticated, and can be used to perform custom setup actions, such as setting the user's groups based on attributes in an LDAP directory. Returns the user object. When fetching or creating an user is called from a synchronous context, ``configure_user`` is called, ``aconfigure_user`` is called from async contexts. [8faef4fe]
- Creates, saves and returns a :class:`~django.contrib.auth.models.User`. [25bac5ff]
- If ``backend`` is passed in and it's defined in :setting:`AUTHENTICATION_BACKENDS`, then this method will use it. Otherwise, it will use the ``backend`` in :setting:`AUTHENTICATION_BACKENDS`, if there is only one, or raise an exception. [3e4049d4]
- If ``include_superusers`` is ``True`` (default), the result will include superusers. [9a2a77e0517f43c8]
- If ``is_active`` is ``True`` (default), returns only active users, or if ``False``, returns only inactive users. Use ``None`` to return all users irrespective of active state. [5cc81ef77bca09f0]
- If ``obj`` is passed in, only returns the group permissions for this specific object. [41b0e519]

## Beyond the budget

185 more facts did not fit in the budget: [e5ff14fb] [cf6cef61] [9c0110fd] [8a155ad5] [08616a40] [36644b77] [54ff224a] [233bdf60] [b01db6e1e92b2187] [79b9ebbc] [bd087e64] [9fb99ffe] [a728f0d7] [104982cd] [4a62c3b0] [163c782a] [c22aca53] [a902b204] [8d1b0cdb] [d74973a1] [5b642ad3] [ec03a409] [1dec0ce9] [bca64deb] [2a319fd2] [26671a46] [69a98264] [2e51b419] [5b863427] [ad2e5ca8573f51b0] [b0050de7] [5281114d] [61bfb8e1] [96ac8e6e] [5d242804] [151dcd6b] [d2d95068] [82d32714] [6a748359] [b373bd37] [de4c130a] [cac1ddae] [244541d5] [ede449a7] [538af98b] [a792d592] [8d014563] [8dbb0ab0] [5a441810] [7011ba6f] [7f3d3b39] [3234098d] [c52e5167] [79841038] [b47c2a14] [cff7a85c] [915bc399] [06c14326] [91852de0] [fa5a000fe8128d0a] [41543a9a] [210f357f] [fcd1c44c] [6e5bab06425e4544-2] [8f038e65] [00fe4894] [e6c53127] [289308a0] [2fdd785b] [d963093c] [b6b09d69] [790176da] [ec1f7b71] [74df5bc7] [6dceedae] [bfda4074] [80d47dc5547c9038-2] [80d47dc5547c9038-3] [0fb31839] [7049d31a] [ce4c0d2a] [70ae121c] [fa7730b9] [8f72058b] [6551496c] [c28af344] [e21e82b7] [538ef255] [fea9cc9f] [bb8bd44f] [ef08f223] [98690fb8] [3116e265] [5c76d480] [399d9cf2] [c974f6c8] [4b058df9] [77418b1e] [cc1f4b21] [d5dc63ce] [4bc904ec] [1e9bbd0f] [383ca098] [cf52ace9] [763483f47ffd3ef4] [0863edda] [df41d0fa] [65a3b5e9] [29c4ea7a] [2b63cda8] [9f2813d8] [8a8cc8e9] [5152dcb0] [f0f31d135f4abac9] [00ebf080] [6b73cb5a] [b74915be] [06967ed6] [3c1535fc] [6d401c8a] [998482c5] [6042bae5] [5444ce32] [95d1e892] [6f07d528] [e1f90c7c] [cf4222f5] [c1e8bed9] [0192d874] [8aaa6f70] [feb45decf51be48a] [6f2270a3] [cb0b6e0a] [2fae9853] [9eba4a03] [4b58d8f2] [0b82da7b] [c91ceeef] [7efd4ce5] [1178cd45] [09f67a48] [14f7f02f] [31ae314a] [c0260dfc] [44981029] [c3979c0b] [f112e305] [e6905dba41d133d2] [53a9404f] [ced6e1fb3b3a92de] [972001ab] [31ae6472] [73501427] [be1477fe1d4b1389] [35a23ede] [a86a142a] [ba481371] [9d655bbc] [9dd136d2] [1d39ceeb] [73ce76c0] [2072a494] [2b80713d] [bf486599] [bb91fb20711fda29-2] [cf5c48e6] [bf79f7b6] [063271e57f785225] [063271e57f785225-2] [063271e57f785225-3] [a750572f] [d6cf3f56] [c53dec76] [d5882157dc780592-3] [d5882157dc780592-4] [f06f536c] [e1d6b9d4] [eb8b8e4c] [958abaa0] [1e94d262] [fe9aceff] [39e8c061] [7acbecd3] [786049e2] [aa932d2b]
