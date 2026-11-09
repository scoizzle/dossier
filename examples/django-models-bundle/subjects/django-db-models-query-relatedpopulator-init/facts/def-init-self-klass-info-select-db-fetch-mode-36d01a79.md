# Fact 36d01a79

Store id: 73daac27-3aae-46a5-b633-9846ca51cb6a

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
- posted_at: `2026-11-09T23:44:56.3378320+00:00`

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
  "id": "73daac27-3aae-46a5-b633-9846ca51cb6a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.3378320+00:00"
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
  "subject_id": "705176b8-b68f-4076-9dbf-26a542b3bb26",
  "subject_name": "django/db/models/query::RelatedPopulator.__init__",
  "tags": [
    "entity:method"
  ],
  "text": "def __init__(self, klass_info, select, db, fetch_mode)"
}
```
