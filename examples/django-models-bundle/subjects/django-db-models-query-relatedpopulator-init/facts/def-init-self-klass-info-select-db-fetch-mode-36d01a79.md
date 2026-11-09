# Fact 36d01a79

Store id: 326f5f84-584f-4df1-9f6b-2c8395633a3f

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
- posted_at: `2026-11-09T22:39:49.9051440+00:00`

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
  "id": "326f5f84-584f-4df1-9f6b-2c8395633a3f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:49.9051440+00:00"
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
  "subject_id": "e8625100-7b8e-48f2-966e-361aef7bedb3",
  "subject_name": "django/db/models/query::RelatedPopulator.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, klass_info, select, db, fetch_mode)"
}
```
