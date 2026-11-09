# Fact 08d345ba

Store id: 2ff16f44-f137-4e80-b200-2d440b3806a0

## Text

```text
def __xor__(self, other)
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
- posted_at: `2026-11-09T22:39:50.0686880+00:00`

## Data

```json
{
  "end_line": 94,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 93,
  "symbol": "Q.__xor__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":93,"selector":"L93-L94","symbol":"Q.__xor__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.__xor__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 94,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 93,
    "symbol": "Q.__xor__"
  },
  "id": "2ff16f44-f137-4e80-b200-2d440b3806a0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:50.0686880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 93,
        "selector": "L93-L94",
        "symbol": "Q.__xor__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "40417650-c737-4dd7-b66f-99d73a985167",
  "subject_name": "django/db/models/query_utils::Q.__xor__",
  "tags": [
    "entity:method"
  ],
  "text": "def __xor__(self, other)"
}
```
