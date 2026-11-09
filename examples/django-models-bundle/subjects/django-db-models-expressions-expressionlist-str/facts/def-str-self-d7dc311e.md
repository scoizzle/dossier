# Fact d7dc311e

Store id: 3bdb2fb6-4583-49c6-a953-12690fc8467c

## Text

```text
def __str__(self)
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
- posted_at: `2026-11-09T23:31:55.9256320+00:00`

## Data

```json
{
  "end_line": 1498,
  "entity_kind": "method",
  "parent": "ExpressionList",
  "start_line": 1497,
  "symbol": "ExpressionList.__str__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1497,"selector":"L1497-L1498","symbol":"ExpressionList.__str__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::ExpressionList.__str__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1498,
    "entity_kind": "method",
    "parent": "ExpressionList",
    "start_line": 1497,
    "symbol": "ExpressionList.__str__"
  },
  "id": "3bdb2fb6-4583-49c6-a953-12690fc8467c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9256320+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1497,
        "selector": "L1497-L1498",
        "symbol": "ExpressionList.__str__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "62ef7a69-5927-4aa6-ab04-b72eeb003b16",
  "subject_name": "django/db/models/expressions::ExpressionList.__str__",
  "tags": [
    "entity:method"
  ],
  "text": "def __str__(self)"
}
```
