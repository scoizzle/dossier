# Fact 21f78cdd

Store id: 651e985f-66c2-4fd6-a827-01a521741777

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
- posted_at: `2026-11-09T23:32:04.7865160+00:00`

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
  "id": "651e985f-66c2-4fd6-a827-01a521741777",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.7865160+00:00"
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
  "subject_id": "88af89a2-d6c5-48ea-b0bd-3fa6b626fb18",
  "subject_name": "django/db/models/query::Prefetch.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, lookup, queryset=None, to_attr=None)"
}
```
