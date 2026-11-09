# django/test/runner

- Subject: django/test/runner (id `17eed696-a8c8-4259-a6bb-c6fc8ce6753b`)
- Kind: subject
- Budget: 1200 tokens
- Used: 889 tokens
- Facts shown: 14 of 165
- Conflicts: 0
- Gaps: 0

## Facts

- tests = list(self.subsuites[subsuite_index]) for event in events: self.handle_event(result, tests, event) [5461b99c]
- try: subsuite_index, events = test_results.next(timeout=0.1) except multiprocessing.TimeoutError as err: if counter.value < 0: err.add_note("ERROR: _init_worker failed, see prior traceback") raise continue except StopIteration: pool.close() break [91afdb2a]
- if extra_sql := getattr(record, "sql", None): if extra_sql == sql: record.sql = formatted_sql else: record.sql = format_sql(extra_sql) [0c228cf0]
- pool.join() [56d6c780]
- sql = None formatted_sql = None if args := record.args: if isinstance(args, tuple) and len(args) > 1 and (sql := args[1]): record.args = (args[0], formatted_sql := format_sql(sql), *args[2:]) elif isinstance(record.args, dict) and (sql := record.args.get("sql")): record.args["sql"] = formatted_sql = format_sql(sql) [b7d78cbd]
- while True: if result.shouldStop: pool.terminate() break [cdf1616c]
- # If a module, or "module.ClassName[.method_name]", just run those. if not os.path.exists(label_as_path): with self.load_with_patterns(): tests = self.test_loader.loadTestsFromName(label) if tests.countTestCases(): return tests # Try discovery if "label" is a package or directory. is_importable, is_package = try_importing(label) if is_importable: if not is_package: return tests elif not os.path.isdir(label_as_path): if os.path.exists(label_as_path): assert tests is None raise RuntimeError( f"One of the test labels is a path to a file: {label!r}, " f"which is not supported. Use a dotted module name or " f"path to a directory instead." ) return tests [b9aea8b3]
- # Make unittest forget the top-level dir it calculated from this run, # to support running tests from two different top-levels. self.test_loader._top_level_dir = None return tests [0349391e]
- # Put the failures detected at load time first for quicker feedback. # _FailedTest objects include things like test modules that couldn't be # found or that couldn't be loaded due to syntax errors. test_types = (unittest.loader._FailedTest, *self.reorder_by) all_tests = list( reorder_tests( all_tests, test_types, shuffler=self._shuffler, reverse=self.reverse, ) ) self.log("Found %d test(s)." % len(all_tests)) suite = self.test_suite(all_tests) [8169baa2]
- - pass back numeric indexes in self.subsuites instead of tests - make tracebacks picklable with tblib, if available [8a9ad864]
- Even with tblib, errors may still occur for dynamically created exception classes which cannot be unpickled. """ self.initialize_suite() counter = multiprocessing.Value(ctypes.c_int, 0) args = [ (self.runner_class, index, subsuite, self.failfast, self.buffer) for index, subsuite in enumerate(self.subsuites) ] # Don't buffer in the main process to avoid error propagation issues. result.buffer = False [325ece92]
- Return an identifier of each TestCase with its result in order to use imap_unordered to show results as soon as they're available. [0ff3e5ec]
- Test labels should be dotted Python paths to test modules, test classes, or test methods. [24840cf6]
- To minimize pickling errors when getting results from workers: [85c55082]

## Beyond the budget

151 more facts did not fit in the budget: [e571cabd] [1ca54bd2] [703b1141] [83ea8eb7] [100a8099] [0174e2e1] [84b4c048] [f9da3879] [c4c11faf] [b46f904a] [e6d2cf0b52c4ebca-5] [768f3083] [e91aaddb] [465af762] [be15f478] [261aab71] [44472ba0] [5c7fc076] [f88c441a] [d80706ca] [d4dc718f] [b76acabe] [7c914f57] [d6d3dec5] [73a779ff] [cd64f053] [3a2fd9f7] [b5a0eee0] [5c1f5077] [70a5bd9c] [d6e4bd85] [1490964c] [906186f9] [d4d34096] [f6d76e8d3390a9c2] [685d8ef1] [d1330eb7] [f3bbf36e] [1d77bf8b] [b6bdfb80] [ea14d3d8] [44dc033c] [73602251] [3d3ab8c5] [efadf755] [61158365] [91439d2f] [1910a9a8] [356d9595] [8578dfde] [3000afe7] [6bf8b986] [a2ccda74] [0cf9aaf1] [0c02b96b] [c383e1ed] [b845b1bd] [4db61926] [8ad2f408] [7e91b458] [e41418ff] [05f81975] [dbff95bb] [57eedb6b] [35b2d251] [2eadc487] [46c2455f] [02012cbe] [daaaedcb] [d747f465] [6fd5e49a] [ca67972e] [a5828acf] [7edd56bd] [40875ab4] [3eeeb768] [6b92a3b4] [c25b592d] [f80a86a8] [07f42468] [00dd0b6e] [7b3e73e8] [55f86be7] [1d60ceb4] [532aacdf] [34b2158f] [e5e85395] [e15eb328] [8252e8b0] [fda70b02] [66611d70] [9dcb433d] [3c289abc] [b6792d55] [de58a9d5] [6c6534f7] [73d6c40d] [d8636da7] [5f937007] [c3d44b98] [1d59bd10] [5020a5fa] [4c3f90e1] [569b5084] [be797619] [a5794537] [2936f2e2] [327e340a] [b754cff5] [725b1538] [6414c967] [32f577ba] [23c3ebfc] [772c22fa] [f3944c54] [45243813] [c6779be4] [b9c6806a] [a4816afc] [47ede67f] [f4603355] [5c7e6782] [88325ea5] [b0a153ef] [652e9649] [628b118d] [5fa73bce] [e2151c72] [131185bd] [ea857db6] [5ba0f3af] [baa1f0c9] [6939d5a5] [5f9f02c6] [a875baae] [ec9a7f07] [cee361b8] [01163b67] [89f0d604] [dbafd4a9] [4e2c297f] [0173f6c8] [b0242cb9] [fe8f98f1] [9735352f] [abfd8179] [930e8588] [b5b480b8] [b00cec79] [a3a1ebc9e0fd1111] [a3a1ebc9e0fd1111-2]
