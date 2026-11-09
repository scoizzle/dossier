# Fact e921863c

Store id: 4d9d3edc-abbc-4db5-a5ef-3d607419b023

## Text

```text
def _check_to_fields_composite_pk(self)
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
- posted_at: `2026-11-09T22:39:44.3169340+00:00`

## Data

```json
{
  "end_line": 671,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 642,
  "symbol": "ForeignObject._check_to_fields_composite_pk"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":642,"selector":"L642-L671","symbol":"ForeignObject._check_to_fields_composite_pk"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject._check_to_fields_composite_pk](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 671,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 642,
    "symbol": "ForeignObject._check_to_fields_composite_pk"
  },
  "id": "4d9d3edc-abbc-4db5-a5ef-3d607419b023",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3169340+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 642,
        "selector": "L642-L671",
        "symbol": "ForeignObject._check_to_fields_composite_pk"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "ac8a0bbc-016c-42f9-b80b-1261b83dfd9a",
  "subject_name": "django/db/models/fields/related::ForeignObject._check_to_fields_composite_pk",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_to_fields_composite_pk(self)"
}
```
