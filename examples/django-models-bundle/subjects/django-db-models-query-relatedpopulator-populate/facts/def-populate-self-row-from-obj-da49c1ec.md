# Fact da49c1ec

Store id: f47bc6dd-dcb3-4dbc-baf8-6a03720c3429

## Text

```text
def populate(self, row, from_obj)
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
- posted_at: `2026-11-09T23:32:04.8624860+00:00`

## Data

```json
{
  "end_line": 3087,
  "entity_kind": "method",
  "parent": "RelatedPopulator",
  "start_line": 3067,
  "symbol": "RelatedPopulator.populate"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":3067,"selector":"L3067-L3087","symbol":"RelatedPopulator.populate"}`

## Referenced by

None.

## Subject

[django/db/models/query::RelatedPopulator.populate](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 3087,
    "entity_kind": "method",
    "parent": "RelatedPopulator",
    "start_line": 3067,
    "symbol": "RelatedPopulator.populate"
  },
  "id": "f47bc6dd-dcb3-4dbc-baf8-6a03720c3429",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:04.8624860+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 3067,
        "selector": "L3067-L3087",
        "symbol": "RelatedPopulator.populate"
      },
      "rel": "derived_from",
      "target": "django/db/models/query.py"
    }
  ],
  "status": "live",
  "subject_id": "46d5a0e2-3190-43c3-9fb2-7896545d5982",
  "subject_name": "django/db/models/query::RelatedPopulator.populate",
  "tags": [
    "entity:method"
  ],
  "text": "def populate(self, row, from_obj)"
}
```
