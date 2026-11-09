# Fact 36d01a79

Store id: c98ea180-50b6-4d29-806e-bbd8df311858

## Text

```text
def __init__(self, klass_info, select, db, fetch_mode)
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
- posted_at: `2026-11-09T23:32:04.8589660+00:00`

## Data

```json
{
  "end_line": 3065,
  "entity_kind": "method",
  "parent": "RelatedPopulator",
  "start_line": 3000,
  "symbol": "RelatedPopulator.__init__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":3000,"selector":"L3000-L3065","symbol":"RelatedPopulator.__init__"}`

## Referenced by

None.

## Subject

[django/db/models/query::RelatedPopulator.__init__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 3065,
    "entity_kind": "method",
    "parent": "RelatedPopulator",
    "start_line": 3000,
    "symbol": "RelatedPopulator.__init__"
  },
  "id": "c98ea180-50b6-4d29-806e-bbd8df311858",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8589660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 3000,
        "selector": "L3000-L3065",
        "symbol": "RelatedPopulator.__init__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "2960bcb1-c1a0-4868-850c-808adba905b3",
  "subject_name": "django/db/models/query::RelatedPopulator.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, klass_info, select, db, fetch_mode)"
}
```
