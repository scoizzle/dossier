# django/contrib/auth/models

- Subject: django/contrib/auth/models (id `262ca7db-cbe1-4dad-8d6e-74e3e6c093dd`)
- Kind: subject
- Budget: 1200 tokens
- Used: 900 tokens
- Facts shown: 22 of 112
- Conflicts: 0
- Gaps: 0

## Facts

- # Otherwise we need to check the backends. return _user_has_perm(self, perm, obj) [5805a065]
- # Otherwise we need to check the backends. return await _auser_has_perm(self, perm, obj) [c8d67702]
- - The "add" permission limits the user's ability to view the "add" form and add an object. - The "change" permission limits a user's ability to view the change list, view the "change" form and change an object. - The "delete" permission limits the ability to delete an object. - The "view" permission limits the ability to view an object. [0cdd396d]
- if extra_fields.get("is_staff") is not True: raise ValueError("Superuser must have is_staff=True.") if extra_fields.get("is_superuser") is not True: raise ValueError("Superuser must have is_superuser=True.") [74057f9f35aa7034]
- return _user_has_module_perms(self, app_label) [1a5ceb02]
- return await _auser_has_module_perms(self, app_label) [67d2cc01]
- return await self._acreate_user(username, email, password, **extra_fields) [7f67e425]
- return self._create_user(username, email, password, **extra_fields) [1a4f6eac]
- @property def groups(self): return self._groups [818ddca5]
- @property def is_anonymous(self): return True [d664a09f]
- @property def is_authenticated(self): return False [85177a76]
- @property def user_perm_str(self): """String representation for the user permission check.""" return f"{self.content_type.app_label}.{self.codename}" [0912c96a]
- @property def user_permissions(self): return self._user_permissions [1b5ead2a]
- A user in a group automatically has all the permissions granted to that group. For example, if the group 'Site editors' has the permission can_edit_home_page, any user in that group will have that permission. [db739366]
- Beyond permissions, groups are a convenient way to categorize users to apply some label, or extended functionality, to them. For example, you could create a group 'Special users', and you could write code that would do special things to those users -- such as giving them access to a members-only portion of your site, or sending them members-only email messages. """ [ccbbb3a2]
- EMAIL_FIELD = "email" USERNAME_FIELD = "username" REQUIRED_FIELDS = ["email"] [8bf89f86]
- Permissions are set globally per type of object, not per specific object instance. It is possible to say "Mary may change news stories," but it's not currently possible to say "Mary may change news stories, but only the ones she created herself" or "Mary may only change news stories that have a certain status or publication date." [33bac716]
- The permission system is used by the Django admin site, but may also be useful in your own code. The Django admin site uses permissions as follows: [aebbe50c]
- The permissions listed above are automatically created for each model. """ [2e405a71]
- Username and password are required. Other fields are optional. """ [4eafd2de423f86fc]
- acreate_superuser.alters_data = True [e548b892]
- objects = GroupManager() [287a21bf]

## Beyond the budget

80 more facts did not fit in the budget: [4357d1ab] [5163ae0a] [f512fb47] [a1180282] [54b48c546b9fcfb8] [746354f4] [62b6230c] [79d52dda] [5a78f9b7] [e7640f09] [d6a1df95] [de5f995c] [f0e51798] [a8a5f86d] [0afb6d10] [62379663e021eaaf-2] [06903379] [9e404c90] [92cddf37] [2a865acc] [ed0bcf9a] [89fb82a2] [ec95a329] [774a5bb2] [0c8d4eff] [e237145c] [5e7b3fdc80e0535c] [1fd802cc] [e74d5cac] [8b0dcc35] [72256fc7] [0eb957a2] [82fbc6a6] [2ba230f1] [98ec562b] [121d6dba2565d21a] [cd46abac] [fecf669b] [2f4b9d76] [206f03db] [cec263a3] [c1fdc22e] [c5dbadae] [4853e66b] [ef279d51] [1f0ddd0f] [474eaaeb] [87a4f35c] [5b436a4b] [6a2645f7] [9bc9ab29] [1d3494b2] [5e2d8c6a] [42e34b00] [04040d22] [f336ab7b] [4f8354ff] [aa2ab63c] [bee62305d24cd880] [3c7b9181] [235e9acf] [e8bd181a] [4de4619a] [66c345d8] [f28430f6] [592d8fb8] [a71a0eb7] [d164f2cc] [d446b010] [fb12bec7] [676f093d] [8487fe82] [c7b21ada] [987a6d2d] [cd81b0cf] [9e41c746] [481c8c0c] [28960877] [0957225fa9318a60] [cf658e73]
