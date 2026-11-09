# django/db/backends/oracle/creation

- Subject: django/db/backends/oracle/creation (id `c5593e3a-9e1e-415c-a6d0-ccdae49e801b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 896 tokens
- Facts shown: 6 of 38
- Conflicts: 0
- Gaps: 0

## Facts

- if self._test_user_create(): if verbosity >= 1: self.log("Creating test user...") try: self._create_test_user(cursor, parameters, verbosity, keepdb) except Exception as e: if "ORA-01920" not in str(e): # All errors except "user already exists" cancel tests self.log("Got an error creating the test user: %s" % e) sys.exit(2) if not autoclobber: confirm = input( "It appears the test user, %s, already exists. Type " "'yes' to delete it, or 'no' to cancel: " % parameters["user"] ) if autoclobber or confirm == "yes": try: if verbosity >= 1: self.log("Destroying old test user...") self._destroy_test_user(cursor, parameters, verbosity) if verbosity >= 1: self.log("Creating test user...") self._create_test_user( cursor, parameters, verbosity, keepdb ) except Exception as e: self.log("Got an error recreating the test user: %s" % e) sys.exit(2) else: self.log("Tests cancelled.") sys.exit(1) # Done with main user -- test user and tablespaces created. self._maindb_connection.close() self._switch_to_test_user(parameters) return self.connection.settings_dict["NAME"] [ad01f1c9]
- Oracle doesn't have the concept of separate databases under the same user, so a separate user is used; see _create_test_db(). The main user is also needed for cleanup when testing is completed, so save its credentials in the SAVED_USER/SAVED_PASSWORD key in the settings dict. """ real_settings = settings.DATABASES[self.connection.alias] real_settings["SAVED_USER"] = self.connection.settings_dict["SAVED_USER"] = ( self.connection.settings_dict["USER"] ) real_settings["SAVED_PASSWORD"] = self.connection.settings_dict[ "SAVED_PASSWORD" ] = self.connection.settings_dict["PASSWORD"] real_test_settings = real_settings["TEST"] test_settings = self.connection.settings_dict["TEST"] real_test_settings["USER"] = real_settings["USER"] = test_settings["USER"] = ( self.connection.settings_dict["USER"] ) = parameters["user"] real_settings["PASSWORD"] = self.connection.settings_dict["PASSWORD"] = ( parameters["password"] ) [3eedc875]
- @cached_property def _maindb_connection(self): """ This is analogous to other backends' `_nodb_connection` property, which allows access to an "administrative" connection which can be used to manage the test databases. For Oracle, the only connection that can be used for that purpose is the main (non-test) connection. """ settings_dict = settings.DATABASES[self.connection.alias] user = settings_dict.get("SAVED_USER") or settings_dict["USER"] password = settings_dict.get("SAVED_PASSWORD") or settings_dict["PASSWORD"] settings_dict = {**settings_dict, "USER": user, "PASSWORD": password} DatabaseWrapper = type(self.connection) return DatabaseWrapper(settings_dict, alias=self.connection.alias) [8c4fd7bb]
- def _destroy_test_user(self, cursor, parameters, verbosity): if verbosity >= 2: self.log("_destroy_test_user(): user=%s" % parameters["user"]) self.log("Be patient. This can take some time...") statements = [ "DROP USER %(user)s CASCADE", ] self._execute_statements(cursor, statements, parameters, verbosity) [a9bf9509]
- def _execute_statements( self, cursor, statements, parameters, verbosity, allow_quiet_fail=False ): for template in statements: stmt = template % parameters if verbosity >= 2: print(stmt) try: cursor.execute(stmt) except Exception as err: if (not allow_quiet_fail) or verbosity >= 2: self.log("Failed (%s)" % (err)) raise [07fd660e]
- import sys [6b0cb2be5ea1bc3c-5]

## Beyond the budget

27 more facts did not fit in the budget: [2eecc8f0] [5c5c1755] [7ad3deea] [fe1d16c7] [edfb0756] [62407468] [48b3f342] [b6295730] [b8f3891c] [e37dbc91] [d0f3c4ae] [b82f6481] [57f4080f] [2d79b4b2] [fb9deb72] [3f6bf60b] [8ee6c71f] [373aba98] [e10dd6d9] [51501e39] [670220ce] [d20c3fd1] [ead0e3b1] [602d83b7] [439b26bb] [1f5e26d1] [9825cfe7]
