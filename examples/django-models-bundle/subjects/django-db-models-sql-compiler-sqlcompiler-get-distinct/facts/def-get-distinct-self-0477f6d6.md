# Fact 0477f6d6

Store id: 0b918374-856f-430d-b424-7d1739723149

## Text

```text
def get_distinct(self)
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
- posted_at: `2026-11-09T23:32:05.7732420+00:00`

## Data

```json
{
  "end_line": 1077,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1053,
  "symbol": "SQLCompiler.get_distinct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1053,"selector":"L1053-L1077","symbol":"SQLCompiler.get_distinct"}`

## Items

```json
[
  {
    "text": "Return a quoted list of fields to use in DISTINCT ON part of the query.",
    "locator": {
      "line": 1054
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_distinct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1077,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1053,
    "symbol": "SQLCompiler.get_distinct"
  },
  "id": "0b918374-856f-430d-b424-7d1739723149",
  "items": [
    {
      "locator": {
        "line": 1054
      },
      "text": "Return a quoted list of fields to use in DISTINCT ON part of the query."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.7732420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1053,
        "selector": "L1053-L1077",
        "symbol": "SQLCompiler.get_distinct"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "2edc3b9f-165e-4cdf-835d-e442b0988eba",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_distinct",
  "tags": [
    "entity:method"
  ],
  "text": "def get_distinct(self)"
}
```
