# Fact 57f5a567

Store id: a11e9628-549c-4581-9814-22ef6f343286

## Text

```text
def __init__(self, query, connection, using, elide_empty=True)
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
- posted_at: `2026-11-09T23:44:57.3763360+00:00`

## Data

```json
{
  "end_line": 65,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 49,
  "symbol": "SQLCompiler.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":49,"selector":"L49-L65","symbol":"SQLCompiler.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 65,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 49,
    "symbol": "SQLCompiler.__init__"
  },
  "id": "a11e9628-549c-4581-9814-22ef6f343286",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.3763360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 49,
        "selector": "L49-L65",
        "symbol": "SQLCompiler.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "ac6dd2f5-f6ca-4102-8467-950528978553",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, query, connection, using, elide_empty=True)"
}
```
