# Fact 62975194

Store id: 73834c2d-d920-418a-950f-aed3f2b85c8a

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
- posted_at: `2026-11-09T23:32:06.0989210+00:00`

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
  "id": "73834c2d-d920-418a-950f-aed3f2b85c8a",
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
    "posted_at": "2026-11-09T23:32:06.0989210+00:00"
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
  "subject_id": "43ab3735-7a71-444b-bb2c-cde650eb70e9",
  "subject_name": "django/db/models/sql/compiler::SQLUpdateCompiler.pre_sql_setup",
  "tags": [
    "entity:method"
  ],
  "text": "def pre_sql_setup(self)"
}
```
