# Fact e921863c

Store id: 3cdcc9cb-316e-4dbc-a921-1814e1a9c2e2

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
- posted_at: `2026-11-09T23:44:51.5209530+00:00`

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
  "id": "3cdcc9cb-316e-4dbc-a921-1814e1a9c2e2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5209530+00:00"
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
  "subject_id": "1e6fbfd2-533d-4603-b709-b60d5ba557f7",
  "subject_name": "django/db/models/fields/related::ForeignObject._check_to_fields_composite_pk",
  "tags": [
    "entity:method"
  ],
  "text": "def _check_to_fields_composite_pk(self)"
}
```
