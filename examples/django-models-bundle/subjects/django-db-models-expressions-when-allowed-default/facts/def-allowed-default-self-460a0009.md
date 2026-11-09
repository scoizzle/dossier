# Fact 460a0009

Store id: f9e67a3a-dbf2-47a7-aa93-800966b559a9

## Text

```text
def allowed_default(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:31:55.9560120+00:00`

## Data

```json
{
  "end_line": 1713,
  "entity_kind": "method",
  "parent": "When",
  "start_line": 1711,
  "symbol": "When.allowed_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1711,"selector":"L1711-L1713","symbol":"When.allowed_default"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When.allowed_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1713,
    "entity_kind": "method",
    "parent": "When",
    "start_line": 1711,
    "symbol": "When.allowed_default"
  },
  "id": "f9e67a3a-dbf2-47a7-aa93-800966b559a9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9560120+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1711,
        "selector": "L1711-L1713",
        "symbol": "When.allowed_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "cb7a0405-1a62-4b57-bc19-d440619696a7",
  "subject_name": "django/db/models/expressions::When.allowed_default",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def allowed_default(self)"
}
```
