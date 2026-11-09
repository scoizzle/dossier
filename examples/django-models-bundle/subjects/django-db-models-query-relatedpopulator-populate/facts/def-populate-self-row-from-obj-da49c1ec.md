# Fact da49c1ec

Store id: 79fba1f3-e165-4ab3-8067-84e102f06329

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
- posted_at: `2026-11-09T23:44:56.3408810+00:00`

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
  "id": "79fba1f3-e165-4ab3-8067-84e102f06329",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:56.3408810+00:00"
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
  "subject_id": "7623e7e9-feae-44b4-8746-f200513e1d9e",
  "subject_name": "django/db/models/query::RelatedPopulator.populate",
  "tags": [
    "entity:method"
  ],
  "text": "def populate(self, row, from_obj)"
}
```
