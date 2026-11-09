# django/db/backends/base/features

- Subject: django/db/backends/base/features (id `fa177c71-fb50-4673-a352-f774937e6164`)
- Kind: subject
- Budget: 1200 tokens
- Used: 882 tokens
- Facts shown: 19 of 105
- Conflicts: 0
- Gaps: 0

## Facts

- # A set of dotted paths to tests in Django's test suite that are expected # to fail on this database. django_test_expected_failures = set() # A map of reasons to sets of dotted paths to tests in Django's test suite # that should be skipped for this database. django_test_skips = {} [2a9d33e0]
- # Can a fixture contain forward references? i.e., are # FK constraints checked at the end of transaction, or # at the end of each save operation? supports_forward_references = True [fdcf4549]
- # Can an index be renamed? can_rename_index = False [5f829a23]
- # Can an object be saved without an explicit primary key? supports_unspecified_pk = False [78447a37]
- # Can an object have an autoincrement primary key of 0? allows_auto_pk_0 = True [bcae3804]
- # Can date/datetime lookups be performed using a string? supports_date_lookup_using_string = True [aee42e39]
- # Can datetimes with timezones be used? supports_timezones = True [335aa0f2]
- # Can it create foreign key constraints inline when adding columns? can_create_inline_fk = True [a3aaedca]
- # Can the backend clone databases for parallel test execution? # Defaults to False to allow third-party backends to opt-in. can_clone_databases = False [eca568d8]
- # Can the backend introspect the column order (ASC/DESC) for indexes? supports_index_column_ordering = True [ed30c71c]
- # Can the backend introspect the default value of a column? can_introspect_default = True [ab57bc24]
- # Can we issue more than one ALTER COLUMN clause in an ALTER TABLE? supports_combined_alters = False [a6014c37]
- # Can we roll back DDL in a transaction? can_rollback_ddl = False [082ac7ef]
- # Collation names for use by the Django test suite. test_collations = { "ci": None, # Case-insensitive. "cs": None, # Case-sensitive. "non_default": None, # Non-default. "swedish_ci": None, # Swedish case-insensitive. "virtual": None, # A collation that can be used for virtual columns. } # SQL template override for tests.aggregation.tests.NowUTC test_now_utc_template = None [4e4c21cc]
- # Combinatorial flags supports_select_union = True supports_select_intersection = True supports_select_difference = True supports_slicing_ordering_in_compound = False supports_parentheses_in_compound = True requires_compound_order_by_subquery = False [6ff16198]
- # Confirm support for introspected foreign keys # Every database can do this reliably, except MySQL, # which can't do it for MyISAM tables can_introspect_foreign_keys = True [0177d7c1]
- # DatabaseWrapper methods that should raise an error if accessed in # django.test.SimpleTestCase. disallowed_simple_test_case_connection_methods = [ ("connect", "connections"), ("temporary_connection", "connections"), ("cursor", "queries"), ("chunked_cursor", "queries"), ] [bb8e4cd5]
- # Do we need to NULL a ForeignKey out, or can the constraint check be # deferred can_defer_constraint_checks = False [b3e5ea0e]
- # Does 'a' LIKE 'A' match? has_case_insensitive_like = False [5c0f3024]

## Beyond the budget

85 more facts did not fit in the budget: [f82dfd19] [df95d1a2] [0da97f8f] [73542d46] [a5ddbb05] [b7134793] [45eaf3dd] [a3c56ea7] [bc656367] [e6b5061e] [b83f6fd7] [95a6fa37] [0d5432c8] [d2671aaf] [d1a48700] [ecd62e2b] [aa700f7f] [a7d1b60c] [f2e74c02] [380c8a6b] [77bc68aa] [576aab8e] [0a7bc5cd] [d65c8018] [baee080e] [00857fec] [d02cbdf6] [a49ffe8f] [c76449f4] [4edb7a7e] [971e5f77] [bde4392a] [d26b9758] [8924b297] [46cc2c0f] [033d08e2] [31c2832a] [d3ddad7d] [29d7cd5b] [c58bbb5d] [66d24607] [ebb745f9] [daec9fc7] [6932ab50] [081a8369] [3daff479] [5f15ac99] [44dada8b] [4473ae8a] [04eab70b] [d1e81580] [5ef7c229] [3e8dfac3] [04c721b1] [4bb91e99] [56a11837] [b4989d16] [6a06a800] [5e8bdb35] [9418d4cd] [e55ad731] [c066829c] [88b26d37] [afca17d7] [49e9c9c3] [c013598a] [84779321] [cb230516] [58ed1d8f] [655a5e70] [efb078bb] [448119d7] [a3fe60d7] [2224092f] [9d849f94] [57bcd40c] [9a35b1ba] [6c4a1f1c] [aedcdc0442006877-3] [f0a7ddc935b65180-2] [a7ce7e8f] [028d31d8] [5de769a0] [9cd290f1] [acb6f3e2]
