# Fact e921863c

Store id: ae816e52-2b62-4b43-ac15-63e2b6dd978e

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
- posted_at: `2026-11-09T23:31:58.6722320+00:00`

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
  "id": "ae816e52-2b62-4b43-ac15-63e2b6dd978e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6722320+00:00"
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
  "subject_id": "48a2d790-a9ef-4e6b-ba0e-43cd28b4da70",
  "subject_name": "django/db/models/fields/related::ForeignObject._check_to_fields_composite_pk",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_to_fields_composite_pk(self)"
}
```
