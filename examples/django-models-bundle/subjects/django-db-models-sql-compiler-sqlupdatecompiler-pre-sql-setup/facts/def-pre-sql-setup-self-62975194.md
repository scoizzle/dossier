# Fact 62975194

Store id: 09a914a2-de6a-4d81-accd-739436241703

## Text

```text
def pre_sql_setup(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:57.7443320+00:00`

## Data

```json
{
  "end_line": 2248,
  "entity_kind": "method",
  "parent": "SQLUpdateCompiler",
  "start_line": 2185,
  "symbol": "SQLUpdateCompiler.pre_sql_setup"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2185,"selector":"L2185-L2248","symbol":"SQLUpdateCompiler.pre_sql_setup"}`

## Items

```json
[
  {
    "text": "If the update depends on results from other tables, munge the \"where\" conditions to match the format required for (portable) SQL updates.",
    "locator": {
      "line": 2186
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLUpdateCompiler.pre_sql_setup](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2248,
    "entity_kind": "method",
    "parent": "SQLUpdateCompiler",
    "start_line": 2185,
    "symbol": "SQLUpdateCompiler.pre_sql_setup"
  },
  "id": "09a914a2-de6a-4d81-accd-739436241703",
  "items": [
    {
      "locator": {
        "line": 2186
      },
      "text": "If the update depends on results from other tables, munge the \"where\" conditions to match the format required for (portable) SQL updates."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.7443320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2185,
        "selector": "L2185-L2248",
        "symbol": "SQLUpdateCompiler.pre_sql_setup"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "944c9c43-2040-4588-ad86-21285ce76816",
  "subject_name": "django/db/models/sql/compiler::SQLUpdateCompiler.pre_sql_setup",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_sql_setup(self)"
}
```
