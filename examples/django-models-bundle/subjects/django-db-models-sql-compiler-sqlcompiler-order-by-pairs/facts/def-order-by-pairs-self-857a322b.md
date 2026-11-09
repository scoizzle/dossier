# Fact 857a322b

Store id: 6fd00acc-9415-482c-bdff-866526df4047

## Text

```text
def _order_by_pairs(self)
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
- posted_at: `2026-11-09T23:32:05.7095640+00:00`

## Data

```json
{
  "end_line": 496,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 338,
  "symbol": "SQLCompiler._order_by_pairs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":338,"selector":"L338-L496","symbol":"SQLCompiler._order_by_pairs"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler._order_by_pairs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 496,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 338,
    "symbol": "SQLCompiler._order_by_pairs"
  },
  "id": "6fd00acc-9415-482c-bdff-866526df4047",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.7095640+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 338,
        "selector": "L338-L496",
        "symbol": "SQLCompiler._order_by_pairs"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "44d7c050-743e-4373-8aa2-6a88d79fbb2c",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler._order_by_pairs",
  "tags": [
    "entity:method"
  ],
  "text": "def _order_by_pairs(self)"
}
```
