# Fact c48c6b92

Store id: 7122c1de-2f4c-443d-9e80-3b810576d631

## Text

```text
def __init__(self, expression, delimiter, **extra)
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
- posted_at: `2026-11-09T23:44:48.4048720+00:00`

## Data

```json
{
  "end_line": 381,
  "entity_kind": "method",
  "parent": "StringAgg",
  "start_line": 379,
  "symbol": "StringAgg.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":379,"selector":"L379-L381","symbol":"StringAgg.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::StringAgg.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 381,
    "entity_kind": "method",
    "parent": "StringAgg",
    "start_line": 379,
    "symbol": "StringAgg.__init__"
  },
  "id": "7122c1de-2f4c-443d-9e80-3b810576d631",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4048720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 379,
        "selector": "L379-L381",
        "symbol": "StringAgg.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "add344d5-02d0-4af8-8817-394c78ce19cb",
  "subject_name": "django/db/models/aggregates::StringAgg.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, expression, delimiter, **extra)"
}
```
