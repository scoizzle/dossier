# Fact 21f78cdd

Store id: a468b533-8c96-483d-b069-c21ca7b2ee37

## Text

```text
def __init__(self, lookup, queryset=None, to_attr=None)
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
- posted_at: `2026-11-09T23:44:56.2799540+00:00`

## Data

```json
{
  "end_line": 2592,
  "entity_kind": "method",
  "parent": "Prefetch",
  "start_line": 2571,
  "symbol": "Prefetch.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2571,"selector":"L2571-L2592","symbol":"Prefetch.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/query::Prefetch.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2592,
    "entity_kind": "method",
    "parent": "Prefetch",
    "start_line": 2571,
    "symbol": "Prefetch.__init__"
  },
  "id": "a468b533-8c96-483d-b069-c21ca7b2ee37",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.2799540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2571,
        "selector": "L2571-L2592",
        "symbol": "Prefetch.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a223d4fd-5921-4347-b378-fbd546cf443c",
  "subject_name": "django/db/models/query::Prefetch.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, lookup, queryset=None, to_attr=None)"
}
```
