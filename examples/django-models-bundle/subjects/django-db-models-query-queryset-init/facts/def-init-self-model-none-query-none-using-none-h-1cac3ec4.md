# Fact 1cac3ec4

Store id: dc8f5326-36ca-492f-af37-b06a213bb3a0

## Text

```text
def __init__(self, model=None, query=None, using=None, hints=None)
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
- posted_at: `2026-11-09T23:32:04.3028800+00:00`

## Data

```json
{
  "end_line": 383,
  "entity_kind": "method",
  "parent": "QuerySet",
  "start_line": 367,
  "symbol": "QuerySet.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":367,"selector":"L367-L383","symbol":"QuerySet.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/query::QuerySet.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 383,
    "entity_kind": "method",
    "parent": "QuerySet",
    "start_line": 367,
    "symbol": "QuerySet.__init__"
  },
  "id": "dc8f5326-36ca-492f-af37-b06a213bb3a0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.3028800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 367,
        "selector": "L367-L383",
        "symbol": "QuerySet.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "d4a8726a-abc1-4f1d-8fbd-add1d9b0937b",
  "subject_name": "django/db/models/query::QuerySet.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, model=None, query=None, using=None, hints=None)"
}
```
