# Fact 4936262b

Store id: a331b318-1c84-43ef-a136-736fdff65207

## Text

```text
def apply_converters(self, rows, converters)
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
- posted_at: `2026-11-09T23:32:05.8700690+00:00`

## Data

```json
{
  "end_line": 1563,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 1554,
  "symbol": "SQLCompiler.apply_converters"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1554,"selector":"L1554-L1563","symbol":"SQLCompiler.apply_converters"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.apply_converters](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1563,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 1554,
    "symbol": "SQLCompiler.apply_converters"
  },
  "id": "a331b318-1c84-43ef-a136-736fdff65207",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.8700690+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1554,
        "selector": "L1554-L1563",
        "symbol": "SQLCompiler.apply_converters"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "92d21e0c-4231-4008-88f7-f0009381382a",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.apply_converters",
  "tags": [
    "entity:method"
  ],
  "text": "def apply_converters(self, rows, converters)"
}
```
